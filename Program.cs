////#region 1.1
//Console.WriteLine("1.:");
//int n = 5, m = 7;
//double[,] a = new double[n, m];
//string s;
//double sum = 0;
//Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
//for (int i = 0; i < n; i++)
//{
//    s = Console.ReadLine();
//    double[] mass = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = mass[j];
//        sum += mass[j];
//    }
//}
//Console.WriteLine($"Сумма элементов массива: {sum}");
//Console.WriteLine();
////#endregion

////#region 1.5
//Console.WriteLine("1.5");
//int n = 5;
//int m = 4;
//double[,] a = new double[n, m];
//int iot = 0;
//int jot = 0;
//int k = 0;
//string s;
//Console.WriteLine("Введите 5 строки по 4 элемента, через пробел:");
//for (int i = 0; i < n; i++)
//{
//    s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = b[j];
//        if (a[i, j] < 0) { k++; };
//    }
//}
//if (k == 0) { Console.WriteLine("Отсутсвуют отрицательные элементы."); }
//if (k > 0)
//{
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < m; j++)
//        {
//            if (a[i, j] < 0) { iot = i; jot = j; break; }
//        }
//    }
//    Console.WriteLine($"Первый отрицательный элемент находится в строке {iot} и в столбце {jot}, его значение {a[iot, jot]}.");
//}
////#endregion

////#region 1.9

