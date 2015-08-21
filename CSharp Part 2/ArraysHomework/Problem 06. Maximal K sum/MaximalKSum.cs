// Problem 6. Maximal K sum
// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("This program finds the maximal sum of a given number of elements in a given array.");
        Console.Write("Please enter how many elements You want the program to calculate: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Please enter the length of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        if (K > N)
        {
            Console.WriteLine("The number of elements must be lower or equal to the length of the array!");
            return;
        }
        for (int i = 0; i < N; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        Array.Reverse(array);
        long sumOfKItems = 0;
        for (int i = 0; i < K; i++)
        {
            sumOfKItems += array[i];
        }
        Console.WriteLine("The maximal sum of {0} elements in this array is: {1}", K, sumOfKItems);
    }
}