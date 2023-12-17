// See https://aka.ms/new-console-template for more information
Console.WriteLine("порядковый номер 9");
#region



Console.WriteLine("номер 4");





int[,] matrixA = new int[5, 5] { {1, 2, 3, 4, 5},
                                 {6, 7, 8, 9, 10},
                                 {11, 12, 13, 14, 15},
                                 {16, 17, 18, 19, 20},
                                 {21, 22, 23, 24, 25} };

        int[,] matrixB = new int[5, 5] { {26, 27, 28, 29, 30},
                                         {31, 32, 33, 34, 35},
                                         {36, 37, 38, 39, 40},
                                         {41, 42, 43, 44, 45},
                                         {46, 47, 48, 49, 50} };

        SwapMaxDiagonalElements(matrixA, matrixB);

        Console.WriteLine("полученная матрица А");
        PrintMatrix(matrixA);

        Console.WriteLine("полученная матрица B");
        PrintMatrix(matrixB);
    

    static void SwapMaxDiagonalElements(int[,] matrixA, int[,] matrixB)
    {
        int maxA = FindMaxOnDiagonal(matrixA);
        int maxB = FindMaxOnDiagonal(matrixB);

        int maxAIndex = -1;
        int maxBIndex = -1;

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            if (matrixA[i, i] == maxA)
            {
                maxAIndex = i;
            }
            if (matrixB[i, i] == maxB)
            {
                maxBIndex = i;
            }
            if (maxAIndex != -1 && maxBIndex != -1)
            {
                break;
            }
        }

        if (maxAIndex != -1 && maxBIndex != -1)
        {
            
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                int temp = matrixA[maxAIndex, j];
                matrixA[maxAIndex, j] = matrixB[j, maxBIndex];
                matrixB[j, maxBIndex] = temp;
            }
        }
    }

    static int FindMaxOnDiagonal(int[,] matrix)
    {
        int max = matrix[0, 0];
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > max)
            {
                max = matrix[i, i];
            }
        }
        return max;
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



#endregion

#region



Console.WriteLine("номер 10");
int[,] matrix = {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25 }
        };

int maxBelowDiagonal = int.MinValue;
int minAboveDiagonal = int.MaxValue;
int maxBelowDiagonalColumn = -1;
int minAboveDiagonalColumn = -1;


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j >= i && matrix[i, j] > maxBelowDiagonal)
        {
            maxBelowDiagonal = matrix[i, j];
            maxBelowDiagonalColumn = j;
        }

        if (j < i && matrix[i, j] < minAboveDiagonal)
        {
            minAboveDiagonal = matrix[i, j];
            minAboveDiagonalColumn = j;
        }
    }
}

Console.WriteLine("Максимальный элемент ниже главной диагонали: " + maxBelowDiagonal);
Console.WriteLine("Минимальный элемент выше главной диагонали: " + minAboveDiagonal);


matrix = DeleteColumn(matrix, maxBelowDiagonalColumn);
matrix = DeleteColumn(matrix, minAboveDiagonalColumn);

Console.WriteLine("Матрица после удаления столбцов:");



static int[,] DeleteColumn(int[,] matrix, int columnIndex)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0, k = 0; j < matrix.GetLength(1); j++)
        {
            if (j != columnIndex)
            {
                result[i, k] = matrix[i, j];
                k++;
            }
        }
    }

    return result;
}


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }




#endregion

#region
Console.WriteLine("номер 16");
int[] a1 = { 3, -5, 2, -8, 7, -4 };
int[] a2 = { -1, 6, -3, 9, -2 };

SortNegativesDescending(a1);
SortNegativesDescending(a2);

Console.WriteLine(" первый массив после упорядочевания");
PrintArray(a1);

Console.WriteLine("второй массив после упорядочевания");
PrintArray(a2);
    

    static void SortNegativesDescending(int[] array)
{
    int[] negatives = Array.FindAll(array, element => element < 0);
    Array.Sort(negatives);
    Array.Reverse(negatives);

    int negativeIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            array[i] = negatives[negativeIndex];
            negativeIndex++;
        }
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
#endregion

#region
Console.WriteLine("номер 22");
int[,] matr = {
            { 1, -2, 3, -4, 5 },
            { 6, 7, -8, 9, -10 },
            { 11, 12, -13, 14, 15 },
            { -16, 17, 18, 19, -20 },
            { 21, -22, 23, 24, -25 }
        };

int[] negativeCountPerRow = GetNegativeCountPerRow(matr);
int[] maxNegativePerColumn = GetMaxNegativePerColumn(matr);

Console.WriteLine("Количество отрицательных элементов в каждой строке:");
PrintAray(negativeCountPerRow);
Console.WriteLine("Максимальные среди отрицательных элементов в каждом столбце:");
PrintAray(maxNegativePerColumn);
    

    static int[] GetNegativeCountPerRow(int[,] matrix)
{
    int ro = matrix.GetLength(0);
    int[] res = new int[ro];

    for (int i = 0; i < ro; i++)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 0)
            {
                count++;
            }
        }
        res[i] = count;
    }

    return res;
}

static int[] GetMaxNegativePerColumn(int[,] matrix)
{
    int cс = matrix.GetLength(1);
    int[] result = new int[cс];

    for (int j = 0; j < cс; j++)
    {
        int maxNegative = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, j] < 0 && matrix[i, j] > maxNegative)
            {
                maxNegative = matrix[i, j];
            }
        }
        result[j] = maxNegative;
    }

    return result;
}

static void PrintAray(int[] array)
{
    foreach (var element in array)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}

#endregion