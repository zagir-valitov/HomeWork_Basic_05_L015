using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    public abstract class Member
    {
        public abstract string Name { get; set; }
        public abstract void BorrowItem(LibraryItem item);
    }    
}
