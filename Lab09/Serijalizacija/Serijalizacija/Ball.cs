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
        public int Radius { get; set; }
        public Color Color { get; set; }
        public Point Location { get; set; }

        public Ball(Color color)
        {
            this.Radius = 25;
            this.Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(this.Color);
        }
        
    }
}
