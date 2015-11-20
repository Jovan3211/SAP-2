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

        playsingle psingle = new playsingle();
        public static string source = playsingle.textBox1.ToString();

        private void button1_Click(object sender, EventArgs e)
        {
            if (source.Contains("\""))
            {
                source = source.Replace("\"", "");
            }

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            string position;
            wplayer.URL = source;
            wplayer.controls.play();

            wplayer.settings.volume = 50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.controls.stop();
        }
    }
}
