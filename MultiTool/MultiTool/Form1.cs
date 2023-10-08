/*
CODE MADE BY RAFAŁ WŁODARCZYK
COPYING OR MODIFYING IS ALLOWED
DISTRIBUTING IS NOT ALLOWED
ANYONE WHO WILL BREAK THIS RULES
WILL BE SENT TO GULAG
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace MultiTool
{
    public partial class Form1 : Form
    {
        Multi_Tool m_tool;
        TextRecover t_tool;
        public Form1()
        {
            InitializeComponent();
            m_tool = new Multi_Tool();
            t_tool = new TextRecover();
            t_tool.form = this;

            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                t_tool.Understand(textBox1.Text);
                m_tool.RemoveText(textBox1);
            }
            if (e.KeyChar == (char)27)
            {
                m_tool.Shutdown();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_tool.Shutdown();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_tool.ShowHelp();
        }
    }
    class Multi_Tool{
        public void RemoveText(TextBox txt)
        {
            txt.Text = "";
        }
        public void Shutdown()
        {
            Process.GetCurrentProcess().Kill();
        }
        public void ShowHelp()
        {
            MessageBox.Show("Available Commands with params:\n-x\n-?\n-s (search query)\n-r (program to run)\n-tten (word to english)\n-ttde (word to deutsch)\n-tf (word to polish)\n-kill (process)\nOther commands:\n-yt,youtube,Youtube(www.youtube.pl)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SaveVideoToDisk(string link, string nameOnDisk)
        {
            var youTube = YouTube.Default; // starting point for YouTube actions
            var video = youTube.GetVideo(link); // gets a Video object with info about the video
            string ur = Environment.CurrentDirectory + "/M_Tool_Videos/" + nameOnDisk;
            File.WriteAllBytes(ur, video.GetBytes());
        }
    }
    class TextRecover
    {
        public Form1 form;
        public void Understand(string command)
        {
            try
            {
                Multi_Tool m = new Multi_Tool();
                if (command == null || command == "")
                {
                    return;
                }
                if (command == "?")
                {
                    m.ShowHelp();
                }
                if (command == "x")
                {
                    m.Shutdown();
                }
                if (command == "cur" || command == "current")
                {
                    Process.Start(Environment.CurrentDirectory);
                    Shutdown();
                }
                {
                    m.Shutdown();
                }
                if (command == "Youtube" || command == "youtube" || command == "yt")
                {
                    Process.Start("http://www.youtube.pl");
                    Shutdown();
                }
                else if (command == "gmail")
                {
                    Process.Start("https://mail.google.com/mail/u/0/#inbox");
                    Shutdown();
                }
                else if (command == "dev")
                {
                    DevWindow d = new DevWindow();
                    d.Show();
                }
                else if (command.Contains("dvid "))
                {
                    if (command.Contains(".mp4"))
                    {

                    }
                    else
                    {
                        command += ".mp4";
                    }
                    command = command.Replace("dvid ", "dvideo");
                    command = command.Replace(" ", "]");
                    command = command.Replace("dvideo", "[");
                    string cmd = Between(command, "[", "]");
                    command = command.Replace("[" + Between(command, "[", "]") + "]", "");
                    m.SaveVideoToDisk(cmd, command);

                }
                else if (command.Contains("play "))
                {
                    command = command.Replace("play ", "");
                    if (command.Contains(".mp4"))
                    {

                    }
                    else
                    {
                        command += ".mp4";
                    }
                    string ur = Environment.CurrentDirectory + "/M_Tool_Videos/" + command;
                    VideoPlayer v = new VideoPlayer();
                    v.dirtomusic = ur;
                    form.Hide();
                    v.form = form;
                    v.Show();

                }
                else if (command.Contains("s "))
                {
                    command = command.Replace("s ", "");
                    Process.Start("http://www.google.pl/search?q=" + GenerateUrl(command));
                    Shutdown();
                }
                else if (command.Contains("r "))
                {
                    Process.Start(command.Replace("r ", ""));
                    Shutdown();
                }
                else if (command.Contains("tten "))
                {
                    command = command.Replace("tten ", "");
                    Process.Start("https://translate.google.pl/#pl/en/" + GenerateUrl(command));
                    Shutdown();
                }
                else if (command.Contains("ttde "))
                {
                    command = command.Replace("ttde ", "");
                    Process.Start("https://translate.google.pl/#pl/de/" + GenerateUrl(command));
                    Shutdown();
                }
                else if (command.Contains("tf "))
                {
                    command = command.Replace("tf ", "");
                    Process.Start("https://translate.google.pl/#auto/pl/" + GenerateUrl(command));
                    Shutdown();
                }
                else if (command.Contains("kill "))
                {
                    command = command.Replace("kill ", "");
                    Process[] p = Process.GetProcessesByName(command);
                    foreach (Process x in p)
                    {
                        x.Kill();
                    }
                    Shutdown();
                }
              
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            
        }
        void Shutdown()
        {
            Process.GetCurrentProcess().Kill();
        }
        string GenerateUrl(string searchString)
        {
            string finalString = null;
            string[] Words = searchString.Split(' ');
            for (int i = 0; i < Words.Length; i++)
            {
                if (i == 0)
                    finalString = Words[i];
                else
                    finalString = string.Concat(finalString, '+', Words[i]);
            }
            return finalString;
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
