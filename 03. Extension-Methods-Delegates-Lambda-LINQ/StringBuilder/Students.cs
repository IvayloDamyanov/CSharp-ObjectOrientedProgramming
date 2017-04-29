using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string _firstName { get; private set; }
        public string _lastName { get; private set; }
        public int _age { get; private set; }
        public int _FN { get; private set; }
        public string _tel { get; private set; }
        public string _email { get; private set; }
        public List<int> _marks { get; private set; }
        public int _groupNumber { get; private set; }

        public Student(string firstName, string lastName, int age, int FN, string tel, string email, List<int> marks, int groupNumber)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
            this._FN = FN;
            this._tel = tel;
            this._email = email;
            this._marks = marks;
            this._groupNumber = groupNumber;
        }

        public override string ToString()
        {
            string output = this._firstName + this._lastName;
            return output;
        }

        public static IEnumerable OrderByName(Student[] students)
        {
            var orderStudents = students
                .OrderByDescending(student => student._firstName)
                .ThenByDescending(student => student._lastName);
            return orderStudents;
        } 
    }
    public class StudentsList
    {
        static Student chokoBokov = new Student("Choko", "Bokov", 63, 012005, "0888112233", "chokoboko@abv.bg", new List<int> { 2, 2, 5, 6 }, 2);
        static Student doniMamuta = new Student("Doni", "Mamuta", 25, 022006, "0888445566", "donimamuta@abv.bg", new List<int> { 3, 3, 4, 5}, 1);
        static Student tomiDjerev = new Student("Tomi", "Djerev", 5, 032005, "022778899", "tomi@djerev.com", new List<int> { 2, 2, 2, 6 }, 2);
        static Student maksiMoritz = new Student("Maksi", "Moritz", 19, 042006, "027114477", "maksi@moritz.com", new List<int> { 2, 2, 4, 6 }, 1);
        public static List<Student> studentsList = new List<Student> { chokoBokov, doniMamuta, tomiDjerev, maksiMoritz };
        public static Student[] studentsArray = studentsList.ToArray();
        //public Student[] StudentsArray
        //{
        //    get
        //    {
        //        return studentsArray;
        //    }
        //    private set
        //    {
        //        studentsArray = value;
        //    }
        //}
    }
}
