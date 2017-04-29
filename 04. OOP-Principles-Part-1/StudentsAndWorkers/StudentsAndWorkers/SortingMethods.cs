using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class SortingMethods
    {
        public static IEnumerable OrderStudentsByGrade(List<Student> students)
        {
            var orderStudents = students
                .OrderBy(student => student.Grade);
            return orderStudents;
        }

        public static IEnumerable OrderWorkersByMoneyPerHour(List<Worker> workers)
        {
            var orderWorkers = workers
                .OrderByDescending(worker => worker.MoneyPerHour());
            return orderWorkers;
        }

        public static IEnumerable OrderByName(List<Human> humans)
        {
            var orderHumans = humans
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName);
            return orderHumans;
        }
    }
}
