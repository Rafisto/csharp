using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongsBase
{
    public partial class NewSong : Form
    {
        public Form1 f;
        public NewSong()
        {
            InitializeComponent();
        }
        public string songName = null;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                songName = textBox1.Text;
                f.CreateSong(songName);
                this.Close();
            }
        }
    }
}
