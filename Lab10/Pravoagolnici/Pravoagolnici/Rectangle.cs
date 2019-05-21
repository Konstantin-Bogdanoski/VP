using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravoagolnici
{
    [Serializable]
    public class Rectangle
    {
        public enum Direction
        {
            STILL,
            RIGHT,
            DOWN
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsClicked { get; set; }
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Direction MoveDirection { get; set; }
        private int up = 1;
        public Rectangle(Point location, Color color)
        {
            this.Color = color;
            this.X = location.X-25;
            this.Y = location.Y-50;
            this.Width = 50;
            this.Height = 100;
            this.IsClicked = false;
            this.MoveDirection = Direction.STILL;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush, X, Y, Width, Height);
            brush.Dispose();
            up = 1;
        }

        public void Right()
        {
            X = X + Width;
            Y = Y + (Height - Width) * up;
            up *= -1;
            int tmp = Width;
            Width = Height;
            Height = tmp;
        }

        public void Down()
        {
            Y = Y + Height;
        }
        public bool IsHit(int x, int y)
        {
            return X <= x && x <= X + Width && y >= Y && y <= Y + Height;
        }

    }
}
