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
    public partial class AdminEkleSilGuncelle : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public AdminEkleSilGuncelle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            label_uyari1.Text = "";
            label_uyari2.Text = "";
            label_uyari3.Text = "";
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            label_uyari2.Text = "";
            label_uyari3.Text = "";
            int flag = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from login_admin", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (textBox_e_kullanici.Text == "" || textBox_e_sifre.Text == "")
                {
                    flag = 1;
                    label_uyari1.Text = "Boş olamaz.";
                    break;
                }
                if (reader["admin_kullanici"].ToString() == textBox_e_kullanici.Text)
                {
                    flag = 1;
                    label_uyari1.Text = "Kayıtlı Admin.";
                    break;
                }
            }
            conn.Close();
            if (flag == 1) return;
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"INSERT INTO login_admin (admin_kullanici, admin_sifre)" +
                "VALUES(@kullanici, @sifre);";
            com.Parameters.AddWithValue("@kullanici", textBox_e_kullanici.Text);
            com.Parameters.AddWithValue("@sifre", textBox_e_sifre.Text);

            label_uyari1.Text = "Kaydedildi ! ";
            com.ExecuteNonQuery();

            conn.Close();

        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            label_uyari1.Text = "";
            label_uyari3.Text = "";
            int flag = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from login_admin", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (textBox_g_kullanici.Text == "" || textBox_g_sifre.Text == "")
                {
                    flag = 2;
                    label_uyari2.Text = "Boş olamaz.";
                    break;
                }
                if (reader["admin_kullanici"].ToString() == textBox_g_kullanici.Text)
                {
                    flag = 1;
                    label_uyari2.Text = "";
                    break;
                }
            }
            if (flag == 0) label_uyari2.Text = "Bulunamadı.";
            conn.Close();
            if (flag == 0 || flag == 2) return;
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"UPDATE login_admin SET admin_sifre = @sifre WHERE admin_kullanici = @kullanici;";
            com.Parameters.AddWithValue("@kullanici", textBox_g_kullanici.Text);
            com.Parameters.AddWithValue("@sifre", textBox_g_sifre.Text);

            label_uyari2.Text = "Güncellendi ! ";
            com.ExecuteNonQuery();

            conn.Close();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            label_uyari1.Text = "";
            label_uyari2.Text = "";
            int flag = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from login_admin", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (textBox_s_kullanici.Text == "" || textBox_s_sifre.Text == "")
                {
                    flag = 2;
                    label_uyari3.Text = "Boş olamaz.";
                    break;
                }
                if (reader["admin_kullanici"].ToString() == textBox_s_kullanici.Text  && reader["admin_sifre"].ToString() == textBox_s_sifre.Text)
                {
                    flag = 1;
                    label_uyari3.Text = "";
                    break;
                }
            }
            if (flag == 0) label_uyari3.Text = "Bulunamadı.";
            conn.Close();
            if (flag == 0 || flag == 2) return;
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"DELETE FROM login_admin WHERE admin_kullanici = @kullanici;";
            com.Parameters.AddWithValue("@kullanici", textBox_s_kullanici.Text);

            label_uyari3.Text = "Silindi ! ";
            com.ExecuteNonQuery();

            conn.Close();
        }
    }
}
