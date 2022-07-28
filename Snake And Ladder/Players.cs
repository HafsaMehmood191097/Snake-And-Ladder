using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Snake_And_Ladder
{
    
    public partial class Players : Form
    {
        public static string firstplayer = "";
        public static string secplayer = " ";
        public Players()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string winner = Snake_Ladder.Winner;
            firstplayer = textBox1.Text;
            secplayer = textBox2.Text;
            if (firstplayer=="" && secplayer=="")
            {
                MessageBox.Show("Please Enter Credentials!");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B1KA2US;Initial Catalog=snake_and_ladder;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into player_data (player1,player2)values ('"+firstplayer+"','"+secplayer+"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                Snake_Ladder snake = new Snake_Ladder();
                snake.Show();
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game gme = new Game();
            gme.Show();
        }

        private void Players_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            History h = new History();
            h.Show();
            
        }
    }
}
