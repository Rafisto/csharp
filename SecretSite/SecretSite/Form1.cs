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

namespace SecretSite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ważna metoda - nie kasuj
        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }

        // hasło do strony
        public string pass = null;
        // nazwa strony
        public string filename = null;
        // obsługa konsoli
        private bool unlocked = false;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    if (textBox1.Text == "unlock")
                    {
                        unlocked = true;
                        richTextBox1.Text += "\r\nUnlocked\r\n";
                        textBox1.Text = "";
                    }
                    if( textBox1.Text == "lock")
                    {
                        unlocked = false;
                        richTextBox1.Text += "\r\nLocked\r\n";
                        textBox1.Text = "";
                    }
                    if (unlocked)
                    {
                        #region setpass
                        if (textBox1.Text.Contains("pass"))
                        {
                            textBox1.Text = textBox1.Text.Replace("pass ", "");
                            textBox1.Text = textBox1.Text.Replace(" ", "");
                            pass = textBox1.Text;
                            textBox1.Text = "";
                            richTextBox1.Text += "\r\nPassword - [" + pass.Length + "] characters";
                        }
                        #endregion
                        #region setfilename
                        if (textBox1.Text.Contains("filename"))
                        {
                            textBox1.Text = textBox1.Text.Replace("filename ", "");
                            textBox1.Text = textBox1.Text.Replace(" ", "");
                            filename = textBox1.Text;
                            textBox1.Text = "";
                            richTextBox1.Text += "\r\nFilename - [" + filename + "]";
                        }
                        #endregion
                        #region open
                        if (textBox1.Text == "open")
                        {
                            try
                            {
                                richTextBox1.Text += "\r\n" + "Typed filename [" + filename + "]\r\n";
                                richTextBox1.Text += "Typed password - [" + pass + "]" + "\r\n";
                                WebClient c = new WebClient();
                                string content = c.DownloadString("http://rack.c0.pl/SecretSite/" + filename + ".txt");
                                richTextBox1.Text += "Got content" + "\r\n";
                                string password = Between(content, "<pass>", "</pass>");
                                richTextBox1.Text += "Got password" + "\r\n";
                                if (password == pass)
                                {
                                    richTextBox1.Text += "Access allowed" + "\r\n";
                                    content = Between(content, "<all>", "</all>");
                                    richTextBox1.Text += "Transfered content." + "\r\n";
                                    content = content.Replace("[enter]", "\r");
                                    richTextBox2.Text = content;
                                    richTextBox1.Text += "Ended" + "\r\n";
                                    textBox1.Text = "";
                                }
                                else
                                {
                                    richTextBox1.Text += "Access denied." + "\r\n";
                                    textBox1.Text = "";
                                }
                            }
                            catch
                            {
                                richTextBox1.Text += "Something went wrong." + "\r\n";
                                textBox1.Text = "";
                            }
                        }
                        #endregion
                        if (textBox1.Text == "clear")
                        {
                            richTextBox1.Text = "";
                            richTextBox1.Text = "Secret Sit€ standalone console build 1.3.\r\nAuthor - Rafal Wlodarczyk";
                        }
                        #region delete
                        if (textBox1.Text == "delete")
                        {
                            System.IO.Directory.CreateDirectory("C:/tymc/");
                            string str = "";
                            File.WriteAllText("C:/tymc/tymc.txt", str);
                            using (WebClient client = new WebClient())
                            {
                                client.Credentials = new NetworkCredential("Rafisto5", "Thegame1");
                                client.UploadFile("ftp://rack.c0.pl/rack.c0.pl/SecretSite/" + filename + ".txt", "STOR", "C:/tymc/tymc.txt");
                            }
                            richTextBox1.Text += "\r\nDeleted file succesful";
                            textBox1.Text = "";
                        }
                        #endregion
                        if (textBox1.Text.Contains("fuck") || textBox1.Text.Contains("Fuck"))
                        {
                            if (textBox1.Text.Contains("you") || textBox1.Text.Contains("You"))
                            {
                                richTextBox1.Text += "\r\nFuck you too.";
                                richTextBox1.ReadOnly = true;
                                textBox1.ReadOnly = true;
                            }
                        }

                    }
                }
            }
            catch
            {
            }
        }

        // wyjdź
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        // stwórz strone
        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create c = new Create();
            c.Show();
        }
        // usuń strone
        private void deleteSecretSitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To remove Secret Sit€ you have to type correct command.\r\nCommand: delete","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
