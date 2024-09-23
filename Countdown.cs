using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal class Countdown : IEnumerator
    {
        int count = 6;
        public bool MoveNext() => count-- > 0;
        public object Current => count;
        public void Reset() => count = 6;
    }
}
