// Problem 7. Encode/decode
// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters.
// The encoding/decoding is done by performing XOR (exclusive or) operation 
// over the first letter of the string with the first of the key, the second – with the second, etc. 
// When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeAndDecode
{
    static void Main()
    {
        Console.WriteLine("This program encodes and decodes a given text, using given encryption key (cipher).");
        Console.Write("Please enter text: ");
        // The easiest way to check wheather the program is correct is when the input text is words 
        // and the cypher is numbers.
        // Example: text = "check if the program is correct" and cypher = 12
        // Result = "RYTRZ◄XW◄EYT◄AC^VCP\◄XB◄R^CCTRE"
        // And when you have the result you can enter the result as input text with the same cypher and check 
        // if the new result is the same as the first input text.
        string text = Console.ReadLine();
        Console.Write("Please enter cypher: ");
        string cypher = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        for (int i = 0, j = 0; i < text.Length && j < cypher.Length; i++, j++)
        {
            if (j == cypher.Length - 1)
            {
                j = 0;
            }
            result.Append((char)(text[i] ^ cypher[j]));
        }
        Console.WriteLine("The decoded input text with this key is: {0}", result);
    }
}