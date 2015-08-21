// Problem 2. Numbers Not Divisible by 3 and 7
// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n 
// not divisible by 3 and 7, on a single line, separated by a space.

using System;

class NumbersNotDivisibleByThreeAndSeven
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
            Console.Write("The numbers between 1 and {0}, which are not divisible by 3 and 7 are: ", inputNumber);
            while (counter <= inputNumber)
            {
                if (counter % 3 != 0 && counter % 7 != 0)
                {
                    Console.Write(counter + " ");
                }
                counter++;
            }
            Console.WriteLine();
        }
    }
}