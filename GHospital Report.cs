﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace Projectm_I
{
    public partial class GHospital_Report : Form
    {
        public ChromiumWebBrowser browser;

        public GHospital_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser("http://192.168.56.1:3000/ghospital");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            General_Hospital rhospital = new General_Hospital();
            rhospital.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 rform1 = new Form1();
            rform1.Show();
            this.Visible = false;
        }
    }
}
