using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "";
            se = "e| ";
            b = "b| ";
            g = "g| ";
            d = "d| ";
            a = "a| ";
            E = "E| ";
        }
        public string se, b, g, d, a, E;

        private void fretboardNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                se = se.Substring(0, se.Length - 4);
                b = b.Substring(0, b.Length - 4);
                g = g.Substring(0, g.Length - 4);
                d = d.Substring(0, d.Length - 4);
                a = a.Substring(0, a.Length - 4);
                E = E.Substring(0, E.Length - 4);
                UpdateRTB();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            se = "e| ";
            b = "b| ";
            g = "g| ";
            d = "d| ";
            a = "a| ";
            E = "E| ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericUpDown1.Value) > -1)
            {
                se += numericUpDown1.Value.ToString() + "---";
            }
            else
            {
                se += "----";
            }
            if (numericUpDown2.Value > -1)
            {
                b += numericUpDown2.Value.ToString() + "---";
            }
            else
            {
                b += "----";
            }
            if (numericUpDown3.Value > -1)
            {
                g += numericUpDown3.Value.ToString() + "---";
            }
            else
            {
                g += "----";
            }
            if (numericUpDown4.Value > -1)
            {
                d += numericUpDown4.Value.ToString() + "---";
            }
            else
            {
                d += "----";
            }
            if (numericUpDown5.Value > -1)
            {
                a += numericUpDown5.Value.ToString() + "---";
            }
            else
            {
                a += "----";
            }
            if (numericUpDown6.Value > -1)
            {
                E += numericUpDown6.Value.ToString() + "---";
            }
            else
            {
                E += "----";
            }
            UpdateRTB();
        }
        public void UpdateRTB()
        {
            richTextBox1.Text = se + "\r\n" + b + "\r\n" + g + "\r\n" + d + "\r\n" + a + "\r\n" + E + "\r\n";
        }
    }
}
