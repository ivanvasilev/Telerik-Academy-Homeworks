//Problem 17. Longest string
//    Write a program to return the string with maximum length from an array of strings.
//    Use LINQ.

namespace LongestString
{
    using System;
    using System.Linq;

    class LongestStringInArray
    {
        public static string LongestString(string[] input)
        {
            string result = input.OrderByDescending(w => w.Length).First();
            return result;
        }

        static void Main()
        {
            string[] input = new string[] { "Monday", 
                                            "Tuesday", 
                                            "Wednesday", 
                                            "Thursday", 
                                            "Friday", 
                                            "Saturday",
                                            "Sunday" };
            Console.WriteLine("The longest word in the array is: {0}", LongestString(input));
        }
    }
}
