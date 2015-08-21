// Problem 8. Catalan Numbers
// In combinatorics, the Catalan numbers are calculated by the following formula: 
// Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100). 

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("This program calcilates Catalan numbers.");
        Console.Write("Please enter integer value for n, where 0 <= n <= 100: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 1;
        BigInteger secondResult = 1;
        BigInteger thirdResult = 1;
        int newNumber = 2 * n;
        int secondNewNumber = n + 1;

        if (0 <= n && n <= 100)
        {
            for (int i = 1; i <= newNumber; i++)
            {
                result *= i;
            }

            for (int i = 1; i <= secondNewNumber; i++)
            {
                secondResult *= i;
            }

            for (int i = 1; i <= n; i++)
            {
                thirdResult *= i;
            }
            BigInteger finalResult = (result / (secondResult * thirdResult));
            Console.WriteLine("The result is: " + finalResult);
        }
        else
        {
            Console.WriteLine("Invalid numbers!\nPlease start the program again and enter new numbers, where n > k.");
        }
    }
}