using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWin
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
			Random rnd = new Random();
			char[] MyRandomArray = chars.OrderBy(x => rnd.Next()).ToArray();
			textBox1.Text = new string(MyRandomArray);
		}
		static string Crypt(string crypt, string hash, int rolls)
		{
			char[] x = crypt.ToCharArray();
			char[] hashes = hash.ToCharArray();
			char[] wynik = new char[1000];
			for (int k = 0; k < x.Length; k++)
			{
				wynik[k] = x[x.Length - k - 1];
			}

			for (int l = 0; l < x.Length; l++)
			{
				try
				{
					wynik[l] = hashes[Array.IndexOf(hashes, wynik[l]) + 1];
				}
				catch
				{
					wynik[l] = wynik[l];
				}
			}

			string c = new string(wynik);
			return c;
		}

		static string DeCrypt(string crypt, string hash, int rolls)
		{
			char[] x = crypt.ToCharArray();
			char[] hashes = hash.ToCharArray();
			char[] wynik = new char[1000];

			for (int l = 0; l < x.Length; l++)
			{
				try
				{
					wynik[l] = hashes[Array.IndexOf(hashes, x[l]) + 2];
				}
				catch
				{
					wynik[l] = hashes[l];
				}
			}

			for (int k = 0; k < x.Length; k++)
			{
				wynik[k] = wynik[wynik.Length - k - 1];
			}

			string c = new string(wynik);
			return c;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox3.Text = Crypt(textBox2.Text, textBox1.Text, Convert.ToInt32(numericUpDown1.Value));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox4.Text = DeCrypt(textBox2.Text, textBox1.Text, Convert.ToInt32(numericUpDown1.Value));
		}
	}
}
