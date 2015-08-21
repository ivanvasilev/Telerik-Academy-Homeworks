// Problem 9. Frequent number
// Write a program that finds the most frequent number in an array.

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("This program finds the most frequent number in an array.");
        Console.Write("Please enter the length of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        int mostFrequentNumber = 0;
        int counter = 1;
        int maxCount = 1;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }

            if (counter >= maxCount)
            {
                maxCount = counter;
                mostFrequentNumber = array[i];
            }
        }
        Console.WriteLine("The most frequent number in the array is: " + mostFrequentNumber);
        Console.WriteLine("How many times does the array contain the number: " + maxCount);
    }
}