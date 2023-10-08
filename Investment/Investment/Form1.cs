using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investment
{
    public partial class Form1 : Form
    {
        public int balance = 100;
        public float ActionOfRAnim =  75;
        public float ActionOfR3dModels = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = balance.ToString();
            Random r = new Random();
            int random1 = r.Next(1, 3);
            if (random1 == 1)
            {
                ActionOfRAnim += 0.5f;
            }
            else
            {
                ActionOfRAnim -= 0.5f;
            }
            int random12 = r.Next(1, 100);
            if (random12 == 1)
            {
                ActionOfRAnim += 10.00f;
            }
            else
            {
                ActionOfRAnim -= 0.1f;
            }
            Random r2 = new Random();
            int random2 = r2.Next(1, 3);
            if (random2 == 1)
            {
                ActionOfR3dModels += 0.5f;
            }
            else
            {
                ActionOfR3dModels -= 0.5f;
            }
            CostOf3dModels.Text = ActionOfR3dModels.ToString();
            CostOfRAnim.Text = ActionOfRAnim.ToString();
        }
    }
}
