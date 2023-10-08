using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DiagnosticDivideChecker
{
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            thread = new Thread(ObliczDzielniki);
        }

        public int aeki;
        public int xiksy;
        public int dzielniki;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!thread.IsAlive)
            {
                thread = new Thread(ObliczDzielniki);
                thread.Start();
                button1.Enabled = false;
            }
            else if (thread.ThreadState == ThreadState.Suspended)
            {
                thread.Resume();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Suspend();
                button1.Enabled = true;
            }
            catch
            {

            }
        }
        public int procesy = 0;
        public void ObliczDzielniki()
        {
            try
            {
                aeki = int.Parse(textBox1.Text);
                xiksy = int.Parse(textBox2.Text);
                dzielniki = int.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Zostały wpisane wartości niebędące liczbami naturalnymi.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Invoke((Action)(() => button1.Enabled = true));
                return;
            }
            textBox5.Invoke((Action)(() => textBox5.Text = Convert.ToString(aeki * xiksy * dzielniki)));
            progressBar1.Invoke((Action)(() => progressBar1.Maximum = aeki * xiksy * dzielniki));
            for (int a = 2; a <= aeki; a++)
            {
                for (int x = 1; x <= xiksy; x++)
                {
                    // diagnostic
                    procesy++;
                    progressBar1.Invoke((Action)(() => progressBar1.Value = procesy));
                    progressBar1.Invoke((Action)(() => progressBar1.Update()));
                    textBox4.Invoke((Action)(() => textBox4.Text = procesy.ToString()));
                    // ^^ diagnostic
                    double z = Convert.ToDouble(a);
                    double y = Convert.ToDouble(x);
                    double wynik = (Math.Pow(z, y)) - 1;
                    if (wynik % dzielniki == 0)
                    {
                        richTextBox1.Invoke((Action)(() => richTextBox1.Text += a + "^" + x + "-1" + " jest podzielne przez " + dzielniki + "\r\n"));
                    }
                }
                button1.Invoke((Action)(() => button1.Enabled = true));
                progressBar1.Invoke((Action)(() => progressBar1.Value = progressBar1.Maximum));
                progressBar1.Invoke((Action)(() => progressBar1.Update()));
                textBox4.Invoke((Action)(() => textBox4.Text = progressBar1.Maximum.ToString()));
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(thread.ThreadState == ThreadState.Suspended) {
                thread.Resume();
            }
            thread.Abort();
        }
    }
}