// Problem 1. Exchange If Greater
// Write an if-statement that takes two double variables a and b and exchanges their values 
// if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program prints two given numbers and arranges them from greater to lower.");
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (secondNumber > firstNumber)
        {
            double buffer = firstNumber;
            firstNumber = secondNumber;
            secondNumber = buffer;
        }
        Console.Write("Result: " + firstNumber + " ");
        Console.WriteLine(secondNumber);
    }
}