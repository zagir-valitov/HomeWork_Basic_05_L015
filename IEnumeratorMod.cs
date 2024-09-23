using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal interface IEnumerator
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }
}
