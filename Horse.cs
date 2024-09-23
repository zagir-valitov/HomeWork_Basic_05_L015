using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal class Horse : IWalkable
    {
        public void Walk() 
        {
            Console.WriteLine("The horse walked 500 meters");
        }
    }
}
