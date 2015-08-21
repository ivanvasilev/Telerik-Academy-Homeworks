// Problem 11. Bitwise: Extract Bit #3
// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//  The bits are counted from right to left, starting from bit #0.
//  The result of the expression should be either 1 or 0.

using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.WriteLine("This program shows the value of the third bit of a given unsigned integer.");
        Console.Write("Please write an integer: ");
        int inputNumber = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = 1 << position;
        int inputNumberAndMask = inputNumber & mask;
        int bit = inputNumberAndMask >> position;
        Console.WriteLine("The value of bit #3 is: " + bit);
    }
}

