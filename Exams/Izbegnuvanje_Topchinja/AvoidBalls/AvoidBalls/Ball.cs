using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidBalls
{
    public class Ball
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; }
        public Double Angle { get; set; }
        public bool gotHit { get; set; }
        public bool Type { get; set; } //True - BLUE, False - RED
        public double Velocity { get; set; }
        private float velocityX;
        private float velocityY;
        public Ball(Point center, Color color, bool type)
        {
            this.Center = center;
            this.Color = color;
            this.gotHit = false;
            this.Radius = 20;
            this.Type = type;
            this.Velocity = 0;
            this.velocityY = 0;
            this.velocityX = 0;
            if (!Type)
            {
                Random random = new Random();
                Angle = random.NextDouble() * 2 * Math.PI;
                this.Velocity = 10;
                velocityX = (float)(Math.Cos(Angle) * Velocity);
                velocityY = (float)(Math.Sin(Angle) * Velocity);
            }
        }

        public void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.Color);
            graphics.FillEllipse(brush, this.Center.X - Radius, this.Center.Y - Radius, this.Radius, this.Radius);
            brush.Dispose();
        }

        public void Move(Point point, int width, int height)
        {
            if (this.Type)
            {
                this.Center = point;
            }
            else
            {
                int nextX = (int)(this.Center.X + velocityX);
                int nextY = (int)(this.Center.Y + velocityY);
                if(nextX <= Radius)
                {
                    nextX = Radius + (Radius - nextX);
                    velocityX = -velocityX;
                }
                if(nextX >= width)
                {
                    nextX = width + (width - nextX);
                    velocityX = -velocityX;
                }
                if(nextY <= Radius)
                {
                    nextY = Radius + (Radius - nextY);
                    velocityY = -velocityY;
                }
                if(nextY >= Radius)
                {
                    nextY = height + (height - nextY);
                    velocityY = -velocityY;
                }
                this.Center = new Point(nextX, nextY);
            }
        }

        public bool isHit(Ball ball)
        {
            return ((Center.X - ball.Center.X) * (Center.X - ball.Center.X) + 
                (Center.Y - ball.Center.Y) * (Center.Y - ball.Center.Y)) <= Radius*Radius;
        }


    }
}
