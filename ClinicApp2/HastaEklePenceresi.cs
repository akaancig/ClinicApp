using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp2
{
    public partial class HastaEklePenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=il_ilce;Integrated Security=True");
        public HastaEklePenceresi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void HastaEklePenceresi_Load(object sender, EventArgs e)
        {
            label_uyari.Text = "";

            con.Open();
            SqlCommand cmd = new SqlCommand("Select sehir from iller ;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["sehir"]);
            }
            con.Close();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            int flag = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select hasta_tc from hastalar", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["hasta_tc"].ToString() == textBox_tc.Text)
                {
                    flag = 1;
                    break;
                }
            }
            conn.Close();
            conn.Open();
            string emptyPhone = maskedTextBox_telefon.Text;
            if (textBox_tc.TextLength < 11)
                label_uyari.Text = "TC no 11 hane olmalıdır.";
            else if (flag == 1)
                label_uyari.Text = "Kayıtlı TC !";
            else if (textBox_adi.Text.Length < 2)
                label_uyari.Text = "Ad en az iki karakter olmalı !";
            else if (textBox_soyadi.Text.Length < 2)
                label_uyari.Text = "Soyad en az iki karakter olamalı !";
            else if (comboBox1.Text == "")
                label_uyari.Text = "İl boş bırakılamaz.";
            else if (comboBox2.Text == "")
                label_uyari.Text = "İlce boş bırakılamaz.";
            else if (richTextBox_adres.Text == "")
                label_uyari.Text = "Adres boş bırakılamaz.";
            else if (comboBox_cinsiyet.Text == "")
                label_uyari.Text = "Cinsiyet alanı boş geçilemez";
            else if ((!maskedTextBox_telefon.Text.Any(char.IsDigit)) || (maskedTextBox_telefon.Text.Length != 14))
                label_uyari.Text = "Telefon alanı boş geçilemez";
            else if(textBox_kullanici.Text == "")
                label_uyari.Text = "Kullanıcı alanı boş geçilemez";
            else if (textBox_sifre.Text == "")
                label_uyari.Text = "Sifre alanı boş geçilemez";
            else
            {
                label_uyari.Text = "";
                //SqlCommand com = new SqlCommand("INSERT INTO hastalar (hasta_tc, hasta_isim, hasta_soyisim, hasta_dtarihi, hasta_il, hasta_ilce, hasta_adres, hasta_cinsiyet, hasta_telefon)" +
                //    "VALUES(@tc, @isim, @soyisim, @dtarihi, @il, @ilce, @adres, @cinsiyet, @telefon)"
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = @"INSERT INTO hastalar (hasta_tc, hasta_isim, hasta_soyisim, hasta_dtarihi, hasta_il, hasta_ilce, hasta_adres, hasta_cinsiyet, hasta_telefon)" +
                    "VALUES(@tc, @isim, @soyisim, @dtarihi, @il, @ilce, @adres, @cinsiyet, @telefon);";
                com.Parameters.AddWithValue("@tc", textBox_tc.Text);
                com.Parameters.AddWithValue("@isim", textBox_adi.Text.ToUpper());
                com.Parameters.AddWithValue("@soyisim", textBox_soyadi.Text.ToUpper());
                com.Parameters.Add("@dtarihi", SqlDbType.Date).Value = dateTimePicker_dgm.Value.Date;
                com.Parameters.AddWithValue("@il", comboBox1.Text.ToUpper());
                com.Parameters.AddWithValue("@ilce", comboBox2.Text.ToUpper());
                com.Parameters.AddWithValue("@adres", richTextBox_adres.Text.ToUpper());
                com.Parameters.AddWithValue("@cinsiyet", comboBox_cinsiyet.Text.ToUpper());
                com.Parameters.Add("@telefon", SqlDbType.VarChar).Value = maskedTextBox_telefon.Text.ToString();

                label_uyari.Text = "Kaydedildi ! ";
                com.ExecuteNonQuery();

                com.CommandText = @"INSERT INTO login_hasta (hasta_kullanici, hasta_sifre, hasta_tc)" +
                    "VALUES(@kullanici, @sifre, @tc2);";
                com.Parameters.AddWithValue("@kullanici", textBox_kullanici.Text);
                com.Parameters.AddWithValue("@sifre", textBox_sifre.Text);
                com.Parameters.AddWithValue("@tc2", textBox_tc.Text);
                com.ExecuteNonQuery();
            }
            conn.Close();
        }
        private void textBox_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void textBox_adi_soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string id = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from iller ;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["sehir"].ToString() == comboBox1.Text)
                {
                    id = reader["id"].ToString();
                }
            }
            con.Close();

            con.Open();
            cmd = new SqlCommand("Select * from ilceler ;", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["sehir"].ToString() == id)
                {
                    comboBox2.Items.Add(reader["ilce"]);
                }
            }
            con.Close();
        }
    }
}
