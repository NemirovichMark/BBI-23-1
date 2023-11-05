using System;
using System.Buffers;
using System.Runtime.Intrinsics.X86;

namespace project
{
    class Project
    {
        static void Main()
        {
            double s = 0;
            int n = 0;
            double[] arr = new double[6];
            double a = 0;
            double[] arr1 = new double[4];
            double[] arr2 = new double[4];
            double[] arr3 = new double[4];
            double arm = 0;
            double k = 0;
            double p = 0;
            double q = 0;
            int I = 0;
            int I1 = 0;
            int index1 = 0;
            int index2 = 0;
            int K = 0;

            #region 1_1 
            s = 0;
            arr = new double[6];
            Console.WriteLine("Введите 6 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += a;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] / s;
            }
            Console.WriteLine("1_1: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 1_2 
            s = 0;
            arm = 0;
            arr = new double[8];
            k = 0;
            Console.WriteLine("Введите 8 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (a > 0)
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
            #endregion
            Console.WriteLine();


            #region 1_3
            arr1 = new double[4];
            arr2 = new double[4];
            arr3 = new double[4];
            Console.WriteLine("Введите 4 элементов 1-го массива: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr1[i] = a;
            }
            Console.WriteLine("Введите 4 элементов 2-го массива: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr2[i] = a;
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            Console.WriteLine("1_3: " + "[{0}]", string.Join("; ", arr3));
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i] - arr2[i];
            }
            Console.WriteLine("1_3: " + "[{0}]", string.Join("; ", arr3));
            #endregion
            Console.WriteLine();


            #region 1_4
            s = 0;
            arm = 0;
            arr = new double[5];
            k = 0;
            Console.WriteLine("Введите 5 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += a;
            }
            arm = s / 5;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - arm;
            }
            Console.WriteLine("1_4: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();
            #region 1_5
            arr1 = new double[4];
            arr2 = new double[4];
            s = 0;
            Console.WriteLine("Введите 4 элементов 1-го массива: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr1[i] = a;
            }
            Console.WriteLine("Введите 4 элементов 2-го массива: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr2[i] = a;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                s += arr1[i] * arr2[i];
            }
            Console.WriteLine("1_5: " + s);
            #endregion
            Console.WriteLine();


            #region 1_6
            s = 0;
            arm = 0;
            arr = new double[5];
            k = 0;
            Console.WriteLine("Введите 5 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += arr[i] * arr[i];
            }
            s=Math.Sqrt(s);
            Console.WriteLine("1_6: " + s);
            #endregion
            Console.WriteLine();


            #region 1_7
            s = 0;
            arm = 0;
            arr = new double[7];
            Console.WriteLine("Введите 7 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += arr[i];
            }
            arm=s/arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arm)
                {
                    arr[i] = 0;
                }
            }
            Console.WriteLine("1_7: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 1_8
            s = 0;
            arr = new double[6];
            k = 0;
            Console.WriteLine("Введите 6 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < 0)
                {
                    k += 1;
                }
            }
            Console.WriteLine("1_8: " + k);
            #endregion
            Console.WriteLine();


            #region 1_9
            s = 0;
            arr = new double[8];
            k = 0;
            arm = 0;
            Console.WriteLine("Введите 8 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += arr[i];
            }
            arm = s / arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arm)
                {
                    k += 1;
                }
            }
            Console.WriteLine("1_9: " + k);
            #endregion
            Console.WriteLine();


