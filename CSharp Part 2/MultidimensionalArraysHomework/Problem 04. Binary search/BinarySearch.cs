// Problem 4. Binary search
// Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
// and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("This program reads a number from the console and prints the largest number" +
                           " in a given array which is <= K, using the Binary search method");
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
        int searchedNumber = new int();

        while (endIndex >= startIndex)
        {
            int middleIndex = (startIndex + endIndex) / 2;
            if (arrayOfNumbers[middleIndex] < number && arrayOfNumbers[middleIndex + 1] > number)
            {
                searchedNumber = arrayOfNumbers[middleIndex];
                Console.WriteLine("Found number: " + searchedNumber);
                break;
            }
            else if (arrayOfNumbers[middleIndex] > number && arrayOfNumbers[middleIndex - 1] < number)
            {
                searchedNumber = arrayOfNumbers[middleIndex - 1];
                Console.WriteLine("Found number: " + searchedNumber);
                break;
            }
            else
            {
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
                    searchedNumber = arrayOfNumbers[middleIndex];
                    Console.WriteLine("Found number: " + searchedNumber);
                    break;
                }
            }
        }
    }
}