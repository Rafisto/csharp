using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overlay
{
    public partial class overlay : Form
    {
        RECT rect;
        public const string WINDOW_NAME = "Client";
        IntPtr handle = FindWindow(null, WINDOW_NAME);
        public bool czyWindow = true;
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);


        public overlay()
        {
            InitializeComponent();
        }

        private void overlay_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            if (czyWindow)
            {
                this.BackColor = Color.AliceBlue;
                this.TransparencyKey = Color.AliceBlue;
                this.TopMost = true;
                int intialstyle = GetWindowLong(this.Handle, -20);
                SetWindowLong(this.Handle, -20, intialstyle | 0x80000 | 0x20);
                GetWindowRect(this.Handle, out rect);
                this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
                this.Left = rect.left;
                this.Top = rect.top;
            }
            else
            {
                this.BackColor = Color.AliceBlue;
                this.TransparencyKey = Color.AliceBlue;
                this.TopMost = true;
                int intialstyle = GetWindowLong(this.Handle, -20);
                SetWindowLong(this.Handle, -20, intialstyle | 0x80000 | 0x20);
                GetWindowRect(this.Handle, out rect);
                this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
                this.Left = rect.left;
                this.Top = rect.top;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }

        }

        Graphics g;
        Pen mypen = new Pen(Color.LightGreen);
        public Rectangle GetScreen()
        {
            return Screen.FromControl(this).Bounds;
        }
        private void overlay_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawRectangle(mypen, 100, 100, 200, 200);
        }
    }
}
