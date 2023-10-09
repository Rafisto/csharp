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

namespace SongsBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (string file in Directory.GetFiles("C:/Songs/"))
            {
                string file_name = Path.GetFileName(file);
                listView1.Items.Add(file_name);
            }
        }
        public void CreateSong(string songName)
        {
            songName = songName + ".song";
            Directory.CreateDirectory("C:/Songs/");
            File.Create("C:/Songs/" + songName);
            
            listView1.Items.Add(songName);
            return;
        }
        private void nowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSong ns = new NewSong();
            ns.f = this;
            ns.Show();
        }

        private void usuńPiosenkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Czy na pewno?", "Zapytanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (drs == DialogResult.OK)
            {
                try
                {
                    if(listView1.SelectedItems == null)
                    {
                        MessageBox.Show("Należy wybrać piosenkę do usunięcia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);
                        File.Delete("C:/Songs/" + item.Text);
                    }
                }
                catch
                {
                    
                }
            }
            else
            {

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    //  debug
                    //  MessageBox.Show("C:/Songs/" + item.Text);
                    richTextBox1.Lines = File.ReadAllLines("C:/Songs/" + item.Text);
                }
            }
            catch
            {
               
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    //  debug
                    //  MessageBox.Show("C:/Songs/" + item.Text);
                    File.WriteAllLines("C:/Songs/" + item.Text, richTextBox1.Lines);
                }
            }
            catch 
            {
                
            }
        }

        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    //  debug
                    //  MessageBox.Show("C:/Songs/" + item.Text);
                    File.WriteAllLines("C:/Songs/" + item.Text, richTextBox1.Lines);
                }
            }
            catch
            {

            }

        }

        private void usuńPiosenkeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Czy na pewno?", "Zapytanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (drs == DialogResult.OK)
            {
                try
                {
                    if (listView1.SelectedItems == null)
                    {
                        MessageBox.Show("Należy wybrać piosenkę do usunięcia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);
                        File.Delete("C:/Songs/" + item.Text);
                    }
                }
                catch
                {

                }
            }
            else
            {

            }
        }
    }
}
