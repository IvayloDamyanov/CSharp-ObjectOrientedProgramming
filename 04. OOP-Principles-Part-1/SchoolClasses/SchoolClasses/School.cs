using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class School
    {
        private List<ClassOfStudents> _classesOfStudents = new List<ClassOfStudents>();

        public List<ClassOfStudents> ClassesOfStudents
        {
            get
            {
                return this._classesOfStudents;
            }
        }

        public School()
        {
        }

        public void AddClassOfStudents(ClassOfStudents classOfStudents)
        {
            _classesOfStudents.Add(classOfStudents);
        }
    }
}
