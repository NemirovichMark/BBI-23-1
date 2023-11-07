using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

class Program
{
    public static double[,] MaxMatr(double[,] arr, int a)
    {
        int ind = 0;
        double max = -100000000000;
        double temp = 0;
        for(int i = 0; i < a; i++)
        {
            for(int j = 0; j < a; j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    ind = j;
                }
            }
        }
        for(int i = 0; i < a; i++)
        {
            temp = arr[i, i];
            arr[i, i] = arr[i, ind];
            arr[i, ind] = temp;
        }
        Console.WriteLine(ind);
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        return arr;
    }
    public static int MaxEl(int a, int b, double[,] arr, int c)
    {
        int temp = 0;
        int temp1 = 0;
        int ind = 0;
        int ind1 = 0;
        if (c == 0)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (arr[i,j] > 0)
                    {
                        temp++;ind = i;
                    }
                }
                if(temp > temp1)
                {
                    temp1 = temp;ind1 = ind;
                }
                temp = 0;ind = 0;
            }
        }
        else
        {
            for (int j = 0; j < b; j++)
            {
                for (int i = 0; i < a; i++)
                {
                    if (arr[i, j] > 0)
                    {
                        temp++;ind = j;
                    }
                }
                if (temp > temp1)
                {
                    temp1 = temp;ind1 = ind;
                }
                temp = 0;ind = 0;
            }
        }
        return ind1;
    }
    public static double[] sortik(double[] arr, int temp)
    {
        double[] otr = new double[temp];
        int tempp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                otr[tempp] = arr[i];
                tempp++;
            }
        }
        tempp = 0;
        Array.Sort(otr);
        Array.Reverse(otr);
        for (int i = 0;i < arr.Length;i++)
        {
            if (arr[i] < 0)
            {
                arr[i] = otr[tempp];
                tempp++;
            }
        }
        return arr;
    }

    public static void Main(string[] args)
    {
        //мой номер 14
        //3 9 15

        #region 3
        Console.WriteLine("3:");
        int n1 = 4;
        int m1 = 5;
        int n2 = 5;
        int m2 = 6;
        double[] mass;
        double[] massiv;
        double[,] B = new double[n1, m1];
        double[,] C = new double[n2, m2];
        double[,] A = new double[n1 + 1, m1];
        string str, strr;
        int temp1 = 0;
        int temp2 = 0;
        int op1 = 0;
        int op2 = 1;
        Console.WriteLine("Введите матрицу: 4 строки по 5 эллементов,через пробел:");
        for (int i = 0; i < n1; i++)
        {
            str = Console.ReadLine();
            mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m1; j++)
            {
                B[i, j] = mass[j];
            }
        }
        Console.WriteLine("Введите матрицу: 5 строк по 6 эллементов,через пробел:");
        for (int i = 0; i < n2; i++)
        {
            strr = Console.ReadLine();
            massiv = strr.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m2; j++)
            {
                C[i, j] = massiv[j];
            }
        }
        temp1 = MaxEl(n1, m1, B, op1);
        temp2 = MaxEl(n2, m2, C, op2);
        Console.WriteLine(temp1 + " " + temp2);
        for (int i = 0; i < n1 + 1; i++)
        {
            for (int j = 0; j < m1; j++)
            {
                if (i < temp1)
                {
                    A[i, j] = B[i, j];
                }
                if (i == temp1)
                {
                    A[i, j] = C[i, temp2];
                }
                if (i > temp1)
                {
                    A[i, j] = C[i - 1, j];
                }
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n1 + 1; i++)
        {
            for (int j = 0; j < m1; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion

        #region 9
        Console.WriteLine("9:");
        Console.WriteLine("Введите массив 1 через пробел:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Введите массив 2 через пробел:");
        string str2 = Console.ReadLine();
        string[] mass1 = str1.Split(' ');
        string[] mass2 = str2.Split(' ');
        double[] arr1 = new double[mass1.Length];
        double[] arr2 = new double[mass1.Length];
        temp1 = 0;
        temp2 = 0;
        for (int i = 0; i < mass1.Length; i++)
        {
            arr1[i] = double.Parse(mass1[i]);
            if (arr1[i] < 0)
            {
                temp1++;
            }
        }
        for (int i = 0; i < mass2.Length; i++)
        {
            arr2[i] = double.Parse(mass2[i]);
            if (arr2[i] < 0)
            {
                temp2++;
            }
        }
        Console.WriteLine("[{0}]", string.Join("; ", sortik(arr1, temp1)));
        Console.WriteLine("[{0}]", string.Join("; ", sortik(arr2, temp2)));
        #endregion

        #region 15
        Console.WriteLine("Введите матрицу 1 через проблем:");
        str = Console.ReadLine();
        mass = str.Split(' ').Select(double.Parse).ToArray();
        int n = mass.Length;
        double[,] array1 = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            array1[0,i] = mass[i];
        }
        for(int i = 1; i < n; i++)
        {
            str = Console.ReadLine();
            mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < n; j++)
            {
                array1[i, j] = mass[j];
            }
        }
        Console.WriteLine("Введите матрицу 2 через проблем:");
        str = Console.ReadLine();
        massiv = str.Split(' ').Select(double.Parse).ToArray();
        int m = massiv.Length;
        double[,] array2 = new double[m, m];
        for (int i = 0; i < m; i++)
        {
            array2[0, i] = massiv[i];
        }
        for (int i = 1; i < m; i++)
        {
            str = Console.ReadLine();
            massiv = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                array2[i, j] = massiv[j];
            }
        }
        MaxMatr(array1, n);
        MaxMatr(array2, m);
        #endregion
    }
}
