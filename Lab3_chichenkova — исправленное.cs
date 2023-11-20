using System;
namespace ConsoleApp3
{
    class program
    {
        static void Main(string[] args)
        {

            /*  #region 2_10
              Console.WriteLine("Введите размер массива ");
              int n = int.Parse(Console.ReadLine());
              double [] a = new double[n];
              int imin = 0;
              bool ok = true;
              for (int i = 0; i < n; i++)
              {
                  string s1 = Console.ReadLine();
                  a[i] = double.Parse(s1);
              }
              while ((imin < n) && (a[imin] <= 0))
              {
                  imin += 1;
              }
              if (imin == n) ok = false;
              Console.WriteLine();
              if (ok == false) Console.WriteLine("Положительные элементы отсутствуют");
              else
              {
                  for (int i = imin + 1; i < n; i++)
                  {
                      if ((a[i] < a[imin]) && (a[i] > 0)) imin = i;
                  }
                  if (ok == true)
                  {
                      for (int i = imin; i < n - 1; i++) a[i] = a[i + 1];
                  }
                  Console.Write("Удалить минимальный элемент среди положительных: ");
                  for (int i = 0; i < n - 1; i++)
                  {
                      Console.Write("{0} ", a[i]);
                  }
              }
              #endregion */


            /* #region Task2.11
             Console.WriteLine("Введите число P ");
             double P = double.Parse(Console.ReadLine());
             Console.WriteLine("Введите размер массива ");
             int k = int.Parse(Console.ReadLine());
             double [] a = new double[k + 1];
             int z = k - 1;
             bool ok = true;
             Console.WriteLine("Введите элементы массива:");
             for (int i = 0; i < k; i++)
             {
                 string s1 = Console.ReadLine();
                 a[i] = double.Parse(s1);
             }
             while ((z >= 0) && (a[z] <= 0)) z -= 1;
             if (z == -1) ok = false;
             if (ok == false) Console.WriteLine("Положительные элементы отсутствуют");
             else
             {
                 Console.Write("Вставить P после последнего положительного элемента: ");
                 for (int i = k - 1; i >= z + 1; i--)
                 {
                     a[i + 1] = a[i];
                 }
                 a[z + 1] = P;
                 for (int i = 0; i < k + 1; i++)
                 {
                     Console.Write("{0} ", a[i]);
                 }
             }
             #endregion */

            /* #region Task2.12 
             Console.WriteLine("Введите размер массива: ");
             int n = int.Parse(Console.ReadLine());
             int z = 0;
             int amax = 0;
             double s = 0;
             bool ok = true;
             double [] a = new double[n];
             Console.WriteLine("Введите элементы массива:");
             for (int i = 0; i < n; i++)
             {
                 string s1 = Console.ReadLine();
                 a[i] = double.Parse(s1);
                 if (a[i] > a[amax]) 
                     amax = i;
             }
             while ((z < n) && (a[z] >= 0)) 
                 z += 1;
             if (z == n) ok = false;
             if (ok == false) Console.WriteLine("Отрицательные элементы отсутствуют");
             else
             {
                 for (int i = amax + 1; i < n; i++) 
                 s += a[i];
                 a[z] = s;
                 Console.Write("Полученный массив: ");
                 for (int i = 0; i < n; i++)
                 {
                     Console.Write("{0} ", a[i]);
                 }
             }
             #endregion */


            /* #region Task2.14
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double max = -10000;
             double min = 10000;
             double s = 0;
             int amax = 0;
             int t = -1;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (b[i] > max)
                 {
                     max = b[i];
                     amax = i;
                 }
                 if (t == -1 && b[i] < 0)
                 {
                     t = i;
                     s = b[i];
                 }
             }
             b[t] = max;
             b[amax] = s;
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b));
             #endregion */

            /* #region Task2.15
             Console.WriteLine("Введите размер массива А ");
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите размер массива В ");
             int m = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите номер элемента массива А, после которого нужно вставить массив В");
             int k = int.Parse(Console.ReadLine());
             int j = 0;
             double [] a = new double[n + m];
             double [] b = new double[m];
             Console.WriteLine("Введите массив А");
             for (int i = 0; i < n; i++)
             {
                 a[i] = double.Parse(Console.ReadLine());
             }
             Console.WriteLine();
             Console.WriteLine("Введите массив В");
             for (int i = 0; i < m; i++)
             {
                 b[i] = double.Parse(Console.ReadLine());
             }
             for (int i = n + m - 1; i >= k + m; i--) 
                a[i] = a[i - m];
             for (int i = k; i < k + m; i++)
             {
                 a[i] = b[j];
                 j++;
             }
             Console.WriteLine();
             Console.Write("Конечный массив А: ");
             for (int i = 0; i < n + m; i++) 
                Console.Write("{0} ", a[i]);
             #endregion */


            /*  #region Task2.17
              Console.WriteLine("Введите размер массива:");
              int n = int.Parse(Console.ReadLine());
              double [] a = new double[n];
              int amax = 0;
              int imin = 0;
              double s1 = 0;
              double s2 = 0;
              double r = 0;
              int m = 0; int z = 0;
              for (int i = 0; i < n; i++)
              {
                  a[i] = double.Parse(Console.ReadLine());
              }
              for (int i = 0; i < n; i++)
              {
                  Console.Write("{0} ", a[i]);
                  if (a[i] < a[imin]) 
                     imin = i;
                  if (a[i] > a[amax]) 
                     amax = i;
                  if (a[i] > 0)
                  {
                      s1 += a[i];
                      z++;
                  }
                  if (a[i] < 0)
                  {
                      s2 += a[i];
                      m++;
                  }
              }
              Console.WriteLine();
              if (imin < amax)
              {
                  if (m != 0)
                  {
                       r = s2 / m;
                      Console.WriteLine("Среднее арифметическое отрицательных чисел: {0}", r);
                  }
                  else Console.WriteLine("Отрицательные числа отсутствуют");
              }
              else
              {
                  if (z != 0)
                  {
                       r = s1 / z;
                      Console.WriteLine("Среднее арифметическое положительных чисел: {0}", r);
                  }
                  else Console.WriteLine("Положительные числа отсутствуют");
              }
              Console.WriteLine();
              #endregion */
        }
    }
}
