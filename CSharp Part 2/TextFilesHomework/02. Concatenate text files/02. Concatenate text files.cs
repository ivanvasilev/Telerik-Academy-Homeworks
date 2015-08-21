//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
class ConcatenateTextFiles
{
    static void Main()
    {
        Console.WriteLine("This program concatenates two text files into another text file.");
        StreamWriter writer = new StreamWriter("..\\..\\Writer");
        using (writer)
        {
            StreamReader file1 = new StreamReader("..\\..\\02. Concatenate text files.cs");
            using (file1)
            {
                string file1Reader = file1.ReadLine();
                while (file1Reader != null)
                {

                    writer.WriteLine(file1Reader);
                    file1Reader = file1.ReadLine();
                }

            }

            StreamReader file2 = new StreamReader("..\\..\\Properties\\AssemblyInfo.cs");
            using (file2)
            {
                string file2Reader = file2.ReadLine();
                while (file2Reader != null)
                {
                    writer.WriteLine(file2Reader);
                    file2Reader = file2.ReadLine();
                }
            }
        }
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }
}
