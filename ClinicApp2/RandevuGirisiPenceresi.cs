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
    public partial class RandevuGirisiPenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        string randId = "";
        public RandevuGirisiPenceresi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from randevular", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((reader["hasta_tc"].ToString() == textBox_tc.Text) && reader["randevu_islendi"].ToString() == "False")
                {
                    label_uyari.Text = "";
                    dateTimePicker1.Text = reader["randevu_tarihi"].ToString();
                    comboBox1.Text = reader["randevu_saati"].ToString();
                    dateTimePicker1.Enabled = false;
                    comboBox1.Enabled = false;
                    button2.Enabled = false;
                    button_kaydet.Enabled = true;

                    richTextBox_acik.Enabled = true;
                    richTextBox_semp.Enabled = true;
                    richTextBox_rece.Enabled = true;

                    richTextBox_acik.Text = "";
                    richTextBox_semp.Text = "";
                    richTextBox_rece.Text = "";

                    randId = reader["randevu_id"].ToString();
                    break;
                }
                else
                {
                    label_uyari.Text = "Randevu Bulunamadı ! ";
                }
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from randevular", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((reader["randevu_tarihi"].ToString().Remove(10,9) == dateTimePicker1.Text) && (reader["randevu_islendi"].ToString() == "False") && (reader["randevu_saati"].ToString().Remove(5,3) == comboBox1.Text))
                {
                    label_uyari.Text = "";
                    textBox_tc.Text = reader["hasta_tc"].ToString();
                    textBox_tc.Enabled = false;
                    button1.Enabled = false;

                    richTextBox_acik.Enabled = true;
                    richTextBox_semp.Enabled = true;
                    richTextBox_rece.Enabled = true;
                    button_kaydet.Enabled = true;

                    richTextBox_acik.Text = "";
                    richTextBox_semp.Text = "";
                    richTextBox_rece.Text = "";

                    randId = reader["randevu_id"].ToString();
                    break;
                }
                else
                {
                    label_uyari.Text = "Randevu Bulunamadı ! ";
                }
            }
            conn.Close();
        }

        private void RandevuGirisiPenceresi_Load(object sender, EventArgs e)
        {
            label_uyari.Text = "";
            comboBox_tani.Text = "Tanı Seçiniz...";
            comboBox_ilac.Text = "İlaç Seçiniz...";
            button_kaydet.Enabled = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tanilar", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox_tani.Items.Add(reader["tani_kodu"].ToString() + "-" +reader["tani_isim"].ToString());
            }
            reader.Close();
            cmd = new SqlCommand("select * from ilaclar", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox_ilac.Items.Add(reader["ilac_barkod"].ToString() + "-" + reader["ilac_isim"].ToString());
            }
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"UPDATE randevular SET randevu_islendi = 'True', randevu_semptom = @semptom, randevu_aciklama = @aciklama, randevu_recete = @recete WHERE randevu_id = @id ;";
            com.Parameters.AddWithValue("@id", randId);
            com.Parameters.AddWithValue("@semptom", richTextBox_semp.Text);
            com.Parameters.AddWithValue("@aciklama", richTextBox_acik.Text);
            com.Parameters.AddWithValue("@recete", richTextBox_rece.Text);
            com.ExecuteNonQuery();

            randId = "";

            richTextBox_acik.Enabled = false;
            richTextBox_semp.Enabled = false;
            richTextBox_rece.Enabled = false;

            textBox_tc.Enabled = true;
            button1.Enabled = true;

            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = true;
            button2.Enabled = true;



            label_uyari.Text = "Kaydedildi ! ";

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox_semp.Text = richTextBox_semp.Text + "\n" +  comboBox_tani.Text + "\n";
            comboBox_tani.Text = "";
        }

        private void button_ilacEkle_Click(object sender, EventArgs e)
        {
            richTextBox_rece.Text = richTextBox_rece.Text + "\n" + comboBox_ilac.Text + "\n";
            comboBox_ilac.Text = "";
        }
    }
}
