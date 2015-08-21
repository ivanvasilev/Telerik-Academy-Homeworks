// Problem 1. Numbers from 1 to N
// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n,
// on a single line, separated by a space.

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        int counter = 1;

        if (inputNumber <= 0)
        {
            Console.WriteLine("Invalid number.\nPlease start the program again and enter another number.");
        }
        else
        {
            while (counter <= inputNumber)
            {
                Console.Write(counter + " ");
                counter++;
            }
            Console.WriteLine();
        }
    }
}