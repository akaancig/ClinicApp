namespace ClinicApp2
{
    partial class DoktorPenceresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorPenceresi));
            this.listView1 = new System.Windows.Forms.ListView();
            this.randevu_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor_isimsoyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta_isimsoyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevu_tarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevu_saati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_randGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_randOlustur = new System.Windows.Forms.Button();
            this.button_randGecmis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.randevu_id,
            this.doktor_isimsoyisim,
            this.hasta_isimsoyisim,
            this.randevu_tarihi,
            this.randevu_saati});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 264);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(577, 252);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // randevu_id
            // 
            this.randevu_id.Text = "Randevu ID";
            this.randevu_id.Width = 80;
            // 
            // doktor_isimsoyisim
            // 
            this.doktor_isimsoyisim.Text = "Doktor";
            this.doktor_isimsoyisim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doktor_isimsoyisim.Width = 150;
            // 
            // hasta_isimsoyisim
            // 
            this.hasta_isimsoyisim.Text = "Hasta";
            this.hasta_isimsoyisim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hasta_isimsoyisim.Width = 150;
            // 
            // randevu_tarihi
            // 
            this.randevu_tarihi.Text = "Tarih";
            this.randevu_tarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.randevu_tarihi.Width = 100;
            // 
            // randevu_saati
            // 
            this.randevu_saati.Text = "Saat";
            this.randevu_saati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.randevu_saati.Width = 90;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(239, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button_randGirisi
            // 
            this.button_randGirisi.BackColor = System.Drawing.Color.LightSalmon;
            this.button_randGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_randGirisi.Location = new System.Drawing.Point(6, 62);
            this.button_randGirisi.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button_randGirisi.Name = "button_randGirisi";
            this.button_randGirisi.Size = new System.Drawing.Size(152, 32);
            this.button_randGirisi.TabIndex = 5;
            this.button_randGirisi.Text = "Randevu Girişi";
            this.button_randGirisi.UseVisualStyleBackColor = false;
            this.button_randGirisi.Click += new System.EventHandler(this.button_randGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "...";
            // 
            // button_randOlustur
            // 
            this.button_randOlustur.BackColor = System.Drawing.Color.LightSalmon;
            this.button_randOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_randOlustur.Location = new System.Drawing.Point(6, 23);
            this.button_randOlustur.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button_randOlustur.Name = "button_randOlustur";
            this.button_randOlustur.Size = new System.Drawing.Size(152, 32);
            this.button_randOlustur.TabIndex = 4;
            this.button_randOlustur.Text = "Randevu Oluştur";
            this.button_randOlustur.UseVisualStyleBackColor = false;
            this.button_randOlustur.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_randGecmis
            // 
            this.button_randGecmis.BackColor = System.Drawing.Color.LightSalmon;
            this.button_randGecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_randGecmis.Location = new System.Drawing.Point(6, 100);
            this.button_randGecmis.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button_randGecmis.Name = "button_randGecmis";
            this.button_randGecmis.Size = new System.Drawing.Size(152, 32);
            this.button_randGecmis.TabIndex = 11;
            this.button_randGecmis.Text = "Geçmiş Randevular";
            this.button_randGecmis.UseVisualStyleBackColor = false;
            this.button_randGecmis.Click += new System.EventHandler(this.button_randGecmis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 232);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(537, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hasta Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSalmon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(6, 68);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Hasta Güncelle / Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_hastaguncellesil_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSalmon;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(9, 68);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "İlaç Listesi";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSalmon;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(9, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 32);
            this.button5.TabIndex = 13;
            this.button5.Text = "Tanı Listesi";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_randOlustur);
            this.groupBox1.Controls.Add(this.button_randGirisi);
            this.groupBox1.Controls.Add(this.button_randGecmis);
            this.groupBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 138);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(233, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 109);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(442, 86);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 109);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diğer";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // DoktorPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(577, 516);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "DoktorPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorPenceresi";
            this.Load += new System.EventHandler(this.DoktorPenceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_randGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_randOlustur;
        private System.Windows.Forms.ColumnHeader randevu_id;
        private System.Windows.Forms.ColumnHeader doktor_isimsoyisim;
        private System.Windows.Forms.ColumnHeader randevu_tarihi;
        private System.Windows.Forms.ColumnHeader randevu_saati;
        private System.Windows.Forms.Button button_randGecmis;
        private System.Windows.Forms.ColumnHeader hasta_isimsoyisim;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}