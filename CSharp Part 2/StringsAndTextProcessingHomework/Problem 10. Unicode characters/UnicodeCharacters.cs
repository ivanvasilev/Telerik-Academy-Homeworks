// Problem 10. Unicode characters
// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("This program converts a text to a sequence of C# Unicode character literals.");
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        foreach (char letter in text)
        {
            result.Append(String.Format("\\u{0:X4}", (int)letter));
        }
        Console.WriteLine("Result: {0}", result);
    }
}