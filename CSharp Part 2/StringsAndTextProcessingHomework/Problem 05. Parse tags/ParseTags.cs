// Problem 5. Parse tags
// You are given a text. Write a program that changes the text in all regions surrounded by the tags 
// <upcase> and </upcase> to upper-case.
// The tags cannot be nested.

using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        Console.WriteLine("This program changes the text in all regions surrounded by the tags " +
                          "<upcase> and </upcase> to upper-case.");
        Console.WriteLine("Please enter text: ");
        string inputText = Console.ReadLine();
        // Example = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else."
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == '<')
            {
                i += 8;
                while (inputText[i] != '<')
                {
                    result.Append(inputText[i].ToString().ToUpper());
                    i++;
                }
                i += 8;
            }
            else
            {
                result.Append(inputText[i]);
            }
        }
        Console.WriteLine("Result: {0}", result);
    }
}