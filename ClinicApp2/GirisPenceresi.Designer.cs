namespace ClinicApp2
{
    partial class GirisPenceresi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisPenceresi));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_dr = new System.Windows.Forms.Button();
            this.textBox_sifredr = new System.Windows.Forms.TextBox();
            this.textBox_kullanicidr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_per = new System.Windows.Forms.Button();
            this.textBox_sifreper = new System.Windows.Forms.TextBox();
            this.textBox_kullaniciper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_girisi = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button_adm = new System.Windows.Forms.Button();
            this.textBox_sifreadm = new System.Windows.Forms.TextBox();
            this.textBox_kullaniciadm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hasta_girisi = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button_hasta = new System.Windows.Forms.Button();
            this.textBox_sifrehasta = new System.Windows.Forms.TextBox();
            this.textBox_kullanicihasta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.admin_girisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.hasta_girisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.admin_girisi);
            this.tabControl1.Controls.Add(this.hasta_girisi);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(72, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(9, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.button_dr);
            this.tabPage1.Controls.Add(this.textBox_sifredr);
            this.tabPage1.Controls.Add(this.textBox_kullanicidr);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(452, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Doktor Girişi ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(86, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "HATALI GİRİŞ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(215, 7);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // button_dr
            // 
            this.button_dr.BackColor = System.Drawing.Color.LightSalmon;
            this.button_dr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_dr.Location = new System.Drawing.Point(215, 248);
            this.button_dr.Margin = new System.Windows.Forms.Padding(2, 20, 2, 10);
            this.button_dr.Name = "button_dr";
            this.button_dr.Size = new System.Drawing.Size(130, 37);
            this.button_dr.TabIndex = 15;
            this.button_dr.Text = "GİRİŞ";
            this.button_dr.UseVisualStyleBackColor = false;
            this.button_dr.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_sifredr
            // 
            this.textBox_sifredr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifredr.Location = new System.Drawing.Point(215, 203);
            this.textBox_sifredr.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.textBox_sifredr.Name = "textBox_sifredr";
            this.textBox_sifredr.Size = new System.Drawing.Size(130, 23);
            this.textBox_sifredr.TabIndex = 14;
            this.textBox_sifredr.UseSystemPasswordChar = true;
            // 
            // textBox_kullanicidr
            // 
            this.textBox_kullanicidr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullanicidr.Location = new System.Drawing.Point(215, 149);
            this.textBox_kullanicidr.Margin = new System.Windows.Forms.Padding(15, 2, 75, 2);
            this.textBox_kullanicidr.Name = "textBox_kullanicidr";
            this.textBox_kullanicidr.Size = new System.Drawing.Size(130, 23);
            this.textBox_kullanicidr.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 24, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Şifre        : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(80, 146, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kullanıcı  : ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.button_per);
            this.tabPage2.Controls.Add(this.textBox_sifreper);
            this.tabPage2.Controls.Add(this.textBox_kullaniciper);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(452, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Personel Girişi ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(86, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "HATALI GİRİŞ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(215, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // button_per
            // 
            this.button_per.BackColor = System.Drawing.Color.LightSalmon;
            this.button_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_per.Location = new System.Drawing.Point(215, 248);
            this.button_per.Margin = new System.Windows.Forms.Padding(2, 20, 2, 10);
            this.button_per.Name = "button_per";
            this.button_per.Size = new System.Drawing.Size(130, 37);
            this.button_per.TabIndex = 15;
            this.button_per.Text = "GİRİŞ";
            this.button_per.UseVisualStyleBackColor = false;
            this.button_per.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_sifreper
            // 
            this.textBox_sifreper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifreper.Location = new System.Drawing.Point(215, 203);
            this.textBox_sifreper.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.textBox_sifreper.Name = "textBox_sifreper";
            this.textBox_sifreper.Size = new System.Drawing.Size(130, 23);
            this.textBox_sifreper.TabIndex = 14;
            this.textBox_sifreper.UseSystemPasswordChar = true;
            // 
            // textBox_kullaniciper
            // 
            this.textBox_kullaniciper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciper.Location = new System.Drawing.Point(215, 149);
            this.textBox_kullaniciper.Margin = new System.Windows.Forms.Padding(15, 2, 75, 2);
            this.textBox_kullaniciper.Name = "textBox_kullaniciper";
            this.textBox_kullaniciper.Size = new System.Drawing.Size(130, 23);
            this.textBox_kullaniciper.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 24, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Şifre        : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(85, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(80, 146, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kullanıcı  : ";
            // 
            // admin_girisi
            // 
            this.admin_girisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.admin_girisi.Controls.Add(this.label10);
            this.admin_girisi.Controls.Add(this.pictureBox4);
            this.admin_girisi.Controls.Add(this.button_adm);
            this.admin_girisi.Controls.Add(this.textBox_sifreadm);
            this.admin_girisi.Controls.Add(this.textBox_kullaniciadm);
            this.admin_girisi.Controls.Add(this.label11);
            this.admin_girisi.Controls.Add(this.label12);
            this.admin_girisi.Location = new System.Drawing.Point(4, 39);
            this.admin_girisi.Name = "admin_girisi";
            this.admin_girisi.Padding = new System.Windows.Forms.Padding(3);
            this.admin_girisi.Size = new System.Drawing.Size(452, 319);
            this.admin_girisi.TabIndex = 3;
            this.admin_girisi.Text = " Admin Girişi ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(86, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "HATALI GİRİŞ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(215, 7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 130);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // button_adm
            // 
            this.button_adm.BackColor = System.Drawing.Color.LightSalmon;
            this.button_adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_adm.Location = new System.Drawing.Point(215, 248);
            this.button_adm.Margin = new System.Windows.Forms.Padding(2, 20, 2, 10);
            this.button_adm.Name = "button_adm";
            this.button_adm.Size = new System.Drawing.Size(130, 37);
            this.button_adm.TabIndex = 23;
            this.button_adm.Text = "GİRİŞ";
            this.button_adm.UseVisualStyleBackColor = false;
            this.button_adm.Click += new System.EventHandler(this.button_adm_Click);
            // 
            // textBox_sifreadm
            // 
            this.textBox_sifreadm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifreadm.Location = new System.Drawing.Point(215, 203);
            this.textBox_sifreadm.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.textBox_sifreadm.Name = "textBox_sifreadm";
            this.textBox_sifreadm.Size = new System.Drawing.Size(130, 23);
            this.textBox_sifreadm.TabIndex = 22;
            this.textBox_sifreadm.UseSystemPasswordChar = true;
            // 
            // textBox_kullaniciadm
            // 
            this.textBox_kullaniciadm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullaniciadm.Location = new System.Drawing.Point(215, 149);
            this.textBox_kullaniciadm.Margin = new System.Windows.Forms.Padding(15, 2, 75, 2);
            this.textBox_kullaniciadm.Name = "textBox_kullaniciadm";
            this.textBox_kullaniciadm.Size = new System.Drawing.Size(130, 23);
            this.textBox_kullaniciadm.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(86, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 24, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Şifre        : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(85, 148);
            this.label12.Margin = new System.Windows.Forms.Padding(80, 146, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Kullanıcı  : ";
            // 
            // hasta_girisi
            // 
            this.hasta_girisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.hasta_girisi.Controls.Add(this.label13);
            this.hasta_girisi.Controls.Add(this.pictureBox5);
            this.hasta_girisi.Controls.Add(this.button_hasta);
            this.hasta_girisi.Controls.Add(this.textBox_sifrehasta);
            this.hasta_girisi.Controls.Add(this.textBox_kullanicihasta);
            this.hasta_girisi.Controls.Add(this.label14);
            this.hasta_girisi.Controls.Add(this.label15);
            this.hasta_girisi.Location = new System.Drawing.Point(4, 39);
            this.hasta_girisi.Name = "hasta_girisi";
            this.hasta_girisi.Padding = new System.Windows.Forms.Padding(3);
            this.hasta_girisi.Size = new System.Drawing.Size(452, 319);
            this.hasta_girisi.TabIndex = 4;
            this.hasta_girisi.Text = " Hasta Girişi ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(86, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "HATALI GİRİŞ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(215, 7);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 130);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // button_hasta
            // 
            this.button_hasta.BackColor = System.Drawing.Color.LightSalmon;
            this.button_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_hasta.Location = new System.Drawing.Point(215, 248);
            this.button_hasta.Margin = new System.Windows.Forms.Padding(2, 20, 2, 10);
            this.button_hasta.Name = "button_hasta";
            this.button_hasta.Size = new System.Drawing.Size(130, 37);
            this.button_hasta.TabIndex = 30;
            this.button_hasta.Text = "GİRİŞ";
            this.button_hasta.UseVisualStyleBackColor = false;
            this.button_hasta.Click += new System.EventHandler(this.button_hasta_Click);
            // 
            // textBox_sifrehasta
            // 
            this.textBox_sifrehasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifrehasta.Location = new System.Drawing.Point(215, 203);
            this.textBox_sifrehasta.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.textBox_sifrehasta.Name = "textBox_sifrehasta";
            this.textBox_sifrehasta.Size = new System.Drawing.Size(130, 23);
            this.textBox_sifrehasta.TabIndex = 29;
            this.textBox_sifrehasta.UseSystemPasswordChar = true;
            // 
            // textBox_kullanicihasta
            // 
            this.textBox_kullanicihasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullanicihasta.Location = new System.Drawing.Point(215, 149);
            this.textBox_kullanicihasta.Margin = new System.Windows.Forms.Padding(15, 2, 75, 2);
            this.textBox_kullanicihasta.Name = "textBox_kullanicihasta";
            this.textBox_kullanicihasta.Size = new System.Drawing.Size(130, 23);
            this.textBox_kullanicihasta.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(86, 202);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 24, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "Şifre        : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(85, 148);
            this.label15.Margin = new System.Windows.Forms.Padding(80, 146, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 24);
            this.label15.TabIndex = 26;
            this.label15.Text = "Kullanıcı  : ";
            // 
            // GirisPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 362);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GirisPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.GirisPenceresi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.admin_girisi.ResumeLayout(false);
            this.admin_girisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.hasta_girisi.ResumeLayout(false);
            this.hasta_girisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_dr;
        private System.Windows.Forms.TextBox textBox_sifredr;
        private System.Windows.Forms.TextBox textBox_kullanicidr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_per;
        private System.Windows.Forms.TextBox textBox_sifreper;
        private System.Windows.Forms.TextBox textBox_kullaniciper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage admin_girisi;
        private System.Windows.Forms.TabPage hasta_girisi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button_adm;
        private System.Windows.Forms.TextBox textBox_sifreadm;
        private System.Windows.Forms.TextBox textBox_kullaniciadm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button_hasta;
        private System.Windows.Forms.TextBox textBox_sifrehasta;
        private System.Windows.Forms.TextBox textBox_kullanicihasta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

