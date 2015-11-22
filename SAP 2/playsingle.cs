using System;
using System.IO;
using System.Windows.Forms;

namespace SAP_2
{
    public partial class playsingle : Form 
    {
        //deklaracije
        public string source;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        bool pauseActive = false;

        public playsingle()
        {
            InitializeComponent();
            t1.Start();
            wplayer.settings.volume = 50;
        }

        //funkcija za pustanje muzike
        public void play(string source)
        {
            wplayer.URL = source;
            wplayer.controls.play();
            label_songName.Text += Path.GetFileNameWithoutExtension(source);
            label_songName.Visible = true;
            playsingle.ActiveForm.Text = Path.GetFileNameWithoutExtension(source);
        }

        //klikanjem dugmeta play, pustiti muziku
        private void button1_Click(object sender, EventArgs e)
        {
            source = textBox1.Text;
            if (source.Contains("\""))
            {
                source = source.Replace("\"", "");
            }

            //provera da li je plejlista
            if (source.Contains(".m3u"))
            {
                label_upNext.Visible = true;
            }

            play(source);
        }

        //zaustavljanje pesme
        private void button2_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            button_play.Enabled = true;
            label_songName.Visible = false;
            label_upNext.Visible = false;
            playsingle.ActiveForm.Text = "SAP 2";
        }

        //selektovanje pesme preko file browsera.
        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Music Files|*.mp3|Playlist Files|*.m3u|All Files (*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
            }       
        }

        //pauziranje pesme
        private void button_pause_Click(object sender, EventArgs e)
        {
            if (!pauseActive)
            {
                wplayer.controls.pause();
                pauseActive = true;
                button_play.Enabled = false;
            }
            else
            {
                wplayer.controls.play();
                pauseActive = false;
                button_play.Enabled = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_volumeAmount.Text = "" + trackBar1.Value;
            wplayer.settings.volume = trackBar1.Value;
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            label_songTime.Text = wplayer.controls.currentPositionString;
        }

        private void playASongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Music Files|*.mp3|All Files (*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
            }

            source = textBox1.Text;
            if (source.Contains("\""))
            {
                source = source.Replace("\"", "");
            }

            wplayer.URL = source;
            wplayer.controls.play();
            label_songName.Text += Path.GetFileNameWithoutExtension(source);
            playsingle.ActiveForm.Text = Path.GetFileNameWithoutExtension(source);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createANewPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addplist form = new addplist();
            form.Show();
        }

        private void openAPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Playlist Files|*.m3u|All Files (*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
            }
        }

        private void playlistEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playlist_editor form = new playlist_editor();
            form.Show();
        }
    }
}
