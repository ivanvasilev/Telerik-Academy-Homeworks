// Problem 2. Binary to decimal
// Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts binary numbers to their decimal representation.");
        Console.Write("Please enter a binary representation of an integer number: ");
        string binary = Console.ReadLine();

        ConvertNumber(binary);
    }

    static void ConvertNumber(string number)
    {
        long newNumber = 0;
        int power = 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int sign = number[i] - '0';
            if (sign == 1)
            {
                newNumber += sign * power;
            }
            power *= 2;
        }
        Console.WriteLine("The decimal representation of {0} is: {1}", number, newNumber);
    }
}