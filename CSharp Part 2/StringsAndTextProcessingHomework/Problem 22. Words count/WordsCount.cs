// Problem 22. Words count
// Write a program that reads a string from the console and lists all different words in the string 
// along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("This program reads a text from the console and lists all different words " +
                          "in the text along with information how many times each word is found.");
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        var dictionary = new Dictionary<string, int>();
        Console.WriteLine("Result:");
        foreach (var word in words)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary[word]++;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }
        foreach (var word in dictionary.OrderBy(key => key.Value))
        {
            Console.WriteLine("{0} - {1} times", word.Key, word.Value);
        }
    }
}