using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main()
    {
        #region 2 - 10 
        /* Console.WriteLine("2-10:");
         Console.WriteLine("Введите массив,элементы вводите через пробел:");
         string str = Console.ReadLine();
         string[] mass = str.Split(' ');
         double[] arr = new double[mass.Length];
         double minim = 1000000000;
         int temporary = 0;
         double[] arr1 = new double[mass.Length - 1];
         for (int i = 0; i < mass.Length; i++)
         {
             arr[i] = double.Parse(mass[i]);
             if (minim > arr[i] && arr[i] > 0)
             {
                 minim = arr[i];
                 temporary = i;
             }
         }
         for (int i = 0; i < mass.Length; i++)
         {
             if (i < temporary)
             {
                 arr1[i] = arr[i];
             }
             if (i > temporary)
             {
                 arr1[i - 1] = arr[i];
             }
         }
         Console.WriteLine("Полученный массив:");
         Console.WriteLine("[{0}]", string.Join(';', arr1));
         Console.WriteLine();*/
        #endregion
        #region 2-12
        Console.WriteLine("2.12:");
        Console.WriteLine("Ведите массив через пробел:");
        string str = Console.ReadLine();
        string[] arrrray = str.Split(' ');
        double[] arr = new double[arrrray.Length];
        double min = 1000000000;
        double max = -100000000000;
        int maxxx = 0;
        int temp = -1;
        double summ = 0;
        for (int i = 0; i < arrrray.Length; i++)
        {
            arr[i] = double.Parse(arrrray[i]);
            if (arr[i] > max)
            {
                max = arr[i];
                maxxx = i;
            }
            if (temp == -1 && arr[i] < 0)
            {
                temp = i;
            }
        }
        for (int i = maxxx + 1; i < arrrray.Length; i++)
        {
            summ += arr[i];
        }
        if (temp == -1)
        {
            Console.WriteLine("Отрицательных чисел не бывает!");
            Console.WriteLine("Исходный массив:");
            Console.WriteLine("[{0}]", string.Join(";", arrrray));
        }
        else
        {
            arr[(int)temp] = summ;
            Console.WriteLine("Конечный массив:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
        }
        Console.WriteLine();
        #endregion
        #region 2-14
        Console.WriteLine("2.14:");
        Console.WriteLine("Ведите массив через пробел:");
        str = Console.ReadLine();
        arrrray = str.Split(' ');
        arr = new double[arrrray.Length];
        min = 1000000000;
        max = -1000000000;
        temp = -1;
        maxxx = 0;
        summ = 0;
        for (int i = 0; i < arrrray.Length; i++)
        {
            arr[i] = double.Parse(arrrray[i]);
            if (arr[i] > max)
            {
                max = Convert.ToInt32(arr[i]);
                maxxx = i;
            }
            if (temp == -1 && arr[i] < 0)
            {
                temp = i;
                summ = arr[i];
            }
        }
        if (temp == -1)
        {
            Console.WriteLine("Отрицательных чисел не бывает!");
            Console.WriteLine("Исходный массив:");
            Console.WriteLine("[{0}]", string.Join(";", arrrray));
        }
        else
        {
            arr[(int)temp] = max;
            arr[maxxx] = summ;
            Console.WriteLine("Конечный массив:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
        }
        Console.WriteLine();
        #endregion
        #region 2-15
        Console.WriteLine("2-15:");
        Console.WriteLine("Введите размер массивa A:");
        int n = (int)Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер массивa B:");
        int m = (int)Double.Parse(Console.ReadLine());
        double[] A = new double[n];
        double[] B = new double[m];
        double[] C = new double[n + m];
        Console.WriteLine("Введите k:");
        int k = (int)Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите масив A:");
        for (int i = 0; i < n; i++)
        {
            A[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Введите массив B:");
        for (int j = 0; j < m; j++)
        {
            B[j] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < C.Length; i++)
        {
            if (i <= k)
            {
                C[i] = A[i];
            }
            if (i > k && i <= (k + m))
            {
                C[i] = B[i - k - 1];
            }
            if (i > (k + m))
            {
                C[i] = A[i - k - m + 2];
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', C));
        Console.WriteLine();
        #endregion
        #region 2-17
        Console.WriteLine("2.17:");
        Console.WriteLine("Введите массив через пробел:");
        str = Console.ReadLine();
        arrrray = str.Split(' ');
        int[] arr3433 = new int[arrrray.Length];
        min = 1000000000;
        max = -1000000000;
        maxxx = 0;
        int minnn = 0;
        int counter = 0;
        summ = 0;
        for (int i = 0; i < arrrray.Length; i++)
        {
            arr[i] = int.Parse(arrrray[i]);
            if (max < arr[i])
            {
                max = arr[i];
                maxxx = i;
            }
            if (min > arr[i])
            {
                min = arr[i];
                minnn = i;
            }
        }
        if (maxxx < minnn)
        {
            for (int i = 0; i < arrrray.Length; i++)
            {
                if (arr[i] > 0)
                {
                    summ += arr[i];
                    counter++;
                }
            }
            summ /= counter;
            Console.WriteLine("Средний: " + summ);
        }
        else
        {
            for (int i = 0; i < arrrray.Length; i++)
            {
                if (arr[i] < 0)
                {
                    summ += arr[i];
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Отрицательных чисел не бывает!");
                Console.WriteLine("Исходный массив:");
                Console.WriteLine("[{0}]", string.Join(";", arrrray));
            }
            else
            {
                summ /= counter;
                Console.WriteLine("Средний: " + summ);
            }
        }
        Console.WriteLine();
        #endregion
        #region 3-2
        Console.WriteLine("3-2:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string stroka = Console.ReadLine();
        string[] massiv = stroka.Split(' ');
        double[] array = new double[massiv.Length];
        double maximum = -1000000000;
        double mem = 1;
        for (int i = 0; i < massiv.Length; i++)
        {
            array[i] = double.Parse(massiv[i]);
            if (maximum < array[i])
            {
                maximum = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maximum)
            {
                array[i] += mem;
                mem++;
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', array));
        Console.WriteLine();
        #endregion
        #region 3-3
        Console.WriteLine("3-3:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        stroka = Console.ReadLine();
        massiv = stroka.Split(' ');
        array = new double[massiv.Length];
        maximum = -1000000000;
        mem = 0;
        double kran = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            array[i] = double.Parse(massiv[i]);
            if (maximum < array[i])
            {
                maximum = array[i];
                mem = i;
            }
        }
        if (mem % 2 != 0)
        {
            mem -= 1;
        }
        for (int i = 0; i < mem; i += 2)
        {
            kran = array[i];
            array[i] = array[i + 1];
            array[i + 1] = kran;

        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', array));
        #endregion



    }

}
