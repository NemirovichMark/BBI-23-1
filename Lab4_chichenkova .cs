using System;
using System.Linq;

namespace ConsoleApp4
{
    class program
    {
        static void Main(string[] args)
        {
            /*  #region Task1.4
              int n = 3; int m = 6;
              int a = 0, b = 0;
              double min = 10000000;
              double [,] x = new double[n, m];
              Console.WriteLine("Введите матрицу: 3 строки по 6 элементов,через пробел:");
              for (int i = 0; i < n; i++)
              {
                  string str = Console.ReadLine();
                  double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                  for (int j = 0; j < m; j++)
                  {
                      x[i, j] = mass[j];
                      if (x[i, j] < min)
                      {
                          min = x[i, j];
                          a = i;
                          b = j;
                      }
                  }
              }
              Console.WriteLine("Строка:");
              Console.WriteLine(a + 1);
              Console.WriteLine("Столбец:");
              Console.WriteLine(b + 1);
              #endregion */

            /* #region Task1.8
             int n = 4; int m = 6;
             double[] C = new double[n];
             double[,] a = new double[n, m];
             double sr = 0; 
             int t = 0;
             Console.WriteLine("Введите матрицу: 4 строки по 6 элементов,через пробел:");
             for (int i = 0; i < n; i++)
             {
                 string str = Console.ReadLine();
                 double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                 for (int j = 0; j < m; j++)
                 {
                     a[i, j] = mass[j];
                     if (mass[j] > 0)
                     {
                         t++;
                         sr += mass[j];
                     }
                 }
                 sr = sr / t;
                 C[i] = sr;
             }
             Console.WriteLine("Полученный массив средних значений:");
             Console.WriteLine("[{0}]", string.Join(';', C));
             #endregion */


            /* #region Task1.12
             int n = 6; int m = 7;
             double [,] a = new double[n, m];
             double [,] b = new double[n - 1, m - 1];
             double max = -10000000;
             int ind1 = 0;
             int ind2 = 0;
             Console.WriteLine("Введите матрицу: 6 строк по 7 элементов,через пробел:");
             for (int i = 0; i < n; i++)
             {
                 string str = Console.ReadLine();
                 double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                 for (int j = 0; j < m; j++)
                 {
                     a[i, j] = mass[j];
                     if (mass[j] > max)
                     {
                         max = mass[j];
                         ind1 = i;
                         ind2 = j;
                     }
                 }
             }
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     if (i < ind1)
                     {
                         if (j < ind2)
                         {
                             b[i, j] = a[i, j];
                         }
                         if (j > ind2)
                         {
                             b[i, j - 1] = a[i, j];
                         }
                     }
                     if (i > ind1)
                     {
                         if (j < ind2)
                         {
                             b[i - 1, j] = a[i, j];
                         }
                         if (j > ind2)
                         {
                             b[i - 1, j - 1] = a[i, j];
                         }
                     }
                 }
             }
             Console.WriteLine("Конечная матрица:");
             for (int i = 0; i < n - 1; i++)
             {
                 for (int j = 0; j < m - 1; j++)
                 {
                     Console.Write(b[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             #endregion */

            /* #region Task1.16
             Console.WriteLine("Введите количество строк:");
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите количество столбцов:");
             int m = int.Parse(Console.ReadLine());
             double[,] A = new double[n, m];
             double[,] C = new double[n, m];
             int[] B = new int[n];
             double max = -1000000;
             int t = 0;
             Console.WriteLine("Введите матрицу: " + n + " строк по " + m + " элементов,через пробел:");
             for (int i = 0; i < n; i++)
             {
                 string str = Console.ReadLine();
                 double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                 for (int j = 0; j < m; j++)
                 {
                     A[i, j] = mass[j];
                     if (A[i, j] > max)
                     {
                         max = A[i, j];
                         t = j;
                     }
                 }
                 B[i] = t;
             }
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     if (j < B[i])
                     {
                         C[i, j] = A[i, j];
                     }
                     if (j > B[i] && B[i] < (m - 1))
                     {
                         C[i, j - 1] = A[i, j];
                     }
                     if (j == (m - 1))
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
             #endregion */

            /*   #region Task1.20 
               Console.WriteLine("Введите количество строк:");
               int n = int.Parse(Console.ReadLine());
               Console.WriteLine("Введите количество столбцов:");
               int m = int.Parse(Console.ReadLine());
               double s = 0;
               int B = 0;
               int C = 0;
               int D = 0;
               double [,] a = new double[n, m];
               double max = -100000;
               double min = 100000;
               double min1 = 100000;
               Console.WriteLine("Введите матрицу: " + n + " строк по " + m + " элементов,через пробел:");
               for (int i = 0; i < n; i++)
               {
                   string str = Console.ReadLine();
                   double[] mas = str.Split(' ').Select(double.Parse).ToArray();
                   for (int j = 0; j < m; j++)
                   {
                       a[i, j] = mas[j];
                   }
               }
               for (int i = 0; i < n; i++)
               {
                   for (int j = 0; j < m; j++)
                   {
                       if (a[i, j] > max)
                       {
                           max = a[i, j];
                           D = j;
                       }
                   }
                   for (int j = 0; j < m; j++)
                   {
                       if (a[i, j] < min1 & a[i, j] < 0)
                       {
                           min1 = a[i, j];
                           C = j;
                       }
                   }
                   for (int j = 0; j < m; j++)
                   {
                       if (a[i, j] < min & a[i, j] < 0)
                       {
                           min = a[i, j];
                           B = j;
                           break;
                       }
                   }
                   s = (min + min1) / 2;
                   if (s < 0)
                   {
                       a[i, D] = s;
                   }
               }
               Console.WriteLine("Конечная матрица:");
               for (int i = 0; i < n; i++)
               {
                   for (int j = 0; j < m; j++)
                   {
                       Console.Write(a[i, j] + " ");
                   }
                   Console.WriteLine();
               }
               #endregion */

            /*  #region Task1.24 
              int n = 6; int m = 5;
              double [,] a = new double[n, m];
              double[] sr = new double[n];
              int [] D = new int[n];
              double max = -100000;
              int ind = 0;
              double s = 0;
              int t = 0;
              Console.WriteLine("Введите матрицу: 6 строк по 5 элементов,через пробел:");
              for (int i = 0; i < n; i++)
              {
                  string str = Console.ReadLine();
                  double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                  for (int j = 0; j < m; j++)
                  {
                      a[i, j] = mass[j];
                      if (a[i, j] > max)
                      {
                          max = mass[j];
                          ind = j;
                      }
                  }
                  D[i] = ind;
              }
              for (int i = 0; i < n; i++)
              {
                  for (int j = 0; j < m; j++)
                  {
                      if (j > D[i] && a[i, j] > 0)
                      {
                          s += a[i, j];
                          t++;
                      }
                  }
                  s = s / t;
                  sr[i] = s;
              }
              for (int i = 0; i < n; i++)
              {
                  for (int j = 0; j < m; j++)
                  {
                      if (j < D[i] && a[i, j] < 0)
                      {
                          a[i, j] = sr[i];
                      }
                  }
              }
              Console.WriteLine("Конечная матрица");
              for (int i = 0; i < n; i++)
              {
                  for (int j = 0; j < m; j++)
                  {
                      Console.Write(a[i, j] + " ");
                  }
                  Console.WriteLine();
              }
              #endregion */

            /* #region Task1.28
             int n = 7; int m = 5;
             double [,] a = new double[n, m];
             double [,] b = new double[n - 1, m];
             double s = 0;
             int t = -1;
             double max = -100000;
             Console.WriteLine("Введите матрицу: 7 строк по 5 элементов, через пробел:");
             for (int i = 0; i < n; i++)
             {
                 string str = Console.ReadLine();
                 double[] mas = str.Split(' ').Select(double.Parse).ToArray();
                 for (int j = 0; j < m; j++)
                 {
                     a[i, j] = mas[j];
                 }
             }
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     if (a[i, j] > 0)
                     {
                         s += a[i, j];
                     }
                 }
                 if (s > max)
                 {
                     max = s;
                     t = i;
                 }
             }
             for (int i = 0; i < n - 1; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     if (i < t)
                     {
                         b[i, j] = a[i, j];
                     }
                     if (i >= t)
                     {
                         b[i, j] = a[i + 1, j];
                     }
                 }
             }
             Console.WriteLine("Конечная матрица:");
             for (int i = 0; i < n - 1; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     Console.Write(b[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             #endregion */

            /* #region Task1.32
             int n = 5; int m = 7;
             double[,] a = new double[n, m];
             double max = -100000;
             double s = 0;
             double t = 0;
             int x = 0;
             Console.WriteLine("Введите матрицу: 5 строк по 7 элементов, через пробел:");
             for (int i = 0; i < n; i++)
             {
                 string str = Console.ReadLine();
                 double[] mas = str.Split(' ').Select(double.Parse).ToArray();
                 for (int j = 0; j < m; j++)
                 {
                     a[i, j] = mas[j];
                 }
             }
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     if (a[i, j] > max)
                     {
                         max = a[i, j];
                     }
                 }
                 for (int j = 0; j < m; j++)
                 {
                     if (a[i, j] > 0)
                     {
                         s += a[i, j];
                         x += 1;
                     }
                 }
                 if (x == 0)
                 {
                     t = 0;
                 }
                 else
                 {
                     t = s / x;
                 }
                 for (int j = 0; j < m; j++)
                 {
                     if (a[i, j] == max)
                     {
                         a[i, j] = t;
                     }
                 }
             }
             Console.WriteLine("Конечная матрица:");
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     Console.Write(a[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             #endregion */

            /* #region Task2.4 
             int n = 7; int m = 5;
             double [] b = new double[5];
             double [,] a = new double[n, m];
             double max = -100000;
             Console.WriteLine("Введите матрицу: 7 строк по 5 элементов, через пробел:");
             for (int i = 0; i < n; i++)
             {
                 string str = Console.ReadLine();
                 double[] mas = str.Split(' ').Select(double.Parse).ToArray();
                 for (int j = 0; j < m; j++)
                 {
                     a[i, j] = mas[j];
                 }
             }
             Console.WriteLine("Введите массив из 5 элементов");
             string st = Console.ReadLine();
             b = st.Split(' ').Select(double.Parse).ToArray();
             for (int j = 0; j < m; j++)
             {
                 for (int i = 0; i < n; i++)
                 {
                     if (a[i, j] > max)
                     {
                         max = a[i, j];
                     }
                 }
                 for (int i = 0; i < n; i++)
                 {
                     if ((a[i, j] == max) & (b[j] > a[i, j]))
                     {
                         a[i, j] = b[j];
                     }
                 }
             }
             Console.WriteLine("Конечная матрица:");
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     Console.Write(a[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             #endregion */

            /* #region 2_8 
             int n = 6; int m = 6;
             int J = -1;
             double []  a = new double[6];
             double [,] b = new double[n, m];
             double max = -1000000;
             Console.WriteLine("Введите матрицу: 6 строк по 6 элементов, через пробел:");
             for (int i = 0; i < n; i++)
             {
                 string str = Console.ReadLine();
                 double[] mas = str.Split(' ').Select(double.Parse).ToArray();
                 for (int j = 0; j < m; j++)
                 {
                     b[i, j] = mas[j];
                 }
             }
             Console.WriteLine("Исходная матрица:");
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     Console.Write(b[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             for (int i = 0; i < n; i++)
             {
                 max = -100000;
                 J = 0;
                 for (int j = 0; j < m; j++)
                 {
                     if (b[i, j] > max)
                     {
                         a[i] = b[i, j];
                         max = b[i, j];
                         J = j;
                     }
                 }
             }
             for (int i = 0; i < n; i += 2)
             {
                 for (int j = 0; j < m; j++)
                 {
                     if ((b[i, j] == a[i]))
                     {
                         b[i, j] = a[i + 1];
                     }
                 }
             }
             for (int i = 1; i < n; i += 2)
             {
                 for (int j = 0; j < m; j++)
                 {
                     if ((b[i, j] == a[i]))
                     {
                         b[i, j] = a[i - 1];
                     }
                 }
             }
             Console.WriteLine("Конечная матрица:");
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     Console.Write(b[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             #endregion */

            /* #region Task3.4
             Console.WriteLine("Введите количество строк:");
             int n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите количество столбцов:");
             int n2 = int.Parse(Console.ReadLine());
             double [,] a = new double[n1, n2];
             double [,] C = new double[n1, n2];
             int t = n1 / 2;
             Console.WriteLine(t);
             Console.WriteLine("Введите матрицу: " + n1 + " строк по " + n2 + " элементов,через пробел:");
             for (int i = 0; i < n1; i++)
             {
                 string str = Console.ReadLine();
                 double[] mass = str.Split(' ').Select(double.Parse).ToArray();
                 for (int j = 0; j < n2; j++)
                 {
                     a[i, j] = mass[j];
                     if (i >= t && j <= i)
                     {
                         C[i, j] = 1;
                     }
                     else
                     {
                         C[i, j] = a[i, j];
                     }
                 }
             }
             Console.WriteLine("Конечная матрица");
             for (int i = 0; i < n1; i++)
             {
                 for (int j = 0; j < n2; j++)
                 {
                     Console.Write(C[i, j] + " ");
                 }
                 Console.WriteLine();
             }
             #endregion */

            /* #region Task3.1
             int[,] a = new int[7, 6] { { 9, 5, 3, 2, 9, 0 }, { 7, 8, 5, 8, 4, 0 }, { 4, 6, 2, 5, 7, 0 }, { 1, 3, 6, 9, 8, 0 }, { 1, 2, 4, 5, 6, 0 }, { 13, 37, 35, 36, 37, 0 }, { 5, 7, 9, 0, 11, 0 } };
             int[] b = new int[7];
             int min, k, max, ind;
             for (int i = 0; i < 7; i++)
             {
                 min = a[i, 0];
                 for (int j = 0; j < 5; j++)
                 {
                     if (a[i, j] < min) min = a[i, j];
                 }
                 b[i] = min;
                 a[i, 5] = min;
             }
             for (int i = 0; i < 7; i++)
             {
                 Console.WriteLine();
                 for (int j = 0; j < 5; j++)
                 {
                     Console.Write("{0:d}\t", a[i, j]);
                 }
             }
             Console.WriteLine();
             for (int i = 0; i < 7; i++)
             {
                 max = b[i];
                 ind = i;
                 for (int j = i + 1; j < 7; j++)
                 {
                     if (b[j] > max)
                     {
                         max = b[j];
                         ind = j;
                     }
                 }
                 k = b[i];
                 b[i] = max;
                 b[ind] = k;
             }
             Console.WriteLine();
             int elem;
             for (int i = 0; i < 7; i++)
             {
                 elem = b[i];
                 ind = 0;
                 for (int j = 0; j < 7; j++)
                 {
                     if (a[j, 5] == elem)
                     {
                         ind = j;
                     }
                 }
                 for (int i2 = 0; i2 < 6; i2++)
                 {
                     k = a[i, i2];
                     a[i, i2] = a[ind, i2];
                     a[ind, i2] = k;
                 }
             }
             Console.WriteLine();
             for (int i = 0; i < 7; i++)
             {
                 Console.WriteLine();
                 for (int j = 0; j < 5; j++)
                 {
                     Console.Write("{0:d}\t", a[i, j]);
                 }
             }
            #endregion */
        }
    }
}


