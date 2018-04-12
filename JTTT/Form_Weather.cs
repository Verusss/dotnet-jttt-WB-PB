using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            string City = textBox1.Text;
            City = replace_Polish_Charakters(City);
            string json;
            using (var wc = new WebClient())
            {
                json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" + City + "&appid=7ad1f6088aa81ee7d1f348c2370adaf7");
                Console.WriteLine(json);
            }
            WeatherInfo WeatherNow = JsonConvert.DeserializeObject<WeatherInfo>(json);
            label2.Text = $"Temperatura w {City} wynosi teraz {WeatherNow.Main.Temp-273} st. Celcjusza. Prędkość wiatru wynosi {WeatherNow.Wind.Speed} m/s, a ciśnienie {WeatherNow.Main.Pressure} hPa.";
            string IconUrl = "http://openweathermap.org/img/w/" + WeatherNow.Weather[0].Icon + ".png";
            string IconPath = WeatherNow.Weather[0].Icon + ".png";
            var hs = new HtmlSample(IconUrl);
            WebClient IconClient = new WebClient();
            IconClient.DownloadFile(IconUrl, IconPath);
            pictureBox1.ImageLocation = IconPath;
        }

        public string replace_Polish_Charakters(string City)
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
