// Problem 1. Odd or Even Integers
// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("This program checks if given number is odd or even.");
        Console.Write("Please enter an integer: ");
        string inputNumber = Console.ReadLine();
        int someNumber = int.Parse(inputNumber);
        if (someNumber % 2 == 0)
        {
            Console.WriteLine("Is the number odd: {0}", false);
        }
        else 
            Console.WriteLine("Is the number odd: {0}", true);
    }
}

