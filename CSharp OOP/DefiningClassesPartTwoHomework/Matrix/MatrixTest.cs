using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixTest
    {
        static void Main(string[] args)
        {
            // Making a matrix and adding values to its elements
            Matrix<int> first = new Matrix<int>(2, 2);
            first[0, 0] = 1;
            first[0, 1] = 2;
            first[1, 0] = 3;
            first[1, 1] = 4;
            // Printing the values of the elements in the first matrix
            Console.WriteLine("The values of the elements in the first matrix are:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Element[{0},{1}]: {2}", i, j, first[i, j]);
                }
            }
            // Making a second matrix and adding values to its elements
            Matrix<int> second = new Matrix<int>(2, 2);
            second[0, 0] = 5;
            second[0, 1] = 6;
            second[1, 0] = 7;
            second[1, 1] = 8;
            // Printing the values of the elements in the second matrix
            Console.WriteLine("The values of the elements in the second matrix are:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Element[{0},{1}]: {2}", i, j, second[i, j]);
                }
            }
            // Testing the * operator
            Matrix<int> result = first * second;
            Console.WriteLine("Result after multiplying the two matrices: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Element[{0},{1}]: {2}", i, j, result[i, j]);
                }
            }
            // Testing the + operator
            Matrix<int> secondResult = first + second;
            Console.WriteLine("Result after adding the two matrices: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Element[{0},{1}]: {2}", i, j, secondResult[i, j]);
                }
            }
            // Testing the - operator
            Matrix<int> thirdResult = first - second;
            Console.WriteLine("Result after substracting the second matrix from the first: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Element[{0},{1}]: {2}", i, j, thirdResult[i, j]);
                }
            }

            Matrix<int> fourthResult = second - first;
            Console.WriteLine("Result after substracting the first matrix from the second: ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Element[{0},{1}]: {2}", i, j, fourthResult[i, j]);
                }
            }
            // Testing the true and false operators
            Console.WriteLine("Is the value of element[0, 0] = 1: {0}", first[0, 0] == 1);
            Console.WriteLine("Is the value of element[0, 0] = 0: {0}", first[0, 0] == 0);
        }
    }
}
