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
            int m = 0;
            double[,] mtrx = new double[n, m];
            double[,] mtrx1 = new double[n, m];
            double a = 0;
            double[] arr1 = new double[4];
            double[] arr2 = new double[4];
            double[] arr3 = new double[4];
            double arm = 0;
            double min = 0;
            double min1 = 0;
            double max = 0;
            double q = 0;
            int I = 0;
            int I1 = 0;
            int J = 0;
            int M = 0;
            int K = 0;
            string str = "";

            #region 1_4 
            Console.WriteLine("1_4:");
            n = 3;
            m = 6;
            mtrx = new double[n, m];
            min = Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: 3; Кол-во элементов в строке: 6)");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        I = i;
                        J = j;
                    }
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Номер строки и столбца с min элементом: " + (I+1) + " " + (J+1));
            #endregion
            Console.WriteLine();


            #region 1_8 
            Console.WriteLine("1_8:");
            n = 4;
            m = 6;
            q = m;
            s = 0;
            I = 0;
            mtrx = new double[n, m];
            arr1 = new double[n];
            Console.WriteLine("Введите матрицу(Кол-во строк: 4; Кол-во элементов в строке: 6)");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                s = 0;
                I = 0;
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                    if (arr[j]>0)
                    {
                        s += arr[j];
                        I += 1;
                    }
                }
                arr1[i] = (s / I);
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив со ср.ариф положю элементов каждой строки: " + "[{0}]", string.Join("; ", arr1));
            #endregion
            Console.WriteLine();


            #region 1_12 
            Console.WriteLine("1_12:");
            n = 6;
            m = 7;
            q = m;
            s = 0;
            I = 0;
            J = 0;
            mtrx = new double[n, m];
            mtrx1 = new double[n-1, m-1];
            max = -Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: 6; Кол-во элементов в строке: 7)");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        I = i;
                        J = j;
                    }
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максмальный элемент и его строка, столбец: " + max + " " + I + " " + J);
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i < I) & (j<J))
                    {
                        mtrx1[i, j] = mtrx[i, j];
                    }
                    if ((i < I) & (j > J))
                    {
                        mtrx1[i, j-1] = mtrx[i, j];
                    }
                    if ((i > I) & (j < J))
                    {
                        mtrx1[i-1, j] = mtrx[i, j];
                    }
                    if ((i > I) & (j > J))
                    {
                        mtrx1[i - 1, j - 1] = mtrx[i, j];
                    }
                }
            }
            for (int i = 0; i < (n-1); i++)
            {
                for (int j = 0; j < (m-1); j++)
                {
                    Console.Write(mtrx1[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 1_16 
            Console.WriteLine("1_16:");
            Console.WriteLine("Введите кол-во строк матрицы:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов в строке в матрице:");
            m = int.Parse(Console.ReadLine());
            J = 0;
            mtrx = new double[n, m];
            max = -Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: "+ n + "; Кол-во элементов в строке: "+m+")");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                    
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                max = -Math.Pow(10, 20);
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i,j] > max)
                    {
                        max = mtrx[i, j];
                        J = j;
                    }
                }
                for (int j = J; j < (m-1); j++)
                {
                    mtrx[i, j] = mtrx[i, j + 1];
                }
                mtrx[i, (m-1)] = max;
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 1_20 
            Console.WriteLine("1_20:");
            Console.WriteLine("Введите кол-во строк матрицы:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов в строке в матрице:");
            m = int.Parse(Console.ReadLine());
            s = 0;
            I = 0;
            I1 = 0;
            J = 0;
            mtrx = new double[n, m];
            max = -Math.Pow(10, 20);
            min = Math.Pow(10, 20);
            min1 = Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                max = -Math.Pow(10, 20);
                min = Math.Pow(10, 20);
                min1 = Math.Pow(10, 20);
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] > max)
                    {
                        max = mtrx[i, j];
                        J = j;
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] < min1 & mtrx[i, j]<0)
                    {
                        min1 = mtrx[i, j];
                        I1 = j;
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] < min & mtrx[i, j] < 0)
                    {
                        min = mtrx[i, j];
                        I = j;
                        break;
                    }
                }
                s = (min + min1) / 2;
                if (s < 0)
                {
                    mtrx[i, J] = s;
                }
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 1_24 
            Console.WriteLine("1_24:");
            n = 6;
            m = 5;
            s = 0;
            I = 0;
            I1 = 0;
            J = 0;
            arm = 0;
            mtrx = new double[n, m];
            max = -Math.Pow(10, 20);
            min = Math.Pow(10, 20);
            min1 = Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                max = -Math.Pow(10, 20);
                s = 0;
                I = 0;
                arm = 0;
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] > max)
                    {
                        max = mtrx[i, j];
                        J = j;
                    }
                }
                for (int j = (J+1); j < m; j++)
                {
                    if (mtrx[i, j] > 0)
                    {
                        s+= mtrx[i, j];
                        I++;
                    }
                }
                if (I != 0)
                {
                    arm = s / I;
                    for (int j = 0; j < J; j++)
                    {
                        if (mtrx[i, j] < 0)
                        {
                            mtrx[i, j] = arm;
                        }
                    }
                }
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 1_28 
            Console.WriteLine("1_28:");
            n = 7;
            m = 5;
            s = 0;
            I = -1;
            mtrx = new double[n, m];
            mtrx1 = new double[n - 1, m];
            max = -Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                s = 0;
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] > 0)
                    {
                        s += mtrx[i, j];
                    }
                }
                if (s > max)
                {
                    max = s;
                    I = i;
                }
            }
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i < I)
                    {
                        mtrx1[i, j] = mtrx[i, j];
                    }
                    if (i >= I)
                    {
                        mtrx1[i, j] = mtrx[i+1, j];
                    }
                }
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx1[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 1_32 
            Console.WriteLine("1_32:");
            n = 5;
            m = 7;
            s = 0;
            I = -1;
            J = -1;
            arm = 0;
            q = 0;
            mtrx = new double[n, m];
            max = -Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                s = 0;
                max = -Math.Pow(10, 20);
                arm = 0;
                q = 0;
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] > max)
                    {
                        max = mtrx[i, j];
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] > 0)
                    {
                        s += mtrx[i, j];
                        q += 1;
                    }
                }
                if (q == 0)
                {
                    arm = 0;
                }
                else
                {
                    arm = s / q;
                }
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] == max)
                    {
                        mtrx[i, j] = arm;
                    }
                }
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 2_4 
            Console.WriteLine("2_4:");
            n = 7;
            m = 5;
            arr1 = new double[5];
            mtrx = new double[n, m];
            max = -Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Введите массив состоящий из 5 элементов");
            str = Console.ReadLine();
            arr1 = str.Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < m; j++)
            {
                max = -Math.Pow(10, 20);
                for (int i = 0; i < n; i++)
                {
                    if (mtrx[i, j] > max)
                    {
                        max = mtrx[i, j];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if ((mtrx[i, j] == max) & (arr1[j] > mtrx[i, j]))
                    {
                        mtrx[i, j] = arr1[j];
                    }
                }
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 2_8 
            Console.WriteLine("2_8:");
            n = 6;
            m = 6;
            s = 0;
            I = -1;
            J = -1;
            arr1 = new double[6];
            mtrx = new double[n, m];
            max = -Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                max = -Math.Pow(10, 20);
                J = 0;
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] > max)
                    {
                        arr1[i] = mtrx[i, j];
                        max = mtrx[i, j];
                        J = j;
                    }
                }
            }
            for (int i = 0; i < n; i+=2)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((mtrx[i, j] == arr1[i]))
                    {
                        mtrx[i, j] = arr1[i+1];
                    }
                }
            }
            for (int i = 1; i < n; i += 2)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((mtrx[i, j] == arr1[i]))
                    {
                        mtrx[i, j] = arr1[i - 1];
                    }
                }
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 3_2 
            Console.WriteLine("3_2:");
            n = 7;
            m = 5;
            s = 0;
            I = -1;
            I1 = 0;
            J = -1;
            arm = 0;
            q = 0;
            arr1 = new double[7];
            arr2 = new double[7];
            arr3 = new double[7];
            mtrx = new double[n, m];
            mtrx1 = new double[n - 1, m];
            max = -Math.Pow(10, 20);
            min = Math.Pow(10, 20);
            min1 = Math.Pow(10, 20);
            Console.WriteLine("Введите первую строку матрицы: ");
            str = Console.ReadLine();
            double[] arr = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < arr.Length; j++)
            {
                mtrx[0, j] = arr[j];
            }
            for (int i = 1; i < arr.Length; i++)
            {
                str = Console.ReadLine();
                arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i==0 || i==(arr.Length-1) || j==0 || j==(arr.Length - 1))
                    {
                        mtrx[i, j] = 0;
                    }
                }
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();


            #region 3_1 
            Console.WriteLine("3_1:");
            n = 7;
            m = 5;
            s = 0;
            I = -1;
            I1 = 0;
            J = -1;
            arm = 0;
            q = 0;
            arr1 = new double[7];
            arr2 = new double[7];
            arr3 = new double[7];
            mtrx = new double[n, m];
            mtrx1 = new double[n - 1, m];
            max = -Math.Pow(10, 20);
            min = Math.Pow(10, 20);
            min1 = Math.Pow(10, 20);
            Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                min = Math.Pow(10, 20);
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] < min)
                    {
                        arr1[i] = mtrx[i, j];
                        min = mtrx[i, j];
                    }
                }
            }
            Console.WriteLine("1_1: " + "[{0}]", string.Join("; ", arr1));
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr1[j] < arr1[j + 1])
                    {
                        q = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = q;
                        for (int k = 0; k < m; k++)
                        {
                            q = mtrx[j, k];
                            mtrx[j, k] = mtrx[j + 1, k];
                            mtrx[j + 1, k] = q;
                        }
                    }
                }
            }
            Console.WriteLine("Итоговая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();
        }
    }
}
