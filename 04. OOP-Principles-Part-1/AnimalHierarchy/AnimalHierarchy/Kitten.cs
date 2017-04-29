using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(int age, string name, bool isMale = false) : base(age, name, isMale)
        {
            base._age = age;
            base._name = name;
            base._isMale = false;
        }
    }
}
