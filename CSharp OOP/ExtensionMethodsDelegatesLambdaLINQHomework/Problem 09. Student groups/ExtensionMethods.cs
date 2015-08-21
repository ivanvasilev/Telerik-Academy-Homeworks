// Problem 10. Student groups extensions
//     Implement Problem 9 using the same query expressed with extension methods.
// Problem 19. Grouped by GroupName extensions
//     Rewrite the previous using extension methods

namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionMethods
    {
        // Problem 10. Student groups extensions
        public static List<Student> StudentsFromSecondGroup(this List<Student> students)
        {
            var result =
                from st in students
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;
            return result.ToList();
        }

        public static List<Student> StudentsWithTwoMarks(this List<Student> students)
        {
            var result =
                from st in students
                where st.Marks.Count == 2
                select st;
            return result.ToList();
        }
        // Problem 19. Grouped by GroupName extensions
        public static void StudentsFromDifferentGroups(this List<Student> students)
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
    }
}
