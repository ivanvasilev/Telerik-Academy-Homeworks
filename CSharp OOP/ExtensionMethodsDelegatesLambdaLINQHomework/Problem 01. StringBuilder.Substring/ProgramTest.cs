//Problem 1. StringBuilder.Substring
//    Implement an extension method Substring(int index, int length) for the class StringBuilder 
//    that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace StringBuilderExtensions
{
    using System;
    using System.Text;

    class ProgramTest
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("This is the test for the substring extension!");

            Console.WriteLine("Taking a substring from text with given index and length: " + test.Substring(12, 4));
            Console.WriteLine("Taking a substring from text with given only index: " + test.Substring(12));
        }
    }
}
