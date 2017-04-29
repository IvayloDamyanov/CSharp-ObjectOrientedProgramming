using Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroupExtension
{
    public static class StudentGroupExtension
    {
        public static void FilterStudentsByGroup(this List<Student> studentsList, int targetGroup)
        {
            int group = targetGroup;

            var filterGroup = StudentsList.studentsList
                .Where(student => student._groupNumber == group)
                .OrderBy(student => student._firstName);

            Console.WriteLine("Students in group 2 by extension method:\n");
            foreach (var student in filterGroup)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n========\n");
        }
    }
}
