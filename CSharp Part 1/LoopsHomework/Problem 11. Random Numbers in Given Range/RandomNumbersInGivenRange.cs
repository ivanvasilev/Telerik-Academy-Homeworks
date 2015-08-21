// Problem 11. Random Numbers in Given Range
// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers 
// in the range [min...max].

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter how many numbers You want the program to print: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter minimal value: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter maximal value: ");
        int max = int.Parse(Console.ReadLine());

        if (min > max)
        {
            int temp = min;
            min = max;
            max = min;
        }
        else if (min == max)
        {
            Console.WriteLine("Invalid min and max values!\nPlease start the program again and enter different values.");
        }

        Console.Write("Result: ");
        Random r = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", r.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}