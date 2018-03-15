using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.IO;
using MimeKit.Utils;

namespace JTTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowImage(string path)
        {
            Form form = new Form();
            form.Show();
            PictureBox picture = new PictureBox();
            picture.ImageLocation = path;
            picture.Size = form.Size;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            form.Controls.Add(picture);
        }

        private void button1_Click(object sender, EventArgs a)
        {
            string URL = textBox1.Text;
            string Word = textBox2.Text;
            string Mail = textBox3.Text;
            var hs = new HtmlSample(URL);
            hs.FindByWord(Word);
            string path = "image.jpg";
            if (comboBox1.Text == "Wyślij e-mailem")
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
                    Content = new MimeContent(File.OpenRead(path), ContentEncoding.Default),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(path)
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
            else if (comboBox1.Text == "Wyświetl obraz")
                ShowImage(path);
        }
           
    }
}
