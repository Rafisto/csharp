using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_002
{
    public partial class Form1 : Form
    {
        public string[] to16 = new string[1000];
        public Form1()
        {
            InitializeComponent();
            startKeyboard();
            MessageBox.Show("Ważne:\r\n-COM3 to port domyślny. Jeżeli jest inny to możesz go znaleźć w panel sterowaia >> menedżer urządzeń.\r\n-Chce żeby wyświetliło się coś innego po wciśnięciu klawisza... W tym celu zmodyfikuj presety klawiszy i zrestartuj aplikacje.","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        void startKeyboard()
        {
            if (File.Exists("C:/doklawiatury/config.raf"))
            {
                string main = System.IO.File.ReadAllText("C:/doklawiatury/config.raf");
                to16[1] = Between(main, "<1>", "</1>");
                to16[2] = Between(main, "<2>", "</2>");
                to16[3] = Between(main, "<3>", "</3>");
                to16[4] = Between(main, "<4>", "</4>");
                to16[5] = Between(main, "<5>", "</5>");
                to16[6] = Between(main, "<6>", "</6>");
                to16[7] = Between(main, "<7>", "</7>");
                to16[8] = Between(main, "<8>", "</8>");
                to16[9] = Between(main, "<9>", "</9>");
                to16[10] = Between(main, "<A>", "</A>");
            }
            else
            {
                Directory.CreateDirectory("C:/doklawiatury/");
                File.WriteAllText("C:/doklawiatury/config.raf", "<1>niedostateczny</1><2>dopuszczający</2><3>dostateczny</3><4>dobry</4><5>bardzo dobry</5><6>celujący</6><7>celujący</7><8>celujący</8><9>celujący</9><A>celujący</A>");
                startKeyboard();
            }
        }
        SerialPort sp;
        void setup()
        {
            Thread.Sleep(1000);
            try
            {
                //Set the datareceived event handler
                sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                //Open the serial port
                sp.Open();
            }
            catch
            {
                setup();
            }
        }
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Write the serial port data to the console.
            AppendTextBox(sp.ReadExisting());
        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            textBox1.Text += value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("1"))
            {
                textBox1.Text = "";
                //SendKeys.Send(to16[1]);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();

                player.SoundLocation = "videoplayback.wav";
                player.Play();
            }

            if (textBox1.Text.Contains("2"))
            {
                textBox1.Text = "";
                //SendKeys.Send(to16[2]);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();

                player.SoundLocation = "videoplaybackmorda.wav";
                player.Play();
            }

            if (textBox1.Text.Contains("3"))
            {
                textBox1.Text = "";
                SendKeys.Send(to16[3]);
            }

            if (textBox1.Text.Contains("4"))
            {
                textBox1.Text = "";
                SendKeys.Send(to16[4]);
            }
            if (textBox1.Text.Contains("5"))
            {
                textBox1.Text = "";
                SendKeys.Send(to16[5]);
            }
            if (textBox1.Text.Contains("6"))
            {
                textBox1.Text = "";
                SendKeys.Send(to16[6]);
            }
            if (textBox1.Text.Contains("7"))
            {
                textBox1.Text = "";
                SendKeys.Send(to16[7]);
            }
            if (textBox1.Text.Contains("8"))
            {
                textBox1.Text = "";
                SendKeys.Send(to16[8]);
            }
            if (textBox1.Text.Contains("9"))
            {
                textBox1.Text = "";
                SendKeys.Send(to16[9]);
            }
            if (textBox1.Text.Contains("A"))
            {
                textBox1.Text = "";
                SendKeys.Send(to16[10]);
            }
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp = new SerialPort(textBox2.Text, 9600, Parity.None, 8, StopBits.One);
            setup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe","C:/doklawiatury/config.raf");
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
