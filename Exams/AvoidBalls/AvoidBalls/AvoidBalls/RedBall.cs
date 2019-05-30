using System;
using System.Drawing;

namespace AvoidBalls
{
    public class RedBall
    {
        public Point Location { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; }
        public bool IsHit { get; set; }
        public double Velocity { get; set; }
        public double Angle { get; set; }

        private float velocityX;
        private float velocityY;

        public RedBall(Point Location)
        {
            this.Location = Location;
            this.Radius = 20;
            this.Color = Color.Red;
            Velocity = 10;
            Random r = new Random();
            Angle = r.NextDouble() * 2 * Math.PI;
            velocityX = (float)(Math.Cos(Angle) * Velocity);
            velocityY = (float)(Math.Sin(Angle) * Velocity);
        }

        internal bool Touches(int x, int y)
        {
            return IsItHit(new BlueBall(new Point(x, y)));
        }

        public bool IsItHit(BlueBall blueBall)
        {
            return ((Location.X - blueBall.Location.X) * (Location.X - blueBall.Location.X) +
                (Location.Y - blueBall.Location.Y) * (Location.Y - blueBall.Location.Y)) < 2 * 2 * Radius * Radius;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Location.X - Radius / 2, Location.Y - Radius / 2, Radius, Radius);
            brush.Dispose();
        }

        public void Move(int width, int height)
        {
            int nextX = (int)(Location.X + velocityX);
            int nextY = (int)(Location.Y + velocityY);
            int lft = Radius;
            int rgt = width - 4*Radius;
            int tp = Radius;
            int btm = height - 4*Radius;

            if (nextX <= lft)
            {
                nextX = lft + (lft - nextX);
                velocityX = -velocityX;
            }
            if (nextX >= rgt)
            {
                nextX = rgt - (nextX - rgt);
                velocityX = -velocityX;

            }
            if (nextY <= tp)
            {
                nextY = tp + (tp - nextY);
                velocityY = -velocityY;
            }

            if (nextY >= btm)
            {
                nextY = btm - (nextY - btm);
                velocityY = -velocityY;
            }
            Location = new Point(nextX, nextY);
        }
    }
}