using System.Runtime.Serialization.Formatters;

internal class Programm
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1:");
        Task1();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2:");
        Task2();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("3:");
        Task3();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("4:");
        Task4();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("5:");
        Task5();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("6:");
        Task6();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("7:");
        Task7();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("8:");
        Task8();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("9:");
        Task9();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("10:");
        Task10();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("11:");
        Task11();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("12:");
        Task12();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("13:");
        Task13();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("14:");
        Task14();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("15:");
        Task15();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_1:");
        Task2_1();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_2:");
        Task2_2();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_3:");
        Task2_3();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_4:");
        Task2_4();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_5:");
        Task2_5();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_6:");
        Task2_6();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_7:");
        Task2_7();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_8:");
        Task2_8();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_9:");
        Task2_9();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_10:");
        Task2_10();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_11:");
        Task2_11();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_12:");
        Task2_12();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_13:");
        Task2_13();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_14:");
        Task2_15();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_16:");
        Task2_16();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_1:");
        Task2_1();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_17:");
        Task2_17();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_18:");
        Task2_18();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_19:");
        Task2_19();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_20:");
        Task2_20();
    }
     private static void Task1()
     {
         double s = 0;
         double[] arr = new double[6];
         Console.WriteLine("Введите 6 элементов массива: ");
         for (int i = 0; i < arr.Length; i++)
         {
             double a = Convert.ToDouble(Console.ReadLine());
             arr[i] = a;
             s += arr[i];
         }
         Console.WriteLine("1_1: " + "[{0}]", string.Join("; ", arr));
         for (int i = 0; i < arr.Length; i++)
         {
             arr[i] = arr[i] / s;
         }
         Console.WriteLine("1_1: " + "[{0}]", string.Join("; ", arr));
         Console.WriteLine();
     }
     private static void Task2()
     {
         double s = 0;
         double arm = 0;
         double[] arr = new double[8];
         int k = 0;
         Console.WriteLine("Введите 8 элементов массива: ");
         for (int i = 0; i < arr.Length; i++)
         {
             double a = Convert.ToDouble(Console.ReadLine());
             arr[i] = a;
             if (arr[i] > 0)
             {
                 s += a;
                 k += 1;
             }
         }
         arm = s / k;
         for (int i = 0; i < arr.Length; i++)
         {
             if (arr[i] > 0)
             {
                 arr[i] = arm;
             }
         }
         Console.WriteLine("1_2: " + "[{0}]", string.Join("; ", arr));
     }
 }
 private static void Task3()
 {
     double [] arr1 = new double[4];
     double [] arr2 = new double[4];
     double [] arr3 = new double[4];
     Console.WriteLine("Введите 4 элементов 1-го массива: ");
     for (int i = 0; i < arr1.Length; i++)
     {
         double a = Convert.ToDouble(Console.ReadLine());
         arr1[i] = a;
     }
     Console.WriteLine("Введите 4 элементов 2-го массива: ");
     for (int i = 0; i < arr2.Length; i++)
     {
         double a = Convert.ToDouble(Console.ReadLine());
         arr2[i] = a;
     }
     for (int i = 0; i < arr3.Length; i++)
     {
         arr3[i] = arr1[i] + arr2[i];
     }
     Console.WriteLine("Сумма:" + "[{0}]", string.Join("; ", arr3));
     for (int i = 0; i < arr3.Length; i++)
     {
         arr3[i] = arr1[i] - arr2[i];
     }
     Console.WriteLine("Разность:" + "[{0}]", string.Join("; ", arr3));
     Console.WriteLine();
 }

 private static void Task4()
 {
     double sum = 0, arm;
     Console.WriteLine();
     double[] arr = new double[5];
     Console.WriteLine("Введите 5 элементов массива через пробел:");
     string str = Console.ReadLine();
     for (int i = 0; i < arr.Length; i++)
     {
         arr = str.Split(' ').Select(double.Parse).ToArray();
     }
     for (int i = 0; i < arr.Length; i++)
     {
         sum +=arr[i];
     }
     arm = sum / 5;
     Console.WriteLine("Преобразование массива");
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] = arr[i] - arm;
     }
     Console.WriteLine("[{0}]", string.Join("; ", arr));
     Console.WriteLine();
 }
 private static void Task5()
 {
     double c = 0;
     Console.WriteLine();
     double[] a = new double[4];
     Console.WriteLine("Введите элементы массива а");
     for(int i = 0; i < a.Length; i++)
     {
         a[i] = double.Parse(Console.ReadLine());
     }
     Console.WriteLine("Введите элементы массива b");
     double[] b = new double[4];
     for (int i = 0; i < b.Length; i++)
     {
         b[i] = double.Parse(Console.ReadLine());
     }
     for (int i = 0; i < b.Length; i++)
     {
         c = c + a[i] * b[i];
     }
     Console.WriteLine("Скалярное произведение векторов = {0}", c);
     Console.WriteLine();
 }
