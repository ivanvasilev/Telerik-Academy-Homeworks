// Problem 2. Compare arrays
// Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("This program reads two integer arrays from the console and compares" +
                          " them element by element.");
        Console.Write("Please enter the length of the first array: ");
        int firstLength = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstLength];
        for (int i = 0; i < firstLength; i++)
        {
            Console.Write("element[{0}] = ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter the length of the second array: ");
        int secondLength = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondLength];
        for (int i = 0; i < secondLength; i++)
        {
            Console.Write("element[{0}] = ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
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