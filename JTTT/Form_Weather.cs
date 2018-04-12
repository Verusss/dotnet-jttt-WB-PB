using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTTT
{
    public partial class Form_Weather : Form
    {
        public Form_Weather()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city = textBox1.Text;
            string json;
            using (var wc = new WebClient())
            {
                json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Wroclaw,pl&appid=7ad1f6088aa81ee7d1f348c2370adaf7");
                Console.WriteLine(json);
            }
            WeatherInfo Weather = JsonConvert.DeserializeObject<WeatherInfo>(json);
            Console.WriteLine("abc " + Weather.Main.Temp);
        }
    }
}
