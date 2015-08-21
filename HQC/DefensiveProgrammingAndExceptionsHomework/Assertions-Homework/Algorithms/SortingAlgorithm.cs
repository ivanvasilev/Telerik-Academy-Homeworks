﻿namespace Assertions.Algorithms
{
    using System;
    using System.Diagnostics;

    internal static class SortingAlgorithm
    {
        internal static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null.");
            Debug.Assert(arr.Length > 0, "Array is empty.");

            int length = arr.Length;
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = Helpers.HelpMethods.FindMinElementIndex(arr, index, arr.Length - 1);
                Helpers.HelpMethods.Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(arr.Length == length, "Input and output arrays have different lengths.");
        }
    }
}