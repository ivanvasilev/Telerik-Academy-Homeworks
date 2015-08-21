// Problem 4. Hexadecimal to decimal
// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("This program converts hexadecimal numbers to their decimal representation.");
        Console.Write("Please enter a hexadecimal representation of an integer number: ");
        string hex = Console.ReadLine();

        ConvertNumberFromHexToDec(hex);
    }

    static void ConvertNumberFromHexToDec(string number)
    {
        long newNumber = 0;
        long power = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            int sign;
            switch (number[i])
            {
                case 'A': sign = 10;
                    break;
                case 'B': sign = 11;
                    break;
                case 'C': sign = 12;
                    break;
                case 'D': sign = 13;
                    break;
                case 'E': sign = 14;
                    break;
                case 'F': sign = 15;
                    break;
                default: sign = number[i] - 48;
                    break;
            }
            newNumber += sign * power;
            power *= 16;
        }
        Console.WriteLine("The decimal representation of {0} is: {1}", number, newNumber);
    }
}