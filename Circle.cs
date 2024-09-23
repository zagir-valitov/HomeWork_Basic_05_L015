using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal class Circle : Figure
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override int GetArea()
        {
            //return 10;
            return (int)Math.PI * (int)Math.Pow(Radius, 2);
        }
    }
}
