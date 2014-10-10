using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mathtastic.Structures
{
    class Transformations
    {

        public Matrix Scale(Matrix VectorMatrix, Matrix ScalarMatrix)
        {

            
            Matrix ScaledMatrix = new Matrix(1, 4);
          //  ScaledMatrix = ScalarMatrix * VectorMatrix;

          //  ScaledMatrix = 
            return ScaledMatrix;
        }
        public Matrix RotateXY(Vector inputVector, double degrees)
        {
            //Create TransMatrix object and assign rows and columns
            Matrix TransMAtrix = new Matrix(4, 4);

            //Convert degrees to radians
          //  C
            TransMAtrix.Elements[0, 0] = 1; TransMAtrix.Elements[0, 1] = 0; TransMAtrix.Elements[0, 2] = 0; TransMAtrix.Elements[0, 3] = 0;
            TransMAtrix.Elements[0, 0] = 0; TransMAtrix.Elements[0, 1] = 1; TransMAtrix.Elements[0, 2] = 0; TransMAtrix.Elements[0, 3] = 0;



            return TransMAtrix;
               ;
        }
    }
}
