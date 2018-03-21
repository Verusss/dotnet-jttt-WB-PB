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
        }

        static BindingList<Quest> list = new BindingList<Quest>();
        

        private void button1_Click(object sender, EventArgs a)
        {
            /*Quest quest = new Quest(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox4.Text);
            var hs = new HtmlSample(quest.q_url);
            quest.jpgPath=hs.FindByWord(quest.q_word);
            quest.executeQuest();*/
        }

        //Dodawanie do listy - nie da się wyświetlić i wysłać równocześnie tego samego obrazu (jest już używany przez jakiś proces). 
        private void button6_Click(object sender, EventArgs e)
        {
            Quest quest = new Quest();
            quest.create(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox4.Text);
            var hs = new HtmlSample(quest.q_url);
            quest.jpgPath = hs.FindByWord(quest.q_word);
            list.Add(quest);
        }

        //Wykonywanie wszystkich operacji
        private void button2_Click(object sender, EventArgs e)
        {
            IEnumerator<Quest> i = list.GetEnumerator();
            while (i.MoveNext())
                i.Current.executeQuest();
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
