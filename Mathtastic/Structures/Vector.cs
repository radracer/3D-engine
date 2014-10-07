using System;
using Mathtastic.Helpers;

namespace Mathtastic.Structures
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Vector()
        {
            X = Y = Z = 0;
        }

        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector FindCrossProduct(Vector bVector)
        {
            return new Vector
            {
                X = (Y*bVector.Z) - (Z*bVector.Y),
                Y = (Z*bVector.X) - (X*bVector.Z),
                Z = (X*bVector.Y) - (Y*bVector.X)
            };
        }

        public Vector AddVector(Vector vector)
        {
            return new Vector
            {
                X = X + vector.X,
                Y = Y + vector.Y,
                Z = Z + vector.Z
            };
        }

        public Vector SubtractVector(Vector vector)
        {
            return new Vector
            {
                X = X - vector.X,
                Y = Y - vector.Y,
                Z = Z - vector.Z
            };
        }

        public Vector RotateXy(double degrees)
        {
            var rad = degrees.ToRadians();

            return new Vector
            {
                X = Convert.ToInt32(Math.Cos(rad) * X) + -Convert.ToInt32(Math.Sin(rad) * Y),
                Y = Convert.ToInt32(Math.Sin(rad) * X) + Convert.ToInt32(Math.Cos(rad) * Y),
                Z = Z
            };
        }

        public Vector RotateXz(double degrees)
        {
            var rad = degrees.ToRadians();

            return new Vector
            {
                X = Convert.ToInt32(Math.Cos(rad) * X) + Convert.ToInt32(Math.Sin(rad) * Z),
                Y = Y,
                Z = -Convert.ToInt32(Math.Sin(rad) * X) + Convert.ToInt32(Math.Cos(rad) * Z),
            };
        }

        public Vector RotateYz(double degrees)
        {
            var rad = degrees.ToRadians();

            return new Vector
            {
                X = X,
                Y = Convert.ToInt32(Math.Cos(rad) * Y) + -Convert.ToInt32(Math.Sin(rad) * Z),
                Z = Convert.ToInt32(Math.Sin(rad) * Y) + Convert.ToInt32(Math.Cos(rad) * Z),
            };
        }

        public Vector Scale(Vector scalingVector)
        {
            return new Vector
            {
                X = X*scalingVector.X,
                Y = Y*scalingVector.Y,
                Z = Z*scalingVector.Z
            };
        }

        public void PrintVectorToScreen()
        {
            Console.WriteLine("{{{0}, {1}, {2}}}", X, Y, Z);
            Console.WriteLine();
        }
    }
}
