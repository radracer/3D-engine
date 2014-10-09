using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using m = Mathtastic.Structures;

namespace DrawingStuff
{
    public partial class Form1 : Form
    {
        private Grid grid { get; set; }
        const int gridSize = 600;
        const int offset = 150;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new Grid(gridSize, offset);
            var random = new Random(Guid.NewGuid().GetHashCode());

            for (int x = 0; x < 6; x++)
            {
                var X = random.Next(-(gridSize / 2), gridSize / 2);
                var Y = random.Next(-(gridSize / 2), gridSize / 2);
                var Z = random.Next(-(gridSize / 2), gridSize / 2);
                var newPoint = new m.Point(X, Y, Z);
                grid.AddPoint(newPoint);
            }

            canvas.Refresh();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            grid.DrawGrid(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid.RotatePointsXy(Int32.Parse(rotateXyDegrees.Text));
            canvas.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grid.RotatePointsXz(Int32.Parse(rotateXzDegrees.Text));
            canvas.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grid.RotatePointsYz(Int32.Parse(rotateYzDegrees.Text));
            canvas.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grid.ScalePoints(Double.Parse(scalePoints.Text));
            canvas.Refresh();
        }

        void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            if (!rotateXyDegrees.Focused && !rotateXzDegrees.Focused && !rotateYzDegrees.Focused && !scalePoints.Focused)
            {
                var amount = 1;
                if (e.Control)
                {
                    amount = 5;
                }
                if (e.Alt)
                {
                    amount = 10;
                }
                if (e.Control && e.Alt)
                {
                    amount = 20;
                }
                var key = e.KeyCode;
                if (key == Keys.OemPeriod)
                {
                    grid.RotatePointsXy(-amount);
                }
                if (key == Keys.Oemcomma)
                {
                    grid.RotatePointsXy(-amount);
                }
                if (key == Keys.NumPad4)
                {
                    grid.RotatePointsXz(-amount);
                }
                if (key == Keys.NumPad6)
                {
                    grid.RotatePointsXz(amount);
                }
                if (key == Keys.NumPad2)
                {
                    grid.RotatePointsYz(-amount);
                }
                if (key == Keys.NumPad8)
                {
                    grid.RotatePointsYz(amount);
                }

                if (key == Keys.NumPad9)
                {
                    grid.RotatePointsXz(amount);
                    grid.RotatePointsYz(amount);
                }
                if (key == Keys.NumPad1)
                {
                    grid.RotatePointsXz(-amount);
                    grid.RotatePointsYz(-amount);
                }

                if (key == Keys.NumPad7)
                {
                    grid.RotatePointsYz(amount);
                    grid.RotatePointsXz(-amount);
                }
                if (key == Keys.NumPad3)
                {
                    grid.RotatePointsYz(-amount);
                    grid.RotatePointsXz(amount);
                }

                canvas.Refresh();
            }
        }

  
    }
}
