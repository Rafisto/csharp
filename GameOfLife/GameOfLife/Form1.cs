using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public bool[,] Map;
        public bool started = false;
        public int counter = 0;
        public int max_x = 115;
        public int max_y = 65;
       
        Graphics g;
        Brush alive;
        Brush dead;
        Rectangle r;

        public int rect_size = 10;

        public Form1()
        {
            InitializeComponent();
            Map = new bool[max_x,max_y];
            g = panel1.CreateGraphics();
            alive = new SolidBrush(Color.Red);
            dead = new SolidBrush(Color.Black);
            r = new Rectangle(0, 0, rect_size, rect_size);
            Start();
        }

        public void Start()
        {
            for (int x = 0; x < max_x; x++)
            {
                for (int y = 0; y < max_y; y++)
                {
                    Map[x, y] = false;
                }
            }
            PrintGeneration();
        }

        public void NewGeneration()
        {
            bool[,] NewMap = new bool[max_x,max_y];
            for (int x = 0; x < max_x; x++)
            {
                for(int y = 0; y < max_y; y++)
                {
                    NewMap[x, y] = WillBeAlive(x, y);
                }
            }
            Map = NewMap;
        }

        public void SetAlive(int x, int y)
        {
            try
            {
                Map[x, y] = !Map[x, y];
            }
            catch
            {

            }
            PrintGeneration();
        }

        public void PrintGeneration()
        {
            string output = "";
            for (int x = 0; x < max_x; x++)
            {
                for (int y = 0; y < max_y; y++)
                {
                    r.Location = new Point(rect_size * x, rect_size * y);
                    if (Map[x, y])
                    {
                        g.FillRectangle(alive, r);
                    }
                    else
                    {
                        g.FillRectangle(dead, r);
                    }
                }
            }
            
        }

        public bool WillBeAlive(int x_coord, int y_coord)
        {
            int alive_neighbours = CountAlive(x_coord, y_coord);
            if (Map[x_coord, y_coord])
            {
                if (alive_neighbours == 2 || alive_neighbours == 3)
                {
                    return true;
                }
                else if (alive_neighbours < 2 || alive_neighbours > 3)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (alive_neighbours == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
            
        public int CountAlive(int x_coord, int y_coord)
        {
            int sum = 0;
            if (x_coord + 1 < max_x)
            {
                if (Map[x_coord + 1, y_coord])
                {
                    sum++;
                }
            }
            if (x_coord - 1 > 0)
            {
                if (Map[x_coord - 1, y_coord])
                {
                    sum++;
                }
            }
            if (y_coord + 1 < max_y)
            {
                if (Map[x_coord, y_coord + 1])
                {
                    sum++;
                }
            }
            if (y_coord - 1 > 0)
            {
                if (Map[x_coord, y_coord - 1])
                {
                    sum++;
                }
            }
            if (x_coord + 1 < max_x && y_coord + 1 < max_y)
            {
                if (Map[x_coord + 1, y_coord + 1])
                {
                    sum++;
                }
            }
            if (x_coord + 1 < max_x && y_coord - 1 > 0)
            {
                if (Map[x_coord + 1, y_coord - 1])
                {
                    sum++;
                }
            }
            if (x_coord - 1 > 0 && y_coord + 1 < max_y)
            {
                if (Map[x_coord - 1, y_coord + 1])
                {
                    sum++;
                }
            }
            if (x_coord - 1 > 0 && y_coord - 1 > 0)
            {
                if (Map[x_coord - 1, y_coord - 1])
                {
                    sum++;
                }
            }
            return sum;
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter <= 1)
            {
                button1.Text = "Start";
                Start();
            }
            if (counter > 1)
            {
                timer1.Enabled = !timer1.Enabled;
                if (timer1.Enabled == false)
                {
                    button1.Text = "Start";
                }
                else
                {
                    button1.Text = "Stop";
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);
            decimal x = point.X;
            decimal y = point.Y;
            int coord_x = (int)Math.Floor(x / 10);
            int coord_y = (int)Math.Floor(y / 10);
            SetAlive(coord_x, coord_y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NewGeneration();
            PrintGeneration();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)trackBar1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to load data from input.txt?", "Loading data", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string[] pixels = File.ReadAllLines("input.txt");
                    foreach (string pixel in pixels)
                    {
                        if (pixel[0] == '#')
                        {
                            continue;
                        }
                        else if (pixel == "")
                        {
                            continue;
                        }

                        else
                        {

                            string[] xy = pixel.Split(' ');
                            SetAlive(Convert.ToInt32(xy[0]), Convert.ToInt32(xy[1]));
                        }
                    }
                }
                catch
                {

                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the data to output.txt?", "Saving data", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    List<string> saving = new List<string>();
                    for (int x = 0; x < max_x; x++)
                    {
                        for (int y = 0; y < max_y; y++)
                        {
                            if (Map[x, y])
                            {
                                saving.Add(x.ToString() + " " + y.ToString());
                            }
                        }
                    }
                    File.WriteAllLines("output.txt", saving.ToArray());
                }
                catch
                {

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap("input.png");
            try
            {
                for (int x = 0; x < max_x; x++)
                {
                    for (int y = 0; y < max_y; y++)
                    {
                        if (bitmap.GetPixel(x, y).R > Convert.ToInt32(trackBar2.Value))
                        {
                            Map[x, y] = true;
                        }
                        else if(bitmap.GetPixel(x,y).G > Convert.ToInt32(trackBar3.Value))
                        {
                            Map[x, y] = true;
                        }
                        else if(bitmap.GetPixel(x, y).B > Convert.ToInt32(trackBar4.Value))
                        {
                            Map[x, y] = true;
                        }
                        else
                        {
                            Map[x, y] = false;
                        }
                    }
                }
            }
            catch
            {

            }
            PrintGeneration();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
