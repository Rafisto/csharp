using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabGenerator
{
    public partial class Form2 : Form
    {
        public string se, b, g, d, a, E, frt;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = frt+"\r\n"+"e"+JustRootNote(comboBox1.Text,se);
        }

        public Form2()
        {
            InitializeComponent();
            frt="0|--1--2--3--4--5--6--7--8--9--10--11--12";
            se ="e|--F--F#-G--G#-A--B--H--C--C#-D---D#--E-";
            b = "b|--C--C#-D--D#-E--F--F#-G--G#-A---B---H-";
            g = "g|--G#-A--B--H--C--C#-D--D#-E--F---F#--G-";
            d = "d|--D#-E--F--F#-G--G#-A--B--H--C---C#--D-";
            a = "a|--B--H--C--C#-D--D#-E--F--F#-G---G#--A-";
            E = "E|--F--F#-G--G#-A--B--H--C--C#-D---D#--E-";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = frt + "\r\n" + se + "\r\n" + b + "\r\n" + g + "\r\n" + d + "\r\n" + a + "\r\n" + E + "\r\n";
        }
        public string JustRootNote(string rootNote,string struna)
        {
            string baseToRootNote="";
            int fst = struna.IndexOf(rootNote);
            int lst = struna.LastIndexOf(rootNote);
            if (fst != lst)
            {
                
            }
            else
            {
               
            }
            return baseToRootNote;
        }
    }
}
