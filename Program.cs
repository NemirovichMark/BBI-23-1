using System;
namespace project
{
    class Project
    {
        static void Main()
        {
            #region 1_1
            Console.WriteLine("1_1:");
            double s = 0;
            double[] arr = new double[6];
            Console.WriteLine("Введите 6 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] / s;
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            Console.WriteLine();
            #endregion

            #region 1_2
            Console.WriteLine("1_2:");
            s = 0;
            int k = 0;
            arr = new double[8];
            Console.WriteLine("Введите 8 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > 0)
                {
                    s += a;
                    k++;
                }
            }
            double sr = s / k;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i] = sr;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            Console.WriteLine();
            #endregion

            #region 1_3
            Console.WriteLine("1_3;");
            arr = new double[4];
            double[] arr1 = new double[4];
            Console.WriteLine("Введите 4 элемента 1-ого массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
            }
            Console.WriteLine("Введите 4 эемента 2-ого массива:");
            for (int i = 0; i < arr1.Length; i++)
            {
                double c = Convert.ToDouble(Console.ReadLine());
                arr1[i] = c;
            }
            double[] arr2 = new double[4];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[i] + arr1[i];
            }
            Console.WriteLine("Сумма:");
            Console.WriteLine("[{0}]", string.Join("; ", arr2));

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[i] - arr1[i];
            }
            Console.WriteLine("Разность:");
            Console.WriteLine("[{0}]", string.Join("; ", arr2));
            #endregion

