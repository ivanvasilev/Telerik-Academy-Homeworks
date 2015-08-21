// Problem 12. Index of letters
// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        Console.WriteLine("This program reads a word from the console and prints " +
                          "the index of each of its letters from the array (A-Z).");
        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 
                             'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
                             'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Console.Write("Please enter a word, using ONLY capital letters: ");
        string inputWord = Console.ReadLine();
        foreach (var letter in inputWord)
        {
            Console.WriteLine("Letter {0} has index {1}.", letter, Array.IndexOf(alphabet, letter));
        }

    }
}