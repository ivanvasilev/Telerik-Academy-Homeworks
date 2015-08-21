// Problem 1. Student class
    // Define a class Student, which contains data about a student – first, middle and last name, SSN, 
    // permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration 
    // for the specialties, universities and faculties.
    // Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
// Problem 2. ICloneable
    // Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields 
    // into a new object of type Student.
// Problem 3. IComparable
    // Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
    // and by social security number (as second criteria, in increasing order).                            

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClass.Enumerations;

namespace StudentClass
{
    class ProgramTest
    {
        static void Main()
        {
            Student firstStudent = new Student("Ivan", "Ivanov", "Ivanov", "8912123434", "bul. Bulgaria 1", "0888888888", "ivan@abv.bg", 4, Specialty.CST, Faculty.FKSU, University.TUSofiya);

            Student secondStudent = new Student("Stefaniya", "Stefanova", "Stefanova", "9011115757", "bul. Al.Malinov 1", "0888555555", "stefaniya@abv.bg", 3, Specialty.EngineerDesign, Faculty.MF, University.TUSofiya);

            Student thirdStudent = new Student("Stefaniya", "Stefanova", "Stefanova", "9011115757", "bul. Al.Malinov 1", "0888555555", "stefaniya@abv.bg", 3, Specialty.EngineerDesign, Faculty.MF, University.TUSofiya);
            
            // Testing the ToString() method
            Console.WriteLine("Testing the ToString() method:");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(firstStudent);
            Console.WriteLine(secondStudent);
            // Testing the GetHashCode() and Equals methods
            Console.WriteLine("Testing the GetHashCode() and Equals() methods:");
            Console.WriteLine(new string('-', 47));
            Console.WriteLine("Result of the Equals() method for the third and the second student: {0}", thirdStudent.Equals(secondStudent));
            Console.WriteLine("First student HashCode: " + firstStudent.GetHashCode());
            Console.WriteLine("Second student HashCode: " + secondStudent.GetHashCode());
            Console.WriteLine("Result of the Equals() method for the hashcodes of the first and the second student: " + firstStudent.GetHashCode().Equals(secondStudent.GetHashCode()));
            Console.WriteLine("Result of the Equals() method for the hashcodes of the third and the second student: " + thirdStudent.GetHashCode().Equals(secondStudent.GetHashCode()));
            Console.WriteLine();
            // Testing the == and != operators
            Console.WriteLine("Testing the == and != operators:");
            Console.WriteLine(new string('-', 32));
            Console.WriteLine("First student == Second student: {0}", firstStudent == secondStudent);
            Console.WriteLine("Second student == Third student: {0}", secondStudent == thirdStudent);
            Console.WriteLine("First student != Second student: {0}", firstStudent != secondStudent);
            Console.WriteLine("Second student != Third student: {0}", secondStudent != thirdStudent);
            Console.WriteLine();
            // Testing the Clone() method
            Console.WriteLine("Testing the Clone() method:");
            Console.WriteLine(new string('-', 27));
            Student copiedStudent = firstStudent.Clone() as Student;
            Console.WriteLine("First student clone == First student: {0}", copiedStudent == firstStudent);
            Console.WriteLine();
            // Testing the CompareTo() method
            Console.WriteLine("Testing the CompareTo() method:");
            Console.WriteLine(new string('-', 31));
            Console.WriteLine("First student compared to the second student: {0}", firstStudent.CompareTo(secondStudent));
            Console.WriteLine("Second student compared to the first student: {0}", secondStudent.CompareTo(firstStudent));
            Console.WriteLine("Cloned student compared to the first student: {0}", copiedStudent.CompareTo(firstStudent));


        }
    }
}
