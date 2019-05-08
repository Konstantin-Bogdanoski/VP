using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    enum Direction { Left, Right, Up, Down}
    class Pacman
    {
        public bool [][]obstacleWorld {get; set;}
        public int X { get; set; }
        public int Y { get; set; }
        public Brush pacmanColor { get; set; }
        public Boolean mouthOpen { get; set; }
        public Direction Direction { get; set; }
        public float MovementSpeed { get; set; }

        public int Radius = 20;
        public int formX { get; set; }
        public int formY { get; set; }
        public Pacman(int formX, int formY, bool [][]obstacleWorld)
        {
            this.obstacleWorld = obstacleWorld;
            this.X = 7;
            this.Y = 5;
            this.Direction = Direction.Right;
            this.formX = formX;
            this.formY = formY;
            mouthOpen = true;
            this.pacmanColor = new SolidBrush(Color.Yellow);
            this.MovementSpeed = 20;
        }

        public void changeDirection(Direction dir)
        {
            this.Direction = dir;
            Move();
        }

        public void updateMouth()
        {
            if (this.mouthOpen.Equals(true))
                this.mouthOpen = false;
            else
                this.mouthOpen = true;
        }
        public void Move()
        {
            this.updateMouth();
            int prevX = this.X;
            int prevY = this.Y;


            if (this.Direction.Equals(Direction.Right)) // MOVING RIGHT
            {
                 if (prevX == formX)
                 {
                    prevX = 0;
                 }
                 else
                 {
                    prevX++;
                 }
                
            }
            else if(this.Direction.Equals(Direction.Left)) // MOVING LEFT
            {
                    if (prevX == 0)
                    {
                        prevX = formX;
                    }
                    else
                    {
                        prevX--;
                    }
            }
            else if(this.Direction.Equals(Direction.Up)) // MOVING UP
            {
                if (prevY == 1)
                {
                    prevY = formY;
                }
                else
                {
                    prevY--;
                }
            }
            else // MOVING DOWN
            {
                if (prevY == formY)
                {
                    prevY = 1;
                }
                else
                {
                    prevY++;
                }
            }

            if (obstacleWorld[prevY][prevX])
            {
                this.X = prevX;
                this.Y = prevY;
            }
        }


        public void Draw(Graphics graphics)
        {
            if (this.Direction.Equals(Direction.Right)) //Move right & Check mouth
            {
                if (mouthOpen)
                    graphics.FillPie(this.pacmanColor, this.X * this.Radius * 2 + 15, this.Y * this.Radius * 2 + 12, this.Radius, this.Radius, 30, 310);
                else
                    graphics.FillPie(this.pacmanColor, this.X * this.Radius * 2 + 15, this.Y * this.Radius * 2 + 12, this.Radius, this.Radius, 0, 360);
            }
            else if (this.Direction.Equals(Direction.Left)) //Move left & Check mouth
            {
                if (mouthOpen)
                    graphics.FillPie(this.pacmanColor, this.X * this.Radius * 2 + 15, this.Y * this.Radius * 2 + 12, this.Radius, this.Radius, 210, 310);
                else
                    graphics.FillPie(this.pacmanColor, this.X * this.Radius * 2 + 15, this.Y * this.Radius * 2 + 12, this.Radius, this.Radius, 0, 360);
            }
            else if (this.Direction.Equals(Direction.Up)) //Move up & Check mouth
            {
                if (mouthOpen)
                    graphics.FillPie(this.pacmanColor, this.X * this.Radius * 2 + 15, this.Y * this.Radius * 2 + 12, this.Radius, this.Radius, 300, 310);
                else
                    graphics.FillPie(this.pacmanColor, this.X * this.Radius * 2 + 15, this.Y * this.Radius * 2 + 12, this.Radius, this.Radius, 0, 360);
            }
            else if (this.Direction.Equals(Direction.Down)) //Move down & check Mouth
            {
                if (mouthOpen)
                    graphics.FillPie(this.pacmanColor, this.X * this.Radius * 2 + 15, this.Y * this.Radius * 2 + 12, this.Radius, this.Radius, 120, 310);
                else
                    graphics.FillPie(this.pacmanColor, this.X * this.Radius * 2 + 15, this.Y * this.Radius * 2 + 12, this.Radius, this.Radius, 0, 360);
            }
        }
    }
}
