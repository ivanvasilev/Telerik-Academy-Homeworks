//Problem 11. Prefix "test"

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.
using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        Console.WriteLine("This program deletes from a text file all words that start with the prefix test.");
        Console.WriteLine("Result:");
        using (StreamWriter writer = new StreamWriter("..//..//TextWithoutTest.txt"))
        {
            using (StreamReader read = new StreamReader("..//..//TextWithTest.txt"))
            {
                string lineRead = read.ReadLine();
                string holder = "\\btest\\w*\\b";
                while (lineRead != null)
                {
                    Regex rgx = new Regex(holder);
                    lineRead = rgx.Replace(lineRead, " ");
                    writer.WriteLine(lineRead);
                    Console.WriteLine(lineRead);
                    lineRead = read.ReadLine();
                }
            }
        }
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }
}

