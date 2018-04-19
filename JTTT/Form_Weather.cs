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
            if (textBox1.Text == "")
                return;
            Run(textBox1.Text);
        }

        public void Run(string city)
        {
            WeatherManager mgr;
            try
            {
                mgr = new WeatherManager(city);
            }
            catch (System.Net.WebException)
            {
                label2.Text = "Nie znalaziono takiego miasta.";
                pictureBox1.Image = null;
                return;
            }
            WeatherInfo weatherInfo = mgr.weatherInfo;
            label2.Text = $"Temperatura w {weatherInfo.Name} wynosi teraz {weatherInfo.Main.Temp - 273} st. Celcjusza. Prędkość wiatru wynosi {weatherInfo.Wind.Speed} m/s, a ciśnienie {weatherInfo.Main.Pressure} hPa.";
            string IconUrl = "http://openweathermap.org/img/w/" + weatherInfo.Weather[0].Icon + ".png";
            string IconPath = weatherInfo.Weather[0].Icon + ".png";
            var hs = new HtmlSample(IconUrl);
            WebClient IconClient = new WebClient();
            IconClient.DownloadFile(IconUrl, IconPath);
            pictureBox1.ImageLocation = IconPath;
        }

        public Form_Weather(string city)
        {
            InitializeComponent();
            textBox1.Text = city;
            Run(city);
        }
    }
}
