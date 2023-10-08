using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zębatka
{
    public partial class Form3 : Form
    {
        public int UserID = 0;
        private int coins = 0;
        public Form3()
        {
            InitializeComponent();
            UpdateCoins();
        }

        void UpdateCoins()
        {
            button2.Hide();
            if(UserID == 1)
            {
                WebClient wc = new WebClient();
                string c = wc.DownloadString("http://www.zebatkabase.y0.pl/User1/coins.txt");
                string j = wc.DownloadString("http://www.zebatkabase.y0.pl/User1/test06.txt");
                if(j == "1")
                {
                    label3.Text = "Posiadasz tę gre.";
                    label3.ForeColor = Color.Green;
                    button2.Show();
                }
                else
                {
                    label3.Text = "Nie posiadasz tej gry.";
                    label3.ForeColor = Color.Red;
                    button2.Hide();
                }
                coins = Convert.ToInt32(c);
            }
            if(UserID == 2)
            {
                WebClient wc = new WebClient();
                string c = wc.DownloadString("http://www.zebatkabase.y0.pl/User2/coins.txt");
                string j = wc.DownloadString("http://www.zebatkabase.y0.pl/User2/test06.txt");
                if (j == "1")
                {
                    label3.Text = "Posiadasz tę gre.";
                    label3.ForeColor = Color.Green;
                    button2.Show();
                }
                else
                {
                    label3.Text = "Nie posiadasz tej gry.";
                    label3.ForeColor = Color.Red;
                    button2.Hide();
                }
                coins = Convert.ToInt32(c);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.mediafire.com/file/81iufmbcvqfjspd/Test.rar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //UpdateCoins();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateCoins();
        }
    }
}
