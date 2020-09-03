namespace ClinicApp2
{
    partial class HastaPenceresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaPenceresi));
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_hastaekle = new System.Windows.Forms.Button();
            this.button_hastasilgun = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hasta_tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta_isimsoyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta_cinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta_dtarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta_telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta_adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta_il = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasta_ilce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hasta_tc,
            this.hasta_isimsoyisim,
            this.hasta_cinsiyet,
            this.hasta_dtarihi,
            this.hasta_telefon,
            this.hasta_adres,
            this.hasta_il,
            this.hasta_ilce});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 212);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button_hastaekle
            // 
            this.button_hastaekle.BackColor = System.Drawing.Color.LightSalmon;
            this.button_hastaekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_hastaekle.Location = new System.Drawing.Point(23, 36);
            this.button_hastaekle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button_hastaekle.Name = "button_hastaekle";
            this.button_hastaekle.Size = new System.Drawing.Size(240, 32);
            this.button_hastaekle.TabIndex = 5;
            this.button_hastaekle.Text = "Hasta Ekle";
            this.button_hastaekle.UseVisualStyleBackColor = false;
            this.button_hastaekle.Click += new System.EventHandler(this.button_hastaekle_Click);
            // 
            // button_hastasilgun
            // 
            this.button_hastasilgun.BackColor = System.Drawing.Color.LightSalmon;
            this.button_hastasilgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_hastasilgun.Location = new System.Drawing.Point(311, 36);
            this.button_hastasilgun.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.button_hastasilgun.Name = "button_hastasilgun";
            this.button_hastasilgun.Size = new System.Drawing.Size(240, 32);
            this.button_hastasilgun.TabIndex = 6;
            this.button_hastasilgun.Text = "Hasta Güncelle / Sil";
            this.button_hastasilgun.UseVisualStyleBackColor = false;
            this.button_hastasilgun.Click += new System.EventHandler(this.button_hastasilgun_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(247, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 26);
            this.textBox1.TabIndex = 22;
            // 
            // hasta_tc
            // 
            this.hasta_tc.Text = "TC";
            this.hasta_tc.Width = 80;
            // 
            // hasta_isimsoyisim
            // 
            this.hasta_isimsoyisim.Text = "İsim Soyisim";
            this.hasta_isimsoyisim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hasta_isimsoyisim.Width = 100;
            // 
            // hasta_cinsiyet
            // 
            this.hasta_cinsiyet.Text = "Cinsiyet";
            // 
            // hasta_dtarihi
            // 
            this.hasta_dtarihi.Text = "Doğum Tarihi";
            this.hasta_dtarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hasta_dtarihi.Width = 100;
            // 
            // hasta_telefon
            // 
            this.hasta_telefon.Text = "Telefon";
            this.hasta_telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hasta_telefon.Width = 100;
            // 
            // hasta_adres
            // 
            this.hasta_adres.Text = "Adres";
            this.hasta_adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hasta_adres.Width = 150;
            // 
            // hasta_il
            // 
            this.hasta_il.Text = "İL";
            // 
            // hasta_ilce
            // 
            this.hasta_ilce.Text = "İlçe";
            this.hasta_ilce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 102);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(545, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(506, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HastaPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(575, 345);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_hastasilgun);
            this.Controls.Add(this.button_hastaekle);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "HastaPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaPenceresi";
            this.Load += new System.EventHandler(this.HastaPenceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_hastaekle;
        private System.Windows.Forms.Button button_hastasilgun;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader hasta_tc;
        private System.Windows.Forms.ColumnHeader hasta_isimsoyisim;
        private System.Windows.Forms.ColumnHeader hasta_cinsiyet;
        private System.Windows.Forms.ColumnHeader hasta_dtarihi;
        private System.Windows.Forms.ColumnHeader hasta_telefon;
        private System.Windows.Forms.ColumnHeader hasta_adres;
        private System.Windows.Forms.ColumnHeader hasta_il;
        private System.Windows.Forms.ColumnHeader hasta_ilce;
    }
}