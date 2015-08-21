// Problem 4. Multiplication Sign
// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    // Use a sequence of if operators.

using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program shows the sign of the product of three real numbers, without claculating it.");
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        double result = firstNumber * secondNumber * thirdNumber;
        string resultText = "The product is: ";

        if (result > 0)
        {
            Console.WriteLine(resultText + "+");
        }
        else if (result < 0)
        {
            Console.WriteLine(resultText + "-");
        }
        else
        {
            Console.WriteLine(resultText + "0");
        }
    }
}