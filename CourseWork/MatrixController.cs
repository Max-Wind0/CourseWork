using System;

namespace CourseWork
{
    internal class MatrixController
    {
        /// <summary>
        /// Функция для решения СЛАУ
        /// </summary>
        public static double[] SolveMatrix(double[,] A, double[] B)
        {
            // Решение СЛАУ A * res = B
            // Предполагается, что матрица А квадратная и обратимая
            int n = A.GetLength(0);
            double[,] AInverse = MatrixInverse(A);
            double[] res = new double[n];
            for (int i = 0; i < n; i++)
            {
                double sum = 0.0;
                for (int j = 0; j < n; j++)
                {
                    sum += AInverse[i, j] * B[j];
                }
                res[i] = sum;
            }
            return res;
        }

        /// <summary>
        /// Функция инвертирования матрицы методом Гаусса-Жордана
        /// </summary>
        static double[,] MatrixInverse(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] augmentedMatrix = new double[n, 2 * n];
            double[,] inverse = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmentedMatrix[i, j] = matrix[i, j];
                    augmentedMatrix[i, j + n] = (i == j) ? 1.0 : 0.0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int pivotRow = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Math.Abs(augmentedMatrix[j, i]) > Math.Abs(augmentedMatrix[pivotRow, i]))
                    {
                        pivotRow = j;
                    }
                }

                if (pivotRow != i)
                {
                    for (int k = 0; k < 2 * n; k++)
                    {
                        double temp = augmentedMatrix[i, k];
                        augmentedMatrix[i, k] = augmentedMatrix[pivotRow, k];
                        augmentedMatrix[pivotRow, k] = temp;
                    }
                }

                double pivot = augmentedMatrix[i, i];
                for (int j = 0; j < 2 * n; j++)
                {
                    augmentedMatrix[i, j] /= pivot;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = augmentedMatrix[k, i];
                        for (int j = 0; j < 2 * n; j++)
                        {
                            augmentedMatrix[k, j] -= factor * augmentedMatrix[i, j];
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inverse[i, j] = augmentedMatrix[i, j + n];
                }
            }

            return inverse;
        }
    }
}
