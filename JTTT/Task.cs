using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit.Utils;

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

        public Task()
        {
            Url = "";
            Word = "";
            Mail = "";
            TaskType = "";
            JpgPath = "";
            TaskName = "";
        }

        public void Create(string _url, string _word, string _mail, string _type, string _name)
        {
            Url = _url;
            Word = _word;
            Mail = _mail;
            TaskType = _type;
            TaskName = _name;
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

        public void SendMail ()
        {

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Genowefa", "genowefa.strudel@gmail.com"));
            message.To.Add(new MailboxAddress("Test", Mail));
            message.Subject = "Obrazek na dziś!";
            var body = new TextPart("plain")
            {
                Text = @"Obrazek na dziś!"
            };

            var attachment = new MimePart("image", "jpg")
            {
                Content = new MimeContent(File.OpenRead(JpgPath), ContentEncoding.Default),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(JpgPath)
            };

            var multipart = new Multipart("mixed");
            multipart.Add(body);
            multipart.Add(attachment);

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
            JpgPath = hs.FindByWord(Word, wantedJpgPath);
        }

        public void ExecuteQuest()
        {
            UpdateImagePath();
            if (JpgPath != "")
            {
                if (TaskType == "Wyślij e-mailem")
                    SendMail();
                else if (TaskType == "Wyświetl obraz")
                    ShowImage();
            }
        }

        public override string ToString()
        {
            return $"taskName:{TaskName}, url:{Url}, word:{Word}, taskType:{TaskType}, mail:{Mail}, jpgPath:{JpgPath}";
        }
    }
}