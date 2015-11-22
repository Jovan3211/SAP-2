using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAP_2
{
    public partial class addplist : Form
    {
        //kreiranje liste gde ce stojati pesme koje ce se ubaciti u fajl koji se cuva kad se klikne 'create playlist'
        List<string> playlistSongs = new List<string>();
        //deklaracija file dialoga
        OpenFileDialog open = new OpenFileDialog();

        public addplist()
        {
            InitializeComponent();
        }

        //selektovanje foldera za cuvanje plejliste
        private void button_saveLocationDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 folder = new folderBrowserDialog1();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_saveLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //selektovanje pesme za dodavanje
        private void button_addSongDialog_Click(object sender, EventArgs e)
        {
            open.Filter = "Music Files|*.mp3|All Files (*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_addSong.Text = Path.GetFileName(open.FileName);
            }
        }

        //dodavanje pesme u textbox i listu plejliste
        private void button_add_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(textBox_addSong.Text);
            playlistSongs.Add(open.FileName);
        }

        //uklanjanje pesme iz texboxa i liste
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                playlistSongs.Remove(Convert.ToString(listBox.SelectedIndex));
            }
        }
    }
}
