using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;

namespace Overlay
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            overlay o = new overlay();
            o.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            overlay o = new overlay();
            o.czyWindow = false;
            o.ShowDialog();
        }
    }
}
