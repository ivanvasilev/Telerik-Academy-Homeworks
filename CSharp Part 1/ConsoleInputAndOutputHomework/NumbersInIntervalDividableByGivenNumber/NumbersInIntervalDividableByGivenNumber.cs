// Problem 11.* Numbers in Interval Dividable by Given Number
// Write a program that reads two positive integer numbers and prints how many numbers p exist
// between them such that the reminder of the division by 5 is 0.

using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("This program prints how many numbers exist between two given numbers, " + 
            "which have no remainder when divided by 5.");
        Console.Write("Please enter the first integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            int buffer = firstNumber;
            firstNumber = secondNumber;
            secondNumber = buffer;
        }

        int count = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("There are exactly {0} numbers between {1} and {2} which can be divided by 5 without remainder.", count, firstNumber, secondNumber);
    }
}