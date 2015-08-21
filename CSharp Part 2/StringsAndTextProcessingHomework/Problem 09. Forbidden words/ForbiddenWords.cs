// Problem 9. Forbidden words
// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("This program replaces in a given text given forbidden words with asteriks.");
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        Console.Write("Please enter forbidden words, separated with space: ");
        string words = Console.ReadLine();
        string[] arrayOfWords = words.Split(new char[] { ' ', ',', '.' }, 
                                            StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();
        result.Append(text);
        
        for (int i = 0; i < arrayOfWords.Length; i++)
        {
            result.Replace(arrayOfWords[i], new string('*', arrayOfWords[i].Length));
        }
        Console.WriteLine("Result: {0}", result);
    }
}