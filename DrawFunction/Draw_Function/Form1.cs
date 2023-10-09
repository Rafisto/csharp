using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Draw_Function
{
    public partial class Form1 : Form
    {
        public double precise = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackpen = new Pen(Color.Black, 1);
            Pen bluepen = new Pen(Color.Blue, 1);
            Pen redpen = new Pen(Color.Red, 5);
            Pen gbluepen = new Pen(Color.Blue, 2);
            Point mid = new Point(panel1.Size.Width / 2, panel1.Size.Height / 2);

            Graphics g = e.Graphics;

            g.DrawLine(blackpen, panel1.Size.Width / 2, 0, panel1.Size.Width / 2, panel1.Size.Height);
            g.DrawLine(blackpen, 0, panel1.Size.Height / 2, panel1.Size.Width, panel1.Size.Height / 2);

            g.DrawRectangle(blackpen, mid.X - 1, mid.Y - 1, 2, 2);
            for (int x = 0; x < panel1.Size.Height / 20 - panel1.Size.Height % 20; x++)
            {
                Point k = new Point(mid.X, mid.Y + (x * 20));
                g.DrawRectangle(blackpen, k.X - 1, k.Y - 1, 2, 2);
            }
            for (int x = 0; x < panel1.Size.Height / 20 - panel1.Size.Height % 20; x++)
            {
                Point k = new Point(mid.X, mid.Y - (x * 20));
                g.DrawRectangle(blackpen, k.X - 1, k.Y - 1, 2, 2);
            }
            for (int x = 0; x < panel1.Size.Width / 20 - panel1.Size.Width % 20; x++)
            {
                Point k = new Point(mid.X + (x * 20), mid.Y);
                g.DrawRectangle(blackpen, k.X - 1, k.Y - 1, 2, 2);
            }
            for (int x = 0; x < panel1.Size.Width / 20 - panel1.Size.Width % 20; x++)
            {
                Point k = new Point(mid.X - (x * 20), mid.Y);
                g.DrawRectangle(blackpen, k.X - 1, k.Y - 1, 2, 2);
            }

            Point startval = new Point(0, 0);
            Point endval = new Point(0, 0);
            
            try
            {
                Point last = new Point(mid.X,mid.Y);
                for (double x = 0; x < 50; x++)
                {
                    string math = textBox1.Text.Replace("x", x.ToString());
                    Expression expr = new Expression(math);
                    double result = expr.calculate();                 
                    Point k = new Point(mid.X + Convert.ToInt32(x) * Convert.ToInt32(precise), mid.Y - Convert.ToInt32(result * precise));
                    g.DrawLine(gbluepen, k.X,k.Y,last.X,last.Y);
                    last = k;
                    if (k.Y == mid.Y) g.DrawRectangle(redpen, k.X - 1, k.Y - 1, 2, 2);
                    else g.DrawRectangle(bluepen, k.X - 1, k.Y - 1, 2, 2);
                    if (result * precise > panel1.Size.Height)
                    {
                        break;
                    }
                }
                last = new Point(mid.X, mid.Y);
                for (double x = 0; x < 50; x++)
                {
                    string math = textBox1.Text.Replace("x", (-1*x).ToString());
                    Expression expr = new Expression(math);
                    double result = expr.calculate();
                    try
                    {
                        Point k = new Point(mid.X - Convert.ToInt32(x) * Convert.ToInt32(precise), mid.Y - Convert.ToInt32(result * precise));
                        g.DrawLine(gbluepen, k.X, k.Y, last.X, last.Y);
                        last = k;
                        if (k.Y == mid.Y) g.DrawRectangle(redpen, k.X - 1, k.Y - 1, 2, 2);
                        else g.DrawRectangle(bluepen, k.X - 1, k.Y - 1, 2, 2);
                        if (result * precise > panel1.Size.Height)
                        {
                            break;
                        }
                    }
                    catch { }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "0" || textBox2.Text == "," || textBox2.Text == ".") return;
            precise = 20*Convert.ToDouble(textBox2.Text);
        }
    }
}
