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
            listBox1.DataSource = list;
        }

        BindingList<Quest> list = new BindingList<Quest>();


        private void button1_Click(object sender, EventArgs a)
        {
            /*Quest quest = new Quest(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox4.Text);
            var hs = new HtmlSample(quest.q_url);
            quest.jpgPath=hs.FindByWord(quest.q_word);
            quest.executeQuest();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Quest quest = new Quest(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox4.Text);
            var hs = new HtmlSample(quest.q_url);
            quest.jpgPath = hs.FindByWord(quest.q_word);
            quest.executeQuest();
            list.Add(quest);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
