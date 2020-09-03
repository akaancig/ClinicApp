namespace ClinicApp2
{
    partial class RandevuGirisiPenceresi
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
            this.label_hastatc = new System.Windows.Forms.Label();
            this.randevu_tarihi = new System.Windows.Forms.Label();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label_saat = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox_semp = new System.Windows.Forms.RichTextBox();
            this.comboBox_tani = new System.Windows.Forms.ComboBox();
            this.button_taniEkle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox_acik = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_ilacEkle = new System.Windows.Forms.Button();
            this.richTextBox_rece = new System.Windows.Forms.RichTextBox();
            this.comboBox_ilac = new System.Windows.Forms.ComboBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.label_uyari = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_hastatc
            // 
            this.label_hastatc.AutoSize = true;
            this.label_hastatc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hastatc.Location = new System.Drawing.Point(10, 21);
            this.label_hastatc.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_hastatc.Name = "label_hastatc";
            this.label_hastatc.Size = new System.Drawing.Size(99, 20);
            this.label_hastatc.TabIndex = 0;
            this.label_hastatc.Text = "Hasta TC : ";
            // 
            // randevu_tarihi
            // 
            this.randevu_tarihi.AutoSize = true;
            this.randevu_tarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevu_tarihi.Location = new System.Drawing.Point(6, 26);
            this.randevu_tarihi.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.randevu_tarihi.Name = "randevu_tarihi";
            this.randevu_tarihi.Size = new System.Drawing.Size(144, 20);
            this.randevu_tarihi.TabIndex = 1;
            this.randevu_tarihi.Text = "Randevu Tarihi : ";
            // 
            // textBox_tc
            // 
            this.textBox_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_tc.Location = new System.Drawing.Point(115, 19);
            this.textBox_tc.MaxLength = 11;
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(161, 24);
            this.textBox_tc.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(282, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "GETİR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_saat
            // 
            this.label_saat.AutoSize = true;
            this.label_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_saat.Location = new System.Drawing.Point(6, 66);
            this.label_saat.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_saat.Name = "label_saat";
            this.label_saat.Size = new System.Drawing.Size(62, 20);
            this.label_saat.TabIndex = 5;
            this.label_saat.Text = "Saat : ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30"});
            this.comboBox1.Location = new System.Drawing.Point(74, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.groupBox1.Controls.Add(this.label_hastatc);
            this.groupBox1.Controls.Add(this.textBox_tc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 58);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.randevu_tarihi);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label_saat);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(212, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 22);
            this.button2.TabIndex = 7;
            this.button2.Text = "GETİR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox_semp);
            this.groupBox3.Controls.Add(this.comboBox_tani);
            this.groupBox3.Controls.Add(this.button_taniEkle);
            this.groupBox3.Location = new System.Drawing.Point(379, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 167);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Semptomlar";
            // 
            // richTextBox_semp
            // 
            this.richTextBox_semp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_semp.Location = new System.Drawing.Point(3, 61);
            this.richTextBox_semp.MaxLength = 400;
            this.richTextBox_semp.Name = "richTextBox_semp";
            this.richTextBox_semp.Size = new System.Drawing.Size(355, 103);
            this.richTextBox_semp.TabIndex = 0;
            this.richTextBox_semp.Text = "";
            // 
            // comboBox_tani
            // 
            this.comboBox_tani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_tani.FormattingEnabled = true;
            this.comboBox_tani.Location = new System.Drawing.Point(6, 19);
            this.comboBox_tani.Name = "comboBox_tani";
            this.comboBox_tani.Size = new System.Drawing.Size(279, 24);
            this.comboBox_tani.TabIndex = 14;
            // 
            // button_taniEkle
            // 
            this.button_taniEkle.BackColor = System.Drawing.Color.LightSalmon;
            this.button_taniEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_taniEkle.Location = new System.Drawing.Point(291, 19);
            this.button_taniEkle.Name = "button_taniEkle";
            this.button_taniEkle.Size = new System.Drawing.Size(64, 24);
            this.button_taniEkle.TabIndex = 15;
            this.button_taniEkle.Text = "EKLE";
            this.button_taniEkle.UseVisualStyleBackColor = false;
            this.button_taniEkle.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox_acik);
            this.groupBox4.Location = new System.Drawing.Point(12, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 164);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Açıklama";
            // 
            // richTextBox_acik
            // 
            this.richTextBox_acik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_acik.Location = new System.Drawing.Point(3, 16);
            this.richTextBox_acik.MaxLength = 200;
            this.richTextBox_acik.Name = "richTextBox_acik";
            this.richTextBox_acik.Size = new System.Drawing.Size(355, 145);
            this.richTextBox_acik.TabIndex = 1;
            this.richTextBox_acik.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_ilacEkle);
            this.groupBox5.Controls.Add(this.richTextBox_rece);
            this.groupBox5.Controls.Add(this.comboBox_ilac);
            this.groupBox5.Location = new System.Drawing.Point(382, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(361, 167);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reçete";
            // 
            // button_ilacEkle
            // 
            this.button_ilacEkle.BackColor = System.Drawing.Color.LightSalmon;
            this.button_ilacEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ilacEkle.Location = new System.Drawing.Point(291, 21);
            this.button_ilacEkle.Name = "button_ilacEkle";
            this.button_ilacEkle.Size = new System.Drawing.Size(64, 24);
            this.button_ilacEkle.TabIndex = 17;
            this.button_ilacEkle.Text = "EKLE";
            this.button_ilacEkle.UseVisualStyleBackColor = false;
            this.button_ilacEkle.Click += new System.EventHandler(this.button_ilacEkle_Click);
            // 
            // richTextBox_rece
            // 
            this.richTextBox_rece.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_rece.Location = new System.Drawing.Point(3, 61);
            this.richTextBox_rece.MaxLength = 1000;
            this.richTextBox_rece.Name = "richTextBox_rece";
            this.richTextBox_rece.Size = new System.Drawing.Size(355, 103);
            this.richTextBox_rece.TabIndex = 2;
            this.richTextBox_rece.Text = "";
            // 
            // comboBox_ilac
            // 
            this.comboBox_ilac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_ilac.FormattingEnabled = true;
            this.comboBox_ilac.Location = new System.Drawing.Point(6, 21);
            this.comboBox_ilac.Name = "comboBox_ilac";
            this.comboBox_ilac.Size = new System.Drawing.Size(279, 24);
            this.comboBox_ilac.TabIndex = 16;
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.Color.LightSalmon;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Location = new System.Drawing.Point(559, 358);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(184, 31);
            this.button_kaydet.TabIndex = 12;
            this.button_kaydet.Text = "KAYDET";
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_uyari
            // 
            this.label_uyari.AutoSize = true;
            this.label_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_uyari.ForeColor = System.Drawing.Color.Red;
            this.label_uyari.Location = new System.Drawing.Point(12, 364);
            this.label_uyari.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_uyari.Name = "label_uyari";
            this.label_uyari.Size = new System.Drawing.Size(62, 20);
            this.label_uyari.TabIndex = 13;
            this.label_uyari.Text = "Saat : ";
            // 
            // RandevuGirisiPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(751, 398);
            this.Controls.Add(this.label_uyari);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "RandevuGirisiPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandevuGirisiPenceresi";
            this.Load += new System.EventHandler(this.RandevuGirisiPenceresi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hastatc;
        private System.Windows.Forms.Label randevu_tarihi;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_saat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox_semp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox_acik;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox_rece;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Label label_uyari;
        private System.Windows.Forms.ComboBox comboBox_tani;
        private System.Windows.Forms.Button button_taniEkle;
        private System.Windows.Forms.Button button_ilacEkle;
        private System.Windows.Forms.ComboBox comboBox_ilac;
    }
}