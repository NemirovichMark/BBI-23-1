using System;

class Program
{

    public static void Main(string[] args)
    {
        #region 1_1
        //double sum = 0;
        //double [] arr = new double[6];
        //Console.WriteLine("введите элементы массива:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    sum += arr[i];
        //}
        //Console.WriteLine("Полученный массив:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] /= sum;
        //}
        //Console.WriteLine("[{0}]", string.Join("; ", arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 1_1
        #region 1_2
        //double sum = 0;
        //int k = 0;
        //double[] arr = new double[8];
        //Console.WriteLine("введите элементы массива:");
        //for (int i = 0; i < 8; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    if (arr[i] > 0)
        //    {

        //        sum += arr[i];
        //        k += 1;

        //    }
        //}

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i]>0)
        //    {
        //        arr[i] = sum / k;
        //    }
        //    Console.Write("{0:f1} ", arr[i]);
        //}
        //Console.ReadLine();
        #endregion 1_2
        #region 1_3
        //double[] arr1 = new double[4];
        //double[] arr2 = new double[4];
        //double[] arr3 = new double[4];
        //double[] arr4 = new double[4];
        //Console.WriteLine("введите элементы 1-ого и 2-ого массива:");
        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    arr1[i] = double.Parse(Console.ReadLine());
        //    arr2[i] = double.Parse(Console.ReadLine());
        //    arr3[i] = arr1[i] - arr2[i];
        //    arr4[i] = arr1[i] + arr2[i];
        //}
        //Console.WriteLine("Массив суммы:");
        //Console.WriteLine("[{0}]", string.Join("; ", arr4));
        //Console.WriteLine("Массив разности:");
        //Console.WriteLine("[{0}]", string.Join("; ", arr3));
        //Console.ReadLine();
        #endregion 1_3
        #region 1_4
        //double[] arr = new double[5];
        //double srm = 0;
        //Console.WriteLine("введите элементы массива:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    srm += arr[i];

        //}
        //srm /= arr.Length;
        //Console.WriteLine("Среднее арифметическое:");
        //Console.WriteLine(srm);
        //Console.ReadLine();
        #endregion 1_4
        #region 1_5
        //double[] arr1 = new double[4];
        //double[] arr2 = new double[4];
        //double sum = 0;
        //Console.WriteLine("введите элементы 1-ого и 2-ого массива:");
        //for (int i=0;i<arr1.Length;i++)
        //{
        //    arr1[i] = double.Parse(Console.ReadLine());
        //    arr2[i] = double.Parse(Console.ReadLine());
        //    sum += arr1[i] * arr2[i];

        //}
        //Console.WriteLine("cкалярное произведение:");
        //Console.WriteLine(sum);
        //Console.ReadLine();
        #endregion 1_5
        #region 1_6
        //double[] arr = new double[5];
        //double sum = 0;
        //Console.WriteLine("введите значения вектора:");
        //for(int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    sum += arr[i] * arr[i];
        //}
        //sum = Math.Sqrt(sum);
        //Console.WriteLine(sum);
        //Console.ReadLine();
        #endregion 1_6
        #region 1_7
        //double[] arr = new double[7];
        //double sum = 0;
        //Console.WriteLine("введите элементы массива:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    sum += arr[i];
        //}
        //sum /= arr.Length;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] > sum)
        //    {
        //        arr[i] = 0;
        //    }
        //}
        //Console.WriteLine("[{0}]", string.Join("; ", arr));
        //Console.ReadLine();
        #endregion 1_7
        #region 1_8
        //double[] arr = new double[6];
        //double k = 0;
        //Console.WriteLine("введите элементы массива:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    if (arr[i] < 0)
        //    {
        //        k++;
        //    }
        //}
        //Console.WriteLine("кол-во отриц. элементов:");
        //Console.WriteLine(k);
        //Console.ReadLine();
        #endregion 1_8
        #region 1_9
        //double[] arr = new double[8];
        //double k = 0;
        //double sum = 0;
        //Console.WriteLine("Введите элементы массива:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    sum += arr[i];
        //}
        //sum = sum / arr.Length;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] > sum)
        //    {
        //        k++;
        //    }
        //}
        //Console.WriteLine("Кол-во элементов больших cр");
        //Console.WriteLine(k);
        //Console.ReadLine();
        #endregion 1_9
        #region 1_10
        //double[] arr = new double[6];
        //double k = 0;
        //double P = 0;
        //double Q = 0;
        //Console.WriteLine("введите левую границу:");
        //P = double.Parse(Console.ReadLine());
        //Console.WriteLine("введите правую границу:");
        //Q = double.Parse(Console.ReadLine());
        //Console.WriteLine("введите элементы массива:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    if (arr[i] > P && arr[i] < Q)
        //    {
        //        k++;
        //    }
        //}
        //Console.WriteLine(k);
        //Console.ReadLine();
        #endregion 1_10
        #region 1_11
        //double[] arr = new double[10];
        //int tp = 0;
        //int op = 0;
        //Console.WriteLine("Введите эллементы массива(10):");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    if (arr[i] > 0)
        //    {
        //        tp++;
        //    }
        //}
        //arr1 = new double[tp];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] > 0)
        //    {
        //        arr1[op] = arr[i];
        //        op++;
        //    }
        //}
        //Console.WriteLine("[{0}]", string.Join("; ", arr1));
        //Console.ReadLine();
        #endregion 1_11
        #region 1_12
        //double[] arr = new double[8];
        //double zn = 0;
        //double nom = 0;
        //Console.WriteLine("введите элементы массива:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //    if (arr[i] < 0)
        //    {
        //        nom = i + 1;
        //        zn = arr[i];
        //    }
        //}
        //Console.WriteLine("значениe:");
        //Console.WriteLine(zn);
        //Console.WriteLine("номер");
        //Console.WriteLine(nom);
        //Console.ReadLine();
        #endregion 1_12
        #region 1_13
        //double[] arr1 = new double[10];
        //double[] arr2 = new double[5];
        //double[] arr3 = new double[5];
        //int k1 = 0;
        //Console.WriteLine("Введите элементы массива(10):");
        //int k2 = 0;
        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    arr1[i] = double.Parse(Console.ReadLine());
        //    if (i % 2 == 0)
        //    {
        //        arr2[k1] = arr1[i];
        //        k1++;
        //    }
        //    else
        //    {
        //        arr3[k2] = arr1[i];
        //        k2++;
        //    }
        //}
        //Console.WriteLine("Новый массив с четн:");
        //Console.WriteLine("[{0}]", string.Join("; ", arr2));
        //Console.WriteLine("Новый массив с нечетн:");
        //Console.WriteLine("[{0}]", string.Join("; ", arr3));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 1_13

        #region 1_14
        //double[] arr = new double[11];
        //double sum = 0;
        //Console.WriteLine("введите элементы массива");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = double.Parse(Console.ReadLine());
        //}
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] < 0)
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        sum += arr[i] * arr[i];
        //    }
        //}
        //Console.WriteLine(sum);
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 1_14
        #region 1_15
        //double[] x = new double[10];
        //double[] y = new double[10];
        //Console.WriteLine("введите элементы массива x(10):");
        //for (int i = 0;i < x.Length;i++)
        //{
        //    x[i] = double.Parse(Console.ReadLine());
        //    y[i] = 0.5 * Math.Log(x[i]);
        //    Console.WriteLine($"{x[i]} {y[i]}");
        //    Console.WriteLine();
        //}
        //Console.ReadLine();
        #endregion 1_15


        #region 2_1
        //Console.WriteLine("введите массив(через пробел):");
        //string str = Console.ReadLine();
        //string[] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double minim = 1000000000;
        //int k = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        k = i;
        //    }
        //}
        //arr[k] = minim * 2;
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_1

        #region 2_2
        //double su = 0;
        //Console.WriteLine("введите массив(через пробел):");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');

        //double [] arr = new double[masiv.Length];
        //double maxim = -100000000000;
        //int k = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        k = i;
        //    }
        //}
        //for (int i = 0; i < k; i++)
        //{
        //    su += arr[i];
        //}
        //Console.WriteLine("Сумма до макс элемента:");
        //Console.WriteLine(su);
        //Console.WriteLine();
        //Console.ReadLine();

        #endregion 2_2

        #region 2_3
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double minim = 1000000000;
        //int k = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        k = i;
        //    }
        //}
        //for (int i = 0; i < k; i++)
        //{
        //    arr[i] = arr[i] * 2;
        //}
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_3

        #region 2_4
        //Console.WriteLine("Введите массив:");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double maxim = -100000000000;
        //double su = 0;
        //int k = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    su += arr[i];
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        k = i;
        //    }
        //}
        //su = su / arr.Length;
        //for (int i = k + 1; i < arr.Length; i++)
        //{
        //    arr[i] = su;
        //}
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_4

        #region 2_5
        //Console.WriteLine("Введите массив:");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double maxim = -100000000000;
        //double minim = 1000000000000;
        //double su = 0;
        //int k = 0;
        //double g = 0, t = 0;
        //int maxxx, minnn;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    su += arr[i];
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        g = i;
        //    }
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        t = i;
        //    }
        //}
        //if (g > t)
        //{
        //    maxxx = (int)g;
        //    minnn = (int)t;
        //}
        //else
        //{
        //    maxxx = (int)t;
        //    minnn = (int)g;
        //}
        //for (int i = minnn + 1; i < maxxx; i++)
        //{
        //    if (arr[i] < 0)
        //    {
        //        k++;
        //    }
        //}
        //double[] arr1 = new double[k];
        //k = 0;
        //for (int i = minnn + 1; i < maxxx; i++)
        //{
        //    if (arr[i] < 0)
        //    {
        //        arr1[k] = arr[i];
        //        k++;
        //    }
        //}
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr1));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_5

        #region 2_6
        //Console.WriteLine("Введите массив:");
        //string str = Console.ReadLine();
        //Console.WriteLine("Введите число P:");
        //double minnn = 1000000000;
        //double P = double.Parse(Console.ReadLine());
        //string [] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double[] arr1 = new double[masiv.Length + 1];
        //int k = 0;
        //double minim = 1000000000;
        //double su = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    su += arr[i];
        //}
        //su = su / arr.Length;
        //Console.WriteLine(su);
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    if (Math.Abs(su - arr[i]) <= minim)
        //    {
        //        minim = Math.Abs(su - arr[i]);
        //        k = i;
        //    }
        //}
        //arr1[k + 1] = P;
        //for (int i = 0; i < arr.Length + 1; i++)
        //{
        //    if (i < (k + 1))
        //    {
        //        arr1[i] = arr[i];
        //    }
        //    else if (i > (k + 1))
        //    {
        //        arr1[i] = arr[i - 1];
        //    }
        //}
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr1));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_6

        #region 2_7
        //Console.WriteLine("Введите массив:");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double maxim = -10000000000;
        //double[] arr = new double[masiv.Length];
        //int k = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        k = i;
        //    }
        //}
        //arr[k + 1] *= 2;
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_7

        #region 2_8
        //Console.WriteLine("Введите массив:");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double maxim = -10000000000;
        //double minim = 10000000000;
        //double[] arr = new double[masiv.Length];
        //int minnn = 0;
        //int maxxx = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        maxxx = i;
        //    }
        //}
        //for (int i = maxxx + 1; i < masiv.Length; i++)
        //{
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        minnn = i;
        //    }
        //}
        //arr[maxxx] = minim;
        //arr[minnn] = maxim;
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_8

        #region 2_9
        //Console.WriteLine("Введите массив:");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double maxim = -10000000000;
        //double minim = 10000000000;
        //double[] arr = new double[masiv.Length];
        //int minnn = 0;
        //int maxxx = 0;
        //int v = 0;
        //int k = 0;
        //double su = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        maxxx = i;
        //    }
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        minnn = i;
        //    }
        //}
        //if (minnn < maxxx)
        //{
        //    v = minnn;
        //    k = maxxx;
        //}
        //else
        //{
        //    v = maxxx;
        //    k = minnn;
        //}
        //for (int i = v + 1; i < k; i++)
        //{
        //    su += arr[i];
        //}
        //su = su / (k - v - 1);
        //Console.WriteLine("Ср ар между мин и  макс эл:");
        //Console.WriteLine(su);
        //Console.ReadLine();
        #endregion 2_9

        #region 2_10
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string str = Console.ReadLine();
        //string[] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double minim = 1000000000;
        //int k = 0;
        //double[] arr1 = new double[masiv.Length - 1];

        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (minim > arr[i] && arr[i] > 0)
        //    {
        //        minim = arr[i];
        //        k = i;
        //    }
        //}

        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    if (i < k)
        //    {
        //        arr1[i] = arr[i];
        //    }
        //    if (i > k)
        //    {
        //        arr1[i - 1] = arr[i];
        //    }
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr1));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_10

        #region 2_11
        //Console.WriteLine("Введите значение p:");
        //int p = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите размер массива:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //double [] arr = new double[b];
        //double []  arr1 = new double[b + 1];
        //double h = 0;
        //double o = 0;
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    double a = Convert.ToDouble(Console.ReadLine());
        //    arr[i] = a;
        //    if (arr[i] > 0)
        //    {
        //        h = i;
        //        o = arr[i];
        //    }
        //}
        //for (int i = 0; i < arr.Length + 1; i++)
        //{
        //    if (i <= h)
        //    {
        //        arr1[i] = arr[i];
        //    }
        //    if (i == (h + 1))
        //    {
        //        arr1[i] = p;
        //    }
        //    if (i > (h + 1))
        //    {
        //        arr1[i] = arr[i - 1];
        //    }
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join("; ", arr1));
        //Console.WriteLine();
        //Console.ReadLine();

        #endregion 2_11

        #region 2_12

        //Console.WriteLine("Введите размер массива:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //double [] arr = new double[b];
        //double [] arr1 = new double[b + 1];
        //int h = 0;
        //int k = 0;
        //double o = -Math.Pow(10, 20);
        //double s = 0;
        //double p = 0;
        //Console.WriteLine("Введите массив");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    double a = Convert.ToDouble(Console.ReadLine());
        //    arr[i] = a;
        //    if (arr[i] > o)
        //    {
        //        h = i;
        //        o = arr[i];
        //    }
        //}
        //for (int i = h + 1; i < arr.Length; i++)
        //{
        //    s += arr[i];
        //}
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] < 0)
        //    {
        //        k = i;
        //        break;
        //    }
        //}
        //arr[k] = s;

        //Console.WriteLine("Результат:");
        //Console.WriteLine("[{0}]", string.Join("; ", arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_12
        #region 2_13
        //Console.WriteLine("Введите массив");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double minim = 1000000000;
        //double maxim = -10000000000;
        //int k = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (i % 2 == 0 && arr[i] > maxim)
        //    {
        //        maxim = arr[i];
        //        k = i;
        //    }
        //}
        //arr[k] = k;
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_13

        #region 2_14
        //Console.WriteLine("Введите размер массива:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //double [] arr = new double[b];
        //int h = 0;
        //int k = 0;
        //double o = -Math.Pow(10, 20);

        //Console.WriteLine("Введите массив");

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    double a = Convert.ToDouble(Console.ReadLine());
        //    arr[i] = a;
        //    if (arr[i] > o)
        //    {
        //        h = i;
        //        o = arr[i];
        //    }
        //}
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] < 0)
        //    {
        //        k = i;
        //        break;
        //    }
        //}
        //arr[h] = arr[k];
        //arr[k] = o;
        //Console.WriteLine("Результат:");
        //Console.WriteLine("[{0}]", string.Join("; ", arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_14
        #region 2_15

        //Console.WriteLine("Введите размер массива A:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //double [] arr = new double[b];
        //Console.WriteLine("Введите элементы массива A:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    double a = Convert.ToDouble(Console.ReadLine());
        //    arr[i] = a;
        //}
        //Console.WriteLine("Введите, пожалуйста, размер массива B:");
        //b = Convert.ToInt32(Console.ReadLine());
        //double [] arr1 = new double[b];
        //Console.WriteLine("Введите, пожалуйста, элементы массива B:");

        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    double a = Convert.ToDouble(Console.ReadLine());
        //    arr1[i] = a;
        //}
        //Console.WriteLine("Введите, пожалуйста, значение k:");
        //int K = Convert.ToInt32(Console.ReadLine());
        //double [] arr2 = new double[arr.Length + arr1.Length];
        //int h = 0;
        //int k = 0;
        //double s = 0;
        //double p = 0;

        //for (int i = 0; i < arr.Length + arr1.Length; i++)
        //{
        //    if (i <= K)
        //    {
        //        arr2[i] = arr[i];
        //    }
        //    if (i > K & i <= K + arr1.Length)
        //    {
        //        arr2[i] = arr1[i - K - 1];
        //    }
        //    if (i > K + arr1.Length)
        //    {
        //        arr2[i] = arr[i - arr1.Length - 1];
        //    }
        //}

        //Console.WriteLine("Результат:");
        //Console.WriteLine("[{0}]", string.Join("; ", arr2));
        //Console.WriteLine();
        //Console.ReadLine();

        #endregion 2_15
        #region 2_16
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string str = Console.ReadLine();
        //string[] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double su = 0;
        //int k = 0;
        //int al = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    su += arr[i];
        //}
        //su = su / arr.Length;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] < su)
        //    {
        //        k++;
        //    }
        //}
        //double[] massivv = new double[k];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] < su)
        //    {
        //        massivv[al] = i;
        //        al++;
        //    }
        //}
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', massivv));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_16
        #region 2_17
        //Console.WriteLine("Введите размер массива:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //int n1 = int.Parse(Console.ReadLine());
        //double [] a1 = new double[n1];
        //int imax = 0;
        //int imin = 0;
        //double sp = 0;
        //double so = 0;
        //int ko = 0;
        //int kp = 0;
        //for (int i = 0; i < n1; i++)
        //{
        //    a1[i] = double.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < n1; i++)
        //{
        //    Console.Write("{0} ", a1[i]);
        //    if (a1[i] < a1[imin]) imin = i;
        //    if (a1[i] > a1[imax]) imax = i;
        //    if (a1[i] > 0)
        //    {
        //        sp += a1[i];
        //        kp++;
        //    }
        //    if (a1[i] < 0)
        //    {
        //        so += a1[i];
        //        ko++;
        //    }
        //}
        //Console.WriteLine();
        //if (imin < imax)
        //{
        //    if (ko != 0)
        //    {
        //        double otv = so / ko;
        //        Console.WriteLine(otv);
        //    }
        //    else Console.WriteLine();
        //}
        //else
        //{
        //    if (kp != 0)
        //    {
        //        double otv = sp / kp;
        //        Console.WriteLine(otv);
        //    }
        //    else Console.WriteLine("Результат:");
        //}
        //Console.WriteLine();
        //Console.ReadLine();

        #endregion 2_17
        #region 2_18
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double maxim1 = -1000000000;
        //double maxim2 = -1000000000;
        //int chet = 0;
        //int nechet = 0;
        //int k = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (maxim1 < arr[i] && (i % 2 == 0))
        //    {
        //        maxim1 = arr[i];
        //        chet = i;
        //    }
        //    if (maxim2 < arr[i] && (i % 2 != 0))
        //    {
        //        maxim2 = arr[i];
        //        nechet = i;
        //    }
        //}
        //if (maxim1 > maxim2)
        //{
        //    for (int i = 0; i < masiv.Length / 2; i++)
        //    {
        //        arr[i] = 0;
        //    }
        //}
        //else
        //{
        //    for (int i = masiv.Length / 2; i < masiv.Length; i++)
        //    {
        //        arr[i] = 0;
        //    }
        //}
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_18

        #region 2_19
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double maxim = -1000000000;
        //int k = 0;
        //double su = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        k = i;
        //    }
        //}
        //if (maxim > su)
        //{
        //    arr[k] = 0;
        //}
        //else
        //{
        //    arr[k] *= 2;
        //}
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_19
        #region 2_20
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string str = Console.ReadLine();
        //string [] masiv = str.Split(' ');
        //double[] arr = new double[masiv.Length];
        //double minim = 1000000000;
        //int k = -1;
        //int minnn = 0;
        //double su = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    arr[i] = double.Parse(masiv[i]);
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        minnn = i;
        //    }
        //    if (k == -1 && arr[i] < 0)
        //    {
        //        k = i;
        //    }
        //}
        //if (k < minnn)
        //{
        //    for (int i = 0; i < masiv.Length; i += 2)
        //    {
        //        su += arr[i];
        //    }
        //}
        //else
        //{
        //    for (int i = 1; i < masiv.Length; i += 2)
        //    {
        //        su += arr[i];
        //    }
        //}
        //Console.WriteLine(su);
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion 2_20

        #region 3_2
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string stroka = Console.ReadLine();
        //string [] massiv = stroka.Split(' ');
        //double [] array = new double[massiv.Length];
        //double maximum = -1000000000;
        //double mem = 1;
        //for (int i = 0; i < massiv.Length; i++)
        //{
        //    array[i] = double.Parse(massiv[i]);
        //    if (maximum < array[i])
        //    {
        //        maximum = array[i];
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] == maximum)
        //    {
        //        array[i] += mem;
        //        mem++;
        //    }
        //}
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', array));
        //Console.ReadLine();
        #endregion 3_2
        #region 3_3
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //string stroka = Console.ReadLine();
        //string []masiv = stroka.Split(' ');
        //double [] array = new double[masiv.Length];
        //double maximum = -1000000000;
        //double mem = 0;
        //double el = 0;
        //for (int i = 0; i < masiv.Length; i++)
        //{
        //    array[i] = double.Parse(masiv[i]);
        //    if (maximum < array[i])
        //    {
        //        maximum = array[i];
        //        mem = i;
        //    }
        //}
        //if (mem % 2 != 0)
        //{
        //    mem -= 1;
        //}
        //for (int i = 0; i < mem; i += 2)
        //{
        //    el = array[i];
        //    array[i] = array[i + 1];
        //    array[i + 1] = el;

        //}
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', array));
        //Console.WriteLine();
        #endregion 3_3


    }
}


