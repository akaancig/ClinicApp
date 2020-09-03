namespace ClinicApp2
{
    partial class DoktorListelePenceresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorListelePenceresi));
            this.pictureBox_yenile = new System.Windows.Forms.PictureBox();
            this.button_ekgünsil = new System.Windows.Forms.Button();
            this.pictureBox_iptal = new System.Windows.Forms.PictureBox();
            this.pictureBox_ara = new System.Windows.Forms.PictureBox();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.listView_perTablo = new System.Windows.Forms.ListView();
            this.doktor_tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor_isimsoyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor_departman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor_cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor_telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor_mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doktor_adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yenile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iptal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ara)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_yenile
            // 
            this.pictureBox_yenile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_yenile.Image")));
            this.pictureBox_yenile.Location = new System.Drawing.Point(178, 12);
            this.pictureBox_yenile.Name = "pictureBox_yenile";
            this.pictureBox_yenile.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_yenile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_yenile.TabIndex = 37;
            this.pictureBox_yenile.TabStop = false;
            this.pictureBox_yenile.Click += new System.EventHandler(this.pictureBox_yenile_Click);
            // 
            // button_ekgünsil
            // 
            this.button_ekgünsil.BackColor = System.Drawing.Color.LightSalmon;
            this.button_ekgünsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekgünsil.Location = new System.Drawing.Point(12, 12);
            this.button_ekgünsil.Name = "button_ekgünsil";
            this.button_ekgünsil.Size = new System.Drawing.Size(160, 27);
            this.button_ekgünsil.TabIndex = 36;
            this.button_ekgünsil.Text = " Ekle / Güncelle / Sil ";
            this.button_ekgünsil.UseVisualStyleBackColor = false;
            this.button_ekgünsil.Click += new System.EventHandler(this.button_ekgünsil_Click);
            // 
            // pictureBox_iptal
            // 
            this.pictureBox_iptal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_iptal.Image")));
            this.pictureBox_iptal.Location = new System.Drawing.Point(730, 13);
            this.pictureBox_iptal.Name = "pictureBox_iptal";
            this.pictureBox_iptal.Size = new System.Drawing.Size(26, 26);
            this.pictureBox_iptal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_iptal.TabIndex = 35;
            this.pictureBox_iptal.TabStop = false;
            this.pictureBox_iptal.Click += new System.EventHandler(this.pictureBox_iptal_Click);
            // 
            // pictureBox_ara
            // 
            this.pictureBox_ara.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ara.Image")));
            this.pictureBox_ara.Location = new System.Drawing.Point(691, 14);
            this.pictureBox_ara.Name = "pictureBox_ara";
            this.pictureBox_ara.Size = new System.Drawing.Size(33, 26);
            this.pictureBox_ara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ara.TabIndex = 34;
            this.pictureBox_ara.TabStop = false;
            this.pictureBox_ara.Click += new System.EventHandler(this.pictureBox_ara_Click);
            // 
            // textBox_ara
            // 
            this.textBox_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ara.Location = new System.Drawing.Point(482, 13);
            this.textBox_ara.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(203, 26);
            this.textBox_ara.TabIndex = 33;
            // 
            // listView_perTablo
            // 
            this.listView_perTablo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.doktor_tc,
            this.doktor_isimsoyisim,
            this.doktor_departman,
            this.doktor_cinsiyet,
            this.doktor_telefon,
            this.doktor_mail,
            this.doktor_adres});
            this.listView_perTablo.ForeColor = System.Drawing.Color.Maroon;
            this.listView_perTablo.HideSelection = false;
            this.listView_perTablo.Location = new System.Drawing.Point(12, 64);
            this.listView_perTablo.Name = "listView_perTablo";
            this.listView_perTablo.Size = new System.Drawing.Size(744, 366);
            this.listView_perTablo.TabIndex = 32;
            this.listView_perTablo.UseCompatibleStateImageBehavior = false;
            this.listView_perTablo.View = System.Windows.Forms.View.Details;
            // 
            // doktor_tc
            // 
            this.doktor_tc.Text = "TC";
            this.doktor_tc.Width = 77;
            // 
            // doktor_isimsoyisim
            // 
            this.doktor_isimsoyisim.Text = "İsim Soyisim";
            this.doktor_isimsoyisim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doktor_isimsoyisim.Width = 100;
            // 
            // doktor_departman
            // 
            this.doktor_departman.Text = "Poliklinik";
            this.doktor_departman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doktor_departman.Width = 100;
            // 
            // doktor_cinsiyet
            // 
            this.doktor_cinsiyet.Text = "Cinsiyet";
            this.doktor_cinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // doktor_telefon
            // 
            this.doktor_telefon.Text = "Telefon";
            this.doktor_telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doktor_telefon.Width = 100;
            // 
            // doktor_mail
            // 
            this.doktor_mail.Text = "Mail";
            this.doktor_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doktor_mail.Width = 100;
            // 
            // doktor_adres
            // 
            this.doktor_adres.Text = "Adres";
            this.doktor_adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doktor_adres.Width = 200;
            // 
            // DoktorListelePenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(768, 442);
            this.Controls.Add(this.pictureBox_yenile);
            this.Controls.Add(this.button_ekgünsil);
            this.Controls.Add(this.pictureBox_iptal);
            this.Controls.Add(this.pictureBox_ara);
            this.Controls.Add(this.textBox_ara);
            this.Controls.Add(this.listView_perTablo);
            this.MaximizeBox = false;
            this.Name = "DoktorListelePenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorListelePenceresi";
            this.Load += new System.EventHandler(this.DoktorListelePenceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yenile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iptal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_yenile;
        private System.Windows.Forms.Button button_ekgünsil;
        private System.Windows.Forms.PictureBox pictureBox_iptal;
        private System.Windows.Forms.PictureBox pictureBox_ara;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.ListView listView_perTablo;
        private System.Windows.Forms.ColumnHeader doktor_tc;
        private System.Windows.Forms.ColumnHeader doktor_isimsoyisim;
        private System.Windows.Forms.ColumnHeader doktor_departman;
        private System.Windows.Forms.ColumnHeader doktor_cinsiyet;
        private System.Windows.Forms.ColumnHeader doktor_telefon;
        private System.Windows.Forms.ColumnHeader doktor_mail;
        private System.Windows.Forms.ColumnHeader doktor_adres;
    }
}