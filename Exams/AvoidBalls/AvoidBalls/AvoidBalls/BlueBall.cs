using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidBalls
{
    public class BlueBall
    {
        public Point Location { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; }
        public bool IsHit { get; set; }

        public BlueBall()
        {
            this.Color = Color.Blue;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Location.X - Radius / 2, Location.Y - Radius / 2, Radius, Radius);
            brush.Dispose();
        }

        public bool IsItHit(RedBall redBall)
        {
            return ((Location.X - redBall.Location.X) * (Location.X - redBall.Location.X) -
                (Location.Y - redBall.Location.Y) * (Location.Y - redBall.Location.Y)) < 2*2*Radius*Radius;
        }

        public void Move(Point Location)
        {
            this.Location = Location;
        }
    }
}
