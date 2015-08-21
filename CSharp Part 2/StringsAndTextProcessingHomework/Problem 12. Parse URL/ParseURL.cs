// Problem 12. Parse URL
// Write a program that parses an URL address given in the format: 
// [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;

class ParseURL
{
    static void Main()
    {
        Console.WriteLine("This program extracts from a given URL it's protocol, server and resource " +
                          "and prints them separately.");
        Console.Write("Please enter an URL: ");
        string url = Console.ReadLine();
        // Example = "http://telerikacademy.com/Courses/Courses/Details/212"

        int index = new int();

        index = url.IndexOf(':');
        Console.WriteLine("[protocol] = {0}", url.Substring(0, index));
        url = url.Remove(0, index + 3);

        index = url.IndexOf('/');
        Console.WriteLine(" [server]  = {0}", url.Substring(0, index));
        url = url.Remove(0, index);

        Console.WriteLine("[resource] = {0}", url);
    }
}