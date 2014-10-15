using System;
using Mathtastic.Helpers;

namespace Mathtastic.Structures
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double W { get; set; } // To make the point class a homogeneous point, add W field.

        public Point()
        {
            X = Y = Z = 0;
            W = 1;
        }


        public Point(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public void SetPoint(Point point)
        {
            X = point.X;
            Y = point.Y;
            Z = point.Z;
            W = point.W;
        }

        public Point AddVector(Vector vector)
        {
            return new Point
            {
                X = X + vector.X,
                Y = Y + vector.Y,
                Z = Z + vector.Z
            };
        }

        public Point SubtractVector(Vector vector)
        {
            return new Point
            {
                X = X - vector.X,
                Y = Y - vector.Y,
                Z = Z - vector.Z
            };
        }

        public Vector SubtractPoint(Point point)
        {
            return new Vector
            {
                X = X - point.X,
                Y = Y - point.Y,
                Z = Z - point.Z
            };
        }

        public Point RotateXZ(double deg, Point p)
        {

            Point RotatedPoint = new Point();


            double rad = Extensions.ToRadians(deg);

            RotatedPoint.X = (Math.Cos(rad) * p.X) + (Math.Sin(rad) * p.X);
            RotatedPoint.Y = p.Y;
            RotatedPoint.Z = -(Math.Sin(rad) * p.Z) + (Math.Cos(rad) * p.Z); 
            RotatedPoint.W = p.W;

            return RotatedPoint;



        }

        public Point RotateXY(double deg, Point p)
        {


            Point RotatedPoint= new Point();


            double rad = Extensions.ToRadians(deg);

            RotatedPoint.X = (Math.Cos(rad) * p.X) - (Math.Sin(rad)*p.X);
            RotatedPoint.Y = (Math.Sin(rad) * p.Y) + (Math.Cos(rad) * p.Y);
            RotatedPoint.Z = p.Z;
            RotatedPoint.W = p.W;
            
            return RotatedPoint;
        
        }

        public Point ViewportXForm(Point p)
        {

            Point viewPoint = new Point();

            viewPoint.X = ((700 / 2) * p.X) + (p.X + (700 / 2));
            viewPoint.Y = ((700 / 2) * p.Y) + (p.Y + (700 / 2));
            viewPoint.Z = p.Z;
            return viewPoint;
        }


        public void Scale(Point scalingPoint)
        {
            X = X*scalingPoint.X;
            Y = Y*scalingPoint.Y;
            Z = Z*scalingPoint.Z;

        }
        public void PrintPointToScreen()
        {
            Console.WriteLine("{{{0}, {1}, {2}}}", X, Y, Z);
            Console.WriteLine();
        }

        
    }
}
