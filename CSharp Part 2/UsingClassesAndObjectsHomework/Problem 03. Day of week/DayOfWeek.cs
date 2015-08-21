// Problem 3. Day of week
// Write a program that prints to the console which day of the week is today.
// Use System.DateTime.

using System;

class DayOfWeek
{
    static void Main()
    {
        Console.WriteLine("This program prints which day of the week is today.");
        DateTime today = DateTime.Today;
        Console.WriteLine("Today is: {0}", today.DayOfWeek);
    }
}