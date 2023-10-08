using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSite
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private string filename;
        private string password;
        private string content;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                filename = textBox1.Text;
                password = textBox2.Text;
                content = richTextBox1.Text;
                try
                {
                    WebClient wl = new WebClient();
                    if (wl.DownloadString("http://www.rack.c0.pl/SecretSite/" + filename + ".txt") == "")
                    {
                        System.IO.Directory.CreateDirectory("C:/tymc/");
                        string str = "<pass>" + password + "</pass>" + "<all>" + content + "</all>";
                        File.WriteAllText("C:/tymc/tymc.txt", str);
                        using (WebClient client = new WebClient())
                        {
                            client.Credentials = new NetworkCredential("Rafisto5", "Thegame1");
                            client.UploadFile("ftp://rack.c0.pl/rack.c0.pl/SecretSite/" + filename + ".txt", "STOR", "C:/tymc/tymc.txt");
                        }
                        MessageBox.Show("Created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File with this name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                   
                }
                catch
                {
                    System.IO.Directory.CreateDirectory("C:/tymc/");
                    string str = "<pass>" + password + "</pass>" + "<all>" + content + "</all>";
                    File.WriteAllText("C:/tymc/tymc.txt", str);
                    using (WebClient client = new WebClient())
                    {
                        client.Credentials = new NetworkCredential("Rafisto5", "Thegame1");
                        client.UploadFile("ftp://rack.c0.pl/rack.c0.pl/SecretSite/" + filename + ".txt", "STOR", "C:/tymc/tymc.txt");
                    }
                    MessageBox.Show("Created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
