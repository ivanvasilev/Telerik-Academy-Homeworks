// Problem 9.Student groups
//     Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//     Create a List<Student> with sample students. Select only the students that are from group number 2.
//     Use LINQ query. Order the students by FirstName.
// Problem 11. Extract students by email
//     Extract all students that have email in abv.bg.
//     Use string methods and LINQ.
// Problem 12. Extract students by phone
//     Extract all students with phones in Sofia.
//     Use LINQ.
// Problem 13. Extract students by marks
//     Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
//     Use LINQ.
// Problem 14. Extract students with two marks
//     Write down a similar program that extracts the students with exactly two marks "2".
//     Use extension methods.
// Problem 15. Extract marks
//     Extract all Marks of the students that enrolled in 2006. 
//     (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
// Problem 16.* Groups
//     Create a class Group with properties GroupNumber and DepartmentName.
//     Introduce a property GroupNumber in the Student class.
//     Extract all students from "Mathematics" department.
// Problem 18. Grouped by GroupNumber
//     Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
//     Use LINQ.


namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ProgramTest
    {
        // Problem 9.Student groups
        public static List<Student> FilterForSecondGroup(List<Student> students)
        {
            var result =
                from st in students
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;
            return result.ToList();
        }
        // Problem 11. Extract students by email
        public static List<Student> FilterForAbvEmails(List<Student> students)
        {
            var result = 
                from st in students
                where st.Email.Substring(st.Email.IndexOf('@'), st.Email.Length - st.Email.IndexOf('@')) == "@abv.bg"
                select st;
            return result.ToList();
        }
        // Problem 12.Extract students by phone
        public static List<Student> FilterForPhoneNumbersInSofia(List<Student> students)
        {
            var result =
                from st in students
                where st.Tel.Substring(0, 2) == "02"
                select st;
            return result.ToList();
        }
        // Problem 13.Extract students by marks
        public static void FilterForMarkExcellent(List<Student> students)
        {
            var result =
                from st in students
                where st.Marks.Contains(6)
                select new {FullName = st.FirstName + " " + st.LastName, Marks = st.Marks};

            foreach (var student in result)
            {
                Console.WriteLine("Full Name: " + student.FullName);
                Console.WriteLine("Marks: " + string.Join(", ", student.Marks));
                Console.WriteLine();
            }
        }
        // Problem 14. Extract students with two marks
        public static void FilterForStudentsWithTwoMarks(List<Student> students)
        {
            List<Student> sorted = students.StudentsWithTwoMarks();

            foreach (var student in sorted)
            {
                Console.WriteLine("Full Name: " + student.ToString());
                Console.WriteLine("Marks: " + string.Join(", ", student.Marks));
                Console.WriteLine();
            }
        }
        // Problem 15. Extract marks from students that enrolled in 2006
        public static void FilterForStudentsFrom2006(List<Student> students)
        {
            var result =
                from st in students
                where st.FN.Substring(4, 2) == "06"
                select new { Marks = st.Marks };

            foreach (var student in result)
            {
                Console.WriteLine("Marks: " + string.Join(", ", student.Marks));
                Console.WriteLine();
            }
        }
        // Problem 16.* Groups
        public static List<Student> FilterForStudentsInDepartmentMathematics(List<Student> students, List<Group> groups)
        {
            var result =
                from st in students
                join gr in groups on st.GroupNumber equals gr.GroupNumber
                where st.GroupNumber == 2
                select st;
            return result.ToList();
        }
        // Problem 18. Grouped by GroupNumber
        public static void FilterForStudentsInGroups(List<Student> students)
        {
            var result =
                from st in students
                orderby st.GroupNumber
                group st by st.GroupNumber;

            foreach (var group in result)
            {
                Console.WriteLine("GROUP " + group.Key);
                Console.WriteLine(new string('-', 7));
                foreach (var student in group)
                {
                    Console.WriteLine("Full name: " + student.FirstName + " " + student.LastName);
                    Console.WriteLine("FN: " + student.FN);
                    Console.WriteLine("Tel: " + student.Tel);
                    Console.WriteLine("Email: " + student.Email);
                    Console.WriteLine("Marks: " + string.Join(", ", student.Marks.ToArray()));
                    Console.WriteLine("Group number: " + student.GroupNumber);
                    Console.WriteLine();
                }
            }
        }

        public static void Print(List<Student> input)
        {
            foreach (var student in input)
            {
                Console.WriteLine("Full name: " + student.FirstName + " " + student.LastName);
                Console.WriteLine("FN: " + student.FN);
                Console.WriteLine("Tel: " + student.Tel);
                Console.WriteLine("Email: " + student.Email);
                Console.WriteLine("Marks: " + string.Join(", ", student.Marks.ToArray()));
                Console.WriteLine("Group number: " + student.GroupNumber);
                Console.WriteLine();
            }
        }

        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Asen", "Ivanov", "4645232", "028812345", "asen@mail.bg", new List<int> { 3, 5, 6, 6, 6, 5, 3, 5 }, 2));
            students.Add(new Student("George", "Vasilev", "2135987", "032936245", "george@abv.bg", new List<int> { 2, 3, 5, 4, 4, 6, 5 }, 3));
            students.Add(new Student("Kamen", "Pavlov", "78670637", "0898452890", "kamen@yahoo.bg", new List<int> { 4, 6 }, 2));
            students.Add(new Student("Ivan", "Zhekov", "5748068", "0878590518", "ivan@gmail.bg", new List<int> { 2, 4, 4, 5 }, 1));
            students.Add(new Student("Valentin", "Panov", "6284068", "027928513", "valentin@abv.bg", new List<int> { 3, 4, 4, 3, 5, 4, 5 }, 5));
            // LINQ query test
            List<Student> groupNumberFilter = FilterForSecondGroup(students);
            Console.WriteLine("EXTRACT STUDENTS FROM GROUP 2, USING LINQ QUERIES: ");
            Console.WriteLine(new string('-', 70));
            Print(groupNumberFilter);
            // LINQ query in extension test
            List<Student> secondGroupExt = students.StudentsFromSecondGroup();
            Console.WriteLine("EXTRACT STUDENTS FROM GROUP 2, USING EXTENSION METHOD: ");
            Console.WriteLine(new string('-', 70));
            Print(secondGroupExt);

            List<Student> abvEmailFilter = FilterForAbvEmails(students);
            Console.WriteLine("EXTRACT STUDENTS WITH EMAILS IN ABV: ");
            Console.WriteLine(new string('-', 70));
            Print(abvEmailFilter);

            List<Student> phoneNumberFilter = FilterForPhoneNumbersInSofia(students);
            Console.WriteLine("EXTRACT STUDENTS WITH PHONES IN SOFIA:");
            Console.WriteLine(new string('-', 70));
            Print(phoneNumberFilter);

            Console.WriteLine("EXTRACT STUDENTS WITH AT LEAST ONE EXCELLENT GRADE: ");
            Console.WriteLine(new string('-', 70));
            FilterForMarkExcellent(students);

            Console.WriteLine("EXTRACT STUDENTS WITH EXACTLY TWO MARKS: ");
            Console.WriteLine(new string('-', 70));
            FilterForStudentsWithTwoMarks(students);

            Console.WriteLine("EXTRACT MARKS OF THE STUDENTS THAT ENROLLED IN 2006: ");
            Console.WriteLine(new string('-', 70));
            FilterForStudentsFrom2006(students);

            List<Group> groups = new List<Group>();
            groups.Add(new Group(1, "Law"));
            groups.Add(new Group(2, "Mathematics"));
            groups.Add(new Group(3, "Economy"));
            groups.Add(new Group(4, "International Business"));
            groups.Add(new Group(5, "IT"));

            List<Student> mathematicsDepartmentFilter = FilterForStudentsInDepartmentMathematics(students, groups);
            Console.WriteLine("EXTRACT STUDENTS IN DEPARTMENT MATHEMATICS: ");
            Console.WriteLine(new string('-', 70));
            Print(mathematicsDepartmentFilter);

            Console.WriteLine("EXTRACT DIFFERENT GROUPS AND STUDENTS IN THEM, USING LINQ QUERIES: ");
            Console.WriteLine(new string('-', 70));
            FilterForStudentsInGroups(students);

            Console.WriteLine("EXTRACT DIFFERENT GROUPS AND STUDENTS IN THEM, USING EXTENSION METHOD: ");
            Console.WriteLine(new string('-', 70));
            students.StudentsFromDifferentGroups();
        }
    }
}
