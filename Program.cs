using System;
class Programm

{
    //номер 22 (если считать с Карасевым) 
    //1 уровень: 3 7 11 15 19 23 27 31 
    //2 уровень: 3 7 
    //3 уровень: 8 9
    static void Main(string[] args)
    {
        #region 1_3
        int n = 4, m = 4;
        double[,] arr = new double[n, m];
        double su = 0;
        Console.WriteLine("Введите матрицу: 4 х 4 через пробел:");
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
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
        for (int i = 0; i < n; i++)
        {
            su = su + arr[i, i] + arr[i, (n - 1) - i];
        }
        Console.WriteLine("Сумма диагональных элементов:");
        Console.WriteLine(su);
        Console.WriteLine();
        #endregion

        #region 1_7
        n = 3;
        m = 5;
        double max = -Math.Pow(10, 20);
        int ind = 0;
        double[] mas = new double[m];
        arr = new double[n, m];
        Console.WriteLine("Введите матрицу: 3 х 5 через пробел:");

        for (int i = 0; i < n; i++)

        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)

            {
                arr[i, j] = mass[j];
            }
        }

        for (int j = 0; j < m; j++)

        {
            for (int i = 0; i < n; i++)

            {
                if (arr[i, j] > max)

                {
                    max = arr[i, j];
                }
            }
            mas[j] = max;
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
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', mas));
        Console.WriteLine();
        #endregion

        #region 1_11
        n = 5;
        m = 7;
        double min = Math.Pow(10, 20);
        arr = new double[n, m];
        double[,] array = new double[n - 1, m];
        ind = 0;
        double maxim = -Math.Pow(10, 20);
        Console.WriteLine("Введите матрицу: 5 х 7 через пробел:");

        for (int i = 0; i < n; i++)

        {
            string str = Console.ReadLine();
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

            Console.WriteLine();

        for (int i = 0; i < n; i++)

        {
            for (int j = 0; j < m; j++)
            {
                if (i < ind)

                {
                    array[i, j] = arr[i, j];
                }
                if (i > ind)

                {
                    array[i - 1, j] = arr[i, j];
                }
            }
        }
        Console.WriteLine("Итоговая матрица:");

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
        
        #region 1_15
        n = 5;
        m = 7;
        arr = new double[n, m];
        double[,] arr1 = new double[n, m];
        Console.WriteLine("Введите матрицу: 5 х 7 через пробел:");
        for (int i = 0; i < n; i++)

        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                arr1[i, j] = arr[i, j] * (i + 1);
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
        Console.WriteLine("Итоговая матрица:");

        for (int i = 0; i < n - 1; i++)

        {
            for (int j = 0; j < m; j++)

            {
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion
        
        #region 1_19
        Console.WriteLine("Введите кол-во строк:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        m = int.Parse(Console.ReadLine());
        arr = new double[n, m];
        int[] x = new int[n];
        max = -Math.Pow(10, 20);
        ind = 0;
        Console.WriteLine("Введите матрицу через пробел:");

        for (int i = 0; i < n; i++)

        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();

            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (mass[j] > max)
                {
                    max = mass[j];
                    ind = j;
                }
            }
            x[i] = ind;
            max = -Math.Pow(10, 20);
            ind = 0;
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
                if (arr[i, j] < 0 && j < x[i])
                {
                    arr[i, j] = arr[i, j] / arr[i, x[i]];
                }
            }
        }
        Console.WriteLine("Итоговая матрица");

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

        n = 5;
        m = 7;
        arr = new double[n, m];
        arr1 = new double[n, m];
        x = new int[n];
        max = -Math.Pow(10, 20);
        ind = 0;
        Console.WriteLine("Введите матрицу через пробел:");

        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
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
            x[i] = ind;
            ind = 0;
            max = -Math.Pow(10, 20);
        }
        Console.WriteLine("Итоговая матрица:");

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
                if (j <= x[i])

                {
                    arr1[i, j] = arr[i, j];
                }

                if ((j - 1) == x[i])

                {
                    arr1[i, j] = arr[i, j - 1];
                }

                if ((j - 1) > x[i])

                {
                    arr1[i, j] = arr[i, j - 1];
                }
            }
        }
        Console.WriteLine("Итоговая матрица");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)

            {
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion
        
        #region 1_27
        n = 5;
        m = 7;
        arr = new double[n, m];
        x = new int[n];
        max = -Math.Pow(10, 20);
        ind = 0;
        Console.WriteLine("Введите матрицу через пробел:");
        
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
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
            x[i] = ind;
            ind = 0;
            max = -Math.Pow(10, 20);
        }
        Console.WriteLine("Итоговая матрица:");

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
            arr[i, 3] = arr[i, x[i]];
        }

        Console.WriteLine("Итоговая матрица");
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

        #region 2_3
        n = 10;
        m = 5;
        ind = 0;
        su = 0;
        arr = new double[n, m];
        max = -Math.Pow(10, 20);
        Console.WriteLine("Введите матрицу через пробел");

        for (int i = 0; i < n; i++)
        {
            string str1 = Console.ReadLine();
            double[] mass = str1.Split(' ').Select(double.Parse).ToArray();

            for (int j = 0; j < m; j++)

            {
                arr[i, j] = mass[j];
            }
        }
        Console.WriteLine("Итоговая матрица:");

        for (int i = 0; i < n; i++)

        {
            for (int j = 0; j < m; j++)

            {
                Console.Write(arr[i, j] + " ");
            }

            Console.WriteLine();
        }

        for (int j = 0; j < m; j++)

        {
            max = -Math.Pow(10, 20);
            ind = 0;
            su = 0;

            for (int i = 0; i < n; i++)

            {
                if (arr[i, j] > max)

                {
                    max = arr[i, j];
                    ind = i;
                }
            }

            if (ind <= 4)

            {
                for (int i = ind + 1; i < n; i++)

                {
                    su += arr[i, j];
                }

                arr[0, j] = su;
            }
        }
        Console.WriteLine("Итоговая матрица:");

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

        #region 2_7
        n = 6;
        m = 6;
        ind = 0;
        su = 0;
        arr = new double[n, m];
        max = -Math.Pow(10, 20);
        Console.WriteLine("Введите матрицу через пробел");

        for (int i = 0; i < n; i++)
        {
            string str1 = Console.ReadLine();
            double[] mass = str1.Split(' ').Select(double.Parse).ToArray();

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

        for (int i = 0; i < n; i++)

        {
            if (arr[i, i] > max)
            {
                max = arr[i, i];
                ind = i;
            }
        }
        for (int i = 0; i < n; i++)

        {
            for (int j = 0; j < m; j++)

            {
                if ((i < ind) & (j > i))
                {
                    arr[i, j] = 0;
                }
            }
        }
        Console.WriteLine("Итоговая матрица:");

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

        #region 3_8
        int e = 7, f = 5;
        double[,] a = new double[f, m];
        int k = 0;
        Console.WriteLine("Введите матрицу: 7 х 5 через пробел:");
        for (int i = 0; i < f; i++)
        {
            string s = Console.ReadLine();
            double[] b = s.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < e; j++)
            {
                a[i, j] = b[j];
                if (a[i, j] >= 0) { k++; }
            }
        }
        if (k == 0)
        {
            Console.WriteLine("В матрице отсутсвуют положительные элементы.");
        }
        if (k == e * f)
        {
            Console.WriteLine("Все элементы матрицы положительны.");
        }
        if (k != 0 && k < e * f)
        {
            for (int i = 0; i < f - 1; i++)
            {
                for (int l = 0; l < f - i - 1; l++)
                {
                    int pol1 = 0, pol2 = 0;
                    for (int j = 0; j < e; j++)
                    {
                        if (a[l, j] >= 0) { pol1++; }
                        if (a[l + 1, j] >= 0) { pol2++; }
                    }

                    if (pol2 > pol1)
                    {
                        for (int j = 0; j < e; j++)
                        {
                            double t = a[l + 1, j];
                            a[l + 1, j] = a[l, j];
                            a[l, j] = t;
                        }
                    }
                }
            }
            Console.WriteLine("Итоговая матрица:");

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < e; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region 3_9
        Console.WriteLine("Введите матрицу: 5 х 7 через пробел:");
        for (int i = 0; i < f; i++)
        {
            string s = Console.ReadLine();
            double[] b = s.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < e; j++)
            {
                a[i, j] = b[j];
                if (a[i, j] < 0) { k++; }
            }
        }

        if (k == 0)
        {
            Console.WriteLine("В матрице отсутствуют отриц. элементы.");
        }
        else if (k == f * m)
        {
            Console.WriteLine("Все элементы матрицы отрицательны.");
        }
        else
        {
            for (int j = 0; j < m - 1; j++)
            {

                for (int l = 0; l < m - 1 - j; l++)
                {
                    int otr1 = 0;
                    int otr2 = 0;

                    for (int i = 0; i < f; i++)
                    {
                        if (a[i, l] < 0) { otr1++; }
                        if (a[i, l + 1] < 0) { otr2++; }
                    }

                    if (otr1 > otr2)
                    {
                        for (int i = 0; i < m; i++)
                        {
                            double t = a[i, l];
                            a[i, l] = a[i, l + 1];
                            a[i, l + 1] = t;
                        }
                    }
                }
            }

            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
