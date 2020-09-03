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
    public partial class PersonelListelePenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public PersonelListelePenceresi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void PersonelListelePenceresi_Load(object sender, EventArgs e)
        {
            listView_perTablo.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM personeller LEFT JOIN departmanlar ON personeller.personel_depkodu = departmanlar.departman_kodu", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(rd["personel_tc"].ToString());
                item.SubItems.Add(rd["personel_isim"].ToString() + " " + rd["personel_soyisim"].ToString());
                item.SubItems.Add(rd["departman_isim"].ToString());
                item.SubItems.Add(rd["personel_cinsiyet"].ToString());
                item.SubItems.Add(rd["personel_telefon"].ToString());
                item.SubItems.Add(rd["personel_mail"].ToString());
                item.SubItems.Add(rd["personel_adres"].ToString());
                listView_perTablo.Items.Add(item);
            }

            conn.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listView_perTablo.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM personeller LEFT JOIN departmanlar ON personeller.personel_depkodu = departmanlar.departman_kodu", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                if (textBox_ara.Text == rd["personel_tc"].ToString() || textBox_ara.Text.ToUpper() == rd["personel_isim"].ToString() || textBox_ara.Text == rd["departman_isim"].ToString() || textBox_ara.Text.ToUpper() == rd["personel_soyisim"].ToString()
                    || textBox_ara.Text.ToUpper() == (rd["personel_isim"].ToString() + " " + rd["personel_soyisim"].ToString()))
                {
                    ListViewItem item = new ListViewItem(rd["personel_tc"].ToString());
                    item.SubItems.Add(rd["personel_isim"].ToString() + " " + rd["personel_soyisim"].ToString());
                    item.SubItems.Add(rd["departman_isim"].ToString());
                    item.SubItems.Add(rd["personel_cinsiyet"].ToString());
                    item.SubItems.Add(rd["personel_telefon"].ToString());
                    item.SubItems.Add(rd["personel_mail"].ToString());
                    item.SubItems.Add(rd["personel_adres"].ToString());
                    listView_perTablo.Items.Add(item);
                }
            }

            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_ara.Text = "";
            PersonelListelePenceresi_Load(sender, e);
        }

        private void button_ekgünsil_Click(object sender, EventArgs e)
        {
            PersonelEkleGüncelleSil ekgünsil = new PersonelEkleGüncelleSil();
            ekgünsil.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }
    }
}
