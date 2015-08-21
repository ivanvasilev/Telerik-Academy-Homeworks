// Problem 5. Larger than neighbours
// Write a method that checks if the element at given position in given array of integers 
// is larger than its two neighbours (when such exist).

using System;
using System.Linq;

class LargerThanHeighbours
{
    static void Main()
    {
        Console.WriteLine("This program checks if the element at given position in given array of integers" +
                          "is larger than its two neighbours (when such exist).");
        Console.WriteLine("Enter numbers on a single line, separated by space: ");
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();
        if (numbers.Length < 3)
        {
            Console.WriteLine("There must be atleast 3 numbers in the array, " +
                              "so atleast one of them to have two neighbours!");
            return;
        }
        Console.Write("Please enter position between 0 and {0}: ", numbers.Length - 1);
        int searchedIndex = int.Parse(Console.ReadLine());
        PrintIfGivenNumberIsLargerThanItsNeghbours(numbers, searchedIndex);
    }

    static void PrintIfGivenNumberIsLargerThanItsNeghbours(int[] numbers, int index)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (index == 0)
                {
                    Console.WriteLine("That is the first element. It isn't between two other numbers.");
                    break;
                }
                if (index == numbers.Length - 1)
                {
                    Console.WriteLine("That is the last number. It isn't between two other numbers.");
                    break;
                }
                if ((numbers[index - 1] < numbers[index]) && (numbers[index] > numbers[index + 1]))
                {
                    Console.WriteLine("Number at position {0} is larger than it's neighbours!", index);
                    break;
                }
                else
                {
                    Console.WriteLine("Number at position {0} isn't larger than it's neighbours!", index);
                    break;
                }
            }
    }
}