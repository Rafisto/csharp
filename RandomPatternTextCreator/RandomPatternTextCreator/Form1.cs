using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPatternTextCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string srtg = "";
            Random r = new Random();
            for (int x = 1; x < 1000; x++)
            {
                string prefix = "<b" + x + ">" + "<b>Tree1</b>";
                string suffix = "</b" + x + ">";
                string x2 = "<x>"+r.Next(0,501)+"</x>";
                string y = "<y>0</y>";
                string z = "<z>" + r.Next(0, 501) + "</z>";
                srtg = srtg + prefix + x2 + y + z + suffix;
            }
            srtg = "<main><bNum>999</bNum>" + srtg + "</main>";
            richTextBox1.Text = srtg;
        }
    }
}
