using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serijalizacija
{
    public partial class Form1 : Form
    {

        public BallDoc AllBalls { get; set; }
        public string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
            AllBalls = new BallDoc();
            FileName = null;
            DoubleBuffered = true;
            tssNumOfCirc.Text = AllBalls.Balls.Count.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!AllBalls.isLocationSet)
                {
                    AllBalls.isLocationSet = true;
                    AllBalls.CurrentLocation = e.Location;
                }
                else if (AllBalls.isLocationSet)
                {
                    AllBalls.CurrentRadius = AllBalls.pointsDistance(AllBalls.CurrentLocation, e.Location);
                    AllBalls.AddCircle();
                    AllBalls.CurrentLocation = Point.Empty;
                    AllBalls.CurrentRadius = default(int);
                    AllBalls.isLocationSet = false;

                    tssNumOfCirc.Text = AllBalls.Balls.Count.ToString();
                }
            }
            else if (e.Button == MouseButtons.Right)
                AllBalls.SetSelected(e.Location);

            Invalidate(true);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (AllBalls.isLocationSet)
            {
                AllBalls.UpdateRadius(e.Location);
                Invalidate(true);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            AllBalls.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (AllBalls.isLocationSet)
                {
                    AllBalls.isLocationSet = false;
                    AllBalls.CurrentLocation = Point.Empty;
                    AllBalls.CurrentRadius = default(int);
                    Invalidate(true);
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                Ball Ball = AllBalls.getSelected();
                if (!(Ball is null))
                {
                    Ball.Location = new Point(Ball.Location.X, Ball.Location.Y - 2);
                    Invalidate(true);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                Ball Ball = AllBalls.getSelected();
                if (!(Ball is null))
                {
                    Ball.Location = new Point(Ball.Location.X, Ball.Location.Y + 2);
                    Invalidate(true);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                Ball Ball = AllBalls.getSelected();
                if (!(Ball is null))
                {
                    Ball.Location = new Point(Ball.Location.X - 2, Ball.Location.Y);
                    Invalidate(true);
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                Ball Ball = AllBalls.getSelected();
                if (!(Ball is null))
                {
                    Ball.Location = new Point(Ball.Location.X + 2, Ball.Location.Y);
                    Invalidate(true);
                }
            }
            AllBalls.Colision();
            tssNumOfCirc.Text = AllBalls.Balls.Count.ToString();
            Invalidate(true);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                AllBalls.CurrentColor = colorDialog.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllBalls = new BallDoc();
            Invalidate(true);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            AllBalls = new BallDoc();
            Invalidate(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Balls File (.ballZ)|*.ballZ";
                sv.Title = "Save the ballz";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    FileName = sv.FileName;
                }
            }
            if (FileName != null)
            {
                BinaryFormatter binaryFormater = new BinaryFormatter();
                FileStream stream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                binaryFormater.Serialize(stream, AllBalls);
                stream.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Balls File (.ballZ)|*.ballZ";
                sv.Title = "Save the ballz";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    FileName = sv.FileName;
                }
            }
            if (FileName != null)
            {
                BinaryFormatter binaryFormater = new BinaryFormatter();
                FileStream stream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                binaryFormater.Serialize(stream, AllBalls);
                stream.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ball File (*.ballZ)|*ballZ";
            ofd.Title = "Open a Ball File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                AllBalls = (BallDoc)binaryFormatter.Deserialize(stream);
                stream.Close();
                tssNumOfCirc.Text = AllBalls.Balls.Count.ToString();
                Invalidate(true);
            }

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Balls AllBalls(*.ballZ)|*.ballZ";
            ofd.Title = "Open a Ball AllBalls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                AllBalls = (BallDoc)binaryFormatter.Deserialize(stream);
                stream.Close();
                tssNumOfCirc.Text = AllBalls.Balls.Count.ToString();
                Invalidate(true);
            }
        }
    }
}
