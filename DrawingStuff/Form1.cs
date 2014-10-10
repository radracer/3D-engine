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
            draw_Click(null, null);
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
        }

        private void draw_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grid.RotatePointsXz(float.Parse(rotateXzDegrees.Text));
            canvas.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grid.RotatePointsYz(float.Parse(rotateYzDegrees.Text));
            canvas.Refresh();
        }
    }
}
