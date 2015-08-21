// Problem 10. Find sum in array
// Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("This program finds in given array of integers a sequence of given sum (if present).");
        Console.Write("Please enter the sum You want the program to find: ");
        int S = int.Parse(Console.ReadLine());
        Console.Write("Please enter the length of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        
        int currSum = 0;
        int startIndex = 0;
        for (int i = 0; i < N - 1; i++)
        {
            currSum += array[i];
            startIndex = i;
            for (int j = i + 1; j < N; j++)
            {
                currSum += array[j];
                if (currSum == S)
                {
                    Console.Write("When You add these numbers You receive the wanted sum: ");
                    for (int k = startIndex; k <= j; k++)
                    {
                        Console.Write(string.Join(", ", array[k]));
                    }
                    Console.WriteLine();
                    break;
                }
            }
            currSum = 0;
        }
    }
}