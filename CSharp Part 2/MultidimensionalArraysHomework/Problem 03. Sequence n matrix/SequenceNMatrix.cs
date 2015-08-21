// Problem 3. Sequence n matrix
// We are given a matrix of strings of size N x M. Sequences in the matrix we define 
// as sets of several neighbour elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class SequenceNMatrix
{
    static void Main()
    {
        Console.WriteLine("This program finds the longest sequence of equal strings " +
                          "(on the same line, column or diagonal) in a matrix of size (N, M).");
        Console.Write("Please enter the size of N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter the size of M: ");
        int M = int.Parse(Console.ReadLine());
        string[,] matrix = new string[N, M];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.WriteLine("Please enter the values of row {0}, separated by space: ", row);
            string temp = Console.ReadLine();
            string[] cells = temp.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = cells[col];
            }
        }

        int numberOfMaxElements = 0;
        int currNumberOfElements = 0;
        string maxSequence = "";

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                // Checking the columns (down):
                currNumberOfElements = 0;
                for (int i = row + 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i - 1, col] == matrix[i, col])
                    {
                        currNumberOfElements++;
                    }

                    if (currNumberOfElements > numberOfMaxElements)
                    {
                        numberOfMaxElements = currNumberOfElements;
                        maxSequence = matrix[i, col];
                    }
                }
                
                // Checking the rows (right):
                currNumberOfElements = 0;
                for (int i = col + 1; i < matrix.GetLength(1); i++)
			    {
			        if (matrix[row, i - 1] == matrix[row, i])       
	                {
		                currNumberOfElements++;
	                }

                    if (currNumberOfElements > numberOfMaxElements)
	                {
                        numberOfMaxElements = currNumberOfElements;
                        maxSequence = matrix[row, i];
	                }
			    }

                // Checking the left diagonal:
                currNumberOfElements = 0;
                for (int i = row + 1, j = col + 1; (i < matrix.GetLength(0)) && (j < matrix.GetLength(1)); i++, j++)
                {
                    if (matrix[i - 1, j - 1] == matrix[i, j])
                    {
                        currNumberOfElements++;
                    }

                    if (currNumberOfElements > numberOfMaxElements)
                    {
                        numberOfMaxElements = currNumberOfElements;
                        maxSequence = matrix[i, j];
                    }
                }
                
                // Checking the right diagonal:
                currNumberOfElements = 0;
                for (int i = matrix.GetLength(0) - 2, j = col + 1; i >= 0 && j < matrix.GetLength(1); i--, j++)
                {
                    if (matrix[i + 1, j - 1] == matrix[i, j])
                    {
                        currNumberOfElements++;
                    }

                    if (currNumberOfElements > numberOfMaxElements)
                    {
                        numberOfMaxElements = currNumberOfElements;
                        maxSequence = matrix[i, j];
                    }
                }
            }
        }
        Console.Write("Best sequence is: ");
        for (int i = 0; i <= numberOfMaxElements; i++)
        {
            Console.Write(maxSequence);
            if (i != numberOfMaxElements)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}