using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveChat
{
    public partial class Form1 : Form
    {
        public bool czyPol = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            if (t.Contains("ą") || t.Contains("ć") || t.Contains("ę") || t.Contains("ń") || t.Contains("ś") || t.Contains("ó") || t.Contains("ł") || t.Contains("ż") || t.Contains("ź"))
            {
                MessageBox.Show("No Polish characters, please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("https://www.google.com"))
                    {
                        czyPol = true;
                    }
                }
            }
            catch
            {
                czyPol = false;
            }
            if (czyPol)
            {
                decimal numerKan = numericUpDown1.Value;
                Directory.CreateDirectory(@"C:\plikT\");
                File.WriteAllText(@"C:\plikT\1.txt", "");
                using (WebClient client = new WebClient())
                {

                    client.Credentials = new NetworkCredential("rafisto5", "Thegame1");
                    client.UploadFile("ftp://www.rack.c0.pl/rack.c0.pl/chatt/" + numerKan.ToString() + ".txt", "STOR", @"C:\plikT\1.txt");
                }
                File.Delete(@"C:\plikT\1.txt");
                Form2 f = new Form2();
                f.name = textBox1.Text;
                f.numOfChannel = numerKan;
                f.Show();
                this.Hide();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t = textBox2.Text;
            if (t.Contains("ą") || t.Contains("ć") || t.Contains("ę") || t.Contains("ń") || t.Contains("ś") || t.Contains("ó") || t.Contains("ł") || t.Contains("ż") || t.Contains("ź"))
            {
                MessageBox.Show("No Polish characters, please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("https://www.google.com"))
                    {
                        czyPol = true;
                    }
                }
            }
            catch
            {
                czyPol = false;
            }
            if (czyPol)
            {
                decimal numerKan = numericUpDown2.Value;
                Directory.CreateDirectory(@"C:\plikT\");
                File.WriteAllText(@"C:\plikT\1.txt", "");
                // nie używane w connectie
                /* using (WebClient client = new WebClient())
                 {

                     client.Credentials = new NetworkCredential("rafisto5", "Thegame1");
                     client.UploadFile("ftp://www.rack.c0.pl/rack.c0.pl/chatt/" + numerKan.ToString() + ".txt", "STOR", @"C:\plikT\1.txt");
                 }*/
                File.Delete(@"C:\plikT\1.txt");
                Form2 f = new Form2();
                f.name = textBox2.Text;
                f.numOfChannel = numerKan;
                f.Show();
                this.Hide();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        /*
WebClient wc = new WebClient();
string a = wc.DownloadString("http://www.rack.c0.pl/User1/pass.txt");
*/

        /*
        using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential("rafisto5", "Thegame1");
                client.UploadFile("ftp://www.rack.c0.pl/rack.c0.pl/hello.txt", "STOR", @"C:\Users\Monika\Desktop\hello.txt");
            }


             int kluczPrywatnny = Convert.ToInt32(numericUpDown1.Value);
            var chars = textBox1.Text.ToCharArray();
            textBox2.Text = "";
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                int[] x = new int[20];
                x[0] = Convert.ToInt32(chars[ctr]);
                x[0] = x[0] + kluczPrywatnny + 3;
                chars[ctr] = Convert.ToChar(x[0]);
                textBox2.Text = textBox2.Text + chars[ctr];
            }
         */

    }
}
