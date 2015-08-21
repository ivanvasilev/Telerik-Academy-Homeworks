// Problem 8. Maximal sum
// Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program finds the sequence of maximal sum in given array.");
        Console.Write("Please enter the length of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(string.Join(", ", array));

        int startIndex = 0;
        int currentSum = 0;
        int bestStart = 0;
        int endIndex = 0;
        int bestSum = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }
            currentSum += array[i];
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestStart = startIndex;
                endIndex = i;
            }
        }
        Console.WriteLine("Maximal sum: {0}", bestSum);
        Console.Write("The best sequence is: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}