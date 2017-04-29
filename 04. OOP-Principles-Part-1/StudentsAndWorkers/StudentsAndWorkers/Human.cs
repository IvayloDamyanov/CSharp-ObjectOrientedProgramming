using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    abstract class Human
    {
        protected string _firstname;
        protected string _lastname;

        public Human(string firstName, string lastName)
        {
            this._firstname = firstName;
            this._lastname = lastName;
        }

        public override string ToString()
        {
            string output = this.FirstName + " " + this.LastName;
            return output;
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
        }
    }
}
