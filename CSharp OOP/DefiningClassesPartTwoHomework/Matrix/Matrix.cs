using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T> where T : IComparable
    {
        // Fields
        private T[,] matrix;
        private int row;
        private int col;
        // Constructor
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.matrix = new T[row, col];
        }
        //Property
        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("Rows and Columns must be non-negative numbers!");
                }
                return this.matrix[row, col];
            }
            set
            {
                if (row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("Rows and Columns must be non-negative numbers!");
                }
                this.matrix[row, col] = value;
            }
        }
        // 
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.matrix.GetLength(0) == secondMatrix.matrix.GetLength(0)) &&
                (firstMatrix.matrix.GetLength(1) == secondMatrix.matrix.GetLength(1)))
            {
                int rows = firstMatrix.matrix.GetLength(0);
                int cols = firstMatrix.matrix.GetLength(1);
                Matrix<T> result = new Matrix<T>(rows, cols);

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        result[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException("The two matrices have different dimensions and they can not be added!");
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.matrix.GetLength(0) == secondMatrix.matrix.GetLength(0)) &&
                (firstMatrix.matrix.GetLength(1) == secondMatrix.matrix.GetLength(1)))
            {
                int rows = firstMatrix.matrix.GetLength(0);
                int cols = firstMatrix.matrix.GetLength(1);
                Matrix<T> result = new Matrix<T>(rows, cols);

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        result[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException("The two matrices have different dimensions and they can not be added!");
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(1) == secondMatrix.matrix.GetLength(0))
            {
                int rows = firstMatrix.matrix.GetLength(0);
                int cols = secondMatrix.matrix.GetLength(1);
                Matrix<T> result = new Matrix<T>(rows, cols);

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        T temp = (dynamic)0;
                        for (int i = 0; i < cols; i++)
                        {
                            temp += (dynamic)firstMatrix[row, i] * secondMatrix[i, col];
                        }
                        result[row, col] = temp;
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException("The columns of the first matrix must be equal to the rows of the second matrix!");
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return CheckForTrueOrFalse(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return CheckForTrueOrFalse(matrix);
            
        }

        private static bool CheckForTrueOrFalse(Matrix<T> matrix)
        {
            bool result = false;
            int rows = matrix.matrix.GetLength(0);
            int cols = matrix.matrix.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