            #region 1_10
            arr = new double[10];
            k = 0;
            Console.WriteLine("Введите нижнюю границу: ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу: ");
            q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 10 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i]>p & arr[i] < q)
                {
                    k += 1;
                }
            }
            Console.WriteLine("1_10: " + k);
            #endregion
            Console.WriteLine();
            #region 1_11
            I = 0;
            arr = new double[10];
            arm = 0;
            Console.WriteLine("Введите 10 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > 0)
                {
                    I += 1;
                }
            }
            arr1 = new double[I];
            I = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr1[I] = arr[i];
                    I += 1;
                }
            }
            Console.WriteLine("1_11: " + "[{0}]", string.Join("; ", arr1));
            #endregion
            Console.WriteLine();


            #region 1_12
            I = 0;
            arr = new double[8];
            k = 0;
            Console.WriteLine("Введите 8 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < 0)
                {
                    k = arr[i];
                    I = i;
                }
            }
            Console.WriteLine("1_12: " + k + " " + (I+1));
            #endregion
            Console.WriteLine();


            #region 1_13
            I = 0;
            arr = new double[10];
            arr1 = new double[5];
            arr2 = new double[5];
            k = 0;
            index1 = 0;
            index2 = 0;
            Console.WriteLine("Введите 10 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (i % 2 == 0)
                {
                    arr1[index1] = arr[i];
                    index1++;
                }
                else
                {
                    arr2[index2] = arr[i];
                    index2++;
                }
            }
            Console.WriteLine("1_13: " + "[{0}]", string.Join("; ", arr1));
            Console.WriteLine("1_13: " + "[{0}]", string.Join("; ", arr2));
            #endregion
            Console.WriteLine();


            #region 1_14
            I = 0;
            arr = new double[11];
            s = 0;
            Console.WriteLine("Введите 11 элементов массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    s += arr[i] * arr[i];
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("1_13: " + s);
            #endregion
            Console.WriteLine();


            #region 1_15
            arr = new double[10];
            arr1 = new double[10];
            Console.WriteLine("Введите 10 значений x: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = 0.5 * Math.Log(arr[i], Math.E);
            }
            Console.WriteLine("1_15: ");
            Console.WriteLine("x " + "y");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " " + arr1[i]);
            }
            #endregion
            Console.WriteLine();
            #region 2_1
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            k = Math.Pow(10, 20);
            Console.WriteLine("Введите " + n + " значений массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < k)
                {
                    k = arr[i];
                }
            }
            Console.WriteLine("2_1 Наименьший элемент массива умноженный на 2: " + 2*k);
            #endregion
            Console.WriteLine();


            #region 2_2
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            k = -Math.Pow(10, 20);
            s = 0;
            I = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > k)
                {
                    I = i;
                    k= arr[i];
                }
            }
            for (int i = 0; i < I; i++)
            {
                s += arr[i];
            }
            Console.WriteLine("2_2 Cумма элементов до максимального элемента массива: " + s);
            #endregion
            Console.WriteLine();


            #region 2_3
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            k = Math.Pow(10, 20);
            I = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < k)
                {
                    I = i;
                    k = arr[i];
                }
            }
            for (int i = 0; i < I; i++)
            {
                arr[i] = 2 * arr[i];
            }

            Console.WriteLine("2_3 Итоговый массив, где элементы расположенные до минимального увеличены в 2 раза: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_4
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            k = -Math.Pow(10, 20);
            I = 0;
            s = 0;
            arm = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > k)
                {
                    I = i;
                    k = arr[i];
                }
                s += arr[i];
            }
            arm = s / n;
            for (int i = (I+1); i < n; i++)
            {
                arr[i] = arm;
            }

            Console.WriteLine("2_4 Итоговый массив, где элементы расположенные после max заменены на ср.ариф.: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_5
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            k = -Math.Pow(10, 20);
            p = Math.Pow(10, 20);
            I = 0;
            I1 = 0;
            index1 = -1;
            index2 = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > k)
                {
                    I = i;
                    k = arr[i];
                }
                if (arr[i] < p)
                {
                    I1 = i;
                    p = arr[i];
                }
            }
            if (I1 >= I)
            {
                for (int i = (I + 1); i < I1; i++)
                {
                    if (arr[i] < 0)
                    {
                        index2++;
                    }
                }
                arr1 = new double[index2];
                for (int i = (I + 1); i < I1; i++)
                {
                    if (arr[i] < 0)
                    {
                        index1 += 1;
                        arr1[index1] = arr[i];
                    }
                }
            }
            if (I1 < I)
            {
                for (int i = (I1 + 1); i < I; i++)
                {
                    if (arr[i] < 0)
                    {
                        index2++;
                    }
                }
                arr1 = new double[index2];
                for (int i = (I1 + 1); i < I; i++)
                {
                    if (arr[i] < 0)
                    {
                        index1 += 1;
                        arr1[index1] = arr[i];
                    }
                }
            }
            Console.WriteLine("2_5: Итоговый массив, где находятся отрицательные элементы расположенные между max и min: " + "[{0}]", string.Join("; ", arr1));
            #endregion
            Console.WriteLine();


            #region 2_6
            Console.WriteLine("Введите значение p: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            arr1 = new double[n+1];
            k = Math.Pow(10, 20);
            I = 0;
            I1 = 0;
            index1 = -1;
            index2 = 0;
            s = 0;
            arm = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += arr[i];
            }
            arm = s / n;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]-arm)<k) 
                {
                    I = i;
                    k = Math.Abs(arr[i] - arm);
                }
            }
            for (int i = 0; i < arr.Length+1; i++)
            {
                if (i<=I)
                {
                    arr1[i] = arr[i];
                }
                if (i == (I+1))
                {
                    arr1[i] = p;
                }
                if (i > (I + 1))
                {
                    arr1[i] = arr[i-1];
                }
            }
            Console.WriteLine("2_6: Итоговый массив, где после элемента ближайшего к ср.ариф. стоит число p: " + "[{0}]", string.Join("; ", arr1));
            #endregion
            Console.WriteLine(); 


            #region 2_7
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            k = -Math.Pow(10, 20);
            I = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > k)
                {
                    I = i;
                    k = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==(I+1))
                {
                    arr[i] = 2 * arr[i];
                }
            }
            Console.WriteLine("2_7: Итоговый массив, где элемент, идущий после max, увеличен в 2 раза: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_8
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            arr1 = new double[n + 1];
            k = -Math.Pow(10, 20);
            p = Math.Pow(10, 20);
            I = 0;
            I1 = 0;
            index1 = -1;
            index2 = 0;
            s = 0;
            arm = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > k)
                {
                    I = i;
                    k = arr[i];
                }
            }
            for (int i = I+1; i < arr.Length; i++)
            {
                if (arr[i]<p)
                {
                    I1 = i;
                    p = arr[i];
                }
            }
            arr[I] = p;
            arr[I1] = k;
            Console.WriteLine("2_8: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_9
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            k = -Math.Pow(10, 20);
            p = Math.Pow(10, 20);
            I = 0;
            I1 = 0;
            s = 0;
            arm = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > k)
                {
                    I = i;
                    k = arr[i];
                }
                if (arr[i] < p)
                {
                    I1 = i;
                    p = arr[i];
                }
            }
            if ( I1>=I )
            {
                for (int i = I + 1; i < I1; i++)
                {
                    s += arr[i];
                }
            }
            if (I1 < I)
            {
                for (int i = I1 + 1; i < I; i++)
                {
                    s += arr[i];
                }
            }
            arm = s / (Math.Abs(I1 - I) - 1);
            Console.WriteLine("2_9: " + arm);
            #endregion
            Console.WriteLine();


            #region 2_10
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            p = Math.Pow(10, 20);
            I = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < p & arr[i]>0)
                {
                    I = i;
                    p = arr[i];
                }
            }
            for (int i = I+1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            Console.Write("2_10: ");
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write("{0:f1}", arr[i] + " ");
            }
            #endregion
            Console.WriteLine();


            #region 2_11
            Console.WriteLine("Введите значение p: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            arr1 = new double[n+1];
            I = 0;
            k = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > 0)
                {
                    I = i;
                    k = arr[i];
                }
            }
            for (int i = 0; i < arr.Length + 1; i++)
            {
                if (i <= I)
                {
                    arr1[i] = arr[i];
                }
                if (i == (I + 1))
                {
                    arr1[i] = p;
                }
                if (i > (I + 1))
                {
                    arr1[i] = arr[i - 1];
                }
            }
            Console.WriteLine("2_11: " + "[{0}]", string.Join("; ", arr1));
            #endregion
            Console.WriteLine();


            #region 2_12
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            arr1 = new double[n + 1];
            I = 0;
            I1 = 0;
            k = -Math.Pow(10,20);
            s = 0;
            p = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > k)
                {
                    I = i;
                    k = arr[i];
                }
            }
            for (int i = I + 1; i < arr.Length; i++)
            {
                s += arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <0 )
                {
                    I1 = i;
                    break;
                }
            }
            arr[I1] = s;
            Console.WriteLine("2_12: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_13
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            I = 0;
            k = -Math.Pow(10, 20);
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > k & i%2==0)
                {
                    I = i;
                    k = arr[i];
                }
            }
            arr[I] = I;
            Console.WriteLine("2_13: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_14
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            I = 0;
            I1 = 0;
            k = -Math.Pow(10, 20);
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] > k)
                {
                    I = i;
                    k = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    I1 = i;
                    break;
                }
            }
            arr[I] = arr[I1];
            arr[I1] = k;
            Console.WriteLine("2_14: " + "[{0}]", string.Join("; ", arr));
            #endregion
            Console.WriteLine();


            #region 2_15
            Console.WriteLine("Введите длину массива A: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            Console.WriteLine("Введите " + n + " значения/ий массива A: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
            }
            Console.WriteLine("Введите длину массива B: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new double[n];
            Console.WriteLine("Введите " + n + " значения/ий массива B: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr1[i] = a;
            }
            Console.WriteLine("Введите значение k: ");
            K = Convert.ToInt32(Console.ReadLine());
            arr2 = new double[arr.Length+arr1.Length];
            I = 0;
            I1 = 0;
            s = 0;
            p = 0;
            for (int i = 0; i < arr.Length + arr1.Length; i++)
            {
                if (i <= K)
                {
                    arr2[i] = arr[i];
                }
                if (i > K & i <= K + arr1.Length)
                {
                    arr2[i] = arr1[i-K-1];
                }
                if (i > K + arr1.Length)
                {
                    arr2[i] = arr[i - arr1.Length - 1];
                }
            }
            Console.WriteLine("2_15: " + "[{0}]", string.Join("; ", arr2));
            #endregion
            Console.WriteLine();


            #region 2_16
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            I = 0;
            s = 0;
            arm = 0;
            K = 0;
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                s += arr[i];
            }
            arm = s / n;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arm)
                {
                    K++;
                }
            }
            arr1 = new double[K];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arm)
                {
                    arr1[I] = i;
                    I++;
                }
            }
            Console.WriteLine("2_16: " + "[{0}]", string.Join("; ", arr1));
            #endregion
            Console.WriteLine();


            #region 2_17
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            I = 0;
            I1 = 0;
            s = 0;
            arm = 0;
            q = 0;
            k = Math.Pow(10, 20);
            p = -Math.Pow(10, 20);
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < k)
                {
                    I = i;
                    k = arr[i];
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
                arm = s / q;
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
                arm = s / q;
            }
            Console.WriteLine("2_17: " + arm);
            #endregion
            Console.WriteLine();


            #region 2_18
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            I = 0;
            I1 = 0;
            s = 0;
            arm = 0;
            q = 0;
            k = Math.Pow(10, 20);
            p = -Math.Pow(10, 20);
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < k)
                {
                    I = i;
                    k = arr[i];
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
                arm = s / q;
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
                arm = s / q;
            }
            Console.WriteLine("2_18: " + arm);
            #endregion
            Console.WriteLine();


            #region 2_19 
            Console.WriteLine("Введите длину массива: "); 
            n = Convert.ToInt32(Console.ReadLine()); 
            arr = new double[n]; 
            I = 0; 
            s = 0; 
            p = -Math.Pow(10, 20); 
            Console.WriteLine("Введите " + n + " значения/ий массива: "); 
            for (int i = 0; i < arr.Length; i++) 
            { 
                a = Convert.ToDouble(Console.ReadLine()); 
                arr[i] = a; 
                if (arr[i] > p) 
                { 
                    I = i; 
                    p = arr[i]; 
                } 
                s += arr[i]; 
            } 
            if (p > s) 
            { 
                arr[I] = 0; 
            } 
            if (p <= s) 
            { 
                arr[I] = 2 * arr[I]; 
            } 
            Console.WriteLine("2_19: " + "[{0}]", string.Join(';', arr)); 
            #endregion 
            Console.WriteLine();


            #region 2_20 
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            I = 0;
            s = 0;
            I1 = 0;
            q = 0;
            k = Math.Pow(10, 20);
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                arr[i] = a;
                if (arr[i] < k)
                {
                    I = i;
                    k = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    I1 = i;
                    break;
                }
            }
            if (I1 < I)
            {
                for (int i = 0; i < arr.Length; i += 2)
                {
                    s += arr[i];
                }
            }
            if (I1 >= I)
            {
                for (int i = 1; i < arr.Length; i += 2)
                {
                    s += arr[i];
                }
            }
            Console.WriteLine("2_20: " + s);
            #endregion
            Console.WriteLine();


            #region 3_1
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            I = 0;
            I1 = 0;
            s = 0;
            K = 0;
            p = -Math.Pow(10, 20);
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
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
                    K++;
                }
            }
            arr1 = new double[K];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == p)
                {
                    arr1[I] = i;
                    I += 1;
                }
            }
            Console.WriteLine("2_19: " + "[{0}]", string.Join(';', arr1));
            #endregion
            Console.WriteLine();


            #region 3_2
            Console.WriteLine("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new double[n];
            p = -Math.Pow(10, 20);
            Console.WriteLine("Введите " + n + " значения/ий массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
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
                    arr[i] = arr[i] + i;
                }
            }
            Console.WriteLine("2_19: " + "[{0}]", string.Join(';', arr));
            #endregion
            Console.WriteLine();
        }
    }
}