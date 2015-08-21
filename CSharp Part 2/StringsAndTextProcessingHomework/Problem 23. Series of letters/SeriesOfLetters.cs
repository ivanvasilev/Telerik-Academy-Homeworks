// Problem 23. Series of letters
// Write a program that reads a string from the console and replaces all series 
// of consecutive identical letters with a single one.

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("This program reads a text from the console and replaces all series of " +
                          "consecutive identical letters with a single one.");
        Console.Write("Please enter a sequence of letters: ");
        string text = Console.ReadLine();
        StringBuilder letters = new StringBuilder();
        letters.Append(text[0]);
        Console.Write("Result: ");
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                letters.Append(text[i]);
            }
        }
        Console.WriteLine(letters.ToString());
    }
}