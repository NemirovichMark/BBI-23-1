using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.1
            Console.WriteLine("1.1:");
            double sum = 0;
            double[] array = new double[6];
            Console.WriteLine("Enter an array with 6 elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("Eventual array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] / sum;
            }
            Console.WriteLine("[{0}]", string.Join("; ", array));
            Console.WriteLine();
            #endregion


            #region 1.2
            Console.WriteLine("1.2:");
            array = new double[8];
            double temp = 0;
            sum = 0;
            Console.WriteLine("Enter an array with 8 elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                if (array[i] > 0)
                {
                    sum += array[i];
                    temp++;
                }
            }
            temp = sum / temp;
            Console.WriteLine("Eventual array:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = temp;
                }
            }
            Console.WriteLine("[{0}]", string.Join("; ", array));
            Console.WriteLine();
            #endregion


            #region 1.3
            Console.WriteLine("1.3:");
            double[] arr1 = new double[4];
            double[] arr2 = new double[4];
            double[] arr3 = new double[4];
            double[] arr4 = new double[4];
            Console.WriteLine("Enter 4 elements for both arrays:");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = double.Parse(Console.ReadLine());
                arr2[i] = double.Parse(Console.ReadLine());
                arr3[i] = arr1[i] - arr2[i];
                arr4[i] = arr1[i] + arr2[i];
            }
            Console.WriteLine("summ array:");
            Console.WriteLine("[{0}]", string.Join("; ", arr4));
            Console.WriteLine("sub array:");
            Console.WriteLine("[{0}]", string.Join("; ", arr3));
            Console.WriteLine();
            #endregion


            #region 1.4
            Console.WriteLine("1.4:");
            array = new double[5];
            sum = 0;
            Console.WriteLine("Enter an array with 5 elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                sum += array[i];
            }
            sum = sum / array.Length;
            Console.WriteLine("Average:");
            Console.WriteLine(sum);
            Console.WriteLine();
            #endregion


            #region 1.5
            Console.WriteLine("1.5:");
            arr1 = new double[4];
            arr2 = new double[4];
            sum = 0;
            Console.WriteLine("Enter elements of both 1 and 2 arrays:");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = double.Parse(Console.ReadLine());
                arr2[i] = double.Parse(Console.ReadLine());
                sum += arr1[i] * arr2[i];
            }
            Console.WriteLine("Scolar product:");
            Console.WriteLine(sum);
            Console.WriteLine();
            #endregion


            #region 1.6
            Console.WriteLine("1.6:");
            array = new double[5];
            sum = 0;
            Console.WriteLine("Enter vector with length 5:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                sum += array[i] * array[i];
            }
            sum = Math.Sqrt(sum);
            Console.WriteLine("Length:");
            Console.WriteLine(sum);
            Console.WriteLine();
            #endregion


            #region 1.7
            Console.WriteLine("1.7:");
            array = new double[7];
            sum = 0;
            Console.WriteLine("Enter array's elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                sum += array[i];
            }
            sum = sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > sum)
                {
                    array[i] = 0;
                }
            }
            Console.WriteLine("[{0}]", string.Join("; ", array));
            Console.WriteLine();
            #endregion


            #region 1.8
            Console.WriteLine("1.8:");
            array = new double[6];
            temp = 0;
            Console.WriteLine("Enter 6 elements of the array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    temp++;
                }
            }
            Console.WriteLine("Number of negative elements:");
            Console.WriteLine(temp);
            Console.WriteLine();
            #endregion


            #region 1.9
            Console.WriteLine("1.9:");
            array = new double[8];
            sum = 0;
            temp = 0;
            Console.WriteLine("Enter array's elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                sum += array[i];
            }
            sum = sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > sum)
                {
                    temp++;
                }
            }
            Console.WriteLine("Number of elements that are bigger than average:");
            Console.WriteLine(temp);
            Console.WriteLine();
            #endregion


            #region 1.10
            Console.WriteLine("1.10:");
            array = new double[10];
            double P = 0, Q = 0;
            temp = 0;
            Console.WriteLine("Enter left border:");
            P = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter right border:");
            Q = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 10 elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                if (array[i] > P && array[i] < Q)
                {
                    temp++;
                }
            }
            Console.WriteLine("Answer:");
            Console.WriteLine(temp);
            Console.WriteLine();
            #endregion


            #region 1.11
            Console.WriteLine("1.11:");
            array = new double[10];
            int tempik = 0;
            int op = 0;
            Console.WriteLine("Enter 10 elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                if (array[i] > 0)
                {
                    tempik++;
                }
            }
            arr1 = new double[tempik];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    arr1[op] = array[i];
                    op++;
                }
            }
            Console.WriteLine("New array:");
            Console.WriteLine("[{0}]", string.Join("; ", arr1));
            Console.WriteLine();
            #endregion


            #region 1.12
            Console.WriteLine("1.12:");
            array = new double[8];
            double num = 0, val = 0;
            Console.WriteLine("Enter array;s elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    num = i + 1;
                    val = array[i];
                }
            }
            Console.WriteLine("Value:");
            Console.WriteLine(val);
            Console.WriteLine("Number");
            Console.WriteLine(num);
            Console.WriteLine();
            #endregion


            #region 1.13
            Console.WriteLine("1.13");
            array = new double[10];
            arr1 = new double[5];
            arr2 = new double[5];
            int temp1 = 0;
            Console.WriteLine("Enter 10 elements of the array:");
            int temp2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    arr1[temp1] = array[i];
                    temp1++;
                }
                else
                {
                    arr2[temp2] = array[i];
                    temp2++;
                }
            }
            Console.WriteLine("Even array:");
            Console.WriteLine("[{0}]", string.Join("; ", arr1));
            Console.WriteLine("Odd array:");
            Console.WriteLine("[{0}]", string.Join("; ", arr2));
            Console.WriteLine();
            #endregion


            #region 1.14
            Console.WriteLine("1.14:");
            array = new double[11];
            sum = 0;
            Console.WriteLine("Enter 11 elements of the array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    break;
                }
                else
                {
                    sum += array[i] * array[i];
                }
            }
            Console.WriteLine("The sum of the squares of the elements located before the first negative array element:");
            Console.WriteLine(sum);
            Console.WriteLine();
            #endregion


            #region 1.15
            Console.WriteLine("1.15:");
            double[] x = new double[10];
            double[] y = new double[10];
            Console.WriteLine("Enter 10 elements of the array:");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = double.Parse(Console.ReadLine());
                y[i] = 0.5 * Math.Log(x[i]);
                Console.WriteLine($"{x[i]} {y[i]}");
                Console.WriteLine();
            }
            #endregion


            #region 2.1
            Console.WriteLine("2.1:");
            Console.WriteLine("Enter elements of the array with space:");
            string str = Console.ReadLine();
            string[] arrrray = str.Split(' ');
            double[] arr = new double[arrrray.Length];
            double min = 1000000000;
            temp = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (min > arr[i])
                {
                    min = arr[i];
                    temp = i;
                }
            }
            arr[(int)temp] = min * 2;
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
            Console.WriteLine();
            #endregion


            #region 2.2
            double summ = 0;
            Console.WriteLine("2.2:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            double max = -100000000000;
            temp = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (max < arr[i])
                {
                    max = arr[i];
                    temp = i;
                }
            }
            for (int i = 0; i < temp; i++)
            {
                summ += arr[i];
            }
            Console.WriteLine("Summ before max element:");
            Console.WriteLine(summ);
            Console.WriteLine();
            #endregion


            #region 2.3
            Console.WriteLine("2.3:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            min = 1000000000;
            temp = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (min > arr[i])
                {
                    min = arr[i];
                    temp = i;
                }
            }
            for (int i = 0; i < temp; i++)
            {
                arr[i] = arr[i] * 2;
            }
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
            Console.WriteLine();
            #endregion


            #region 2.4
            Console.WriteLine("2.4:");
            Console.WriteLine("Enter the array:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            max = -100000000000;
            summ = 0;
            temp = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                summ += arr[i];
                if (max < arr[i])
                {
                    max = arr[i];
                    temp = i;
                }
            }
            summ = summ / arr.Length;
            for (int i = Convert.ToInt32(temp + 1); i < arr.Length; i++)
            {
                arr[i] = summ;
            }
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
            Console.WriteLine();
            #endregion


            #region 2.5
            Console.WriteLine("2.5:");
            Console.WriteLine("Enter the array:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            max = -100000000000;
            min = 1000000000000;
            summ = 0;
            temp = 0;
            double g = 0, t = 0;
            int maxxx, minnn;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                summ += arr[i];
                if (max < arr[i])
                {
                    max = arr[i];
                    g = i;
                }
                if (min > arr[i])
                {
                    min = arr[i];
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
            double[] arr11 = new double[(int)temp];
            temp = 0;
            for (int i = minnn + 1; i < maxxx; i++)
            {
                if (arr[i] < 0)
                {
                    arr1[(int)temp] = arr[i];
                    temp++;
                }
            }
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr1));
            Console.WriteLine();
            #endregion


            #region 2.6
            Console.WriteLine("2.6:");
            Console.WriteLine("Enter the array:");
            str = Console.ReadLine();
            Console.WriteLine("Enter P:");
            minnn = 1000000000;
            P = double.Parse(Console.ReadLine());
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            arr1 = new double[arrrray.Length + 1];
            temp = 0;
            min = 1000000000;
            summ = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                summ += arr[i];
            }
            summ = summ / arr.Length;
            Console.WriteLine(summ);
            for (int i = 0; i < arrrray.Length; i++)
            {
                if (Math.Abs(summ - arr[i]) <= min)
                {
                    min = Math.Abs(summ - arr[i]);
                    temp = i;
                }
            }
            arr1[Convert.ToInt32(temp + 1)] = P;
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
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr1));
            Console.WriteLine();
            #endregion


            #region 2.7
            Console.WriteLine("2.7:");
            Console.WriteLine("Enter the array:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            max = -10000000000;
            arr = new double[arrrray.Length];
            temp = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (max < arr[i])
                {
                    max = arr[i];
                    temp = i;
                }
            }
            arr[(int)temp + 1] *= 2;
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
            Console.WriteLine();
            #endregion


            #region 2.8
            Console.WriteLine("2.8:");
            Console.WriteLine("Enter the array:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            max = -10000000000;
            min = 10000000000;
            arr = new double[arrrray.Length];
            minnn = 0;
            maxxx = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (max < arr[i])
                {
                    max = arr[i];
                    maxxx = i;
                }
            }
            for (int i = maxxx + 1; i < arrrray.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    minnn = i;
                }
            }
            arr[maxxx] = min;
            arr[minnn] = max;
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
            Console.WriteLine();
            #endregion


            #region 2.9
            Console.WriteLine("2.9:");
            Console.WriteLine("Enter the array:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            max = -10000000000;
            min = 10000000000;
            arr = new double[arrrray.Length];
            minnn = 0;
            maxxx = 0;
            int v = 0;
            int k = 0;
            summ = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (max < arr[i])
                {
                    max = arr[i];
                    maxxx = i;
                }
                if (min > arr[i])
                {
                    min = arr[i];
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
                summ += arr[i];
            }
            summ = summ / (k - v - 1);
            Console.WriteLine("Average between max and min elements:");
            Console.WriteLine(summ);
            Console.WriteLine();
            #endregion


            #region 2.10
            Console.WriteLine("2.10:");
            Console.WriteLine("Enter array's length: ");
            int n;
            double a;
            int.TryParse(Console.ReadLine(), out n);
            double[] arraichik = new double[n];
            int p = int.MaxValue;
            int comparingEl = -1;
            Console.WriteLine($"Enter {n} array's elements(each element on new line): ");
            for (int i = 0; i < arraichik.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out a);
                arraichik[i] = a;
                if ((arraichik[i] < p) & (arraichik[i] > 0))
                {
                    comparingEl = i;
                    p = Convert.ToInt32(arraichik[i]);
                }
            }
            if (comparingEl < 0)
            {
                Console.WriteLine("There're no positive elements!");
                Console.WriteLine("Initial array:");
                for (int i = 0; i < arraichik.Length; i++)
                {
                    Console.Write("{0:f1}", arraichik[i] + " ");
                }
            }
            else
            {
                for (int i = comparingEl + 1; i < arraichik.Length; i++)
                {
                    arraichik[i - 1] = arraichik[i];
                }
                Console.WriteLine("Eventual array:");
                for (int i = 0; i < arraichik.Length - 1; i++)
                {
                    Console.Write("{0:f1}", arraichik[i] + " ");
                }
            }
            #endregion


            #region 2.11
            Console.WriteLine("2.11:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            Console.WriteLine("Enter P");
            P = double.Parse(Console.ReadLine());
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            temp = 0;
            arr1 = new double[arrrray.Length + 1];
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (arr[i] > 0)
                {
                    temp = i;
                }
            }
            temp++;
            arr1[(int)temp] = P;
            for (int i = 0; i < arrrray.Length + 1; i++)
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
            if (temp == 1)
            {
                Console.WriteLine("There're no positive numbers!");
                Console.WriteLine("Initial array:");
                Console.WriteLine("[{0}]", string.Join(";", arrrray));
            }
            else
            {
                Console.WriteLine("Eventual array:");
                Console.WriteLine("[{0}]", string.Join(";", arr1));
            }
            Console.WriteLine();
            #endregion


            #region 2.12
            Console.WriteLine("2.12:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            min = 1000000000;
            max = -100000000000;
            maxxx = 0;
            temp = -1;
            summ = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxxx = i;
                }
                if (temp == -1 && arr[i] < 0)
                {
                    temp = i;
                }
            }
            for (int i = maxxx + 1; i < arrrray.Length; i++)
            {
                summ += arr[i];
            }
            if (temp == -1)
            {
                Console.WriteLine("There are no negative numbers!");
                Console.WriteLine("Initial array:");
                Console.WriteLine("[{0}]", string.Join(";", arrrray));
            }
            else
            {
                arr[(int)temp] = summ;
                Console.WriteLine("Eventual array:");
                Console.WriteLine("[{0}]", string.Join(";", arr));
            }
            Console.WriteLine();
            #endregion


            #region 2.13
            Console.WriteLine("2.13:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            min = 1000000000;
            max = -10000000000;
            temp = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (i % 2 == 0 && arr[i] > max)
                {
                    max = arr[i];
                    temp = i;
                }
            }
            arr[(int)temp] = temp;
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
            Console.WriteLine();
            #endregion


            #region 2.14
            Console.WriteLine("2.14:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            min = 1000000000;
            max = -1000000000;
            temp = -1;
            maxxx = 0;
            summ = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (arr[i] > max)
                {
                    max = Convert.ToInt32(arr[i]);
                    maxxx = i;
                }
                if (temp == -1 && arr[i] < 0)
                {
                    temp = i;
                    summ = arr[i];
                }
            }
            if (temp == -1)
            {
                Console.WriteLine("There're no negative numbers!");
                Console.WriteLine("Initial array:");
                Console.WriteLine("[{0}]", string.Join(";", arrrray));
            }
            else
            {
                arr[(int)temp] = max;
                arr[maxxx] = summ;
                Console.WriteLine("Eventual array:");
                Console.WriteLine("[{0}]", string.Join(";", arr));
            }
            Console.WriteLine();
            #endregion


            #region 2.15
            Console.WriteLine("2.15:");
            Console.WriteLine("Enter array A length: ");
            int.TryParse(Console.ReadLine(), out n);
            double[] arrAy = new double[n];
            Console.WriteLine($"Enter {n} elements of array A (each element on new line): ");
            for (int i = 0; i < arrAy.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out a);
                arrAy[i] = a;
            }
            Console.WriteLine("Enter array B length: ");
            int.TryParse(Console.ReadLine(), out n);
            double[] arrAy1 = new double[n];
            Console.WriteLine($"Enter {n} elements of array B (each element on new line): ");
            for (int i = 0; i < arrAy1.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out a);
                arrAy1[i] = a;
            }
            Console.WriteLine("Enter k: ");
            int.TryParse(Console.ReadLine(), out int intK);
            double[] arrAy2 = new double[arrAy.Length + arrAy1.Length];
            intK -= 1;
            if (((intK + 1) > arrAy.Length) || ((intK == 1) & (arrAy.Length == 1)))
            {
                Console.WriteLine("k is bigger than the array length!");
            }
            else
            {
                for (int i = 0; i < arrAy.Length + arrAy1.Length; i++)
                {
                    if (i <= intK)
                    {
                        arrAy2[i] = arrAy[i];
                    }
                    if (i > intK & i <= intK + arrAy1.Length)
                    {
                        arrAy2[i] = arrAy1[i - intK - 1];
                    }
                    if (i > (intK + arrAy1.Length))
                    {
                        arrAy2[i] = arrAy[i - arrAy1.Length];
                    }
                }
            }
            Console.WriteLine("Answer: " + "[{0}]", string.Join("; ", arrAy2));
            Console.WriteLine();
            #endregion


            #region 2.16
            Console.WriteLine("2.16:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            summ = 0;
            temp = 0;
            int al = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                summ += arr[i];
            }
            summ = summ / arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < summ)
                {
                    temp++;
                }
            }
            double[] massivchik = new double[(int)temp];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < summ)
                {
                    massivchik[al] = i;
                    al++;
                }
            }
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", massivchik));
            Console.WriteLine();
            #endregion


            #region 2.17
            Console.WriteLine("2.17:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            int[] arr3433 = new int[arrrray.Length];
            min = 1000000000;
            max = -1000000000;
            maxxx = 0;
            minnn = 0;
            int counter = 0;
            summ = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = int.Parse(arrrray[i]);
                if (max < arr[i])
                {
                    max = arr[i];
                    maxxx = i;
                }
                if (min > arr[i])
                {
                    min = arr[i];
                    minnn = i;
                }
            }
            if (maxxx < minnn)
            {
                for (int i = 0; i < arrrray.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        summ += arr[i];
                        counter++;
                    }
                }
                summ /= counter;
                Console.WriteLine("Average: " + summ);
            }
            else
            {
                for (int i = 0; i < arrrray.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        summ += arr[i];
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine("There're no negative numbers!");
                    Console.WriteLine("Initial array:");
                    Console.WriteLine("[{0}]", string.Join(";", arrrray));
                }
                else
                {
                    summ /= counter;
                    Console.WriteLine("Average: " + summ);
                }
            }
            Console.WriteLine();
            #endregion


            #region 2.18
            Console.WriteLine("2.18:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            double maxim1 = -1000000000;
            double maxim2 = -1000000000;
            int evenn = 0;
            int oddd = 0;
            temp = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (maxim1 < arr[i] && (i % 2 == 0))
                {
                    maxim1 = arr[i];
                    evenn = i;
                }
                if (maxim2 < arr[i] && (i % 2 != 0))
                {
                    maxim2 = arr[i];
                    oddd = i;
                }
            }
            if (maxim1 > maxim2)
            {
                for (int i = 0; i < arrrray.Length / 2; i++)
                {
                    arr[i] = 0;
                }
            }
            else
            {
                for (int i = arrrray.Length / 2; i < arrrray.Length; i++)
                {
                    arr[i] = 0;
                }
            }
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
            Console.WriteLine();
            #endregion


            #region 2.19
            Console.WriteLine("2.19:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            max = -1000000000;
            temp = 0;
            summ = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (max < arr[i])
                {
                    max = arr[i];
                    temp = i;
                }
            }
            if (max > summ)
            {
                arr[(int)temp] = 0;
            }
            else
            {
                arr[(int)temp] *= 2;
            }
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", arr));
            Console.WriteLine();
            #endregion


            #region 2.20
            Console.WriteLine("2.20:");
            Console.WriteLine("Enter array's elements with space:");
            str = Console.ReadLine();
            arrrray = str.Split(' ');
            arr = new double[arrrray.Length];
            min = 1000000000;
            temp = -1;
            minnn = 0;
            summ = 0;
            for (int i = 0; i < arrrray.Length; i++)
            {
                arr[i] = double.Parse(arrrray[i]);
                if (min > arr[i])
                {
                    min = arr[i];
                    minnn = i;
                }
                if (temp == -1 && arr[i] < 0)
                {
                    temp = i;
                }
            }
            if (temp < minnn)
            {
                for (int i = 0; i < arrrray.Length; i += 2)
                {
                    summ += arr[i];
                }
            }
            else
            {
                for (int i = 1; i < arrrray.Length; i += 2)
                {
                    summ += arr[i];
                }
            }
            Console.WriteLine("Summ:");
            Console.WriteLine(summ);
            Console.WriteLine();
            #endregion


            #region 3.2
            Console.WriteLine("3.2:");
            Console.WriteLine("Enter array's elements with space:");
            string line = Console.ReadLine();
            string[] arrayy = line.Split(' ');
            double[] arrayu = new double[arrayy.Length];
            double maximum = -1000000000;
            double mem = 1;
            for (int i = 0; i < arrayy.Length; i++)
            {
                array[i] = double.Parse(arrayy[i]);
                if (maximum < array[i])
                {
                    maximum = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maximum)
                {
                    array[i] += mem;
                    mem++;
                }
            }
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", array));
            Console.WriteLine();
            #endregion


            #region 3.3
            Console.WriteLine("3.3:");
            Console.WriteLine("Enter array's elements with space:");
            line = Console.ReadLine();
            arrayy = line.Split(' ');
            array = new double[arrayy.Length];
            maximum = -1000000000;
            mem = 0;
            double adadv = 0;
            for (int i = 0; i < arrayy.Length; i++)
            {
                array[i] = double.Parse(arrayy[i]);
                if (maximum < array[i])
                {
                    maximum = array[i];
                    mem = i;
                }
            }
            if (mem % 2 != 0)
            {
                mem -= 1;
            }
            for (int i = 0; i < mem; i += 2)
            {
                adadv = array[i];
                array[i] = array[i + 1];
                array[i + 1] = adadv;

            }
            Console.WriteLine("Eventual array:");
            Console.WriteLine("[{0}]", string.Join(";", array));
            Console.WriteLine();
            #endregion


            Console.ReadKey();
        }
    }

}