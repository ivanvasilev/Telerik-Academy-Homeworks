// Problem 11. Binary search
// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("This program finds the index of given element in a sorted array " +
                          "of integers by using the Binary search algorithm.");
        Console.Write("Please enter the value of the element: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter the length of the array: ");
        int lengthOfTheArray = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[lengthOfTheArray];
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrayOfNumbers);
        Console.WriteLine("When sorted the array looks like this: " + string.Join(", ", arrayOfNumbers));
        int startIndex = 0;
        int endIndex = lengthOfTheArray - 1;
        int searchedIndex = new int();

        while (endIndex >= startIndex)
        {
            int middleIndex = (startIndex + endIndex) / 2;
            if (arrayOfNumbers[middleIndex] < number)
            {
                startIndex = middleIndex + 1;
            }
            else if (arrayOfNumbers[middleIndex] > number)
            {
                endIndex = middleIndex - 1;
            }
            else
            {
                Console.WriteLine("The index of the wanted element is: " + middleIndex);
                break;
            }
        }
    }
}