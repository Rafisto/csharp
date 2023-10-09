using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vingardzki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWords();
        }

        public enum CzMowy
        {
            Czasownik,
            Rzeczownik,
            Przymiotnik,
            Liczebnik,
            Zaimek
        }

        public static CzMowy SpeechMode = CzMowy.Czasownik;

        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtboxpl.Text = text;
            Translation ToVingard = new Translation();
            if (SpeechMode == CzMowy.Czasownik)
            {
                txtboxvinprzesz.Text = ToVingard.Translate(text) + "von";
                txtboxvintraz.Text = ToVingard.Translate(text) + "tún";
                txtboxvinprzysz.Text = ToVingard.Translate(text) + "nan";
                txtboxvinlpoj.Text = ToVingard.Translate(text) + "tún";
                txtboxvinlmn.Text = ToVingard.Translate(text) + "túnko";
            }
            else if (SpeechMode == CzMowy.Rzeczownik)
            {
                txtboxvinprzesz.Text = "";
                txtboxvintraz.Text = "";
                txtboxvinprzysz.Text = "";
                txtboxvinlpoj.Text = ToVingard.Translate(text);
                txtboxvinlmn.Text = ToVingard.Translate(text) + "ko";
            }
        }

        void InitializeWords()
        {
            listBox1.Items.Clear();
            if (SpeechMode == CzMowy.Czasownik)
            {
                foreach (string s in GetTranslatedFiles.Czasowniki())
                {
                    string x = s;
                    x = Between(s, "<pl>", "</pl>");
                    listBox1.Items.Add(x);
                }
            }
            if (SpeechMode == CzMowy.Rzeczownik)
            {
                foreach (string s in GetTranslatedFiles.Rzeczowniki())
                {
                    string x = s;
                    x = Between(s, "<pl>", "</pl>");
                    listBox1.Items.Add(x);
                }
            }
        }

        private void txtboxpl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                try
                {
                    listBox1.SelectedItem = txtboxpl.Text;
                }
                catch
                {
                    MessageBox.Show("Nie ma takiego wyrazu.");
                }
            }
        }

        private void słowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void czasownikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechMode = CzMowy.Czasownik;
            InitializeWords();
        }

        private void rzeczownkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechMode = CzMowy.Rzeczownik;
            InitializeWords();
        }
    }
    public class Translation
    {
        public string Translate(string polish)
        {
            string translated;
            if (Form1.SpeechMode == Form1.CzMowy.Czasownik)
            {
                foreach (string s in GetTranslatedFiles.Czasowniki())
                {
                    if (s.Contains(polish))
                    {
                        translated = Between(s, "<vin>", "</vin");
                        return translated;
                    }
                }
            }
            else if (Form1.SpeechMode == Form1.CzMowy.Rzeczownik)
            {
                foreach (string s in GetTranslatedFiles.Rzeczowniki())
                {
                    if (s.Contains(polish))
                    {
                        translated = Between(s, "<vin>", "</vin");
                        return translated;
                    }
                }
            }
            return null;
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
    public static class GetTranslatedFiles
    {
        public static string[] Czasowniki()
        {         
            return System.IO.File.ReadAllLines("czasowniki.txt");
        }
        public static string[] Rzeczowniki()
        {
            return System.IO.File.ReadAllLines("rzeczowniki.txt");
        }
    }
}
