using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialCommunicator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort port;
        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            string comport = "COM" + Convert.ToInt32(numericUpDown1.Value);
            port = new SerialPort(comport, 9600);
            message = message.Replace("a","120");
            message = message.Replace("b", "21110");
            message = message.Replace("c", "21210");
            message = message.Replace("d", "2110");
            message = message.Replace("e", "10");
            message = message.Replace("f", "11210");
            message = message.Replace("g", "2210");
            message = message.Replace("h", "11110");
            message = message.Replace("i", "110");
            message = message.Replace("j", "12220");
            message = message.Replace("k", "2120");
            message = message.Replace("l", "1211");
            message = message.Replace("m", "220");
            message = message.Replace("n", "210");
            message = message.Replace("o", "2220");
            message = message.Replace("p", "12210");
            message = message.Replace("q", "22120");
            message = message.Replace("r", "1210");
            message = message.Replace("s", "1110");
            message = message.Replace("t", "20");
            message = message.Replace("u", "1120");
            message = message.Replace("v", "11120");
            message = message.Replace("w", "1220");
            message = message.Replace("x", "21120");
            message = message.Replace("y", "21220");
            message = message.Replace("z", "22110");
            MessageBox.Show(message);
            string[] chunks = Split(message);
            foreach (string msg in chunks)
            {
                port.Open();
                port.Write(msg);
                port.Close();
            }

        }
        static string[] Split(string str)
        {
            int chunkSize = 8;
            int stringLength = str.Length;
            List<string> list = new List<string>();
            for (int i = 0; i < stringLength; i += chunkSize)
            {
                if (i + chunkSize > stringLength) chunkSize = stringLength - i;
                list.Add(str.Substring(i, chunkSize));
            }
            return list.ToArray<string>();
        }
    }
}
