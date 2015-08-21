// Problem 7. Sum of 5 Numbers
// Write a program that enters 5 numbers (given in a single line, separated by a space),
// calculates and prints their sum.

using System;
using System.Globalization;
using System.Threading;

class SumOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program calculates the sum of 5 numbers, when they are entered in the same line.");
        Console.Write("Please enter the numbers and separate them with space: ");
        string[] inputNumbers = Console.ReadLine().Split();

        double sum = 0.0;
        foreach (string number in inputNumbers)
        {
            double firstNumber = double.Parse(number);
            sum += firstNumber;
        }
        Console.WriteLine("The sum of the five numbers is: " + sum);
    }
}