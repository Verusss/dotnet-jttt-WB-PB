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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            listBox_listaZadania.DataSource = list;
            label_komunikat.Text = "Podaj parametry.";
        }

        static BindingList<Task> list = new BindingList<Task>();

        //Dodawanie do listy
        private void button_dodajDoListy_Click(object sender, EventArgs e)
        {
            if (textBox_url.Text == "" || textBox_slowo.Text == "" || comboBox_akcja.Text == "" || textBox_nazwaZadania.Text == "" || comboBox_akcja.Text == "Wyślij e-mailem" && textBox_email.Text == "")
                label_komunikat.Text = "Brakuje parametrów.";
            else
            {
                Task quest = new Task();
                quest.Create(textBox_url.Text, textBox_slowo.Text, textBox_email.Text, comboBox_akcja.Text, textBox_nazwaZadania.Text);
                var hs = new HtmlSample(quest.url);
                quest.jpgPath = hs.FindByWord(quest.word, list.Count);
                if (quest.jpgPath == "")
                {
                    quest.jpgPath = "image.jpg";
                    label_komunikat.Text = "Nie znaleziono obrazu dla danego zadania. Dodano domyślny.";
                }
                else
                    label_komunikat.Text = "Dodano zadanie.";
                list.Add(quest);
            }
        }

        //Wykonywanie wszystkich operacji
        private void button_wykonaj_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
                label_komunikat.Text = "Brak zadań do wykonania.";
            else
            {
                label_komunikat.Text = "Wykonuję.";
                IEnumerator<Task> i = list.GetEnumerator();
                while (i.MoveNext())
                    i.Current.ExecuteQuest();
            }
        }

        //Czyszczenie listy
        private void button_czysc_Click(object sender, EventArgs e)
        {
            list.Clear();
        }

        //Serializacja
        private void button_serializacja_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("list.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Task>));
            serializer.Serialize(writer, list);
            writer.Flush();
            writer.Close();
        }

        //Deserializacja
        private void button_deserializacja_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("list.xml");
            XmlSerializer deserializer = new XmlSerializer(typeof(BindingList<Task>));
            object obj = deserializer.Deserialize(reader);
            list = (BindingList<Task>)obj;
            listBox_listaZadania.DataSource = list;
            reader.Close();
            File.Delete("list.xml");
        }
    }
}
