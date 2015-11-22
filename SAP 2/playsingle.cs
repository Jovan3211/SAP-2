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

        //klikanjem dugmeta play, pustiti muziku
        private void button1_Click(object sender, EventArgs e)
        {
            source = textBox1.Text;
            if (source.Contains("\""))
            {
                source = source.Replace("\"", "");
            }

            wplayer.URL = source;
            wplayer.controls.play();
            label_songName.Text += Path.GetFileNameWithoutExtension(source);
            playsingle.ActiveForm.Text += Path.GetFileNameWithoutExtension(source);                  // Umesto onog tvog pls
        }

        //zaustavljanje pesme
        private void button2_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            button_play.Enabled = true;
            label_songName.Text = "Playing: ";
            playsingle.ActiveForm.Text = "Playing:  ";                                               // Umesto onog tvog pls
        }

        //selektovanje pesme preko file browsera.
        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Music Files|*.mp3|All Files (*.*)|*.*";
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
    }
}
