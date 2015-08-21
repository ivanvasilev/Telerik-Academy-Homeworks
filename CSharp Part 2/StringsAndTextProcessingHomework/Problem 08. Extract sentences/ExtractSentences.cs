// Problem 8. Extract sentences
// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        Console.WriteLine("This program extracts from a given text all sentences containing given word.");
        Console.Write("Please enter sentences, separated by '.': ");
        string inputText = Console.ReadLine();
        Console.Write("Please enter the word: ");
        string word = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        string[] sentences = inputText.Split(new char[] { '.' , '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(' ');
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == word)
                {
                    result.Append(sentences[i]);
                    result.Append(".");
                }
            }
        }
        Console.WriteLine("Result: {0}", result);
    }
}