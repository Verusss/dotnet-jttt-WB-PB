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
        public string url;
        public string word;
        public string mail;
        public string taskType;
        public string jpgPath;
        public string taskName;

        public Task()
        {
            url = "";
            word = "";
            mail = "";
            taskType = "";
            jpgPath = "";
            taskName = "";
        }

        public void Create(string _url, string _word, string _mail, string _type, string _name)
        {
            url = _url;
            word = _word;
            mail = _mail;
            taskType = _type;
            taskName = _name;
        }

        public void ShowImage()
        {
            Form form = new Form();
            PictureBox picture = new PictureBox();
            picture.ImageLocation = jpgPath;
            picture.Size = form.Size;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            form.Controls.Add(picture);
            form.Show();
        }

        public void SendMail ()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Genowefa", "genowefa.strudel@gmail.com"));
            message.To.Add(new MailboxAddress("Test", mail));
            message.Subject = "Obrazek na dziś!";
            var body = new TextPart("plain")
            {
                Text = @"Obrazek na dziś!"
            };

            var attachment = new MimePart("image", "jpg")
            {
                Content = new MimeContent(File.OpenRead(jpgPath), ContentEncoding.Default),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(jpgPath)
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

        public void ExecuteQuest()
        {
            if (taskType == "Wyślij e-mailem")
                SendMail();
            else if (taskType == "Wyświetl obraz")
                ShowImage();
        }

        public override string ToString()
        {
            string sQuest = taskName + " " + url + " " + word + " " + taskType + " " + mail;
            return sQuest;
        }
    }
}