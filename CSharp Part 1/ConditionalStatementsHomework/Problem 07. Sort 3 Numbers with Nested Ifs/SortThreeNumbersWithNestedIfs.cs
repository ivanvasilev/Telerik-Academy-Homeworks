// Problem 7. Sort 3 Numbers with Nested Ifs
// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.

using System;
using System.Globalization;
using System.Threading;

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("This program compares three given numbers and prints them in descending order.");
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        string resultText = "The numbers in descending order are: {0} {1} {2}";


        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine(resultText, firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine(resultText, firstNumber, thirdNumber, secondNumber);
            }
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine(resultText, secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine(resultText, secondNumber, thirdNumber, firstNumber);
            }
        }
        else
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(resultText, thirdNumber, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine(resultText, thirdNumber, secondNumber, firstNumber);
            }
        }
    }
}
