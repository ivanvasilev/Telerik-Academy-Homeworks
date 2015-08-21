// Problem 20. Palindromes
// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("This program extracts from a given text all palindromes.");
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, 
                                    StringSplitOptions.RemoveEmptyEntries);

        bool isPalindrome = true;
        Console.WriteLine("The palindromes in the text are: ");
        int counter = 0;
        foreach (var word in words)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    isPalindrome = false;
                }
            }
            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
                counter++;
            }

            if (counter == 0)
            {
                Console.WriteLine("There aren't any palindromes in this text!");
            }
        }
    }
}