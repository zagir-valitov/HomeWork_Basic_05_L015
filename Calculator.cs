using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal static class Calculator
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine($"Summ: {a} + {b} = {a + b}");
        }
        public static void Add(int a, int b, int c)
        {
            Console.WriteLine($"Summ: {a} + {b} + {c} = {a + b + c}");
        }        
    }
}
