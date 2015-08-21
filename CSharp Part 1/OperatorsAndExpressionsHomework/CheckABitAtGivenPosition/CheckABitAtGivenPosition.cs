// Problem 13. Check a Bit at Given Position
// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
// in given integer number n, has value of 1.

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("This program extracts from given integer the value of a given bit position and tells if the bit is a 1.");
        Console.Write("Please write an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please write the position of the bit you want to extract: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        bool result = bit == 1;
        Console.WriteLine("Is the value of the bit a 1: " + result);
    }
}