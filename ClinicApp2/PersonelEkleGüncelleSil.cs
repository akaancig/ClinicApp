using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicApp2
{
    public partial class PersonelEkleGüncelleSil : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");

        public PersonelEkleGüncelleSil()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select departman_isim from departmanlar ;", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox_e_dep.Items.Add(reader["departman_isim"]);
                comboBox_g_dep.Items.Add(reader["departman_isim"]);
                comboBox_s_dep.Items.Add(reader["departman_isim"]);
            }
            conn.Close();
            label_uyari1.Text = "";
            label_uyari2.Text = "";
            label_uyari3.Text = "";

            textBox_e_sifre.UseSystemPasswordChar = true;
            button_g_guncelle.Enabled = false;
            button_s_sil.Enabled = false;

            guncelleEnDis(false);
            silEnDis(false);
        }
        private void guncelleEnDis(Boolean a)
        {
            textBox_g_isim.Enabled = a;
            textBox_g_soyisim.Enabled = a;
            maskedTextBox_g_telefon.Enabled = a;
            textBox_g_mail.Enabled = a;
            richTextBox_g_adres.Enabled = a;
            textBox_g_kullanici.Enabled = a;
            textBox_g_sifre.Enabled = a;
            radioButton_g_erkek.Enabled = a;
            radioButton_g_kadin.Enabled = a;
            radioButton_g_diger.Enabled = a;
            comboBox_g_dep.Enabled = a;
            button_g_gstr.Enabled = a;
        }
        private void silEnDis(Boolean a)
        {
            textBox_s_isim.Enabled = a;
            textBox_s_soyisim.Enabled = a;
            maskedTextBox_s_telefon.Enabled = a;
            textBox_s_mail.Enabled = a;
            richTextBox_s_adres.Enabled = a;
            textBox_s_kullanici.Enabled = a;
            textBox_s_sifre.Enabled = a;
            radioButton_s_erkek.Enabled = a;
            radioButton_s_kadin.Enabled = a;
            radioButton_s_diger.Enabled = a;
            comboBox_s_dep.Enabled = a;
            button_s_gstr.Enabled = a;
        }
        private void sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void harf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void button_e_gstr_Click(object sender, EventArgs e)
        {
            if (textBox_e_sifre.UseSystemPasswordChar == false)
                textBox_e_sifre.UseSystemPasswordChar = true;
            else if (textBox_e_sifre.UseSystemPasswordChar == true)
                textBox_e_sifre.UseSystemPasswordChar = false;
        }

        private void button_g_gstr_Click(object sender, EventArgs e)
        {
            if (textBox_g_sifre.UseSystemPasswordChar == false)
                textBox_g_sifre.UseSystemPasswordChar = true;
            else if (textBox_g_sifre.UseSystemPasswordChar == true)
                textBox_g_sifre.UseSystemPasswordChar = false;
        }

        private void button_s_gstr_Click(object sender, EventArgs e)
        {
            if (textBox_s_sifre.UseSystemPasswordChar == false)
                textBox_s_sifre.UseSystemPasswordChar = true;
            else if (textBox_s_sifre.UseSystemPasswordChar == true)
                textBox_s_sifre.UseSystemPasswordChar = false;
        }
        public static bool TcDogrula(string tcKimlikNo)
        {
            Console.WriteLine(tcKimlikNo[0]);
            if (tcKimlikNo.Length == 11)
                return false;
            else if (tcKimlikNo[0] == 0)
                return false;

            return true;
        }

        private void button_e_kaydet_Click(object sender, EventArgs e)
        {
            label_uyari1.Text = "";
            int flag = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select personel_tc from personeller", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["personel_tc"].ToString() == textBox_e_tc.Text)
                {
                    flag = 1;
                    break;
                }
            }
            conn.Close();

            string emptyPhone = maskedTextBox_e_telefon.Text;
            if (textBox_e_tc.TextLength < 11)
                label_uyari1.Text = "TC no 11 hane olmalıdır.";
            else if (TcDogrula(textBox_e_tc.Text))
                label_uyari1.Text = "Hatalı TC !";
            else if (flag == 1)
                label_uyari1.Text = "Kayıtlı TC !";
            else if (textBox_e_isim.Text.Length < 2)
                label_uyari1.Text = "Ad en az iki karakter olmalı !";
            else if (textBox_e_soyisim.Text.Length < 2)
                label_uyari1.Text = "Soyad en az iki karakter olamalı !";
            else if ((!maskedTextBox_e_telefon.Text.Any(char.IsDigit)) || (maskedTextBox_e_telefon.Text.Length != 14))
                label_uyari1.Text = "Telefon alanı boş geçilemez";
            else if (textBox_e_mail.Text == "")
                label_uyari1.Text = "Mail alanı boş geçilemez";
            else if (richTextBox_e_adres.Text == "")
                label_uyari1.Text = "Adres boş bırakılamaz.";
            else if (radioButton_e_erkek.Checked == false && radioButton_e_kadin.Checked == false && radioButton_e_diger.Checked == false)
                label_uyari1.Text = "Cinsiyet boş bırakılamaz.";
            else if (comboBox_e_dep.Text == "")
                label_uyari1.Text = "Poliklinik boş bırakılamaz.";
            else if (textBox_e_kullanici.Text == "")
                label_uyari1.Text = "Kullanıcı adı boş bırakılamaz.";
            else if (textBox_e_sifre.Text == "")
                label_uyari1.Text = "şifre boş bırakılamaz.";
            else
            {
                string BolumKodu = "";
                conn.Open();
                cmd = new SqlCommand("select * from departmanlar", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["departman_isim"].ToString() == comboBox_e_dep.Text)
                    {
                        BolumKodu = reader["departman_kodu"].ToString();
                        break;
                    }
                }
                conn.Close();

                conn.Open();

                label_uyari1.Text = "";
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = @"INSERT INTO personeller (personel_tc, personel_isim, personel_soyisim, personel_telefon, personel_mail, personel_adres, personel_cinsiyet, personel_depkodu)" +
                    "VALUES(@tc, @isim, @soyisim, @telefon, @mail, @adres, @cinsiyet, @dkodu);";
                com.Parameters.AddWithValue("@tc", textBox_e_tc.Text);
                com.Parameters.AddWithValue("@isim", textBox_e_isim.Text.ToUpper());
                com.Parameters.AddWithValue("@soyisim", textBox_e_soyisim.Text.ToUpper());
                com.Parameters.Add("@telefon", SqlDbType.VarChar).Value = maskedTextBox_e_telefon.Text.ToString();
                com.Parameters.AddWithValue("@mail", textBox_e_mail.Text);
                com.Parameters.AddWithValue("@adres", richTextBox_e_adres.Text.ToUpper());
                if (radioButton_e_erkek.Checked == true) com.Parameters.AddWithValue("@cinsiyet", "ERKEK");
                else if (radioButton_e_kadin.Checked == true) com.Parameters.AddWithValue("@cinsiyet", "KADIN");
                else if (radioButton_e_diger.Checked == true) com.Parameters.AddWithValue("@cinsiyet", "DİĞER");
                com.Parameters.AddWithValue("@dkodu", BolumKodu);
                com.ExecuteNonQuery();

                com.CommandText = @"INSERT INTO login_personel (personel_tc, personel_kullanici, personel_sifre)" +
                    "VALUES(@tc2, @kullanici, @sifre);";
                com.Parameters.AddWithValue("@tc2", textBox_e_tc.Text);
                com.Parameters.AddWithValue("@kullanici", textBox_e_kullanici.Text);
                com.Parameters.AddWithValue("@sifre", textBox_e_sifre.Text);

                label_uyari1.Text = "Kaydedildi ! ";
                com.ExecuteNonQuery();

                textBox_e_tc.Text = "";
                textBox_e_isim.Text = "";
                textBox_e_soyisim.Text = "";
                maskedTextBox_e_telefon.Text = "";
                textBox_e_mail.Text = "";
                richTextBox_e_adres.Text = "";
                radioButton_e_erkek.Checked = false;
                radioButton_e_kadin.Checked = false;
                radioButton_e_diger.Checked = false;
                comboBox_e_dep.Text = "";
                textBox_e_kullanici.Text = "";
                textBox_e_sifre.Text = "";

                textBox_e_sifre.UseSystemPasswordChar = true;

                conn.Close();
            }
        }

        private void button_g_getir_Click(object sender, EventArgs e)
        {
            label_uyari2.Text = "";
            string BolumKodu = "";
            conn.Open();
            int flg = 0;
            SqlCommand cmd = new SqlCommand("select * from personeller", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["personel_tc"].ToString() == textBox_g_tc.Text)
                {
                    textBox_g_isim.Text = reader["personel_isim"].ToString();
                    textBox_g_soyisim.Text = reader["personel_soyisim"].ToString();
                    maskedTextBox_g_telefon.Text = reader["personel_telefon"].ToString();
                    textBox_g_mail.Text = reader["personel_mail"].ToString();
                    richTextBox_g_adres.Text = reader["personel_adres"].ToString();
                    if (reader["personel_cinsiyet"].ToString() == "ERKEK") radioButton_g_erkek.Checked = true;
                    else if (reader["personel_cinsiyet"].ToString() == "KADIN") radioButton_g_kadin.Checked = true;
                    else if (reader["personel_cinsiyet"].ToString() == "DİĞER") radioButton_g_diger.Checked = true;
                    BolumKodu = reader["personel_depkodu"].ToString();

                    textBox_g_tc.Enabled = false;
                    guncelleEnDis(true);
                    button_g_guncelle.Enabled = true;
                    flg = 1;
                    break;
                }
            }
            if (flg == 0)
            {
                label_uyari2.Text = "Kullanıcı bulunamadı ! ";
                button_g_guncelle.Enabled = false;
            }
            reader.Close();

            SqlCommand newComm = new SqlCommand("select * from departmanlar", conn);
            SqlDataReader newRead = newComm.ExecuteReader();

            while (newRead.Read())
            {
                if (newRead["departman_kodu"].ToString() == BolumKodu && flg == 1)
                {
                    comboBox_g_dep.Text = newRead["departman_isim"].ToString();
                    break;
                }
            }
            newRead.Close();

            SqlCommand newCommand = new SqlCommand("select * from login_personel", conn);
            SqlDataReader newReader = newCommand.ExecuteReader();

            while (newReader.Read())
            {
                if (newReader["personel_tc"].ToString() == textBox_g_tc.Text && flg == 1)
                {
                    textBox_g_kullanici.Text = newReader["personel_kullanici"].ToString();
                    textBox_g_sifre.Text = newReader["personel_sifre"].ToString();
                    textBox_g_sifre.UseSystemPasswordChar = true;
                    break;
                }
            }

            conn.Close();
        }

        private void button_g_guncelle_Click(object sender, EventArgs e)
        {
            label_uyari2.Text = "";

            string emptyPhone = maskedTextBox_g_telefon.Text;
            if (textBox_g_isim.Text.Length < 2)
                label_uyari2.Text = "Ad en az iki karakter olmalı !";
            else if (textBox_g_soyisim.Text.Length < 2)
                label_uyari2.Text = "Soyad en az iki karakter olamalı !";
            else if ((!maskedTextBox_g_telefon.Text.Any(char.IsDigit)) || (maskedTextBox_g_telefon.Text.Length != 14))
                label_uyari2.Text = "Telefon alanı boş geçilemez";
            else if (textBox_g_mail.Text == "")
                label_uyari2.Text = "Mail alanı boş geçilemez";
            else if (richTextBox_g_adres.Text == "")
                label_uyari2.Text = "Adres boş bırakılamaz.";
            else if (radioButton_g_erkek.Checked == false && radioButton_g_kadin.Checked == false && radioButton_g_diger.Checked == false)
                label_uyari2.Text = "Cinsiyet boş bırakılamaz.";
            else if (comboBox_g_dep.Text == "")
                label_uyari2.Text = "Poliklinik boş bırakılamaz.";
            else if (textBox_g_kullanici.Text == "")
                label_uyari2.Text = "Kullanıcı adı boş bırakılamaz.";
            else if (textBox_g_sifre.Text == "")
                label_uyari2.Text = "şifre boş bırakılamaz.";
            else
            {
                string BolumKodu = "";
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from departmanlar", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["departman_isim"].ToString() == comboBox_g_dep.Text)
                    {
                        BolumKodu = reader["departman_kodu"].ToString();
                        break;
                    }
                }
                conn.Close();

                conn.Open();

                label_uyari1.Text = "";
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = @"UPDATE personeller SET personel_isim = @isim, personel_soyisim = @soyisim, personel_telefon = @telefon, " +
                    "personel_mail = @mail, personel_adres = @adres , personel_cinsiyet = @cinsiyet, personel_depkodu = @dkodu WHERE personel_tc = @tc; ";
                com.Parameters.AddWithValue("@tc", textBox_g_tc.Text);
                com.Parameters.AddWithValue("@isim", textBox_g_isim.Text.ToUpper());
                com.Parameters.AddWithValue("@soyisim", textBox_g_soyisim.Text.ToUpper());
                com.Parameters.Add("@telefon", SqlDbType.VarChar).Value = maskedTextBox_g_telefon.Text.ToString();
                com.Parameters.AddWithValue("@mail", textBox_g_mail.Text);
                com.Parameters.AddWithValue("@adres", richTextBox_g_adres.Text.ToUpper());
                if (radioButton_g_erkek.Checked == true) com.Parameters.AddWithValue("@cinsiyet", "ERKEK");
                else if (radioButton_g_kadin.Checked == true) com.Parameters.AddWithValue("@cinsiyet", "KADIN");
                else if (radioButton_g_diger.Checked == true) com.Parameters.AddWithValue("@cinsiyet", "DİĞER");
                com.Parameters.AddWithValue("@dkodu", BolumKodu);
                com.ExecuteNonQuery();

                com.CommandText = @"UPDATE login_personel SET personel_kullanici = @kullanici, personel_sifre = @sifre WHERE personel_tc = @tc2";
                com.Parameters.AddWithValue("@tc2", textBox_g_tc.Text);
                com.Parameters.AddWithValue("@kullanici", textBox_g_kullanici.Text);
                com.Parameters.AddWithValue("@sifre", textBox_g_sifre.Text);

                label_uyari2.Text = "Güncellendi ! ";
                com.ExecuteNonQuery();
                button_g_guncelle.Enabled = false;

                conn.Close();
            }

            textBox_g_tc.Enabled = true;
            textBox_g_tc.Text = "";
            button_g_getir.Enabled = true;
            guncelleEnDis(false);
        }

        private void button_s_getir_Click(object sender, EventArgs e)
        {
            label_uyari2.Text = "";
            string BolumKodu = "";
            conn.Open();
            int flg = 0;
            SqlCommand cmd = new SqlCommand("select * from personeller", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["personel_tc"].ToString() == textBox_s_tc.Text)
                {
                    textBox_s_isim.Text = reader["personel_isim"].ToString();
                    textBox_s_soyisim.Text = reader["personel_soyisim"].ToString();
                    maskedTextBox_s_telefon.Text = reader["personel_telefon"].ToString();
                    textBox_s_mail.Text = reader["personel_mail"].ToString();
                    richTextBox_s_adres.Text = reader["personel_adres"].ToString();
                    if (reader["personel_cinsiyet"].ToString() == "ERKEK") radioButton_s_erkek.Checked = true;
                    else if (reader["personel_cinsiyet"].ToString() == "KADIN") radioButton_s_kadin.Checked = true;
                    else if (reader["personel_cinsiyet"].ToString() == "DİĞER") radioButton_s_diger.Checked = true;
                    BolumKodu = reader["personel_depkodu"].ToString();

                    button_s_sil.Enabled = true;
                    label_uyari3.Text = "";
                    flg = 1;
                    break;
                }
            }
            reader.Close();

            SqlCommand newComm = new SqlCommand("select * from departmanlar", conn);
            SqlDataReader newRead = newComm.ExecuteReader();

            while (newRead.Read())
            {
                if (newRead["departman_kodu"].ToString() == BolumKodu && flg == 1)
                {
                    comboBox_s_dep.Text = newRead["departman_isim"].ToString();
                    break;
                }
            }
            newRead.Close();

            SqlCommand newCommand = new SqlCommand("select * from login_personel", conn);
            SqlDataReader newReader = newCommand.ExecuteReader();

            while (newReader.Read())
            {
                if (newReader["personel_tc"].ToString() == textBox_s_tc.Text && flg == 1)
                {
                    textBox_s_kullanici.Text = newReader["personel_kullanici"].ToString();
                    textBox_s_sifre.Text = newReader["personel_sifre"].ToString();
                    textBox_s_sifre.UseSystemPasswordChar = true;
                    break;
                }
            }
            if (flg == 0)
            {
                label_uyari3.Text = "Kayıt bulunamadı ! ";
                button_s_sil.Enabled = false;
            }
            conn.Close();
        }

        private void button_s_sil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"DELETE FROM personeller WHERE personel_tc = @tc ;";
            com.Parameters.AddWithValue("@tc", textBox_s_tc.Text);
            com.ExecuteNonQuery();

            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = @"DELETE FROM login_personel WHERE personel_tc = @tc ;";
            comm.Parameters.AddWithValue("@tc", textBox_s_tc.Text);
            comm.ExecuteNonQuery();

            label_uyari3.Text = "Personel Silindi ! ";
            textBox_s_tc.Text = "";
            button_s_sil.Enabled = false;
            conn.Close();
        }
    }
}
