using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Student : People
    {
        
        int _uniqueClassNumber;
        string _optionalComments;

        public int UniqueClassNumber
        {
            get
            {
                return _uniqueClassNumber;
            }
        }
        public string OptionalComments
        {
            get
            {
                return _optionalComments;
            }
        }

        public Student(string name, int uniqueClassNumber, string optionalComments = null) : base(name)
        {
            base._name = name;
            this._uniqueClassNumber = uniqueClassNumber;
            this._optionalComments = optionalComments;
        }
    }
}
