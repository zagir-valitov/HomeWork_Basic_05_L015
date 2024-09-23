using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    abstract class Figure
    {
        public abstract int GetArea();
        public static void Draw()
        {
            Console.WriteLine("Drawing a figure");
        }
    }
}
