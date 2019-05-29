using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvoidBalls
{
    public partial class Form1 : Form
    {
        public Balls balls { get; set; }
        public bool flag { get; set; }
        public int timerCounter { get; set; }
        public Form1()
        {
            this.DoubleBuffered = true;
            flag = false;
            InitializeComponent();
            balls = new Balls();
            Random random = new Random();
            while(balls.redBalls.Count < 2)
            {
                int x = random.Next(20, this.Width- 20);
                int y = random.Next(20, this.Height - 20);
                bool touches = false;
                foreach (RedBall ball in balls.redBalls)
                {
                    touches = ball.Touches(x, y);
                    if (touches) break;
                }
                if (!touches)
                {
                    RedBall ball = new RedBall(new Point(x, y), Color.Red);
                    balls.redBalls.Add(ball);
                }
            }
            balls.blueBall.Location = Control.MousePosition;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            balls.blueBall.Draw(e.Graphics);
            balls.redBalls.ForEach(ball =>
            {
                ball.Draw(e.Graphics);
            });
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            balls.Move(this.Width, this.Height);
            timerCounter++;
            if(timerCounter >= 50)
            {
                Random random = new Random();
                int x = random.Next(20, this.Width - 20);
                int y = random.Next(20, this.Height - 20);
                RedBall red = new RedBall(new Point(x, y), Color.Red);
                balls.AddBall(red);
                timerCounter = 0;
            }
            this.CountRedBox.Text = balls.redBalls.Count.ToString();
            Invalidate(true);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            balls.blueBall.Location = e.Location;
            Invalidate(true);
        }
    }
}
