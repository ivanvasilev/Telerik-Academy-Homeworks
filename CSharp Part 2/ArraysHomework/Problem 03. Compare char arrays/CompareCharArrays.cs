// Problem 3. Compare char arrays
// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("This program reads two integer char arrays from the console and compares" +
                          " them letter by letter.");
        Console.Write("Please enter the length of the first array: ");
        int firstLength = int.Parse(Console.ReadLine());
        char[] firstArray = new char[firstLength];
        for (int i = 0; i < firstLength; i++)
        {
            Console.Write("element[{0}] = ", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Please enter the length of the second array: ");
        int secondLength = int.Parse(Console.ReadLine());
        char[] secondArray = new char[secondLength];
        for (int i = 0; i < secondLength; i++)
        {
            Console.Write("element[{0}] = ", i);
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        bool arraysAreEqual = true;
        for (int i = 0; i < firstLength; i++)
        {
            if (firstLength != secondLength)
            {
                Console.WriteLine("The arrays aren't equal!");
                return;
            }
            else
            {
                if (firstArray[i] != secondArray[i])
                {
                    arraysAreEqual = false;
                }   
            }
        }
        Console.WriteLine("Are both arrays equal: {0}", arraysAreEqual);
    }
}