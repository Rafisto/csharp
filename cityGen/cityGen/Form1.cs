using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cityGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool bool_linedraw = false;

        private void linesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool_linedraw = true;
            out_panel.Refresh();
        }

        private void out_panel_Paint(object sender, PaintEventArgs e)
        {

            Pen blackpen = new Pen(Color.Black, 1);
            Graphics g = e.Graphics;
            List<int[]> lines = GenerateGridLines(100, 300);
            if (bool_linedraw)
            {
                foreach (int[] line in lines)
                {
                    //MessageBox.Show(line[0].ToString() + "," + line[1].ToString() + ";" + line[2].ToString() + "," + line[3].ToString());
                    g.DrawLine(blackpen, new Point(line[0], line[1]), new Point(line[2], line[3]));
                }     
                g.Dispose();
                bool_linedraw = false;
            }
        }

        public List<int[]> GenerateLines(int total_lines, int max_length)
        {
            List<int[]> lines = new List<int[]>();
            Random random = new Random();
            for (int x = 0; x < total_lines; x++)
            {
                int[] line = new int[4];
                line[0] = random.Next(0, 800);
                line[1] = random.Next(0, 800);
                line[2] = line[0] + random.Next(0, max_length);
                line[3] = line[1] + random.Next(0, max_length);
                lines.Add(line);
            }
            return lines;
        }
        public List<int[]> GenerateGridLines(int total_lines, int max_length)
        {
            List<int[]> lines = new List<int[]>();
            Random random = new Random();
            for (int x = 0; x < total_lines; x++)
            {
                int[] line = new int[4];
                if (random.Next(0, 2) == 1)
                {
                    line[0] = random.Next(0, 800);
                    line[1] = random.Next(0, 800);
                    line[2] = line[0] + random.Next(0, max_length);
                    line[3] = line[1];
                }
                else
                {
                    line[0] = random.Next(0, 800);
                    line[1] = random.Next(0, 800);
                    line[2] = line[0];
                    line[3] = line[1] + random.Next(0, max_length);
                }
                lines.Add(line);
            }
            return lines;
        }
    }
}
