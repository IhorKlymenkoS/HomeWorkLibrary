using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public class MultiDimentionalArraysHelper
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static(int, int) MinI(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Matrix is null");
            }
            int minI1 = 0;
            int minI2 = 0;
            int min = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        minI1 = i;
                        minI2 = j;
                        min = matrix[i, j];
                    }
                }
            }

            return (minI1, minI2);
        }

        public static(int, int) MaxI(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Matrix is null");
            }
            int maxI1 = 0;
            int maxI2 = 0;
            int max = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        maxI1 = i;
                        maxI2 = j;
                        max = matrix[i, j];
                    }
                }
            }

            return (maxI1, maxI2);
        }

        public static int Min(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Matrix is null");
            }
            (int minI1, int minI2) = MinI(matrix);
            return matrix[minI1, minI2];
        }

        public static int Max(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Matrix is null");
            }
            (int maxI1, int maxI2) = MaxI(matrix);
            return matrix[maxI1, maxI2];
        }

        public static void FlipAongLine(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Matrix is null");
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    Swap(ref matrix[i, j], ref matrix[j, i]);
                }
            }
        }

        public static int GetLargestCells(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Matrix is null");
            }
            int result = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > 0 && matrix[i, j] <= matrix[i - 1, j])
                    {
                        continue;
                    }

                    if (i < (matrix.GetLength(0) - 1) &&
                        matrix[i, j] <= matrix[i + 1, j])
                    {
                        continue;
                    }

                    if (j > 0 && matrix[i, j] <= matrix[i, j - 1])
                    {
                        continue;
                    }

                    if (j < (matrix.GetLength(1) - 1) &&
                        matrix[i, j] <= matrix[i, j + 1])
                    {
                        continue;
                    }

                    ++result;
                }
            }

            return result;
        }
    }
}
