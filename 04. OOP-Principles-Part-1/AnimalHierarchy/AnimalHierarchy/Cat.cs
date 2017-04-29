using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat(int age, string name, bool isMale) : base(age, name, isMale)
        {
            base._age = age;
            base._name = name;
            base._isMale = isMale;
        }

        public string makeSound()
        {
            string output = "Meow";
            return output;
        }
    }
}