private static void Task6()
{
    {
        double[] arr = new double[5] {1, 4, 6, 7, 6};
        double L = 0;
        for(int i= 0; i < arr.Length; i++)
        {
            L += Math.Pow(arr[i], 2);
        }
        Console.WriteLine(Math.Sqrt(L));
    }
}
private static void Task7()
{
    double[] arr= new double[7] {5, -3, 7, 9, 10, -4, 8};
    double arm = 0;
    double S = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        S = arr[i];
    }
    arm = S / 7;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > arm)
        {
            arr[i] = 0;
        }
    }
    Console.WriteLine("[{0}]", string.Join("; ", arr));
}
private static void Task8()
{
    double[] arr= new double[6] {2, 7, 9 -10, 5, 6, 8};
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            k += 1;
        }
    }
    Console.WriteLine(k);
}
private static void Task9()
{
    double[] arr = new double[8] { 2, 7, 9 - 10, 5, 6, 8, -4, -8 };
    int k = 0;
    double arm = 0;
    double S = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        S = arr[i];
    }
    arm = S / 8;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>arm)
        {
            k += 1;
        }
    }
    Console.WriteLine(k);
}
private static void Task10()
{
    double[] arr= new double[10] {5, 6, 10, -11, -23, 8, 9, 4, 7, -5};
    double P = -10;
    double Q = 12;
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((P < arr[i]) && (arr[i] < Q) )
        {
            k += 1;
        }
    }
    Console.WriteLine(k);
}
private static void Task11()
{
    double[] arr = new double[10] { 5, 6, 10, -11, -23, 8, 9, 4, 7, -5 };
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) k++;
    }
    double[] arr2 = new double[k];

    int m = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] > 0))
        {
            arr2[m] = arr[i];
            m++;
        }
    }
    Console.WriteLine("[{0}]", string.Join("; ", arr2));
    Console.WriteLine();
