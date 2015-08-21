//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests
//count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
using System;
using System.IO;

class ExtractTextFromXML
{
    static void Main()
    {
        Console.WriteLine("This program extracts from given XML file all the text without the tags.");
        Console.Write("Result: ");
        using (StreamReader read = new StreamReader("..//..//XML.txt"))
        {
            int charactrer = read.Read();
            bool start = false;

            while (charactrer != -1)
            {
                if (charactrer == '>')
                {
                    start = true;
                }
                else if (charactrer == '<' || charactrer == '\r' || charactrer == '\n')
                {
                    start = false;
                }
                if (start && charactrer != '>')
                {
                    Console.Write((char)charactrer);
                }
                charactrer = read.Read();
            }
        }
        Console.WriteLine();
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }
}

