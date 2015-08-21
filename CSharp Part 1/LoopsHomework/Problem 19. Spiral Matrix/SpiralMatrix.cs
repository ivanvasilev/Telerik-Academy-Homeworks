// Problem 19.** Spiral Matrix
// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
// and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Please enter an integer number between 1 and 20: ");
        int N = int.Parse(Console.ReadLine());
        int[,] spiral = new int[N, N];

        string direction = "right";
        int currentRow = 0;
        int currentCol = 0;
        if (N <= 0 || N > 20)
        {
            Console.WriteLine("Invalid number!\nPlease start the program again and enter valid number between 1 and 20.");
        }
        else
        {
            Console.WriteLine("matrix");
            for (int i = 1; i <= N * N; i++)
            {
                if (direction == "right" && (currentCol >= N || spiral[currentRow, currentCol] != 0))
                {
                    currentCol--;
                    currentRow++;
                    direction = "down";
                }
                else if (direction == "down" && (currentRow >= N || spiral[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    currentCol--;
                    direction = "left";
                }
                else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
                {
                    currentCol++;
                    currentRow--;
                    direction = "up";
                }
                else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
                {
                    currentRow++;
                    currentCol++;
                    direction = "right";
                }

                spiral[currentRow, currentCol] = i;

                if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,3} ", spiral[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}