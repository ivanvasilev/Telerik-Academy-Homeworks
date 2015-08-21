using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello,";
        string secondWord = "World!";
        object wholeSentence = firstWord + " " + secondWord;
        string sentenceInString = (string)wholeSentence;

        Console.WriteLine(sentenceInString);
    }
}