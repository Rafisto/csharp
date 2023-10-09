using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vingardzki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Czasownik
            if (radioButton1.Checked)
            {
                File.AppendAllText("czasowniki.txt","<pl>" + textBox1.Text + "</pl><vin>" + textBox2.Text + "</vin>" + Environment.NewLine,Encoding.Unicode);
            }

            // Rzeczownik
            if (radioButton2.Checked)
            {
                File.AppendAllText("rzeczowniki.txt", "<pl>" + textBox1.Text + "</pl><vin>" + textBox2.Text + "</vin>" + Environment.NewLine, Encoding.Unicode);
            }



            if (radioButton3.Checked)
            {

            }
            if (radioButton4.Checked)
            {

            }
            if (radioButton5.Checked)
            {

            }

        }
    }
}
