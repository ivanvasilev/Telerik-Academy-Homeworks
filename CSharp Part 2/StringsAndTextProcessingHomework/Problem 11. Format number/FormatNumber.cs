// Problem 11. Format number
// Write a program that reads a number and prints it as a decimal number, hexadecimal number,
// percentage and in scientific notation.
// Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("This program reeds a number from the console and prints it as a decimal number, " +
                          "hexadecimal number, percentage and in scientific notation.");
        Console.Write("Please enter an integer: ");
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine("Number as a decimal number      : {0, 15:F2}", n);
        Console.WriteLine("Number as a hexadecimal number  : {0, 15:X}", n);
        Console.WriteLine("Number as a percentage          : {0, 15:P}", n);
        Console.WriteLine("Number as a scientific notation : {0, 15:E}", n);
    }
}