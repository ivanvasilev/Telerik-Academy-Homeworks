// Problem 4. Number Comparer
// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

using System;
using System.Globalization;
using System.Threading;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("This program compares two given numbers and prints the greater of them.");
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        double result = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater of the two numbers is: " + result);
    }
}