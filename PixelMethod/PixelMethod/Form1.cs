using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelMethod
{
    public partial class Form1 : Form
    {
        public bool[,] Map;
        public bool started = false;
        public int counter = 0;
        public int max_x = 92;
        public int max_y = 58;

        Graphics g;
        Brush alive;
        Brush dead;
        Rectangle r;


        public Form1()
        {
            InitializeComponent();
            Map = new bool[max_x, max_y];
            g = panel1.CreateGraphics();
            alive = new SolidBrush(Color.Red);
            dead = new SolidBrush(Color.Black);
            r = new Rectangle(0, 0, 10, 10);
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
            bool[,] NewMap = new bool[max_x, max_y];
            for (int x = 0; x < max_x; x++)
            {
                for (int y = 0; y < max_y; y++)
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
                    r.Location = new Point(10 * x, 10 * y);
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
            if (Map[x_coord, y_coord])
            {
                return false;
            }
            else
            {
               if(x_coord-1 > 0)
               {
                    if (Map[x_coord - 1, y_coord])
                    {
                        return true;
                    }
               }
               if(x_coord+1 < max_x)
               {
                    if (Map[x_coord + 1, y_coord])
                    {
                        return true;
                    }
               }
               if (y_coord + 1 < max_y)
               {
                    if (Map[x_coord, y_coord+1])
                    {
                        return true;
                    }
               }
               if (y_coord -1 > 0)
               {
                    if (Map[x_coord, y_coord-1])
                    {
                        return true;
                    }
               }
                if (x_coord + 1 < max_x && y_coord + 1 < max_y)
                {
                    if (Map[x_coord + 1, y_coord + 1])
                    {
                        return true;
                    }
                }
                if (x_coord + 1 < max_x && y_coord - 1 > 0)
                {
                    if (Map[x_coord + 1, y_coord - 1])
                    {
                        return true;
                    }
                }
                if (x_coord - 1 > 0 && y_coord + 1 < max_y)
                {
                    if (Map[x_coord - 1, y_coord + 1])
                    {
                        return true;
                    }
                }
                if (x_coord - 1 > 0 && y_coord - 1 > 0)
                {
                    if (Map[x_coord - 1, y_coord - 1])
                    {
                        return true;
                    }
                }
                return false;

            }
        }

        /*
         * public int CountAlive(int x_coord, int y_coord)
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

        }*/

        private void panel1_Click(object sender, EventArgs e)
        {
            /*Point point = panel1.PointToClient(Cursor.Position);
            decimal x = point.X;
            decimal y = point.Y;
            int coord_x = (int)Math.Floor(x / 10);
            int coord_y = (int)Math.Floor(y / 10);
            SetAlive(coord_x, coord_y);*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NewGeneration();
            PrintGeneration();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);
            decimal x = point.X;
            decimal y = point.Y;
            int coord_x = (int)Math.Floor(x / 10);
            int coord_y = (int)Math.Floor(y / 10);
            SetAlive(coord_x, coord_y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            Point point = panel1.PointToClient(Cursor.Position);
            decimal x = point.X;
            decimal y = point.Y;
            int coord_x = (int)Math.Floor(x / 10);
            int coord_y = (int)Math.Floor(y / 10);
            SetAlive(coord_x, coord_y);
        }
    }
}
