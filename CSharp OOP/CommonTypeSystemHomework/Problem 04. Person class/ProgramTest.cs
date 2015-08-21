// Problem 4. Person class
    // Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value). 
    // Override ToString() to display the information of a person and if age is not specified – to say so.
    // Write a program to test this functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class ProgramTest
    {
        static void Main()
        {
            Console.WriteLine("Person with defined only name: ");
            Console.WriteLine(new string('-', 30));
            Person firstPerson = new Person("Ivan Ivanov");
            Console.WriteLine(firstPerson);
            Console.WriteLine();
            Console.WriteLine("Person with defined name and age: ");
            Console.WriteLine(new string('-', 33));
            Person secondPerson = new Person("Stefaniya Stefanova", 25);
            Console.WriteLine(secondPerson);
        }
    }
}
