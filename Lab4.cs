#region 1.4
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаю матрицу A
        int[,] matricaA = new int[3, 6];

        Console.WriteLine("Введите, пожалуйста, значения матрицы А (заполняйте через пробел):");

        for (int i = 0; i < 3; i++)
        {
            string[] ourRow = Console.ReadLine().Split(' ');

            for (int j = 0; j < 6; j++)
            {
                matricaA[i, j] = int.Parse(ourRow[j]);
            }
        }

        // Нахожу номера строки и столбца с минимальным элементом
        int minimalEl = matricaA[0, 0];
        int minimalRow = 0;
        int minimalCol = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (matricaA[i, j] < minimalEl)
                {
                    minimalEl = matricaA[i, j];
                    minimalRow = i;
                    minimalCol = j;
                }
            }
        }

        Console.WriteLine("Минимальный элемент: {0}", minimalEl);
        Console.WriteLine("Номер строки: {0}", minimalRow);
        Console.WriteLine("Номер столбца: {0}", minimalCol);

        Console.ReadKey();
    }
}
*/
#endregion

#region 1.8
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matricaA = new int[4, 6];

        Console.WriteLine("Введите, пожалуйста, значения матрицы А через пробел:");
        for (int i = 0; i < 4; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < 6; j++)
            {
                matricaA[i, j] = int.Parse(input[j]);
            }
        }

        int[] averages = new int[4];
        for (int i = 0; i < 4; i++) // Для каждой строки матрицы
        {
            int positiveCount = 0;
            int sum = 0;
            for (int j = 0; j < 6; j++) // Для каждого элемента в строке
            {
                if (matricaA[i, j] > 0)
                {
                    positiveCount++;
                    sum += matricaA[i, j];
                }
            }
            if (positiveCount == 0)
            {
                averages[i] = 0; // Если нет положительных элементов, среднее значение равно 0
            }
            else
            {
                averages[i] = sum / positiveCount;
            }
        }

        Console.WriteLine("Массив средних значений:");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(averages[i] + " ");
        }
    }
}
*/
#endregion

