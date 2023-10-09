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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        #region wyglad
        private void loginform_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 1)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 1)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 1)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 1)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 1)
            {
                textBox6.Focus();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == 1)
            {
                textBox7.Focus();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length == 1)
            {
                textBox8.Focus();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == 1)
            {
                textBox9.Focus();
            }
        }
        #endregion

        #region showpass
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox9.UseSystemPasswordChar = false;
                textBox9.Focus();
            }
            else
            {
                textBox9.UseSystemPasswordChar = true;
            }
        }
        #endregion

        public string GetBetween(string text, string first, string last)
        {
            return text.Substring(text.IndexOf(first) + first.Length, text.IndexOf(last) - text.IndexOf(first) - first.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text + textBox8.Text;
                string password = textBox9.Text;
                WebClient wc = new WebClient();
                string toCheckPass = wc.DownloadString("http://www.rack.c0.pl/BankRCOIN/"+login+".txt");
                toCheckPass = GetBetween(toCheckPass, "<pass>","</pass>");
                if(password == toCheckPass)
                {
                    progressBar1.Value = 100;
                    mainaccount n = new mainaccount();
                    n.username = login;
                    n.Show();
                    this.Hide();
                }
                else
                {
                    progressBar1.Value = 5;
                }
            }
            catch
            {
                progressBar1.Value = 0;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                try
                {
                    string login = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text + textBox8.Text;
                    string password = textBox9.Text;
                    WebClient wc = new WebClient();
                    string toCheckPass = wc.DownloadString("http://www.rack.c0.pl/BankRCOIN/" + login + ".txt");
                    toCheckPass = GetBetween(toCheckPass, "<pass>", "</pass>");
                    if (password == toCheckPass)
                    {
                        progressBar1.Value = 100;
                        mainaccount n = new mainaccount();
                        n.username = login;
                        n.Show();
                        this.Hide();
                    }
                    else
                    {
                        progressBar1.Value = 5;
                    }
                }
                catch
                {
                    progressBar1.Value = 0;
                }
            }
        }
    }
}
