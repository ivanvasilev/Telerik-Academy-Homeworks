//Problem 5. Maximal area sum

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:

//input	            output
//4 
//2 3 3 4 
//0 2 3 4 
//3 7 1 2   
//4 3 3 2	         17

using System;
using System.IO;
class MaximalAreaSum
{
    static void Main()
    {
        Console.WriteLine("This program that reads a text file containing a square matrix of numbers and " +
                          "finds the area of size 2 x 2 in the matrix, with a maximal sum of its elements" +
                          " and saves the result in a text file.");
        Console.Write("Enter the size of the matrix: ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int[,] newMatrix = new int[size, size];

        StreamWriter writer = new StreamWriter("..//..//Matrix.txt");

        using (writer)
        {
            writer.WriteLine(size);

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("Enter Element matrix[{0},{1}]=", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                    writer.Write(matrix[row, col] + " ");

                }
                writer.WriteLine();
            }
        }

        StreamReader matrixOutput = new StreamReader("..//..//Matrix.txt");
        using (matrixOutput)
        {
            string reader = matrixOutput.ReadLine();
            int length = int.Parse(reader);

            reader = matrixOutput.ReadLine();
            while (reader != null)
            {
                for (int p = 0; p < length; p++)
                {
                    for (int q = 0; q < length; q++)
                    {
                        string number = String.Empty;
                        for (int i = 0; i < reader.Length; i++) 
                        {
                            if (reader[i] == ' ')
                            {
                                newMatrix[p, q] = int.Parse(number);
                                number = String.Empty;
                                q++;
                            }
                            else
                            {
                                number += reader[i];
                            }
                        }
                    }
                    reader = matrixOutput.ReadLine();
                }
            }
        }
        StreamWriter result = new StreamWriter("..//..//Result.txt");
        using (result)
        {
            result.WriteLine("The Biggest Sum is: {0}", BestSum(newMatrix));
        }
        Console.WriteLine("You can find all results and text files in the folders of the different projects!");
    }

    static int BestSum(int[,] matrix)
    {
        int sum = 0;
        int bestSum = 0;
        for (int row = 0; row < matrix.GetLongLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1) - 1; col++)
            {
                sum = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int p = 0; p < 2; p++)
                    {
                        sum += matrix[row + i, col + p];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
        return bestSum;
    }
}

