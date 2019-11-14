using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace Projectm_I
{
    public partial class General_Hospital : Form
    {

        public ChromiumWebBrowser browser;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ApIILyFhnmxj9nL5XlI6priYT36g1yyhlruOxwKv",
            BasePath = "https://liberity-a214c.firebaseio.com/"
        };
        IFirebaseClient client;

        public General_Hospital()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Crime
            {
                name = title.Text,
                date = date.Text,
                proposal = proposal.Text,
                imageUrl = photo.Text
            };
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = await client.SetTaskAsync("GHospital/" + title.Text, data);
            Crime result = response.ResultAs<Crime>();
            MessageBox.Show("Insert Successed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           GHospital_Report ghospital = new GHospital_Report();
            ghospital.Show();
        }
    }
}
