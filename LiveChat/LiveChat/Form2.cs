using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveChat
{

    public partial class Form2 : Form
    {
        public bool czyEncode2 = false;
        public bool czyEncode3 = false;
        public bool czyEncode4 = false;
        public bool czyEncode5 = false;

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckCont();
        }

        public string name = "";
        public decimal numOfChannel = 0;
        public Form2()
        {
            InitializeComponent();
            InitTimer();
            this.CenterToScreen();
            this.ShowInTaskbar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendMessage(textBox1.Text);
            }
        }
        void SendMessage(string t)
        {
            if (t.Contains("ą") || t.Contains("ć") || t.Contains("ę") || t.Contains("ń") || t.Contains("ś") || t.Contains("ó") || t.Contains("ł") || t.Contains("ż") || t.Contains("ź"))
            {
                MessageBox.Show("No Polish characters please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string j = "[" + name + "]: " + t;
            string a = "";
            if (czyEncode2)
            {
                string y = Code(j, 15);
                WebClient w = new WebClient();
                string aj = w.DownloadString("http://www.rack.c0.pl/chatt/" + numOfChannel.ToString() + ".txt");
                aj = aj + y;
                a = aj;
            }
            else if (czyEncode3)
            {
                string y = Code(j, 20);
                WebClient w = new WebClient();
                string aj = w.DownloadString("http://www.rack.c0.pl/chatt/" + numOfChannel.ToString() + ".txt");
                aj = aj + y;
                a = aj;
            }
            else if (czyEncode4)
            {
                string y = Code(j, 30);
                WebClient w = new WebClient();
                string aj = w.DownloadString("http://www.rack.c0.pl/chatt/" + numOfChannel.ToString() + ".txt");
                aj = aj + y;
                a = aj;
            }
            else if (czyEncode5)
            {
                string y = Code(j, -5);
                WebClient w = new WebClient();
                string aj = w.DownloadString("http://www.rack.c0.pl/chatt/" + numOfChannel.ToString() + ".txt");
                aj = aj + y;
                a = aj;
            }
            else
            {
                WebClient wc = new WebClient();
                string c = wc.DownloadString("http://www.rack.c0.pl/chatt/" + numOfChannel.ToString() + ".txt");
                c = c + j + "\r\n";
                a = c;
            }



            File.WriteAllText(@"C:\plikT\1.txt", a);
            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential("rafisto5", "Thegame1");
                client.UploadFile("ftp://www.rack.c0.pl/rack.c0.pl/chatt/" + numOfChannel.ToString() + ".txt", "STOR", @"C:\plikT\1.txt");
            }
            File.Delete(@"C:\plikT\1.txt");
            textBox1.Text = "";
        }
        void CheckCont()
        {
            WebClient wc = new WebClient();
            string a = wc.DownloadString("http://www.rack.c0.pl/chatt/" + numOfChannel.ToString() + ".txt");
            label2.Text = "Name: " + name;
            label1.Text = "Channel: " + numOfChannel;
            if (czyEncode2)
            {
                a = UnCode(a, 15);
                string newText = string.Join("\r\n[", a.Split(new[] { "[" }, StringSplitOptions.RemoveEmptyEntries));
                richTextBox1.Text = newText;
                return;
            }
            else if (czyEncode3)
            {
                a = UnCode(a, 20);
                string newText = string.Join("\r\n[", a.Split(new[] { "[" }, StringSplitOptions.RemoveEmptyEntries));
                richTextBox1.Text = newText;
                return;
            }
            else if (czyEncode4)
            {
                a = UnCode(a, 30);
                string newText = string.Join("\r\n[", a.Split(new[] { "[" }, StringSplitOptions.RemoveEmptyEntries));
                richTextBox1.Text = newText;
                return;
            }
            else if (czyEncode5)
            {
                a = UnCode(a, -5);
                string newText = string.Join("\r\n[", a.Split(new[] { "[" }, StringSplitOptions.RemoveEmptyEntries));
                richTextBox1.Text = newText;
                return;
            }
            else
            {
                richTextBox1.Text = a;
            }
        }

        private void włączToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
        }

        private void wyłączToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private string Code(string text, int method)
        {
            string wyn = "";
            var chars = text.ToCharArray();
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                int[] x = new int[30];
                x[0] = Convert.ToInt32(chars[ctr]);
                x[0] = x[0] - method;
                chars[ctr] = Convert.ToChar(x[0]);
                wyn = wyn + chars[ctr];
            }
            return wyn;
        }
        private string UnCode(string text, int method)
        {
            var chars = text.ToCharArray();
            string wyn = "";
            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                int[] x = new int[20];
                x[0] = Convert.ToInt32(chars[ctr]);
                x[0] = x[0] + method;
                chars[ctr] = Convert.ToChar(x[0]);
                wyn += chars[ctr];
            }
            return wyn;
        }

        private void encode2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czyEncode2 = true;
            czyEncode3 = false;
            czyEncode4 = false;
            czyEncode5 = false;
        }
        private void brakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czyEncode2 = false;
            czyEncode3 = false;
            czyEncode4 = false;
            czyEncode5 = false;
        }

        private void encode3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czyEncode2 = false;
            czyEncode3 = true;
            czyEncode4 = false;
            czyEncode5 = false;
        }
        private void aBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czyEncode2 = false;
            czyEncode3 = false;
            czyEncode4 = true;
            czyEncode5 = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            czyEncode2 = false;
            czyEncode3 = false;
            czyEncode4 = false;
            czyEncode5 = true;
        }

        private void powrótToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 r = new Form1();
            r.Show();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ColorTheKs(Color.Red, ']');
        }
        private void ColorTheKs(Color x, char finding)
        {

            /*
            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                if (richTextBox1.Text[i] == finding)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = 1;

                    richTextBox1.SelectionColor = x;
                    richTextBox1.SelectionBackColor = x;
                }
            }
            *
            int openBrace = richTextBox1.Text.IndexOf("Red");
            while (openBrace > -1)
            {
                int endBrace = richTextBox1.Text.IndexOf("EndRed", openBrace);
                if (endBrace > -1)
                {
                    richTextBox1.SelectionStart = openBrace;
                    richTextBox1.SelectionLength = endBrace - openBrace + 1;
                    richTextBox1.SelectionColor = Color.Red;
                }
                openBrace = richTextBox1.Text.IndexOf("Red", openBrace + 1);
            }
            int openBrac = richTextBox1.Text.IndexOf("Blue");
            while (openBrac > -1)
            {
                int endBrac = richTextBox1.Text.IndexOf("EndB", openBrac);
                if (endBrac > -1)
                {
                    richTextBox1.SelectionStart = openBrac;
                    richTextBox1.SelectionLength = None.GetBetween(richTextBox1.Text, "Blue", "EndB").Length + 8;
                    richTextBox1.SelectionColor = Color.Blue;
                }
                openBrac = richTextBox1.Text.IndexOf("Blue", openBrac + 1);
            }
            */


        }
        private void ColourRrbText(RichTextBox rtb)
        {
            Regex regExp = new Regex("\b(For|Next|If|Then)\b");

            foreach (Match match in regExp.Matches(rtb.Text))
            {
                rtb.Select(match.Index, match.Length);
                rtb.SelectionColor = Color.Blue;
            }
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            ColorTheKs(Color.Green, ']');
        }

    }
    public static class None{
        public static string GetBetween(this string content, string startString, string endString)
        {
            int Start = 0, End = 0;
            if (content.Contains(startString) && content.Contains(endString))
            {
                Start = content.IndexOf(startString, 0) + startString.Length;
                End = content.IndexOf(endString, Start);
                return content.Substring(Start, End - Start);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
