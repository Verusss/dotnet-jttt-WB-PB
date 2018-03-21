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
using System.Xml.Serialization;

namespace JTTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = list;
            label5.Text = "Podaj parametry.";
        }

        static BindingList<Quest> list = new BindingList<Quest>();

        //Dodawanie do listy
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || textBox4.Text == "" || comboBox1.Text=="Wyślij e-mailem" && textBox3.Text=="")
                label5.Text = "Brakuje parametrów.";
            else
            {
                Quest quest = new Quest();
                quest.create(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox4.Text);
                var hs = new HtmlSample(quest.q_url);
                quest.jpgPath = hs.FindByWord(quest.q_word, list.Count);
                if (quest.jpgPath=="")
                {
                    quest.jpgPath = "image.jpg";
                    label5.Text = "Nie znaleziono obrazu dla danego zadania. Dodano domyślny.";
                }
                else
                    label5.Text = "Dodano zadanie.";
                list.Add(quest);
            }       
        }

        //Wykonywanie wszystkich operacji
        private void button2_Click(object sender, EventArgs e)
        {
            if (list.Count==0)
                label5.Text = "Brak zadań do wykonania.";
            else
            {
                label5.Text = "Wykonuję.";
                IEnumerator<Quest> i = list.GetEnumerator();
                while (i.MoveNext())
                    i.Current.executeQuest();
            }
        }

        //Czyszczenie listy
        private void button3_Click(object sender, EventArgs e)
        {
            list.Clear();
        }

        //Serializacja
        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("list.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Quest>));
            serializer.Serialize(writer, list);
            writer.Flush();
            writer.Close();
        }

        //Deserializacja
        private void button5_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("list.xml");
            XmlSerializer deserializer = new XmlSerializer(typeof(BindingList<Quest>));
            object obj = deserializer.Deserialize(reader);
            list = (BindingList<Quest>)obj;
            listBox1.DataSource = list;
            reader.Close();
            File.Delete("list.xml");
        }
    }
}
