using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Snake_And_Ladder
{
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();
        }

        private void More_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Game g = new Game();
            g.Show();

        }
    }
}
