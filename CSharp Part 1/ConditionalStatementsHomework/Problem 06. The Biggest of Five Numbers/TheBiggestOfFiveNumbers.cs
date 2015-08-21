// Problem 6. The Biggest of Five Numbers
// Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfFiveNumbers
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
        Console.Write("Please enter the fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());
        string resultText = "The greatest of the five numbers is: ";
        double greaterNumber;
        double oneMoreGreaterNumber;
        double greatestNumber;

        if (firstNumber > secondNumber)
        {
            greaterNumber = firstNumber;
        }
        else
        {
            greaterNumber = secondNumber;
        }

        if (thirdNumber > fourthNumber)
        {
            oneMoreGreaterNumber = thirdNumber;
        }
        else
        {
            oneMoreGreaterNumber = fourthNumber;
        }

        if (greaterNumber > oneMoreGreaterNumber)
        {
            greatestNumber = greaterNumber;
        }
        else
        {
            greatestNumber = oneMoreGreaterNumber;
        }

        if (greatestNumber > fifthNumber)
        {
            Console.WriteLine(resultText + greatestNumber);
        }
        else
        {
            Console.WriteLine(resultText + fifthNumber);
        }
    }
}