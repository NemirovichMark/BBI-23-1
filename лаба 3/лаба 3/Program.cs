using System;
class Program
{
    public static void Main(string[] args)
    {
        #region 1_1
        Console.WriteLine("1_1:");
        double s = 0;
        double[] mas = new double[6];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            s += mas[i];
        }
        Console.WriteLine("Полученный массив:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = mas[i] / s;
        }
        Console.WriteLine("[{0}]", string.Join("; ", mas));
        Console.WriteLine();
        #endregion

        #region 1_2
        Console.WriteLine("1_2:");
        mas = new double[8];
        double temp = 0;
        s = 0;
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            if (mas[i] > 0)
            {
                s += mas[i];
                temp++;
            }
        }
        temp = s / temp;
        Console.WriteLine("Новый массив:");
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] > 0)
            {
                mas[i] = temp;
            }
        }
        Console.WriteLine("[{0}]", string.Join("; ", mas));
        Console.WriteLine();
        #endregion

        #region 1_3
        Console.WriteLine("1_3:");
        double[] mas1 = new double[4];
        double[] mas2 = new double[4];
        double[] mas3 = new double[4];
        double[] mas4 = new double[4];
        Console.WriteLine("Введите элементы 1 и 2 массива:");
        for (int i = 0; i < mas1.Length; i++)
        {
            mas1[i] = double.Parse(Console.ReadLine());
            mas2[i] = double.Parse(Console.ReadLine());
            mas3[i] = mas1[i] - mas2[i];
            mas4[i] = mas1[i] + mas2[i];
        }
        Console.WriteLine("Массив суммы:");
        Console.WriteLine("[{0}]", string.Join("; ", mas4));
        Console.WriteLine("Массив разности:");
        Console.WriteLine("[{0}]", string.Join("; ", mas3));
        Console.WriteLine();
        #endregion

        #region 1_4
        Console.WriteLine("1_4:");
        mas = new double[5];
        s = 0;
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            s += mas[i];
        }
        s = s / mas.Length;
        Console.WriteLine("Среднее арифметическое:");
        Console.WriteLine(s);
        Console.WriteLine();
        #endregion

        #region 1_5
        Console.WriteLine("1_5:");
        mas1 = new double[4];
        mas2 = new double[4];
        s = 0;
        Console.WriteLine("Введите элементы 1 и 2 массива");
        for (int i = 0; i < mas1.Length; i++)
        {
            mas1[i] = double.Parse(Console.ReadLine());
            mas2[i] = double.Parse(Console.ReadLine());
            s += mas1[i] * mas2[i];
        }
        Console.WriteLine("Скалярное произведение:");
        Console.WriteLine(s);
        Console.WriteLine();
        #endregion

        #region 1_6
        Console.WriteLine("1_6:");
        mas = new double[5];
        s = 0;
        Console.WriteLine("Ведите значения вектора:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            s += mas[i] * mas[i];
        }
        s = Math.Sqrt(s);
        Console.WriteLine("Длина вектора:");
        Console.WriteLine(s);
        Console.WriteLine();
        #endregion

        #region 1_7
        Console.WriteLine("1_7:");
        mas = new double[7];
        s = 0;
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            s += mas[i];
        }
        s = s / mas.Length;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] > s)
            {
                mas[i] = 0;
            }
        }
        Console.WriteLine("[{0}]", string.Join("; ", mas));
        Console.WriteLine();
        #endregion

        #region 1_8
        Console.WriteLine("1_8:");
        mas = new double[6];
        temp = 0;
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            if (mas[i] < 0)
            {
                temp++;
            }
        }
        Console.WriteLine("Количество отрицательных элементов:");
        Console.WriteLine(temp);
        Console.WriteLine();
        #endregion

        #region 1_9
        Console.WriteLine("1_9:");
        mas = new double[8];
        s = 0;
        temp = 0;
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            s += mas[i];
        }
        s = s / mas.Length;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] > s)
            {
                temp++;
            }
        }
        Console.WriteLine("Количество элементов больших cр.ар:");
        Console.WriteLine(temp);
        Console.WriteLine();
        #endregion

        #region 1_10
        Console.WriteLine("1_10:");
        mas = new double[10];
        double P = 0, Q = 0;
        temp = 0;
        Console.WriteLine("Введите левую границу:");
        P = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите правую границу:");
        Q = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            if (mas[i] > P && mas[i] < Q)
            {
                temp++;
            }
        }
        Console.WriteLine("Ответ:");
        Console.WriteLine(temp);
        Console.WriteLine();
        #endregion

        #region 1_11
        Console.WriteLine("1_11:");
        mas = new double[10];
        int tempik = 0;
        int op = 0;
        Console.WriteLine("Введите эллементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            if (mas[i] > 0)
            {
                tempik++;
            }
        }
        mas1 = new double[tempik];
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] > 0)
            {
                mas1[op] = mas[i];
                op++;
            }
        }
        Console.WriteLine("Новый массив:");
        Console.WriteLine("[{0}]", string.Join("; ", mas1));
        Console.WriteLine();
        #endregion

        #region 1_12
        Console.WriteLine("1_12:");
        mas = new double[8];
        double num = 0, znach = 0;
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            if (mas[i] < 0)
            {
                num = i + 1;
                znach = mas[i];
            }
        }
        Console.WriteLine("Значениe:");
        Console.WriteLine(znach);
        Console.WriteLine("Номер");
        Console.WriteLine(num);
        Console.WriteLine();
        #endregion

        #region 1_13
        Console.WriteLine("1_13");
        mas = new double[10];
        mas1 = new double[5];
        mas2 = new double[5];
        int temp1 = 0;
        Console.WriteLine("Введите элементы массива:");
        int temp2 = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                mas1[temp1] = mas[i];
                temp1++;
            }
            else
            {
                mas2[temp2] = mas[i];
                temp2++;
            }
        }
        Console.WriteLine("Новый массив с четным индексами:");
        Console.WriteLine("[{0}]", string.Join("; ", mas1));
        Console.WriteLine("Новый массив с нечетным индексами:");
        Console.WriteLine("[{0}]", string.Join("; ", mas2));
        Console.WriteLine();
        #endregion

        #region 1_14
        Console.WriteLine("1_14:");
        mas = new double[11];
        s = 0;
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] < 0)
            {
                break;
            }
            else
            {
                s += mas[i] * mas[i];
            }
        }
        Console.WriteLine("Сумма квадратов:");
        Console.WriteLine(s);
        Console.WriteLine();
        #endregion

        #region 1_15
        Console.WriteLine("1_15:");
        double[] x = new double[10];
        double[] y = new double[10];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < x.Length; i++)
        {
            x[i] = double.Parse(Console.ReadLine());
            y[i] = 0.5 * Math.Log(x[i]);
            Console.WriteLine($"{x[i]} {y[i]}");
            Console.WriteLine();
        }
        #endregion

        #region 2_1
        Console.WriteLine("2_1:");
        Console.WriteLine("Введите массив:");
        string str = Console.ReadLine();
        string[] mass = str.Split(' ');
        double[] arr = new double[mass.Length];
        double minim = 1000000000;
        int temporary = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (minim > arr[i])
            {
                minim = arr[i];
                temporary = i;
            }
        }
        arr[temporary] = minim * 2;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_2
        double su = 0;
        Console.WriteLine("2_2:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        double maxim = -100000000000;
        temporary = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                temporary = i;
            }
        }
        for (int i = 0; i < temporary; i++)
        {
            su += arr[i];
        }
        Console.WriteLine("Сумма до максимального элемента:");
        Console.WriteLine(su);
        Console.WriteLine();
        #endregion

        #region 2_3
        Console.WriteLine("2_3:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        minim = 1000000000;
        temporary = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (minim > arr[i])
            {
                minim = arr[i];
                temporary = i;
            }
        }
        for (int i = 0; i < temporary; i++)
        {
            arr[i] = arr[i] * 2;
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_4
        Console.WriteLine("2_4:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        maxim = -100000000000;
        su = 0;
        temporary = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            su += arr[i];
            if (maxim < arr[i])
            {
                maxim = arr[i];
                temporary = i;
            }
        }
        su = su / arr.Length;
        for (int i = temporary + 1; i < arr.Length; i++)
        {
            arr[i] = su;
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_5
        Console.WriteLine("2_5:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        maxim = -100000000000;
        minim = 1000000000000;
        su = 0;
        temporary = 0;
        double g = 0, t = 0;
        int maxxx, minnn;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            su += arr[i];
            if (maxim < arr[i])
            {
                maxim = arr[i];
                g = i;
            }
            if (minim > arr[i])
            {
                minim = arr[i];
                t = i;
            }
        }
        if (g > t)
        {
            maxxx = (int)g;
            minnn = (int)t;
        }
        else
        {
            maxxx = (int)t;
            minnn = (int)g;
        }
        for (int i = minnn + 1; i < maxxx; i++)
        {
            if (arr[i] < 0)
            {
                temporary++;
            }
        }
        double[] arr1 = new double[temporary];
        temporary = 0;
        for (int i = minnn + 1; i < maxxx; i++)
        {
            if (arr[i] < 0)
            {
                arr1[temporary] = arr[i];
                temporary++;
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr1));
        Console.WriteLine();
        #endregion

        #region 2_6
        Console.WriteLine("2_6:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        Console.WriteLine("Введите число P:");
        minnn = 1000000000;
        P = double.Parse(Console.ReadLine());
        mass = str.Split(' ');
        arr = new double[mass.Length];
        arr1 = new double[mass.Length + 1];
        temporary = 0;
        minim = 1000000000;
        su = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            su += arr[i];
        }
        su = su / arr.Length;
        Console.WriteLine(su);
        for (int i = 0; i < mass.Length; i++)
        {
            if (Math.Abs(su - arr[i]) <= minim)
            {
                minim = Math.Abs(su - arr[i]);
                temporary = i;
            }
        }
        arr1[temporary + 1] = P;
        for (int i = 0; i < arr.Length + 1; i++)
        {
            if (i < (temporary + 1))
            {
                arr1[i] = arr[i];
            }
            else if (i > (temporary + 1))
            {
                arr1[i] = arr[i - 1];
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr1));
        Console.WriteLine();
        #endregion

        #region 2_7
        Console.WriteLine("2_7:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        maxim = -10000000000;
        arr = new double[mass.Length];
        temporary = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                temporary = i;
            }
        }
        arr[temporary + 1] *= 2;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_8
        Console.WriteLine("2_8:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        maxim = -10000000000;
        minim = 10000000000;
        arr = new double[mass.Length];
        minnn = 0;
        maxxx = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                maxxx = i;
            }
        }
        for (int i = maxxx + 1; i < mass.Length; i++)
        {
            if (minim > arr[i])
            {
                minim = arr[i];
                minnn = i;
            }
        }
        arr[maxxx] = minim;
        arr[minnn] = maxim;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_9
        Console.WriteLine("2_9:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        maxim = -10000000000;
        minim = 10000000000;
        arr = new double[mass.Length];
        minnn = 0;
        maxxx = 0;
        int v = 0;
        int k = 0;
        su = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                maxxx = i;
            }
            if (minim > arr[i])
            {
                minim = arr[i];
                minnn = i;
            }
        }
        if (minnn < maxxx)
        {
            v = minnn;
            k = maxxx;
        }
        else
        {
            v = maxxx;
            k = minnn;
        }
        for (int i = v + 1; i < k; i++)
        {
            su += arr[i];
        }
        su = su / (k - v - 1);
        Console.WriteLine("Ср.ар между элементами:");
        Console.WriteLine(su);
        Console.WriteLine();
        #endregion

        #region 2_10
        Console.WriteLine("2_10:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        minim = 1000000000;
        temporary = 0;
        arr1 = new double[mass.Length - 1];
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
        Console.WriteLine();
        #endregion

        #region 2_11
        Console.WriteLine("2_11:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        Console.WriteLine("Введите число P");
        P = double.Parse(Console.ReadLine());
        mass = str.Split(' ');
        arr = new double[mass.Length];
        temporary = 0;
        arr1 = new double[mass.Length + 1];
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (arr[i] > 0)
            {
                temporary = i;
            }
        }
        temporary++;
        arr1[temporary] = P;
        for (int i = 0; i < mass.Length + 1; i++)
        {
            if (i < temporary)
            {
                arr1[i] = arr[i];
            }
            if (i > temporary)
            {
                arr1[i] = arr[i - 1];
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr1));
        Console.WriteLine();
        #endregion

        #region 2_12
        Console.WriteLine("2_12:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        minim = 1000000000;
        maxim = -100000000000;
        maxxx = 0;
        temporary = -1;
        su = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (arr[i] > maxim)
            {
                maxim = arr[i];
                maxxx = i;
            }
            if (temporary == -1 && arr[i] < 0)
            {
                temporary = i;
            }
        }
        for (int i = maxxx + 1; i < mass.Length; i++)
        {
            su += arr[i];
        }
        arr[temporary] = su;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_13
        Console.WriteLine("2_13:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        minim = 1000000000;
        maxim = -10000000000;
        temporary = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (i % 2 == 0 && arr[i] > maxim)
            {
                maxim = arr[i];
                temporary = i;
            }
        }
        arr[temporary] = temporary;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_14
        Console.WriteLine("2_14:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        minim = 1000000000;
        maxim = -10000000000;
        temporary = -1;
        su = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (arr[i] > maxim)
            {
                maxim = arr[i];
                maxxx = i;
            }
            if (temporary == -1 && arr[i] < 0)
            {
                temporary = i;
                su = arr[i];
            }
        }
        arr[temporary] = maxim;
        arr[maxxx] = su;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_15
        Console.WriteLine("2_15:");
        Console.WriteLine("Введите размер массивa A:");
        int n = (int)Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер массивa B:");
        int m = (int)Double.Parse(Console.ReadLine());
        double[] A = new double[n];
        double[] B = new double[m];
        double[] C = new double[n + m];
        Console.WriteLine("Введите k:");
        k = (int)Double.Parse(Console.ReadLine());
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

        #region 2_16
        Console.WriteLine("2_16:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        su = 0;
        temporary = 0;
        int al = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            su += arr[i];
        }
        su = su / arr.Length;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < su)
            {
                temporary++;
            }
        }
        double[] massivchik = new double[temporary];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < su)
            {
                massivchik[al] = i;
                al++;
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', massivchik));
        Console.WriteLine();
        #endregion

        #region 2_17
        Console.WriteLine("2_17:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        minim = 1000000000;
        maxim = -1000000000;
        maxxx = 0;
        minnn = 0;
        temporary = 0;
        su = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                maxxx = i;
            }
            if (minim > arr[i])
            {
                minim = arr[i];
                minnn = i;
            }
        }
        if (maxxx < minnn)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (arr[i] > 0)
                {
                    su += arr[i];
                    temporary++;
                }
            }
        }
        else
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (arr[i] < 0)
                {
                    su += arr[i];
                    temporary++;
                }
            }
        }
        su = su / temporary;
        Console.WriteLine("Среднее арифметичсекое:");
        Console.WriteLine(su);
        Console.WriteLine();
        #endregion

        #region 2_18
        Console.WriteLine("2_18:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        double maxim1 = -1000000000;
        double maxim2 = -1000000000;
        int chet = 0;
        int nechet = 0;
        temporary = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim1 < arr[i] && (i % 2 == 0))
            {
                maxim1 = arr[i];
                chet = i;
            }
            if (maxim2 < arr[i] && (i % 2 != 0))
            {
                maxim2 = arr[i];
                nechet = i;
            }
        }
        if (maxim1 > maxim2)
        {
            for (int i = 0; i < mass.Length / 2; i++)
            {
                arr[i] = 0;
            }
        }
        else
        {
            for (int i = mass.Length / 2; i < mass.Length; i++)
            {
                arr[i] = 0;
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_19
        Console.WriteLine("2_19:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        maxim = -1000000000;
        temporary = 0;
        su = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                temporary = i;
            }
        }
        if (maxim > su)
        {
            arr[temporary] = 0;
        }
        else
        {
            arr[temporary] *= 2;
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2_20
        Console.WriteLine("2_20:");
        Console.WriteLine("Введите массив:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        minim = 1000000000;
        temporary = -1;
        minnn = 0;
        su = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (minim > arr[i])
            {
                minim = arr[i];
                minnn = i;
            }
            if (temporary == -1 && arr[i] < 0)
            {
                temporary = i;
            }
        }
        if (temporary < minnn)
        {
            for (int i = 0; i < mass.Length; i += 2)
            {
                su += arr[i];
            }
        }
        else
        {
            for (int i = 1; i < mass.Length; i += 2)
            {
                su += arr[i];
            }
        }
        Console.WriteLine("Сумма:");
        Console.WriteLine(su);
        Console.WriteLine();
        #endregion
    }
}