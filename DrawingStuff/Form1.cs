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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            draw_Click(null, null);
            grid = new Grid(gridSize, offset);
            var random = new Random(Guid.NewGuid().GetHashCode());

            for (int x = 0; x < 30; x++)
            {
                var X = random.Next(-(gridSize / 2), gridSize / 2);
                var Y = random.Next(-(gridSize / 2), gridSize / 2);
                var Z = random.Next(-(gridSize / 2), gridSize / 2);
                var newPoint = new m.Point(X, Y, Z);
                grid.AddPoint(newPoint);
            }
        }

        private void draw_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
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
    }
}
