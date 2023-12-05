using System;
using System.Buffers;
using System.Runtime.Intrinsics.X86;
 
namespace project
{
   class Project
   {
       static void Main()
       {
           double al = 0;
           int g = 0;
           int u = 0;
           double[,] matriza = new double[g, u];
           double[,] matriza1 = new double[g, u];
           double a = 0;
           double[] arr1 = new double[4];
           double[] arr2 = new double[4];
           double[] arr3 = new double[4];
           double s = 0;
           double min = 0;
           double min1 = 0;
           double max = 0;
           double ga = 0;
           int i = 0;
           int i1 = 0;
           int m = 0;
           int ll = 0;
           int hj = 0;
           string str = "";
 
           #region 1_4
           Console.WriteLine("1_4:");
           g = 3;
           u = 6;
           matriza = new double[g, u];
           min = Math.Pow(10, 20);
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
                   if (arr[j] < min)
                   {
                       min = arr[j];
                       i = i;
                       m = j;
                   }
               }
           }
       
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           Console.WriteLine("Номер строки и столбца с наименьшем элементом: " + (i+1) + " " + (m+1));
           #endregion
           Console.WriteLine();
 
 
           #region 1_8
           Console.WriteLine("1_8:");
           g = 4;
           u = 6;
           ga = u;
           al = 0;
           i = 0;
           matriza = new double[g, u];
           arr1 = new double[g];
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               al = 0;
               i = 0;
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
                   if (arr[j]>0)
                   {
                       al += arr[j];
                       i += 1;
                   }
               }
               arr1[i] = (al / i);
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           Console.WriteLine("Среднее арифметическое " + "[{0}]", string.Join("; ", arr1));
           #endregion
           Console.WriteLine();
 
 
           #region 1_12
           Console.WriteLine("1_12:");
           g = 6;
           u = 7;
           ga = u;
           al = 0;
           i = 0;
           m = 0;
           matriza = new double[g, u];
           matriza1 = new double[g-1, u-1];
           max = -Math.Pow(10, 20);
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
                   if (arr[j] > max)
                   {
                       max = arr[j];
                       i = i;
                       m = j;
                   }
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           Console.WriteLine("Максмальный элемент и его строка, столбец: " + max + " " + i + " " + m);
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   if ((i < i) & (j<m))
                   {
                       matriza1[i, j] = matriza[i, j];
                   }
                   if ((i < i) & (j > m))
                   {
                       matriza1[i, j-1] = matriza[i, j];
                   }
                   if ((i > i) & (j < m))
                   {
                       matriza1[i-1, j] = matriza[i, j];
                   }
                   if ((i > i) & (j > m))
                   {
                       matriza1[i - 1, j - 1] = matriza[i, j];
                   }
               }
           }
           for (int i = 0; i < (g-1); i++)
           {
               for (int j = 0; j < (u-1); j++)
               {
                   Console.Write(matriza1[i, j] + " ");
               }
               Console.WriteLine();
           }
           #endregion
           Console.WriteLine();
 
 
           #region 1_16
           Console.WriteLine("1_16:");
           g = int.Parse(Console.ReadLine());
           u = int.Parse(Console.ReadLine());
           m = 0;
           matriza = new double[g, u];
           max = -Math.Pow(10, 20);
           Console.WriteLine("количество строк матрицы"+ g + " количество элементов в строке "+u );
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
                   
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           for (int i = 0; i < g; i++)
           {
               max = -Math.Pow(10, 20);
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i,j] > max)
                   {
                       max = matriza[i, j];
                       m = j;
                   }
               }
               for (int j = m; j < (u-1); j++)
               {
                   matriza[i, j] = matriza[i, j + 1];
               }
               matriza[i, (u-1)] = max;
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           #endregion
           Console.WriteLine();
 
 
           #region 1_20
           Console.WriteLine("1_20:");
           g = int.Parse(Console.ReadLine());
           u = int.Parse(Console.ReadLine());
           al = 0;
           i = 0;
           i1 = 0;
           m = 0;
           matriza = new double[g, u];
           max = -Math.Pow(10, 20);
           min = Math.Pow(10, 20);
           min1 = Math.Pow(10, 20);
           Console.WriteLine("количество строк матрицы" + g + " количество элементов в строке " + u);
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           for (int i = 0; i < g; i++)
           {
               max = -Math.Pow(10, 20);
               min = Math.Pow(10, 20);
               min1 = Math.Pow(10, 20);
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i, j] > max)
                   {
                       max = matriza[i, j];
                       m = j;
                   }
               }
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i, j] < min1 & matriza[i, j]<0)
                   {
                       min1 = matriza[i, j];
                       i1 = j;
                   }
               }
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i, j] < min & matriza[i, j] < 0)
                   {
                       min = matriza[i, j];
                       i = j;
                       break;
                   }
               }
               al = (min + min1) / 2;
               if (al < 0)
               {
                   matriza[i, m] = al;
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           #endregion
           Console.WriteLine();
 
 
           #region 1_24
           Console.WriteLine("1_24:");
           g = 6;
           u = 5;
           al = 0;
           i = 0;
           i1 = 0;
           m = 0;
           s = 0;
           matriza = new double[g, u];
           max = -Math.Pow(10, 20);
           min = Math.Pow(10, 20);
           min1 = Math.Pow(10, 20);
           Console.WriteLine("количество строк матрицы" + g + " количество элементов в строке " + u);
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           for (int i = 0; i < g; i++)
           {
               max = -Math.Pow(10, 20);
               al = 0;
               i = 0;
               s = 0;
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i, j] > max)
                   {
                       max = matriza[i, j];
                       m = j;
                   }
               }
               for (int j = (m+1); j < u; j++)
               {
                   if (matriza[i, j] > 0)
                   {
                       al+= matriza[i, j];
                       i++;
                   }
               }
               if (i != 0)
               {
                   s = al / i;
                   for (int j = 0; j < m; j++)
                   {
                       if (matriza[i, j] < 0)
                       {
                           matriza[i, j] = s;
                       }
                   }
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           #endregion
           Console.WriteLine();
 
 
           #region 1_28
           Console.WriteLine("1_28:");
           g = 7;
           u = 5;
           al = 0;
           i = -1;
           matriza = new double[g, u];
           matriza1 = new double[g - 1, u];
           max = -Math.Pow(10, 20);
           Console.WriteLine("количество строк матрицы" + g + " количество элементов в строке " + u);
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           for (int i = 0; i < g; i++)
           {
               al = 0;
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i, j] > 0)
                   {
                       al += matriza[i, j];
                   }
               }
               if (al > max)
               {
                   max = al;
                   i = i;
               }
           }
           for (int i = 0; i < g-1; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   if (i < i)
                   {
                       matriza1[i, j] = matriza[i, j];
                   }
                   if (i >= i)
                   {
                       matriza1[i, j] = matriza[i+1, j];
                   }
               }
           }
           for (int i = 0; i < g-1; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza1[i, j] + " ");
               }
               Console.WriteLine();
           }
           #endregion
           Console.WriteLine();
 
 
           #region 1_32
           Console.WriteLine("1_32:");
           g = 5;
           u = 7;
           al = 0;
           i = -1;
           m = -1;
           s = 0;
           ga = 0;
           matriza = new double[g, u];
           max = -Math.Pow(10, 20);
           Console.WriteLine("количество строк матрицы" + g + " количество элементов в строке " + u);
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           for (int i = 0; i < g; i++)
           {
               al = 0;
               max = -Math.Pow(10, 20);
               s = 0;
               ga = 0;
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i, j] > max)
                   {
                       max = matriza[i, j];
                   }
               }
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i, j] > 0)
                   {
                       al += matriza[i, j];
                       ga += 1;
                   }
               }
               if (ga == 0)
               {
                   s = 0;
               }
               else
               {
                   s = al / ga;
               }
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i, j] == max)
                   {
                       matriza[i, j] = s;
                   }
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           #endregion
           Console.WriteLine();
 
 
           #region 2_4
           Console.WriteLine("2_4:");
           g = 7;
           u = 5;
           arr1 = new double[5];
           matriza = new double[g, u];
           max = -Math.Pow(10, 20);
           Console.WriteLine("количество строк матрицы" + g + " количество элементов в строке " + u);
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
               }
           }
           str = Console.ReadLine();
           arr1 = str.Split(' ').Select(double.Parse).ToArray();
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           for (int j = 0; j < u; j++)
           {
               max = -Math.Pow(10, 20);
               for (int i = 0; i < g; i++)
               {
                   if (matriza[i, j] > max)
                   {
                       max = matriza[i, j];
                   }
               }
               for (int i = 0; i < g; i++)
               {
                   if ((matriza[i, j] == max) & (arr1[j] > matriza[i, j]))
                   {
                       matriza[i, j] = arr1[j];
                   }
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           #endregion
           Console.WriteLine();
 
 
           #region 2_8
           Console.WriteLine("2_8:");
           g = 6;
           u = 6;
           al = 0;
           i = -1;
           m = -1;
           arr1 = new double[6];
           matriza = new double[g, u];
           max = -Math.Pow(10, 20);
           Console.WriteLine("количество строк матрицы" + g + " количество элементов в строке " + u);
           for (int i = 0; i < g; i++)
           {
               str = Console.ReadLine();
               double[] arr = str.Split(' ').Select(double.Parse).ToArray();
               for (int j = 0; j < u; j++)
               {
                   matriza[i, j] = arr[j];
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           for (int i = 0; i < g; i++)
           {
               max = -Math.Pow(10, 20);
               m = 0;
               for (int j = 0; j < u; j++)
               {
                   if (matriza[i, j] > max)
                   {
                       arr1[i] = matriza[i, j];
                       max = matriza[i, j];
                       m = j;
                   }
               }
           }
           for (int i = 0; i < g; i+=2)
           {
               for (int j = 0; j < u; j++)
               {
                   if ((matriza[i, j] == arr1[i]))
                   {
                       matriza[i, j] = arr1[i+1];
                   }
               }
           }
           for (int i = 1; i < g; i += 2)
           {
               for (int j = 0; j < u; j++)
               {
                   if ((matriza[i, j] == arr1[i]))
                   {
                       matriza[i, j] = arr1[i - 1];
                   }
               }
           }
           for (int i = 0; i < g; i++)
           {
               for (int j = 0; j < u; j++)
               {
                   Console.Write(matriza[i, j] + " ");
               }
               Console.WriteLine();
           }
           #endregion
           Console.WriteLine();
 
 
           #region 3_3
           int[,] a = new int[6, 6] {{1,2,3,4,5,6 },
                                     {7,19,9,10,11,12},
                                     {14,16,15,1,2,3},
                                     {14,-15,-16,1,-2,-5},
                                     {-1,4,3,-6,20,14},
                                     {1,2,3,4,5,6 } };
           //int[,] a = new int[4, 4] { { 1, 2, 3, 4 },
           //                           { 1, 2, 3, 4 },
           //                           { 1, 2, 3, 4 },
           //                           { 1, 2, 3, 4 }};
           int n = 6;
           int[] b = new int[2 * n - 1];
           int p = 0;
 
           Console.WriteLine("Вывод изначальной матрицы:");
           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   Console.Write($"{a[i, j],5}");
               }
               Console.WriteLine();
           }
 
           Console.WriteLine();
 
           for (int i = n - 1; i != 0; i--)
           {
               int s = 0;
               for (int j = 0; j + i != n; j++)
               {
                   s += a[i + j, j];
               }
               b[p] = s;
               p++;
           }
           for (int i = n - 1; i != -1; i--)
           {
               int s = 0;
               for (int j = 0; j + i != n; j++)
               {
                   s += a[j, j + i];
               }
               b[p] = s;
               p++;
           }
 
           Console.WriteLine("Полученный вектор:");
           int sum = 0;
           foreach (int i in b)
           {
               Console.Write($"{i} ");
               sum += i;
           }
           Console.WriteLine();
           Console.WriteLine($"Сумма: {sum}");
           #endregion
           Console.WriteLine();
 
           #region 3_13
           int n = 3;
           int nMinus = n - 1;
           double[,] a = new double[3, 3] { {1,2,3},
                                         {4,5,6},
                                         {7,8,9} };
 
           Console.WriteLine("Вывод изначальной матрицы:");
           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   Console.Write($"{a[i, j],5}");
               }
               Console.WriteLine();
           }
 
           Console.WriteLine();
           for (int i = nMinus; i > 0;)
           {
               for (int j = i; ; j--)
               {
                   if (j < 0)
                   {
                       goto NextLine;
                   }
                   if (a[j, i] == 0)
                   {
                       continue;
                   }
                   if (j != i)
                   {
                       for (int k = i; k < n; k++)
                       {
                           (a[i, k], a[j, k]) = (a[j, k], a[i, k]);
                       }
                   }
                   break;
               }
               int iPlus = i - 1;
               for (int j = iPlus; j >= 0; j--)
               {
                   double mult = a[j, i] / a[i, i];
                   a[j, i] = 0;
                   for (int k = iPlus; k >= 0; k--)
                   {
                       a[j, k] -= a[i, k] * mult;
                   }
               }
           NextLine:
               i--;
           }
           Console.WriteLine("Новый массив");
           for (int k = 0; k < n; k++)
           {
               for (int j = 0; j < n; j++)
               {
                   Console.Write($"{a[k, j],6:f3} ");
               }
               Console.WriteLine();
           }
           #endregion
           Console.WriteLine();
       }
   }
}
