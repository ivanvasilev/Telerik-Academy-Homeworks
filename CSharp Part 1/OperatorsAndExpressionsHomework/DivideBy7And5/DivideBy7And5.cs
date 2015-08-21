// Problem 3. Divide by 7 and 5
// Write a Boolean expression that checks for given integer if it can be divided 
// (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("This program checks if a given integer can be divided by 5 and 7 without remainder.");
        Console.Write("Please write an integer: ");
        int inputNumber = int.Parse(Console.ReadLine());
        bool result = inputNumber % 5 == 0 && inputNumber % 7 == 0 && inputNumber != 0;
        Console.WriteLine("Result: " + result);
    }
}
