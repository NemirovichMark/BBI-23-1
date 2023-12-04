using System;

class Program
{
    public static void Main(string[] args)
    {
        //номер 2
        #region 1_3
        //int n = 3;
        //int m = 6;
        //int a = 0, b = 0;
        //double min = 10000000000000;
        //double [,] arr = new double[n, m];
        //Console.WriteLine("Введите матрицу: 3 строки по 6 эллементов,через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m; j++)
        //    {
        //        arr[i, j] = mass[j];
        //        if (arr[i, j] < min)
        //        {
        //            min = arr[i, j];
        //            a = i;
        //            b = j;
        //        }
        //    }
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("Строка:");
        //Console.WriteLine(a + 1);
        //Console.WriteLine("Столбец:");
        //Console.WriteLine(b + 1);
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion

        #region 1_7        
        //int n = 3;
        //int m = 5;
        //double max = double.MinValue;
        //int ind = 0;
        //int[] mas = new int[m];
        //double[,] arr = new double[n, m];
        //Console.WriteLine("Введите матрицу: 3 строки по 5 элементов, через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m; j++)
        //    {
        //        arr[i, j] = mass[j];
        //    }
        //}
        //for (int j = 0; j < m; j++)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (arr[i, j] > max)
        //        {
        //            max = arr[i, j];
        //            ind = i;
        //        }
        //    }
        //    mas[j] = ind;
        //    max = double.MinValue;
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.WriteLine("Полученный массив индексов:");
        //Console.WriteLine("[{0}]", string.Join(';', mas));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion
        #region 1_11
        //int n = 5;
        //int m = 7;
        //double min = 100000000000;
        //double[,] arr = new double[n, m];
        //double[,] array = new double[n - 1, m];
        //int ind = 0;
        //double maxim = -10000000000;
        //double temp = 0;

        //Console.WriteLine("Введите матрицу: 5 строк по 7 элементов, через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m; j++)
        //    {
        //        arr[i, j] = mass[j];
        //        if (mass[j] < min && j == 0)
        //        {
        //            min = mass[j];
        //            ind = i;
        //        }
        //    }
        //}

        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();

        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        if (i < ind)
        //        {
        //            array[i, j] = arr[i, j];
        //        }
        //        if (i > ind)
        //        {
        //            array[i - 1, j] = arr[i, j];
        //        }
        //    }
        //}

        //Console.WriteLine("Конечная матрица:");
        //for (int i = 0; i < n - 1; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(array[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();
        #endregion

        #region 1_15
        //int n = 5;
        //int m = 7;
        //double [,]arr = new double[n, m];
        //double [,]array = new double[n, m];
        //Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m; j++)
        //    {
        //        arr[i, j] = mass[j];
        //        array[i, j] = arr[i, j] * (i + 1);
        //    }
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.WriteLine("Конечная матрица:");
        //for (int i = 0; i < n - 1; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(array[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion

        #region 1_19
        //Console.WriteLine("Введите кол-во строк:");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите кол-во столбцов:");
        //int m = int.Parse(Console.ReadLine());
        //double [,] A = new double[n, m];
        //int [] B = new int[n];
        //double max = -10000000000000;
        //int ind = 0;
        //Console.WriteLine("Введите матрицу: " + n + " строк по " + m + " эллементов,через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m; j++)
        //    {
        //        A[i, j] = mass[j];
        //        if (mass[j] > max)
        //        {
        //            max = mass[j];
        //            ind = j;
        //        }
        //    }
        //    B[i] = ind;
        //    max = -1000000000000000;
        //    ind = 0;
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(A[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        if (A[i, j] < 0 && j < B[i])
        //        {
        //            A[i, j] = A[i, j] / A[i, B[i]];
        //        }
        //    }
        //}
        //Console.WriteLine("Конечная матрица");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(A[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion

        #region 1_23
        //int n = 5;
        //int m = 7;
        //double [,] arr = new double[n, m];
        //double [,] array = new double[n, m];
        //int [] D = new int[n];
        //double max = -100000000000000;
        //int ind = 0;
        //Console.WriteLine("Введите матрицу: 5 строк по 6 эллементов,через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m - 1; j++)
        //    {
        //        arr[i, j] = mass[j];
        //        if (arr[i, j] > max)
        //        {
        //            max = mass[j];
        //            ind = j;
        //        }
        //    }
        //    D[i] = ind;
        //    ind = 0;
        //    max = -10000000000000000;
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        if (j <= D[i])
        //        {
        //            array[i, j] = arr[i, j];
        //        }
        //        if ((j - 1) == D[i])
        //        {
        //            array[i, j] = arr[i, j - 1];
        //        }
        //        if ((j - 1) > D[i])
        //        {
        //            array[i, j] = arr[i, j - 1];
        //        }
        //    }
        //}
        //Console.WriteLine("Конечная матрица");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(array[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion

        #region 1_27
        //int n = 5;
        //int m = 7;
        //double[,] arr = new double[n, m];
        //int[] D = new int[n];
        //double max = -100000000000000;
        //int ind = 0;
        //Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m; j++)
        //    {
        //        arr[i, j] = mass[j];
        //        if (arr[i, j] > max)
        //        {
        //            max = mass[j];
        //            ind = j;
        //        }
        //    }
        //    D[i] = ind;
        //    ind = 0;
        //    max = -10000000000000000;
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    arr[i, 3] = arr[i, D[i]];
        //}
        //Console.WriteLine("Конечная матрица");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion
        #region 1_31
        //int n = 5;
        //int m = 8;
        //double[,] arr = new double[n, m];
        //int[] D = new int[n];
        //double max = -100000000000000;

        //Console.WriteLine("Введите первые 7 столбцов матрицы A:");

        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    string[] mss = str.Split(' ');

        //    for (int j = 0; j < m - 1; j++)
        //    {
        //        arr[i, j] = double.Parse(mss[j]);
        //    }
        //}

        //Console.WriteLine("Введите вектор B размера 5:");
        //string vector = Console.ReadLine();
        //string[] vectorrr = vector.Split(' ');
        //double[] vectorB = new double[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    vectorB[i] = double.Parse(vectorrr[i]);
        //}

        //int minind = -1;
        //double minValue = double.MaxValue;
        //for (int j = 0; j < m - 1; j++)
        //{
        //    double minzn = double.MaxValue;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (arr[i, j] < minzn)
        //        {
        //            minzn = arr[i, j];
        //        }
        //    }
        //    if (minzn < minValue)
        //    {
        //        minValue = minzn;
        //        minind = j;
        //    }
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = m - 1; j > minind; j--)
        //    {
        //        arr[i, j] = arr[i, j - 1];
        //    }
        //    arr[i, minind + 1] = vectorB[i];
        //}

        //Console.WriteLine("Матрица A после добавления вектора B:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.ReadLine();
        #endregion

        #region 2_1
        //int n = 5;
        //int m = 7;
        //double [, ]arr = new double[n, m];
        //int [] D = new int[n];
        //double max = -100000000000000;
        //int ind = 0;
        //Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m; j++)
        //    {
        //        arr[i, j] = mass[j];
        //        if (arr[i, j] > max)
        //        {
        //            max = mass[j];
        //            ind = j;
        //        }
        //    }
        //    D[i] = ind;
        //    ind = 0;
        //    max = -10000000000000000;
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    if (D[i] == 0)
        //    {
        //        arr[i, 1] = arr[i, 1] * 2;
        //    }
        //    else if (D[i] == (m - 1))
        //    {
        //        arr[i, (m - 2)] = arr[i, (m - 2)] * 2;
        //    }
        //    else
        //    {
        //        if (arr[i, D[i] - 1] < arr[i, D[i] + 1])
        //        {
        //            arr[i, D[i] - 1] = arr[i, D[i] - 1] * 2;
        //        }
        //        else
        //        {
        //            arr[i, D[i] + 1] = arr[i, D[i] + 1] * 2;
        //        }
        //    }
        //}
        //Console.WriteLine("Конечная матрица");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion

        #region 2_5
        //int n = 7;
        //int m = 5;
        //double [, ] arr = new double[n, m];
        //int [] D = new int[n];
        //double max = -100000000000000;
        //int ind = 0;
        //int su = 0;
        //Console.WriteLine("Введите матрицу: 7 строк по 5 эллементов,через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m; j++)
        //    {
        //        arr[i, j] = mass[j];
        //    }
        //}
        //for (int i = 0; i < m; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        if (arr[j, i] > max)
        //        {
        //            max = arr[i, j];
        //            ind = j;
        //        }
        //    }
        //    D[i] = ind;
        //    ind = 0;
        //    max = -10000000000000000;
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //for (int i = 0; i < m; i++)
        //{
        //    su = (int)(arr[0, i] + arr[(n - 1), i]) / 2;
        //    if (arr[D[i], i] < su)
        //    {
        //        arr[D[i], i] = su;
        //    }
        //    else
        //    {
        //        arr[D[i], i] = D[i];
        //    }
        //}
        //Console.WriteLine("Конечная матрица");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion

        #region 2_9
        //int n = 6;
        //int m = 7;
        //double [, ]arr = new double[n, m];
        //double[, ]  C = new double[n, m];
        //int [] D = new int[n];
        //Console.WriteLine("Введите матрицу: 6 строк по 7 эллементов,через пробел:");
        //for (int i = 0; i < n; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < m; j++)
        //    {
        //        arr[i, j] = mass[j];
        //    }
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        C[i, j] = arr[i, (m - 1) - j];
        //    }
        //}
        //Console.WriteLine("Конечная матрица");
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(C[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion
        #region 3_2
        //Console.WriteLine("Введите кол-во строк:");
        //int n1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите кол-во столбцов:");
        //int n2 = int.Parse(Console.ReadLine());
        //double [, ] arr = new double[n1, n2];
        //double [, ] C = new double[n1, n2];
        //Console.WriteLine("Введите матрицу: " + n1 + " строк по " + n2 + " эллементов,через пробел:");
        //for (int i = 0; i < n1; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < n2; j++)
        //    {
        //        arr[i, j] = mass[j];
        //        if (i == 0 || j == 0 || i == (n1 - 1) || j == (n2 - 1))
        //        {
        //            C[i, j] = 0;
        //        }
        //        else
        //        {
        //            C[i, j] = arr[i, j];
        //        }
        //    }
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n1; i++)
        //{
        //    for (int j = 0; j < n2; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.WriteLine("Конечная матрица");
        //for (int i = 0; i < n1; i++)
        //{
        //    for (int j = 0; j < n2; j++)
        //    {
        //        Console.Write(C[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion
        #region 3_4
        //Console.WriteLine("Введите кол-во строк:");
        //int n1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите кол-во столбцов:");
        //int n2 = int.Parse(Console.ReadLine());
        //double[,] arr = new double[n1, n2];
        //double [,]C = new double[n1, n2];
        //int tempura = 0;
        //tempura = n1 / 2;
        //Console.WriteLine(tempura);
        //Console.WriteLine("Введите матрицу: " + n1 + " строк по " + n2 + " эллементов,через пробел:");
        //for (int i = 0; i < n1; i++)
        //{
        //    string str = Console.ReadLine();
        //    double[] mass = str.Split(' ').Select(double.Parse).ToArray();
        //    for (int j = 0; j < n2; j++)
        //    {
        //        arr[i, j] = mass[j];
        //        if (i >= tempura && j <= i)
        //        {
        //            C[i, j] = 1;
        //        }
        //        else
        //        {
        //            C[i, j] = arr[i, j];
        //        }
        //    }
        //}
        //Console.WriteLine("Исходная матрица:");
        //for (int i = 0; i < n1; i++)
        //{
        //    for (int j = 0; j < n2; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.WriteLine("Конечная матрица");
        //for (int i = 0; i < n1; i++)
        //{
        //    for (int j = 0; j < n2; j++)
        //    {
        //        Console.Write(C[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion


    }
}