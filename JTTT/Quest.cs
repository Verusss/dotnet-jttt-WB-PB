using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.IO;
using MimeKit.Utils;

namespace JTTT
{
    class Quest
    {
        public string q_url;
        public string q_word;
        public string q_mail;
        public string questType;
        public string jpgPath;
        public string questName;

        public Quest(string url, string word, string mail, string task, string name)
        {
            q_url = url;
            q_word = word;
            q_mail = mail;
            questType = task;
            questName = name;
        }

        public void ShowImage(string path)
        {
            Form form = new Form();
            form.Show();
            PictureBox picture = new PictureBox();
            picture.ImageLocation = path;
            picture.Size = form.Size;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            form.Controls.Add(picture);
        }

        public void sendMail (string jpgPath)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Genowefa", "genowefa.strudel@gmail.com"));
            message.To.Add(new MailboxAddress("Test", q_mail));
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

        public void executeQuest()
        {
            if (questType == "Wyślij e-mailem")
                sendMail(jpgPath);
            else if (questType == "Wyświetl obraz")
                ShowImage(jpgPath);
        }

        public override string ToString()
        {
            string sQuest = questName;
            return sQuest;
        }
    }
}
