using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project
{
    class Program
    {
        static void Main()
        {
            int n = 0;
            int m = 0;
            #region 1-2
            /*Console.WriteLine("1-2:");
            double n = 5; double m = 7;
            double[,] arr = new double[(int)n, (int)m];
            int su = 0;
            double temp = 0;
            Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = mass[j];
                    if (mass[j] > 0)
                    {
                        su += mass[j];
                        temp++;
                    }
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            su = su / temp;
            Console.WriteLine("Сумма элементов массива:");
            Console.WriteLine(su);
            Console.WriteLine();*/
            #endregion

            #region 1 - 6
            /*Console.WriteLine("");
            matrix = new int[4, 7] {
            {-3, 7, 2, 8, 5, 9, 1},
            {4, 6, 2, 9, 1, 5, 3},
            {9, 2, 6, 4, 8, 1, 7},
            {5, 3, 1, 7, 9, 2, 6}
        };

            int[] minInd = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int minI = 0;
                int minV = matrix[i, 0];

                for (int j = 1; j < 7; j++)
                {
                    if (matrix[i, j] < minV)
                    {
                        minV = matrix[i, j];
                        minI = j;
                    }
                }

                minInd[i] = minI;
            }

            Console.WriteLine("Минимальные индексы в каждой строке:");
            Console.WriteLine("[{0}]", string.Join(';', minInd));*/
            #endregion

            #region 1 - 10
            /*matrix = new int[5, 7] {
            {3, 7, 2, 9, 5, 9, 1},
            {4, 6, 2, 9, 1, 5, 3},
            {9, 2, 6, 3, 2, 7, 7},
            {5, 4, 5, 6, 5, 2, 6},
            {2, 4, 7, 2, 3, 5, 8}
        };

            int maxI = matrix[0, 2];
            int maxR = 0;
            for (int i = 1; i < 5; i++)
            {
                if (matrix[i, 2] > maxI)
                {
                    maxI = matrix[i, 2];
                    maxR = i;
                }
            }


            for (int j = 0; j < 7; j++)
            {
                int temp = matrix[3, j];
                matrix[3, j] = matrix[maxR, j];
                matrix[maxR, j] = temp;
            }

            Console.WriteLine("Матрица после замены строк:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            #endregion

            #region 1 - 14
            /* n = 4; m = 3;
             int[] array1 = new int[m];
             arr = new double[n, m];
             int tempura = 0;
             ind = 0;
             Console.WriteLine("Введите матрицу: 4 строки по 3 эллемента,через пробел:");
             for (int i = 0; i < n; i++)
             {
                 str = Console.ReadLine();
                 double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                 for (int j = 0; j < m; j++)
                 {
                     arr[i, j] = mass[j];
                 }
             }
             for (int j = 0; j < m; j++)
             {
                 for (int i = 0; i < n; i++)
                 {
                     if (arr[i, j] < 0)
                     {
                         tempura++;
                     }
                 }
                 array1[j] = tempura;
                 tempura = 0;
             }
             Console.WriteLine("Исходная матрица:");
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     Console.Write(arr[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();
             Console.WriteLine("Полученный массив кол-ва отр значений:");
             Console.WriteLine("[{0}]", string.Join(';', array));
             Console.WriteLine();*/
            #endregion

            #region 1 - 18 
            /*Console.WriteLine("1.18");
            matrix = new int[4, 3] {
            {3, 7,- 2},
            {-4, 6, 2},
            {9, -2, 6},
            {5, 3, -1}
        };

            for (int i = 0; i < 4; i++)
            {
                int maxIndex = -1;
                int l = -1;
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        l = j;
                        break;
                    }
                    if (maxIndex == -1 || matrix[i, j] > matrix[i, maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                if (l != -1 && maxIndex != -1)
                {
                    int temp = matrix[i, maxIndex];
                    matrix[i, maxIndex] = matrix[i, l];
                    matrix[i, l] = temp;
                }
            }

            Console.WriteLine("Измененная матрица:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }*/
            #endregion

            #region 1 - 22
            /*int[,] Z = new int[6, 8]
                   {
            {1, -2, 6, -4, -5, 6, -7, 8},
            {9, -10, 11, 12, 13, 14, -15, 16},
            {17, -18, 19, 20, -21, -22, 23, -24},
            {25, 26, -27, -28, -29, 12, -31, 32},
            {33, -12, 35, -36, 37, 38, -39, 40},
            {41, -42, 43, 44, -45, 46, 47, 50}
                   };
            Console.WriteLine("исходная матрица");
            for (int i = 0; i < Z.GetLength(0); i++)
            {
                for (int j = 0; j < Z.GetLength(1); j++)
                {
                    Console.Write(Z[i, j] + " ");
                }
                Console.WriteLine();
            }
            int max = Z[0, 0];
            sum = 0;
            int c = 0;


            for (int i = 0; i < Z.GetLength(0); i++)
            {
                for (int j = 0; j < Z.GetLength(1); j++)
                {
                    if (Z[i, j] > max)
                    {
                        max = Z[i, j];
                    }
                    if (Z[i, j] > 0)
                    {
                        sum += Z[i, j];
                        c++;
                    }
                }
            }


            if (c > 0)
            {
                int av = sum / c;
                for (int i = 0; i < Z.GetLength(0); i++)
                {
                    for (int j = 0; j < Z.GetLength(1); j++)
                    {
                        if (Z[i, j] == max)
                        {
                            Z[i, j] = av;
                        }
                    }
                }
            }

            Console.WriteLine("полученная матрица");
            for (int i = 0; i < Z.GetLength(0); i++)
            {
                for (int j = 0; j < Z.GetLength(1); j++)
                {
                    Console.Write(Z[i, j] + " ");
                }
                Console.WriteLine();
            }
*/
            #endregion

            #region 1 - 26 
            /*int[,] A = new int[5, 7]
      {
            {1, 2, 3, 4, 5, 6, 7},
            {8, 9, 10, 11, 12, 13, 14},
            {15, 16, 17, 18, 19, 20, 21},
            {22, 23, 24, 25, 26, 27, 28},
            {29, 30, 31, 32, 33, 34, 35}
      };

            int[] B = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            int maxe = A[0, 6];
            int imax = 0;

            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, 6] > maxe)
                {
                    maxe = A[i, 6];
                    imax = i;
                }
            }

            for (int j = 0; j < A.GetLength(1); j++)
            {
                A[imax, j] = B[j];
            }


            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            #endregion

            #region 1 - 30 
            /*matrix = new int[5, 5]
        {
            {1, 2, 3, 4, 5},
            {6, 7, 8, 9, 10},
            {11, 12, -13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
        };

            int maxd = matrix[0, 0];
            imax = 0;
            for (int i = 1; i < 5; i++)
            {
                if (matrix[i, i] > maxd)
                {
                    maxd = matrix[i, i];
                    imax = i;
                }
            }
            int neg = -1;
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 2] < 0)
                {
                    neg = i;
                    break;
                }
            }

            if (neg != -1)
            {
                for (int j = 0; j < 5; j++)
                {
                    int temp = matrix[neg, j];
                    matrix[neg, j] = matrix[imax, j];
                    matrix[imax, j] = temp;
                }
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }*/
            #endregion

            #region 2 - 1 
            /*Console.WriteLine("2.1");
            int[,] a = {
            {-1, -2, -3, -4, 0, -6, -7},
            {8, 9, 10, 11, 12, 13, 14},
            {15, 16, 17, 18, 19, 20, 21},
            {22, 23, 90, -25, 26, 27, 28},
            {100, 30, 31, 32, 33, 34, 35}
        };

            Console.WriteLine("исходная матрица:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int maxIndex = 0;
                max = a[i, maxIndex];

                for (int j = 1; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        maxIndex = j;
                    }
                }

                if (maxIndex > 0 && maxIndex < a.GetLength(1) - 1)
                {
                    if (a[i, maxIndex - 1] < a[i, maxIndex + 1])
                    {
                        a[i, maxIndex - 1] *= 2;
                    }
                    else
                    {
                        a[i, maxIndex + 1] *= 2;
                    }
                }
                else if (maxIndex == 0)
                {
                    a[i, maxIndex + 1] *= 2;
                }
                else
                {
                    a[i, maxIndex - 1] *= 2;
                }
            }

            Console.WriteLine("полученная матрица:");*/
            #endregion

            #region 2 - 5
            /*n = 7; m = 5;
            arr = new double[n, m];
            D = new int[n];
            max = -100000000000000;
            ind = 0; su = 0;
            Console.WriteLine("Введите матрицу: 7 строк по 5 эллементов,через пробел:");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = mass[j];
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[j, i] > max)
                    {
                        max = arr[i, j];
                        ind = j;
                    }
                }
                D[i] = ind;
                ind = 0;
                max = -10000000000000000;
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                su = (arr[0, i] + arr[(n - 1), i]) / 2;
                if (arr[D[i], i] < su)
                {
                    arr[D[i], i] = su;
                }
                else
                {
                    arr[D[i], i] = D[i];
                }
            }
            Console.WriteLine("Конечная матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();*/
            #endregion

            #region 2 - 9
            /*// Создаем матрицу 6x7
            int[,] matrix = new int[6, 7]
            {
            {1, 2, 3, 4, 5, 6, 7},
            {8, 9, 10, 11, 12, 13, 14},
            {15, 16, 17, 18, 19, 20, 21},
            {22, 23, 24, 25, 26, 27, 28},
            {29, 30, 31, 32, 33, 34, 35},
            {36, 37, 38, 39, 40, 41, 42}
            };

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            // Переставляем элементы строк в обратном порядке
            ReverseRows(matrix);

            Console.WriteLine("\nМатрица после перестановки:");
            PrintMatrix(matrix);

            Console.ReadLine();
        }

        static void ReverseRows(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows / 2; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Обмениваем элементы строк в обратном порядке
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[rows - 1 - i, j];
                    matrix[rows - 1 - i, j] = temp;
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }*/
            #endregion

            #region 3 - 2
            /*Console.WriteLine("Введите кол-во строк:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов:");
            int n2 = int.Parse(Console.ReadLine());
            arr = new double[n1, n2];
            C = new double[n1, n2];
            Console.WriteLine("Введите матрицу: " + n1 + " строк по " + n2 + " эллементов,через пробел:");
            for (int i = 0; i < n1; i++)
            {
                str = Console.ReadLine();
                double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < n2; j++)
                {
                    arr[i, j] = mass[j];
                    if (i == 0 || j == 0 || i == (n1 - 1) || j == (n2 - 1))
                    {
                        C[i, j] = 0;
                    }
                    else
                    {
                        C[i, j] = arr[i, j];
                    }
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Конечная матрица");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();*/
            #endregion

            #region 3 - 1 
            /*matrix = new int[7, 5]
       {
            {3, 7, 1, 4, 9},
            {6, 2, 8, 9, 5},
            {11, 1, 13, 14, 15},
            {16, 17, 2, 19, 20},
            {21, 22, 23, 4, 25},
            {26, 27, 3, 29, 30},
            {31, 32, 33, 34, 1}
       };


            int[] minVv = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                minVv[i] = min;
            }


            for (int i = 0; i < minVv.Length - 1; i++)
            {
                for (int j = 0; j < minVv.Length - i - 1; j++)
                {
                    if (minVv[j] > minVv[j + 1])
                    {

                        for (int k = 0; k < matrix.GetLength(1); k++)
                        {
                            int temp = matrix[j, k];
                            matrix[j, k] = matrix[j + 1, k];
                            matrix[j + 1, k] = temp;
                        }


                        int t = minVv[j];
                        minVv[j] = minVv[j + 1];
                        minVv[j + 1] = t;
                    }
                }
            }
            Console.WriteLine("полученная матрица");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }*/
            #endregion 





        }
    }
}