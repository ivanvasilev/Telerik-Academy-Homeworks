// Problem 18.* Trailing Zeroes in N!
// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
// Your program should work well for very big numbers, e.g. n=100000.

using System;

class TrailingZerosInNFactorial
{
    static void Main()
    {
        Console.WriteLine("This program calculates how many zaros has a factorial of a given positive integer number at it's end.");
        Console.Write("Please enter a positive integer number: ");
        int input = int.Parse(Console.ReadLine());
        int num = input;
        int sum = 0;
        int power = 5;
        
        do
        {
            sum += (input / 5);
        } while (power < 5);
       
        Console.WriteLine("{0}! has exactly {1} zeros at it's end.", num, sum);
    }
}
