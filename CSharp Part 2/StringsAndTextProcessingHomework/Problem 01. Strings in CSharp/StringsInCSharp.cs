// Problem 1. Strings in C#.
// Describe the strings in C#.
// What is typical for the string data type?
// Describe the most important methods of the String class.

using System;
using System.Text;

class StringsInCSharp
{
    static void Main()
    {
        Console.WriteLine("This program prints what is typical for the string data type and describes " +
                          "the most important methods of the String class.");
        Console.WriteLine();
        StringBuilder text = new StringBuilder();
        text.AppendLine("Definition: A string is an object from class String and it's value is represented " +
                        "as a sequence of zero or more Unicode characters. The string is stored " +
                        "as a read-only char array and you can take the value of every index in " +
                        "the string using the indexer. Every string has some length and it can be" +
                        " taken with the Length property.");
        text.AppendLine(new string('-', 40));
        text.AppendLine("Important methods of the String class:");
        text.AppendLine("*string.Compare(): Compares different strings. This method has different overloads.");
        text.AppendLine("*string.Contains(): Returns a value indicating whether a specified " +
                        "substring occurs within this string.");
        text.AppendLine("*string.Equals(): Determines whether two specified String objects have the same value.");
        text.AppendLine("*string.Format(): Replaces one or more format items in a specified string with" +
                        " the string representation of a specified object.");
        text.AppendLine("*string.IndexOf(): Finding a character or substring within given string.");
        text.AppendLine("*string.Insert(): Returns a new string in which a specified string is inserted" +
                        " at a specified index position in this instance. ");
        text.AppendLine("*string.Join(): Concatenates the members of a constructed IEnumerable<T> collection" +
                        " of type String, using the specified separator between each member.");
        text.AppendLine("*string.PadLeft() and string.PadRight(): Returns a new string that is right-" +
                        " or left-alligned.");
        text.AppendLine("*string.Split(): Splits string object by given separator.");
        text.AppendLine("*string.Substring(): Extract substring from the String object.");
        text.AppendLine("*string.Trim(): Removes all leading and trailing white-space characters from" +
                        " the current String object.");
        text.AppendLine("*string.ToUpper() and string.ToLower(): Returns a copy of this string converted" +
                        " to uppercase or to lowercase.");
        text.AppendLine("*string.Replace(): Returns a new string in which all occurrences of a specified " +
                        "string or a specified Unicode character in the current instance are replaced " +
                        "with another specified string or a specified Unicode character.");
        text.AppendLine("*string.Remove(): Returns a new string in which all the characters or a specified" +
                        " number of characters in the current instance beginning at a specified position " +
                        "have been deleted.");
        Console.Write(text);
    }
}