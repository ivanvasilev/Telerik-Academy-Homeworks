using System;

class QuotesInStrings
{
    static void Main()
    {
        string slashQuote = "The \"use\" of quotations causes difficulties.";
        string atQuote = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(slashQuote);
        Console.WriteLine(atQuote);
    }
}