// Problem 6. Four-Digit Number
// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        // Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        // Prints on the console the number in reversed order: dcba (in our example 1102).
        // Puts the last digit in the first position: dabc (in our example 1201).
        // Exchanges the second and the third digits: acbd (in our example 2101).
// The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("This program makes four manipulations with a given four-digit integer.");
        Console.Write("Please enter a four-digit integer, which can't start with 0: ");
        int inputNumber = int.Parse(Console.ReadLine());
        // I divide the input number by 1000 to find the first integer.
        int a = inputNumber / 1000;
        // I divide the input number two times. The first time I divide it by 100 to receive a two-digit number. 
        // The second time I divide this two-digit number with % by 10. That way the remainder is the second integer.
        int b = inputNumber / 100 % 10;
        // I use the same principal from above. The remainder is the third integer.
        int c = inputNumber / 10 % 10;
        // I divide the input number with % by 10. That way the remainder is the fourth integer.
        int d = inputNumber % 10;
        int sum = a + b + c + d;
        Console.WriteLine("The sum of the digits of your number is: " + sum);
        Console.WriteLine("Your number in reversed order is: " + d + c + b + a);
        Console.WriteLine("Your number with the last digit in first position looks like this: " + d + a + b + c);
        Console.WriteLine("Your number with exchanged second and third digit looks like this: " + a + c + b + d);
    }
}

