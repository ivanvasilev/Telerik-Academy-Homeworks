// Problem 2. Maximal sum
// Write a program that reads a rectangular matrix of size N x M 
// and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("This program reads a rectangular matrix of size N x M " +
                          "and finds in it the square 3 x 3 that has maximal sum of its elements.");
        Console.Write("Please enter the size of N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter the size of M: ");
        int M = int.Parse(Console.ReadLine());
        int[,] numbers = new int[N, M];

        for (int row = 0; row < numbers.GetLength(0); row++)
        {
            Console.WriteLine("Please enter the values of row {0}, separated by space: ", row);
            string temp = Console.ReadLine();
            string[] cells = temp.Split(' ');
            for (int col = 0; col < numbers.GetLength(1); col++)
            {
                numbers[row, col] = int.Parse(cells[col]);
            }
        }

        if (numbers.GetLength(0) < 3 || numbers.GetLength(1) < 3)
        {
            Console.WriteLine("Not a valid matrix.\n" +
                "The lengths of the columns and rows must be equal or greater that 3.");
            return;
        }
        int bestRow = 0;
        int bestCol = 0;
        int bestSum = numbers[0, 0] + numbers[0, 1] + numbers[0, 2] +
                             numbers[1, 0] + numbers[1, 1] + numbers[1, 2] +
                             numbers[2, 0] + numbers[2, 1] + numbers[2, 2];
        for (int row = 0; row < numbers.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < numbers.GetLength(1) - 2; col++)
            {
                int newSum = numbers[row, col] + numbers[row, col + 1] + numbers[row, col + 2] +
                             numbers[row + 1, col] + numbers[row + 1, col + 1] + numbers[row + 1, col + 2] +
                             numbers[row + 2, col] + numbers[row + 2, col + 1] + numbers[row + 2, col + 2];
                if (newSum > bestSum)
                {
                    bestSum = newSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("Best sum in the matrix is: {0}", bestSum);
        Console.WriteLine("Best matrix is:");
        Console.WriteLine("{0}, {1}, {2}", numbers[bestRow, bestCol], 
                                           numbers[bestRow, bestCol + 1], 
                                           numbers[bestRow, bestCol + 2]);
        Console.WriteLine("{0}, {1}, {2}", numbers[bestRow + 1, bestCol], 
                                           numbers[bestRow + 1, bestCol + 1], 
                                           numbers[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0}, {1}, {2}", numbers[bestRow + 2, bestCol], 
                                           numbers[bestRow + 2, bestCol + 1], 
                                           numbers[bestRow + 2, bestCol + 2]);
    }
}