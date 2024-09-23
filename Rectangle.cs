using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal class Rectangle : Figure
    {
        public int SideA;
        public int SideB;
        public Rectangle(int sideA, int sideB) 
        {
            SideA = sideA;
            SideB = sideB;  
        }
        public override int GetArea()
        {
            //return 5;
            return SideA * SideB;
        }
    }
}
