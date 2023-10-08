/*
CODE MADE BY RAFAŁ WŁODARCZYK
COPYING OR MODIFYING IS ALLOWED
DISTRIBUTING IS NOT ALLOWED
ANYONE WHO WILL BREAK THIS RULES
WILL BE SENT TO GULAG
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTool
{
    public partial class VideoPlayer : Form
    {
        public string dirtomusic;
        public Form1 form;
        public VideoPlayer()
        {
            InitializeComponent();
            this.Focus();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            axWindowsMediaPlayer1.URL = dirtomusic;
            this.Focus();
        }

        private void VideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }
    }
}
