// Problem 1. Decimal to binary
// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("This program converts decimal numbers to their binary representation.");
        Console.Write("Please enter an integer number: ");
        long dec = long.Parse(Console.ReadLine());

        ConvertNumber(dec);
    }

    static void ConvertNumber(long number)
    {
        long remainder;
        long temp = number;
        StringBuilder binary = new StringBuilder();

        while (temp > 0)
        {
            int index = 0;
            remainder = temp % 2;
            binary.Insert(index, remainder);
            temp /= 2;
            index++;
        }
        Console.WriteLine("The binary representation of {0} is: {1}", number, binary);
    }
}