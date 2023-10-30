using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        //почему изменения по задачам в лабу внесли только позавчера..........
        //мой номер 14
        //3 7 11 15 19 23 27 31
        //1 5 9
        #region 1-1
        Console.WriteLine("1-1:");
        int n = 5, m = 7;
        double[,] arr = new double[n, m];
        string str;
        double su = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for(int i = 0; i < n; i++)
        { 
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i,j] = mass[j];
                su += mass[j];
            }    
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j]+ " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Сумма элементов массива:");
        Console.WriteLine(su);
        Console.WriteLine();
        #endregion

        #region 1-2
        Console.WriteLine("1-2:");
        n = 5; m = 7;
        arr = new double[n, m];
        su = 0;
        double temp = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
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
        Console.WriteLine();
        #endregion

        #region 1-3
        Console.WriteLine("1-3:");
        n = 4; m = 4;
        arr = new double[n, m];
        su = 0;
        Console.WriteLine("Введите матрицу: 4 строки по 4 эллемента,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
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
        for(int i = 0;i < n; i++)
        {
            su =su + arr[i, i] + arr[i, (n - 1) - i];
        }
        Console.WriteLine("След:");
        Console.WriteLine(su);
        Console.WriteLine();
        #endregion

        #region 1-4
        Console.WriteLine("1-4:");
        n = 3; m = 6;
        int a = 0, b = 0;
        double min = 10000000000000;
        arr = new double[n, m];
        Console.WriteLine("Введите матрицу: 3 строки по 6 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i,j] < min)
                {
                    min = arr[i, j];
                    a = i;
                    b = j;
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
        Console.WriteLine("Строка:");
        Console.WriteLine(a+1);
        Console.WriteLine("Столбец:");
        Console.WriteLine(b+1);
        Console.WriteLine();
        #endregion

        #region 1-5
        Console.WriteLine("1-5:");
        n = 5; m = 4;
        arr = new double[n, m];
        temp = -1;
        double tempik = 0;

        Console.WriteLine("Введите столбец:");
        double g = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите матрицу: 5 строк по 4 эллемента,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i, j] < 0 && j == g && temp == -1)
                {
                    temp = i;
                    tempik = arr[i, j];
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
        Console.WriteLine("Номер:");
        Console.WriteLine(temp + 1);
        Console.WriteLine("Значение:");
        Console.WriteLine(tempik);
        Console.WriteLine();
        #endregion

        #region 1-6
        Console.WriteLine("1-6:");
        n =4; m = 7;
        min = 1000000000000000;
        int ind = 0;
        double[] mas = new double[n];
        arr = new double[n, m];
        Console.WriteLine("Введите матрицу: 4 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (mass[j] < min)
                {
                    min = mass[j];
                    ind = j;
                }
            }
            mas[i] = ind;
            min = 10000000000;
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
        Console.WriteLine("Полученный массив индексов :");
        Console.WriteLine("[{0}]", string.Join(';', mas));
        Console.WriteLine();
        #endregion

        #region 1-7 
        Console.WriteLine("1-7:");
        n = 3; m = 5;
        double max = -1000000000000000;
        ind = 0;
        mas = new double[m];
        arr = new double[n, m];
        Console.WriteLine("Введите матрицу: 3 строки по 5 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
            }
        }
        for(int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i,j] > max)
                {
                    max = arr[i,j];
                    ind = i;
                }
            }
            mas[j] = ind;
            max = -10000000000;
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
        Console.WriteLine("Полученный массив индексов :");
        Console.WriteLine("[{0}]", string.Join(';', mas));
        Console.WriteLine();
        #endregion

        #region 1-8
        Console.WriteLine("1-8:");
        n = 4; m = 6;
        mas = new double[n];
        arr = new double[n, m];
        su = 0; temp = 0;
        Console.WriteLine("Введите матрицу: 4 строки по 6 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (mass[j] > 0)
                {
                    temp++;
                    su += mass[j];
                }
            }
            su = su / temp;
            mas[i] = su;
            su = 0; temp = 0;
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
        Console.WriteLine("Полученный массив ср знач:");
        Console.WriteLine("[{0}]", string.Join(';', mas));
        Console.WriteLine();
        #endregion

        #region 1-9
        Console.WriteLine("1-9:");
        n = 5;m = 7;
        mas = new double[n];
        arr = new double[n, m];
        temp = 0;
        int ind1 = 0, ind2 = 0;
        double maxim = -10000000000;
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if(maxim < arr[i, j])
                {
                    maxim = arr[i, j];
                    ind1 = i; ind2 = j;
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
        arr[ind1, ind2] = arr[0,0];
        arr[0, 0] = maxim;
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-10
        Console.WriteLine("1-10:");
        n = 5; m = 7;
        arr = new double[n, m];
        ind = 0;
        maxim = -10000000000;
        temp = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if(j == 2 && arr[i, j] > maxim)
                {
                    maxim = arr[i, j];
                    ind = i;
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
        for (int i = 0; i < m; i++)
        {
            temp = arr[3, i];
            arr[3, i] = arr[ind, i];
            arr[ind, i] = temp;
        }
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-11
        Console.WriteLine("1-11:");
        n = 5;m = 7;
        min = 10000000000000;
        arr = new double[n, m];
        double[,] array = new double[n - 1, m]; 
        ind = 0;maxim = -10000000000;temp = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (mass[j] < min && j == 0)
                {
                    min = mass[j];
                    ind = i;
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
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if(i < ind)
                {
                    array[i,j] = arr[i, j];
                }
                if( i > ind)
                {
                    array[i - 1, j] = arr[i, j];
                }
            }
        }
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-12
        Console.WriteLine("1-12:");
        n = 6;m = 7;
        max = -10000000000000;
        arr = new double[n, m];
        array = new double[n - 1, m - 1];
        ind1 = 0;
        ind2 = 0;
        temp = 0;
        Console.WriteLine("Введите матрицу: 6 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (mass[j] > max)
                {
                    max = mass[j];
                    ind1 = i;
                    ind2 = j;
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
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i < ind1)
                {
                    if(j < ind2)
                    {
                        array[i, j] = arr[i, j];
                    }
                    if(j >  ind2)
                    {
                        array[i, j - 1] = arr[i, j];
                    }
                }
                if (i > ind1)
                {
                    if(j < ind2)
                    {
                        array[i - 1, j] = arr[i, j];
                    }
                    if(j > ind2)
                    {
                        array[i - 1,j - 1] = arr[i, j];
                    }
                }
            }
        }
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-13
        Console.WriteLine("1-13:");
        n = 5;m = 5;
        max = -10000000000000;
        arr = new double[n, m];
        temp = 0;ind = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 5 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (mass[j] > max && ((i == j) || (i == i-j)))
                {
                    max = mass[j];
                    ind = j; 
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
        Console.WriteLine();
        for (int i = 0; i < m; i++)
        {
            temp = arr[i, 3];
            arr[i, 3] = arr[i, ind];
            arr[i,ind] = temp;
        }
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-14
        Console.WriteLine("1-14:");
        n = 4;m = 3;
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
        for(int j = 0; j < m; j++)
        {
            for(int i = 0; i < n;i++)
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
        Console.WriteLine();
        #endregion

        #region 1-15
        Console.WriteLine("1-15:");
        n = 5; m = 7;
        arr = new double[n, m];
        array = new double[n, m];
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                array[i, j] = arr[i, j] * (i+1);
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
        Console.WriteLine();
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-16
        Console.WriteLine("1-16:");
        Console.WriteLine("Введите кол-во строк:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        m = int.Parse(Console.ReadLine());
        double[,] A = new double[n, m];
        double[,] C = new double[n, m];
        int[] B = new int[n];
        max = -10000000000000;
        tempura = 0;
        Console.WriteLine("Введите матрицу: " + n +" строк по " + m +" эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                A[i, j] = mass[j];
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    tempura = j;
                }
            }
            B[i] = tempura;
            tempura = 0; max = -10000000000000;
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if(j < B[i])
                {
                    C[i,j] = A[i,j];
                }
                if(j > B[i] && B[i] < (m-1))
                {
                    C[i, j - 1] = A[i,j];   
                }
                if(j == (m-1))
                {
                    C[i, j] = A[i, B[i]];
                }
            }
        }
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-17
        Console.WriteLine("1-17:");
        Console.WriteLine("Введите кол-во строк:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        m = int.Parse(Console.ReadLine());
        A = new double[n, m];
        C = new double[n, m];
        B = new int[n];
        min = 10000000000000;
        tempura = 0;
        Console.WriteLine("Введите матрицу: " + n + " строк по " + m + " эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                A[i, j] = mass[j];
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    tempura = j;
                }
            }
            B[i] = tempura;
            tempura = 0; min = 10000000000000;
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (j == 0)
                {
                    C[i, j] = A[i, B[i]];
                }
                if (j <= B[i] && j != 0)
                {
                    C[i, j] = A[i, j - 1];
                }
                if (j > B[i] && j != 0)
                {
                    C[i, j] = A[i, j];
                }
            }
        }
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-18
        Console.WriteLine("1-18:");
        Console.WriteLine("Введите кол-во строк:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        m = int.Parse(Console.ReadLine());
        A = new double[n, m];
        B = new int[n];
        int[] D = new int[n];
        max = -10000000000000;
        tempura = 0;
        temp = -1;
        ind = 0;
        int otr = 0;
        Console.WriteLine("Введите матрицу: " + n + " строк по " + m + " эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                A[i, j] = mass[j];
                if (mass[j] < 0)
                {
                    temp = -2;
                }
                if (mass[j] > max && temp != -2)
                {
                    max = mass[j];
                    ind = j;
                }
                if (mass[j] < 0)
                {
                    otr = j;
                }
            }
            B[i] = ind;
            D[i] = otr;
            temp = -1;
            ind = 0; otr = 0;
            max = -100000000000000;
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            temp = A[i, B[i]];
            A[i, B[i]] = A[i, D[i]];
            A[i, D[i]] = temp;
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-19
        Console.WriteLine("1-19:");
        Console.WriteLine("Введите кол-во строк:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        m = int.Parse(Console.ReadLine());
        A = new double[n, m];
        B = new int[n];
        max = -10000000000000;
        ind = 0;
        Console.WriteLine("Введите матрицу: " + n + " строк по " + m + " эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                A[i, j] = mass[j];
                if (mass[j] > max)
                {
                    max = mass[j];
                    ind = j;
                }
            }
            B[i] = ind;
            max = -1000000000000000;
            ind = 0;
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < 0 && j < B[i])
                {
                    A[i, j] = A[i, j] / A[i, B[i]];
                }
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-20
        Console.WriteLine("1-20:");
        Console.WriteLine("Введите кол-во строк:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        m = int.Parse(Console.ReadLine());
        A = new double[n, m];
        B = new int[n];
        D = new int[n];
        int[] E = new int[n];
        max = -10000000000000;
        ind1 = 0; ind2 = 0;
        tempura = 0;
        su = 0; temp = -1;
        Console.WriteLine("Введите матрицу: " + n + " строк по " + m + " эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                A[i, j] = mass[j];
                if (mass[j] > max)
                {
                    max = mass[j];
                    B[i] = j;
                }
                if (mass[j] < 0 && temp != -2)
                {
                    D[i] = j;
                    temp = -2;
                }
                if (mass[j] < 0)
                {
                    E[i] = j;
                }
            }
            temp = -1;
            max = -10000000000000000;
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < 0 && j < B[i])
                {
                    A[i, B[i]] = (A[i, D[i]] + A[i, E[i]]) / 2;
                }
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-21
        Console.WriteLine("1-21:");
        n = 5; m = 7;
        arr = new double[n, m];
        B = new int[n];
        max = -100000000000000;
        Console.WriteLine("Введите матрицу: 5 строк по 6 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m - 1 ; j++)
            {
                arr[i, j] = mass[j];
                if (mass[j] > max)
                {
                    max = mass[j];
                    B[i] = j;
                }
            }
            max = -1000000000000000;
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
        for(int i = 0;i < n; i++)
        {
            arr[i, 5] = arr[i, B[i]];
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
        Console.WriteLine();
        #endregion

        #region 1-22
        Console.WriteLine("1-22:");
        n = 6;m = 8;
        arr = new double[n, m];
        max = -100000000000000;
        su = 0;temp = 0;
        ind1 = 0;
        ind2 = 0;
        Console.WriteLine("Введите матрицу: 6 строк по 8 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m - 1; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i,j] > max)
                {
                    max = mass[j];
                    ind1 = i;
                    ind2 = j;
                }
                if (arr[i,j] > 0)
                {
                    su += arr[i, j];
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
        Console.WriteLine();
        su = su / temp;
        arr[ind1, ind2] = su;
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-23
        Console.WriteLine("1-23:");
        n = 5; m = 7;
        arr = new double[n, m];
        array = new double[n, m];
        D = new int[n];
        max = -100000000000000;
        ind = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 6 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m - 1; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i, j] > max)
                {
                    max = mass[j];
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
        for (int i = 0;i < n; i++)
        {
            for(int j = 0;j < m; j++)
            {
                if (j <= D[i])
                {
                    array[i, j] = arr[i, j];
                }
                if((j-1) == D[i])
                {
                    array[i, j] = arr[i, j - 1];
                }
                if ((j-1) > D[i])
                {
                    array[i,j] = arr[i, j - 1];
                }
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 1-24
        Console.WriteLine("1-24:");
        n = 6;m = 5;
        arr = new double[n, m];
        double[] sr = new double[n];
        D = new int[n];
        max = -100000000000000;
        ind = 0;
        su = 0;
        temp = 0;
        Console.WriteLine("Введите матрицу: 6 строк по 5 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i, j] > max)
                {
                    max = mass[j];
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
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (j > D[i] && arr[i, j] > 0)
                {
                    su += arr[i, j];
                    temp++;
                }
            }
            su = su / temp;
            sr[i] = su;
            su = 0;
            temp = 0;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if(j < D[i] && arr[i,j] < 0)
                {
                    arr[i, j] = sr[i];
                }
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
        Console.WriteLine();
        #endregion

        #region 1-25
        Console.WriteLine("1-25:");
        n = 6;
        m = 5;
        ind1 = 0;
        ind2 = 0;
        arr = new double[n, m];
        D = new int[n];
        max = -100000000000000;
        min = 100000000000000;
        tempura = 0;
        temp = 0;
        Console.WriteLine("Введите матрицу: 6 строк по 5 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i, j] < 0)
                {
                    tempura++;
                }
            }
            D[i] = tempura;
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
        for (int i = 0;i < n; i++)
        {
            if(max < D[i])
            {
                max = D[i];
                ind1 = i;
            }
            if(min > D[i])
            {
                min = D[i];
                ind2 = i;
            }
        }
        for(int i = 0;i<m;i++)
        {
            temp = arr[ind1, i];
            arr[ind1, i] = arr[ind2, i];
            arr[ind2, i] = temp;
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
        Console.WriteLine();
        #endregion

        #region 1-27
        Console.WriteLine("1-27:");
        n = 5; m = 7;
        arr = new double[n, m];
        D = new int[n];
        max = -100000000000000;
        ind = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i, j] > max)
                {
                    max = mass[j];
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
        for(int  i = 0; i < n; i++)
        {
            arr[i, 3] = arr[i, D[i]];
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
        Console.WriteLine();
        #endregion

        #region 2-1
        Console.WriteLine("2-1:");
        n = 5;m = 7;
        arr = new double[n, m];
        D = new int[n];
        max = -100000000000000;
        ind = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i, j] > max)
                {
                    max = mass[j];
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
        for(int i = 0; i < n;i++)
        {
            if (D[i] == 0)
            {
                arr[i, 1] = arr[i, 1] * 2;
            }
            else if (D[i] == (m - 1))
            {
                arr[i, (m - 2)] = arr[i, (m - 2)] * 2;
            }
            else
            {
                if (arr[i, D[i] - 1] < arr[i, D[i] + 1])
                {
                    arr[i, D[i] - 1] = arr[i, D[i] - 1] * 2;
                }
                else
                {
                    arr[i, D[i] + 1] = arr[i, D[i] + 1] * 2;
                }
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
        Console.WriteLine();
        #endregion

        #region 2-5
        Console.WriteLine("2-5:");
        n = 7;m = 5;
        arr = new double[n, m];
        D = new int[n];
        max = -100000000000000;
        ind = 0;su = 0;
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
        for(int i = 0; i < m;i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[j, i] > max)
                {
                    max = arr[i,j];
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
        for(int i = 0; i < m;i++)
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
        Console.WriteLine();
        #endregion

        #region 2-9
        Console.WriteLine("2-9:");
        n = 6;m = 7;
        arr = new double[n, m];
        C = new double[n, m];
        D = new int[n];
        Console.WriteLine("Введите матрицу: 6 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
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
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                C[i,j] = arr[i, (m-1) -j];
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 3-2
        Console.WriteLine("3-2:");
        Console.WriteLine("Введите кол-во строк:");
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
                if(i == 0 || j == 0 || i ==(n1-1) ||  j == (n2-1))
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
        Console.WriteLine();
        #endregion

        #region 3-4
        Console.WriteLine("3-4:");
        Console.WriteLine("Введите кол-во строк:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        n2 = int.Parse(Console.ReadLine());
        arr = new double[n1, n2];
        C = new double[n1, n2];
        tempura = 0;
        tempura = n1 / 2;
        Console.WriteLine(tempura);
        Console.WriteLine("Введите матрицу: " + n1 + " строк по " + n2 + " эллементов,через пробел:");
        for (int i = 0; i < n1; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < n2; j++)
            {
                arr[i, j] = mass[j];
                if(i >= tempura && j <=i)
                {
                    C[i, j] = 1;
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
        Console.WriteLine();
        #endregion
    }
}
