// Problem 12. Extract Bit from Integer
// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("This proram extracts from given integer the value of a given bit position.");
        Console.Write("Please write an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please write the position of the bit you want to extract: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(bit);
    }
}