using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Animal
    {
        protected int _age;
        protected string _name;
        protected bool _isMale;

        public Animal(int age, string name, bool isMale)
        {
            this._age = age;
            this._name = name;
            this._isMale = isMale;
        }

        public int Age
        {
            get { return this._age; }
        }
        public string Name
        {
            get { return this._name; }
        }
        public bool IsMale
        {
            get { return _isMale; }
        }
    }
}
