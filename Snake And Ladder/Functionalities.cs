using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Snake_And_Ladder
{
    class Functionalities
    {

        public static int rolldice(PictureBox pic)
        {
            int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);

            //------------------------------------Images Of Dices-------------------------------------


            pic.Image = Image.FromFile(@"A:\5th Semester\Visual programming\VPLAB\project\Snake And Ladder\Snake And Ladder\Resources\" + dice + ".png");

            return dice;

        }

        public static void move_player(ref int x, ref int y, ref int p, int dice, PictureBox px, Label l)
        {



            //-------------------------------------Condition for 100+ value of player-----------------------------


            
            if (dice + p > 101)
             {
                l.Text = "Cannot move further!";
                return;
            }




            //------------------------------------Player Move Operations from one to upper layers-----------------




            for (int i = 0; i < dice; i++)
            {

                if (p == 10)
                {
                    x = 12;
                    y = 482;
                 
                }
                else if (p == 20)
                {
                    x = 12;
                    y = 427;
                   
                }

                else if (p == 30)
                {
                    x = 12;
                    y = 365;

                }

                else if (p == 40)
                {
                    x = 12;
                    y = 308;
                   
                }
                else if (p == 50)
                {
                    x = 12;
                    y = 250;
                  
                }

                else if (p == 60)
                {
                    x = 12;
                    y = 186;
                 
                }

                else if (p == 70)
                {
                    x = 12;
                    y = 125;
                   
                }

                else if (p == 80)
                {
                    x = 12;
                    y = 73;
                    
                }

                else if (p == 90)
                {
                    x = 12;
                    y = 12;
                    
                }
                else
                {
                    x += 74;
                }

                px.Location = new Point(x, y);
                l.Text = p.ToString();
                p++;

            }

        }



        //-------------------------------------Ladders Code-----------------------------




        public static int Ladders(ref int x, ref int y, ref int p, PictureBox px, Label l)
        {
            if (p == 3)
            {
                x = 12;
                y = 250;
                p = 51;
                px.Location = new Point(x, y);
            }
            else if (p == 6)
            {
                //448, 426
                x = 448;
                y = 426;
                p = 27;
                px.Location = new Point(x, y);
            }

            else if (p == 36)
            {
                //301, 250
                x = 301;
                y = 250;
                p = 55;
                px.Location = new Point(x, y);
            }

            else if (p == 20)
            {
                //671, 189
                x = 671;
                y = 189;
                p = 70;
               
            }

            else if (p == 68)
            {
                //524, 13
                x = 524;
                y = 13;
                p = 98;
                
            }

            else if (p == 63)
            {
                //302, 12
                x = 302;
                y = 12;
                p = 95;
               
            }
            px.Location = new Point(x, y);
            return p;
        }




        //-------------------------------------Snakes Code-----------------------------




        public static int Snakes(ref int x, ref int y, ref int p, PictureBox px, Label l)
        {
            if (p == 25)
            {
                //306, 541
                x = 306;
                y = 541;
                p = 5;
             
            }
            else if (p == 34)
            {
                //12,y= 541
                x = 12;
                y = 541;
                p = 1;
               
            }
            else if (p == 47)
            {
                //598, 488
                x = 598;
                y = 488;
                p = 19;
               
            }
            else if (p == 65)
            {
                //82, 250
                x = 82;
                y = 250;
                p = 52;
                
            }

            else if (p == 87)
            {
                //450, 250
                x = 450;
                y = 250;
                p = 57;
                
            }

            else if (p == 91)
            {
                //12, 186
                x = 12;
                y = 186;
                p = 61;
               
            }

            else if (p == 99)
            {
                //599, 190
                x = 599;
                y = 190;
                p = 69;
                
            }
            px.Location = new Point(x, y);
            return p;
        }
    }


    //-------------------------------------Winner!!!!!!!!!!!!-----------------------------


   

}
