using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            progressBar1.Value = 10;
        }
        public bool internet = true;
        void Lload()
        {
            try
            {
                using (WebClient w = new WebClient())
                {
                    w.OpenRead("http://www.google.pl");
                }
                progressBar1.Value = 40;

                using (WebClient w = new WebClient())
                {
                    w.OpenRead("http://www.base-rplay.cba.pl");
                }
                progressBar1.Value = 100;
                loginform r = new loginform();
                System.Threading.Thread.Sleep(1000);
                r.Show();
                this.Hide();
            }
            catch
            {
                internet = false;
                label3.Text = "Your internet or our server is down";
                progressBar1.Value = 5;
            }
        }

        int dots = 0;
        private void loadingtimerdots_Tick(object sender, EventArgs e)
        {
            if (internet)
            {
                dots++;
                switch (dots)
                {
                    case 0:
                        {
                            label3.Text = "Loading";
                        }
                        break;
                    case 1:
                        {
                            label3.Text = "Loading.";
                        }
                        break;
                    case 2:
                        {
                            label3.Text = "Loading..";
                        }
                        break;
                    case 3:
                        {
                            label3.Text = "Loading...";
                            dots = -1;
                        }
                        break;
                }
            }
        }

        private void activatingprogressbar_Tick(object sender, EventArgs e)
        {
            activatingprogressbar.Enabled = false;
            Lload();
        }
    }
}
