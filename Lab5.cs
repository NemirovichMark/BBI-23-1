#region 4
/*
using System;

class Program
{
    static int[,] ReadMatrica(int n)
    {
        int[,] matrica = new int[n, n];
        Console.WriteLine($"Введите, пожалуйста, элементы матрицы {n} x {n} через пробел:");
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrica[i, j] = int.Parse(input[j]);
            }
        }
        return matrica;
    }

    static void PrintMatrica(int[,] matrica, int n)
    {
        Console.WriteLine("Матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int FindMaxDiag(int[,] matrica, int n)
    {
        int maxEl = matrica[0, 0];
        for (int i = 1; i < n; i++)
        {
            if (matrica[i, i] > maxEl)
            {
                maxEl = matrica[i, i];
            }
        }
        return maxEl;
    }

    static void SwapRowColumn(int[,] matricaA, int[,] matricaB, int n)
    {
        int maxElmatricaA = FindMaxDiag(matricaA, n);
        int maxElmatricaB = FindMaxDiag(matricaB, n);
        int rIndex = -1;
        int cIndex = -1;

        // Нахожу индекс строки с максимальным элементом на главной диагонали в матрице A
        for (int i = 0; i < n; i++)
        {
            if (matricaA[i, i] == maxElmatricaA)
            {
                rIndex = i;
                break;
            }
        }

        // Нахожу индекс столбца с максимальным элементом на главной диагонали в матрице В
        for (int j = 0; j < n; j++)
        {
            if (matricaB[j, j] == maxElmatricaB)
            {
                cIndex = j;
                break;
            }
        }

        // Проверяю, что найдены индексы
        if (rIndex != -1 && cIndex != -1)
        {
            // Меняю местами строку и столбец
            for (int i = 0; i < n; i++)
            {
                int t = matricaA[rIndex, i];
                matricaA[rIndex, i] = matricaB[i, cIndex];
                matricaB[i, cIndex] = t;
            }
        }
        else
        {
            Console.WriteLine("К сожалению, не удалось найти максимальные элементы на диагоналях.");
        }
    }

    static void Main(string[] args)
    {
        int n = 5;
        int[,] matricaA = ReadMatrica(n);
        int[,] matricaB = ReadMatrica(n);

        Console.WriteLine("Исходные матрицы:");
        PrintMatrica(matricaA, n);
        PrintMatrica(matricaB, n);

        SwapRowColumn(matricaA, matricaB, n);

        Console.WriteLine("Матрицы после замены:");
        PrintMatrica(matricaA, n);
        PrintMatrica(matricaB, n);
    }
}
*/
#endregion

#region 10
/*
using System;

class Program
{
    static void Main()
    {
        // Мой пимер использования
        int[,] matrica = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrica(matrica);

        // Нахожу максимальный элемент ниже главной диагонали
        int maxBelowDiagonal = FindMaxBelowDiagonal(matrica);
        Console.WriteLine($"Максимальный элемент ниже главной диагонали: {maxBelowDiagonal}");

        // Нахожу минимальный элемент выше главной диагонали
        int minAboveDiagonal = FindMinAboveDiagonal(matrica);
        Console.WriteLine($"Минимальный элемент выше главной диагонали: {minAboveDiagonal}");

        // Удаляю столбцы, в которых находятся максимальный и минимальный элементы
        DeleteColumnsWithElements(matrica, maxBelowDiagonal, minAboveDiagonal);

        Console.WriteLine("Матрица после удаления столбцов:");
        PrintMatrica(matrica);
    }

    static int FindMaxBelowDiagonal(int[,] matrica)
    {
        int maxEl = matrica[0, 0];

        for (int i = 0; i < matrica.GetLength(0); i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (matrica[i, j] > maxEl)
                {
                    maxEl = matrica[i, j];
                }
            }
        }

        return maxEl;
    }

    static int FindMinAboveDiagonal(int[,] matrica)
    {
        int minEl = matrica[0, 0];

        for (int i = 0; i < matrica.GetLength(0); i++)
        {
            for (int j = i + 1; j < matrica.GetLength(1); j++)
            {
                if (matrica[i, j] < minEl)
                {
                    minEl = matrica[i, j];
                }
            }
        }

        return minEl;
    }

    static void DeleteColumnsWithElements(int[,] matrica, int maxEl, int minEl)
    {
        int rows = matrica.GetLength(0);
        int columns = matrica.GetLength(1);

        // Удаляю столбцы с максимальным и минимальным элементами
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrica[i, j] == maxEl || matrica[i, j] == minEl)
                {
                    DeleteColumn(matrica, j);
                    columns--;
                    j--; // Уменьшаю индекс, чтобы не пропустить следующий столбец
                }
            }
        }
    }

    static void DeleteColumn(int[,] matrica, int cIndex)
    {
        int rows = matrica.GetLength(0);
        int columns = matrica.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = cIndex; j < columns - 1; j++)
            {
                matrica[i, j] = matrica[i, j + 1];
            }
        }
    }

    static void PrintMatrica(int[,] matrica)
    {
        int rows = matrica.GetLength(0);
        int columns = matrica.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrica[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/
#endregion 

#region 16
/*
using System;

class Program
{
    static void Main()
    {
        int[] array1 = { 3, -5, 2, -8, 7, 1, -4, 6 };
        int[] array2 = { -2, 9, -11, 4, -6, 10, -3, 8 };

        Console.WriteLine("Исходный массив 1:");
        PrintArray(array1);

        Console.WriteLine("\nИсходный массив 2:");
        PrintArray(array2);

        NegElDown(array1);
        NegElDown(array2);

        Console.WriteLine("\nМассив 1 после упорядочивания отрицательных элементов:");
        PrintArray(array1);

        Console.WriteLine("\nМассив 2 после упорядочивания отрицательных элементов:");
        PrintArray(array2);

        Console.ReadLine();
    }

    static void NegElDown(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < 0 && arr[j] > arr[i])
                    {
                        // Тут сделаю так, чтобы происходил обмен отрицательных элементов для упорядочивания
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
*/
#endregion

#region 22
/*
using System;

class Program
{
    static void Main()
    {
        // Мой пример матрицы
        int[,] matrica = {
            { 1, -2, 3 },
            { 4, -5, 6 },
            { -7, 8, -9 }
        };

        int[] NegatElCount = CountNegatEl(matrica);
        int[] maxNegatColumns = FindMaxNegatColumns(matrica);

        // Вывожу результаты
        Console.WriteLine("Количество отрицательных элементов в каждой строке:");
        PrintArray(NegatElCount);

        Console.WriteLine("\nМаксимальные отрицательные элементы в каждом столбце:");
        PrintArray(maxNegatColumns);
    }

    static int[] CountNegatEl(int[,] matrica)
    {
        int rCount = matrica.GetLength(0);
        int[] NegatCountArr = new int[rCount];

        for (int i = 0; i < rCount; i++)
        {
            for (int j = 0; j < matrica.GetLength(1); j++)
            {
                if (matrica[i, j] < 0)
                {
                    NegatCountArr[i]++;
                }
            }
        }

        return NegatCountArr;
    }

    static int[] FindMaxNegatColumns(int[,] matrica)
    {
        int cCount = matrica.GetLength(1);
        int[] maxNegatArr = new int[cCount];

        for (int j = 0; j < cCount; j++)
        {
            int maxNegat = int.MinValue;

            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                if (matrica[i, j] < 0 && matrica[i, j] > maxNegat)
                {
                    maxNegat = matrica[i, j];
                }
            }

            maxNegatArr[j] = maxNegat;
        }

        return maxNegatArr;
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
*/
#endregion 
