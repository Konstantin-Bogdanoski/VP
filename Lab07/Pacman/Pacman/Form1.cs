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
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        Image obstacleImage;
        bool[][] foodWorld;
        bool[][] obstacleWorld;
        Pacman pacman;
        int score = 0;
        int foodCount = 0;
        bool foodflag = true;
        bool randomFlag = true;

        public Form1()
        {
            InitializeComponent();
            this.foodImage = Resources.food;
            this.obstacleImage = Resources.obstacle;
            this.BackColor = Color.Black;
            DoubleBuffered = true;
            scoreTextBox.Text = score.ToString();
            newGame();
        }

        public void newGame()
        {
            this.Width = 20 * 2 * (WORLD_WIDTH + 1);
            this.Height = 20 * 2 * (WORLD_HEIGHT + 1);
            // овде кодот за иницијализација на матрицата foodWorld

            foodWorld = new bool[10][];
            obstacleWorld = new bool[10][];


            for (int i = 0; i < foodWorld.Length; i++)
            {
                foodWorld[i] = new bool[15];
                obstacleWorld[i] = new bool[15];
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    foodWorld[i][j] = true;
                    obstacleWorld[i][j] = true;
                }
            }
            progressBarValue.Minimum = 0;
            progressBarValue.Value = 0;
            score = 0;
            pacman = new Pacman(14, 9, obstacleWorld);

            // овде кодот за иницијализација и стартување на тајмерот
            timer1.Interval = TIMER_INTERVAL;
            timer1.Enabled = true;
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
                pacman.Y++;
            }
            else if (e.KeyCode == Keys.Down)
            {
                pacman.changeDirection(Direction.Down);
                pacman.Y--;
            }
            else if (e.KeyCode == Keys.Left)
            {
                pacman.changeDirection(Direction.Left);
                pacman.X++;
            }
            else if (e.KeyCode == Keys.Right)
            {
                pacman.changeDirection(Direction.Right);
                pacman.X--;
            }
            Invalidate();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
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
                        if (i == 0)
                        {
                            foodWorld[i][j] = false;
                        }                        
                        /* if (i == 3 && j < 4)
                        {
                            g.DrawImageUnscaled(obstacleImage, j * 20 * 2 + (20 * 2 - obstacleImage.Height) / 2, i * 20 * 2 + (20 * 2 - obstacleImage.Width) / 2);
                            obstacleWorld[i][j] = false;
                        }
                        else if (j == 2 && i < 2)
                        {
                            g.DrawImageUnscaled(obstacleImage, j * 20 * 2 + (20 * 2 - obstacleImage.Height) / 2, i * 20 * 2 + (20 * 2 - obstacleImage.Width) / 2);
                            obstacleWorld[i][j] = false;
                        }
                        else if (i == 7 && (5 < j && j < 8))
                        {
                            g.DrawImageUnscaled(obstacleImage, j * 20 * 2 + (20 * 2 - obstacleImage.Height) / 2, i * 20 * 2 + (20 * 2 - obstacleImage.Width) / 2);
                            obstacleWorld[i][j] = false;
                        }
                        else if (i == 7 && (2 < j && j < 5))
                        {
                            g.DrawImageUnscaled(obstacleImage, j * 20 * 2 + (20 * 2 - obstacleImage.Height) / 2, i * 20 * 2 + (20 * 2 - obstacleImage.Width) / 2);
                            obstacleWorld[i][j] = false;
                        }
                        else if (i < 7 && j == 5)
                        {
                            g.DrawImageUnscaled(obstacleImage, j * 20 * 2 + (20 * 2 - obstacleImage.Height) / 2, i * 20 * 2 + (20 * 2 - obstacleImage.Width) / 2);
                            obstacleWorld[i][j] = false;
                        } */
                    }
                    if(!obstacleWorld[i][j])
                        g.DrawImageUnscaled(obstacleImage, j * 20 * 2 + (20 * 2 - obstacleImage.Height) / 2, i * 20 * 2 + (20 * 2 - obstacleImage.Width) / 2);
                }
            }

            if (randomFlag)
            {
                randomFlag = false;
                Random random = new Random();
                for (int i = 0; i < 3; i++)
                {
                    int x = random.Next(foodWorld.Length - 5);
                    for (int j = 0; j < 3; j++)
                    {
                        g.DrawImageUnscaled(obstacleImage, j * 20 * 2 + (20 * 2 - obstacleImage.Height) / 2, x+1 * 20 * 2 + (20 * 2 - obstacleImage.Width) / 2);
                        obstacleWorld[x + 1][j] = false;
                    }
                }
            }

            if (foodflag)
            {
                foodflag = false;
                for (int i = 0; i < obstacleWorld.Length; i++)
                {
                    for (int j = 0; j < obstacleWorld[i].Length; j++)
                        if (obstacleWorld[i][j])
                            foodCount++;
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
                if (!foodWorld[pacman.Y][pacman.X])
                {
                    score++;
                    progressBarValue.Maximum = foodCount - 13;
                    progressBarValue.Value++;
                }
                scoreTextBox.Text = score.ToString();

                if (score == foodCount - 13)
                {
                    var choice = MessageBox.Show("You gathered all the points, \n CONGRATULATIONS\n Would you like to start a new game?", "WELL DONE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (choice == DialogResult.Yes)
                    {
                        newGame();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            Invalidate();
        }

        private void progressBarValue_Click(object sender, EventArgs e)
        {

        }
    }
}
