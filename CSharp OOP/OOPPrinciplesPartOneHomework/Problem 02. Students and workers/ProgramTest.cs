using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class ProgramTest
    {
        public static List<Student> ArrangeStudentsByGrade(List<Student> students)
        {
            var result = students.OrderBy(st => st.Grade);
            return result.ToList();
        }

        public static List<Worker> ArrangeWorkersBymoneyPerHour(List<Worker> workers)
        {
            var result = workers.OrderByDescending(w => w.MoneyPerHour());
            return result.ToList();
        }

        public static List<Human> ArrangePeopleByName(List<Human> people)
        {
            var result = people.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);
            return result.ToList();
        }

        static List<Student> LoadStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivaylo", "Andonov", 12));
            students.Add(new Student("Petyr", "Tudjarov", 10));
            students.Add(new Student("Zdravko", "Kiselov", 8));
            students.Add(new Student("Rosen", "Gacov", 6));
            students.Add(new Student("Walter", "White", 4));
            students.Add(new Student("Jesse", "Pinkman", 11));
            students.Add(new Student("Mike", "Ehrmantraut", 9));
            students.Add(new Student("Nucky", "Thompson", 7));
            students.Add(new Student("Jimmy", "Darmody", 5));
            students.Add(new Student("Lucky", "Luciano", 3));

            return students;
        }

        static List<Worker> LoadWorkers()
        {
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Ivanov", 284, 8));
            workers.Add(new Worker("George", "Georgiev", 326, 8));
            workers.Add(new Worker("Petyr", "Petrov", 158, 6));
            workers.Add(new Worker("Angel", "Angelov", 134, 4));
            workers.Add(new Worker("Dimityr", "Dimitrov", 463, 8));
            workers.Add(new Worker("Nikolay", "Nikolov", 412, 12));
            workers.Add(new Worker("Stoyan", "Stoyanov", 208, 6));
            workers.Add(new Worker("Stefan", "Stefanov", 181, 4));
            workers.Add(new Worker("Hristo", "Hristov", 363, 12));
            workers.Add(new Worker("Asen", "Asenov", 610, 8));

            return workers;
        }

        static List<Human> MergeLists(List<Student> students, List<Worker> workers)
        {
            List<Human> mergedList = new List<Human>(students);
            foreach (var worker in workers)
            {
                mergedList.Add(worker);
            }
            return mergedList;
        }

        static void Main()
        {
            List<Student> students = LoadStudents();
            var orderedStudentsByGrade = ArrangeStudentsByGrade(students);
            Console.WriteLine("TEST FOR CLASS STUDENT AND METHOD ARRANGE BY GRADE: ");
            Console.WriteLine();
            foreach (var student in orderedStudentsByGrade)
            {
                Console.WriteLine("Student: {0}", student.FirstName + " " + student.LastName);
                Console.WriteLine("Grade: {0}", student.Grade);
            }
            Console.WriteLine();

            List<Worker> workers = LoadWorkers();
            var orderedWorkersByMoneyPerHour = ArrangeWorkersBymoneyPerHour(workers);
            Console.WriteLine("TEST FOR CLASS WORKER AND METHOD ARRANGE BY MONEY PER HOUR IN DESCENDING ORDER: ");
            Console.WriteLine();
            foreach (var worker in orderedWorkersByMoneyPerHour)
            {
                Console.WriteLine("Worker: {0}", worker.FirstName + " " + worker.LastName);
                Console.WriteLine("Money per hour: {0:F2}", worker.MoneyPerHour());
            }
            Console.WriteLine();

            List<Human> mergedList = MergeLists(students, workers);
            var orderedpeopleByName = ArrangePeopleByName(mergedList);
            Console.WriteLine("TEST FOR CLASS HUMAN AND METHODS MERGE LISTS AND ARRANGE BY FIRST AND LAST NAME:");
            Console.WriteLine();
            foreach (var person in orderedpeopleByName)
            {
                Console.WriteLine("Full name: {0} - {1}", person.FirstName + " " + person.LastName, person.GetType().ToString().Substring(19));
            }

        }
    }
}
