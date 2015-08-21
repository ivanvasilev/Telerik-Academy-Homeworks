// Problem 15.* Bits Exchange
// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("This program exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of a given integer.");
        Console.Write("Enter an integer: ");
        long inputNumber = long.Parse(Console.ReadLine());
        
        Console.WriteLine("Your number: " + inputNumber);
        string inputNumberInBinary = Convert.ToString(inputNumber, 2).PadLeft(32, '0');
        Console.WriteLine("The binary representation of your number   : " + inputNumberInBinary);
        
        long mask = 7; // 0111
        long firstBits = (inputNumber & (mask << 3)) >> 3; // Takes bits 3, 4 and 5 and puts them in the beginning
        long secondBits = (inputNumber & (mask << 24)) >> 24; // Takes bits 24, 25 and 26 and puts them in the beginning
        
        inputNumber = inputNumber & ~(mask << 3); // Makes bits 3, 4 and 5 to be equal to 0
        inputNumber = inputNumber & ~(mask << 24); // Makes bits 24, 25 and 26 to be equal to 0
        inputNumber = inputNumber | (firstBits << 24); // Takes the values of bits 3, 4 and 5 and puts them in bits 24, 25 and 26
        inputNumber = inputNumber | (secondBits << 3); // Takes the values of bits 24, 25 and 26 and puts them in bits 3, 4 and 5
        
        string newNumberInBinary = Convert.ToString(inputNumber, 2).PadLeft(32, '0');
        Console.WriteLine("The binary representation of the new number: " + newNumberInBinary);
        Console.WriteLine("New number : " + inputNumber);
    }
}