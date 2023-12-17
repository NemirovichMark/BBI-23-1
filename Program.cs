
#region 3
class Program
{
    static void Main()
    {
        double[,] a = new double[5, 5];
        double[,] b = new double[6, 6];

        FillMatrix(a);
        Console.WriteLine("Матрица A до удаления строки с максимальным элементом диагонали:");
        PrintMatrix(a);

        FillMatrix(b);
        Console.WriteLine("Матрица B до удаления строки с максимальным элементом диагонали:");
        PrintMatrix(b);

        RemoveMax(ref a);
        RemoveMax(ref b);

        Console.WriteLine("Матрица A после удаления строки с максимальным элементом диагонали:");
        PrintMatrix(a);

        Console.WriteLine("Матрица B после удаления строки с максимальным элементом диагонали:");
        PrintMatrix(b);
    }

    static void FillMatrix(double[,] matrix)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(10);
            }
        }
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void RemoveMax(ref double[,] matrix)
    {
        int maxIndex = FindMaxElement(matrix);
        if (maxIndex != -1)
        {
            int rowCount = matrix.GetLength(0) - 1;
            double[,] newMatrix = new double[rowCount, matrix.GetLength(1)];

            for (int i = 0, newRow = 0; i < matrix.GetLength(0); i++)
            {
                if (i != maxIndex)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        newMatrix[newRow, j] = matrix[i, j];
                    }
                    newRow++;
                }
            }

            matrix = newMatrix;
        }
    }

    static int FindMaxElement(double[,] matrix)
    {
        double maxElement = double.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > maxElement)
            {
                maxElement = matrix[i, i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }
}

#endregion

#region 9

class Program
{
    static void Main()
    {
        int[,] a = new int[6, 5];
        int[,] c = new int[7, 4];

        FillMatrix(a);
        FillMatrix(c);

        Console.WriteLine("Матрица A");
        PrintMatrix(a);

        Console.WriteLine("Матрица C");
        PrintMatrix(c);

        int[] array = SumMatrix(a).Concat(SumMatrix(c)).ToArray();

        Console.WriteLine("Суммы положительных элементов столбцов матриц A и C");
        PrintArray(array);
    }

    static void FillMatrix(int[,] matrix)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(-10, 10);
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int[] SumMatrix(int[,] matrix)
    {
        int[] result = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] > 0)
                {
                    sum += matrix[i, j];
                }
            }
            result[j] = sum;
        }
        return result;
    }
}

#endregion

#region 15

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = 5, m = 6;
        double[,] a = new double[n, m];
        fillmatrix(a);
        Console.WriteLine("Матрица A:");
        printMatrix(a);

        double[,] b = new double[n, m];
        fillmatrix(b);
        Console.WriteLine("Матрица B:");
        printMatrix(b);

        double[,] c = new double[n, m];
        fillmatrix(c);
        Console.WriteLine("Матрица C:");
        printMatrix(c);

        double[] array = { sumMatrix(a), sumMatrix(b), sumMatrix(c) };
        Console.WriteLine("Средние значения матриц: ");
        printArray(array);
        if (array[0] > array[1] && array[1] > array[2])
        {
            Console.WriteLine("Полученные значения образуют убывающую последовательность");
        }
        else if (array[0] < array[1] && array[1] < array[2])
        {
            Console.WriteLine("Полученные значения образуют возрастающую последовательность");
        }
        else
        {
            Console.WriteLine("Полученные значения не образуют последовательность");
        }
    }

    static void fillmatrix(double[,] matrix)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(-9, 9);
            }
        }
    }

    static void printMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void printArray(double[] array)
    {
        foreach (double element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static double sumMatrix(double[,] matrix)
    {
        double[] elements = new double[matrix.GetLength(0) * matrix.GetLength(1)];
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                elements[index++] = matrix[i, j];
            }
        }
        double max = elements.Max();
        double min = elements.Min();
        double sum = elements.Sum() - max - min;
        sum /= (elements.Length - 2);
        return sum;
    }
}

#endregion

#region 21

class Program
{
    static void Main()
    {
        int n = 5;

        double[,] a = new double[n, n];
        fillMatrix(a);
        Console.WriteLine("Матрица А");
        printMatrix(a);

        double[,] b = new double[n, n];
        fillMatrix(b);
        Console.WriteLine("Матрица В");
        printMatrix(b);

        double[] arrayA = minArray(a);
        Console.WriteLine("Массив, состоящий из минимальных элементов строк матрицы А справа от главной диагонали и включающий её");
        printArray(arrayA);

        double[] arrayB = minArray(b);
        Console.WriteLine("Массив, состоящий из минимальных элементов строк матрицы В справа от главной диагонали и включающий её");
        printArray(arrayB);
    }

    static void fillMatrix(double[,] matrix)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(-9, 9);
            }
        }
    }

    static void printMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void printArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static double[] minArray(double[,] matrix)
    {
        int size = matrix.GetLength(0);
        double[] resultArray = new double[size];
        for (int i = 0; i < size; i++)
        {
            double min = double.MaxValue;
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
            resultArray[i] = min;
        }
        return resultArray;
    }
}

#endregion

#region 27
class Sistem
{
    static void Main()
    {
        int n = 5, m = 8;

        double[,] a = new double[n, m];
        fillMatrix(a);
        Console.WriteLine("Матрица А");
        printMatrix(a);

        double[,] b = new double[n, m];
        fillMatrix(b);
        Console.WriteLine("Матрица В");
        printMatrix(b);

        minelement(a);
        Console.WriteLine("Изменённая матрица А");
        printMatrix(a);

        minelement(b);
        Console.WriteLine("Изменённая матрица В");
        printMatrix(b);
    }

    static void fillMatrix(double[,] matrix)
    {
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = random.Next(-9,9);
            }
        }
    }

    static void printMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void minelement(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            double max = double.MinValue;
            int jmax = 0;
            if (i % 2 == 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j]; 
                        jmax = j;
                    }
                }
                matrix[i, jmax] = 0;
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        jmax = j;
                    }
                }
                matrix[i, jmax] *= (jmax + 1);
            }
        }
    }
}
#endregion
