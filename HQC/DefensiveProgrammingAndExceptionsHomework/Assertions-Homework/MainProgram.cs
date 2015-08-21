using System;
using Assertions.Algorithms;

namespace Assertions
{
    internal class MainProgram
    {
        static void Main()
        {
            int[] arr = { 15, 60, -1, 87, -305, 190, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));

            SortingAlgorithm.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            //SortingAlgorithm.SelectionSort((int[])null);
            //SortingAlgorithm.SelectionSort(new int[0]); 
            SortingAlgorithm.SelectionSort(new int[1]); 

            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, -1));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 0));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 10));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 190));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 500));
        }
    }
}