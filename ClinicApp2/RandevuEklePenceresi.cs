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
using System.Runtime.CompilerServices;

namespace ClinicApp2
{
    public partial class RandevuEklePenceresi : Form
    {
        string gelenTC = "";
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public RandevuEklePenceresi(string tc= "")
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gelenTC = tc;
        }

        private void RandevuEklePenceresi_Load(object sender, EventArgs e)
        {
            if (gelenTC != "") textBox_tc.Text = gelenTC;
            label_uyari.Text = "";
            textBox_adi.Enabled = false;
            textBox_soyadi.Enabled = false;
            comboBox_doktor.Enabled = false;
            dateTimePicker_randevu.Enabled = false;
            comboBox_doktor.Enabled = false;
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select doktor_isim, doktor_soyisim from doktorlar ;",conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox_doktor.Items.Add(reader["doktor_isim"] + " " +reader["doktor_soyisim"]);
            }
            conn.Close();
            conn.Open();
            cmd = new SqlCommand("Select bolum_isim from bolumler ;", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox_poliklinik.Items.Add(reader["bolum_isim"]);
            }
            conn.Close();
        }

        private void button_getir_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from hastalar", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["hasta_tc"].ToString() == textBox_tc.Text)
                {
                    textBox_adi.Text = reader["hasta_isim"].ToString();
                    textBox_soyadi.Text = reader["hasta_soyisim"].ToString();

                    textBox_tc.Enabled = false;
                    comboBox_doktor.Enabled = true;
                    dateTimePicker_randevu.Enabled = true;
                    comboBox_doktor.Enabled = true;
                    break;
                }
            }
            conn.Close();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            string doktor_tc = "";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from doktorlar", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["doktor_isim"].ToString() + " " + reader["doktor_soyisim"].ToString() == comboBox_doktor.Text)
                {
                    doktor_tc = reader["doktor_tc"].ToString();
                    break;
                }
            }
            conn.Close();
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"INSERT INTO randevular (doktor_tc, hasta_tc, randevu_tarihi, randevu_saati, randevu_pol, randevu_islendi)" +
                "VALUES(@dr_tc, @tc, @randevu_tarihi, @randevu_saati, @randevu_pol, @ran_islendi);";
            com.Parameters.AddWithValue("@dr_tc", doktor_tc);
            com.Parameters.AddWithValue("@tc", textBox_tc.Text);
            com.Parameters.Add("@randevu_tarihi", SqlDbType.Date).Value = dateTimePicker_randevu.Value.Date;
            com.Parameters.AddWithValue("@randevu_saati", comboBox_saat.Text);
            com.Parameters.AddWithValue(@"randevu_pol", comboBox_poliklinik.Text);
            com.Parameters.AddWithValue(@"ran_islendi", "False");
            com.ExecuteNonQuery();

            conn.Close();

            label_uyari.Text = "Kaydedildi !";
        }

        private void comboBox_saat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doktor_tc = "";
            label_uyari.Text = "";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from doktorlar", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["doktor_isim"].ToString() + " " + reader["doktor_soyisim"].ToString() == comboBox_doktor.Text)
                {
                    doktor_tc = reader["doktor_tc"].ToString();
                    break;
                }
            }
            conn.Close();
            conn.Open();
            cmd = new SqlCommand("select * from randevular", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((reader["doktor_tc"].ToString() == doktor_tc) && (reader["randevu_saati"].ToString() == comboBox_saat.Text +":00") && (reader["randevu_tarihi"].ToString() == dateTimePicker_randevu.Value.Date.ToString()))
                {
                    label_uyari.Text = "Dolu !";
                    button_kaydet.Enabled = false;
                    break;
                }
                else
                {
                    label_uyari.Text = "";
                    button_kaydet.Enabled = true;
                }
            }
            conn.Close();
        }

        private void comboBox_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_saat_SelectedIndexChanged(sender, e);
        }

        private void dateTimePicker_randevu_ValueChanged(object sender, EventArgs e)
        {
            comboBox_saat_SelectedIndexChanged(sender, e);
        }

        private void comboBox_poliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_doktor.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from doktorlar left join bolumler on doktorlar.doktor_bolumkodu = bolumler.bolum_kodu ;", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if( comboBox_poliklinik.Text == reader["bolum_isim"].ToString())
                    comboBox_doktor.Items.Add(reader["doktor_isim"] + " " + reader["doktor_soyisim"]);
            }
            conn.Close();
        }
    }
}
