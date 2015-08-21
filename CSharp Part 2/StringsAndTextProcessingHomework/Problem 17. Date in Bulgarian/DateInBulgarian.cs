// Problem 17. Date in Bulgarian
// Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
// and prints the date and time after 6 hours and 30 minutes (in the same format) 
// along with the day of week in Bulgarian.

using System;
using System.Text;

class DateInBulgarian
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("This program reads a date and time given in the format: " +
                          "day.month.year hour:minute:second from the console and prints" +
                          " the date and time after 6 hours and 30 minutes (in the same format) " +
                          "along with the day of week in Bulgarian.");
        Console.Write("Please enter thе date and time: ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        DateTime result = inputDate.AddHours(6).AddMinutes(30);
        string resultText = "After 6 hours and 30 minutes the exact date and time of the input date would be: ";
        switch (result.DayOfWeek)
        {
            case DayOfWeek.Monday: Console.Write(resultText + "Понеделник, ");
                break;
            case DayOfWeek.Tuesday: Console.Write(resultText + "Вторник, ");
                break;
            case DayOfWeek.Wednesday: Console.Write(resultText + "Сряда, ");
                break;
            case DayOfWeek.Thursday: Console.Write(resultText + "Четвъртък, ");
                break;
            case DayOfWeek.Friday: Console.Write(resultText + "Петък, ");
                break;
            case DayOfWeek.Saturday: Console.Write(resultText + "Събота, ");
                break;
            case DayOfWeek.Sunday: Console.Write(resultText + "Неделя, ");
                break;
        }
        Console.WriteLine("{0:d.MM.yyyy hh:mm:ss}", result);
    }
}