using System;
using System.Collections.Generic;
using System.Text;

namespace NeuronLib
{
    public class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public Point3D(Point3D input)
        {
            X = input.X;
            Y = input.Y;
            Z = input.Z;
        }
    }
}
