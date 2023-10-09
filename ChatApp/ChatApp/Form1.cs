using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Task.Factory.StartNew(() => Init());
		}
		void Init() {
			TcpListener server = null;
			try
			{
				Int32 port = 666;
				IPAddress localAddr = IPAddress.Parse(GetLocalIPAddress());
				server = new TcpListener(localAddr, port);
				server.Start();
				Byte[] bytes = new Byte[256];
				String data = null;
				while (true)
				{
					Invoke((Action)(() => richTextBox1.AppendText("Waiting for a connection... ")));
					TcpClient client = server.AcceptTcpClient();
					Invoke((Action)(() => richTextBox1.AppendText("Connected!")));
					data = null;
					NetworkStream stream = client.GetStream();
					int i;
					while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
					{
						data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
						Invoke((Action)(() => richTextBox1.AppendText("Received: " + data)));
						data = data.ToUpper();
						byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
						stream.Write(msg, 0, msg.Length);
						Invoke((Action)(() => richTextBox1.AppendText("Sent: "+ data)));
					}
					client.Close();
				}
			}
			catch (SocketException e)
			{
				richTextBox1.AppendText("SocketException: "+ e);
			}
			finally
			{
				server.Stop();
			}
		}
		public static string GetLocalIPAddress()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip.ToString();
				}
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			richTextBox1.AppendText("\r\n");
		}
	}
}
