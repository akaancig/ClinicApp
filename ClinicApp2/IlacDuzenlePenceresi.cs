﻿using System;
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
    public partial class IlacDuzenlePenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public IlacDuzenlePenceresi()
        {
            InitializeComponent();
        }

        private void IlacDuzenlePenceresi_Load(object sender, EventArgs e)
        {
            label_e.Text = "";
            label_g.Text = "";
            label_s.Text = "";

            button_guncelle.Enabled = false;
            richTextBox_g.Enabled = false;

            button_sil.Enabled = false;
            richTextBox_s.Enabled = false;
        }

        private void button_e_kaydet_Click(object sender, EventArgs e)
        {
            int flg = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ilaclar", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (textBox_e.Text == reader["ilac_barkod"].ToString())
                {
                    flg = 1;
                    label_e.Text = "Kayıtlı barkod no.";
                    break;
                }
            }
            conn.Close();
            if (flg == 1) return;
            else if (textBox_e.Text == "")
            {
                label_e.Text = "Barkod no boş olamaz.";
                return;
            }
            else if (richTextBox_e.Text == "")
            {
                label_e.Text = "İlaç adı boş olamaz.";
                return;
            }
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"INSERT INTO ilaclar (ilac_barkod, ilac_isim)" +
                "VALUES(@kod, @isim);";
            com.Parameters.AddWithValue("@kod", textBox_e.Text.ToUpper());
            com.Parameters.AddWithValue("@isim", richTextBox_e.Text.ToUpper());
            com.ExecuteNonQuery();
            conn.Close();
            label_e.Text = "Kaydedildi";
        }

        private void button_g_getir_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ilaclar", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (textBox_g.Text == reader["ilac_barkod"].ToString())
                {
                    richTextBox_g.Text = reader["ilac_isim"].ToString();
                    button_g_getir.Enabled = false;
                    textBox_g.Enabled = false;
                    button_guncelle.Enabled = true;
                    richTextBox_g.Enabled = true;
                    label_g.Text = "";
                    break;
                }
                else
                {
                    label_g.Text = "Bulunamadı";
                    button_guncelle.Enabled = true;
                }
            }
            conn.Close();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            label_g.Text = "";
            if (richTextBox_g.Text == "")
            {
                label_g.Text = "İlaç Adı alanı boş olamaz.";
                return;
            }
            else
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = @"UPDATE ilaclar SET ilac_isim = @isim WHERE ilac_barkod = @kod; ";
                com.Parameters.AddWithValue("@kod", textBox_g.Text);
                com.Parameters.AddWithValue("@isim", richTextBox_g.Text.ToUpper());
                com.ExecuteNonQuery();
                conn.Close();
                label_g.Text = "Güncellendi ! ";
                button_guncelle.Enabled = false;
                button_g_getir.Enabled = true;
                richTextBox_g.Enabled = false;
                textBox_g.Enabled = true;
                richTextBox_g.Text = "";
                textBox_g.Text = "";
            }
        }

        private void button_s_getir_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ilaclar", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (textBox_s.Text == reader["ilac_barkod"].ToString())
                {
                    richTextBox_s.Text = reader["ilac_isim"].ToString();
                    button_sil.Enabled = true;
                    label_s.Text = "";
                    break;
                }
                else
                {
                    label_s.Text = "Bulunamadı";
                    button_sil.Enabled = false;
                }
            }
            conn.Close();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"delete from ilaclar WHERE ilac_barkod = @kod; ";
            com.Parameters.AddWithValue("@kod", textBox_s.Text);
            com.ExecuteNonQuery();
            conn.Close();

            button_sil.Enabled = false;
            textBox_s.Enabled = true;
            button_s_getir.Enabled = true;
            label_s.Text = "Silindi ! ";
        }
    }
}