            #region 1_4
            Console.WriteLine("1_4:");
            s = 0;
            k = 0;
            arr = new double[5];
            Console.WriteLine("Введите 5 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += a;
                k++;
            }
            sr = s / k;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] -= sr;
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            #endregion

            #region 1_6
            Console.WriteLine("1_6:");
            double l = 0;
            arr = new double[5];
            Console.WriteLine("Введите 5 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                l += a * a;
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(Math.Sqrt(l));
            #endregion

            #region 1_7
            Console.WriteLine("1_7:");
            arr = new double[7];
            s = 0;
            k = 0;
            Console.WriteLine("Введите 7 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += a;
                k++;
            }
            sr = s / k;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > sr)
                {
                    arr[i] = 0;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            Console.WriteLine();
            #endregion

            #region 1_8
            Console.WriteLine("1_8:");
            arr = new double[6];
            k = 0;
            Console.WriteLine("Введите 6 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < 0)
                {
                    k++;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(k);
            Console.WriteLine();
            #endregion

            #region 1_9
            Console.WriteLine("1_9:");
            arr = new double[8];
            k = 0;
            s = 0;
            l = 0;
            Console.WriteLine("Введите 8 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += a;
                k++;
            }
            sr = s / k;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > sr)
                {
                    l++;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(l);
            Console.WriteLine();
            #endregion

            #region 1_10
            Console.WriteLine("1_10:");
            arr = new double[10];
            k = 0;
            Console.WriteLine("Вводим p:");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вводим q:");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 10 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {

                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > p & arr[i] < q)
                {
                    k++;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(k);
            Console.WriteLine();
            #endregion

            #region 1_11
            Console.WriteLine("1_11:");
            arr = new double[10];
            k = 0;
            int h = 0;
            Console.WriteLine("Введите 10 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > 0)
                {
                    k++;
                }
            }
            arr1 = new double[k];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr1[h] = arr[i];
                    h++;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr1));
            Console.WriteLine();
            #endregion

            #region 1_12
            Console.WriteLine("1_12:");
            arr = new double[8];
            h = 0;
            double g = 0;
            Console.WriteLine("Введите 8 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < 0)
                {
                    h = i;
                    g = arr[i];
                }
            }
            Console.WriteLine("Значение:");
            Console.WriteLine(g);
            Console.WriteLine("Номер элемента:");
            Console.WriteLine(h);
            Console.WriteLine();
            #endregion

            #region 1_13
            Console.WriteLine("1_13:");
            arr = new double[10];
            k = 0;
            h = 0;
            Console.WriteLine("Введите 10 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
            }
            arr1 = new double[5];
            for (int i = 0; i < arr.Length; i += 2)
            {
                arr1[k] = arr[i];
                k++;
            }
            arr2 = new double[5];
            for (int i = 1; i < arr.Length; i += 2)
            {
                arr2[h] = arr[i];
                h++;
            }
            Console.WriteLine("Массив с четными индексами:");
            Console.WriteLine("[{0}]", string.Join("; ", arr2));
            Console.WriteLine("Массив с нечетными индексами:");
            Console.WriteLine("[{0}]", string.Join("; ", arr1));
            Console.WriteLine();
            #endregion

            #region 1_14
            Console.WriteLine("1_14:");
            arr = new double[11];
            s = 0;
            Console.WriteLine("Введите 11 элементов массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] >= 0)
                {
                    s += a * a;
                }
                if (arr[i] < 0)
                {
                    break;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(s);
            Console.WriteLine();
            #endregion

            #region 1_15
            Console.WriteLine("1_15:");
            double[] x = new double[10];
            double[] y = new double[10];
            Console.WriteLine("Введите 10 элементов массива:");
            for (int i = 0; i < x.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                x[i] = a;
                y[i] = 0.5 * Math.Log10(x[i]);
            }
            Console.WriteLine("x      y");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{x[i]} {y[i]}");
            }
            Console.WriteLine();
            #endregion

            #region 2_1
            Console.WriteLine("2_1:");
            Console.WriteLine("Введите размер массива:");
            int b = Convert.ToInt16(Console.ReadLine());
            arr = new double[b];
            double min = 100000000000;
            h = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;

                if (min > arr[i])
                {
                    min = arr[i];
                    h = i;
                }
            }
            arr[h] = min * 2;
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            #endregion

            #region 2_2
            Console.WriteLine("2_2:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            double o = -Math.Pow(10, 20);
            s = 0;
            h = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > o)
                {
                    h = i;
                    o = arr[i];
                }
            }
            for (int i = 0; i < h; i++)
            {
                s += arr[i];
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(s);
            #endregion
            Console.WriteLine();


            #region 2_3
            Console.WriteLine("2_3:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            o = Math.Pow(10, 20);
            h = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < o)
                {
                    h = i;
                    o = arr[i];
                }
            }
            for (int i = 0; i < h; i++)
            {
                arr[i] = 2 * arr[i];
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_4
            Console.WriteLine("2_4:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            o = -Math.Pow(10, 20);
            h = 0;
            s = 0;
            sr = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > o)
                {
                    h = i;
                    o = arr[i];
                }
                s += arr[i];
            }
            sr = s / b;
            for (int i = (h + 1); i < b; i++)
            {
                arr[i] = sr;
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_5
            Console.WriteLine("2_5:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            o = -Math.Pow(10, 20);
            p = Math.Pow(10, 20);
            h = 0;
            k = 0;
            int index1 = -1;
            int index2 = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > o)
                {
                    h = i;
                    o = arr[i];
                }
                if (arr[i] < p)
                {
                    k = i;
                    p = arr[i];
                }
            }
            if (k >= h)
            {
                for (int i = (h + 1); i < k; i++)
                {
                    if (arr[i] < 0)
                    {
                        index2++;
                    }
                }
                arr1 = new double[index2];
                for (int i = (h + 1); i < k; i++)
                {
                    if (arr[i] < 0)
                    {
                        index1 += 1;
                        arr1[index1] = arr[i];
                    }
                }
            }
            if (k < h)
            {
                for (int i = (k + 1); i < h; i++)
                {
                    if (arr[i] < 0)
                    {
                        index2++;
                    }
                }
                arr1 = new double[index2];
                for (int i = (k + 1); i < h; i++)
                {
                    if (arr[i] < 0)
                    {
                        index1 += 1;
                        arr1[index1] = arr[i];
                    }
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr1));
            #endregion
            Console.WriteLine();


            #region 2_6
            Console.WriteLine("2_6:");
            Console.WriteLine("Введите значение p:");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            arr1 = new double[b + 1];
            o = Math.Pow(10, 20);
            h = 0;
            k = 0;
            index1 = -1;
            index2 = 0;
            s = 0;
            sr = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += arr[i];
            }
            sr = s / b;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - sr) < o)
                {
                    h = i;
                    o = Math.Abs(arr[i] - sr);
                }
            }
            for (int i = 0; i < arr.Length + 1; i++)
            {
                if (i <= h)
                {
                    arr1[i] = arr[i];
                }
                if (i == (h + 1))
                {
                    arr1[i] = p;
                }
                if (i > (h + 1))
                {
                    arr1[i] = arr[i - 1];
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr1));
            #endregion
            Console.WriteLine();


            #region 2_7
            Console.WriteLine("2_7:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            o = -Math.Pow(10, 20);
            h = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > o)
                {
                    h = i;
                    o = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == (h + 1))
                {
                    arr[i] = 2 * arr[i];
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_8
            Console.WriteLine("2_8:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            arr1 = new double[b + 1];
            o = -Math.Pow(10, 20);
            p = Math.Pow(10, 20);
            h = 0;
            k = 0;
            index1 = -1;
            index2 = 0;
            s = 0;
            sr = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > o)
                {
                    h = i;
                    o = arr[i];
                }
            }
            for (int i = h + 1; i < arr.Length; i++)
            {
                if (arr[i] < p)
                {
                    k = i;
                    p = arr[i];
                }
            }
            arr[h] = p;
            arr[k] = o;
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_9
            Console.WriteLine("2_9:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            o = -Math.Pow(10, 20);
            p = Math.Pow(10, 20);
            h = 0;
            k = 0;
            s = 0;
            sr = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > o)
                {
                    h = i;
                    o = arr[i];
                }
                if (arr[i] < p)
                {
                    k = i;
                    p = arr[i];
                }
            }
            if (k >= h)
            {
                for (int i = h + 1; i < k; i++)
                {
                    s += arr[i];
                }
            }
            if (k < h)
            {
                for (int i = k + 1; i < h; i++)
                {
                    s += arr[i];
                }
            }
            sr = s / (Math.Abs(k - h) - 1);
            Console.WriteLine("Ответ:");
            Console.WriteLine(sr);
            #endregion
            Console.WriteLine();

            #region 2_10
            Console.WriteLine("2_10:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            p = Math.Pow(10, 20);
            h = 0;
            bool flag = false;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < p & arr[i] > 0)
                {
                    h = i;
                    p = arr[i];
                }
            }
            foreach (double elem in arr)
            {
                if (elem > 0)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                for (int i = h + 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                Console.WriteLine("Ответ:");
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Console.Write("{0:f1}", arr[i] + " ");
                }
            }
            else
            {
                foreach (double elem in arr)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 2_11
            Console.WriteLine("2_11:");
            Console.WriteLine("Введите значение p:");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            arr1 = new double[b + 1];
            h = 0;
            flag = false;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > 0)
                {
                    h = i;
                }
            }
            foreach (double elem in arr)
            {
                if (elem > 0)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                for (int i = 0; i < arr.Length + 1; i++)
                {
                    if (i <= h)
                    {
                        arr1[i] = arr[i];
                    }
                    if (i == (h + 1))
                    {
                        arr1[i] = p;
                    }
                    if (i > (h + 1))
                    {
                        arr1[i] = arr[i - 1];
                    }
                }
                Console.WriteLine("Ответ:");
                Console.WriteLine("[{0}]", string.Join("; ", arr1));
            }
            else
            {
                foreach (double elem in arr)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 2_12
            Console.WriteLine("2_12:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            h = 0;
            k = 0;
            o = -Math.Pow(10, 20);
            s = 0;
            flag = false;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > o)
                {
                    h = i;
                    o = arr[i];
                }
            }
            foreach (double elem in arr)
            {
                if (elem < 0)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                for (int i = h + 1; i < arr.Length; i++)
                {
                    s += arr[i];
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        k = i;
                        break;
                    }
                }
                arr[k] = s;
                Console.WriteLine("Ответ:");
                Console.WriteLine("[{0}]", string.Join("; ", arr));
            }
            else
            {
                foreach (double elem in arr)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 2_13
            Console.WriteLine("2_13:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            h = 0;
            o = -Math.Pow(10, 20);
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > o & i % 2 == 0)
                {
                    h = i;
                    o = arr[i];
                }
            }
            arr[h] = h;
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_14
            Console.WriteLine("2_14:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            h = 0;
            k = 0;
            o = -Math.Pow(10, 20);
            flag = false;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > o)
                {
                    h = i;
                    o = arr[i];
                }
            }
            foreach (double elem in arr)
            {
                if (elem < 0)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        k = i;
                        break;
                    }
                }
                arr[h] = arr[k];
                arr[k] = o;
                Console.WriteLine("Ответ:");
                Console.WriteLine("[{0}]", string.Join("; ", arr));
            }
            else
            {
                foreach (double elem in arr)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 2_15
            Console.WriteLine("2_15:");
            Console.WriteLine("Введите размер массива A: ");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            Console.WriteLine("Введите элементы массива A: ");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
            }
            Console.WriteLine("Введите размер массива B: ");
            int n = int.Parse(Console.ReadLine());
            arr1 = new double[n];
            Console.WriteLine("Введите элементы массива B: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr1[i] = a;
            }
            Console.WriteLine("Введите значение k: ");
            k = int.Parse(Console.ReadLine());
            arr2 = new double[arr.Length + arr1.Length];
            h -= 1;
            if (((h + 1) > arr.Length) || ((h == 1) & (arr.Length == 1)))
            {
                Console.WriteLine("Неверный ввод");
            }
            else
            {
                for (int i = 0; i < arr.Length + arr1.Length; i++)
                {
                    if (i <= h)
                    {
                        arr2[i] = arr[i];
                    }
                    if (i > h & i <= h + arr1.Length)
                    {
                        arr2[i] = arr1[i - h - 1];
                    }
                    if (i > (h + arr1.Length))
                    {
                        arr2[i] = arr[i - arr1.Length];
                    }
                }
            }
            Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", arr2));
            #endregion
            Console.WriteLine();


            #region 2_16
            Console.WriteLine("2_16:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            h = 0;
            s = 0;
            int K = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += arr[i];
            }
            sr = s / b;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < sr)
                {
                    K++;
                }
            }
            arr1 = new double[K];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < sr)
                {
                    arr1[h] = i;
                    h++;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr1));
            #endregion
            Console.WriteLine();


            #region 2_17
            Console.WriteLine("2_17:");
            Console.WriteLine("Введите размер массива: ");
            b = int.Parse(Console.ReadLine());
            arr = new double[b];
            int I = 0;
            int I1 = 0;
            s = 0;
            sr = 0;
            q = 0;
            l = Math.Pow(10, 20);
            p = -Math.Pow(10, 20);
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < l)
                {
                    I = i;
                    l = arr[i];
                }
                if (arr[i] > p)
                {
                    I1 = i;
                    p = arr[i];
                }
            }
            if (I1 < I)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        s += arr[i];
                        q += 1;
                    }
                }
                sr = s / q;
            }
            if (I1 > I)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        s += arr[i];
                        q += 1;
                    }
                }
                if (q == 0)
                {
                    Console.WriteLine("Ответ: 0");
                }
                else
                {
                    sr = s / q;
                }
            }
            Console.WriteLine($"Ответ: {sr}");
            #endregion
            Console.WriteLine();


            #region 2_18
            Console.WriteLine("2_18:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            h = 0;
            k = 0;
            s = 0;
            sr = 0;
            q = 0;
            o = Math.Pow(10, 20);
            p = -Math.Pow(10, 20);
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < o)
                {
                    h = i;
                    o = arr[i];
                }
                if (arr[i] > p)
                {
                    k = i;
                    p = arr[i];
                }
            }
            if (k < h)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        s += arr[i];
                        q += 1;
                    }
                }
                sr = s / q;
            }
            if (k > h)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        s += arr[i];
                        q += 1;
                    }
                }
                sr = s / q;
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(sr);
            #endregion
            Console.WriteLine();


            #region 2_19
            Console.WriteLine("2_19:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            h = 0;
            s = 0;
            p = -Math.Pow(10, 20);
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > p)
                {
                    h = i;
                    p = arr[i];
                }
                s += arr[i];
            }
            if (p > s)
            {
                arr[h] = 0;
            }
            if (p <= s)
            {
                arr[h] = 2 * arr[h];
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine("[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_20
            Console.WriteLine("2_20:");
            Console.WriteLine("Введите размер массива:");
            b = Convert.ToInt32(Console.ReadLine());
            arr = new double[b];
            h = 0;
            s = 0;
            k = 0;
            q = 0;
            o = Math.Pow(10, 20);
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < o)
                {
                    h = i;
                    o = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    k = i;
                    break;
                }
            }
            if (k < h)
            {
                for (int i = 0; i < arr.Length; i += 2)
                {
                    s += arr[i];
                }
            }
            if (k >= h)
            {
                for (int i = 1; i < arr.Length; i += 2)
                {
                    s += arr[i];
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(s);
            #endregion
            Console.WriteLine();

            #region 3_2
            Console.WriteLine("3_2:");
            Console.WriteLine("Введите размер массива: ");
            b = int.Parse(Console.ReadLine());
            arr = new double[b];
            p = -Math.Pow(10, 20);
            K = 1;
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > p)
                {
                    p = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == p)
                {
                    arr[i] = arr[i] + K;
                    K++;
                }
            }
            Console.WriteLine("Ответ: ");
            Console.Write("[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();

            #region 3_3
            Console.WriteLine("3_3:");
            Console.WriteLine("Введите размер массива: ");
            b = int.Parse(Console.ReadLine());
            arr = new double[b];
            p = -Math.Pow(10, 20);
            I = 0;
            double kr = 0;
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > p)
                {
                    p = arr[i];
                }
            }
            if (I % 2 != 0)
            {
                I -= 1;
            }
            for (int i = 0; i < I; i += 2)
            {
                kr = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = kr;
            }
            Console.WriteLine("Ответ: ");
            Console.Write("[{0}]", string.Join("; ", arr));
            #endregion
        }
    }
}

