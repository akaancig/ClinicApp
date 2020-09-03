namespace ClinicApp2
{
    partial class PersonelPenceresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelPenceresi));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_randGecmis = new System.Windows.Forms.Button();
            this.button_randOlustur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_hastaEkle = new System.Windows.Forms.Button();
            this.button_hastaSilGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.randevu_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor_isimsoyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta_isimsoyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevu_tarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randevu_saati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(540, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_randGecmis);
            this.groupBox2.Controls.Add(this.button_randOlustur);
            this.groupBox2.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(319, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 107);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RANDEVU";
            // 
            // button_randGecmis
            // 
            this.button_randGecmis.BackColor = System.Drawing.Color.LightSalmon;
            this.button_randGecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_randGecmis.Location = new System.Drawing.Point(15, 57);
            this.button_randGecmis.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button_randGecmis.Name = "button_randGecmis";
            this.button_randGecmis.Size = new System.Drawing.Size(152, 32);
            this.button_randGecmis.TabIndex = 11;
            this.button_randGecmis.Text = "Geçmiş Randevular";
            this.button_randGecmis.UseVisualStyleBackColor = false;
            this.button_randGecmis.Click += new System.EventHandler(this.button_randGecmis_Click);
            // 
            // button_randOlustur
            // 
            this.button_randOlustur.BackColor = System.Drawing.Color.LightSalmon;
            this.button_randOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_randOlustur.Location = new System.Drawing.Point(15, 19);
            this.button_randOlustur.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button_randOlustur.Name = "button_randOlustur";
            this.button_randOlustur.Size = new System.Drawing.Size(152, 32);
            this.button_randOlustur.TabIndex = 4;
            this.button_randOlustur.Text = "Randevu Oluştur";
            this.button_randOlustur.UseVisualStyleBackColor = false;
            this.button_randOlustur.Click += new System.EventHandler(this.button_randOlustur_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_hastaEkle);
            this.groupBox3.Controls.Add(this.button_hastaSilGuncelle);
            this.groupBox3.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(67, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 107);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HASTA";
            // 
            // button_hastaEkle
            // 
            this.button_hastaEkle.BackColor = System.Drawing.Color.LightSalmon;
            this.button_hastaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_hastaEkle.Location = new System.Drawing.Point(6, 19);
            this.button_hastaEkle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button_hastaEkle.Name = "button_hastaEkle";
            this.button_hastaEkle.Size = new System.Drawing.Size(153, 32);
            this.button_hastaEkle.TabIndex = 3;
            this.button_hastaEkle.Text = "Hasta Ekle";
            this.button_hastaEkle.UseVisualStyleBackColor = false;
            this.button_hastaEkle.Click += new System.EventHandler(this.button_hastaEkle_Click);
            // 
            // button_hastaSilGuncelle
            // 
            this.button_hastaSilGuncelle.BackColor = System.Drawing.Color.LightSalmon;
            this.button_hastaSilGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_hastaSilGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_hastaSilGuncelle.Location = new System.Drawing.Point(6, 57);
            this.button_hastaSilGuncelle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button_hastaSilGuncelle.Name = "button_hastaSilGuncelle";
            this.button_hastaSilGuncelle.Size = new System.Drawing.Size(153, 32);
            this.button_hastaSilGuncelle.TabIndex = 7;
            this.button_hastaSilGuncelle.Text = "Hasta Güncelle / Sil";
            this.button_hastaSilGuncelle.UseVisualStyleBackColor = false;
            this.button_hastaSilGuncelle.Click += new System.EventHandler(this.button_hastaSilGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kullanıcı : Doktor1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 187);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(242, 187);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 26);
            this.textBox1.TabIndex = 13;
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
            this.listView1.Location = new System.Drawing.Point(0, 224);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 252);
            this.listView1.TabIndex = 12;
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
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 187);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PersonelPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(574, 476);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "PersonelPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelPenceresi";
            this.Load += new System.EventHandler(this.PersonelPenceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_randGecmis;
        private System.Windows.Forms.Button button_randOlustur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_hastaEkle;
        private System.Windows.Forms.Button button_hastaSilGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader randevu_id;
        private System.Windows.Forms.ColumnHeader doktor_isimsoyisim;
        private System.Windows.Forms.ColumnHeader hasta_isimsoyisim;
        private System.Windows.Forms.ColumnHeader randevu_tarihi;
        private System.Windows.Forms.ColumnHeader randevu_saati;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}