// Problem 14. Word dictionary
// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

using System;

class WordDictionary
{
    static void Main()
    {
        Console.WriteLine("This program reads a word from the console and prints it's explanation.");
        Console.WriteLine("The input word must be: .NET, CLR or namespace");
        Console.Write("Please enter a word: ");
        string inputWord = Console.ReadLine();
        string dictionary = ".NET - platform for applications from Microsoft\n"+
            "CLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes";

        string[] arrayOfDictionary = dictionary.Split(new char[] { '\n', '-' });
        string searchedWord = inputWord + " ";

        for (int i = 0; i < arrayOfDictionary.Length; i++)
        {
            if (string.Compare(searchedWord, arrayOfDictionary[i], true) == 0)
            {
                Console.WriteLine(inputWord + " -" + arrayOfDictionary[i + 1].ToString());
            }
        }
    }
}