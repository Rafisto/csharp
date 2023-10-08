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
    public partial class Form1 : Form
    {
        // hasło do ftp www.cba.pl
        // login: rafisto5
        // hasło: Zębatka1
        public bool jestint = false;
        public Form1()
        {
            InitializeComponent();
            label2.Hide();
            button1.Hide();
            testInternetState();
            LoadForm();
            
        }
        void testInternetState()
        {
            progressBar1.Value = 30;
            try
            {
                using (var client = new WebClient())
                {
                    progressBar1.Value = 50;
                    using (var stream = client.OpenRead("https://www.google.com"))
                    {
                        progressBar1.Value = 100;
                        label2.Text = "Połączony z bazą danych";
                        label2.ForeColor = Color.Green;
                        label2.Show();
                    }
                }
            }
            catch
            {
                progressBar1.Value = 40;
                label2.Show();
            }
        }
        void LoadForm() {      
            if (progressBar1.Value == 100) {
                button1.Show();
                jestint = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jestint)
            {
                Form2 x = new Form2();
                x.Show();
                this.Hide();
            }
        }
    }
}
