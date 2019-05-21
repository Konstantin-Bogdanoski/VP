using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pravoagolnici
{
    public partial class Form1 : Form
    {
        Timer timer;
        Rectangles Rectangles;
        Color color;
        private string FileName;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            Rectangles = new Rectangles();
            timer.Start();
            color = Color.Red;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Rectangles.Move();
            Rectangles.Check(Width, Height);
            Invalidate(true);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Invalidate();
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Rectangles.StartMoving(e.X, e.Y, Rectangle.Direction.RIGHT);
            }
            else
            {
                Rectangles.StartMoving(e.X, e.Y, Rectangle.Direction.DOWN);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Rectangles.Draw(e.Graphics);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Rectangles.addRectangle(e.Location, color);
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            rectangleCountTextBox.Text = string.Format("{0}", Rectangles.RectangleList.Count);
        }


        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rectangles file (*.rct)|*.rct";
                saveFileDialog.Title = "Rectangles Rectangles";
                saveFileDialog.FileName = FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, Rectangles);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rectangles file (*.rct)|*.rct";
            openFileDialog.Title = "Rectangles Rectangles";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        Rectangles = (Rectangles)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Rectangles = new Rectangles();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = d.Color;
            }
        }

    }
}
