// Problem 24. Order words
// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("This program reads a sequence of words, separated by spaces and " +
                          "prints them in an alphabetical order.");
        Console.Write("Please enter words, separated by space: ");
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        Array.Sort(words);
        Console.WriteLine("Your words in alphabetical order: ");
        Console.WriteLine(string.Join(" ", words));
    }
}