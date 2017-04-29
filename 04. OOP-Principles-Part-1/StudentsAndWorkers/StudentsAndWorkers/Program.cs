using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List of students
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Petrov", 4));
            students.Add(new Student("Dimi", "Peshev", 8));
            students.Add(new Student("Grudi", "Jmudev", 3));
            students.Add(new Student("Ferdi", "Mravkov", 4));
            students.Add(new Student("Maks", "Imoritz", 1));
            students.Add(new Student("Jaba", "Thehut", 12));
            students.Add(new Student("Major", "Kusanagi", 9));
            students.Add(new Student("Maika", "Tereza", 99));
            students.Add(new Student("Jordanka", "Hristova", 52));
            students.Add(new Student("Zlatka", "Cherna", 1));
            #endregion

            #region List of workers
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Kiro", "Dyrvoto", 15, 2.2));
            workers.Add(new Worker("Pesho", "Neshev", 200000, 18));
            workers.Add(new Worker("Mitko", "Typoto", 10000, 4));
            workers.Add(new Worker("Paulina", "Staneva", 200, 8.5));
            workers.Add(new Worker("Spiro", "Lambov", 200, 5));
            workers.Add(new Worker("Anna", "Annanieva", 500, 5));
            workers.Add(new Worker("Nina", "Krysteva", 400, 7.3));
            workers.Add(new Worker("Jordanka", "Kaloyanova", 150, 3));
            workers.Add(new Worker("Penka", "Stamova", 300, 6));
            workers.Add(new Worker("Liubka", "Liubcheva", 2, 0.5));
            #endregion

            #region Merged List
            List<Human> mergedList = new List<Human>();
            foreach (var item in students)
            {
                mergedList.Add(item);
            }
            foreach (var item in workers)
            {
                mergedList.Add(item);
            }
            //mergedList.AddRange(students);
            //mergedList.AddRange(workers);
            #endregion

            #region Tests
            Console.WriteLine("Sorted students by grade test:\n");
            foreach (var student in SortingMethods.OrderStudentsByGrade(students))
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("\nSorted workers by money per hour test:\n");
            foreach (var worker in SortingMethods.OrderWorkersByMoneyPerHour(workers))
            {
                Console.WriteLine(worker.ToString());
            }
            Console.WriteLine("\nSorted by name test:\n");
            foreach (var human in SortingMethods.OrderByName(mergedList))
            {
                Console.WriteLine(human.ToString());
            }
            #endregion
        }
    }
}
