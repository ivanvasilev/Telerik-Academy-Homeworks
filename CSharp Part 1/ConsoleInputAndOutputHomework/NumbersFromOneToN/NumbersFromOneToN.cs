// Problem 8. Numbers from 1 to n
// Write a program that reads an integer number n from the console
// and prints all the numbers in the interval [1..n], each on a single line.

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("This program reads an integer from the console and print all the numbers " + 
            "in the interval [1..n], each on a single line.");
        Console.Write("Please enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid number\nPlease start the program again and enter a new number.");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}