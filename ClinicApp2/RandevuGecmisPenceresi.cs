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
    public partial class RandevuGecmisPenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public RandevuGecmisPenceresi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void RandevuGecmisPenceresi_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM randevular LEFT JOIN hastalar ON randevular.hasta_tc = hastalar.hasta_tc LEFT JOIN doktorlar ON randevular.doktor_tc = doktorlar.doktor_tc", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                    ListViewItem item = new ListViewItem(rd["randevu_id"].ToString());
                    item.SubItems.Add(rd["hasta_isim"].ToString() + " " + rd["hasta_soyisim"].ToString());
                    item.SubItems.Add(rd["hasta_tc"].ToString());
                    item.SubItems.Add(rd["doktor_isim"].ToString() + " " + rd["doktor_soyisim"].ToString());
                    item.SubItems.Add(rd["randevu_tarihi"].ToString().Remove(10,9));
                    item.SubItems.Add(rd["randevu_saati"].ToString().Remove(5,3));
                    listView1.Items.Add(item);
            }

            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandevuGecmisGuncellemePenceresi ranGecGuncelle = new RandevuGecmisGuncellemePenceresi();
            ranGecGuncelle.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM randevular LEFT JOIN hastalar ON randevular.hasta_tc = hastalar.hasta_tc", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                if (textBox1.Text == rd["randevu_id"].ToString() || textBox1.Text == rd["hasta_tc"].ToString() || textBox1.Text == rd["randevu_tarihi"].ToString().Remove(10,9)
                    || textBox1.Text.ToUpper() == (rd["hasta_isim"].ToString() + " " + rd["hasta_soyisim"].ToString()))
                {
                    ListViewItem item = new ListViewItem(rd["randevu_id"].ToString());
                    item.SubItems.Add(rd["hasta_isim"].ToString() + " " + rd["hasta_soyisim"].ToString());
                    item.SubItems.Add(rd["hasta_tc"].ToString());
                    item.SubItems.Add(rd["doktor_isimsoyisim"].ToString());
                    item.SubItems.Add(rd["randevu_tarihi"].ToString().Remove(10,9));
                    item.SubItems.Add(rd["randevu_saati"].ToString().Remove(5,3));
                    listView1.Items.Add(item);
                }
            }

            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            RandevuGecmisPenceresi_Load(sender,e);
        }
    }
}
