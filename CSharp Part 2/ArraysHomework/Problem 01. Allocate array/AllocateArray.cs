// Problem 1. Allocate array
// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main()
    {
        Console.WriteLine("This program prints 20 elements of an array, " +
                          "where each element is equal of its index multiplied by 5.");
        int[] array = new int[20];
        int length = array.Length;
        Console.WriteLine("Result: ");
        for (int index = 0; index < length; index++)
        {
            array[index] = index * 5;
            Console.WriteLine("element[{0}]: {1}", index, array[index]);
        }
    }
}