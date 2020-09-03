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
    public partial class AdminPenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public string kullanici = "";

        public AdminPenceresi(string str)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorListelePenceresi dr = new DoktorListelePenceresi();
            dr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelListelePenceresi prs = new PersonelListelePenceresi();
            prs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RandevuGecmisPenceresi rnd = new RandevuGecmisPenceresi();
            rnd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminEkleSilGuncelle adm = new AdminEkleSilGuncelle();
            adm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaPenceresi hasta = new HastaPenceresi("");
            hasta.Show();
        }
    }
}
