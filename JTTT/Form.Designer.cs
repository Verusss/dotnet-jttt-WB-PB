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
            this.SuspendLayout();
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(88, 66);
            this.textBox_url.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(204, 20);
            this.textBox_url.TabIndex = 0;
            // 
            // textBox_slowo
            // 
            this.textBox_slowo.Location = new System.Drawing.Point(88, 104);
            this.textBox_slowo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_slowo.Name = "textBox_slowo";
            this.textBox_slowo.Size = new System.Drawing.Size(204, 20);
            this.textBox_slowo.TabIndex = 1;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(88, 219);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(204, 20);
            this.textBox_email.TabIndex = 2;
            // 
            // label_slowo
            // 
            this.label_slowo.AutoSize = true;
            this.label_slowo.Location = new System.Drawing.Point(22, 104);
            this.label_slowo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_slowo.Name = "label_slowo";
            this.label_slowo.Size = new System.Drawing.Size(41, 13);
            this.label_slowo.TabIndex = 3;
            this.label_slowo.Text = "Słowo:";
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(23, 68);
            this.label_url.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(32, 13);
            this.label_url.TabIndex = 4;
            this.label_url.Text = "URL:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(23, 219);
            this.label_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(38, 13);
            this.label_email.TabIndex = 5;
            this.label_email.Text = "E-mail:";
            // 
            // comboBox_akcja
            // 
            this.comboBox_akcja.FormattingEnabled = true;
            this.comboBox_akcja.Items.AddRange(new object[] {
            "Wyślij e-mailem",
            "Wyświetl obraz"});
            this.comboBox_akcja.Location = new System.Drawing.Point(111, 159);
            this.comboBox_akcja.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_akcja.Name = "comboBox_akcja";
            this.comboBox_akcja.Size = new System.Drawing.Size(146, 21);
            this.comboBox_akcja.TabIndex = 7;
            // 
            // listBox_listaZadania
            // 
            this.listBox_listaZadania.FormattingEnabled = true;
            this.listBox_listaZadania.Location = new System.Drawing.Point(344, 31);
            this.listBox_listaZadania.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_listaZadania.Name = "listBox_listaZadania";
            this.listBox_listaZadania.Size = new System.Drawing.Size(254, 160);
            this.listBox_listaZadania.TabIndex = 8;
            // 
            // button_wykonajZadania
            // 
            this.button_wykonajZadania.Location = new System.Drawing.Point(344, 196);
            this.button_wykonajZadania.Margin = new System.Windows.Forms.Padding(2);
            this.button_wykonajZadania.Name = "button_wykonajZadania";
            this.button_wykonajZadania.Size = new System.Drawing.Size(80, 24);
            this.button_wykonajZadania.TabIndex = 9;
            this.button_wykonajZadania.Text = "Wykonaj";
            this.button_wykonajZadania.UseVisualStyleBackColor = true;
            this.button_wykonajZadania.Click += new System.EventHandler(this.button_wykonaj_Click);
            // 
            // button_czyscZadania
            // 
            this.button_czyscZadania.Location = new System.Drawing.Point(429, 196);
            this.button_czyscZadania.Margin = new System.Windows.Forms.Padding(2);
            this.button_czyscZadania.Name = "button_czyscZadania";
            this.button_czyscZadania.Size = new System.Drawing.Size(65, 24);
            this.button_czyscZadania.TabIndex = 10;
            this.button_czyscZadania.Text = "Czyść";
            this.button_czyscZadania.UseVisualStyleBackColor = true;
            this.button_czyscZadania.Click += new System.EventHandler(this.button_czysc_Click);
            // 
            // button_serializacjaZadania
            // 
            this.button_serializacjaZadania.Location = new System.Drawing.Point(499, 196);
            this.button_serializacjaZadania.Margin = new System.Windows.Forms.Padding(2);
            this.button_serializacjaZadania.Name = "button_serializacjaZadania";
            this.button_serializacjaZadania.Size = new System.Drawing.Size(84, 24);
            this.button_serializacjaZadania.TabIndex = 11;
            this.button_serializacjaZadania.Text = "Serializacja";
            this.button_serializacjaZadania.UseVisualStyleBackColor = true;
            this.button_serializacjaZadania.Click += new System.EventHandler(this.button_serializacja_Click);
            // 
            // button_deserializacjaZadania
            // 
            this.button_deserializacjaZadania.Location = new System.Drawing.Point(499, 225);
            this.button_deserializacjaZadania.Margin = new System.Windows.Forms.Padding(2);
            this.button_deserializacjaZadania.Name = "button_deserializacjaZadania";
            this.button_deserializacjaZadania.Size = new System.Drawing.Size(84, 23);
            this.button_deserializacjaZadania.TabIndex = 12;
            this.button_deserializacjaZadania.Text = "Deserializacja";
            this.button_deserializacjaZadania.UseVisualStyleBackColor = true;
            this.button_deserializacjaZadania.Click += new System.EventHandler(this.button_deserializacja_Click);
            // 
            // button_dodajDoListy
            // 
            this.button_dodajDoListy.Location = new System.Drawing.Point(80, 288);
            this.button_dodajDoListy.Margin = new System.Windows.Forms.Padding(2);
            this.button_dodajDoListy.Name = "button_dodajDoListy";
            this.button_dodajDoListy.Size = new System.Drawing.Size(162, 27);
            this.button_dodajDoListy.TabIndex = 13;
            this.button_dodajDoListy.Text = "Dodaj do listy";
            this.button_dodajDoListy.UseVisualStyleBackColor = true;
            this.button_dodajDoListy.Click += new System.EventHandler(this.button_dodajDoListy_Click);
            // 
            // label_nazwaZadania
            // 
            this.label_nazwaZadania.AutoSize = true;
            this.label_nazwaZadania.Location = new System.Drawing.Point(2, 255);
            this.label_nazwaZadania.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nazwaZadania.Name = "label_nazwaZadania";
            this.label_nazwaZadania.Size = new System.Drawing.Size(83, 13);
            this.label_nazwaZadania.TabIndex = 14;
            this.label_nazwaZadania.Text = "Nazwa zadania:";
            // 
            // textBox_nazwaZadania
            // 
            this.textBox_nazwaZadania.Location = new System.Drawing.Point(88, 253);
            this.textBox_nazwaZadania.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nazwaZadania.Name = "textBox_nazwaZadania";
            this.textBox_nazwaZadania.Size = new System.Drawing.Size(204, 20);
            this.textBox_nazwaZadania.TabIndex = 15;
            // 
            // label_komunikat
            // 
            this.label_komunikat.AutoSize = true;
            this.label_komunikat.Location = new System.Drawing.Point(378, 288);
            this.label_komunikat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_komunikat.Name = "label_komunikat";
            this.label_komunikat.Size = new System.Drawing.Size(10, 13);
            this.label_komunikat.TabIndex = 16;
            this.label_komunikat.Text = "-";
            // 
            // label_komunikat1
            // 
            this.label_komunikat1.AutoSize = true;
            this.label_komunikat1.Location = new System.Drawing.Point(341, 288);
            this.label_komunikat1.Name = "label_komunikat1";
            this.label_komunikat1.Size = new System.Drawing.Size(32, 13);
            this.label_komunikat1.TabIndex = 17;
            this.label_komunikat1.Text = "Stan:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 334);
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
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.label_slowo);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_slowo);
            this.Controls.Add(this.textBox_url);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "FormMain";
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
    }
}