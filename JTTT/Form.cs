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
        DbManager dbmgr = new DbManager();
        static BindingList<Task> list = new BindingList<Task>();
        Logger logger = new Logger();

        public FormMain()
        {
            InitializeComponent();
            list = dbmgr.GetBindingList();
            listBox_listaZadania.DataSource = list;
            label_komunikat.Text = "Podaj parametry.";
            //dbmgr.AddExamples();
            logger.Log("Rozpoczęto działanie programu.");
        }

        //Dodawanie do listy
        private void button_dodajDoListy_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Slowo" && (textBox_url.Text == "" 
                || textBox_slowo.Text == "" || comboBox_akcja.Text == "" || textBox_nazwaZadania.Text == "" 
                || comboBox_akcja.Text == "Wyślij e-mailem" && textBox_email.Text == "") 

                || tabControl1.SelectedTab.Text == "Pogoda"  && comboBox_akcja.Text == "Wyślij e-mailem"
                && (textBox1.Text == "" || comboBox1.Text == "" || comboBox_akcja.Text == "" || textBox_email.Text == "" || textBox_nazwaZadania.Text == "")

                || tabControl1.SelectedTab.Text == "Pogoda" && comboBox_akcja.Text == "Wyświetl obraz" 
                && (textBox1.Text == "" || textBox_nazwaZadania.Text == "")
                )
            {
                label_komunikat.Text = "Brakuje parametrów.";
                logger.Log("Dodanie do listy nie powiodło się. Stan pól TextBox: URL = " + textBox_url.Text + "; Słowo = " + textBox_slowo.Text + "; Akcja = " + comboBox_akcja.Text + "; Nazwa = " + textBox_nazwaZadania.Text + "; Mail = " + textBox_email.Text);
            }
            else
            {
                Task quest = new Task();
                if (tabControl1.SelectedTab.Text == "Slowo")
                {
                    var hs = new HtmlSample(textBox_url.Text);
                    string testPage = hs.GetPageHtml();
                    if (testPage == "")
                    {
                        label_komunikat.Text = "Popraw url i spróbuj ponownie.";
                        logger.Log($"Niepoprawny url: {testPage}");
                        return;
                    }
                }

                try
                {
                    quest.Create(textBox_url.Text, textBox_slowo.Text, textBox_email.Text, comboBox_akcja.Text, textBox_nazwaZadania.Text, textBox1.Text, comboBox1.Text, numericUpDown1.Value, tabControl1.SelectedTab.Text);
                }
                catch (System.Net.WebException)
                {
                    label_komunikat.Text = "Upewnij się że podajesz poprawną nazwę miejscowości";
                    logger.Log("quest.Create -> System.Net.WebException");
                    return;
                }
                quest.JpgPath = "";
                list.Add(quest);
                dbmgr.AddTask(quest);
                label_komunikat.Text = "Dodano zadanie.";
                logger.Log($"Dodano zadanie: {quest}");

            }
        }

        //Wykonywanie wszystkich operacji
        private void button_wykonaj_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                label_komunikat.Text = "Brak zadań do wykonania.";
            }
            else
            {
                string text = "";
                label_komunikat.Text = "Wykonuję.";
                IEnumerator<Task> i = list.GetEnumerator();
                while (i.MoveNext())
                {
                    i.Current.ExecuteQuest();
                    /*if (i.Current.JpgPath != "")
                    {
                        text += i.Current.TaskName + ", ";
                    }*/
                }
                //text = text.Substring(0, text.Length - 2);
                //label_komunikat.Text = "Wykonano zadania: " + text + ";";
                logger.Log("Wykonano zadania: " + text + ";");
            }
        }

        //Czyszczenie listy
        private void button_czysc_Click(object sender, EventArgs e)
        {
            var index = listBox_listaZadania.SelectedIndex;
            if (index != -1)
            {
                Task t = list[index];
                list.RemoveAt(index);
                DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć to zadanie również z bazy danych?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dbmgr.DelTask(t);
                    logger.Log($"Usunięto zadanie z bazy danych: {t}");
                }
                label_komunikat.Text = $"Usunięto z listy zadanie o indeksie {index}.";
            }
            else
            {
                label_komunikat.Text = "Lista jest pusta.";
            }
        }

        //Serializacja
        private void button_serializacja_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                label_komunikat.Text = "Lista jest pusta.";
                return;
            }
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
            if (list.Count == 0)
            {
                label_komunikat.Text = "Lista jest pusta.";
                return;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Weather form = new Form_Weather();
            form.ShowDialog();
        }
    }
}
