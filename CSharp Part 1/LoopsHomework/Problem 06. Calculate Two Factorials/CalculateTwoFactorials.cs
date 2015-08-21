// Problem 6. Calculate N! / K!
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

using System;
using System.Numerics;

class CalculateTwoFactorials
{
    static void Main()
    {
        Console.WriteLine("This program calculates N! / K!");
        Console.Write("Please enter integer value for n, where 1 < k < n < 100: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter integer value for k, where 1 < k < n < 100: ");
        int k = int.Parse(Console.ReadLine());
        
        BigInteger result = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("The result of the division is: " + result);
        }
        else
        {
            Console.WriteLine("Invalid numbers!\nPlease start the program again and enter new numbers, where n > k.");
        }
    }
}