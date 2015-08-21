// Problem 25. Extract text from HTML
// Write a program that extracts from given HTML file its title (if available), 
// and its body text without the HTML tags.

using System;

class ExtractTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("This program extracts from given HTML file its title and its body text without the HTML tags.");
        Console.WriteLine("Please enter HTML file: ");
        string file = Console.ReadLine();
        // Example = "<html><head><title>News</title></ head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>"
        int firstIndex = new int();
        int secondIndex = new int();

        Console.WriteLine("Result:");

        firstIndex = file.IndexOf("<title>");
        secondIndex = file.IndexOf("</title>", firstIndex + 1);
        Console.WriteLine("Title: {0}", file.Substring(firstIndex + 7, secondIndex - firstIndex - 7));
        file = file.Remove(0, secondIndex);

        firstIndex = file.IndexOf("\">");
        secondIndex = file.IndexOf("</a>");
        Console.Write("Text: {0} ", file.Substring(firstIndex + 2, secondIndex - firstIndex - 2));
        file = file.Remove(0, secondIndex);

        firstIndex = file.IndexOf("</a>");
        secondIndex = file.IndexOf("</p>");
        Console.Write("{0}", file.Substring(firstIndex + 4, secondIndex - firstIndex - 4));
        Console.WriteLine();
    }
}