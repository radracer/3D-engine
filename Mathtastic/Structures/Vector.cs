using System;
using Mathtastic.Helpers;

namespace Mathtastic.Structures
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector()
        {
            X = Y = Z = 0;
        }

        public Vector(double x, double y, double z)
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

<<<<<<< HEAD
=======
        public Vector RotateXy(double degrees)
        {
            var rad = degrees.ToRadians();

            return new Vector
            {
                X = Math.Cos(rad) * X + -Math.Sin(rad) * Y,
                Y = Math.Sin(rad) * X +  Math.Cos(rad) * Y,
                Z = Z
            };
        }

        public Vector RotateXz(double degrees)
        {
            var rad = degrees.ToRadians();

            return new Vector
            {
                X = Math.Cos(rad) * X + Math.Sin(rad) * Z,
                Y = Y,
                Z = -Math.Sin(rad) * X + Math.Cos(rad) * Z,
            };
        }

        public Vector RotateYz(double degrees)
        {
            var rad = degrees.ToRadians();

            return new Vector
            {
                X = X,
                Y = Math.Cos(rad) * Y + -Math.Sin(rad) * Z,
                Z = Math.Sin(rad) * Y +  Math.Cos(rad) * Z,
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

>>>>>>> origin/master
        public void PrintVectorToScreen()
        {
            Console.WriteLine("{{{0}, {1}, {2}}}", X, Y, Z);
            Console.WriteLine();
        }
       
    }
}
