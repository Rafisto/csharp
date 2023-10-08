using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool CanPaint = false;
        public Color c = Color.Black;
        public int BrushSize = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graph = obrazek.CreateGraphics();
            graph.Clear(BackColor);
        }

        private void obrazek_MouseMove(object sender, MouseEventArgs e)
        {
            if (CanPaint)
            {           
                Graphics graph = obrazek.CreateGraphics();
                SolidBrush color = new SolidBrush(c);
                graph.FillEllipse(color, e.X, e.Y, BrushSize,BrushSize);
            }
        }

        private void obrazek_MouseUp(object sender, MouseEventArgs e)
        {
            CanPaint = false;
        }

        private void obrazek_MouseDown(object sender, MouseEventArgs e)
        {
            CanPaint = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            c = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c = Color.Lime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = Color.Blue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c = Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            c = Color.White;
            BrushSize = 100;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            BrushSize = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
