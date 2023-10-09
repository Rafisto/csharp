using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joystick_Connection_Agent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            textBox2.Text += value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                sp = new SerialPort("COM" + textBox1.Text, 9600, Parity.None, 8, StopBits.One);
                setup();
            }
            catch
            {

            }
        }
        public bool[] working = new bool[5];
        bool started = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!started)
            {
                if (textBox2.Text.Contains("w"))
                {
                    north.BackColor = Color.Green;
                    working[0] = true;
                }
                if (textBox2.Text.Contains("s"))
                {
                    south.BackColor = Color.Green;
                    working[1] = true;
                }
                if (textBox2.Text.Contains("a"))
                {
                    west.BackColor = Color.Green;
                    working[2] = true;
                }
                if (textBox2.Text.Contains("d"))
                {
                    east.BackColor = Color.Green;
                    working[3] = true;
                }
                if (textBox2.Text.Contains("q"))
                {
                    joy_switch.BackColor = Color.Green;
                    working[4] = true;
                }
            }
            else
            {
                if (textBox2.Text.Contains("w"))
                {
                    SendKeys.Send("w");
                }
                if (textBox2.Text.Contains("s"))
                {
                    SendKeys.Send("s");
                }
                if (textBox2.Text.Contains("a"))
                {
                    SendKeys.Send("a");
                }
                if (textBox2.Text.Contains("d"))
                {
                    SendKeys.Send("d");
                }
                if (textBox2.Text.Contains("q"))
                {
                    SendKeys.Send("q");
                }
            }
            textBox2.Text = "";
            if (working[0] && working[1] && working[2] && working[3] && working[4] && !started)
            {
                started = true;
                Process.Start("JoystickGame.exe");
            }
        }
    }
}
