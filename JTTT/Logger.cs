using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTTT
{
    class Logger
    {      
        public void Log(string logMessage)
        {
            using (StreamWriter logWriter = File.AppendText("JTTT.log"))
            {
                logWriter.Write("\nLog Entry: ");
                logWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                logWriter.WriteLine("\t:{0} ", logMessage);
                logWriter.WriteLine("------------------------");
            }
        }
    }
}
