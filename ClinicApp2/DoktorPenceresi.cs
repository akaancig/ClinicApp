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
    public partial class DoktorPenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public string kullanici;
        public DoktorPenceresi(string user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            kullanici = user;
        }
        private void DoktorPenceresi_Load(object sender, EventArgs e)
        {
            label1.Text = "Kullanıcı : " + kullanici ;
            textBox1.Text = "";

            listView1.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM randevular LEFT JOIN hastalar ON randevular.hasta_tc = hastalar.hasta_tc LEFT JOIN doktorlar ON randevular.doktor_tc = doktorlar.doktor_tc"
                + " LEFT JOIN login_doktor ON randevular.doktor_tc = login_doktor.doktor_tc ;" , conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                if(rd["doktor_kullanici"].ToString() == kullanici && rd["randevu_islendi"].ToString()=="False")
                {
                    ListViewItem item = new ListViewItem(rd["randevu_id"].ToString());
                    item.SubItems.Add(rd["doktor_isim"].ToString() + " " + rd["doktor_soyisim"].ToString());
                    item.SubItems.Add(rd["hasta_isim"].ToString()+" "+ rd["hasta_soyisim"].ToString());
                    item.SubItems.Add(rd["randevu_tarihi"].ToString().Remove(10,9));
                    item.SubItems.Add(rd["randevu_saati"].ToString().Remove(5,3));
                    listView1.Items.Add(item);
                }
            }

            conn.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            GirisPenceresi home_window = new GirisPenceresi();
            home_window.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaEklePenceresi hastaekle = new HastaEklePenceresi();
            hastaekle.Show();
        }

        private void button_hastaguncellesil_Click(object sender, EventArgs e)
        {
            HastaSilGuncellePenceresi hastasilgun = new HastaSilGuncellePenceresi();
            hastasilgun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuEklePenceresi randEkle = new RandevuEklePenceresi();
            randEkle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoktorPenceresi_Load(sender, e);
        }

        private void button_randGecmis_Click(object sender, EventArgs e)
        {
            RandevuGecmisPenceresi ranGecmis = new RandevuGecmisPenceresi();
            ranGecmis.Show();
        }

        private void button_randGirisi_Click(object sender, EventArgs e)
        {
            RandevuGirisiPenceresi ranGiris = new RandevuGirisiPenceresi();
            ranGiris.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM randevular LEFT JOIN hastalar ON randevular.hasta_tc = hastalar.hasta_tc LEFT JOIN login_doktor ON randevular.doktor_tc = login_doktor.doktor_tc" +
                " LEFT JOIN doktorlar ON randevular.doktor_tc = doktorlar.doktor_tc", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                if (rd["doktor_kullanici"].ToString() == kullanici && (textBox1.Text == rd["randevu_id"].ToString() || textBox1.Text == rd["hasta_tc"].ToString() || textBox1.Text.ToUpper() == rd["hasta_isim"].ToString() || textBox1.Text.ToUpper() == rd["hasta_soyisim"].ToString()
                    || textBox1.Text.ToUpper() == rd["hasta_soyisim"].ToString() +" " +rd["hasta_soyisim"].ToString()))
                {
                    ListViewItem item = new ListViewItem(rd["randevu_id"].ToString());
                    item.SubItems.Add(rd["doktor_isim"].ToString() + " " + rd["doktor_soyisim"].ToString());
                    item.SubItems.Add(rd["hasta_isim"].ToString() + " " + rd["hasta_soyisim"].ToString());
                    item.SubItems.Add(rd["randevu_tarihi"].ToString().Remove(10, 9));
                    item.SubItems.Add(rd["randevu_saati"].ToString().Remove(5, 3));
                    listView1.Items.Add(item);
                }
            }

            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DoktorPenceresi_Load(sender,e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TaniListePenceresi tani = new TaniListePenceresi();
            tani.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            IlacListePenceresi ilac = new IlacListePenceresi();
            ilac.Show();
        }
    }
}
