using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcc_lang_recognizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public double ComputeCoeff(double[] values1, double[] values2)
        {
            if (values1.Length != values2.Length)
                throw new ArgumentException("values must be the same length");

            var avg1 = values1.Average();
            var avg2 = values2.Average();

            var sum1 = values1.Zip(values2, (x1, y1) => (x1 - avg1) * (y1 - avg2)).Sum();

            var sumSqr1 = values1.Sum(x => Math.Pow((x - avg1), 2.0));
            var sumSqr2 = values2.Sum(y => Math.Pow((y - avg2), 2.0));

            var result = sum1 / Math.Sqrt(sumSqr1 * sumSqr2);

            return result;
        }

        public double[] percentages(string text)
        {
            List<double> percentages = new List<double>();
            foreach (char character in alphabet)
            {
                double number = text.Split(character).Length - 1;
                percentages.Add(number/text.Length);              
            }
            double[] toReturn = percentages.ToArray();
            return toReturn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reference = text_reference.Text;
            string main = text_main.Text;
            string percent = "";
            foreach(double d in percentages(reference))
            {
                percent += d.ToString("N6") + ".";
            }
            MessageBox.Show(percent);

            coefficient_answer.Text = "Coefficient: " + ComputeCoeff(percentages(reference), percentages(main)).ToString("0.00");
        }
    }
}
