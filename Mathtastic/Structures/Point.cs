using System;
using Mathtastic.Helpers;

namespace Mathtastic.Structures
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point()
        {
            X = Y = Z = 0;
        }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void SetPoint(Point point)
        {
            X = point.X;
            Y = point.Y;
            Z = point.Z;
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

        public void PrintPointToScreen()
        {
            Console.WriteLine("{{{0}, {1}, {2}}}", X, Y, Z);
            Console.WriteLine();
        }

        public void RotateXy(double degrees)
        {
            var rad = degrees.ToRadians();

            X = Math.Cos(rad)*X + -Math.Sin(rad)*Y;
            Y = Math.Sin(rad)*X + Math.Cos(rad)*Y;
        }

        public void RotateXz(double degrees)
        {
            var rad = degrees.ToRadians();

            X = Math.Cos(rad)*X + Math.Sin(rad)*Z;
            Z = -Math.Sin(rad)*X + Math.Cos(rad)*Z;
        }

        public void RotateYz(double degrees)
        {
            var rad = degrees.ToRadians();

            Y = Math.Cos(rad)*Y + -Math.Sin(rad)*Z;
            Z = Math.Sin(rad)*Y + Math.Cos(rad)*Z;
        }


        public void Scale(Point scalingPoint)
        {
            X = X*scalingPoint.X;
            Y = Y*scalingPoint.Y;
            Z = Z*scalingPoint.Z;
        }
    }
}
