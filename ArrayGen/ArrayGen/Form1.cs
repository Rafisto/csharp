using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rows_value = Convert.ToInt32(rows.Value);
            int columns_value = Convert.ToInt32(columns.Value);
            int min_value = Convert.ToInt32(min.Value);
            int max_value = Convert.ToInt32(max.Value);
            string spliter_value = spliter.Text;
            List<string> vals = new List<string>();

            for (int x = 0; x < rows_value; x++)
            {
                string outp = "";
                for (int y = 0; y < columns_value; y++)
                {
                    if (checkBox1.Checked)
                    {
                        outp += rnd.Next(min_value, max_value).ToString() + spliter_value;
                        if (vals.Contains(outp))
                        {
                            y--;
                            continue;
                        }
                    }
                    else
                    {
                        outp += rnd.Next(min_value, max_value).ToString() + spliter_value;
                    }
                }
                outp = outp.Remove(outp.Length - 1);
                vals.Add(outp);
            }
            richTextBox1.Lines=vals.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null && richTextBox1.Text != "")
            {
                Clipboard.SetText(richTextBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the data to output.txt?", "Saving data", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    File.WriteAllText("output.txt", richTextBox1.Text);
                }
                catch
                {

                }
            }
        }
    }
}
