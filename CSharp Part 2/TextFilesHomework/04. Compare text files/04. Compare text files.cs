//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same
//and the number of lines that are different.
//Assume the files have equal number of lines.
using System;
using System.IO;
class CompareTextFiles
{
    static void Main()
    {
        Console.WriteLine("This program compares two text files line by line and prints the number of lines " +
                          "that are the same and the number of lines that are different.");
        Console.WriteLine("Result:");
        StreamReader fileOne = new StreamReader("..//..//04. Compare text files.cs");
        int sameLines = 0;
        int diffLines = 0;

        using (fileOne)
        {
            string readerOne = fileOne.ReadLine();

            StreamReader fileTwo = new StreamReader("..//..//..//03. Line numbers//03. Line numbers.cs");

            using (fileTwo)
            {
                string readerTwo = fileTwo.ReadLine();

                while (readerOne != null && readerTwo != null)
                {
                    if (readerOne == readerTwo)
                    {
                        sameLines++;
                    }
                    if (readerOne != readerTwo)
                    {
                        diffLines++;
                    }
                    readerOne = fileOne.ReadLine();
                    readerTwo = fileTwo.ReadLine();
                }

            }
        }
        Console.WriteLine("The different lines are {0} ", diffLines);
        Console.WriteLine("The same lines are {0} ", sameLines);
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }
}

