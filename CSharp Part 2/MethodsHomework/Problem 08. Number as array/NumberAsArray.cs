// Problem 8. Number as array
// Write a method that adds two positive integer numbers represented as arrays of digits 
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;


class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine("This program adds two positive integer numbers, " +
                          "which could have up to 10000 digits and prints their sum.");
        Console.Write("Please enter the first number: ");
        string firstNumber = Console.ReadLine();
        Console.Write("Please enter the second number: ");
        string secondNumber = Console.ReadLine();

        if (IsCorrectNumber(firstNumber) && IsCorrectNumber(secondNumber))
        {
            List<int> result = SumOfTheTwoNumbers(firstNumber, secondNumber);
            Console.Write("\nResult: ");
            PrintResult(result);
        }
        else
        {
            Console.WriteLine("\n-> You have entered invalid number(s)...\n");
        }
    }

    static bool IsCorrectNumber(string number)
    {
        return number.All(t => t >= '0' && t <= '9');
    } 

    static List<int> SumOfTheTwoNumbers(string first, string second)
    {
        var a = first.Select(ch => ch - '0').ToArray();
        var b = second.Select(ch => ch - '0').ToArray();

        Array.Reverse(a);
        Array.Reverse(b);

        List<int> result = new List<int>(Math.Max(a.Length, b.Length));
        int left = 0;
        for (int i = 0; i < result.Capacity; i++)
        {
            int num = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + left;
            left = num / 10;
            result.Add(num % 10);
        }
        result.Reverse();
        if (left > 0) result.Add(left);
        return result;
    }

    static void PrintResult(List<int> result)
    {
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine("\n");
    }
}
