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

namespace Bank
{
    public partial class mainaccount : Form
    {
        public string username = null;
        public double balance = 0;
        public mainaccount()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            label20.Text = "";
        }

        private void mainaccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        public string GetBetween(string text, string first, string last)
        {
            return text.Substring(text.IndexOf(first) + first.Length, text.IndexOf(last) - text.IndexOf(first) - first.Length);
        }

        // main account info tab
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        // make a transfer tab
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void initializationtimer_Tick(object sender, EventArgs e)
        {
            initializationtimer.Enabled = false;
            label1.Text = "Wallet ID is " + username + ".";
            setupBalance();
        }
        void setupBalance() {
            WebClient wc = new WebClient();
            string toCheckPass = wc.DownloadString("http://www.rack.c0.pl/BankRCOIN/" + username + ".txt");
            balance = Convert.ToDouble(GetBetween(toCheckPass, "<rcoin>", "</rcoin>"));
            label2.Text = "You have " + balance + " rcoins.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (n * 0.98).ToString();
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            try
            {
                string id = textBox1.Text;
                double finaltotransfer = Convert.ToDouble(textBox3.Text);
                if(balance < finaltotransfer / 0.98)
                {
                    progressBar1.Value = 0;
                    label20.Text = "not enough money";
                    return;
                }

                // przelew natychmiastowy do kogoś
                WebClient w = new WebClient();
                string strtotransfer = w.DownloadString("http://www.rack.c0.pl/BankRCOIN/" + id + ".txt");
                double first = Convert.ToDouble(GetBetween(strtotransfer, "<rcoin>", "</rcoin>"));
                double last = first + finaltotransfer;
                strtotransfer = strtotransfer.Replace(first.ToString(), last.ToString());
                Directory.CreateDirectory("C:/tymc/");
                File.WriteAllText("C:/tymc/tymc.txt", strtotransfer);
                using (WebClient client = new WebClient())
                {
                    client.Credentials = new NetworkCredential("Rafisto5", "Thegame1");
                    client.UploadFile("ftp://www.rack.c0.pl/rack.c0.pl/BankRCOIN/" + id + ".txt", "STOR", "C:/tymc/tymc.txt");
                }
                // odebranie pieniędzy
                string strtotransfero = w.DownloadString("http://www.rack.c0.pl/BankRCOIN/" + username + ".txt");
                double firsto = Convert.ToDouble(GetBetween(strtotransfero, "<rcoin>", "</rcoin>"));
                double lasto = firsto - finaltotransfer / 0.98;
                strtotransfero = strtotransfero.Replace(firsto.ToString(), lasto.ToString());
                Directory.CreateDirectory("C:/tymc/");
                File.WriteAllText("C:/tymc/tymc.txt", strtotransfero);
                using (WebClient client = new WebClient())
                {
                    client.Credentials = new NetworkCredential("Rafisto5", "Thegame1");
                    client.UploadFile("ftp://www.rack.c0.pl/rack.c0.pl/BankRCOIN/" + username + ".txt", "STOR", "C:/tymc/tymc.txt");
                }
                progressBar1.Value = 100;
                label20.Text = "sent";
            }
            catch
            {
                progressBar1.Value = 0;
                label20.Text = "error";
            }
            setupBalance();
        }
    }
}
