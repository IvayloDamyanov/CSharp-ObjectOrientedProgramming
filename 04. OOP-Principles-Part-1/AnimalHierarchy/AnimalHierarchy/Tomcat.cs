using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name, bool isMale = true) : base(age, name, isMale)
        {
            base._age = age;
            base._name = name;
            base._isMale = true;
        }
    }
}
