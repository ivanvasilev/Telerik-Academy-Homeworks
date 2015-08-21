using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2ExamRefactoring
{
    class LoverOfThree
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            int updater = rows;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int valueOfTheCell = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ((updater - 1) * 3) + valueOfTheCell;
                    valueOfTheCell += 3;
                }
                updater -= 1;
            }

            int n = int.Parse(Console.ReadLine());

            string[] cypher = new string[n];

            for (int i = 0; i < cypher.Length; i++)
            {
                cypher[i] = Console.ReadLine();
            }

            int row = rows - 1;
            int col = 0;
            int moves = 0;
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (cypher[i].Substring(0, 2) == "UR" || cypher[i].Substring(0, 2) == "RU")
                {
                    moves = int.Parse(cypher[i].Substring(3, cypher[i].Length - 3));
                    for (int j = 0; j < moves; j++)
                    {
                        if ((row >= 0 && row < rows) && (col >= 0 && col < cols))
                        {
                            sum += matrix[row, col];
                            matrix[row, col] = 0;
                            row -= 1;
                            col += 1;
                        }
                    }
                    row += 1;
                    col -= 1;
                }

                if (cypher[i].Substring(0, 2) == "UL" || cypher[i].Substring(0, 2) == "LU")
                {
                    moves = int.Parse(cypher[i].Substring(3, cypher[i].Length - 3));
                    for (int j = 0; j < moves; j++)
                    {
                        if ((row >= 0 && row < rows) && (col >= 0 && col < cols))
                        {
                            sum += matrix[row, col];
                            matrix[row, col] = 0;
                            row -= 1;
                            col -= 1;
                        }
                    }
                    row += 1;
                    col += 1;
                }

                if (cypher[i].Substring(0, 2) == "DL" || cypher[i].Substring(0, 2) == "LD")
                {
                    moves = int.Parse(cypher[i].Substring(3, cypher[i].Length - 3));
                    for (int j = 0; j < moves; j++)
                    {
                        if ((row >= 0 && row < rows) && (col >= 0 && col < cols))
                        {
                            sum += matrix[row, col];
                            matrix[row, col] = 0;
                            row += 1;
                            col -= 1;
                        }
                    }
                    row -= 1;
                    col += 1;
                }

                if (cypher[i].Substring(0, 2) == "DR" || cypher[i].Substring(0, 2) == "RD")
                {
                    moves = int.Parse(cypher[i].Substring(3, cypher[i].Length - 3));
                    for (int j = 0; j < moves; j++)
                    {
                        if ((row >= 0 && row < rows) && (col >= 0 && col < cols))
                        {
                            sum += matrix[row, col];
                            matrix[row, col] = 0;
                            row += 1;
                            col += 1;
                        }
                    }
                    row -= 1;
                    col -= 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

