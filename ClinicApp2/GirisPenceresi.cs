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
    public partial class GirisPenceresi : Form
    {
        public string kullanici = "";
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public GirisPenceresi()
        {
            InitializeComponent();
        }
        private void GirisPenceresi_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            label10.Text = "";
            label13.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from login_doktor",conn);
            SqlDataReader reader = com.ExecuteReader();

            while(reader.Read())
            {
                if (textBox_kullanicidr.Text == reader["doktor_kullanici"].ToString() && textBox_sifredr.Text == reader["doktor_sifre"].ToString())
                {
                    Console.WriteLine("Giriş Başarılı");
                    kullanici = reader["doktor_kullanici"].ToString();
                    Console.WriteLine(kullanici);
                    DoktorPenceresi dr_window = new DoktorPenceresi(kullanici);
                    dr_window.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    label7.Text = "HATALI GİRİŞ";
                    label8.Text = "";
                    label10.Text = "";
                    label13.Text = "";
                }
                //Console.WriteLine(reader["doktor_kullanici"].ToString());
                //Console.WriteLine(reader["doktor_sifre"].ToString());
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from login_personel", conn);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                if (textBox_kullaniciper.Text == reader["personel_kullanici"].ToString() && textBox_sifreper.Text == reader["personel_sifre"].ToString())
                {
                    Console.WriteLine("Giriş Başarılı");
                    kullanici = reader["personel_kullanici"].ToString();
                    Console.WriteLine(kullanici);
                    PersonelPenceresi per_window = new PersonelPenceresi(kullanici);
                    per_window.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    label7.Text = "";
                    label8.Text = "HATALI GİRİŞ";
                    label10.Text = "";
                    label13.Text = "";
                }
                //Console.WriteLine(reader["doktor_kullanici"].ToString());
                //Console.WriteLine(reader["doktor_sifre"].ToString());
            }
            conn.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            System.Windows.Forms.Application.ExitThread();
        }

        private void button_adm_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from login_admin", conn);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                if (textBox_kullaniciadm.Text == reader["admin_kullanici"].ToString() && textBox_sifreadm.Text == reader["admin_sifre"].ToString())
                {
                    Console.WriteLine("Giriş Başarılı");
                    kullanici = reader["admin_kullanici"].ToString();
                    Console.WriteLine(kullanici);
                    AdminPenceresi admin_window = new AdminPenceresi(kullanici);
                    admin_window.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    label7.Text = "";
                    label8.Text = "";
                    label10.Text = "HATALI GİRİŞ";
                    label13.Text = "";
                }
                //Console.WriteLine(reader["doktor_kullanici"].ToString());
                //Console.WriteLine(reader["doktor_sifre"].ToString());
            }
            conn.Close();
        }

        private void button_hasta_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from login_hasta", conn);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                if (textBox_kullanicihasta.Text == reader["hasta_kullanici"].ToString() && textBox_sifrehasta.Text == reader["hasta_sifre"].ToString())
                {
                    Console.WriteLine("Giriş Başarılı");
                    kullanici = reader["hasta_kullanici"].ToString();
                    Console.WriteLine(kullanici);
                    HastaKullaniciPenceresi hasta_window = new HastaKullaniciPenceresi(kullanici);
                    hasta_window.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    label7.Text = "";
                    label8.Text = "";
                    label13.Text = "HATALI GİRİŞ";
                    label10.Text = "";
                }
                //Console.WriteLine(reader["doktor_kullanici"].ToString());
                //Console.WriteLine(reader["doktor_sifre"].ToString());
            }
            conn.Close();
        }
    }
}
