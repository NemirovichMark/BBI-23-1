using System;
namespace ConsoleApp3
{
    class program
    {
        static void Main(string[] args)
        {
            /* #region Task1.1
             double s = 0;
             double [] a = new double[6];
             Console.WriteLine("Введите элементы массива(6):");
             for (int i=0; i<6; i++)
             {
                 a [i] = double.Parse(Console.ReadLine());
                 s += a[i];
             }
             Console.WriteLine("Полученный массив:");
             for (int i = 0; i < 6; i++)
             {
                 a[i] = a[i] / s;
             }
             Console.WriteLine("[{0}]", string.Join("; ", a));
             #endregion */

            /*  #region Task1.2
              double[] a = new double[8];
              double s = 0;
              double m = 0;
              Console.WriteLine("Введите элементы массива(8):");
              for (int i = 0; i < 8; i++)
              {
                  a[i] = double.Parse(Console.ReadLine());
                  if (a[i] > 0)
                {
                    s += a[i];
                    m++;
                }
              }
              m = s / m;
              Console.WriteLine("Новый массив:");
              for (int i = 0; i < 8; i++)
              {
                  if (a[i] > 0)
                  {
                      a[i] = m;
                  }
              }
              Console.WriteLine("[{0}]", string.Join("; ", a));
              #endregion */

            /*#region Task1.3 
             double[] a1 = new double[4];
             double[] a2 = new double[4];
             double[] a3 = new double[4];
             double[] a4 = new double[4];
             Console.WriteLine("Введите элементы первого и второго массива(4):");
             for (int i = 0; i < 4; i++)
             {
                 a1[i] = double.Parse(Console.ReadLine());
                 a2[i] = double.Parse(Console.ReadLine());
                 a3[i] = a1[i] + a2[i];
                 a4[i] = a1[i] - a2[i];
             }
             Console.WriteLine("Массив суммы:");
             Console.WriteLine("[{0}]", string.Join("; ", a3));
             Console.WriteLine("Массив разности:");
             Console.WriteLine("[{0}]", string.Join("; ", a4));
             #endregion */

            /*  #region Task1.4
              double[] a = new double[5];
              double s = 0;
              Console.WriteLine("Введите элементы массива(5):");
              for (int i = 0; i < 5; i++)
              {
                  a[i] = double.Parse(Console.ReadLine());
                  s += a[i];
              }
              s = s / 5;
              Console.WriteLine("Среднее арифметическое:");
              Console.WriteLine(s);
              #endregion */

            /*  #region Task1.5
              double[] a = new double[4];
              double[] b = new double[4];
              double s = 0;
              Console.WriteLine("Введите элементы первого и второго массива(4)");
              for (int i = 0; i < 4; i++)
              {
                  a[i] = double.Parse(Console.ReadLine());
                  b[i] = double.Parse(Console.ReadLine());
                  s += a[i] * b[i];
              }
              Console.WriteLine("Скалярное произведение:");
              Console.WriteLine(s);
              #endregion */

            /*  #region Task1.6
              double[] a = new double[5];
              double s = 0;
              Console.WriteLine("Введите значения вектора(5):");
              for (int i = 0; i < 5; i++)
              {
                  a[i] = double.Parse(Console.ReadLine());
                  s += a[i] * a[i];
              }
              s = Math.Sqrt(s);
              Console.WriteLine("Длина вектора:");
              Console.WriteLine(s);
              #endregion */

            /*  #region Task1.7
              double[] a = new double[7];
              double s = 0;
              Console.WriteLine("Введите элементы массива:");
              for (int i = 0; i < 7; i++)
              {
                  a[i] = double.Parse(Console.ReadLine());
                  s += a[i];
              }
              s = s / 7;
              for (int i = 0; i < 7; i++)
              {
                  if (a[i] > s)
                  {
                      a[i] = 0;
                  }
              }
              Console.WriteLine("[{0}]", string.Join("; ", a));
              Console.WriteLine();
              #endregion */

            /* #region Task1.8
             double[] a = new double[6];
             double s = 0;
             double m = 0;
             Console.WriteLine("Введите элементы массива(6):");
             for (int i = 0; i < 6; i++)
             {
                 a[i] = double.Parse(Console.ReadLine());
                 if (a[i] < 0)
                 {
                     m++;
                 }
             }
             Console.WriteLine("Кол-во отрицательных элементов:");
             Console.WriteLine(m);
             #endregion */

            /*  #region Task1.9
              double[] a = new double[8];
              double s = 0;
              double m = 0;
              Console.WriteLine("Введите элементы массива:");
              for (int i = 0; i < 8; i++)
              {
                  a[i] = double.Parse(Console.ReadLine());
                  s += a[i];
              }
              s = s / 8;
              for (int i = 0; i < 8; i++)
              {
                  if (a[i] > s)
                  {
                      m++;
                  }
              }
              Console.WriteLine("Кол-во элементов больше cреднего значения элементов массива:");
              Console.WriteLine(m);
              #endregion */

            /* #region Task1.10
             double[] a = new double[10];
             double P = 0;
             double Q = 0;
             double m = 0;
             Console.WriteLine("Введите левую границу:");
             P = double.Parse(Console.ReadLine());
             Console.WriteLine("Введите правую границу:");
             Q = double.Parse(Console.ReadLine());
             Console.WriteLine("Введите элементы массива(10):");
             for (int i = 0; i < 10; i++)
             {
                 a[i] = double.Parse(Console.ReadLine());
                 if (a[i] > P && a[i] < Q)
                 {
                     m++;
                 }
             }
             Console.WriteLine("Ответ:");
             Console.WriteLine(m);
             #endregion */

            /* #region Task1.11
             double[] a = new double[10];
             int p = 0;
             int o = 0;
             Console.WriteLine("Введите эллементы массива(10):");
             for (int i = 0; i < 10; i++)
             {
                 a[i] = double.Parse(Console.ReadLine());
                 if (a[i] > 0)
                 {
                     p++;
                 }    
             }
             double [] a1 = new double[p];
             for (int i = 0; i < 10; i++)
             {
                 if (a[i] > 0)
                 {
                     a1[o] = a[i];
                     o++;
                 }
             }
             Console.WriteLine("Новый массив с положительными знаком:");
             Console.WriteLine("[{0}]", string.Join("; ", a1));
             #endregion */

            /* #region Task1.12
             double[] a = new double[8];
             double n = 0;
             double x = 0;
             Console.WriteLine("Введите элементы массива:");
             for (int i = 0; i < 8; i++)
             {
                 a[i] = double.Parse(Console.ReadLine());
                 if (a[i] < 0)
                 {
                     n = i + 1;
                     x = a[i];
                 }
             }
             Console.WriteLine("Значениe:");
             Console.WriteLine(x);
             Console.WriteLine("Номер");
             Console.WriteLine(n);
             #endregion */

            /*  #region Task1.13
              double[] a = new double[10];
              double[] a1 = new double[5];
              double[] a2 = new double[5];
              int k1 = 0;
              Console.WriteLine("Введите элементы массива(10):");
              int k2 = 0;
              for (int i = 0; i < 10; i++)
              {
                  a[i] = double.Parse(Console.ReadLine());
                  if (i % 2 == 0)
                  {
                      a1[k1] = a[i];
                      k1++;
                  }
                  else
                  {
                      a2[k2] = a[i];
                      k2++;
                  }
              }
              Console.WriteLine("Новый массив с четным индексом:");
              Console.WriteLine("[{0}]", string.Join("; ", a1));
              Console.WriteLine("Новый массив с нечетным индексом:");
              Console.WriteLine("[{0}]", string.Join("; ", a2));
              #endregion */

            /*  #region Task1.14
              double[] a = new double[11];
              double s = 0;
              Console.WriteLine("Введите элементы массива(11)");
              for (int i = 0; i < 11; i++)
              {
                  a[i] = double.Parse(Console.ReadLine());
              }
              for (int i = 0; i < 11; i++)
              {
                  if (a[i] < 0)
                  {
                      break;
                  }
                  else
                  {
                      s += a[i] * a[i];
                  }
              }
              Console.WriteLine("Сумма квадратов до отрицательного члена:");
              Console.WriteLine(s);
              #endregion */

            /* #region Task1.15
             double[] x = new double[10];
             double[] y = new double[10];
             Console.WriteLine("Введите элементы массива x(10):");
             for (int i = 0; i < 10; i++)
             {
                 x[i] = double.Parse(Console.ReadLine());
                 y[i] = 0.5 * Math.Log(x[i]);
                 Console.WriteLine($"{x[i]}   {y[i]}");
             }
             #endregion */

            /* #region Task2.1
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double min = 10000;
             int t = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (min > b[i])
                 {
                     min = b[i];
                     t = i;
                 }
             }
             b[t] = min * 2;
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b));
             Console.WriteLine();
             #endregion */

            /*  #region Task2.2
              double s = 0;
              Console.WriteLine("Введите массив,элементы вводите через пробел:");
              string str = Console.ReadLine();
              string [] a = str.Split(' ');
              double[] b = new double[a.Length];
              double max = -10000;
              int t = 0;
              for (int i = 0; i < a.Length; i++)
              {
                  b[i] = double.Parse(a[i]);
                  if (max < b[i])
                  {
                      max = b[i];
                      t = i;
                  }
              }
              for (int i = 0; i < t; i++)
              {
                  s += b[i];
              }
              Console.WriteLine("Сумма до максимального элемента:");
              Console.WriteLine(s);
              #endregion */

            /* #region Task2.3
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double min = 1000;
             int t = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (min > b[i])
                 {
                     min = b[i];
                     t = i;
                 }
             }
             for (int i = 0; i < t; i++)
             {
                 b[i] = b[i] * 2;
             }
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b));
             #endregion */

            /*  #region Task2.4
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double max = -1000;
             double s = 0;
             int t = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 s += b[i];
                 if (max < b[i])
                 {
                     max = b[i];
                     t = i;
                 }
             }
             s = s / b.Length;
             for (int i = t + 1; i < b.Length; i++)
             {
                 b[i] = s;
             }
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b));
             #endregion */

            /* #region Task2.5
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string [] a = str.Split(' ');
             double[] b = new double[a.Length];
             double max = -10000;
             double min = 10000;
             double s = 0;
             int t = 0;
             double g = 0, k = 0;
             int amax, imin;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 s += b[i];
                 if (max < b[i])
                 {
                     max = b[i];
                     g = i;
                 }
                 if (min > b[i])
                 {
                     min = b[i];
                     k = i;
                 }
             }
             if (g > t)
             {
                 amax = (int)g;
                 imin = (int)k;
             }
             else
             {
                 amax = (int)k;
                 imin = (int)g;
             }
             for (int i = imin + 1; i < amax; i++)
             {
                 if (b[i] < 0)
                 {
                     t++;
                 }
             }
             double[] b1 = new double[t];
             t = 0;
             for (int i = imin + 1; i < amax; i++)
             {
                 if (b[i] < 0)
                 {
                     b1[t] = b[i];
                     t++;
                 }
             }
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b1));
             #endregion */

            /* #region Task2.6 
            Console.WriteLine("Введите массив,элементы вводите через пробел:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите число P:");
            double min = 10000;
            double P = double.Parse(Console.ReadLine());
            string [] a = str.Split(' ');
            double [] b = new double[a.Length];
            double[] c = new double[a.Length + 1];
            int t = 0;
            min = 10000;
            double s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = double.Parse(a[i]);
                s += b[i];
            }
            s = s / b.Length;
            Console.WriteLine(s);
            for (int i = 0; i < a.Length; i++)
            {
                if (Math.Abs(s - b[i]) <= min)
                {
                    min = Math.Abs(s - b[i]);
                    t = i;
                }
            }
            c[t + 1] = P;
            for (int i = 0; i < b.Length + 1; i++)
            {
                if (i < (t + 1))
                {
                    c[i] = b[i];
                }
                else if (i > (t + 1))
                {
                    c[i] = b[i - 1];
                }
            }
            Console.WriteLine("Полученный массив:");
            Console.WriteLine("[{0}]", string.Join(';', c));
            #endregion */

            /* #region Task2.7
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string [] a = str.Split(' ');
             double[] b = new double[a.Length];
             double max = -10000;
             int t = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (max < b[i])
                 {
                     max = b[i];
                     t = i;
                 }
             }
             b[t + 1] *= 2; 
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b));
             #endregion */

            /* #region Task2.8
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double max = -10000;
             double min = 10000;
             int imin = 0;
             int amax = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (max < b[i])
                 {
                     max = b[i];
                     amax = i;
                 }
             }
             for (int i = amax + 1; i < a.Length; i++)
             {
                 if (min > b[i])
                 {
                     min = b[i];
                     imin = i;
                 }
             }
             b[amax] = min;
             b[imin] = max;
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b));
             #endregion */

            /*  #region Task2.9
              Console.WriteLine("Введите массив,элементы вводите через пробел:");
              string str = Console.ReadLine();
              string[] a = str.Split(' ');
              double[] b = new double[a.Length];
              double max = -10000;
              double min = 10000;
              double s = 0;
              int imin = 0;
              int amax = 0;
              int d = 0, r = 0;
              for (int i = 0; i < a.Length; i++)
              {
                  b[i] = double.Parse(a[i]);
                  if (max < b[i])
                  {
                      max = b[i];
                      amax = i;
                  }
                  if (min > b[i])
                  {
                      min = b[i];
                      imin = i;
                  }
              }
              if (imin < amax)
              {
                  d = imin;
                  r = amax;
              }
              else
              {
                  d = amax;
                  r = imin;
              }
              for (int i = d + 1; i < r; i++)
              {
                  s += b[i];
              }
              s = s / (r - d - 1);
              Console.WriteLine("Среднее арифметическое между мин и  макс элементами:");
              Console.WriteLine(s);
              #endregion */

            /* #region Task2.10
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double[] c = new double[a.Length - 1];
             double min = 10000;
             int t = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (min > b[i] && b[i] > 0)
                 {
                     min = b[i];
                     t = i;
                 }
             }
             for (int i = 0; i < a.Length; i++)
             {
                 if (i < t)
                 {
                     c[i] = b[i];
                 }
                 if (i > t)
                 {
                     c[i - 1] = b[i];
                 }
             }
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', c));
             #endregion */

            /* #region Task2.11
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             Console.WriteLine("Введите число P");
             double P = double.Parse(Console.ReadLine());
             double[] b = new double[a.Length];
             double[] c = new double[a.Length + 1];
             int t = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (b[i] > 0)
                 {
                     t = i;
                 }
             }
             t++;
             c[t] = P;
             for (int i = 0; i < a.Length + 1; i++)
             {
                 if (i < t)
                 {
                     c[i] = b[i];
                 }
                 if (i > t)
                 {
                     c[i] = b[i - 1];
                 }
             }
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', c));
             #endregion */

            /* #region Task2.12
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
                 }
             }
             for (int i = amax + 1; i < a.Length; i++)
             {
                 s += b[i];
             }
             b[t] = s;
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b));
             #endregion */

            /* #region Task2.13
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double max = -10000;
             double min = 10000;
             int t = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (i % 2 == 0 && b[i] > max)
                 {
                     max = b[i];
                     t = i;
                 }
             }
             b[t] = t;
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b));
             #endregion */

            /*  #region Task2.14 
              Console.WriteLine("Введите массив,элементы вводите через пробел:");
              string str = Console.ReadLine();
              string[] a = str.Split(' ');
              double[] b = new double[a.Length];
              double max = -10000;
              double min = 10000;
              int s = 0;
              int amax = 0;
              int t = -1;
              for (int i = 0; i < mass.Length; i++)
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
            Console.WriteLine("Введите размер массивa A:");
            int n = (int)Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер массивa B:");
            int m = (int)Double.Parse(Console.ReadLine());
            double[] A = new double[n];
            double[] B = new double[m];
            double[] C = new double[n + m];
            Console.WriteLine("Введите k:");
            int k = (int)Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите масcив A:");
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
            #endregion */

            /* #region Task2.16
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double s = 0;
             int t = 0;
             int c = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 s += b[i];
             }
             s = s / b.Length;
             for (int i = 0; i < b.Length; i++)
             {
                 if (b[i] < s)
                 {
                     t++;
                 }
             }
             double[] m = new double[t];
             for (int i = 0; i < b.Length; i++)
             {
                 if (b[i] < s)
                 {
                     m[c] = i;
                     c++;
                 }
             }
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', m));
             #endregion */

            /* #region Task2.17
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double max = -10000;
             double min = 10000;
             double s = 0;
             int amax = 0;
             int imin = 0;
             int t = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (max < b[i])
                 {
                     max = b[i];
                     amax = i;
                 }
                 if (min > b[i])
                 {
                     min = b[i];
                     imin = i;
                 }
             }
             if (amax < imin)
             {
                 for (int i = 0; i < a.Length; i++)
                 {
                     if (b[i] > 0)
                     {
                         s += b[i];
                         t++;
                     }
                 }
             }
             else
             {
                 for (int i = 0; i < a.Length; i++)
                 {
                     if (b[i] < 0)
                     {
                         s += b[i];
                         t++;
                     }
                 }
             }
             s = s / t;
             Console.WriteLine("Среднее арифметичеcкое:");
             Console.WriteLine(s);
             #endregion */

            /*  #region Task2.18
              Console.WriteLine("Введите массив,элементы вводите через пробел:");
              string str = Console.ReadLine();
              string[] a = str.Split(' ');
              double[] b = new double[a.Length];
              double max1 = -10000;
              double max2 = -10000;
              int d = 0;
              int n = 0;
              for (int i = 0; i < a.Length; i++)
              {
                  b[i] = double.Parse(a[i]);
                  if (max1 < b[i] && (i % 2 == 0))
                  {
                      max1 = b[i];
                      d = i;
                  }
                  if (max2 < b[i] && (i % 2 != 0))
                  {
                      max2 = b[i];
                      n = i;
                  }
              }
              if (max1 > max2)
              {
                  for (int i = 0; i < a.Length / 2; i++)
                  {
                      b[i] = 0;
                  }
              }
              else
              {
                  for (int i = a.Length / 2; i < a.Length; i++)
                  {
                      b[i] = 0;
                  }
              }
              Console.WriteLine("Полученный массив:");
              Console.WriteLine("[{0}]", string.Join(';', b));
                  #endregion */

            /* #region Task2.19
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double max = -10000;
             double s = 0;
             int t = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (max < b[i])
                 {
                     max = b[i];
                     t = i;
                     s += b[i];
                 }
             }
             if (max > s)
             {
                 b[t] = 0;
             }
             else
             {
                 b[t]= b[t]*2;
             }
             Console.WriteLine("Полученный массив:");
             Console.WriteLine("[{0}]", string.Join(';', b));
             #endregion */

            /* #region Task2.20
             Console.WriteLine("Введите массив,элементы вводите через пробел:");
             string str = Console.ReadLine();
             string[] a = str.Split(' ');
             double[] b = new double[a.Length];
             double min = 10000;
             double s = 0;
             int imin = 0;
             int t = -1;
             for (int i = 0; i < a.Length; i++)
             {
                 b[i] = double.Parse(a[i]);
                 if (min > b[i])
                 {
                     min = b[i];
                     imin = i;
                 }
                 if (t == -1 && b[i] < 0)
                 {
                     t = i;
                 }
             }
             if (t < imin)
             {
                 for (int i = 0; i < a.Length; i += 2)
                 {
                     s += b[i];
                 }
             }
             else
             {
                 for (int i = 1; i < a.Length; i += 2)
                 {
                     s += b[i];
                 }
             }
             Console.WriteLine("Сумма:");
             Console.WriteLine(s);
             #endregion */

            /* #region Task3.1
             int t = 10;
             double [] a = new double[] { 1, 2, 5, 3, 4, 5, 2, 1, 5, -5 };
             double [] b = new double[t];
             int k = 0;
             int amax = 0;
             for (int i = 0; i < t; i++)
             {
                 if (a[i] == a[amax])
                 {
                     b[k] = i;
                     k++;
                 }
                 else if (a[i] > a[amax])
                 {
                     b[0] = i;
                     amax = i;
                     k = 1;
                 }
             }
             Console.Write("Исходный массив: ");
             for (int i = 0; i < t; i++) Console.Write("{0} ", a[i]);
             Console.WriteLine();
             for (int i = 0; i < k; i++)
             {
                 Console.Write("{0} ", a2[i]);
             }
             #endregion */

            /*  #region 3-3
              Console.WriteLine("Введите массив,элементы вводите через пробел:");
              string str = Console.ReadLine();
              string [] a = str.Split(' ');
              double[] b = new double[a.Length];
              double max = -10000;
              int t = 0;
              double j = 0;
              for (int i = 0; i < a.Length; i++)
              {
                  b[i] = double.Parse(a[i]);
                  if (max < b[i])
                  {
                      max = b[i];
                      t = i;
                  }
              }
              if (t % 2 != 0)
              {
                  t -= 1;
              }
              for (int i = 0; i < t; i += 2)
              {
                  j = b[i];
                  b[i] = b[i + 1];
                  b[i + 1] = j;

              }
              Console.WriteLine("Полученный массив:");
              Console.WriteLine("[{0}]", string.Join(';', b));
              Console.WriteLine();
              #endregion */
        }
    }
}

