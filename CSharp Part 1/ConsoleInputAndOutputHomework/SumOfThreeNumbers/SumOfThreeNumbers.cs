// Problem 1. Sum of 3 Numbers
// Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Globalization;
using System.Threading;

class SumOfThreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program gives the sum of three numbers.");
        Console.WriteLine("Please write the numbers:");
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of the three numbers is: {0}", sum);
    }
}