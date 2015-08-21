// Problem 5. Sort by string length
// You are given an array of strings. Write a method that sorts the array by the length 
// of its elements (the number of characters composing them).

using System;

class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("This program sorts a given array by the length of its elements");
        Console.Write("Please enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] stringArray = new string[n];
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            stringArray[i] = Console.ReadLine();
        }
        Array.Sort(stringArray, (x1, x2) => x1.Length.CompareTo(x2.Length));
        
        Console.Write("Sorted array: ");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i]);
            if (i != stringArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}