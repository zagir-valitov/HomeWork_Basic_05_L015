using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal class Vector
    {
        public double X;
        public double Y;
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);    
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
