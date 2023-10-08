using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encode_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string kod = richTextBox1.Text;
            kod = code(kod);
            richTextBox2.Text = kod;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string unkod = richTextBox1.Text;
            richTextBox2.Text = uncode(unkod);
        }

        public string pattern = "a8b+c-d(e)f1g/h*i2jk'l3m9n4o0p5q{r6s~t7u}v<w,x]y[z. =";

        private string code(string text)
        {
            string coded = text;
            string cd = "";
            foreach(char x in coded)
            {
                int index = pattern.IndexOf(x);
                cd += x.ToString().Replace(x,pattern[index+1]);
            }

            return cd;
        }
        private string uncode(string text)
        {
            string coded = text;
            string cd = "";
            foreach (char x in coded)
            {
                int index = pattern.IndexOf(x);
                cd += x.ToString().Replace(x,pattern[index - 1]);
            }

            return cd;
        }
    }
}
