using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Teacher : People
    {
        private string _name;
        List<Discipline> _disciplines = new List<Discipline>();
        string _optionalComments;

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public List<Discipline> Disciplines
        {
            get
            {
                return _disciplines;
            }
        }
        public string OptionalComments
        {
            get
            {
                return _optionalComments;
            }
        }

        public Teacher(string name, string optionalComments = null) : base(name)
        {
            base._name = name;
            this._optionalComments = optionalComments;
        }

        public void AddDiscipline(Discipline discipline)
        {
            Disciplines.Add(discipline);
        }
    }
}
