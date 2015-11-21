using System;
using System.Windows.Forms;

namespace SAP_2
{
    public partial class playsingle : Form 
    {
        public playsingle()
        {
            InitializeComponent();
        }

        public string source;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void button1_Click(object sender, EventArgs e)
        {
            source = textBox1.Text;
            if (source.Contains("\""))
            {
                source = source.Replace("\"", "");
            }

            wplayer.URL = source;
                
            wplayer.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Music Files(.mp3)|*.mp3|All Files (*.*)|*.*";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
            }       
        }
    }
}
