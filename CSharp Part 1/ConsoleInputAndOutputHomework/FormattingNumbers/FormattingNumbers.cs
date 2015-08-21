// Problem 5. Formatting Numbers
// Write a program that reads 3 numbers:
        // integer a (0 <= a <= 500)
        // floating-point b
        // floating-point c
// The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        // The number a should be printed in hexadecimal, left aligned
        // Then the number a should be printed in binary form, padded with zeroes
        // The number b should be printed with 2 digits after the decimal point, right aligned
        // The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program makes several different manipulations with 3 given numbers.");
        Console.Write("Please enter an integer between 0 and 500: ");
        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber < 0 || inputNumber > 500)
        {
            Console.WriteLine("Invalid number!\nPlease start the program again and enter a new number.");
        }
        else
        {
            Console.Write("Please enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            string inputNumberInHexadecimal = Convert.ToString(inputNumber, 16);
            string inputNumberInBinary = Convert.ToString(inputNumber, 2).PadLeft(10, '0');
            Console.WriteLine("|{0,-10}|{1,10}|{2,10:0.00}|{3,-10:F3}|", inputNumberInHexadecimal, inputNumberInBinary, secondNumber, thirdNumber);
        }
    }
}