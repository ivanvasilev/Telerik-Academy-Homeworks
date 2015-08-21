// Problem 7. Selection sort
// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
// find the smallest from the rest, move it at the second position, etc.

using System;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("This program sorts the elements of an array using the selection sort method.");
        Console.Write("Please enter the length of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int temp = 0;
        int[] sortedArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            temp = Array.IndexOf(array, array.Min());
            sortedArray[i] = array[temp];
            array[temp] = int.MaxValue;

        }
        Console.WriteLine("Result: " + string.Join(", ", sortedArray));
    }
}