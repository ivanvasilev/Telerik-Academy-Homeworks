// Problem 3. Min, Max, Sum and Average of N Numbers
// Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
// the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
// The output is like in the examples below.

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want the program to calculate: ");
        int count = int.Parse(Console.ReadLine());
        if (count < 1)
        {
            Console.WriteLine("No numbers to add.\nPlease start the program again and enter another number.");
        }
        else
        {
            int input = 0;
            int sum = 0;
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            Console.WriteLine("Enter {0} numbers: ", count); 

            for (int i = 1; i <= count; i++)
            {
                input = int.Parse(Console.ReadLine()); 

                sum += input;

                if (input > maxValue)
                {
                    maxValue = input;
                }
                if (input < minValue)
                {
                    minValue = input;
                }
            }
            double average = (double)sum / count;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2} ", minValue, maxValue, sum, average);
        }
    }
}
