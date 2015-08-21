// Problem 16. Decimal to Hexadecimal Number
// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;
using System.Text;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        long number = long.Parse(Console.ReadLine());

        long temp = number;
        StringBuilder binary = new StringBuilder();
        while (temp > 0)
        {
            int index = 0;
            char hexValue = '0';
            long remainder = temp % 16;
            if (remainder > 9)
            {
                switch (remainder)
                {
                    case 10: hexValue = 'A';
                        break;
                    case 11: hexValue = 'B';
                        break;
                    case 12: hexValue = 'C';
                        break;
                    case 13: hexValue = 'D';
                        break;
                    case 14: hexValue = 'E';
                        break;
                    case 15: hexValue = 'F';
                        break;
                    default: Console.WriteLine("Fail");
                        break;
                }
                binary.Insert(index, hexValue);
            }
            else
            {
                binary.Insert(index, remainder);
            }
            temp /= 16;
            index++;
        }
        Console.WriteLine("The hexadecimal representation of {0} is: {1}", number, binary);
    }
}