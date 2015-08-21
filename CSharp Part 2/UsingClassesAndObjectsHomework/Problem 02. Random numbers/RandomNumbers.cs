// Problem 2. Random numbers
// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("This program generates and prints to the console " +
                          "10 random values in the range [100, 200].");
        
        PrintTenRandomNumbers();
    }

    static void PrintTenRandomNumbers()
    {
        Random randomNumber = new Random();
        Console.Write("Result: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(randomNumber.Next(100, 201));
            if (i != 9)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}