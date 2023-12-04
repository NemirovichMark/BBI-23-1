#region 2.8 
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matricaB = new int[6, 6];

        Console.WriteLine("Введите, пожалуйста, значения матрицы:");


        for (int i = 0; i < 6; i++)
        {
            string[] ourRow = Console.ReadLine().Split(' ');

            for (int j = 0; j < 6; j++)
            {
                matricaB[i, j] = int.Parse(ourRow[j]);
            }
        }

        // Ищу максимальные элементы и их индексы по строкам
        int maximInd1 = 0, maximInd2 = 0;
        for (int i = 0; i < 6; i += 2)
        {
            int maxim1 = int.MinValue, maxim2 = int.MinValue;

            for (int j = 0; j < 6; j++)
            {
                if (matricaB[i, j] > maxim1)
                {
                    maxim1 = matricaB[i, j];
                    maximInd1 = j;
                }

                if (matricaB[i + 1, j] > maxim2)
                {
                    maxim2 = matricaB[i + 1, j];
                    maximInd2 = j;
                }
            }

            // Обменяю максимальные элементы между строками
            int t = matricaB[i, maximInd1];
            matricaB[i, maximInd1] = matricaB[i + 1, maximInd2];
            matricaB[i + 1, maximInd2] = t;
        }

        Console.WriteLine("Измененная матрица, результат:");
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

#region 3.6
/*
class Program3lvl_6
{
    static void Main()
    {
        const int n = 5;
        int[] A1 = new int[15];
        int[] A2 = new int[15];
        int[,] B = new int[n, n] { {1,2,3,4,5},
                                {6,7,8,9,10},
                                {11,12,13,14,15},
                                {16,17,18,19,20},
                                {21,22,23,24,25}};
        int j, i, m = 0, k = 0;
        Console.WriteLine("Данный массив: ");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
                Console.Write("{0,3:d} ", B[i, j]);
            Console.WriteLine();
        }
        for (i = 0; i < n; i++)
        {
            for (j = i; j < n; j++)
            {
                A1[k] = B[i, j];
                k++;
            }
        }
        for (i = 1; i < n; i++)
        {
            for (j = 0; j < i; j++)
            {
                A2[m] = B[i, j];
                m++;
            }
        }


        int x = 0, y = n;
        Console.WriteLine("Верхний треугольник: ");
        for (i = 0; i < n; i++)
        {
            for (j = y; j > 0; j--)
            {
                Console.Write($"{A1[x],3:d} ");
                x++;
            }
            y--;
            Console.WriteLine();
        }

        int v = 0, z = 0;
        Console.WriteLine("Нижний треугольник: ");
        for (i = 0; i < n; i++)
        {
            string s = "  ";
            for (j = z; j > 0; j--)
            {
                Console.Write($"{s}");
                Console.Write($"{A2[v],3:d} ");
                v++;
            }
            s = " " + s;
            z++;
            Console.WriteLine();
        }

    }
}
*/
#endregion
