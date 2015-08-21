// Problem 5. Maximal increasing sequence
// Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("This program finds the maximal increasing sequence in an array.");
        Console.Write("Please enter the length of the array: ");
        int lengthOfTheArray = int.Parse(Console.ReadLine());
        int[] numbers = new int[lengthOfTheArray];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        var sequence = GetLongestSequence(numbers);
        Console.WriteLine("Longest sequence: " + sequence);
    }
    private static string GetLongestSequence(int[] numbers)
    {
        int lastSequenceIndex = 0;
        int longestSequenceLenght = 1;
        int tempLength = 1;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                ++tempLength;
                if (tempLength > longestSequenceLenght)
                {
                    longestSequenceLenght = tempLength;
                    lastSequenceIndex = i;
                }
            }
            else
            {
                tempLength = 1;
            }
        }
        int skip = lastSequenceIndex - longestSequenceLenght + 1;
        var sequence = numbers.Skip(skip).Take(longestSequenceLenght).ToArray();
        return string.Join(", ", sequence);
    }
}