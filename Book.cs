using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal class Book : LibraryItem
    {
        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override void Checkout()
        {
            throw new NotImplementedException();
        }

        public override void Return()
        {
            throw new NotImplementedException();
        }
    }
}
