using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encode_4._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Code();
        }
        private void Code()
        {
            var chars = textBox1.Text.ToCharArray();
            textBox2.Text = "";
            try
            {
                for (int ctr = 0; ctr < chars.Length; ctr++)
                {
                    int[] x = new int[2000];
                    x[0] = Convert.ToInt32(chars[ctr]);
                    // tutaj kodowanie lub deszyfracja
                    x[0] = x[0] - Convert.ToInt32(numericUpDown1.Value);
                    //             
                    chars[ctr] = Convert.ToChar(x[0]);
                    textBox2.Text = textBox2.Text + chars[ctr];
                }
                textBox2.Text = textBox2.Text.Replace("®", " ");
                textBox2.Text = textBox2.Text.Replace("!", " ");
            }
            catch
            {
                MessageBox.Show("Wkradł się błąd: index jest niepoprawny. Spróbuj przetłumaczyć mniejszą ilośc tekstu lub zmniejsz wartość szyfrowania");
            }
        }
    }
}
