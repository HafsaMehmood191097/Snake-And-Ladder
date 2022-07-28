using System;
using System.Windows.Forms;
using System.Media;

namespace Snake_And_Ladder
{

    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(@"A:\5th Semester\Visual programming\VPLAB\project\Snake And Ladder\Snake And Ladder\bin\Debug\back.wav");
        public Form1()
        {
            InitializeComponent();
            
        }




        Timer tmr;
        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();
            tmr = new Timer();
            tmr.Interval = 5000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        void tmr_Tick(object sender, EventArgs e)

        {
            tmr.Stop();
            Game mf = new Game();
            mf.Show();
            this.Hide();
            
        }
    }
}
