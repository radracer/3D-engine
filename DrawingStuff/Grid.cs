using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using m = Mathtastic.Structures;
using System;

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

            //build Mesh frame with vertices
            var mesh = new Mathtastic.Structures.Mesh("Cube!", 8);

            mesh.Vertices[0] = new m.Vector(-1, 1, 1);
            mesh.Vertices[1] = new m.Vector(1, 1, 1);
            mesh.Vertices[2] = new m.Vector(-1, -1, 1);
            mesh.Vertices[3] = new m.Vector(-1, -1, -1);
            mesh.Vertices[4] = new m.Vector(-1, 1, -1);
            mesh.Vertices[5] = new m.Vector(1, 1, -1);
            mesh.Vertices[6] = new m.Vector(1, -1, 1);
            mesh.Vertices[7] = new m.Vector(1, -1, -1);


            try
            {
                using (var pen = new Pen(Color.DarkGray, 1))
                {
                    var verticalPoint1 = new Point((Size / 2) + Offset, Offset);
                    var verticalPoint2 = new Point((Size / 2) + Offset, Offset + Size);
                    e.Graphics.DrawLine(pen, verticalPoint1, verticalPoint2);

                    var horizaontalPoint1 = new Point(Offset, (Size / 2) + Offset);
                    var horizaontalPoint2 = new Point(Offset + Size, (Size / 2) + Offset);
                    e.Graphics.DrawLine(pen, horizaontalPoint1, horizaontalPoint2);

                    Points.ForEach((p) =>
                    {
                        Brush brush = new SolidBrush(Color.Black);
                        //Rectangle rect = new Rectangle(

                        double px;
                        double py;
                        double pz;


                        px = p.X;//+ DistanceToCenter();
                        py = p.Y;// +DistanceToCenter();
                        
                        
                        
                        m.Point finalP = new m.Point();
                        //Create the viewport xform points (converting 3d world to 2d screen
                        finalP = p.ViewportXForm(p);
                        
                        e.Graphics.FillRectangle(brush, Convert.ToInt64(finalP.X), Convert.ToInt64(finalP.Y), 2, 2);


                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

              
            }
        }

        public void AddPoint(m.Point point)
        {
            Points.Add(point);
        }


        public void RotatePointsXy(float degrees)
        {
            Points.ForEach(
                (p) => p.RotateXY(degrees,p)
                    
                );
        }
        public void RotatePointsXz(float degrees)
        {
            Points.ForEach((p) => p.RotateXZ(degrees,p));
        }
        public void RotatePointsYz(float degrees)
        {
          //  Points.ForEach((p) => p.RotateYz(degrees));
        }
        public void ScalePoints(double amount)
        {
            var scalingPoint = new m.Point(amount, amount, amount,1);
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

        public double DistanceToCenter()
        {
            return Offset + (Size/2);
        }

        #endregion Boundaries
    }
}
