using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mathtastic.Structures
{
    public class Mesh
    {
        public string Name { get; set; }

        public Vector[] Vertices { get; private set; }

        public Vector Position { get; set; }

        public Vector Rotation { get; set; }


        public Mesh(string name, int verticesCount)
        {
            Vertices = new Vector[verticesCount];
            
            Name = name;
        }
    }
}
