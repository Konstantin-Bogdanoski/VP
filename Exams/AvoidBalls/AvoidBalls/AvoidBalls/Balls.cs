using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidBalls
{
    public class Balls
    {
        public List<RedBall> redBalls { get; set; }
        public BlueBall blueBall { get; set; }
        public Balls(Point mouseLoc)
        {
            redBalls = new List<RedBall>();
            blueBall = new BlueBall(mouseLoc);
        }

        public void Draw(Graphics g)
        {
            blueBall.Draw(g);
            redBalls.ForEach(ball =>
            {
                ball.Draw(g);
            });
            
        }

        public void AddBall(RedBall ball)
        {
            redBalls.Add(ball);
        }

        public void Move(int width, int height, Point location)
        {
            blueBall.Move(location);

            redBalls.ForEach(ball =>
            {
                ball.Move(width, height);
            });

            redBalls.ForEach(ball =>
            {
                if (blueBall.IsItHit(ball))
                {
                    blueBall.IsHit = true;
                    blueBall.Color = Color.Gray;
                    ball.IsHit = true;
                }
            });

            for(int i=0; i<redBalls.Count; i++)
                if (redBalls[i].IsHit)
                {
                    redBalls.RemoveAt(i);
                }
        }
    }
}
