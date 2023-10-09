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
using Microsoft.VisualBasic.Devices;

namespace DiagnosicSerialSender
{
    public partial class Form1 : Form
    {
        PerformanceCounter ramCounter;
        SerialPort sp;
        public bool sending = false;

        public int prog1;
        public int prog2;
        public int prog3;
        public int prog4;
        public Form1()
        {
            InitializeComponent();
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);
            string main = System.IO.File.ReadAllText(Environment.CurrentDirectory + "/saved.txt");
            prog1 = Convert.ToInt32(Between(main, "<1>", "</1>"));
            prog2 = Convert.ToInt32(Between(main, "<2>", "</2>"));
            prog3 = Convert.ToInt32(Between(main, "<3>", "</3>"));
            prog4 = Convert.ToInt32(Between(main, "<4>", "</4>"));
        }
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

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int mem = Convert.ToInt32(Convert.ToString(GetTotalMemoryInBytes() - new ComputerInfo().AvailablePhysicalMemory).Substring(0, 4));
            label2.Text = mem + "MB";
            if (sending)
            {
                if(mem > prog4)
                {
                    sp.WriteLine("4");
                    richTextBox1.Text += 4;
                }
                else if (mem > prog3)
                {
                    sp.WriteLine("3");
                    richTextBox1.Text += 3;
                }
                else if (mem > prog2)
                {
                    sp.WriteLine("2");
                    richTextBox1.Text += 2;
                }
                else if (mem < prog1)
                {
                    sp.WriteLine("1");
                    richTextBox1.Text += 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            setup();
            sending = true;
        }
        ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }
        public string Between(string STR, string FirstString, string LastString)
        {
            string FinalString;
            int Pos1 = STR.IndexOf(FirstString) + FirstString.Length;
            int Pos2 = STR.IndexOf(LastString);
            FinalString = STR.Substring(Pos1, Pos2 - Pos1);
            return FinalString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sav="";
            sav += "<1>" + numericUpDown1.Value + "</1>";
            sav += "<2>" + numericUpDown2.Value + "</2>";
            sav += "<3>" + numericUpDown3.Value + "</3>";
            sav += "<4>" + numericUpDown4.Value + "</4>";
            File.WriteAllText(Environment.CurrentDirectory + "/saved.txt", sav);
        }
    }
}
