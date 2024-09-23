using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal class Widget : I1, I2
    {
        public void Foo()
        {
            Console.WriteLine("Реализация I1.Foo() в Widget");
        }
        int I2.Foo()
        {
            Console.WriteLine("Реализация I2.Foo() в Widget");
            return 0;
        }
    }
}