//double[,] a = new double[5, 7];
//string s;
//Console.WriteLine("Введите 5 строк по 7 элементов, разделяя их пробелом:");
//for (int i = 0; i < 5; i++)
//{
//    s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < 7; j++)
//    {
//        a[i, j] = b[j];
//    }
//}
//for (int i = 0; i < 5; i++)
//{
//    double amax = a[i, 0];
//    int imax = 0;
//    for (int j = 1; j < 7; j++)
//    {
//        if (a[i, j] > amax) { imax = j; amax = a[i, j]; }
//    }
//    double t = a[i, 0];
//    a[i, 0] = amax;
//    a[i, imax] = t;
//}
//Console.WriteLine("Полученный массив:");
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        Console.Write(a[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

////#endregion

////#region 1.13

//double[,] a = new double[5, 5];
//string s;
//Console.WriteLine("Введите 5 строк по 5 элементов, рахделяя их пробелом.");
//for (int i = 0; i < 5; i++)
//{
//    s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < 5; j++)
//    {
//        a[i, j] = b[j];
//    }
//}
//double amax = a[0, 0];
//int jmax = 0;
//for (int i = 1; i < 5; i++)
//{
//    if (a[i, i] > amax) { jmax = i; amax = a[i, i]; }
//}
//if (jmax == 3) { Console.WriteLine("Минимальный элемент главной диагонали находился в 4 столбце. Невозможно поменять местами."); }
//if (jmax != 3)
//{
//    for (int i = 0; i < 5; i++)
//    {
//        double t = a[i, 3];
//        a[i, 3] = a[i, jmax];
//        a[i, jmax] = t;
//    }
//    Console.WriteLine("Полученый массив:");
//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            Console.Write(a[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}
//Console.WriteLine();

////#endregion

////#region 1.17

//Console.Write("Введите количество строк n:");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите количество столбцов m:");
//int m = int.Parse(Console.ReadLine());
//double[,] a = new double[n, m];
//Console.WriteLine($"Введите {n} строк по {m} элементов, разделяя их пробелом:");
//string s;
//for (int i = 0; i < n; i++)
//{
//    s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = b[j];
//    }
//}
//for (int i = 0; i < n; i++)
//{
//    int imin = 0;
//    double amin = a[i, 0];
//    for (int j = 0; j < m; j++)
//    {
//        if (amin > a[i, j]) { amin = a[i, j]; imin = j; }
//    }
//    for (int j = imin; j > 0; j--)
//    {
//        a[i, j] = a[i, j - 1];
//    }
//    a[i, 0] = amin;
//}
//Console.WriteLine("Матрица, после изменений:");
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        Console.Write(a[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

////#endregion

////#region 1.21

//int n = 5, m = 7;
//double[,] a = new double[n, m];
//Console.WriteLine("Введите 5 строк по 6 элементов, разделяя их пробелом:");
//for (int i = 0; i < n; i++)
//{
//    string s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < 6; j++)
//    {
//        a[i, j] = b[j];
//    }
//}
//double[] c = new double[n];
//for (int i = 0; i < n; i++)
//{
//    double amax = a[i, 0];
//    for (int j = 1; j < 6; j++)
//    {
//        if (a[i, j] > amax) { amax = a[i, j]; }
//    }
//    c[i] = amax;
//}
//for (int i = 0; i < n; i++)
//{
//    double t = a[i, 5];
//    a[i, 5] = c[i];
//    a[i, 6] = t;
//}
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        Console.Write(a[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////#endregion

////#region 1.25

//int n = 6, m = 5;
//int k = 0;  //счетчик отричательных элементов
//double[,] a = new double[n, m];
//Console.WriteLine("Введите 6 строк по 5 элементов, разделяя их пробелом:");
//for (int i = 0; i < n; i++)
//{
//    string s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = b[j];
//        if (a[i, j] < 0) { k++; }
//    }
//}
//if (k == 0) { Console.WriteLine("В матрице отсутсвуют отрицаиельные элементы."); }
//if (k != 0)
//{
//    double[] c = new double[n];
//    for (int i = 0; i < n; i++)
//    {
//        int ot = 0;//счетчик отриц. элементов в строке
//        for (int j = 0; j < m; j++)
//        {
//            if (a[i, j] < 0) { ot++; }
//        }
//        c[i] = ot;
//    }
//    int imin = 0;
//    int imax = 0;
//    double cmin = n;
//    double cmax = 0;
//    for (int i = 0; i < n; i++)
//    {
//        if (cmin > c[i]) { cmin = c[i]; imin = i; }
//        if (cmax < c[i]) { cmax = c[i]; imax = i; }
//    }
//    for (int j = 0; j < m; j++)
//    {
//        double t = a[imin, j];
//        a[imin, j] = a[imax, j];
//        a[imax, j] = t;
//    }
//    Console.WriteLine("Изменённая матрица:");
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < m; j++)
//        {
//            Console.Write(a[i, j] + " ");
//        }
//        Console.WriteLine();
//    }

//}

////#endregion

////#region 1.29

//int n = 5, m = 7;
//double[,] a = new double[n, m];
//Console.WriteLine("Введите 5 строк по 7 элементов, разделяя их пробелом:");
//for (int i = 0; i < n; i++)
//{
//    string s = Console.ReadLine();
//    double[] b = Array.ConvertAll(s.Split(' '), double.Parse);
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = b[j];
//    }
//}
//double amin = Math.Abs(a[1, 0]);
//int jmin = 0;
//for (int j = 0; j < m; j++)
//{
//    if (Math.Abs(a[1, j]) < amin)
//    {
//        amin = Math.Abs(a[1, j]);
//        jmin = j;
//    }
//}
//if (jmin == 6)
//{
//    Console.WriteLine("Минимальный по модулю элемент во второй строке находится в 7 столбце. Невозможно удалить следующий столбец.");
//}
//else
//{
//    m--;

//    for (int i = 0; i < n; i++)
//    {
//        for (int j = jmin + 1; j < m; j++)
//        {
//            a[i, j] = a[i, j + 1];
//        }
//    }
//    Console.WriteLine("Изменённый массив:");
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < m; j++)
//        {
//            Console.Write(a[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}

////#endregion

////#region 1.33

//int n = 5, m = 7;
//double[,] a = new double[n, m];
//int k = 0; //счетский отриц. элементов
//Console.WriteLine("Введите 5 строк по 7 элементов, разделяя их пробелом:");
//for (int i = 0; i < n; i++)
//{
//    string s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = b[j];
//        if (a[i, j] < 0) { k++; }
//    }
//}
//if (k == 0) { Console.WriteLine("В матрице отсутствуют отрицательные элементы."); }
//else
//{
//    double[] c = new double[k];
//    int counter = 0; //счетчик для заполнения массива c
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < m; j++)
//        {
//            if (a[i, j] < 0)
//            {
//                c[counter++] = a[i, j];
//            }
//        }
//    }
//    Console.WriteLine("Полученный массив:");
//    for (int i = 0; i < k; i++)
//    {
//        Console.Write(c[i] + " ");
//    }
//    Console.WriteLine();
//}

////#endregion

////#region 2.4

//int m = 5;
//double[] b = new double[m];
//for (int i = 0; i < m; i++)
//{
//    Console.Write($"Введите элемент массива {i + 1}: ");
//    b[i] = double.Parse(Console.ReadLine());
//}

//int n = 7;
//double[,] a = new double[n, m];

//Console.WriteLine("Введите 7 строк по 5 элементов, разделяя их пробелом:");
//for (int i = 0; i < n; i++)
//{
//    string s = Console.ReadLine();
//    double[] c = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = c[j];
//    }
//}

//for (int j = 0; j < m; j++)
//{
//    double amax = a[0, j];
//    int jmax = 0;

//    for (int i = 1; i < n; i++)
//    {
//        if (a[i, j] > amax)
//        {
//            amax = a[i, j];
//            jmax = i;
//        }
//    }

//    if (b[j] > amax)
//    {
//        a[jmax, j] = b[j];
//    }
//}

//Console.WriteLine("Изменённая матрица:");

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        Console.Write(a[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////#endregion

////#region 2.8

//int n = 6, m = 6;
//double[,] a = new double[n, m];
//Console.WriteLine("Введите 6 строк по 6 элементов, разделяя их пробелом:");
//for (int i = 0; i < n; i++)
//{
//    string s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = b[j];
//    }
//}

//for (int i = 0; i < n; i += 2)
//{
//    int max1 = 0;
//    int max2 = 0;
//    for (int j = 0; j < m; j++)
//    {
//        if (a[i, j] > a[i, max1]) { max1 = j; }
//        if (a[i + 1, j] > a[i + 1, max2]) { max2 = j; }
//    }
//    double t = a[i, max1];
//    a[i, max1] = a[i + 1, max2];
//    a[i + 1, max2] = t;
//}
//Console.WriteLine("Матрица после изменений:");
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        Console.Write(a[i, j] + " ");
//    }
//    Console.WriteLine();
//}

////#endregion

////#region 3.8
//int n = 7, m = 5;
//double[,] a = new double[n, m];
//int k = 0;//счётчик положительных элементов
//Console.WriteLine("Введите 7 строк по 5 элементов, раздлеяя их пробелом.");
//for (int i = 0; i < n; i++)
//{
//    string s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = b[j];
//        if (a[i, j] >= 0) { k++; }
//    }
//}
//if (k == 0)
//{
//    Console.WriteLine("В матрице отсутсвуют положительные элементы.");
//}
//if (k == m * n)
//{
//    Console.WriteLine("Все элементы матрицы положительны.");
//}
//if (k != 0 && k < n * m)
//{
//    for (int i = 0; i < n - 1; i++)
//    {
//        for (int l = 0; l < n - i - 1; l++)
//        {
//            int po1 = 0, po2 = 0;
//            for (int j = 0; j < m; j++)
//            {
//                if (a[l, j] >= 0) { po1++; }
//                if (a[l + 1, j] >= 0) { po2++; }
//            }

//            if (po2 > po1)
//            {
//                // Обмен строк
//                for (int j = 0; j < m; j++)
//                {
//                    double t = a[l + 1, j];
//                    a[l + 1, j] = a[l, j];
//                    a[l, j] = t;
//                }
//            }
//        }
//    }
//    Console.WriteLine("Изменённая матрица:");

//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < m; j++)
//        {
//            Console.Write(a[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}
////#endregion

////#region 3.9
//int n = 5, m = 7;
//double[,] a = new double[n, m];
//int k = 0; // счетчик отрицательных элементов
//Console.WriteLine("Введите 5 строк по 7 элементов, разделяя их пробелом:");
//for (int i = 0; i < n; i++)
//{
//    string s = Console.ReadLine();
//    double[] b = s.Split(' ').Select(double.Parse).ToArray();
//    for (int j = 0; j < m; j++)
//    {
//        a[i, j] = b[j];
//        if (a[i, j] < 0) { k++; }
//    }
//}

//if (k == 0)
//{
//    Console.WriteLine("В матрице отсутствуют отрицательные элементы");
//}
//else if (k == n * m)
//{
//    Console.WriteLine("Матрица полностью состоит из отрицательных элементов.");
//}
//else
//{
//    for (int j = 0; j < m - 1; j++)
//    {

//        for (int l = 0; l < m - 1 - j; l++)
//        {
//            int ot1 = 0;
//            int ot2 = 0;

//            for (int i = 0; i < n; i++)
//            {
//                if (a[i, l] < 0) { ot1++; }
//                if (a[i, l + 1] < 0) { ot2++; }
//            }

//            if (ot1 > ot2)
//            {
//                for (int i = 0; i < n; i++)
//                {
//                    double t = a[i, l];
//                    a[i, l] = a[i, l + 1];
//                    a[i, l + 1] = t;
//                }
//            }
//        }
//    }

//    Console.WriteLine("Изменённая матрица:");
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < m; j++)
//        {
//            Console.Write(a[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}
////#endregion