using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "abcdefghijklmnopqrstuvwxyz";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "abcdefghijklmnopqrstuvwxyz0123456789";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "abcdefghijklmnopqrstuvwxyz0123456789~!@#$%^&*()-=_+[]{}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = RandomString(Convert.ToInt32(numericUpDown1.Value), textBox1.Text);

        }
        private static Random random = new Random();
        public static string RandomString(int length,string chars)
        {
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
