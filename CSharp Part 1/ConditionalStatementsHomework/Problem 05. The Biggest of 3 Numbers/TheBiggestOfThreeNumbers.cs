// Problem 5. The Biggest of 3 Numbers
// Write a program that finds the biggest of three numbers.

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("This program compares three given numbers and prints the greatest of them.");
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        string resultText = "The greatest of the three numbers is: ";
        double greatestNumber;

        if (firstNumber > secondNumber)
        {
            greatestNumber = firstNumber;
        }
        else
        {
            greatestNumber = secondNumber;
        }

        if (greatestNumber > thirdNumber)
        {
            Console.WriteLine(resultText + greatestNumber);
        }
        else
        {
            Console.WriteLine(resultText + thirdNumber);
        }
    }
}