// Problem 2. Reverse string
// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("This program reads a text, reverses it and prints the result at the console.");
        Console.Write("Please enter text: ");
        string input = Console.ReadLine();
        StringBuilder reverseText = new StringBuilder(input.Length);
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverseText.Append(input[i]);
        }
        Console.WriteLine("The reversed text is: {0}", reverseText);
    }
}