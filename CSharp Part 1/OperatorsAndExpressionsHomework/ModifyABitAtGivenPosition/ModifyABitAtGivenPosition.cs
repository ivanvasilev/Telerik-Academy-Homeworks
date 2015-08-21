// Problem 14. Modify a Bit at Given Position
// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
// at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("This program changes the value of given bit in a given integer with value 0 or 1, while preserving all other bits.");
        Console.Write("Please write an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please write the position of the bit you want to extract: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please write the bit value you want: ");
        int v = int.Parse(Console.ReadLine());
        int mask = ~(1 << p);
        int nAndMask = mask & n;
        int anotherMask = v << p;
        int result = nAndMask + anotherMask;
        Console.WriteLine("Result: " + result);
    }
}