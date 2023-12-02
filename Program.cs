using System;

class Program
{

    public static void Main(string[] args)
    {
        #region 2_10
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string str = Console.ReadLine();
        //string[] a = str.Split(' ');
        //double[] arr = new double[a.Length];
        //double[] ard = new double[a.Length - 1];
        //double min = 10000;
        //int t = 0;
        //for (int i = 0; i < a.Length; i++)
        //{
        //    arr[i] = double.Parse(a[i]);
        //    if (min > arr[i] && arr[i] > 0)
        //    {
        //        min = arr[i];
        //        t = i;
        //    }
        //}
        //for (int i = 0; i < a.Length; i++)
        //{
        //    if (i < t)
        //    {
        //        ard[i] = arr[i];
        //    }
        //    if (i > t)
        //    {
        //        ard[i - 1] = arr[i];
        //    }
        //}
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', ard));
        //Console.ReadLine();
        #endregion 2_10
        #region 2_11
        //Console.Write("Введите P: ");
        //double p = Double.Parse(Console.ReadLine());
        //double[] arr = new double[] { -1, -2, -3, 4, -5, -6 };
        //double ind = arr[0];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] > 0)
        //    {
        //        ind = i;
        //    }
        //}
        //Console.WriteLine("Итоговый массив: ");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write("{0:f0} ", arr[i]);
        //    if (i == ind) Console.Write("{0:f0} ", p);
        //}
        //Console.ReadLine();
        #endregion 2_11
        #region 2_12
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string str = Console.ReadLine();
        //string[] a = str.Split(' ');
        //double[] arr = new double[a.Length];
        //double max = -10000;
        //double min = 10000;
        //double s = 0;
        //int amax = 0;
        //int t = -1;
        //for (int i = 0; i < a.Length; i++)
        //{
        //    arr[i] = double.Parse(a[i]);
        //    if (arr[i] > max)
        //    {
        //        max = arr[i];
        //        amax = i;
        //    }
        //    if (t == -1 && arr[i] < 0)
        //    {
        //        t = i;
        //    }
        //}
        //for (int i = amax + 1; i < a.Length; i++)
        //{
        //    s += arr[i];
        //}
        //arr[t] = s;
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.ReadLine();
        #endregion 2_12
        #region 2_15
        //int k = 3;
        //int n = 10;
        //int m = 5;
        //int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] B = new int[] { 999, 2, 3, 4, 999 };
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("{0:d} ", A[i]);
        //    if (i == (k - 1))
        //    {
        //        for (int j = 0; j < m; j++) Console.Write("{0:d} ", B[j]);
        //        Console.ReadLine();
                #endregion 2_15

            }
        }
    }
}