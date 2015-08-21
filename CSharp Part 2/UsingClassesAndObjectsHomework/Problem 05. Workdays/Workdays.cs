// Problem 5. Workdays
// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday 
// except a fixed list of public holidays specified preliminary as array.

using System;

class Workdays
{
    static void Main()
    {
        Console.WriteLine("This program calculates the number of workdays between today and a future given " +
            "date from this year, where workdays are all from Monday to Friday, except public holidays.");
        string[] holidays = { "2015 ,1, 1", "2015, 1, 2", "2015, 3, 2", "2015, 3, 3", "2015, 4, 10", 
                              "2015, 4, 13", "2015, 5, 1", "2015, 5, 6", "2015, 5, 24", "2015, 9, 6", 
                              "2015, 9, 21", "2015, 9, 22", "2015, 12, 24", "2015, 12, 25", "2015, 12, 31" };
        DateTime firstDate = DateTime.Today;
        Console.Write("Please enter date from today till 31.12.2015 in format (dd.MM.yyyy): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        int counterForWorkdays = 0;
        DateTime currentDate = firstDate;;

        while (currentDate <= secondDate)
	{
        if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday &&
           currentDate != DateTime.Parse(holidays[0]) && currentDate != DateTime.Parse(holidays[1]) &&
           currentDate != DateTime.Parse(holidays[2]) && currentDate != DateTime.Parse(holidays[3]) &&
           currentDate != DateTime.Parse(holidays[4]) && currentDate != DateTime.Parse(holidays[5]) &&
           currentDate != DateTime.Parse(holidays[6]) && currentDate != DateTime.Parse(holidays[7]) &&
           currentDate != DateTime.Parse(holidays[8]) && currentDate != DateTime.Parse(holidays[9]) &&
           currentDate != DateTime.Parse(holidays[10]) && currentDate != DateTime.Parse(holidays[11]) &&
           currentDate != DateTime.Parse(holidays[12]) && currentDate != DateTime.Parse(holidays[13]) &&
           currentDate != DateTime.Parse(holidays[14]))
        {
            counterForWorkdays++;
        }
        currentDate = currentDate.AddDays(1);
	}
        Console.WriteLine("There are {0} workdays between {1:dd.MM.yyyy} and {2:dd.MM.yyyy}", counterForWorkdays, firstDate, secondDate);
    }
}