//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;
class OddLines
{
    static void Main()
    {
        Console.WriteLine("This program reads a text file and prints on the console only its odd lines.");
        StreamReader read = new StreamReader("..//..//01. Odd lines.cs");
        using (read)
        {
            int lineCount = 1;
            string line = read.ReadLine();
            Console.WriteLine("Result:");
            while (line!=null)
            {
                if (lineCount%2==0)
                {
                    Console.WriteLine("Line {0}: {1}", lineCount, line);

                }
                lineCount++;
                line = read.ReadLine();
            }
        }
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }
}

