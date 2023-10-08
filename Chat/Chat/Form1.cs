using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        public string lastTyped = "";
        public string[] msgs = new string[1000000];
        public string name = "";
        public int wiad = 0;
        public enum Ranga
        {
            Normal,
            Vip,
            Moderator,
        }
        public Ranga rank = Ranga.Normal;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    if (textBox1.Text.Contains("/name"))
                    {
                        name = Between(textBox1.Text, "[", "]");
                        return;
                    }
                    if (textBox1.Text.Contains("/show debug"))
                    {
                        richTextBox1.Show();
                        return;
                    }
                    if (textBox1.Text.Contains("/hide debug"))
                    {
                        richTextBox1.Hide();
                        return;
                    }
                    if (name == "")
                    {
                        MessageBox.Show("Musisz Najpierw ustalić swój nickname. Użyj komendy /name [twoje imie]", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
              
                wiad++;
                lastTyped = textBox1.Text;
                sendMessage(textBox1.Text);
                textBox1.Text = "";
                }
                catch
                {

                }
            }

        }

        public void sendMessage(string msg)
        {
            string tekst = " ["+ name + "]: " + msg + "\r\n";
            if (rank == Ranga.Moderator)
            {
                tekst = "[MOD]" + tekst;
            }
            if (rank == Ranga.Vip)
            {
                tekst = "[VIP]" + tekst;
            }
            if (rank == Ranga.Normal)
            {
                tekst = "[NRL]" + tekst;
            }
            Rchtxt.Text += tekst;
            ColorInRchTxtBox(tekst);
            msgs[wiad] = msg;
            foreach (string col in msgs)
            {
                this.ColorTxt(col, Color.Black);
            }
        }

        void ColorInRchTxtBox(string txt)
        {
            this.ColorTxt("[VIP]", Color.Gold);
            this.ColorTxt("[MOD]", Color.Red);
            this.ColorTxt("[NRL]", Color.Gray);
            if (rank == Ranga.Normal)
            {
                this.ColorTxt(name, Color.Gray);
            }
            else
            {
                this.ColorTxt(name, Color.Black);
            }
        }
        void ColorTxt(string find, Color color)
        {
            if (Rchtxt.Text.Contains(find))
            {
                var matchString = Regex.Escape(find);
                foreach (Match match in Regex.Matches(Rchtxt.Text, matchString))
                {
                    Rchtxt.Select(match.Index, find.Length);
                    Rchtxt.SelectionColor = color;
                    Rchtxt.Select(Rchtxt.TextLength, 0);
                    Rchtxt.SelectionColor = Rchtxt.ForeColor;
                };
            }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox1.Text = lastTyped;
            }
        }

        private void Rchtxt_TextChanged(object sender, EventArgs e)
        {
         /*   this.CheckKeyword("[VIP]", Color.Gold, 0);
            this.CheckKeyword("[MOD]", Color.Red, 0);
            this.CheckKeyword("[NRL]", Color.Gray, 0);
            if (rank == Ranga.Normal)
            {
                this.CheckKeyword(name, Color.Gray, 0);
            }
            else
            {
                this.CheckKeyword(name, Color.Black, 0);
            }*/
        }

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.Rchtxt.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.Rchtxt.SelectionStart;

                while ((index = this.Rchtxt.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.Rchtxt.Select((index + startIndex), word.Length);
                    this.Rchtxt.SelectionColor = color;
                    this.Rchtxt.Select(selectStart, 0);
                    this.Rchtxt.SelectionColor = Color.Black;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rank = Ranga.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rank = Ranga.Vip;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rank = Ranga.Moderator;
        }
        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }
    }
}
