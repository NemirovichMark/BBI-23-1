//3
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[,] matrixB = new int[5, 5]
//        {
//            {1, 2, 3, 4, 5},
//            {6, 7, 8, 9, 10},
//            {11, 12, 13, 14, 15},
//            {16, 17, 18, 19, 20},
//            {21, 22, 23, 24, 25}
//        };

//        int[,] matrixC = new int[6, 6]
//        {
//            {1, 2, 3, 4, 5, 6},
//            {7, 8, 9, 10, 11, 12},
//            {13, 14, 15, 16, 17, 18},
//            {19, 20, 21, 22, 23, 24},
//            {25, 26, 27, 28, 29, 30},
//            {31, 32, 33, 34, 35, 36}
//        };

//        DeleteRowWithMaxDiagonalElement(matrixB);
//        DeleteRowWithMaxDiagonalElement(matrixC);

//        Console.WriteLine("Матрица B после удаления строки с максимальным элементом на диагонали:");
//        PrintMatrix(matrixB);

//        Console.WriteLine("Матрица C после удаления строки с максимальным элементом на диагонали:");
//        PrintMatrix(matrixC);
//    }

//    static void DeleteRowWithMaxDiagonalElement(int[,] matrix)
//    {
//        int maxDiagonalElement = FindMaxDiagonalElement(matrix);

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            if (matrix[i, i] == maxDiagonalElement)
//            {

//                for (int j = i; j < matrix.GetLength(0) - 1; j++)
//                {
//                    for (int k = 0; k < matrix.GetLength(1); k++)
//                    {
//                        matrix[j, k] = matrix[j + 1, k];
//                    }
//                }

//                break;
//            }
//        }
//    }

//    static int FindMaxDiagonalElement(int[,] matrix)
//    {
//        int maxElement = matrix[0, 0];

//        for (int i = 1; i < matrix.GetLength(0); i++)
//        {
//            if (matrix[i, i] > maxElement)
//            {
//                maxElement = matrix[i, i];
//            }
//        }

//        return maxElement;
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        Console.ReadLine();
//    }

//}

