using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JTTT
{
    class WeatherManager
    {
        public string json { get; set; }
        public string City { get; set; }
        public WeatherManager(string CityName)
        {
            City = CityName;
        }
        
        public void downloadJson()
        {
            using (var wc = new WebClient())
            {
                json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" + City + "&appid=7ad1f6088aa81ee7d1f348c2370adaf7");
                Console.WriteLine(json);
            }
        }

        public string replace_Polish_Charakters()
        {
            City = City.Replace("ą", "a");
            City = City.Replace("ć", "c");
            City = City.Replace("ę", "e");
            City = City.Replace("ł", "l");
            City = City.Replace("ń", "n");
            City = City.Replace("ó", "o");
            City = City.Replace("ś", "s");
            City = City.Replace("ź", "z");
            City = City.Replace("ż", "z");
            City = City.Replace("Ł", "L");
            City = City.Replace("Ć", "C");
            City = City.Replace("Ś", "S");
            City = City.Replace("Ź", "Z");
            City = City.Replace("Ż", "Z");
            return City;
        }
    }
}
