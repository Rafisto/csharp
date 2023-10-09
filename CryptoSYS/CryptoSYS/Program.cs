using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoSYS
{
	class Program
	{
		static void Main(string[] args)
		{
			string hashhh = RandomString(100);
			Console.WriteLine("Word to crypt");
			Console.WriteLine(hashhh);
			string tocrypt = Console.ReadLine();
			Console.WriteLine(Crypt(tocrypt, hashhh, 5,true));
			Console.Read();
		}
		static string Crypt(string crypt, string hash, int rolls, bool def)
		{
			char[] x = crypt.ToCharArray();
			char[] hashes = hash.ToCharArray();
			char[] wynik = new char[1000];
			for (int l = 0; l < rolls; l++)
			{
				for (int k = 0; k < x.Length; k++)
				{
					wynik[k] = x[x.Length - k - 1];
				}
				foreach (char j in wynik)
				{
					int z = Array.IndexOf(wynik, j);
					wynik[z+1] = hashes[z+1];
				}
			}

			string c = new string(wynik);
			return c;
		}

		static string DeCrypt(string crypt, string hash, int rolls, bool def)
		{
			char[] x = crypt.ToCharArray();
			char[] hashes = hash.ToCharArray();
			char[] wynik = new char[1000];
			for (int l = 0; l < rolls; l++)
			{
				foreach (char j in wynik)
				{
					int z = Array.IndexOf(wynik, j);
					wynik[z - 1] = hashes[z - 1];
				}
				for (int k = 0; k < x.Length; k++)
				{
					wynik[k] = x[x.Length - k - 1];
				}
			}

			string c = new string(wynik);
			return c;
		}

		private static Random random = new Random();
		public static string RandomString(int length)
		{
			const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
		}
	}
}
