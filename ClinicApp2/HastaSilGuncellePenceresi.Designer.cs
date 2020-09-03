namespace ClinicApp2
{
    partial class HastaSilGuncellePenceresi
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
            this.label_uyari = new System.Windows.Forms.Label();
            this.button_hastasil = new System.Windows.Forms.Button();
            this.richTextBox_adres = new System.Windows.Forms.RichTextBox();
            this.comboBox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_dgm = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_telefon = new System.Windows.Forms.MaskedTextBox();
            this.textBox_soyadi = new System.Windows.Forms.TextBox();
            this.textBox_adi = new System.Windows.Forms.TextBox();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_getir = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.comboBox_ilce = new System.Windows.Forms.ComboBox();
            this.comboBox_il = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.textBox_kullanici = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_uyari
            // 
            this.label_uyari.AutoSize = true;
            this.label_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_uyari.ForeColor = System.Drawing.Color.Red;
            this.label_uyari.Location = new System.Drawing.Point(13, 306);
            this.label_uyari.Name = "label_uyari";
            this.label_uyari.Size = new System.Drawing.Size(39, 18);
            this.label_uyari.TabIndex = 43;
            this.label_uyari.Text = "uyarı";
            // 
            // button_hastasil
            // 
            this.button_hastasil.BackColor = System.Drawing.Color.LightSalmon;
            this.button_hastasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_hastasil.Location = new System.Drawing.Point(356, 300);
            this.button_hastasil.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.button_hastasil.Name = "button_hastasil";
            this.button_hastasil.Size = new System.Drawing.Size(103, 31);
            this.button_hastasil.TabIndex = 42;
            this.button_hastasil.Text = "Hasta SİL";
            this.button_hastasil.UseVisualStyleBackColor = false;
            this.button_hastasil.Click += new System.EventHandler(this.button_hastasil_Click);
            // 
            // richTextBox_adres
            // 
            this.richTextBox_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_adres.Location = new System.Drawing.Point(464, 129);
            this.richTextBox_adres.MaxLength = 200;
            this.richTextBox_adres.Name = "richTextBox_adres";
            this.richTextBox_adres.Size = new System.Drawing.Size(192, 65);
            this.richTextBox_adres.TabIndex = 41;
            this.richTextBox_adres.Text = "";
            // 
            // comboBox_cinsiyet
            // 
            this.comboBox_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_cinsiyet.FormattingEnabled = true;
            this.comboBox_cinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN",
            "DİĞER"});
            this.comboBox_cinsiyet.Location = new System.Drawing.Point(133, 220);
            this.comboBox_cinsiyet.Name = "comboBox_cinsiyet";
            this.comboBox_cinsiyet.Size = new System.Drawing.Size(192, 28);
            this.comboBox_cinsiyet.TabIndex = 40;
            // 
            // dateTimePicker_dgm
            // 
            this.dateTimePicker_dgm.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_dgm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_dgm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dgm.Location = new System.Drawing.Point(133, 168);
            this.dateTimePicker_dgm.Name = "dateTimePicker_dgm";
            this.dateTimePicker_dgm.Size = new System.Drawing.Size(192, 26);
            this.dateTimePicker_dgm.TabIndex = 39;
            // 
            // maskedTextBox_telefon
            // 
            this.maskedTextBox_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox_telefon.Location = new System.Drawing.Point(133, 262);
            this.maskedTextBox_telefon.Mask = "(999) 000-0000";
            this.maskedTextBox_telefon.Name = "maskedTextBox_telefon";
            this.maskedTextBox_telefon.Size = new System.Drawing.Size(192, 26);
            this.maskedTextBox_telefon.TabIndex = 38;
            // 
            // textBox_soyadi
            // 
            this.textBox_soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_soyadi.Location = new System.Drawing.Point(133, 125);
            this.textBox_soyadi.MaxLength = 60;
            this.textBox_soyadi.Name = "textBox_soyadi";
            this.textBox_soyadi.Size = new System.Drawing.Size(192, 26);
            this.textBox_soyadi.TabIndex = 35;
            this.textBox_soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_adi_soyadi_KeyPress);
            // 
            // textBox_adi
            // 
            this.textBox_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_adi.Location = new System.Drawing.Point(133, 80);
            this.textBox_adi.MaxLength = 60;
            this.textBox_adi.Name = "textBox_adi";
            this.textBox_adi.Size = new System.Drawing.Size(192, 26);
            this.textBox_adi.TabIndex = 34;
            this.textBox_adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_adi_soyadi_KeyPress);
            // 
            // textBox_tc
            // 
            this.textBox_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_tc.Location = new System.Drawing.Point(133, 35);
            this.textBox_tc.MaxLength = 11;
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(192, 26);
            this.textBox_tc.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(387, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Adres : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Cinsiyet : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Telefon : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(387, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "İl : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(387, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "İlçe : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Soyadı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 30, 3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "T.C. No  : ";
            // 
            // button_getir
            // 
            this.button_getir.BackColor = System.Drawing.Color.LightSalmon;
            this.button_getir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_getir.Location = new System.Drawing.Point(331, 37);
            this.button_getir.Name = "button_getir";
            this.button_getir.Size = new System.Drawing.Size(50, 24);
            this.button_getir.TabIndex = 44;
            this.button_getir.Text = "Getir";
            this.button_getir.UseVisualStyleBackColor = false;
            this.button_getir.Click += new System.EventHandler(this.button_getir_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.Color.LightSalmon;
            this.button_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle.Location = new System.Drawing.Point(568, 300);
            this.button_guncelle.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(88, 31);
            this.button_guncelle.TabIndex = 45;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.BackColor = System.Drawing.Color.LightSalmon;
            this.button_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_temizle.Location = new System.Drawing.Point(475, 300);
            this.button_temizle.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(88, 31);
            this.button_temizle.TabIndex = 46;
            this.button_temizle.Text = "Temizle";
            this.button_temizle.UseVisualStyleBackColor = false;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // comboBox_ilce
            // 
            this.comboBox_ilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_ilce.FormattingEnabled = true;
            this.comboBox_ilce.Location = new System.Drawing.Point(464, 79);
            this.comboBox_ilce.Name = "comboBox_ilce";
            this.comboBox_ilce.Size = new System.Drawing.Size(192, 28);
            this.comboBox_ilce.TabIndex = 48;
            // 
            // comboBox_il
            // 
            this.comboBox_il.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_il.FormattingEnabled = true;
            this.comboBox_il.Location = new System.Drawing.Point(464, 34);
            this.comboBox_il.Name = "comboBox_il";
            this.comboBox_il.Size = new System.Drawing.Size(192, 28);
            this.comboBox_il.TabIndex = 47;
            this.comboBox_il.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_sifre);
            this.groupBox1.Controls.Add(this.textBox_kullanici);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(391, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 71);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Giriş Bilgileri";
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(125, 43);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(125, 20);
            this.textBox_sifre.TabIndex = 3;
            // 
            // textBox_kullanici
            // 
            this.textBox_kullanici.Location = new System.Drawing.Point(125, 15);
            this.textBox_kullanici.Name = "textBox_kullanici";
            this.textBox_kullanici.Size = new System.Drawing.Size(125, 20);
            this.textBox_kullanici.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(19, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Şifre : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(19, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kullanıcı : ";
            // 
            // HastaSilGuncellePenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(668, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_ilce);
            this.Controls.Add(this.comboBox_il);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_getir);
            this.Controls.Add(this.label_uyari);
            this.Controls.Add(this.button_hastasil);
            this.Controls.Add(this.richTextBox_adres);
            this.Controls.Add(this.comboBox_cinsiyet);
            this.Controls.Add(this.dateTimePicker_dgm);
            this.Controls.Add(this.maskedTextBox_telefon);
            this.Controls.Add(this.textBox_soyadi);
            this.Controls.Add(this.textBox_adi);
            this.Controls.Add(this.textBox_tc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HastaSilGuncellePenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaSilGuncellePenceresi";
            this.Load += new System.EventHandler(this.HastaSilGuncellePenceresi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_uyari;
        private System.Windows.Forms.Button button_hastasil;
        private System.Windows.Forms.RichTextBox richTextBox_adres;
        private System.Windows.Forms.ComboBox comboBox_cinsiyet;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dgm;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefon;
        private System.Windows.Forms.TextBox textBox_soyadi;
        private System.Windows.Forms.TextBox textBox_adi;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_getir;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.ComboBox comboBox_ilce;
        private System.Windows.Forms.ComboBox comboBox_il;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.TextBox textBox_kullanici;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}