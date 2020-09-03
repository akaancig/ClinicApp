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
    public partial class HastaKullaniciPenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        string kullanici = "";
        string tc = "";
        public HastaKullaniciPenceresi(string user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            kullanici = user;
        }

        private void HastaKullaniciPenceresi_Load(object sender, EventArgs e)
        {
            label_kullanici.Text = "Kullanıcı : " + kullanici;
            label_uyari.Text = "";

            listView_randListesi.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM randevular LEFT JOIN login_hasta ON randevular.hasta_tc = login_hasta.hasta_tc LEFT JOIN doktorlar ON doktorlar.doktor_tc = randevular.doktor_tc ORDER BY randevu_id DESC", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                if (rd["hasta_kullanici"].ToString() == kullanici)
                {
                    tc = rd["hasta_tc"].ToString();
                    ListViewItem item = new ListViewItem(rd["randevu_id"].ToString());
                    if(rd["randevu_tarihi"].ToString() == "") item.SubItems.Add(rd["randevu_tarihi"].ToString());
                    else item.SubItems.Add(rd["randevu_tarihi"].ToString().Remove(10, 9));
                    if(rd["randevu_saati"].ToString() == "") item.SubItems.Add(rd["randevu_saati"].ToString());
                    else item.SubItems.Add(rd["randevu_saati"].ToString().Remove(5, 3));
                    item.SubItems.Add(rd["randevu_pol"].ToString());
                    item.SubItems.Add(rd["doktor_isim"].ToString() + " " + rd["doktor_soyisim"].ToString());
                    if (rd["randevu_islendi"].ToString() == "True") item.ForeColor = Color.Red;
                    else item.ForeColor = Color.Blue;
                    listView_randListesi.Items.Add(item);
                }
            }

            conn.Close();
        }

        private void button_yeniRand_Click(object sender, EventArgs e)
        {
            RandevuEklePenceresi yeniRand = new RandevuEklePenceresi(tc);
            yeniRand.Show();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            int flag = 0;
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM randevular", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                if (rd["randevu_id"].ToString() == textBox1.Text)
                {
                    if (rd["randevu_islendi"].ToString() == "False")
                    {
                        flag = 1;
                        label_uyari.Text = "";
                        break;
                    }
                    else
                    {
                        label_uyari.Text = "Geçmiş Randevu !";
                        flag = 2;
                        break;
                    }
                }
            }
            conn.Close();
            if (flag == 0) { label_uyari.Text = "Bulunamadı !"; return; }
            if (flag == 2) return;


            conn.Open();
            com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = @"DELETE FROM randevular WHERE randevu_id = @id ;";
            com.Parameters.AddWithValue("@id", textBox1.Text);
            com.ExecuteNonQuery();
            label_uyari.Text = "Randevu İptal Edildi ! ";
            conn.Close();
            HastaKullaniciPenceresi_Load(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HastaKullaniciPenceresi_Load(sender, e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            GirisPenceresi home_window = new GirisPenceresi();
            home_window.Show();
        }
    }
}
