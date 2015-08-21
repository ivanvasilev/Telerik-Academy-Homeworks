// Problem 19. Dates from text in Canada
// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

class DatesFromTextInCanada
{
    static void Main()
    {
        Console.WriteLine("This program extracts from a given text all dates that match the format DD.MM.YYYY" +
                          " and prints them in the standard date format for Canada.");
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        string format = "d.M.yyyy";

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        CultureInfo provider = Thread.CurrentThread.CurrentCulture;
        
        foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
        {
            try
            {
                DateTime check = DateTime.ParseExact(match.ToString(), format, provider);
                Console.WriteLine("Result: {0}", check.ToShortDateString());
            }
            catch (FormatException)
            {
                continue;
            }
        }
    }
}