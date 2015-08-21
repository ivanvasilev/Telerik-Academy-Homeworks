// Problem 14. Decimal to Binary Number
// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;
using System.Text;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        long dec = long.Parse(Console.ReadLine());
        
        long remainder;
        long temp = dec;
        StringBuilder binary = new StringBuilder();
        
        while (temp > 0)
        {
            int index = 0;
            remainder = temp % 2;
            binary.Insert(index, remainder);
            temp /= 2;
            index++;
        }
        Console.WriteLine("The binary representation of {0} is: {1}", dec, binary);
    }
}