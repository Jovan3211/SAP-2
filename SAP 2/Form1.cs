using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playSingle_Click(object sender, EventArgs e)
        {
            playsingle form = new playsingle();
            form.Show();

        }

        private void createplist_Click(object sender, EventArgs e)
        {
            addplist form = new addplist();
            form.Show();
        }

        private void selectplist_Click(object sender, EventArgs e)
        {
            selectplist form = new selectplist();
            form.Show();
        }
    }
}