#region 1.12
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matricaA = new int[6, 7];

        Console.WriteLine("Введите, пожалуйста, значения матрицы (6 строк, 7 столбцов):");
        for (int i = 0; i < 6; i++)
        {
            string[] ourRow = Console.ReadLine().Split(' ');
            for (int j = 0; j < 7; j++)
            {
                matricaA[i, j] = int.Parse(ourRow[j]);
            }
        }

        int maximEl = int.MinValue;
        int maximElRow = 0;
        int maximElCol = 0;

        // Ищу максимальный элемент
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (matricaA[i, j] > maximEl)
                {
                    maximEl = matricaA[i, j];
                    maximElRow = i;
                    maximElCol = j;
                }
            }
        }

        // Удаляю строки и столбца с максимальным элементом
        int[,] result = new int[5, 6];
        int index = 0;
        for (int i = 0; i < 6; i++)
        {
            if (i != maximElRow)
            {
                int colIndex = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (j != maximElCol)
                    {
                        result[index, colIndex] = matricaA[i, j];
                        colIndex++;
                    }
                }
                index++;
            }
        }

        // Вывод результата
        Console.WriteLine("Результат:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
#endregion

#region 1.16
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите, пожалуйста, количество строк матрицы: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите, пожалуйста, количество столбцов матрицы: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matricaA = new int[n, m];

        Console.WriteLine("Введите, пожалуйста, значения матрицы (через пробел):");
        for (int i = 0; i < n; i++)
        {
            string[] ourRow = Console.ReadLine().Split(' ');

            for (int j = 0; j < m; j++)
            {
                matricaA[i, j] = int.Parse(ourRow[j]);
            }
        }

        // Переношу максимальные элементы в конец строк
        for (int i = 0; i < n; i++)
        {
            // Нахожу максимальный элемент в строке
            int maximEl = matricaA[i, 0];
            int maximElIndex = 0;
            for (int j = 1; j < m; j++)
            {
                if (matricaA[i, j] > maximEl)
                {
                    maximEl = matricaA[i, j];
                    maximElIndex = j;
                }
            }

            // Переношу максимальный элемент в конец строки
            for (int j = maximElIndex; j < m - 1; j++)
            {
                int temp = matricaA[i, j];
                matricaA[i, j] = matricaA[i, j + 1];
                matricaA[i, j + 1] = temp;
            }
        }

        Console.WriteLine("Измененная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matricaA[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
#endregion

#region 1.20
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите, пожалуйста, количество строк: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите, пожалуйста, количество столбцов: ");
        int m = int.Parse(Console.ReadLine());

        int[,] F = new int[n, m];

        Console.WriteLine("Введите, пожалуйста, значения матрицы через пробел:");

        for (int i = 0; i < n; i++)
        {
            string[] ourRow = Console.ReadLine().Split(' ');

            for (int j = 0; j < m; j++)
            {
                F[i, j] = int.Parse(ourRow[j]);
            }
        }

        // Заменяю максимальный элемент в каждой строке на полусумму первого и последнего отрицательного
        for (int i = 0; i < n; i++)
        {
            int maximElIndex = 0;
            int firstminusIndex = -1;
            int lastminusIndex = -1;

            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > F[i, maximElIndex])
                {
                    maximElIndex = j;
                }

                if (F[i, j] < 0)
                {
                    if (firstminusIndex == -1)
                    {
                        firstminusIndex = j;
                    }

                    lastminusIndex = j;
                }
            }

            if (firstminusIndex != -1 && lastminusIndex != -1)
            {
                int halfSum = (F[i, firstminusIndex] + F[i, lastminusIndex]) / 2;
                F[i, maximElIndex] = halfSum;
            }
        }

        Console.WriteLine("Результат:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(F[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
*/
#endregion

#region 1.24
/*
using System;

public class Program
{
    public static void Main()
    {
        int rows = 6;
        int cols = 5;

        int[,] matricaY = new int[rows, cols];

        Console.WriteLine("Введите, пожалуйста, значения матрицы через пробел:");
        for (int i = 0; i < rows; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matricaY[i, j] = int.Parse(input[j]);
            }
        }

        // Обработка матрицы
        for (int i = 0; i < rows; i++)
        {
            // Поиск максимального элемента
            int maximIndex = 0;
            for (int j = 1; j < cols; j++)
            {
                if (matricaY[i, j] > matricaY[i, maximIndex])
                {
                    maximIndex = j;
                }
            }

            // Замена отрицательных элементов
            int sum = 0;
            int count = 0;
            for (int j = 0; j < maximIndex; j++)
            {
                if (matricaY[i, j] < 0)
                {
                    sum += matricaY[i, maximIndex + 1];
                    count++;
                }
            }

            // Вычисление среднего значения
            int average = 0;
            if (count > 0)
            {
                average = sum / count;
            }

            // Замена отрицательных элементов
            for (int j = 0; j < maximIndex; j++)
            {
                if (matricaY[i, j] < 0)
                {
                    matricaY[i, j] = average;
                }
            }
        }

        Console.WriteLine("Обновленная матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matricaY[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
#endregion

#region 1.28
/*
using System;

class Program
{
    static void Main()
    {
        int[,] matricaA = new int[7, 5];

        // Ввод значений матрицы
        Console.WriteLine("Введите,пожалуйста, значения матрицы (через пробел):");
        for (int i = 0; i < 7; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < 5; j++)
            {
                matricaA[i, j] = int.Parse(input[j]);
            }
        }

        // Нахожу строку с максимальной суммой положительных элементов
        int maxSum = 0;
        int maxSumRowIndex = 0;
        for (int i = 0; i < 7; i++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (matricaA[i, j] > 0)
                {
                    sum += matricaA[i, j];
                }
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                maxSumRowIndex = i;
            }
        }

        // Удаляю строку с максимальной суммой положительных элементов
        int[,] newMatricaA = new int[6, 5];
        int newRow = 0;
        for (int i = 0; i < 7; i++)
        {
            if (i != maxSumRowIndex)
            {
                for (int j = 0; j < 5; j++)
                {
                    newMatricaA[newRow, j] = matricaA[i, j];
                }
                newRow++;
            }
        }

        Console.WriteLine("Новая матрица:");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0} ", newMatricaA[i, j]);
            }
            Console.WriteLine();
        }
    }
}
*/
#endregion

#region 1.32
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matricaA = new int[5, 7];

        Console.WriteLine("Введите, пожалуйста, значения матрицы (через пробел):");
        for (int i = 0; i < matricaA.GetLength(0); i++)
        {
            string[] ourRow = Console.ReadLine().Split(' ');
            for (int j = 0; j < matricaA.GetLength(1); j++)
            {
                matricaA[i, j] = int.Parse(ourRow[j]);
            }
        }

        // Замена максимального элемента в каждой строке
        for (int i = 0; i < matricaA.GetLength(0); i++)
        {
            int maxElement = int.MinValue;
            int sumPositive = 0;
            int countPositive = 0;

            // Нахожу максимальный элемент и сумму положительных элементов в строке
            for (int j = 0; j < matricaA.GetLength(1); j++)
            {
                if (matricaA[i, j] > maxElement)
                {
                    maxElement = matricaA[i, j];
                }

                if (matricaA[i, j] > 0)
                {
                    sumPositive += matricaA[i, j];
                    countPositive++;
                }
            }

            if (countPositive > 0)
            {
                int averagePositive = sumPositive / countPositive;

                // Заменяю максимальный элемент средним среди положительных элементов в строке
                for (int j = 0; j < matricaA.GetLength(1); j++)
                {
                    if (matricaA[i, j] == maxElement)
                    {
                        matricaA[i, j] = averagePositive;
                    }
                }
            }
        }

        Console.WriteLine("Измененная матрица:");
        for (int i = 0; i < matricaA.GetLength(0); i++)
        {
            for (int j = 0; j < matricaA.GetLength(1); j++)
            {
                Console.Write(matricaA[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
#endregion


#region 2.4
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matricaA = new int[7, 5];
        int[] arrayB = new int[5];

        Console.WriteLine("Введите, пожалуйста, элементы матрицы:");

        for (int i = 0; i < 7; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int j = 0; j < 5; j++)
            {
                matricaA[i, j] = int.Parse(input[j]);
            }
        }

        Console.WriteLine("Введите, пожалуйста, элементы массива:");


        string[] inputArray = Console.ReadLine().Split(' ');

        for (int i = 0; i < 5; i++)
        {
            arrayB[i] = int.Parse(inputArray[i]);
        }

        // Замена максимальных элементов
        for (int j = 0; j < 5; j++)
        {
            int max = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < 7; i++)
            {
                if (matricaA[i, j] > max)
                {
                    max = matricaA[i, j];
                    maxIndex = i;
                }
            }

            if (arrayB[j] > max)
            {
                matricaA[maxIndex, j] = arrayB[j];
            }
        }

        Console.WriteLine("Результат:");

        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matricaA[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
#endregion

#region 2.8
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matricaB = new int[6, 6];

        Console.WriteLine("Введите, пожалуйста, значения матрицы через пробел:");

        for (int i = 0; i < 6; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int j = 0; j < 6; j++)
            {
                matricaB[i, j] = int.Parse(input[j]);
            }
        }

        // Нахождение максимальных элементов и их позиций
        int max1RowIndex = 0, max1ColIndex = 0;
        int max2RowIndex = 1, max2ColIndex = 0;
        int max3RowIndex = 2, max3ColIndex = 0;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (matricaB[i, j] > matricaB[max1RowIndex, max1ColIndex])
                {
                    max1RowIndex = i;
                    max1ColIndex = j;
                }
                else if (matricaB[i, j] > matricaB[max2RowIndex, max2ColIndex])
                {
                    max2RowIndex = i;
                    max2ColIndex = j;
                }
                else if (matricaB[i, j] > matricaB[max3RowIndex, max3ColIndex])
                {
                    max3RowIndex = i;
                    max3ColIndex = j;
                }
            }
        }

        // Обмен максимальных элементов между строками
        for (int i = 0; i < 6; i++)
        {
            int t = matricaB[0, i];
            matricaB[0, i] = matricaB[1, i];
            matricaB[1, i] = t;

            t = matricaB[2, i];
            matricaB[2, i] = matricaB[3, i];
            matricaB[3, i] = t;

            t = matricaB[4, i];
            matricaB[4, i] = matricaB[5, i];
            matricaB[5, i] = t;
        }

        Console.WriteLine("Измененная матрица:");

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(matricaB[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
#endregion


#region 3.1
// Вариант а) в виде двухмерного массива
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrica = new int[7, 5];
        Console.WriteLine("Введите, пожалуйста, значения матрицы (через пробел):");
        for (int i = 0; i < 7; i++)
        {
            string[] ourRow = Console.ReadLine().Split(' ');
            for (int j = 0; j < 5; j++)
            {
                matrica[i, j] = int.Parse(ourRow[j]);
            }
        }

        // Отсортирую строки матрицы по убыванию минимальных элементов
        for (int i = 0; i < 7; i++)
        {
            for (int j = i + 1; j < 7; j++)
            {
                int min1 = matrica[i, 0];
                int min2 = matrica[j, 0];
                for (int k = 1; k < 5; k++)
                {
                    min1 = Math.Min(min1, matrica[i, k]);
                    min2 = Math.Min(min2, matrica[j, k]);
                }
                if (min2 > min1)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int t = matrica[i, k];
                        matrica[i, k] = matrica[j, k];
                        matrica[j, k] = t;
                    }
                }
            }
        }

        Console.WriteLine("Отсортированная матрица:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/

// Вариант б) в виде одномерной последовательности
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] matrica = new int[35];
        Console.WriteLine("Введите, пожалуйста, значения матрицы (через пробел):");
        string[] ourRow = Console.ReadLine().Split(' ');
        for (int i = 0; i < 35; i++)
        {
            matrica[i] = int.Parse(ourRow[i]);
        }

        // Отсортирую строки матрицы по убыванию минимальных элементов
        for (int i = 0; i < 7; i++)
        {
            for (int j = i + 1; j < 7; j++)
            {
                int min1 = matrica[i * 5];
                int min2 = matrica[j * 5];
                for (int k = 1; k < 5; k++)
                {
                    min1 = Math.Min(min1, matrica[i * 5 + k]);
                    min2 = Math.Min(min2, matrica[j * 5 + k]);
                }
                if (min2 > min1)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        int t = matrica[i * 5 + k];
                        matrica[i * 5 + k] = matrica[j * 5 + k];
                        matrica[j * 5 + k] = t;
                    }
                }
            }
        }

        Console.WriteLine("Отсортированная матрица:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrica[i * 5 + j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
#endregion

#region 3.2
// Вариант а) в виде двухмерного массива
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите, пожалуйста, размер матрицы: ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrica = new int[size, size];

        Console.WriteLine("Введите, пожалуйста, элементы матрицы через пробел:");

        for (int i = 0; i < size; i++)
        {
            string[] elements = Console.ReadLine().Split(' ');

            for (int j = 0; j < size; j++)
            {
                matrica[i, j] = int.Parse(elements[j]);
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                {
                    matrica[i, j] = 0;
                }

                Console.Write(matrica[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
*/
// Вариант б) в виде одномерной последовательности
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите, пожалуйста, размер матрицы (одно число): ");
        int size = int.Parse(Console.ReadLine());

        int[] matrica = new int[size * size];

        Console.WriteLine("Введите, пожалуйста, элементы матрицы через пробел:");

        string[] elements = Console.ReadLine().Split(' ');

        for (int i = 0; i < size * size; i++)
        {
            matrica[i] = int.Parse(elements[i]);
        }

        for (int i = 0; i < size * size; i++)
        {
            if (i / size == 0 || i / size == size - 1 || i % size == 0 || i % size == size - 1)
            {
                matrica[i] = 0;
            }

            Console.Write(matrica[i] + " ");

            if ((i + 1) % size == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
*/
#endregion
