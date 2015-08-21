// Problem 13. Reverse sentence
// Write a program that reverses the words in given sentence.

using System;
using System.Collections.Generic;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("This program reverses all the words in a given sentence.");
        Console.Write("Please enter a sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' },
                                               StringSplitOptions.RemoveEmptyEntries);
        List<char> signs = new List<char>();
        for (char i = 'a'; i <= 'z'; i++)
        {
            signs.Add(i);
        }
        for (char i = 'A'; i <= 'Z'; i++)
        {
            signs.Add(i);
        }
        for (char i = '0'; i <= '9'; i++)
        {
            signs.Add(i);
        }
        signs.Add('#');
        signs.Add('+');

        string[] splitElements = sentence.Split(signs.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        Console.WriteLine("Result: ");
        var reversedText = new StringBuilder();
        for (int i = 0; i < splitElements.Length; i++)
        {
            reversedText.Append(words[i]);
            reversedText.Append(splitElements[i]);
        }
        Console.WriteLine(reversedText.ToString());
    }
}