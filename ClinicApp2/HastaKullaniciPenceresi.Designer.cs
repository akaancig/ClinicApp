namespace ClinicApp2
{
    partial class HastaKullaniciPenceresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKullaniciPenceresi));
            this.listView_randListesi = new System.Windows.Forms.ListView();
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bolum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_yeniRand = new System.Windows.Forms.Button();
            this.label_kullanici = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randevu_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_uyari = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_randListesi
            // 
            this.listView_randListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.randevu_id,
            this.tarih,
            this.saat,
            this.bolum,
            this.doktor});
            this.listView_randListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_randListesi.HideSelection = false;
            this.listView_randListesi.Location = new System.Drawing.Point(0, 114);
            this.listView_randListesi.Name = "listView_randListesi";
            this.listView_randListesi.Size = new System.Drawing.Size(446, 221);
            this.listView_randListesi.TabIndex = 0;
            this.listView_randListesi.UseCompatibleStateImageBehavior = false;
            this.listView_randListesi.View = System.Windows.Forms.View.Details;
            // 
            // tarih
            // 
            this.tarih.Text = "Tarih";
            this.tarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tarih.Width = 100;
            // 
            // saat
            // 
            this.saat.Text = "Saat";
            this.saat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saat.Width = 80;
            // 
            // bolum
            // 
            this.bolum.Text = "Poliklinik";
            this.bolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bolum.Width = 100;
            // 
            // doktor
            // 
            this.doktor.Text = "Doktor";
            this.doktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doktor.Width = 100;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(315, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button_sil
            // 
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Location = new System.Drawing.Point(398, 81);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(48, 27);
            this.button_sil.TabIndex = 2;
            this.button_sil.Text = "SİL !";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_yeniRand
            // 
            this.button_yeniRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_yeniRand.Location = new System.Drawing.Point(0, 81);
            this.button_yeniRand.Name = "button_yeniRand";
            this.button_yeniRand.Size = new System.Drawing.Size(114, 27);
            this.button_yeniRand.TabIndex = 3;
            this.button_yeniRand.Text = "Yeni Randevu";
            this.button_yeniRand.UseVisualStyleBackColor = true;
            this.button_yeniRand.Click += new System.EventHandler(this.button_yeniRand_Click);
            // 
            // label_kullanici
            // 
            this.label_kullanici.AutoSize = true;
            this.label_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullanici.ForeColor = System.Drawing.Color.Red;
            this.label_kullanici.Location = new System.Drawing.Point(12, 9);
            this.label_kullanici.Name = "label_kullanici";
            this.label_kullanici.Size = new System.Drawing.Size(65, 16);
            this.label_kullanici.TabIndex = 4;
            this.label_kullanici.Text = "kullanıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(279, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID : ";
            // 
            // randevu_id
            // 
            this.randevu_id.Text = "ID";
            // 
            // label_uyari
            // 
            this.label_uyari.AutoSize = true;
            this.label_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_uyari.ForeColor = System.Drawing.Color.Red;
            this.label_uyari.Location = new System.Drawing.Point(275, 49);
            this.label_uyari.Name = "label_uyari";
            this.label_uyari.Size = new System.Drawing.Size(34, 13);
            this.label_uyari.TabIndex = 6;
            this.label_uyari.Text = "uyari";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HastaKullaniciPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(446, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_uyari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_kullanici);
            this.Controls.Add(this.button_yeniRand);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView_randListesi);
            this.MaximizeBox = false;
            this.Name = "HastaKullaniciPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaKullaniciPenceresi";
            this.Load += new System.EventHandler(this.HastaKullaniciPenceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_randListesi;
        private System.Windows.Forms.ColumnHeader randevu_id;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader saat;
        private System.Windows.Forms.ColumnHeader bolum;
        private System.Windows.Forms.ColumnHeader doktor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_yeniRand;
        private System.Windows.Forms.Label label_kullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_uyari;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}