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
        static BindingList<Task> list = new BindingList<Task>();
        Logger logger = new Logger();

        public FormMain()
        {
            InitializeComponent();
            listBox_listaZadania.DataSource = list;
            label_komunikat.Text = "Podaj parametry.";
            logger.Log("Rozpoczęto działanie programu.");
        }

        //Dodawanie do listy
        private void button_dodajDoListy_Click(object sender, EventArgs e)
        {
            if (textBox_url.Text == "" || textBox_slowo.Text == "" || comboBox_akcja.Text == "" || textBox_nazwaZadania.Text == "" || comboBox_akcja.Text == "Wyślij e-mailem" && textBox_email.Text == "")
            {
                label_komunikat.Text = "Brakuje parametrów.";
                logger.Log("Dodanie do listy nie powiodło się. Stan pól TextBox: URL = " + textBox_url.Text + "; Słowo = " + textBox_slowo.Text + "; Akcja = " + comboBox_akcja.Text + "; Nazwa = " + textBox_nazwaZadania.Text + "; Mail = " + textBox_email.Text);
            }
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
                    logger.Log("Nie znaleziono obrazu. Dodano domyślny.");
                }
                else
                {
                    label_komunikat.Text = "Dodano zadanie.";
                    logger.Log("Dodano zadanie: " + textBox_nazwaZadania.Text);
                }
                list.Add(quest);
            }
        }

        //Wykonywanie wszystkich operacji
        private void button_wykonaj_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                label_komunikat.Text = "Brak zadań do wykonania.";
                logger.Log("Wykonaj => Nie ma zadań do wykonania.");
            }
            else
            {
                label_komunikat.Text = "Wykonuję.";
                IEnumerator<Task> i = list.GetEnumerator();
                while (i.MoveNext())
                    i.Current.ExecuteQuest();
                logger.Log("Wykonaj => Wykonano wszystkie zadania.");
            }
        }

        //Czyszczenie listy
        private void button_czysc_Click(object sender, EventArgs e)
        {  
            list.Clear();
            label_komunikat.Text = "Wyczyszczono.";
            logger.Log("Wyczyszczono listę.\n");
        }

        //Serializacja
        private void button_serializacja_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("list.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Task>));
            serializer.Serialize(writer, list);
            writer.Flush();
            writer.Close();
            label_komunikat.Text = "Zapisano.";
            logger.Log("Dane zostały zserializowane.");
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
            label_komunikat.Text = "Przywrócono z pliku.";
            logger.Log("Dane zostały zdeserializowane. Plik usunięto.");
        }
    }
}
