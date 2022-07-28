using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Snake_And_Ladder
{
    public partial class Snake_Ladder : Form
    {
        
        int flag = 0,sec;  // green's turn 
        bool green = false,red=false;
        int x = 12,y= 541, dice_value,p=0;
        int rx = 12, ry = 541,q = 0;
        public static string Winner = "";
        public Snake_Ladder()
        {
            
            InitializeComponent();

            label10.Text = Players.firstplayer;
            label11.Text = Players.secplayer;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;

        }
        SoundPlayer player = new SoundPlayer(@"A:\5th Semester\Visual programming\VPLAB\project\Snake And Ladder\Snake And Ladder\roll1.wav");

        private void Snake_Ladder_Load(object sender, EventArgs e)
        {
            player.Stop();
            timer1.Stop();
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox1.Visible = true;
           
            if (flag == 0)
            {
                button2.Enabled = false;
            }
            lables_hide();

            label9.BackColor = System.Drawing.Color.Green;
            label9.Text = Players.firstplayer;
        }
        public void lables_hide()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            button1.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {


            
            timer1.Interval = 100;
            timer1.Start();
            timergame(sender, e);
            
            dice_value = Functionalities.rolldice(pictureBox1);
            label1.Text = dice_value.ToString();
           

            //------------------------------------Turn after first 6-------------------------------------


            if (green == true)
            {
                /* pictureBox5.Location = new Point(x, y);
                 x += 74;
                 label2.Text = x.ToString();
                 label3.Text = y.ToString();*/

                Thread.Sleep(1000);
                Functionalities.move_player(ref x,ref y,ref p,dice_value,pictureBox5,label4);

            }

            //------------------------------------For First Time 6-------------------------------------


            if (label1.Text == "6" && green == false)
            {
                
                pictureBox5.BackColor = Color.Transparent;
                pictureBox5.Visible = true;
                pictureBox2.Visible = false;
                green = true;
                pictureBox5.Location = new Point(x, y);
                label2.Text = x.ToString();
                label3.Text = y.ToString();
                label4.Text = p.ToString();
                p++;

               
            }

            //------------------------------------Player Green Wins-------------------------------------


            winner_player();


            //------------------------------------For Snakes And Ladders-------------------------------------



            p = Functionalities.Ladders(ref x, ref y, ref p, pictureBox5, label4);
            p = Functionalities.Snakes(ref x, ref y, ref p, pictureBox5, label4);
            label4.Text = p.ToString();


            //------------------------------------If 6 is value for second turn-------------------------------------


            if (dice_value == 6)
            {
                flag = 0;
            }
            else {
                flag = 1;
                
                button3.Enabled = false;
                button2.Enabled = true;
                label9.BackColor = System.Drawing.Color.Red;
                label9.Text = Players.secplayer;

            }

         

        }

        public void winner_player()
        {
            if(p == 101)
            {
                this.Hide();
                Winner = Players.firstplayer;
                button2.Enabled = false;
                button3.Enabled = false;
                winner w = new winner();
                w.Show();

            }
            else if (q == 101)
            {
                this.Hide();
                Winner = Players.secplayer;
                button2.Enabled = false;
                button3.Enabled = false;
                winner w = new winner();
                w.Show();
            }
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        //------------------------------------Timer Event for Dice Rolling-------------------------------------



        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int pic = 0;
            sec = sec + 1;
            Random r = new Random();
            if (sec <= 10)
            {
                pic = r.Next(1, 7);
                pictureBox7.Image = Image.FromFile(@"A:\5th Semester\Visual programming\VPLAB\project\Snake And Ladder\Snake And Ladder\Resources\" + pic + ".png");
                pictureBox7.Visible = true;
            }
            else {
                timer1.Stop();
                pictureBox7.Visible = false;
            }
        }




        //------------------------------------Player Red-------------------------------------



        private void button2_Click(object sender, EventArgs e)
        {

           
            timer1.Interval = 100;
            timer1.Start();
            timergame(sender, e);


            dice_value = Functionalities.rolldice(pictureBox1);
            label7.Text = dice_value.ToString();
            

            //------------------------------------Turn after first 6-------------------------------------


            if (red == true)
            {
                Thread.Sleep(1000);
                Functionalities.move_player(ref rx, ref ry, ref q, dice_value, pictureBox6, label4);
                label7.Text = dice_value.ToString();

            }


            //------------------------------------first time 6-------------------------------------


            if (label7.Text == "6" && red == false)
            {

                pictureBox6.BackColor = Color.Transparent;
                pictureBox6.Visible = true;
                pictureBox3.Visible = false;
                red = true;
                pictureBox6.Location = new Point(rx, ry);
                label6.Text = rx.ToString();
                label5.Text = ry.ToString();
                label8.Text = q.ToString();
                q++;

            }


            //------------------------------------Player Red Wins-------------------------------------


            winner_player();



            //------------------------------------For Snakes And Ladders-------------------------------------



            q = Functionalities.Ladders(ref rx, ref ry, ref q, pictureBox6, label4);
            q = Functionalities.Snakes(ref rx, ref ry, ref q, pictureBox6, label4);
            label8.Text = q.ToString();


            //------------------------------------If 6 is value for second turn-------------------------------------



            if (dice_value == 6)
            {
                flag = 1;
            }
            else
            {
                flag = 0;

                button2.Enabled = false;
                button3.Enabled = true;

                label9.BackColor = System.Drawing.Color.Green;
                label9.Text = Players.firstplayer;


            }

         
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.ForeColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Players ply = new Players();
            ply.Show();
        }

        private void timergame(object sender, EventArgs e)
        {
            

            sec = 0;
            timer1.Interval = 100;
            
            player.Play();
            timer1.Start();
            Snake_Ladder snk = new Snake_Ladder();
            
            snk.timer1_Tick(sender, e);
            {
               
                int pic = 0;
                sec = sec + 1;
                Random r = new Random();
                if (sec <= 10)
                {
                   
                    pic = r.Next(1, 7);
                    pictureBox7.Image = Image.FromFile(@"A:\5th Semester\Visual programming\VPLAB\project\Snake And Ladder\Snake And Ladder\Resources\" + pic + ".png");
                    pictureBox7.Visible = true;
                    
                }
                else
                {
                   
                    timer1.Stop();
                    pictureBox7.Visible = false;
                }

            };


        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}
