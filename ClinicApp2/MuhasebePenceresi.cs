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
    public partial class MuhasebePenceresi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8S1QF7D;Initial Catalog=clinic;Integrated Security=True");
        public string kullanici = "";

        public MuhasebePenceresi(string str)
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
    }
}
