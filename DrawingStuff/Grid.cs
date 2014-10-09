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
            using (var pen = new Pen(Color.DarkGray, 3))
            {
                var verticalPoint1 = new Point((Size/2) + Offset, Offset);
                var verticalPoint2 = new Point((Size/2) + Offset, Offset + Size);
                e.Graphics.DrawLine(pen, verticalPoint1, verticalPoint2);

                var horizaontalPoint1 = new Point(Offset, (Size/2) + Offset);
                var horizaontalPoint2 = new Point(Offset + Size, (Size/2) + Offset);
                e.Graphics.DrawLine(pen, horizaontalPoint1, horizaontalPoint2);

                var linePen = new Pen(Color.OrangeRed, 1);
                m.Point last = null;
                Points.ForEach((p) =>
                {
                    Brush brush = new SolidBrush(Color.Black);
                    e.Graphics.FillRectangle(brush, Convert.ToInt64(p.X) + DistanceToCenter(), Convert.ToInt64(p.Y) + +DistanceToCenter(), 3, 3);

                    var thisPoint = new Point();
                    thisPoint.X = Convert.ToInt32(p.X) + Offset + (Size / 2) + 1;
                    thisPoint.Y = Convert.ToInt32(p.Y) + Offset + (Size / 2) + 1;

                    if (last != null)
                    {
                        var lastPoint = new Point();
                        lastPoint.X = Convert.ToInt32(last.X) + Offset + (Size / 2) + 1;
                        lastPoint.Y = Convert.ToInt32(last.Y) + Offset + (Size / 2) + 1;
                        e.Graphics.DrawLine(linePen, lastPoint, thisPoint);
                    }
                    last = p;
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
        public void ScalePoints(double amount)
        {
            var scalingPoint = new m.Point(amount, amount, amount);
            Points.ForEach((p) => p.Scale(scalingPoint));
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
