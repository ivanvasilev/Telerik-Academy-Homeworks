// Problem 8. Digit as Word
// Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
    // Print “not a digit” in case of invalid input.
    // Use a switch statement.

using System;

class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine("This program asks for a digit and depending on the input, shows the digit as a word.");
        Console.Write("Please enter a digit: ");
        string inputSign = Console.ReadLine();

        switch (inputSign)
        {
            case "0": Console.WriteLine(inputSign + ": zero");
                break;
            case "1": Console.WriteLine(inputSign + ": one");
                break;
            case "2": Console.WriteLine(inputSign + ": two");
                break;
            case "3": Console.WriteLine(inputSign + ": three");
                break;
            case "4": Console.WriteLine(inputSign + ": four");
                break;
            case "5": Console.WriteLine(inputSign + ": five");
                break;
            case "6": Console.WriteLine(inputSign + ": six");
                break;
            case "7": Console.WriteLine(inputSign + ": seven");
                break;
            case "8": Console.WriteLine(inputSign + ": eight");
                break;
            case "9": Console.WriteLine(inputSign + ": nine");
                break;
            default: Console.WriteLine(inputSign + ": not a digit");
                break;
        }
    }
}