using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using m = Mathtastic.Structures;

namespace DrawingStuff
{
    public class Grid
    {
        private int Size { get; set; }
        private int Offset { get; set; }
        private List<m.Point> Points { get; set; }

        public Grid(int size, int offset)
        {
            Size = size;
            Offset = offset;
            Points = new List<m.Point>();
        }

        public void DrawGrid(PaintEventArgs e)
        {
            using (var pen = new Pen(Color.DarkGray, 1))
            {
                var verticalPoint1 = new Point((Size/2) + Offset, Offset);
                var verticalPoint2 = new Point((Size/2) + Offset, Offset + Size);
                e.Graphics.DrawLine(pen, verticalPoint1, verticalPoint2);

                var horizaontalPoint1 = new Point(Offset, (Size/2) + Offset);
                var horizaontalPoint2 = new Point(Offset + Size, (Size/2) + Offset);
                e.Graphics.DrawLine(pen, horizaontalPoint1, horizaontalPoint2);

                Points.ForEach((p) =>
                {
                    Brush brush = new SolidBrush(Color.Black);
                    e.Graphics.FillRectangle(brush, Convert.ToInt64(p.X) + DistanceToCenter(), Convert.ToInt64(p.Y) + +DistanceToCenter(), 2, 2);
                });
            }
        }

        public void AddPoint(m.Point point)
        {
            Points.Add(point);
        }


        public void RotatePointsXy(int degrees)
        {
            Points.ForEach((p) => p.RotateXy(degrees));
        }
        public void RotatePointsXz(int degrees)
        {
            Points.ForEach((p) => p.RotateXz(degrees));
        }
        public void RotatePointsYz(int degrees)
        {
            Points.ForEach((p) => p.RotateYz(degrees));
        }
        #region Boundaries

        public int MinX
        {
            get { return Offset; }
        }

        public int MaxX
        {
            get { return Offset + Size; }
        }

        public int MinY
        {
            get { return Offset; }
        }

        public int MaxY
        {
            get { return Offset + Size; }
        }

        public int MinZ
        {
            get { return 0; }
        }

        public int MaxZ
        {
            get { return 100; }
        }

        public int DistanceToCenter()
        {
            return Offset + (Size/2);
        }

        #endregion Boundaries
    }
}
