using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAsCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string patternBigToSmall = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = code(richTextBox1.Text);
            string value = new DataTable().Compute(richTextBox2.Text, null).ToString();
            try
            {
                richTextBox2.Text += "=" + Convert.ToInt32(value).ToString();
            }
            catch
            {
                richTextBox2.Text += "=" + Convert.ToDouble(value).ToString("0.00");
            }
        }
        private string code(string ToCode) {
            try
            {
                string coded = "";
                foreach (char x in ToCode)
                {
                    if (Convert.ToInt32(x) > 64 && Convert.ToInt32(x) < 91)
                    {
                        int index = patternBigToSmall.IndexOf(x);
                        coded += x.ToString().Replace(x, patternBigToSmall[index + 1]);
                    }
                    else
                    {
                        coded += x;
                    }
                }
                coded = coded.Replace("a", "+10");
                coded = coded.Replace("b", "/11");
                coded = coded.Replace("c", "/12");
                coded = coded.Replace("d", "*13");
                coded = coded.Replace("e", "+14");
                coded = coded.Replace("f", "-15");
                coded = coded.Replace("g", "+16");
                coded = coded.Replace("h", "-17");
                coded = coded.Replace("i", "/18");
                coded = coded.Replace("j", "+19");
                coded = coded.Replace("k", "*20");
                coded = coded.Replace("l", "-21");
                coded = coded.Replace("m", "-22");
                coded = coded.Replace("n", "+23");
                coded = coded.Replace("o", "/24");
                coded = coded.Replace("p", "/25");
                coded = coded.Replace("q", "-26");
                coded = coded.Replace("r", "+27");
                coded = coded.Replace("s", "-28");
                coded = coded.Replace("t", "-29");
                coded = coded.Replace("u", "/30");
                coded = coded.Replace("v", "*31");
                coded = coded.Replace("w", "*32");
                coded = coded.Replace("x", "/33");
                coded = coded.Replace("y", "-34");
                coded = coded.Replace("z", "+35");
                coded = coded.Replace(" ", ".0");
                coded = coded.Remove(0, 1);
                return coded;
            }
            catch
            {
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
        private string Uncode(string ToUncode)
        {
            try
            {
                string coded = "";
                int index = ToUncode.IndexOf("=");
                if (index > 0) coded = ToUncode.Substring(0, index);
                coded = coded.Replace("+10", "a");
                coded = coded.Replace("/11", "b");
                coded = coded.Replace("/12", "c");
                coded = coded.Replace("*13", "d");
                coded = coded.Replace("+14", "e");
                coded = coded.Replace("-15", "f");
                coded = coded.Replace("+16", "g");
                coded = coded.Replace("-17", "h");
                coded = coded.Replace("/18", "i");
                coded = coded.Replace("+19", "j");
                coded = coded.Replace("*20", "k");
                coded = coded.Replace("-21", "l");
                coded = coded.Replace("-22", "m");
                coded = coded.Replace("+23", "n");
                coded = coded.Replace("/24", "o");
                coded = coded.Replace("/25", "p");
                coded = coded.Replace("-26", "q");
                coded = coded.Replace("+27", "r");
                coded = coded.Replace("-28", "s");
                coded = coded.Replace("-29", "t");
                coded = coded.Replace("/30", "u");
                coded = coded.Replace("*31", "v");
                coded = coded.Replace("*32", "w");
                coded = coded.Replace("/33", "x");
                coded = coded.Replace("-34", "y");
                coded = coded.Replace("+35", "z");

                coded = coded.Replace("10", "a");
                coded = coded.Replace("11", "b");
                coded = coded.Replace("12", "c");
                coded = coded.Replace("13", "d");
                coded = coded.Replace("14", "e");
                coded = coded.Replace("15", "f");
                coded = coded.Replace("16", "g");
                coded = coded.Replace("17", "h");
                coded = coded.Replace("18", "i");
                coded = coded.Replace("19", "j");
                coded = coded.Replace("20", "k");
                coded = coded.Replace("21", "l");
                coded = coded.Replace("22", "m");
                coded = coded.Replace("23", "n");
                coded = coded.Replace("24", "o");
                coded = coded.Replace("25", "p");
                coded = coded.Replace("26", "q");
                coded = coded.Replace("27", "r");
                coded = coded.Replace("28", "s");
                coded = coded.Replace("29", "t");
                coded = coded.Replace("30", "u");
                coded = coded.Replace("31", "v");
                coded = coded.Replace("32", "w");
                coded = coded.Replace("33", "x");
                coded = coded.Replace("34", "y");
                coded = coded.Replace("35", "z");

                coded = coded.Replace(".0", " ");
                coded = coded.Replace("0", " ");
                return coded;
            }
            catch
            {
                MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Uncode(richTextBox1.Text);
        }
    }
}
