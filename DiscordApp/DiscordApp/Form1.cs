using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DiscordApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DiscordRpcClient client;
        public bool started = false;
        //Called when your application first starts.
        //For example, just before your main loop, on OnEnable for unity.
        void Initialize()
        {
            /*
            Create a Discord client
            NOTE: 	If you are using Unity3D, you must use the full constructor and define
                     the pipe connection.
            */
            client = new DiscordRpcClient("790720180702674964");

            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = textBox1.Text,
                State = textBox2.Text,
                Assets = new Assets()
                {
                    LargeImageKey = textBox3.Text,
                    LargeImageText = textBox4.Text,
                    SmallImageKey = textBox5.Text
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            client.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (started)
            {
                client.Invoke();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            Initialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("state.st");
                textBox1.Text = lines[0];
                textBox2.Text = lines[1];
                textBox3.Text = lines[2];
                textBox4.Text = lines[3];
                textBox5.Text = lines[4];
                textBox6.Text = lines[5];
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                List<string> contents = new List<string>();
                contents.Add(textBox1.Text);
                contents.Add(textBox2.Text);
                contents.Add(textBox3.Text);
                contents.Add(textBox4.Text);
                contents.Add(textBox5.Text);
                contents.Add(textBox6.Text);
                File.WriteAllLines("state.st", contents.ToArray());
            }
            catch
            {

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox6.Text;
            this.Name = textBox6.Text;
        }
    }
}
