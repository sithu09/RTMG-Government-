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
    public partial class Police : Form
    {


        public ChromiumWebBrowser browser;

     



        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ApIILyFhnmxj9nL5XlI6priYT36g1yyhlruOxwKv",
            BasePath = "https://liberity-a214c.firebaseio.com/"
        };
        IFirebaseClient client;
        public Police()
        {
            InitializeComponent();
        



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Crime
            {
                name = title.Text,
                 date= date.Text,
                proposal = proposal.Text,
                imageUrl = photo.Text
            };
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = await client.SetTaskAsync("Crime/" + title.Text,data);
           Crime result = response.ResultAs<Crime>();
            MessageBox.Show("Insert Successed");
        }

      
        private void Police_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //client = new FireSharp.FirebaseClient(config);

            //FirebaseResponse response = await client.GetTaskAsync("Crime/");
            //Crime obj = response.ResultAs<Crime>();


            //obj.rname = title.Text;
            //obj.rdate = date.Text;
            //obj.rpropossal = proposal.Text;
            //obj.rimageUrl = photo.Text;

            // MessageBox.Show(obj.proposal);
            WebForm webform = new WebForm();
            webform.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {




            //Cef.Initialize(new CefSettings());
            //webBrowser1.Navigate("https://liberity-a214c.firebaseapp.com/");
            //this.Controls.Add(webBrowser1);
            //webBrowser1.Dock = DockStyle.Left;

            USer user = new USer();
            user.Show();





        }
    }
}