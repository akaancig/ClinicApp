namespace ClinicApp2
{
    partial class PersonelListelePenceresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelListelePenceresi));
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.listView_perTablo = new System.Windows.Forms.ListView();
            this.personel_tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personel_isimsoyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personel_departman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personel_cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personel_telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personel_mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox_iptal = new System.Windows.Forms.PictureBox();
            this.pictureBox_ara = new System.Windows.Forms.PictureBox();
            this.personel_adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_ekgünsil = new System.Windows.Forms.Button();
            this.pictureBox_yenile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iptal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yenile)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ara
            // 
            this.textBox_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ara.Location = new System.Drawing.Point(481, 21);
            this.textBox_ara.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(203, 26);
            this.textBox_ara.TabIndex = 27;
            // 
            // listView_perTablo
            // 
            this.listView_perTablo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.personel_tc,
            this.personel_isimsoyisim,
            this.personel_departman,
            this.personel_cinsiyet,
            this.personel_telefon,
            this.personel_mail,
            this.personel_adres});
            this.listView_perTablo.ForeColor = System.Drawing.Color.Maroon;
            this.listView_perTablo.HideSelection = false;
            this.listView_perTablo.Location = new System.Drawing.Point(12, 73);
            this.listView_perTablo.Name = "listView_perTablo";
            this.listView_perTablo.Size = new System.Drawing.Size(743, 366);
            this.listView_perTablo.TabIndex = 25;
            this.listView_perTablo.UseCompatibleStateImageBehavior = false;
            this.listView_perTablo.View = System.Windows.Forms.View.Details;
            // 
            // personel_tc
            // 
            this.personel_tc.Text = "TC";
            this.personel_tc.Width = 77;
            // 
            // personel_isimsoyisim
            // 
            this.personel_isimsoyisim.Text = "İsim Soyisim";
            this.personel_isimsoyisim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.personel_isimsoyisim.Width = 100;
            // 
            // personel_departman
            // 
            this.personel_departman.Text = "Departman";
            this.personel_departman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.personel_departman.Width = 100;
            // 
            // personel_cinsiyet
            // 
            this.personel_cinsiyet.Text = "Cinsiyet";
            this.personel_cinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // personel_telefon
            // 
            this.personel_telefon.Text = "Telefon";
            this.personel_telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.personel_telefon.Width = 100;
            // 
            // personel_mail
            // 
            this.personel_mail.Text = "Mail";
            this.personel_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.personel_mail.Width = 100;
            // 
            // pictureBox_iptal
            // 
            this.pictureBox_iptal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_iptal.Image")));
            this.pictureBox_iptal.Location = new System.Drawing.Point(729, 21);
            this.pictureBox_iptal.Name = "pictureBox_iptal";
            this.pictureBox_iptal.Size = new System.Drawing.Size(26, 26);
            this.pictureBox_iptal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_iptal.TabIndex = 29;
            this.pictureBox_iptal.TabStop = false;
            this.pictureBox_iptal.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_ara
            // 
            this.pictureBox_ara.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ara.Image")));
            this.pictureBox_ara.Location = new System.Drawing.Point(690, 22);
            this.pictureBox_ara.Name = "pictureBox_ara";
            this.pictureBox_ara.Size = new System.Drawing.Size(33, 26);
            this.pictureBox_ara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ara.TabIndex = 28;
            this.pictureBox_ara.TabStop = false;
            this.pictureBox_ara.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // personel_adres
            // 
            this.personel_adres.Text = "Adres";
            this.personel_adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.personel_adres.Width = 200;
            // 
            // button_ekgünsil
            // 
            this.button_ekgünsil.BackColor = System.Drawing.Color.LightSalmon;
            this.button_ekgünsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekgünsil.Location = new System.Drawing.Point(12, 21);
            this.button_ekgünsil.Name = "button_ekgünsil";
            this.button_ekgünsil.Size = new System.Drawing.Size(160, 27);
            this.button_ekgünsil.TabIndex = 30;
            this.button_ekgünsil.Text = " Ekle / Güncelle / Sil ";
            this.button_ekgünsil.UseVisualStyleBackColor = false;
            this.button_ekgünsil.Click += new System.EventHandler(this.button_ekgünsil_Click);
            // 
            // pictureBox_yenile
            // 
            this.pictureBox_yenile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_yenile.Image")));
            this.pictureBox_yenile.Location = new System.Drawing.Point(178, 21);
            this.pictureBox_yenile.Name = "pictureBox_yenile";
            this.pictureBox_yenile.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_yenile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_yenile.TabIndex = 31;
            this.pictureBox_yenile.TabStop = false;
            this.pictureBox_yenile.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PersonelListelePenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(767, 451);
            this.Controls.Add(this.pictureBox_yenile);
            this.Controls.Add(this.button_ekgünsil);
            this.Controls.Add(this.pictureBox_iptal);
            this.Controls.Add(this.pictureBox_ara);
            this.Controls.Add(this.textBox_ara);
            this.Controls.Add(this.listView_perTablo);
            this.MaximizeBox = false;
            this.Name = "PersonelListelePenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.PersonelListelePenceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iptal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yenile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_iptal;
        private System.Windows.Forms.PictureBox pictureBox_ara;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.ListView listView_perTablo;
        private System.Windows.Forms.ColumnHeader personel_tc;
        private System.Windows.Forms.ColumnHeader personel_isimsoyisim;
        private System.Windows.Forms.ColumnHeader personel_departman;
        private System.Windows.Forms.ColumnHeader personel_cinsiyet;
        private System.Windows.Forms.ColumnHeader personel_telefon;
        private System.Windows.Forms.ColumnHeader personel_mail;
        private System.Windows.Forms.ColumnHeader personel_adres;
        private System.Windows.Forms.Button button_ekgünsil;
        private System.Windows.Forms.PictureBox pictureBox_yenile;
    }
}