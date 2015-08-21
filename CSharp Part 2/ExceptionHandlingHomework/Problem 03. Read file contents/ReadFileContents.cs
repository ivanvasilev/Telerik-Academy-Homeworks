// Problem 3. Read file contents
// Write a program that enters file name along with its full file path 
// (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
// Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("This program reads a file name along with its full file path, reads its" +
                          " contents and prints it on the console.");
        Console.Write("Enter the path of the file: ");
        string filePath = Console.ReadLine();
        // It's easier to check the program, if you enter a path of a file of type .txt.
        ReadFile(filePath);
    }

    static void ReadFile(string filePath)
    {
        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("File content: ");
            Console.WriteLine(fileContent);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}