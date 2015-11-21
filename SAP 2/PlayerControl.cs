using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAP_2
{
    public partial class PlayerControl : UserControl
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
    //    Timer timer1 = new Timer();

        public Timer timer1
        {
            get { return timer1; }
            set { timer1 = value; }
        }

        public PlayerControl()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(TimerEventProcessor);
            timer1.Start();
            wplayer.settings.volume = 50;
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
             lbStrTime.Text = wplayer.controls.currentPositionString;
        }

        private void btVolUp_Click(object sender, EventArgs e)
        {
            wplayer.settings.volume++;
        }

        private void btVolDown_Click(object sender, EventArgs e)
        {
            wplayer.settings.volume--;
        }
    }
}
