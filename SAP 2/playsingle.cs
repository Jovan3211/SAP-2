using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WMPLib;
using System.Windows.Forms;

namespace SAP_2
{
    public partial class playsingle : Form
    {
        public playsingle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = textBox1.ToString();

            if (source.Contains("\""))
            {
                source = source.Replace("\"", "");
            }

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            string position;
            ConsoleKeyInfo input;
            wplayer.URL = source;
            wplayer.controls.stop();
            wplayer.controls.play();

            wplayer.settings.volume = 50;
        }
    }
}
