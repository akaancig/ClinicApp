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
    public partial class HastaSilGuncellePenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=il_ilce;Integrated Security=True");
        public HastaSilGuncellePenceresi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void enable_disable_boxes(bool value)
        {
            textBox_adi.Enabled = value;
            textBox_soyadi.Enabled = value;
            comboBox_il.Enabled = value;
            comboBox_ilce.Enabled = value;
            dateTimePicker_dgm.Enabled = value;
            richTextBox_adres.Enabled = value;
            comboBox_cinsiyet.Enabled = value;
            maskedTextBox_telefon.Enabled = value;
            textBox_kullanici.Enabled = value;
            textBox_sifre.Enabled = value;
        }

        private void HastaSilGuncellePenceresi_Load(object sender, EventArgs e)
        {
            label_uyari.Text = "";
            enable_disable_boxes(false);
            button_guncelle.Enabled = false;
            button_hastasil.Enabled = false;
            button_temizle.Enabled = false;

            con.Open();
            SqlCommand cmd = new SqlCommand("Select sehir from iller ;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox_il.Items.Add(reader["sehir"]);
            }
            con.Close();
        }

        private void button_getir_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from hastalar FULL OUTER JOIN login_hasta ON login_hasta.hasta_tc = hastalar.hasta_tc ;", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["hasta_tc"].ToString() == textBox_tc.Text)
                {
                    textBox_adi.Text = reader["hasta_isim"].ToString();
                    textBox_soyadi.Text = reader["hasta_soyisim"].ToString();
                    comboBox_il.Text = reader["hasta_il"].ToString();
                    comboBox_ilce.Text = reader["hasta_ilce"].ToString();
                    dateTimePicker_dgm.Text = reader["hasta_dtarihi"].ToString();
                    richTextBox_adres.Text = reader["hasta_adres"].ToString();
                    comboBox_cinsiyet.Text = reader["hasta_cinsiyet"].ToString();
                    maskedTextBox_telefon.Text = reader["hasta_telefon"].ToString();
                    textBox_kullanici.Text = reader["hasta_kullanici"].ToString();
                    textBox_sifre.Text = reader["hasta_sifre"].ToString();

                    label_uyari.Text = "";
                    enable_disable_boxes(true);
                    textBox_tc.Enabled = false;
                    button_guncelle.Enabled = true;
                    button_hastasil.Enabled = true;
                    button_temizle.Enabled = true;
                    break;
                }
                else
                {
                    label_uyari.Text = "TC bulunamadı !";
                }
            }
            conn.Close();
        }

        private void button_hastasil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"DELETE FROM hastalar WHERE hasta_tc = @tc ;";
            com.Parameters.AddWithValue("@tc", textBox_tc.Text);
            com.ExecuteNonQuery();

            com.CommandText = @"DELETE FROM login_hasta WHERE hasta_tc = @tc2 ;";
            com.Parameters.AddWithValue("@tc2", textBox_tc.Text);
            com.ExecuteNonQuery();

            label_uyari.Text = "Hasta Sİlindi ! ";
            button_temizle_Click(sender, e);
            conn.Close();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            Console.WriteLine(maskedTextBox_telefon.Text.Length);
            conn.Open();
            SqlCommand com = new SqlCommand();
            if (textBox_adi.Text.Length < 2)
                label_uyari.Text = "Ad en az iki karakter olmalı !";
            else if (textBox_soyadi.Text.Length < 2)
                label_uyari.Text = "Soyad en az iki karakter olamalı !";
            else if (comboBox_il.Text == "")
                label_uyari.Text = "İl boş bırakılamaz.";
            else if (comboBox_ilce.Text == "")
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
                label_uyari.Text = "Şifre alanı boş geçilemez";
            else
            {
                com.Connection = conn;
                com.CommandText = @"UPDATE hastalar SET hasta_isim = @isim, hasta_soyisim = @soyisim, hasta_dtarihi = @dtarihi, hasta_il = @il, hasta_ilce = @ilce, hasta_adres = @adres, hasta_cinsiyet = @cinsiyet, hasta_telefon = @telefon WHERE hasta_tc = @tc ;";
                com.Parameters.AddWithValue("@tc", textBox_tc.Text);
                com.Parameters.AddWithValue("@isim", textBox_adi.Text.ToUpper());
                com.Parameters.AddWithValue("@soyisim", textBox_soyadi.Text.ToUpper());
                com.Parameters.Add("@dtarihi", SqlDbType.Date).Value = dateTimePicker_dgm.Value.Date;
                com.Parameters.AddWithValue("@il", comboBox_il.Text.ToUpper());
                com.Parameters.AddWithValue("@ilce", comboBox_ilce.Text.ToUpper());
                com.Parameters.AddWithValue("@adres", richTextBox_adres.Text.ToUpper());
                com.Parameters.AddWithValue("@cinsiyet", comboBox_cinsiyet.Text.ToUpper());
                com.Parameters.Add("@telefon", SqlDbType.VarChar).Value = maskedTextBox_telefon.Text.ToString();
                com.ExecuteNonQuery();

                com.CommandText = @"UPDATE login_hasta SET hasta_kullanici = @kullanici, hasta_sifre = @sifre WHERE hasta_tc = @tc2;";

                com.Parameters.AddWithValue("@kullanici",textBox_kullanici.Text);
                com.Parameters.AddWithValue("@sifre", textBox_sifre.Text);
                com.Parameters.AddWithValue("@tc2", textBox_tc.Text);
                com.ExecuteNonQuery();
                button_guncelle.Enabled = false;
                button_hastasil.Enabled = false;
                button_temizle.Enabled = false;

                label_uyari.Text = "GÜNCELLENDİ ! ";
                button_temizle_Click(sender, e);
            }
            conn.Close();
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            textBox_tc.Text = "";
            textBox_adi.Text = "";
            textBox_soyadi.Text = "";
            comboBox_il.Text = "";
            comboBox_ilce.Text = "";
            dateTimePicker_dgm.Text = "";
            richTextBox_adres.Text = "";
            comboBox_cinsiyet.Text = "";
            maskedTextBox_telefon.Text = "";
            textBox_kullanici.Text = "";
            textBox_sifre.Text = "";

            enable_disable_boxes(false);
            textBox_tc.Enabled = true;
        }
        private void textBox_adi_soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ilce.Items.Clear();
            string id = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from iller ;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["sehir"].ToString() == comboBox_il.Text)
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
                    comboBox_ilce.Items.Add(reader["ilce"]);
                }
            }
            con.Close();
        }
    }
}
