//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.
using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        Console.WriteLine("This program deletes from given text file all odd lines and saves the result " +
                          "in the same file.");
        StreamReader read = new StreamReader("..//..//Start.txt");
        List<string> archiever = new List<string>();

        using (read)
        {
            string fileReader = read.ReadLine();
            int line = 1;
            while (fileReader != null)
            {
                if (line % 2 != 0)
                {
                    archiever.Add(fileReader);
                }
                line++;
                fileReader = read.ReadLine();
            }
        }

        StreamWriter writer = new StreamWriter("..//..//Start.txt");

        using (writer)
        {
            for (int i = 0; i < archiever.Count; i++)
            {
                writer.WriteLine(archiever[i]);
            }
        }
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }
}

