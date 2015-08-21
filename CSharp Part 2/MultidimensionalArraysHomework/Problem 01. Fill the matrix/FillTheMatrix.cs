// Problem 1. Fill the matrix
// Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("This program fills and prints a matrix of size (n, n).");
        Console.Write("Please enter the size of n: ");
        int n = int.Parse(Console.ReadLine());
        int temp = 0;
        int[,] matrix = new int[n,n];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + 1 + temp;
                temp += n;
                Console.Write("{0,3}", matrix[row, col]);
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write(", "); 
                }
            }
            Console.WriteLine();
            temp = 0;
        }
    }
}