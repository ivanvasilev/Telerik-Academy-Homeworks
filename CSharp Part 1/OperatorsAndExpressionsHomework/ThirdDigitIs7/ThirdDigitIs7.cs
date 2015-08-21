// Problem 5. Third Digit is 7?
// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("This program checks for given integer if the digit in the hundreds place is 7.");
        Console.Write("Please enter an integer: ");
        int inputNumber = int.Parse(Console.ReadLine());
        int newNumber = inputNumber / 100;
        bool result = newNumber % 10 == 7;
        Console.WriteLine("The digit in the hundreds place is 7: " + result);
    }
}