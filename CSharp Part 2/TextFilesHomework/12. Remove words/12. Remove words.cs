//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;

class RemoveWords
{
    static void Main()
    {
        Console.WriteLine("This program removes from a text file all words listed in given another text file.");
        Console.WriteLine("Result:");
        try
        {
            using (StreamReader textreader = new StreamReader("..//..//Text.txt"))
            {
                List<string> listOfWords = ListOfWords();
                string line = textreader.ReadLine();
                while (line != null)
                {

                    for (int i = 0; i < listOfWords.Count; i++)
                    {
                        line = line.Replace(listOfWords[i], string.Empty);
                    }
                    Console.WriteLine(line);
                    line = textreader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }

    static List<string> ListOfWords()
    {
        List<string> words = new List<string>();

        using (StreamReader list = new StreamReader("..//..//ListOfWords.txt"))
        {
            string line = list.ReadLine();
            while (line != null)
            {
                words.Add(line);
                line = list.ReadLine();
            }
        }
        return words;
    }
}

