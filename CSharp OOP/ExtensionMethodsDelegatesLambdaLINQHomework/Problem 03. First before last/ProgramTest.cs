//Problem 3. First before last
//    Write a method that from a given array of students finds all students whose first name 
//    is before its last name alphabetically.
//    Use LINQ query operators.
//Problem 4. Age range
//    Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
//Problem 5. Order students
//    Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the 
//    students by first name and last name in descending order.
//    Rewrite the same with LINQ.

namespace StudentExtensions
{
    using System;
    using System.Linq;

    class ProgramTest
    {
        // Problem 3. First before last
        public static Student[] AlphabeticalArrange(Student[] input)
        {
            //var result = input.Where(x => x.FirstName.CompareTo(x.LastName) < 0);
            var result =
                from st in input
                where st.FirstName.CompareTo(st.LastName) < 0
                orderby st.FirstName
                select st;

            return result.ToArray();
        }
        // Problem 4. Age range
        public static Student[] AgeArrange(Student[] input)
        {
            //var result = input.Where(st => st.Age >= 18 && st.Age <= 24);
            var result =
                from st in input
                where st.Age >= 18 && st.Age <= 24
                orderby st.Age
                select st;

            return result.ToArray();
        }
        // Problem 5. Order students
        public static Student[] DescendingOrder(Student[] input)
        {
            // var result = input.OrderByDescending(first => first.FirstName).ThenByDescending(last => last.LastName);
            var result =
                from st in input
                orderby st.FirstName descending, st.LastName descending
                select st;
                
            return result.ToArray();
        }

        public static void Print(Student[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("Full name: {0}", input[i].FirstName + " " + input[i].LastName);
                Console.WriteLine("Age: {0}", input[i].Age);
                Console.WriteLine();
            }
        }

        static void Main()
        {
            Student[] test = new Student[5];
            test[0] = new Student("Ivan", "Petrov", 18);
            test[1] = new Student("Georgi", "Asenov", 22);
            test[2] = new Student("Georgi", "Georgiev", 31);
            test[3] = new Student("Angel", "Kostov", 19);
            test[4] = new Student("Valeri", "Vasilev", 27);

            Student[] alphabeticalFilter = AlphabeticalArrange(test);
            Console.WriteLine("Students, filtered by first name before last name alphabetically: ");
            Console.WriteLine(new string('-', 65));
            Print(alphabeticalFilter);

            Console.WriteLine();
            Student[] ageFilter = AgeArrange(test);
            Console.WriteLine("Students, filtered by Age: ");
            Console.WriteLine(new string('-', 65));
            Print(ageFilter);

            Console.WriteLine();
            Student[] descendingOrderFilter = DescendingOrder(test);
            Console.WriteLine("Students, filtered by first and last name in descending order: ");
            Console.WriteLine(new string('-', 65));
            Print(descendingOrderFilter);
        }
    }
}
