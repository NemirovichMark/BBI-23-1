using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        #region 1-1
        Console.WriteLine("1-1:");
        double s = 0;
        double[] mas = new double[6];
        Console.WriteLine("Введите элементы массива(6):");
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

        #region 1-2
        Console.WriteLine("1-2:");
        mas = new double[8];
        double temp = 0;
        s = 0;
        Console.WriteLine("Введите элементы массива(8):");
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

        #region 1-3
        Console.WriteLine("1-3:");
        double[] mas1 = new double[4];
        double[] mas2 = new double[4];
        double[] mas3 = new double[4];
        double[] mas4 = new double[4];
        Console.WriteLine("Введите попарно элементы первого и второго массива(4):");
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

        #region 1-4
        Console.WriteLine("1-4:");
        mas = new double[5];
        s = 0;
        Console.WriteLine("Введите элементы массива(5):");
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

        #region 1-5
        Console.WriteLine("1-5:");
        mas1 = new double[4];
        mas2 = new double[4];
        s = 0;
        Console.WriteLine("Введите попарно элементы первого и второго массива");
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

        #region 1-6
        Console.WriteLine("1-6:");
        mas = new double[5];
        s = 0;
        Console.WriteLine("Ведите значения вектора(5):");
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

        #region 1-7
        Console.WriteLine("1-7:");
        mas = new double[7];
        s = 0;
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0;i < mas.Length;i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            s += mas[i];
        }
        s = s / mas.Length;
        for (int i = 0;i < mas.Length;i++)
        {
            if (mas[i] > s)
            {
                mas[i] = 0;
            }
        }
        Console.WriteLine("[{0}]", string.Join("; ", mas));
        Console.WriteLine();
        #endregion

        #region 1-8
        Console.WriteLine("1-8:");
        mas = new double[6];
        temp = 0;
        Console.WriteLine("Введите элементы массива(6):");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = double.Parse(Console.ReadLine());
            if (mas[i] < 0)
            {
                temp++;
            }
        }
        Console.WriteLine("Кол-во отрицательных элементов:");
        Console.WriteLine(temp);
        Console.WriteLine();
        #endregion

        #region 1-9
        Console.WriteLine("1-9:");
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
        Console.WriteLine("Кол-во элементов больших cр ар:");
        Console.WriteLine(temp);
        Console.WriteLine();
        #endregion

        #region 1-10
        Console.WriteLine("1-10:");
        mas = new double[10];
        double P = 0, Q = 0;
        temp = 0;
        Console.WriteLine("Введите левую границу:");
        P = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите правую границу:");
        Q = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите элементы массива(10):");
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

        #region 1-11
        Console.WriteLine("1-11:");
        mas = new double[10];
        int tempik = 0;
        int op = 0;
        Console.WriteLine("Введите эллементы массива(10):");
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
        Console.WriteLine("Новый массив с положительными зн:");
        Console.WriteLine("[{0}]", string.Join("; ", mas1));
        Console.WriteLine();
        #endregion

        #region 1-12
        Console.WriteLine("1-12:");
        mas = new double[8];
        double num = 0, znach = 0;
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0;i < mas.Length; i++)
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

        #region 1-13
        Console.WriteLine("1-13");
        mas = new double[10];
        mas1 = new double[5];
        mas2 = new double[5];
        int temp1 = 0;
        Console.WriteLine("Введите элементы массива(10):");
        int temp2 = 0;
        for (int i = 0;i < mas.Length;i++)
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
        Console.WriteLine("Новый массив с четн инд:");
        Console.WriteLine("[{0}]", string.Join("; ", mas1));
        Console.WriteLine("Новый массив с нечетн инд:");
        Console.WriteLine("[{0}]", string.Join("; ", mas2));
        Console.WriteLine();
        #endregion

        #region 1-14
        Console.WriteLine("1-14:");
        mas = new double[11];
        s = 0;
        Console.WriteLine("Введите элементы массива(11)");
        for(int i = 0; i < mas.Length;i++)
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
        Console.WriteLine("Сумма квадратов до отр члена:");
        Console.WriteLine(s);
        Console.WriteLine();
        #endregion

        #region 1-15
        Console.WriteLine("1-15:");
        double[] x = new double[10];
        double[] y = new double[10];
        Console.WriteLine("Введите элементы массива x(10):");
        for (int i = 0;i < x.Length;i++)
        {
            x[i] = double.Parse(Console.ReadLine());
            y[i] = 0.5 * Math.Log(x[i]);
            Console.WriteLine($"{x[i]} {y[i]}");
            Console.WriteLine();
        }
        #endregion

        #region 2-1
        Console.WriteLine("2-1:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string[] mass = str.Split(' ');
        double[] arr = new double[mass.Length];
        double minim = 1000000000;
        int temporary = 0;
        for(int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if(minim > arr[i])
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

        #region 2-2
        double su = 0;
        Console.WriteLine("2-2:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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
        for(int i = 0; i < temporary; i++)
        {
            su += arr[i];
        }
        Console.WriteLine("Сумма до макс элемента:");
        Console.WriteLine(su);
        Console.WriteLine();
        #endregion

        #region 2-3
        Console.WriteLine("2-3:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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
        for( int i = 0; i < temporary;i++)
        {
            arr[i] = arr[i] * 2;
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2-4
        Console.WriteLine("2-4:");
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

        #region 2-5
        Console.WriteLine("2-5:");
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
        if(g > t)
        {
            maxxx = (int)g;
            minnn = (int)t;
        }
        else
        {
            maxxx = (int)t;
            minnn = (int)g;
        }
        for(int i = minnn + 1; i < maxxx;i++)
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

        #region 2-6
        Console.WriteLine("2-6:");
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
        for (int i = 0;i < mass.Length; i++)
        {
            if(Math.Abs(su - arr[i]) <= minim)
            {
                minim = Math.Abs(su - arr[i]);
                temporary = i;
            }
        }
        arr1[temporary + 1] = P;
        for(int i = 0; i < arr.Length+1; i++)
        {
            if(i < (temporary + 1))
            {
                arr1[i] = arr[i];
            }
            else if(i > (temporary + 1))
            {
                arr1[i] = arr[i-1];
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr1));
        Console.WriteLine();
        #endregion

        #region 2-7
        Console.WriteLine("2-7:");
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

        #region 2-8
        Console.WriteLine("2-8:");
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
        for (int i = maxxx + 1; i < mass.Length;i++)
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

        #region 2-9
        Console.WriteLine("2-9:");
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
        for (int i = v+1; i < k;i++)
        {
            su += arr[i];
        }
        su = su / (k - v - 1);
        Console.WriteLine("Ср ар между мин и  макс эл:");
        Console.WriteLine(su);
        Console.WriteLine();
        #endregion

        #region 2-10
        Console.WriteLine("2-10:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        minim = 1000000000;
        temporary = 0;
        arr1 = new double[mass.Length-1];
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (minim > arr[i] && arr[i] > 0)
            {
                minim = arr[i];
                temporary = i;
            }
        }
        for(int i = 0; i < mass.Length; i++)
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

        #region 2-11
        Console.WriteLine("2-11:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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
                arr1[i] = arr[i-1];
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr1));
        Console.WriteLine();
        #endregion

        #region 2-12
        Console.WriteLine("2-12:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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

        #region 2-13
        Console.WriteLine("2-13:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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

        #region 2-14
        Console.WriteLine("2-14:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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

        #region 2-15
        Console.WriteLine("2-15:");
        Console.WriteLine("Введите размер массивa A:");    
        int n = (int)Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер массивa B:");
        int m = (int)Double.Parse(Console.ReadLine());
        double[] A = new double[n];
        double[] B = new double[m];
        double[] C = new double[n+m];
        Console.WriteLine("Введите k:");
        k = (int)Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите масив A:");
        for(int i = 0; i < n; i++)
        {
            A[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Введите массив B:");
        for (int j = 0; j < m; j++) 
        {
            B[j] = double.Parse(Console.ReadLine());
        }
        for(int i = 0; i < C.Length; i++)
        {
            if(i <= k)
            {
                C[i] = A[i];
            }
            if(i > k && i <= (k + m))
            {
                C[i] = B[i-k-1];
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

        #region 2-16
        Console.WriteLine("2-16:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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
        for (int i = 0;i < arr.Length; i++)
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

        #region 2-17
        Console.WriteLine("2-17:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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
        if(maxxx < minnn)
        {
            for(int i = 0; i < mass.Length;i++)
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

        #region 2-18
        Console.WriteLine("2-18:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        str = Console.ReadLine();
        mass = str.Split(' ');
        arr = new double[mass.Length];
        double maxim1 = -1000000000;
        double maxim2 = -1000000000;
        int chet = 0;
        int nechet= 0;
        temporary = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim1 < arr[i] && (i%2 == 0))
            {
                maxim1 = arr[i];
                chet = i;
            }
            if (maxim2 < arr[i] && (i%2 != 0))
            {
                maxim2 = arr[i];
                nechet = i;
            }
        }
        if (maxim1 > maxim2)
        {
            for (int i = 0;i < mass.Length / 2;i++)
            {
                arr[i] = 0;
            }
        }
        else
        {
            for (int i = mass.Length/2; i < mass.Length; i++)
            {
                arr[i] = 0;
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
        #endregion

        #region 2-19
        Console.WriteLine("2-19:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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
        if(maxim > su)
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

        #region 2-20
        Console.WriteLine("2-20:");
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
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
            if(temporary == -1 && arr[i] < 0)
            {
                temporary = i;
            }
        }
        if(temporary < minnn)
        {
            for(int i = 0;i < mass.Length;i += 2) 
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
        for(int i = 0;i < array.Length; i++)
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
        if(mem % 2 != 0)
        {
            mem -= 1;
        }
        for(int i = 0;i < mem; i+=2)
        {
            kran = array[i];
            array[i] = array[i+1];
            array[i + 1] = kran;

        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', array));
        Console.WriteLine();
        #endregion

    }
}
