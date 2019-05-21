using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravoagolnici
{
    [Serializable]
    public class Rectangles
    {
        public List<Rectangle> RectangleList { get; set; }
        public Rectangles()
        {
            this.RectangleList = new List<Rectangle>();
        }
        public void addRectangle(Point location, Color color)
        {
            RectangleList.Add(new Rectangle(location, color));
        }

        public void Draw(Graphics g)
        {
            foreach (Rectangle rectangle in RectangleList)
                rectangle.Draw(g);
        }

        public void Check(int width, int height)
        {
            for (int i = RectangleList.Count - 1; i >= 0; --i)
            {
                if (RectangleList[i].X > width)
                {
                    RectangleList.RemoveAt(i);
                }
                else
                    if (RectangleList[i].Y > height)
                {
                    RectangleList.RemoveAt(i);
                }
            }
        }

        public void StartMoving(int x, int y, Rectangle.Direction direction)
        {
            foreach (Rectangle r in RectangleList)
            {
                if (r.IsHit(x, y))
                {
                    if (r.MoveDirection == Rectangle.Direction.STILL)
                    {
                        r.MoveDirection = direction;
                    }
                }
            }
        }

        public void Move()
        {
            foreach (Rectangle r in RectangleList)
            {
                if (r.MoveDirection == Rectangle.Direction.DOWN)
                {
                    r.Down();
                }
                else if (r.MoveDirection == Rectangle.Direction.RIGHT)
                {
                    r.Right();
                }
            }
        }
    }
}
