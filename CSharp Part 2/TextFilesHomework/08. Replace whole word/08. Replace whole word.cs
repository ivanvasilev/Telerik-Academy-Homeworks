//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace only whole words (not strings).
using System;
using System.IO;

class ReplaceWholeWord
{
    static void Main()
    {
        Console.WriteLine("This program modies the solution of the previous problem to replace only whole word.");
        StreamWriter writer = new StreamWriter("..//..//Finish.txt");
        using (writer)
        {
            StreamReader reader = new StreamReader("..//..//Start.txt");
            using (reader)
            {
                string readfile = reader.ReadLine();
                while (readfile != null)
                {
                    writer.WriteLine(System.Text.RegularExpressions.Regex.Replace(readfile, "\\bstart\\b", "finish"));
                    readfile = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }
}

