using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human
    {
        private int _grade;

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            base._firstname = firstName;
            base._lastname = lastName;
            this._grade = grade;
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += ", Grade: " + this.Grade;
            return output;
        }

        public int Grade
        {
            get
            {
                return _grade;
            }
        }
    }
}
