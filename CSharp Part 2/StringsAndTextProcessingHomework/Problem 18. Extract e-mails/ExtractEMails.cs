// Problem 18. Extract e-mails
// Write a program for extracting all email addresses from given text.
// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;

class ExtractEMails
{
    static void Main()
    {
        Console.WriteLine("This program extracts all email addresses from given text " +
                          "and prints their identifier, host and domain separately.");
        Console.Write("Please enter text with e-mails: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> emails = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            foreach (var symbol in words[i])
            {
                if (symbol == '@')
                {
                    emails.Add(words[i]);
                }
            }
        }

       int index = new int();
       Console.WriteLine("Result: ");
       for (int i = 0; i < emails.Count; i++)
       {
           foreach (var symbol in emails)
           {
               string singleEmail = emails[i].ToString();
               index = singleEmail.IndexOf('@');
               Console.WriteLine("[identifier] = {0}", singleEmail.Substring(0, index));
               singleEmail = singleEmail.Remove(0, index + 1);

               index = singleEmail.IndexOf('.');
               Console.WriteLine("   [host]    = {0}", singleEmail.Substring(0, index));
               singleEmail = singleEmail.Remove(0, index + 1);

               Console.WriteLine("  [domain]   = {0}", singleEmail);
               break;
           }
           if (i != emails.Count - 1)
           {
               Console.WriteLine();
           }       
       }
	}
}
