using System;

namespace JTTT
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.textBox_slowo = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_slowo = new System.Windows.Forms.Label();
            this.label_url = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.comboBox_akcja = new System.Windows.Forms.ComboBox();
            this.listBox_listaZadania = new System.Windows.Forms.ListBox();
            this.button_wykonajZadania = new System.Windows.Forms.Button();
            this.button_czyscZadania = new System.Windows.Forms.Button();
            this.button_serializacjaZadania = new System.Windows.Forms.Button();
            this.button_deserializacjaZadania = new System.Windows.Forms.Button();
            this.button_dodajDoListy = new System.Windows.Forms.Button();
            this.label_nazwaZadania = new System.Windows.Forms.Label();
            this.textBox_nazwaZadania = new System.Windows.Forms.TextBox();
            this.label_komunikat = new System.Windows.Forms.Label();
            this.label_komunikat1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(62, 35);
            this.textBox_url.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(271, 22);
            this.textBox_url.TabIndex = 0;
            // 
            // textBox_slowo
            // 
            this.textBox_slowo.Location = new System.Drawing.Point(62, 92);
            this.textBox_slowo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_slowo.Name = "textBox_slowo";
            this.textBox_slowo.Size = new System.Drawing.Size(271, 22);
            this.textBox_slowo.TabIndex = 1;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(117, 270);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(271, 22);
            this.textBox_email.TabIndex = 2;
            // 
            // label_slowo
            // 
            this.label_slowo.AutoSize = true;
            this.label_slowo.Location = new System.Drawing.Point(6, 92);
            this.label_slowo.Name = "label_slowo";
            this.label_slowo.Size = new System.Drawing.Size(49, 17);
            this.label_slowo.TabIndex = 3;
            this.label_slowo.Text = "Słowo:";
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(6, 35);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(40, 17);
            this.label_url.TabIndex = 4;
            this.label_url.Text = "URL:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(31, 270);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 17);
            this.label_email.TabIndex = 5;
            this.label_email.Text = "E-mail:";
            // 
            // comboBox_akcja
            // 
            this.comboBox_akcja.FormattingEnabled = true;
            this.comboBox_akcja.Items.AddRange(new object[] {
            "Wyślij e-mailem",
            "Wyświetl obraz"});
            this.comboBox_akcja.Location = new System.Drawing.Point(155, 225);
            this.comboBox_akcja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_akcja.Name = "comboBox_akcja";
            this.comboBox_akcja.Size = new System.Drawing.Size(193, 24);
            this.comboBox_akcja.TabIndex = 7;
            // 
            // listBox_listaZadania
            // 
            this.listBox_listaZadania.FormattingEnabled = true;
            this.listBox_listaZadania.HorizontalScrollbar = true;
            this.listBox_listaZadania.ItemHeight = 16;
            this.listBox_listaZadania.Location = new System.Drawing.Point(459, 38);
            this.listBox_listaZadania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_listaZadania.Name = "listBox_listaZadania";
            this.listBox_listaZadania.Size = new System.Drawing.Size(337, 196);
            this.listBox_listaZadania.TabIndex = 8;
            // 
            // button_wykonajZadania
            // 
            this.button_wykonajZadania.Location = new System.Drawing.Point(459, 241);
            this.button_wykonajZadania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_wykonajZadania.Name = "button_wykonajZadania";
            this.button_wykonajZadania.Size = new System.Drawing.Size(107, 30);
            this.button_wykonajZadania.TabIndex = 9;
            this.button_wykonajZadania.Text = "Wykonaj";
            this.button_wykonajZadania.UseVisualStyleBackColor = true;
            this.button_wykonajZadania.Click += new System.EventHandler(this.button_wykonaj_Click);
            // 
            // button_czyscZadania
            // 
            this.button_czyscZadania.Location = new System.Drawing.Point(572, 241);
            this.button_czyscZadania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_czyscZadania.Name = "button_czyscZadania";
            this.button_czyscZadania.Size = new System.Drawing.Size(87, 30);
            this.button_czyscZadania.TabIndex = 10;
            this.button_czyscZadania.Text = "Czyść";
            this.button_czyscZadania.UseVisualStyleBackColor = true;
            this.button_czyscZadania.Click += new System.EventHandler(this.button_czysc_Click);
            // 
            // button_serializacjaZadania
            // 
            this.button_serializacjaZadania.Location = new System.Drawing.Point(665, 241);
            this.button_serializacjaZadania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_serializacjaZadania.Name = "button_serializacjaZadania";
            this.button_serializacjaZadania.Size = new System.Drawing.Size(112, 30);
            this.button_serializacjaZadania.TabIndex = 11;
            this.button_serializacjaZadania.Text = "Serializacja";
            this.button_serializacjaZadania.UseVisualStyleBackColor = true;
            this.button_serializacjaZadania.Click += new System.EventHandler(this.button_serializacja_Click);
            // 
            // button_deserializacjaZadania
            // 
            this.button_deserializacjaZadania.Location = new System.Drawing.Point(665, 277);
            this.button_deserializacjaZadania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_deserializacjaZadania.Name = "button_deserializacjaZadania";
            this.button_deserializacjaZadania.Size = new System.Drawing.Size(112, 28);
            this.button_deserializacjaZadania.TabIndex = 12;
            this.button_deserializacjaZadania.Text = "Deserializacja";
            this.button_deserializacjaZadania.UseVisualStyleBackColor = true;
            this.button_deserializacjaZadania.Click += new System.EventHandler(this.button_deserializacja_Click);
            // 
            // button_dodajDoListy
            // 
            this.button_dodajDoListy.Location = new System.Drawing.Point(107, 354);
            this.button_dodajDoListy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_dodajDoListy.Name = "button_dodajDoListy";
            this.button_dodajDoListy.Size = new System.Drawing.Size(216, 33);
            this.button_dodajDoListy.TabIndex = 13;
            this.button_dodajDoListy.Text = "Dodaj do listy";
            this.button_dodajDoListy.UseVisualStyleBackColor = true;
            this.button_dodajDoListy.Click += new System.EventHandler(this.button_dodajDoListy_Click);
            // 
            // label_nazwaZadania
            // 
            this.label_nazwaZadania.AutoSize = true;
            this.label_nazwaZadania.Location = new System.Drawing.Point(3, 314);
            this.label_nazwaZadania.Name = "label_nazwaZadania";
            this.label_nazwaZadania.Size = new System.Drawing.Size(108, 17);
            this.label_nazwaZadania.TabIndex = 14;
            this.label_nazwaZadania.Text = "Nazwa zadania:";
            // 
            // textBox_nazwaZadania
            // 
            this.textBox_nazwaZadania.Location = new System.Drawing.Point(117, 311);
            this.textBox_nazwaZadania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_nazwaZadania.Name = "textBox_nazwaZadania";
            this.textBox_nazwaZadania.Size = new System.Drawing.Size(271, 22);
            this.textBox_nazwaZadania.TabIndex = 15;
            // 
            // label_komunikat
            // 
            this.label_komunikat.AutoSize = true;
            this.label_komunikat.Location = new System.Drawing.Point(504, 354);
            this.label_komunikat.Name = "label_komunikat";
            this.label_komunikat.Size = new System.Drawing.Size(13, 17);
            this.label_komunikat.TabIndex = 16;
            this.label_komunikat.Text = "-";
            // 
            // label_komunikat1
            // 
            this.label_komunikat1.AutoSize = true;
            this.label_komunikat1.Location = new System.Drawing.Point(455, 354);
            this.label_komunikat1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_komunikat1.Name = "label_komunikat1";
            this.label_komunikat1.Size = new System.Drawing.Size(41, 17);
            this.label_komunikat1.TabIndex = 17;
            this.label_komunikat1.Text = "Stan:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Pogoda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(51, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(361, 181);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_url);
            this.tabPage1.Controls.Add(this.textBox_slowo);
            this.tabPage1.Controls.Add(this.label_url);
            this.tabPage1.Controls.Add(this.label_slowo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(353, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Slowo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(353, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pogoda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "wyższa niż",
            "niższa niż"});
            this.comboBox1.Location = new System.Drawing.Point(100, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miasto: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(148, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_komunikat1);
            this.Controls.Add(this.label_komunikat);
            this.Controls.Add(this.textBox_nazwaZadania);
            this.Controls.Add(this.label_nazwaZadania);
            this.Controls.Add(this.button_dodajDoListy);
            this.Controls.Add(this.button_deserializacjaZadania);
            this.Controls.Add(this.button_serializacjaZadania);
            this.Controls.Add(this.button_czyscZadania);
            this.Controls.Add(this.button_wykonajZadania);
            this.Controls.Add(this.listBox_listaZadania);
            this.Controls.Add(this.comboBox_akcja);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_email);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.TextBox textBox_slowo;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_slowo;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.ComboBox comboBox_akcja;
        private System.Windows.Forms.ListBox listBox_listaZadania;
        private System.Windows.Forms.Button button_wykonajZadania;
        private System.Windows.Forms.Button button_czyscZadania;
        private System.Windows.Forms.Button button_serializacjaZadania;
        private System.Windows.Forms.Button button_deserializacjaZadania;
        private System.Windows.Forms.Button button_dodajDoListy;
        private System.Windows.Forms.Label label_nazwaZadania;
        private System.Windows.Forms.TextBox textBox_nazwaZadania;
        private System.Windows.Forms.Label label_komunikat;
        private System.Windows.Forms.Label label_komunikat1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}