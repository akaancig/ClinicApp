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
    public partial class IlacListePenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public IlacListePenceresi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void IlacListePenceresi_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from ilaclar ;", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(rd["ilac_barkod"].ToString());
                item.SubItems.Add(rd["ilac_isim"].ToString());
                listView1.Items.Add(item);
            }

            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM ilaclar", conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read())
            {
                if (rd["ilac_isim"].ToString().StartsWith(textBox1.Text.ToUpper()) || rd["ilac_barkod"].ToString().StartsWith(textBox1.Text.ToUpper()))
                {
                    ListViewItem item = new ListViewItem(rd["ilac_barkod"].ToString());
                    item.SubItems.Add(rd["ilac_isim"].ToString());
                    listView1.Items.Add(item);
                }
            }

            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1_Click(sender,e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            IlacListePenceresi_Load(sender,e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IlacDuzenlePenceresi pnc = new IlacDuzenlePenceresi();
            pnc.Show();
        }
    }
}
