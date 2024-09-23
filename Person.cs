using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    internal class Person
    {
        private string? _name;
        private int _age;

        public string? GetName() 
        { 
            return _name; 
        }

        public void SetName(string? name) 
        { 
            _name = name; 
        }

        public int GetAge() 
        { 
            return _age; 
        }

        public void SetAge(int age) 
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age));
            }
            _age = age;
        }
    }
}
