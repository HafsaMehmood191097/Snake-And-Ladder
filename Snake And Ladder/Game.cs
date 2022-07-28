using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Snake_And_Ladder
{
    public partial class Game : Form
    {
        public Game()
        {
            
            InitializeComponent();
            
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Players ply = new Players();
            ply.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            More m = new More();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
