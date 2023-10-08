using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWDNWW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = Convert.ToInt32(numericUpDown1.Value);
                b = Convert.ToInt32(numericUpDown2.Value);
                NWDNWW wynik = new NWDNWW(a, b);
                textBox1.Text = wynik.nwd().ToString();
                textBox2.Text = wynik.nww().ToString();
            }
            catch
            {

            }
        }
    }
    public class NWDNWW
    {
        public int a;
        public int b;
        public int nw;
        public int nd;

        public NWDNWW(int a1, int b1)
        {

            a = a1;
            b = b1;
        }

        public int nwd()
        {

            int x = a;
            int y = b;

            while (x != y)
            {

                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }

            nd = x;
            return nd;
        }

        public int nww()
        {

            nw = Math.Abs(a * b) / nd;
            return nw;
        }
    }
}
