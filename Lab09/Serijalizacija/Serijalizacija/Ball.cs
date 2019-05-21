using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija
{
    [Serializable]
    public class Ball
    {
        public double Radius { get; set; }
        public Color Color { get; set; }
        public Point Location { get; set; }
        public bool isSelected { get; set; }
        public bool isColiding { get; set; }

        public Ball(Point location, Color color, double Radius)
        {
            this.Location = location;
            this.Radius = Radius;
            this.Color = color;
            isSelected = false;
            isColiding = false;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Red, 5);
            Brush brush = new SolidBrush(Color);

            if (isSelected)
                g.DrawEllipse(pen, Location.X - (float)Radius, Location.Y - (float)Radius, (float)Radius * 2, (float)Radius * 2);

            g.FillEllipse(brush, Location.X - (float)Radius, Location.Y - (float)Radius, (float)Radius * 2, (float)Radius * 2);
            pen.Dispose();
            brush.Dispose();
        } 
    }
}
