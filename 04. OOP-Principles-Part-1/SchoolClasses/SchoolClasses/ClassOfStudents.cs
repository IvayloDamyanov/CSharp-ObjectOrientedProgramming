using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class ClassOfStudents
    {
        string _uniqueTextIdentifier;
        List<Teacher> _teachers = new List<Teacher>();
        List<Student> _students = new List<Student>();
        string _optionalComments;

        public string UniqueTextIdentifier
        {
            get
            {
                return _uniqueTextIdentifier;
            }
        }
        public List<Teacher> Teachers
        {
            get
            {
                return _teachers;
            }
        }
        public List<Student> Students
        {
            get
            {
                return _students;
            }
        }
        public string OptionalComments
        {
            get
            {
                return _optionalComments;
            }
        }

        public ClassOfStudents(string uniqueTextIdentifier, string optionalComments = null)
        {
            this._uniqueTextIdentifier = uniqueTextIdentifier;
            this._optionalComments = optionalComments;
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
    }
}
