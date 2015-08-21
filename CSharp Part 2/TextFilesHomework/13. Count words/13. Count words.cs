//Problem 13. Count words

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained 
//in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Linq;

class CountWords
{
    public static List<string> FileReader()
    {
        using (StreamReader reader = new StreamReader("..//..//word.txt"))
        {
            List<string> words = new List<string>();
            for (string line; (line = reader.ReadLine()) != null; ) words.Add(line);
            return words;
        }
    }

    public static Dictionary<string, int> SameWordsSequences(List<string> words)
    {
        using (StreamReader reader = new StreamReader("..//..//test.txt"))
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] wordsOnLine = line.ToLower().Split(' ', '.', ';', ':');

                foreach (string word in wordsOnLine)
                {
                    if (words.Contains(word))
                    {
                        if (!dictionary.ContainsKey(word))
                        {
                            dictionary.Add(word, 1);
                        }
                        else ++dictionary[word];
                    }
                }
                line = reader.ReadLine();
            }

            return dictionary;
        }
    }

    public static void SaveResultToFile(Dictionary<string, int> dictionary)
    {
        using (StreamWriter writer = new StreamWriter("..//..//result.txt"))
        {
            var sortedDictionary = (from d in dictionary
                                    orderby d.Value descending
                                    select d);

            foreach (var pair in dictionary)
            {
                writer.WriteLine(pair.Key + " " + pair.Value);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("This program reads a list of words from the file words.txt and finds how many " +
                          "times each of the words is contained in another file test.txt.");
        try
        {
            List<string> words = FileReader();
            Dictionary<string, int> dictionary = SameWordsSequences(words);
            SaveResultToFile(dictionary);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }
}

