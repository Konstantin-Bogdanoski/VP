using Pacman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        Timer timer;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] foodWorld;
        Pacman pacman;
        public Form1()
        {
            InitializeComponent();
            this.foodImage = Resources.food;
            this.BackColor = Color.Black;
            DoubleBuffered = true;
            newGame();
        }

        public void newGame()
        {
            pacman = new Pacman(14, 9);
            this.Width = 20 * 2 * (WORLD_WIDTH + 1);
            this.Height = 20 * 2 * (WORLD_HEIGHT + 1);
            // овде кодот за иницијализација на матрицата foodWorld

            foodWorld = new bool[10][];
            for (int i = 0; i < foodWorld.Length; i++)
            {
                foodWorld[i] = new bool[15];
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    foodWorld[i][j] = true;
                }
            }

            // овде кодот за иницијализација и стартување на тајмерот
            timer1.Interval = TIMER_INTERVAL;
            timer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.Black;
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * 20 * 2 + (20 * 2 - foodImage.Height) / 2, i * 20 * 2 + (20 * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pacman.changeDirection(Direction.Up);
            }
            else if (e.KeyCode == Keys.Down)
            {
                pacman.changeDirection(Direction.Down);
            }
            else if (e.KeyCode == Keys.Left)
            {
                pacman.changeDirection(Direction.Left);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pacman.changeDirection(Direction.Right);
            }

            Invalidate();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * 20 * 2 + (20 * 2 - foodImage.Height) / 2, i * 20 * 2 + (20 * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // овде вашиот код
            pacman.Move();
            if (foodWorld[pacman.Y][pacman.X])
            {
                foodWorld[pacman.Y][pacman.X] = false;
            }
            Invalidate();
        }
    }
}
