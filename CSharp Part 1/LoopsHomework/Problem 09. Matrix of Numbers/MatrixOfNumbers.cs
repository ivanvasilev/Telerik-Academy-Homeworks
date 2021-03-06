﻿// Problem 9. Matrix of Numbers
// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix
// like in the examples below. Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Please enter positive integer number N, where 1 <= n <= 20: ");
        int inputNumber = int.Parse(Console.ReadLine());
        int counter = 1;

        if (1 <= inputNumber && inputNumber <= 20)
        {
            for (int row = 1; row <= inputNumber; row++)
            {
                for (int col = 0; col < inputNumber; col++)
                {
                    Console.Write("{0,2} ", row + col);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid number!\nPlease start the program again and enter new number.");
        }
    }
}