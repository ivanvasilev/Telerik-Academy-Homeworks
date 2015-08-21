// Problem 15. Replace tags
// Write a program that replaces in a HTML document given as string all the tags 
// <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("This program replaces in a HTML document given as string all the tags " +
                          "<a href=\"…\">…</a> with corresponding tags [URL=…]…/URL].");
        Console.Write("Please enter HTML document: ");
        // Example = "<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>"
        string inputText = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        result.Append(inputText);

        result = result.Replace("<a href=\"", "[URL=").Replace("\">", "]").Replace("</a>", "[/URL]");
        Console.WriteLine("Result: ");
        Console.WriteLine(result);
    }
}