// Problem 4. Maximal sequence
// Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("This program finds the maximal sequence of equal elements in an array.");
        Console.Write("Please enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        
        if (length == 0)
        {
            Console.WriteLine("There aren't any given numbers!");
            return;
        }
        
        int[] numbers = new int[length];
        Console.WriteLine("Enter values:");
        for (int i = 0; i < length; i++)
        {
            Console.Write("element[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int bestLength = 0;
        int currentLength = 1;
        int bestItem = 0;
        int currentItem = numbers[0];
        
        if (length == 1)
        {
            bestItem = currentItem;
            bestLength = 1;
            Console.WriteLine("The maximal sequence of equal elements in the array is 1, because there is only one integer in the array.\nThe sequence is: {0}", bestItem);
            return;
        }

        for (int i = 1; i < numbers.Length; i++) 
        {
            if (numbers[i] == currentItem) 
            {
                currentLength++;
            }
            else
            {
                currentItem = numbers[i]; 
                currentLength = 1;
            }

            if (currentLength >= bestLength) 
            {
                bestLength = currentLength;
                bestItem = currentItem;
            }
        }
        Console.WriteLine("The maximal sequence of equal elements in the array is {0}.", bestLength);
        Console.Write("The sequence is: ");
        for (int i = 0; i < bestLength - 1; i++)
			{
			 Console.Write("{0}, ", bestItem);
			}
        Console.WriteLine("{0}", bestItem);
    }
}