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
    public partial class DoktorListelePenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public DoktorListelePenceresi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void DoktorListelePenceresi_Load(object sender, EventArgs e)
        {
            listView_perTablo.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM doktorlar LEFT JOIN bolumler ON doktorlar.doktor_bolumkodu = bolumler.bolum_kodu", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(rd["doktor_tc"].ToString());
                item.SubItems.Add(rd["doktor_isim"].ToString() + " " + rd["doktor_soyisim"].ToString());
                item.SubItems.Add(rd["bolum_isim"].ToString());
                item.SubItems.Add(rd["doktor_cinsiyet"].ToString());
                item.SubItems.Add(rd["doktor_telefon"].ToString());
                item.SubItems.Add(rd["doktor_mail"].ToString());
                item.SubItems.Add(rd["doktor_adres"].ToString());
                listView_perTablo.Items.Add(item);
            }

            conn.Close();
        }

        private void pictureBox_ara_Click(object sender, EventArgs e)
        {
            listView_perTablo.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM doktorlar LEFT JOIN bolumler ON doktorlar.doktor_bolumkodu = bolumler.bolum_kodu", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                if (textBox_ara.Text == rd["doktor_tc"].ToString() || textBox_ara.Text.ToUpper() == rd["doktor_isim"].ToString() || textBox_ara.Text == rd["bolum_isim"].ToString() || textBox_ara.Text.ToUpper() == rd["doktor_soyisim"].ToString()
                    || textBox_ara.Text.ToUpper() == (rd["doktor_isim"].ToString() + " " + rd["doktor_soyisim"].ToString()))
                {
                    ListViewItem item = new ListViewItem(rd["doktor_tc"].ToString());
                    item.SubItems.Add(rd["doktor_isim"].ToString() + " " + rd["doktor_soyisim"].ToString());
                    item.SubItems.Add(rd["bolum_isim"].ToString());
                    item.SubItems.Add(rd["doktor_cinsiyet"].ToString());
                    item.SubItems.Add(rd["doktor_telefon"].ToString());
                    item.SubItems.Add(rd["doktor_mail"].ToString());
                    item.SubItems.Add(rd["doktor_adres"].ToString());
                    listView_perTablo.Items.Add(item);
                }
            }

            conn.Close();
        }

        private void pictureBox_iptal_Click(object sender, EventArgs e)
        {
            textBox_ara.Text = "";
            DoktorListelePenceresi_Load(sender, e);
        }

        private void button_ekgünsil_Click(object sender, EventArgs e)
        {
            DoktorEkleSilGüncelle ekgünsil = new DoktorEkleSilGüncelle();
            ekgünsil.Show();
        }

        private void pictureBox_yenile_Click(object sender, EventArgs e)
        {
            pictureBox_iptal_Click(sender,e);
        }
    }
}
