// Problem 4. Appearance count
// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("This program counts how many times given number appears in given array.");
        Console.WriteLine("Enter numbers on a single line, separated by space: ");
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
        Console.Write("Please enter the number you want the program to find: ");
        int searchedNumber = int.Parse(Console.ReadLine());

        PrintCountOfMostFrequentElementInArray(numbers, searchedNumber);
    }

    static void PrintCountOfMostFrequentElementInArray(int[] numbers, int numberTobeFound)
    {
        int counter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == numberTobeFound)
            {
                counter++;
            }
        }
        Console.WriteLine("Number {0} is found {1} times in the given array.", numberTobeFound, counter);
    }
}