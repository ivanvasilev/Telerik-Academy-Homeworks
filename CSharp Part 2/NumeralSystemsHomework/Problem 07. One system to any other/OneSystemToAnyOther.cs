// Problem 7. One system to any other
// Write a program to convert from any numeral system of given base s 
// to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Text;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.WriteLine("This program converts a number from any numeral system of given base s " +
                          "to any other numeral system of base d (2 <= s, d <= 16).");
        Console.Write("Please enter from which numeral system you want to convert: ");
        int firstNumeralSystem = int.Parse(Console.ReadLine());
        if (firstNumeralSystem < 2 || firstNumeralSystem > 16)
        {
            Console.WriteLine("Invalid numeral system!\nNumeral system must be between 2 and 16.");
            return;
        }
        WhatNumbersToAdd(firstNumeralSystem);
        string number = Console.ReadLine();
        Console.Write("Please enter to which numeral system you want to convert: ");
        int secondNumeralSystem = int.Parse(Console.ReadLine());
        if (secondNumeralSystem < 2 || secondNumeralSystem > 16)
        {
            Console.WriteLine("Invalid numeral system!\nNumeral system must be between 2 and 16.");
            return;
        }

        ConvertToOther(number, ConvertNumberToDecimal(firstNumeralSystem, number), secondNumeralSystem);
    }

    static void WhatNumbersToAdd(int firstNumeralSystem)
    {
        switch (firstNumeralSystem)
        {
            case 2: Console.WriteLine("Please enter the number you want to convert, using 0 and 1: ");
                break;
            case 3: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 2: ");
                break;
            case 4: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 3: ");
                break;
            case 5: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 4: ");
                break;
            case 6: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 5: ");
                break;
            case 7: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 6: ");
                break;
            case 8: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 7: ");
                break;
            case 9: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 8: ");
                break;
            case 10: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 9: ");
                break;
            case 11: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 9 and the letter A: ");
                break;
            case 12: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 9 and the letters A and B: ");
                break;
            case 13: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 9 and the letters from A to C: ");
                break;
            case 14: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 9 and the letters from A to D: ");
                break;
            case 15: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 9 and the letters from A to E: ");
                break;
            case 16: Console.WriteLine("Please enter the number you want to convert, using the digits from 0 to 9 and the letters from A to F: ");
                break;
            default: return;
        }
    }

    static long ConvertNumberToDecimal(int numSystem, string number)
    {
        long newNumber = 0;
        int power = 1;
        int sign = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (number[i] >= 'A' && number[i] <= 'F')
            {
                sign = (number[i] - 'A') + 10;
            }
            else if (number[i] >= '0' && number[i] <= '9')
            {
                sign = number[i] - '0';
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            newNumber += sign * power;
            power *= numSystem;
        }
        return newNumber;
    }

    static void ConvertToOther(string inputNumber, long number, int system)
    {
        long remainder = 0;
        long temp = number;
        StringBuilder result = new StringBuilder();

        while (temp > 0)
        {
            int index = 0;
            remainder = temp % system;
            if (remainder >= 10 && remainder <= 15)
            {
                result.Insert(index, (char)(55 + remainder)); 
            }
            else
            {
                result.Insert(index, remainder);
            }
            temp /= system;
            index++;
        }
        Console.WriteLine("The converted representation of {0} is: {1}", inputNumber, result);
    }
}