using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

/*
1 1 1 1 1
-1 1 1 1 1
-1 1 1 1 1
-1 1 1 1 1
2 2 2 2 2 2
2 -2 -2 -2 -2 -2
2 -2 -2 -2 -2 -2
2 -2 -2 -2 -2 -2
2 -2 -2 -2 -2 -2
*/
class Program
{
    public static double[,] vvod(int a, int b)
    {
        string str;
        double[,] massivchik = new double[a, b];
        double[] masss;
        Console.WriteLine("Введите матрицу: " + a + " строки по " + b +" эллементов,через пробел:");
        for (int i = 0; i < a; i++)
        {
            str = Console.ReadLine();
            masss = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < b; j++)
            {
                massivchik[i, j] = masss[j];
            }
        }
        Console.WriteLine();
        return massivchik;
    }
    public static void vivod(double[,] arr, int a, int b)
    {
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
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
        vivod(arr, a, a);
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
        int n1 = 4;int m1 = 5;
        int n2 = 5;int m2 = 6;
        double[,] B = new double[n1, m1];
        double[,] C = new double[n2, m2];
        double[,] A = new double[n1 + 1, m1];
        int temp1 = 0;
        int temp2 = 0;
        int op1 = 0;
        int op2 = 1;
        B = vvod(n1, m1);
        C = vvod(n2, m2);
        temp1 = MaxEl(n1, m1, B, op1);
        temp2 = MaxEl(n2, m2, C, op2);
        Console.WriteLine(temp1 + " " + temp2);
        for (int i = 0; i < n1 + 1; i++)
        {
            for (int j = 0; j < m1; j++)
            {
                if (i < (temp1 + 1))
                {
                    A[i, j] = B[i, j];
                }
                if (i == (temp1 + 1))
                {
                    A[i, j] = C[i, temp2];
                }
                if (i > (temp1 + 1))
                {
                    A[i, j] = B[i - 1, j];
                }
            }
        }
        vivod(A, n1 + 1, m1);
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
        #endregion*/

        #region 15
        Console.WriteLine("Введите размер матрицы 1:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер матрицы 2:");
        int b = int.Parse(Console.ReadLine());
        double[,] array1 = new double[a, a];
        double[,] array2 = new double[b, b];
        array1 = vvod(a, a);
        array2 = vvod(b, b);
        MaxMatr(array1, a);
        MaxMatr(array2, b);
        #endregion
    }
}
