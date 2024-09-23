using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    public interface IUndoable
    {
        const double Pi = 3.14; 
        void Undo();
        void DisplayPi()
        {
            Console.WriteLine($"Pi = {Pi}");
        }
    }
}
