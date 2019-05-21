using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> Balls { get; set; }
        public Color CurrentColor { get; set; }
        public Point CurrentLocation { get; set; }
        public double CurrentRadius { get; set; }
        public bool isLocationSet { get; set; }
        public bool isRadiusSet { get; set; }
        public int countSelected { get; set; }

        public BallDoc()
        {
            this.Balls = new List<Ball>();
            this.CurrentColor = Color.Green;
            this.CurrentLocation = Point.Empty;
            this.CurrentRadius = 0;
            this.countSelected = 0;
        }
        
        public double pointsDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }

        public void UpdateRadius(Point position)
        {
            this.CurrentRadius = pointsDistance(CurrentLocation, position);
        }

        public void AddCircle()
        {
            if (isLocationSet)
            {
                Ball ball = new Ball(CurrentLocation, CurrentColor, CurrentRadius);
                this.Balls.Add(ball);
            }
        }

        public Ball getSelected()
        {
            foreach (Ball ball in Balls)
                if (ball.isSelected)
                    return ball;                
            return null;
        }

        public int getSelectedIndex(Ball Ball)
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                if (Ball.Equals(Balls.ElementAt(i)));
                    return i;
            }
            return -1;
        }

        public void Colision()
        {
            Ball Ball = getSelected();

            if (!(Ball is null))
            {
                int index = getSelectedIndex(Ball);

                for (int i = 0; i < Balls.Count; i++)
                {
                    if (Ball.Equals(Balls[i]))
                        continue;

                    if (pointsDistance(Ball.Location, Balls[i].Location) < (Ball.Radius + Balls.ElementAt(i).Radius) &&
                        Ball.Color == Balls.ElementAt(i).Color)
                    {
                        Balls[index].isColiding = true;
                        Balls[i].isColiding = true;
                    }
                }

                for (int i = 0; i < Balls.Count; i++)
                {
                    if (Balls[i].isColiding)
                    {
                        Balls.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        public void SetSelected(Point position)
        {
            foreach (Ball Ball in Balls)
            {
                if (pointsDistance(Ball.Location, position) < Ball.Radius)
                {
                    if (!Ball.isSelected)
                    {
                        countSelected++;
                        Ball.isSelected = true;
                        if (countSelected == 2)
                            continue;
                        break;
                    }
                    else
                    {
                        Ball.isSelected = false;
                        countSelected--;
                    }
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Ball Ball in Balls)
            {
                Ball.Draw(g);
            }
            if (isLocationSet)
            {
                Pen pen = new Pen(Color.Black, 2);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawEllipse(pen, CurrentLocation.X - (float)CurrentRadius, CurrentLocation.Y - (float)CurrentRadius, (float)CurrentRadius * 2, (float)CurrentRadius * 2);
                pen.Dispose();
            }
        }

    }
}

