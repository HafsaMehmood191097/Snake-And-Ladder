using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Snake_And_Ladder
{
    public partial class winner : Form
    {
        public winner()
        {
            InitializeComponent();
        }

        private void winner_Load(object sender, EventArgs e)
        {
            label1.Text = Snake_Ladder.Winner;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Players ply = new Players();
            ply.Show();
        }
    }
}
