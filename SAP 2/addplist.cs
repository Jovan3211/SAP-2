using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAP_2
{
    public partial class addplist : Form
    {
        //kreiranje liste gde ce stojati pesme koje ce se ubaciti u fajl koji se cuva kad se klikne 'create playlist'
        List<string> playlistSongs = new List<string>();
        //deklaracije
        OpenFileDialog open = new OpenFileDialog();
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

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
                textBox_addSong.Text = open.FileName;
            }
        }

        //dodavanje pesme u textbox i listu plejliste
        private void button_add_Click(object sender, EventArgs e)
        {
            if (!File.Exists(open.FileName))
            {
                MessageBox.Show("Incorrect song file path!", "Error");
            }
            else
            {
                listBox.Items.Add(textBox_addSong.Text);
                playlistSongs.Add(textBox_addSong.Text);
            }
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

        //kreiranje plejliste
        private void button_createPlaylist_Click(object sender, EventArgs e)
        {
            string playlistLocation = textBox_saveLocation.Text + "\\" + textBox_playlistName.Text + ".m3u";

            if (!Directory.Exists(textBox_saveLocation.Text))
            {
                MessageBox.Show("Incorrect save location!", "Error");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(playlistLocation))
                {
                    writer.WriteLine("#EXTM3U\n");

                    foreach (string path in playlistSongs)
                    {
                        wplayer.URL = path;
                        wplayer.controls.play();

                        //uzimanje informacija o pesmi
                        string duration = wplayer.currentMedia.durationString;
                        string artist = wplayer.currentMedia.getItemInfo("Artist");
                        string title = wplayer.currentMedia.getItemInfo("Title");

                        wplayer.controls.stop();

                        //pisanje u playlistu
                        writer.WriteLine("#EXTINF:{0},{1} - {2}", duration, artist, title);
                        writer.WriteLine("{0}\n", path);
                    }
                }

                if (File.Exists(playlistLocation))
                    MessageBox.Show("The playlist has been successfully created!", "Playlist created");
                else
                    MessageBox.Show("There has been an error during creation. The playlist does not exist!", "Error");
            }
        }

        //italic text u textbox za dodavanje pesme
        private void textBox_addSong_Click(object sender, EventArgs e)
        {
            textBox_addSong.Clear();
            textBox_addSong.Font = new Font(textBox_addSong.Font, textBox_addSong.Font.Style & FontStyle.Regular);
            textBox_addSong.ForeColor = Color.Black;
        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            pictureBox_dragDrop.Visible = true;
        }

        private void listBox_DragLeave(object sender, EventArgs e)
        {
            pictureBox_dragDrop.Visible = false;
        }
    }
}
