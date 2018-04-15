using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit.Utils;
using System.Net;
using Newtonsoft.Json;

namespace JTTT
{
    public class Task
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Word { get; set; }
        public string Mail { get; set; }
        public string TaskType { get; set; }
        public string JpgPath { get; set; }
        public string TaskName { get; set; }
        public string City { get; set; }
        public string Json { get; set; }
        public string TypeTempHeight { get; set; }
        public decimal TempHeight { get; set; }
        public string ConditionType { get; set; }

        public Task()
        {
            Url = "";
            Word = "";
            Mail = "";
            TaskType = "";
            JpgPath = "";
            TaskName = "";
            City = "";
            Json = "";
            TypeTempHeight = "";
            TempHeight = 0;
            ConditionType = "";
        }
        public string downloadJson()
        {
            using (var wc = new WebClient())
            {
                Json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" + City + "&appid=7ad1f6088aa81ee7d1f348c2370adaf7");
                Console.WriteLine(Json);
            }
            return Json;
        }

        public void Create(string _url, string _word, string _mail, string _type, string _name, string _city, string _typeTemp, decimal _temp, string _conditionType)
        {
            Url = _url;
            Word = _word;
            Mail = _mail;
            TaskType = _type;
            TaskName = _name;
            if (_city!="")
            {
                City = _city;
                replace_Polish_Charakters();
                downloadJson();
                TypeTempHeight = _typeTemp;
                TempHeight = _temp;
            }
            ConditionType = _conditionType;
        }

        public void ShowImage()
        {
            Form form = new Form();
            PictureBox picture = new PictureBox();
            picture.ImageLocation = JpgPath;
            picture.Size = form.Size;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            form.Controls.Add(picture);
            form.Show();
        }

        public void SendMail (string _subject, string _text)
        {

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Genowefa", "genowefa.strudel@gmail.com"));
            message.To.Add(new MailboxAddress("Test", Mail));
            message.Subject = _subject;
            var body = new TextPart("plain")
            {
                Text = _text
            };

            var multipart = new Multipart("mixed");
            multipart.Add(body);

            if (ConditionType=="Slowo")
            {
                var attachment = new MimePart("image", "jpg")
                {
                    Content = new MimeContent(File.OpenRead(JpgPath), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(JpgPath)
                };
                multipart.Add(attachment);
            }

            message.Body = multipart;

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("genowefa.strudel@gmail.com", "123qw123");
                client.Send(message);
                client.Disconnect(true);
            }
        }

        public void UpdateImagePath()
        {
            string wantedJpgPath = TaskName + Id.ToString() + ".jpg";
            var hs = new HtmlSample(Url);
            JpgPath = hs.FindByWord(Word, wantedJpgPath, Url);
        }

        public void ExecuteQuest()
        {
            if (ConditionType=="Slowo")
            {
                UpdateImagePath();
                if (JpgPath != "")
                {
                    if (TaskType == "Wyślij e-mailem")
                        SendMail("Obrazek na dziś!", "Obrazek na dziś!");
                    else if (TaskType == "Wyświetl obraz")
                        ShowImage();
                }
            }
            else if (ConditionType=="Pogoda")
            {
                string Json = downloadJson();
                WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(Json);
                if (TypeTempHeight== "wyższa niż" && weatherInfo.Main.Temp > Convert.ToDouble(TempHeight) || TypeTempHeight == "niższa niż" && weatherInfo.Main.Temp < Convert.ToDouble(TempHeight))
                {
                    string weather = $"Temperatura wynosi dzisiaj {weatherInfo.Main.Temp-273} st. Celcjusza. Ciśnienie {weatherInfo.Main.Pressure} hPa."; 
                    if (TaskType == "Wyślij e-mailem")
                        SendMail("Pogoda na dziś!", weather);
                    Console.WriteLine(City);
                }             
            }
        }

        public override string ToString()
        {
            return $"Task Name: {TaskName}";//, url:{Url}, word:{Word}, taskType:{TaskType}, mail:{Mail}, jpgPath:{JpgPath}";
        }

        public void replace_Polish_Charakters()
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
        }
    }
}