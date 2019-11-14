using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Projectm_I
{
    public partial class Form1 : Form
    {
        public Rectangle GetScreen()
        {
            return Screen.FromControl(this).Bounds;
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ApIILyFhnmxj9nL5XlI6priYT36g1yyhlruOxwKv",
            BasePath = "https://liberity-a214c.firebaseio.com/"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("Connection established");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            String userpassword = password.Text;
            if (username== "police" && userpassword=="p1234")
                //Actually username and userpassword must get from Database(Firebase)
                //But this is idea testing and not current version
            {
                Police police = new Police();
                police.Show();
                this.Visible = false;
            }
            else if(username=="municipal" && userpassword == "m1234")
            {
                Municipal municipal = new Municipal();
                municipal.Show();
                this.Visible = false;
            }
            else if(username=="epc" && userpassword == "e1234")
            {
                EPC epc = new EPC();
                epc.Show();
                this.Visible = false;
            }
            else if(username=="ghospital" && userpassword == "h1234")
            {
                General_Hospital ghospital = new General_Hospital();
                ghospital.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Username or Userpassword wrong! Please Check");
                //နာမည် သို့ ကုတ်နံပါတ် မှားယွင်းနေသည်။ထပ်မံကြိုးစားပါ။
            }


        }
    }
}
