using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JTTT
{
    public class WeatherManager
    {
        public string City;
        public string Json;
        public WeatherInfo weatherInfo;

        public WeatherManager(string CityName)
        {
            City = CityName;
            replace_Polish_Characters();
            using (var wc = new WebClient())
            {
                Json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" + City + "&appid=7ad1f6088aa81ee7d1f348c2370adaf7");
                weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(Json);
            }
            
        }

        public string replace_Polish_Characters()
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
