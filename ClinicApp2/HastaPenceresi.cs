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
    public partial class HastaPenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public string kullanici = "";

        public HastaPenceresi(string str)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //label1.Text = "";
            kullanici = str;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            GirisPenceresi home_window = new GirisPenceresi();
            home_window.Show();
        }

        private void button_hastasilgun_Click(object sender, EventArgs e)
        {
            HastaSilGuncellePenceresi p = new HastaSilGuncellePenceresi();
            p.Show();
        }

        private void button_hastaekle_Click(object sender, EventArgs e)
        {
            HastaEklePenceresi pnc = new HastaEklePenceresi();
            pnc.Show();
        }

        private void HastaPenceresi_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM hastalar", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                    ListViewItem item = new ListViewItem(rd["hasta_tc"].ToString());
                    item.SubItems.Add(rd["hasta_isim"].ToString() + " " + rd["hasta_soyisim"].ToString());
                    item.SubItems.Add(rd["hasta_cinsiyet"].ToString());
                    item.SubItems.Add(rd["hasta_dtarihi"].ToString().Remove(10, 9));
                    item.SubItems.Add(rd["hasta_telefon"].ToString());
                    item.SubItems.Add(rd["hasta_adres"].ToString());
                    item.SubItems.Add(rd["hasta_il"].ToString());
                    item.SubItems.Add(rd["hasta_ilce"].ToString());
                    listView1.Items.Add(item);
            }

            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM hastalar", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                if (textBox1.Text == rd["hasta_tc"].ToString() || textBox1.Text.ToUpper() == rd["hasta_isim"].ToString() || textBox1.Text.ToUpper() == rd["hasta_soyisim"].ToString()
                    || textBox1.Text.ToUpper() == rd["hasta_soyisim"].ToString() + " " + rd["hasta_soyisim"].ToString())
                {
                    ListViewItem item = new ListViewItem(rd["hasta_tc"].ToString());
                    item.SubItems.Add(rd["hasta_isim"].ToString() + " " + rd["hasta_soyisim"].ToString());
                    item.SubItems.Add(rd["hasta_cinsiyet"].ToString());
                    item.SubItems.Add(rd["hasta_dtarihi"].ToString().Remove(10, 9));
                    item.SubItems.Add(rd["hasta_telefon"].ToString());
                    item.SubItems.Add(rd["hasta_adres"].ToString());
                    item.SubItems.Add(rd["hasta_il"].ToString());
                    item.SubItems.Add(rd["hasta_ilce"].ToString());
                    listView1.Items.Add(item);
                }
            }

            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            HastaPenceresi_Load(sender,e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender,e);
        }
    }
}
