using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    public class TextBox : IUndoable
    {
        void IUndoable.Undo()
            => Console.WriteLine("TextBox.Undo()");
    }
}