private static void Task12()
{
    double[] arr = new double[8] { -3, 6, 10, -11, -23, 8, 9, -5 };
    double x = 0;
    double y = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] < 0))
        {
            x = i;
            y = arr[i];
        }
    }
    Console.WriteLine("значение:");
    Console.WriteLine(y);
    Console.WriteLine("номер:");
    Console.WriteLine(x);
    Console.WriteLine();
}
private static void Task13()
{
    double[] arr = new double[10] { 5, 6, 10, -11, -23, 8, 9, 4, 7, -5 };
    double[] arr2 = new double[5];
    double[] arr3 = new double[5];
    int k = 0;
    int h = 0;

    for (int i = 0; i < 10; i+=2)
    {
        arr2[h] = arr[i];
        h++;
    }
    for(int i = 1;i < 10; i+=2)
    {
        arr3[k] = arr[i];
        k++;
    }
    Console.WriteLine("[{0}]", string.Join("; ", arr2));
    Console.WriteLine();
    Console.WriteLine("[{0}]", string.Join("; ", arr3));
    Console.WriteLine();
}
private static void Task14()
{
    double[]arr = new double[11] { 5, 6, 10, -11, -23, 8, 9, 4, 7, -5, -7};
    double s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            break;
        }
        else
        {
            s += arr[i] * arr[i];
        }
    }
    Console.WriteLine("Сумма квадратов до - члена:");
    Console.WriteLine(s);
    Console.WriteLine();
}
private static void Task15()
{
    double[] x = new double[10];
    double[] y = new double[10];
    Console.WriteLine("Введите элементы массива x(10):");
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = double.Parse(Console.ReadLine());
        y[i] = 0.5 * Math.Log(x[i]);
        Console.WriteLine($"{x[i]} {y[i]}");
        Console.WriteLine();
    }
}
private static void Task2_1()
{
    Console.WriteLine("Введите массив:");
    string str = Console.ReadLine();
    string[] mass = str.Split(' ');
    double[] arr = new double[mass.Length];
    double minim = 1000000000;
    int temp = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        arr[i] = double.Parse(mass[i]);
        if (minim > arr[i])
        {
            minim = arr[i];
            temp = i;
        }
    }
    arr[temp] = minim * 2;
    Console.WriteLine("Полученный массив:");
    Console.WriteLine("[{0}]", string.Join(';', arr));
    Console.WriteLine();
}
private static void Task2_2()
{
    double sum = 0;
    Console.WriteLine("Введите массив:");
    string str = Console.ReadLine();
    string[] mass = str.Split(' ');
    double [] arr = new double[mass.Length];
    double maxim = -100000000000;
    double temporary = 0;
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
        sum += arr[i];
    }
    Console.WriteLine("Сумма до макс элемента:");
    Console.WriteLine(sum);
    Console.WriteLine();
}
    private static void Task2_3()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string[] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double minim = 1000000000;
        double temporary = 0;
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
    }
    private static void Task2_4()
    {
        Console.WriteLine("Введите массив:");
        string str = Console.ReadLine();
        string[] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double maxim = -100000000000;
        double sum = 0;
        int temporary = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            sum += arr[i];
            if (maxim < arr[i])
            {
                maxim = arr[i];
                temporary = i;
            }
        }
        sum = sum / arr.Length;
        for (int i = temporary + 1; i < arr.Length; i++)
        {
            arr[i] = sum;
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
    }
    private static void Task2_5()
    {
        Console.WriteLine("Введите массив:");
        string str = Console.ReadLine();
        string[] mass = str.Split(' ');
        double[] arr = new double[mass.Length];
        arr = new double[mass.Length];
        double maxim = -100000000000;
        double minim = 1000000000000;
        double sum = 0;
        int temp = 0;
        double g = 0, t = 0;
        int maxxx, minnn;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            sum += arr[i];
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
                temp++;
            }
        }
        double[] arr1 = new double[temp];
        temp = 0;
        for (int i = minnn + 1; i < maxxx; i++)
        {
            if (arr[i] < 0)
            {
                arr1[temp] = arr[i];
                temp++;
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr1));
        Console.WriteLine();
    }
    private static void Task2_6()
    {
        Console.WriteLine("Введите массив:");
        string str = Console.ReadLine();
        Console.WriteLine("Введите число P:");
        double min = 1000000000;
        double P = double.Parse(Console.ReadLine());
        string[] mass = str.Split(' ');
        double[] arr = new double[mass.Length];
        double[] arr1 = new double[mass.Length + 1];
        int temp = 0;
        double minim = 1000000000;
        double sum = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            sum += arr[i];
        }
        sum = sum / arr.Length;
        Console.WriteLine(sum);
        for (int i = 0; i < mass.Length; i++)
        {
            if (Math.Abs(sum - arr[i]) <= minim)
            {
                minim = Math.Abs(sum - arr[i]);
                temp = i;
            }
        }
        arr1[temp + 1] = P;
        for (int i = 0; i < arr.Length + 1; i++)
        {
            if (i < (temp + 1))
            {
                arr1[i] = arr[i];
            }
            else if (i > (temp + 1))
            {
                arr1[i] = arr[i - 1];
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr1));
        Console.WriteLine();
    }
    private static void Task2_7()
    {
        Console.WriteLine("Введите массив:");
        string str = Console.ReadLine();
        string[] mass = str.Split(' ');
        double maxim = -10000000000;
        double [] arr = new double[mass.Length];
        int temp = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                temp = i;
            }
        }
        arr[temp + 1] *= 2;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
    }
    private static void Task2_8()
    {
        Console.WriteLine("Введите массив:");
        string str = Console.ReadLine();
        string[] mass = str.Split(' ');
        double maxim = -10000000000;
        double minim = 10000000000;
        double [] arr = new double[mass.Length];
        int min = 0;
        int max = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                max = i;
            }
        }
        for (int i = max + 1; i < mass.Length; i++)
        {
            if (minim > arr[i])
            {
                minim = arr[i];
                min = i;
            }
        }
        arr[max] = minim;
        arr[min] = maxim;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
    }
    private static void Task2_9()
    {
        Console.WriteLine("Введите массив:");
        string str = Console.ReadLine();
        string[] mass = str.Split(' ');
        double maxim = -10000000000;
        double minim = 10000000000;
        double [] arr = new double[mass.Length];
        int min = 0;
        int max = 0;
        int x = 0;
        int k = 0;
        double sum = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                max = i;
            }
            if (minim > arr[i])
            {
                minim = arr[i];
                min = i;
            }
        }
        if (min < max)
        {
            x = min;
            k = max;
        }
        else
        {
            x = max;
            k = min;
        }
        for (int i = x + 1; i < k; i++)
        {
            sum += arr[i];
        }
        sum = sum / (k - x - 1);
        Console.WriteLine("Ср ар между мин и  макс эл:");
        Console.WriteLine(sum);
        Console.WriteLine();
    }
    private static void Task2_10()
    {
        Console.WriteLine("Введите массив:");
        string str = Console.ReadLine();
        string[] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double minim = 1000000000;
        int temp = 0;
        double [] arr1 = new double[mass.Length - 1];
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (minim > arr[i] && arr[i] > 0)
            {
                minim = arr[i];
                temp = i;
            }
        }
        for (int i = 0; i < mass.Length; i++)
        {
            if (i < temp)
            {
                arr1[i] = arr[i];
            }
            if (i > temp)
            {
                arr1[i - 1] = arr[i];
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr1));
        Console.WriteLine();
    }
    private static void Task2_11()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        Console.WriteLine("Введите число P");
        double P = double.Parse(Console.ReadLine());
        string[] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        int temp = 0;
        double [] arr1 = new double[mass.Length + 1];
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (arr[i] > 0)
            {
                temp = i;
            }
        }
        temp++;
        arr1[temp] = P;
        for (int i = 0; i < mass.Length + 1; i++)
        {
            if (i < temp)
            {
                arr1[i] = arr[i];
            }
            if (i > temp)
            {
                arr1[i] = arr[i - 1];
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr1));
        Console.WriteLine();
    }
    private static void Task2_12()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string [] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double minim = 1000000000;
        double maxim = -100000000000;
        int max = 0;
        int temp = -1;
        double sum = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (arr[i] > maxim)
            {
                maxim = arr[i];
                max = i;
            }
            if (temp == -1 && arr[i] < 0)
            {
                temp = i;
            }
        }
        for (int i = max + 1; i < mass.Length; i++)
        {
            sum += arr[i];
        }
        arr[temp] = sum;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
    }
    private static void Task2_13()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string [] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double minim = 1000000000;
        double maxim = -10000000000;
        int temp = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (i % 2 == 0 && arr[i] > maxim)
            {
                maxim = arr[i];
                temp = i;
            }
        }
        arr[temp] = temp;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
    }
    private static void Task2_14()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string [] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double minim = 1000000000;
        double maxim = -10000000000;
        int temp = -1;
        double sum = 0;
        int max = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (arr[i] > maxim)
            {
                maxim = arr[i];
                max = i;
            }
            if (temp == -1 && arr[i] < 0)
            {
                temp = i;
                sum = arr[i];
            }
        }
        arr[temp] = maxim;
        arr[max] = sum;
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
    }
    private static void Task2_15()
    {
        Console.WriteLine("Введите размер массивa A:");
        int n = (int)Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер массивa B:");
        int m = (int)Double.Parse(Console.ReadLine());
        double[] A = new double[n];
        double[] B = new double[m];
        double[] C = new double[n + m];
        Console.WriteLine("Введите k:");
        int k = (int)Double.Parse(Console.ReadLine());
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
    }
    private static void Task2_16()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string [] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double sum = 0;
        int temp = 0;
        int al = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            sum += arr[i];
        }
        sum = sum / arr.Length;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < sum)
            {
                temp++;
            }
        }
        double[] massivchik = new double[temp];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < sum)
            {
                massivchik[al] = i;
                al++;
            }
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', massivchik));
        Console.WriteLine();
    }
    private static void Task2_17()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string [] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double minim = 1000000000;
        double maxim = -1000000000;
        int max = 0;
        int min = 0;
        int temp = 0;
        double sum = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                max = i;
            }
            if (minim > arr[i])
            {
                minim = arr[i];
                min = i;
            }
        }
        if (max < min)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    temp++;
                }
            }
        }
        else
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                    temp++;
                }
            }
        }
        sum = sum / temp;
        Console.WriteLine("Среднее арифметичсекое:");
        Console.WriteLine(sum);
        Console.WriteLine();
    }
    private static void Task2_18()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string [] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double maxim1 = -1000000000;
        double maxim2 = -1000000000;
        int chet = 0;
        int nechet = 0;
        int temp = 0;
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
    }
    private static void Task2_19()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string [] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double maxim = -1000000000;
        int temp = 0;
        double sum = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (maxim < arr[i])
            {
                maxim = arr[i];
                temp = i;
            }
        }
        if (maxim > sum)
        {
            arr[temp] = 0;
        }
        else
        {
            arr[temp] *= 2;
        }
        Console.WriteLine("Полученный массив:");
        Console.WriteLine("[{0}]", string.Join(';', arr));
        Console.WriteLine();
    }
    private static void Task2_20()
    {
        Console.WriteLine("Введите массив,элементы вводите через пробел:");
        string str = Console.ReadLine();
        string [] mass = str.Split(' ');
        double [] arr = new double[mass.Length];
        double minim = 1000000000;
        int temp = -1;
        int min = 0;
        double sum = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            arr[i] = double.Parse(mass[i]);
            if (minim > arr[i])
            {
                minim = arr[i];
                min = i;
            }
            if (temp == -1 && arr[i] < 0)
            {
                temp = i;
            }
        }
        if (temp < min)
        {
            for (int i = 0; i < mass.Length; i += 2)
            {
                sum += arr[i];
            }
        }
        else
        {
            for (int i = 1; i < mass.Length; i += 2)
            {
                sum += arr[i];
            }
        }
        Console.WriteLine("Сумма:");
        Console.WriteLine(sum);
        Console.WriteLine();
    }
    static int Main(string[] args)
    {
        Console.WriteLine(3_5);
        Console.Write($"n: ");
        string input_n = Console.ReadLine();
        if (!int.TryParse(input_n, out var n) || (n < 2))
        {
            Console.WriteLine("Invalid n");
            return 1;
        }

        double[] arr = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Array_A[{i}]: ");
            string input_ai = Console.ReadLine();
            if (!double.TryParse(input_ai, out var a))
            {
                Console.WriteLine("Invalid number");
                return 1;
            }
            arr[i] = a;
        }
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                double min = arr[i];
                for (int j = i + 1; j < n; j++)
                {
                    if ((arr[j] < min) && (j % 2 == 0))
                    {
                        min = arr[j];
                        arr[j] = arr[i];
                        arr[i] = min;
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        return 0;
    }
     static int Task3_8()
    {
        Console.WriteLine(3_8);
        Console.Write($"n: ");
        string input_n = Console.ReadLine();
        if (!int.TryParse(input_n, out var n) || (n < 2))
        {
            Console.WriteLine("Invalid n");
            return 1;
        }

        double[] arr = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Arr_A[{i}]: ");
            string input_ai = Console.ReadLine();
            if (!double.TryParse(input_ai, out var a))
            {
                Console.WriteLine("Invalid number");
                return 1;
            }
            arr[i] = a;
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] < 0)
            {
                double max = arr[i];
                for (int j = i + 1; j < n; j++)
                {
                    if ((arr[j] > max) && (arr[j] < 0))
                    {
                        max = arr[j];
                        arr[j] = arr[i];
                        arr[i] = max;
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        return 0;
    }
}