// Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
// Write a program that, for a given two integer numbers n and x, calculates the sum 
// S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class CalculateAProblem
{
    static void Main()
    {
        Console.WriteLine("This program calculates of S = 1 + 1!/x + 2!/x2 + ... + n!/x^n by two given integer numbers for n and x.");
        Console.Write("Please enter integer value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter integer value for x: ");
        int x = int.Parse(Console.ReadLine());
        
        double sum = 1.00;
        double xAtPowerN = 1.00;
        double factorial = 1.00;

        for (int i = 1; i <= n; i++)
        {
            xAtPowerN *= x;
            factorial *= i;
            sum += (factorial / xAtPowerN);
        }
        Console.WriteLine("The solution of the problem with x = {0} and n = {1} is: {2:F5}", x, n, sum);
    }
}