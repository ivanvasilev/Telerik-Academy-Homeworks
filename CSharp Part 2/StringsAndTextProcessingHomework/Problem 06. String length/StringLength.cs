// Problem 6. String length
// Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
// Print the result string into the console.

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("This program reads from the console a text with maximum 20 characters " +
                          "and if the length of the text i less than 20, the rest of the characters" +
                          " are going to be filled with the symbol '*'.");
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder(20);


        if (text.Length > 20)
        {
            Console.WriteLine("Invalid text length.\nThe text must have maximum 20 characters!");
        }
        else if (text.Length < 20)
        {
            result.Append(text);
            result.Append(new string('*', 20 - text.Length));
            Console.WriteLine("Result: {0}", result);
        }
        else
        {
            Console.WriteLine("The input text has exactly 20 characters!");
        }
    }
}