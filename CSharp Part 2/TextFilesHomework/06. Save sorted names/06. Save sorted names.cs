//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	
//Ivan 
//Peter 
//Maria 
//George

//output.txt	
//George 
//Ivan 
//Maria 
//Peter

using System;
using System.Collections.Generic;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        Console.WriteLine("This program reads a text file containing a list of strings, sorts them and " +
                          "saves them to another text file.");
        StreamReader reader = new StreamReader("..//..//Unsorted.txt");
        List<string> array = new List<string>();

        using (reader)
        {
            string nameReader = reader.ReadLine();
            while (nameReader != null)
            {
                array.Add(nameReader);
                nameReader = reader.ReadLine();
            }
        }
        array.Sort();

        StreamWriter writer = new StreamWriter("..//..//SaveSortedNames", true);

        using (writer)
        {
            for (int i = 0; i < array.Count; i++)
            {
                writer.WriteLine(array[i]);
            }
        }
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }
}

