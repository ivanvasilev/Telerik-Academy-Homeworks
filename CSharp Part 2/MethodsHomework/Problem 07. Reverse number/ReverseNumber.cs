// Problem 7. Reverse number
// Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("This program reverses the digits of given decimal number.");
        Console.Write("Please enter a decimal number: ");
        string number = Console.ReadLine();

        ReversedNumber(number);
    }

    static void ReversedNumber(string number)
    {
        Console.Write("Result: ");
        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }
        Console.WriteLine();
    }
}