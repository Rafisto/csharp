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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace MultiTool
{
    public partial class DevWindow : Form
    {
        DevMulti_Tool m_tool;
        DevTextRecover t_tool;
        int toshutdown = 5;

        public DevWindow()
        {
            InitializeComponent();
            m_tool = new DevMulti_Tool();
            t_tool = new DevTextRecover();
            t_tool.form = this;
        }
        public void appendtext(string text)
        {
            richTextBox1.Text += "\r\n"+text;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                t_tool.Understand(textBox1.Text);
                m_tool.RemoveText(textBox1);
            }
            if (e.KeyChar == (char)27)
            {
                m_tool.Shutdown();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toshutdown--;
            appendtext("!> SHUTDOWN IN "+toshutdown);
            if (toshutdown == 0)
            {
                this.Close();
            }
        }
        public void shutdownbyTimer()
        {
            timer1.Enabled = true;
        }
        public void cancelshutdownbyTimer()
        {
            timer1.Enabled = false;
        }
    }
    class DevTextRecover
    {
        public DevWindow form;
        public bool isClosing = false;

        public void Understand(string command)
        {
            try
            {
                Multi_Tool m = new Multi_Tool();
                if (command == "close")
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    form.appendtext("!> EXIT DEV MODE REQUEST");
                    isClosing = true;
                    form.shutdownbyTimer();
                    return;
                }
                if (command == "c" && isClosing == true)
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    form.appendtext("!> CANCEL EXITING REQUEST");
                    form.cancelshutdownbyTimer();
                    form.appendtext(">> CANCELED");
                    form.appendtext(">> FINISH");
                    return;
                }
                if (command == null || command == "")
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command+"]");
                    form.appendtext("!> Null exception");
                    form.appendtext(">> FINISH");
                    return;
                }
                if (command == "?")
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    form.appendtext("I> Help Form");
                    m.ShowHelp();
                    form.appendtext(">> FINISH");
                }
                if (command == "x")
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    form.appendtext("?> Shutdown Request");
                    form.appendtext(">> FINISH");
                    Shutdown();
                }
                if (command == "Youtube" || command == "youtube" || command == "yt")
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    form.appendtext("?> Start Youtube request");
                    Process.Start("http://www.youtube.pl");
                    form.appendtext(">> FINISH");
                    Shutdown();
                }
                else if (command == "gmail")
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    form.appendtext("?> Start Mail Request");
                    Process.Start("https://mail.google.com/mail/u/0/#inbox");
                    form.appendtext(">> FINISH");
                    Shutdown();
                }
                else if (command.Contains("dvid "))
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    form.appendtext("?> Downloading video request");
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
                    form.appendtext(">> FINISH");

                }
                else if (command.Contains("play "))
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
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
                    v.form = new Form1();
                    v.Show();
                    form.appendtext(">> FINISH");

                }
                else if (command.Contains("s "))
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    command = command.Replace("s ", "");
                    form.appendtext("?> Search request for [" + command + "]");
                    Process.Start("http://www.google.pl/search?q=" + GenerateUrl(command));
                    form.appendtext(">> FINISH");
                    Shutdown();
                }
                else if (command.Contains("r "))
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    form.appendtext("?> Run request for [" + command + "]");
                    Process.Start(command.Replace("r ", ""));
                    form.appendtext(">> FINISH");
                    Shutdown();
                }
                else if (command.Contains("tten "))
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    command = command.Replace("tten ", "");
                    form.appendtext("?> Translate to english request");
                    form.appendtext("I> word = " + command);
                    Process.Start("https://translate.google.pl/#pl/en/" + GenerateUrl(command));
                    form.appendtext(">> FINISH");
                    Shutdown();
                }
                else if (command.Contains("ttde "))
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    command = command.Replace("ttde ", "");
                    form.appendtext("?> Translate to german request");
                    form.appendtext("I> word = " + command);
                    Process.Start("https://translate.google.pl/#pl/de/" + GenerateUrl(command));
                    Shutdown();
                }
                else if (command.Contains("tf "))
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    command = command.Replace("tf ", "");
                    form.appendtext("?> Translate to polish request");
                    form.appendtext("I> word = " + command);
                    Process.Start("https://translate.google.pl/#auto/pl/" + GenerateUrl(command));
                    Shutdown();
                }
                else if (command.Contains("kill "))
                {
                    form.appendtext(">> START");
                    form.appendtext(">> WITH COMMAND [" + command + "]");
                    command = command.Replace("kill ", "");
                    form.appendtext("?> Process kill request");
                    form.appendtext("I> Process = " + command);
                    Process[] p = Process.GetProcessesByName(command);
                    foreach (Process x in p)
                    {
                        x.Kill();
                    }
                    Shutdown();
                }
             
            }
            catch (Exception x)
            {
                form.appendtext(x.ToString());
            }

        }
        void Shutdown()
        {
           
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
    class DevMulti_Tool
    {
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
}
