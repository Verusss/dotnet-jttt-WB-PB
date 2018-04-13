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
            WeatherManager weatherManager = new WeatherManager(textBox1.Text);
            weatherManager.replace_Polish_Charakters();            
            weatherManager.downloadJson();
            WeatherInfo WeatherNow = JsonConvert.DeserializeObject<WeatherInfo>(weatherManager.json);
            label2.Text = $"Temperatura w {weatherManager.City} wynosi teraz {WeatherNow.Main.Temp-273} st. Celcjusza. Prędkość wiatru wynosi {WeatherNow.Wind.Speed} m/s, a ciśnienie {WeatherNow.Main.Pressure} hPa.";

            string IconUrl = "http://openweathermap.org/img/w/" + WeatherNow.Weather[0].Icon + ".png";
            string IconPath = WeatherNow.Weather[0].Icon + ".png";
            var hs = new HtmlSample(IconUrl);
            WebClient IconClient = new WebClient();
            IconClient.DownloadFile(IconUrl, IconPath);
            pictureBox1.ImageLocation = IconPath;
        }


    }
}
