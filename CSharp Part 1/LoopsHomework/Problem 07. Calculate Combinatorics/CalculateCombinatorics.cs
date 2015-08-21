// Problem 7. Calculate N! / (K! * (N-K)!)
// In combinatorics, the number of ways to choose k different members out of a group of n different elements 
// (also known as the number of combinations) is calculated by the following formula: N! / (K! * (N-K)!) 
// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
// Try to use only two loops.

using System;
using System.Numerics;

class CalculateCombinatorics
{
    static void Main()
    {
        Console.WriteLine("This program calculates N! / (K! * (N-K)!");
        Console.Write("Please enter integer value for n, where 1 < k < n < 100: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter integer value for n, where 1 < k < n < 100: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger result = 1;
        BigInteger secondResult = 1;
        int newNumber = n - k;

        if (1 < k && k < n && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }

            for (int i = 1; i <= newNumber; i++)
			{
			    secondResult *= i; 
			}
            Console.WriteLine(result / secondResult);
        }
        else
        {
            Console.WriteLine("Invalid numbers!\nPlease start the program again and enter new numbers, where n > k.");
        }
    }
}