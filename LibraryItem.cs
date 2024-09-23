using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    public abstract class LibraryItem
    {   public abstract string Title { get; set; }
        public abstract void Checkout();
        public abstract void Return();
    }

}
