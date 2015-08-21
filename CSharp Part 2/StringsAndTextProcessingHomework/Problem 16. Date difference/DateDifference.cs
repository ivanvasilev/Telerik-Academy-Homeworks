// Problem 16. Date difference
// Write a program that reads two dates in the format: day.month.year 
// and calculates the number of days between them.

using System;

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("This program reads two dates in the format: day.month.year from the console " +
                          "and calculates the number of days between them.");
        Console.Write("Please enter the first date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Please enter the second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        int dayCounter = 0;
        while (firstDate < secondDate)
        {
            dayCounter++;
            firstDate = firstDate.AddDays(1);
        }
        Console.WriteLine("Distance: {0} days", dayCounter);
    }
}