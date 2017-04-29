using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using StringBuilderSubstring;
using GenericExtensions;
using Students;
using StudentGroupExtension;
using ExtractStudentsByTwoMark;

namespace StringBuilderExtensionMethodsDelegatesLambdaLINQ
{
    class StartUp
    {
        static void Main(string[] args)
        {
            #region StringBuilder substring test
            StringBuilder b = new StringBuilder("proba");
            StringBuilder c = b.Substring(0, 2);
            Console.WriteLine("StringBuilder substring test:\n");
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine("\n========\n");
            #endregion

            #region IEnumerable extensions test
            double[] test = { 2, 3, 4 };
            Console.WriteLine("IEnumerable extension test:\n");
            Console.WriteLine(test.Sum());
            Console.WriteLine(test.Product());
            Console.WriteLine(test.Min());
            Console.WriteLine(test.Max());
            Console.WriteLine(test.Average());
            Console.WriteLine("\n========\n");
            #endregion

            #region First before last test
            var filterNameFirstBeforeLast = StudentsList.studentsList
                .Where(student => String.Compare(student._firstName, student._lastName) <= 0);

            Console.WriteLine("First before last test:\n");
            foreach (var student in filterNameFirstBeforeLast)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n========\n");
            #endregion

            #region Age range test
            int min = 18;
            int max = 24;
            var filterAge = StudentsList.studentsList
                .Where(student => student._age >= min && student._age <= max);

            Console.WriteLine("Aged between 18 and 24 test:\n");
            foreach (var student in filterAge)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n========\n");
            #endregion

            #region Order students test

            IEnumerable orderStudents = Student.OrderByName(StudentsList.studentsArray);

            Console.WriteLine("Order descending test:\n");

            foreach (var student in orderStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n========\n");
            #endregion

            #region Divisible by 7 and 3 test
            int[] numbers = new int[] { 0, 1, 3, 7, 21, 33, 77, 63, -63 };
            var devisibleNumbers = numbers
                .Where(number => number % 3 == 0 && number % 7 == 0);
            Console.WriteLine("Divisible by 7 and 3 test:\n");
            foreach (var number in devisibleNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\n========\n");
            #endregion

            #region Students Group test

            int group = 2;

            var filterGroup = StudentsList.studentsList
                .Where(student => student._groupNumber == group)
                .OrderBy(student => student._firstName);

            Console.WriteLine("Students in group 2:\n");
            foreach (var student in filterGroup)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n========\n");

            #endregion

            #region Students Group extensions test

            StudentsList.studentsList.FilterStudentsByGroup(2);

            #endregion

            #region Extract students by email test

            string targetMail = "abv.bg";

            var filterEMail = StudentsList.studentsList
                .Where(student => student._email.EndsWith(targetMail))
                .OrderBy(student => student._firstName);

            Console.WriteLine("Students with email in abv.bg:\n");
            foreach (var student in filterEMail)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n========\n");

            #endregion

            #region Extract students by Phone number test

            string targetTel = "02";

            var filterPhone = StudentsList.studentsList
                .Where(student => student._tel.StartsWith(targetTel))
                .OrderBy(student => student._firstName);

            Console.WriteLine("Students with Phone numbers in Sofia:\n");
            foreach (var student in filterPhone)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n========\n");

            #endregion

            #region Extract students by 6 mark test

            int sixMark = 6;

            var filterSixMark = StudentsList.studentsList
                .Where(student => student._marks.Contains(sixMark))
                .OrderBy(student => student._firstName);
            
            Console.WriteLine("Students with at least one 6 mark:\n");
            foreach (var student in filterSixMark)
            {
                var anonymous = new { Fullname = string.Format("{0} {1}", student._firstName, student._lastName), Marks = student._marks };
                Console.WriteLine(anonymous.Fullname + "\nMarks:\n" + string.Join(", ", anonymous.Marks));
            }
            Console.WriteLine("\n========\n");

            #endregion

            #region Extract students by two 2 mark test

            int twoMark = 2;

            var filterTwoMark = StudentsList.studentsList
                .Where(student => student._marks.MarkCount(2) == 2)
                .OrderBy(student => student._firstName);

            Console.WriteLine("Students with exactly two 2 marks:\n");
            foreach (var student in filterTwoMark)
            {
                var anonymous = new { Fullname = string.Format("{0} {1}", student._firstName, student._lastName), Marks = student._marks };
                Console.WriteLine(anonymous.Fullname + "\nMarks:\n" + string.Join(", ", anonymous.Marks));
            }
            Console.WriteLine("\n========\n");

            #endregion

            #region Extract students by FN test

            string targetFN = "06";

            var filterFN = StudentsList.studentsList
                .Where(student => (student._FN).ToString().EndsWith(targetFN))
                .OrderBy(student => student._firstName);

            Console.WriteLine("Students enrolled in 2006:\n");
            foreach (var student in filterEMail)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\n========\n");

            #endregion
        }
    }
}
