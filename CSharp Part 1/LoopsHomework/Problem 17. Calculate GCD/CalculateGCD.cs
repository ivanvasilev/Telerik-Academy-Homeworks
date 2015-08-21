// Problem 17.* Calculate GCD
// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
// Use the Euclidean algorithm (find it in Internet).

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("This program calculates the GCD of two given integers.");
        Console.Write("Please enter the first positive integer number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second positive integer number: ");
        int b = int.Parse(Console.ReadLine());

        int tempA = a;
        int tempB = b;
        if (a <= 0 || b <= 0)
        {
            Console.WriteLine("Invalid numbers!\nPlease start the program again and enter new numbers.");
        }
        else
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine("The greatest common divisor of {0} and {1} is: {2}", tempA, tempB, Math.Max(a, b));
        }
        
    }
}