//9
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrixA = new int[6, 5] {
//            {-2, 1, -3, 4, 5},
//            {6, -7, 8, -9, 10},
//            {-11, 12, -13, 14, -15},
//            {16, 17, -18, 19, -20},
//            {-21, 22, -23, 24, -25},
//            {26, -27, 28, -29, 30}
//        };

//        int[,] matrixC = new int[7, 4] {
//            {-1, 2, -3, 4},
//            {5, -6, 7, -8},
//            {-9, 10, -11, 12},
//            {13, -14, 15, -16},
//            {-17, 18, -19, 20},
//            {21, -22, 23, -24},
//            {-25, 26, -27, 28}
//        };

//        int[] obmas = MergeArrays(matrixA, matrixC);

//        Console.WriteLine("Объединенный массив:");
//        PrintArray(obmas);
//    }

//    static int[] MergeArrays(int[,] matrixA, int[,] matrixC)
//    {
//        int stA = matrixA.GetLength(1);
//        int stC = matrixC.GetLength(1);
//        int[] obmas = new int[stA + stC];

//        int obmasIndex = 0;


//        for (int j = 0; j < stA; j++)
//        {
//            int stSum = 0;
//            for (int i = 0; i < matrixA.GetLength(0); i++)
//            {
//                if (matrixA[i, j] > 0)
//                {
//                    stSum += matrixA[i, j];
//                }
//            }
//            obmas[obmasIndex] = stSum;
//            obmasIndex++;
//        }


//        for (int j = 0; j < stC; j++)
//        {
//            int stSum = 0;
//            for (int i = 0; i < matrixC.GetLength(0); i++)
//            {
//                if (matrixC[i, j] > 0)
//                {
//                    stSum += matrixC[i, j];
//                }
//            }
//            obmas[obmasIndex] = stSum;
//            obmasIndex++;
//        }

//        return obmas;
//    }

//    static void PrintArray(int[] mass)
//    {
//        for (int i = 0; i < mass.Length; i++)
//        {
//            Console.Write(mass[i] + " ");
//        }
//        Console.WriteLine();
//        Console.ReadLine();
//    }
//}

//15
//using System;

//class Program
//{
//    static void Main()
//    {

//        int[,] matrix1 = {
//            {10, 5, 7},
//            {6, 12, 9},
//            {3, 8, 15}
//        };

//        int[,] matrix2 = {
//            {4, 1, 9},
//            {2, 7, 11},
//            {13, 6, 5}
//        };

//        int[,] matrix3 = {
//            {8, 3, 11},
//            {15, 2, 6},
//            {4, 9, 7}
//        };


//        double[] mass = {
//            CalculateAverage(matrix1),
//            CalculateAverage(matrix2),
//            CalculateAverage(matrix3)
//        };


//        bool vozr = CheckSequence(mass, true);
//        bool ybv = CheckSequence(mass, false);

//        Console.WriteLine("Средние значения элементов матриц:");
//        for (int i = 0; i < mass.Length; i++)
//        {
//            Console.WriteLine($"Матрица {i + 1}: {mass[i]}");
//        }

//        if (vozr)
//            Console.WriteLine("значения образуют возрастающую последовательность");
//        else if (ybv)
//            Console.WriteLine("значения образуют убывающую последовательность ");
//        else
//            Console.WriteLine("значения не образуют убывающую или возрастающую последовательность");
//        Console.ReadLine();
//    }


//    static double CalculateAverage(int[,] matrix)
//    {
//        int strok = matrix.GetLength(0);
//        int stolb = matrix.GetLength(1);

//        int sum = 0;
//        int count = 0;
//        int max = int.MinValue;
//        int min = int.MaxValue;


//        foreach (int value in matrix)
//        {
//            sum += value;
//            count++;

//            if (value > max)
//                max = value;

//            if (value < min)
//                min = value;
//        }


//        sum = sum - min - max;
//        count = count - 2;


//        return (double)sum / count;
//    }


//    static bool CheckSequence(double[] values, bool vozr)
//    {
//        for (int i = 1; i < values.Length; i++)
//        {
//            if (vozr)
//            {
//                if (values[i] <= values[i - 1])
//                    return false;
//            }
//            else
//            {
//                if (values[i] >= values[i - 1])
//                    return false;
//            }
//        }

//        return true;
//    }
//}

//номер 21
//using System;

//class Program
//{
//    static void Main()
//    {

//        int[,] matrix1 = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        int[,] matrix2 = {
//            { 9, 8, 7 },
//            { 6, 5, 4 },
//            { 3, 2, 1 }
//        };


//        int[] mass1 = GetMinimumsToRightOfDiagonal(matrix1);
//        int[] mass2 = GetMinimumsToRightOfDiagonal(matrix2);


//        Console.WriteLine("Массив 1:");
//        PrintArray(mass1);

//        Console.WriteLine("Массив 2:");
//        PrintArray(mass2);
//    }

//    static int[] GetMinimumsToRightOfDiagonal(int[,] matrix)
//    {
//        int n = matrix.GetLength(0); 
//        int[] mass = new int[n]; 


//        for (int i = 0; i < n; i++)
//        {
//            int min = matrix[i, i]; 
//            for (int j = i + 1; j < n; j++)
//            {
//                int a = matrix[i, j];
//                if (a < min)
//                {
//                    min = a;
//                }
//            }
//            mass[i] = min;
//        }

//        return mass;
//    }

//    static void PrintArray(int[] mass)
//    {
//        for (int i = 0; i < mass.Length; i++)
//        {
//            Console.Write(mass[i] + " ");
//        }
//        Console.WriteLine();
//        Console.ReadLine();
//    }
//}

//номер 27
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix1 = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        int[,] matrix2 = {
//            { 9, 8, 7 },
//            { 6, 5, 4 },
//            { 3, 2, 1 }
//        };

//        ReplaceMaxElements(matrix1);
//        ReplaceMaxElements(matrix2);

//        Console.WriteLine("Матрица 1 после замены:");
//        PrintMatrix(matrix1);

//        Console.WriteLine("Матрица 2 после замены:");
//        PrintMatrix(matrix2);
//    }

//    static void ReplaceMaxElements(int[,] matrix)
//    {
//        int strok = matrix.GetLength(0); 
//        int stolb = matrix.GetLength(1); 


//        for (int i = 1; i < strok; i += 2)
//        {
//            int max = matrix[i, 0];
//            int stolbIndex = 0; 

//            for (int j = 1; j < stolb; j++)
//            {
//                if (matrix[i, j] > max)
//                {
//                    max = matrix[i, j];
//                    stolbIndex = j;
//                }
//            }

//            matrix[i, stolbIndex] = 0;
//        }

//        for (int i = 0; i < strok; i += 2)
//        {
//            for (int j = 0; j < stolb; j++)
//            {
//                matrix[i, j] *= j + 1;
//            }
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int strok = matrix.GetLength(0); 
//        int stolb = matrix.GetLength(1); 

//        for (int i = 0; i < strok; i++)
//        {
//            for (int j = 0; j < stolb; j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();

//        }
//    Console.ReadLine();
//    }
//}

