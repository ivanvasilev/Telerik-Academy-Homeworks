// Problem 4. Sub-string in text
// Write a program that finds how many times a sub-string is contained 
// in a given text (perform case insensitive search).

using System;

class SubstringInText
{
    static void Main()
    {
        Console.WriteLine("This program finds how many times a sub-string is contained in a given text");
        Console.Write("Please enter text: ");
        string inputText = Console.ReadLine();
        Console.Write("Please enter which word you want the program to search: ");
        string word = Console.ReadLine();

        int counter = 0;
        for (int i = 0; i < inputText.Length - word.Length + 1; i++)
		{
            if ((string.Compare(word, inputText.Substring(i, word.Length), true)) == 0)
            {
                counter++;
            }
		}       
        Console.WriteLine("The word {0} is contained {1} times in the given text.", word, counter);
    }
}