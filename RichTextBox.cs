using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    public class RichTextBox : TextBox, IUndoable
    {
        public new void Undo()
            => Console.WriteLine("RichTextBox.Undo()");
    }
}
