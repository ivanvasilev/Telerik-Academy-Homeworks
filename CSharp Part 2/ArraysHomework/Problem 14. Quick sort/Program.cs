// Problem 14. Quick sort
// Write a program that sorts an array of integers using the Quick sort algorithm.

using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("This program sorts an array of integers using the Quick sort algorithm.");
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
            int pivot;
            if (left < right)
            {
                pivot = Partition(numbers, left, right);
                if (pivot > 1)
                {
                    SortArray(numbers, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    SortArray(numbers, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot) ++left;
                while (numbers[right] > pivot) --right;
                if (numbers[right] == numbers[left] && numbers[left] == pivot)
                    ++left;
                if (left < right)
                {
                    numbers[left] ^= numbers[right];
                    numbers[right] ^= numbers[left];
                    numbers[left] ^= numbers[right];
                }
                else
                    return right;
            }
        }
    }