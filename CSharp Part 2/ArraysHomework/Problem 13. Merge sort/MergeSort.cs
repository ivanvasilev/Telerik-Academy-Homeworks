﻿// Problem 13.* Merge sort
// Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class MergeSort
{
    static void Main()
    {
        Console.WriteLine("This program sorts an array of integers using the Merge sort algorithm.");
        Console.Write("Please enter the length of the array: ");
        int lengthOfTheArray = int.Parse(Console.ReadLine());
        int[] numbers = new int[lengthOfTheArray];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        SortArray(numbers, 0, numbers.Length - 1);
        Console.WriteLine("Result: " + String.Join(", ", numbers));
    }
    private static void SortArray(int[] numbers, int left, int right)
    {
        int mid;
        if (left < right)
        {
            mid = (left + right) / 2;
            SortArray(numbers, left, mid);
            SortArray(numbers, mid + 1, right);
            MergeArrays(numbers, left, mid + 1, right);
        }
    }
    private static void MergeArrays(int[] numbers, int left, int mid, int right)
    {
        int numbersCount = right - left + 1;
        int leftEnd = mid - 1;
        int position = left;
        int[] temp = new int[numbers.Length];
        while ((left <= leftEnd) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
            {
                temp[position++] = numbers[left++];
            }
            else
            {
                temp[position++] = numbers[mid++];
            }
        }
        while (left <= leftEnd)
        {
            temp[position++] = numbers[left++];
        }
        while (mid <= right)
        {
            temp[position++] = numbers[mid++];
        }
        for (int index = numbersCount - 1; index >= 0; index--)
        {
            numbers[right] = temp[right];
            --right;
        }
    }
}