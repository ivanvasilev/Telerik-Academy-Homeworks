// Problem 6. First larger than neighbours
// Write a method that returns the index of the first element in array 
// that is larger than its neighbours, or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("This program returns the index of the first element in array " +
                          "that is larger than its neighbours, or -1, if there’s no such element.");
        Console.WriteLine("Enter numbers on a single line, separated by space: ");
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();
        PrintIfGivenNumberIsLargerThanItsNeghbours(numbers);
    }

    static void PrintIfGivenNumberIsLargerThanItsNeghbours(int[] numbers)
    {
        if (numbers.Length < 3)
        {
            Console.WriteLine("There must be atleast 3 numbers in the array, " +
                              "so atleast one of them to have two neighbours!");
        }
        
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            
            
            if ((numbers[i - 1] < numbers[i]) && (numbers[i] > numbers[i + 1]))
            {
                Console.WriteLine("The number at position {0} is the first element of the" +
                                  " array larger than it's neighbours.", i);
                break;
            }
            else
            {
                Console.WriteLine("No such number: " + -1);
                break;
            }
        }
    }
}
