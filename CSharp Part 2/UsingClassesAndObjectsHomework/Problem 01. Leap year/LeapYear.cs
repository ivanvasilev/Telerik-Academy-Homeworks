// Problem 1. Leap year
// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime.

using System;

    class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("This program reads a year from the console and checks whether it is a leap one.");
            Console.Write("Please enter a year in the range [1, 9999]: ");
            int year = int.Parse(Console.ReadLine());
            
            if (year < 1 || year > 9999)
            {
                Console.WriteLine("Invalid year!\nYear must be between 1 and 9999.");
                return;
            }
            
            CheckIfYearIsLeap(year);
        }

        static void CheckIfYearIsLeap(int year)
        {
            if (DateTime.IsLeapYear(year) == true)
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("Result: {0} is not a leap year.", year);
            }
        }
    }