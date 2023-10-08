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

namespace Zębatka
{
    public partial class Form2 : Form
    {
        public bool pass1 = false;
        public bool pass2 = false;
        public int loggedUserID = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // login

            WebClient wc = new WebClient();
            string a = wc.DownloadString("http://www.zebatkabase.y0.pl/User1/login.txt");
            string b = wc.DownloadString("http://www.zebatkabase.y0.pl/User2/login.txt");
            if(textBox1.Text == a)
            {
                loggedUserID = 1;
                pass1 = true;
            }
            if(textBox1.Text == b)
            {
                loggedUserID = 2;
                pass1 = true;
            }
            // password
            string c = wc.DownloadString("http://www.zebatkabase.y0.pl/User1/pass.txt");
            string d = wc.DownloadString("http://www.zebatkabase.y0.pl/User2/pass.txt");
            if (textBox2.Text == c && loggedUserID == 1)
            {
                pass2 = true;
            }
            if (textBox2
                .Text == d && loggedUserID == 2)
            {
                pass2 = true;
            }
            if (pass1 && pass2)
            {
                MessageBox.Show("Zalogowano Pomyślnie", "Zalogowano Pomyślnie",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form3 x = new Form3();
                x.UserID = loggedUserID;
                x.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string a = wc.DownloadString("http://www.zebatkabase.y0.pl/User1/login.txt");
            string b = wc.DownloadString("http://www.zebatkabase.y0.pl/User2/login.txt");
            if (textBox1.Text == a)
            {
                checkBox1.Checked = true;
            }
            if (textBox1.Text == b)
            {
                checkBox1.Checked = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            WebClient wc = new WebClient();
            string a = wc.DownloadString("http://www.zebatkabase.y0.pl/User1/pass.txt");
            string b = wc.DownloadString("http://www.zebatkabase.y0.pl/User2/pass.txt");
            if (textBox2.Text == a)
            {
                checkBox2.Checked = true;
            }
            if (textBox2.Text == b)
            {
                checkBox2.Checked = true;
            }
        }
    }
}
