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

        const int gridSize = 700;
        const int offset = 0;
        //If xy_rotate is set to true, the corrdinates will rotate around the xy axis by 2 degrees each paint
        public bool xy_rotate = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new Grid(gridSize, offset);
            var random = new Random(Guid.NewGuid().GetHashCode());


            for (int x = 0; x < 2; x++)
            {
                var X = random.Next(-(gridSize / 2), gridSize / 2);
                var Y = random.Next(-(gridSize / 2), gridSize / 2);
                var Z = random.Next(0, gridSize / 100);
                var W = 1; //for all points, w = 1
                var newPoint = new m.Point(X, Y, Z, W);

                grid.AddPoint(newPoint);
            }

            reset.Refresh();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            if (xy_rotate)
            {
                grid.RotatePointsXy(float.Parse(rotateXyDegrees.Text));
                grid.DrawGrid(e);
            }
            else grid.DrawGrid(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (xy_rotate)
            {
                xy_rotate = false;
            }
            else xy_rotate = true;

            grid.RotatePointsXy(Int32.Parse(rotateXyDegrees.Text));
            reset.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            grid.RotatePointsXz(Int32.Parse(rotateXzDegrees.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {

            grid.RotatePointsYz(Int32.Parse(rotateYzDegrees.Text));
            reset.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grid.ScalePoints(Double.Parse(scalePoints.Text));
            reset.Refresh();

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

                reset.Refresh();
            }
        }

  
    }
}
