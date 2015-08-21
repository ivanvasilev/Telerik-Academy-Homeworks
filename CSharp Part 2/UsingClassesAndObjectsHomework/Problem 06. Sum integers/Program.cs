// Problem 6. Sum integers
// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("This program reads from the console a sequence of positive ineteger values, " +
                          "separated by space, and calculates their sum.");
        Console.Write("Please enter numbers, separated by space: ");
        string text = Console.ReadLine();
        string[] numbersAsText = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[numbersAsText.Length];
        long sum = 0;
        for (int i = 0; i < numbersAsText.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsText[i]);
            sum += numbers[i];
        }
        Console.WriteLine("The sum of the input numbers is: {0}", sum);
    }
}