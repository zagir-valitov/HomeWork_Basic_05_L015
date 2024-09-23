using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal class BasicMember : Member
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override void BorrowItem(LibraryItem item)
        {
            throw new NotImplementedException();
        }
    }
}
