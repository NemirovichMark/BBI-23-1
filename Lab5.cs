using System;
using System.Buffers;
using System.Runtime.Intrinsics.X86;

namespace project
{
    class Project
    {
        public static double[,] input(int a, int b)
        {
            string str;
            double[,] mtrx = new double[a, b];
            double[] arr;
            Console.WriteLine("Введите матрицу, где кол-во строк: " + a + "; и кол-во элементов в строке: " + b);
            for (int i = 0; i < a; i++)
            {
                str = Console.ReadLine();
                arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < b; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            return mtrx;
        }
        public static void output(double[,] arr, int a, int b)
        {
            Console.WriteLine("Итоговая матрица: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int[] MaxMtrx(double[,] mtrx, int a, int b)
        {
            int I = 0;
            int J = 0;
            double max = -100000000000;
            int[] mass = new int[2];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (mtrx[i, j] > max)
                    {
                        max = mtrx[i, j];
                        mass[1] = j;
                        mass[0] = i;
                    }
                }
            }
            return mass;
        }
        public static int MaxMtrxLine(double[,] mtrx, int a, int b)
        {
            int I = 0;
            double s = 0;
            double max = -100000000000;
            for (int i = 0; i < a; i++)
            {
                s = 0;
                for (int j = 0; j < b; j++)
                {
                    if (mtrx[i, j] > 0)
                    {
                        s += 1;
                    }
                }
                if (s > max)
                {
                    max = s;
                    I = i;
                }
            }
            return I;
        }
        public static int MaxMtrxColumn(double[,] mtrx, int a, int b)
        {
            int J = 0;
            double s = 0;
            double max = -100000000000;
            for (int i = 0; i < b; i++)
            {
                s = 0;
                for (int j = 0; j < a; j++)
                {
                    if (mtrx[j, i] > 0)
                    {
                        s += 1;
                    }
                }
                if (s > max)
                {
                    max = s;
                    J = i;
                }
            }
            return J;
        }
        public static double[,] DelLine(double[,] mtrx, int a, int b, int Imax, int Imin)
        {
            int J = 0;
            double s = 0;
            double max = -100000000000;
            if (Imax != Imin)
            {
                double[,] mtrx1 = new double[a - 2, b];
                if (Imax < Imin)
                {
                    for (int i = 0; i < Imax; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            mtrx1[i, j] = mtrx[i,j];
                        }
                    }
                    for (int i = Imax; i < Imin-1; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            mtrx1[i, j] = mtrx[i+1, j];
                        }
                    }
                    for (int i = Imin-1; i < a-2; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            mtrx1[i, j] = mtrx[i + 2, j];
                        }
                    }
                }
                if (Imax > Imin)
                {
                    for (int i = 0; i < Imin; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            mtrx1[i, j] = mtrx[i, j];
                        }
                    }
                    for (int i = Imin; i < Imax - 1; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            mtrx1[i, j] = mtrx[i + 1, j];
                        }
                    }
                    for (int i = Imax - 1; i < a - 2; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            mtrx1[i, j] = mtrx[i + 2, j];
                        }
                    }
                }
                output(mtrx1, a - 2, b);
                return mtrx1;
            }
            else
            {
                double[,] mtrx1 = new double[a - 1, b];
                for (int i = 0; i < a - 1; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if (i < Imax)
                        {
                            mtrx1[i, j] = mtrx[i, j];
                        }
                        if (i >= Imax)
                        {
                            mtrx1[i, j] = mtrx[i + 1, j];
                        }
                    }
                }
                output(mtrx1, a - 1, b);
                return mtrx1;
            }
        }
        public static int[] MinMtrx(double[,] mtrx, int a, int b)
        {
            int I = 0;
            int J = 0;
            double min = 100000000000;
            int[] mass = new int[2];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (mtrx[i, j] < min)
                    {
                        min = mtrx[i, j];
                        mass[1] = j;
                        mass[0] = i;
                    }
                }
            }
            return mass;
        }
        public static double[,] DelColumnWithout0(double[,] mtrx, int a, int b)
        {
            int c = 0;
            int c1 = 0;
            int k = 0;
            double s = 0;
            double max = -100000000000;
            for (int j = 0; j < b; j++)
            {
                c = 0;
                for (int i = 0; i < a; i++)
                {
                    if ((mtrx[i, j] == 0))
                    {
                        c += 1;
                    }
                }
                if (c==0)
                {
                    c1++;
                }
            }
            double[,] mtrx1 = new double[a, b-c1];
            for (int j = 0; j < b-c1; j++)
            {
                c = 0;
                for (int i = 0; i < a; i++)
                {
                    if ((mtrx[i, j] == 0))
                    {
                        c += 1;
                    }
                }
                if (c == 0)
                {
                    k++;
                }
                for (int i = 0; i < a; i++)
                {
                    mtrx1[i, j] = mtrx[i,j+k];
                }
            }
            output(mtrx1, a, b-c1);
            return mtrx1;
        }
        public static int MinMtrxLine(double[,] mtrx, int a, int b)
        {
            int I = 0;
            double s = 0;
            double max = -100000000000;
            int[] mass = new int[2];
            for (int i = 0; i < a; i++)
            {
                s = 0;
                for (int j = 0; j < b; j++)
                {
                    if (mtrx[i, j] < 0)
                    {
                        s += 1;
                    }
                }
                if (s > max)
                {
                    max = s;
                    I = i;
                }
            }
            return I;
        }
        public static int SwapLines(double[,] mtrx, double[,] mtrx1, int a, int b, int I, int I1)
        {
            int I2 = 0;
            double s = 0;
            double max = -100000000000;
            double [] mass = new double[b];
            double [] mass1 = new double[b];
            for (int j = 0; j < b; j++)
            {
                mass[j] = mtrx[I, j];
            }
            for (int j = 0; j < b; j++)
            {
                mtrx[I, j] = mtrx1[I1, j];
            }
            for (int j = 0; j < b; j++)
            {
                mtrx1[I1, j] = mass[j];
            }
            output(mtrx, a, b);
            output(mtrx1, a, b);
            return I;
        }






        static void Main()
        {
            double s = 0;
            int n = 0;
            int m = 0;
            double[,] mtrx = new double[n, m];
            double[,] mtrx1 = new double[n, m];
            double[,] mtrx2 = new double[n, m];
            double[] mass = new double[4];
            int[] arr1 = new int[4];
            int[] arr2 = new int[4];
            double[] arr3 = new double[4];
            double arm = 0;
            double min = 0;
            double min1 = 0;
            double max1 = 0;
            double max2 = 0;
            double q = 0;
            int I = 0;
            int a = 0;
            int b = 0;
            int I1 = 0;
            int J = 0;
            int M = 0;
            int K = 0;
            string str = "";

            #region 1
            Console.WriteLine("Задание 1: ");
            n = 5;
            m = 6;
            mtrx = new double[n, m];
            Console.WriteLine("Введите матрицу, где кол-во строк: " + n + "; и кол-во элементов в строке: " + m);
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            a = 3;
            b = 5;
            mtrx1 = new double[a, b];
            Console.WriteLine("Введите матрицу, где кол-во строк: " + a + "; и кол-во элементов в строке: " + b);
            for (int i = 0; i < a; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < b; j++)
                {
                    mtrx1[i, j] = arr[j];
                }
            }
            arr1 = MaxMtrx(mtrx, n, m);
            arr2 = MaxMtrx(mtrx1, a, b);
            q = mtrx[arr1[0], arr1[1]];
            mtrx[arr1[0], arr1[1]] = mtrx1[arr2[0], arr2[1]];
            mtrx1[arr2[0], arr2[1]] = q;
            Console.WriteLine("Итоговые матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(mtrx1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion


            #region 7
            Console.WriteLine("Задание 7: ");
            n = 4;
            m = 5;
            mtrx = new double[n, m];
            Console.WriteLine("Введите матрицу, где кол-во строк: " + n + "; и кол-во элементов в строке: " + m);
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            a = 5;
            b = 6;
            mtrx1 = new double[a, b];
            Console.WriteLine("Введите матрицу, где кол-во строк: " + a + "; и кол-во элементов в строке: " + b);
            for (int i = 0; i < a; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < b; j++)
                {
                    mtrx1[i, j] = arr[j];
                }
            }
            I = MaxMtrxLine(mtrx, n, m);
            J = MaxMtrxColumn(mtrx1, a, b);
            mtrx2 = new double[n+1, m];
            arr3 = new double[a];
            for (int i = 0; i < n+1; i++)
            {
                arr3[i] = mtrx1[i, J];
            }
            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i<=I)
                    {
                        mtrx2[i, j] = mtrx[i, j];
                    }
                    if (i == (I+1))
                    {
                        mtrx2[i, j] = arr3[j];
                    }
                    if (i > (I+1))
                    {
                        mtrx2[i, j] = mtrx[i-1,j];
                    }

                }
            }
            Console.WriteLine(I);
            Console.WriteLine("Итоговая матрица");
            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion


            #region 13
            Console.WriteLine("Задание 13: ");
            Console.WriteLine("Введите кол-во строк матрицы: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов в строке матрицы: ");
            m = Convert.ToInt32(Console.ReadLine());
            mtrx = new double[n, m];
            Console.WriteLine("Введите матрицу, где кол-во строк: " + n + "; и кол-во элементов в строке: " + m);
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            arr1 = MaxMtrx(mtrx, n, m);
            arr2 = MinMtrx(mtrx, n, m);
            I = arr1[0];
            I1 = arr2[0];
            DelLine(mtrx, n, m, I, I1);
            #endregion


            #region 20
            Console.WriteLine("Задание 20: ");
            Console.WriteLine("Введите кол-во строк матрицы: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов в строке матрицы: ");
            m = Convert.ToInt32(Console.ReadLine());
            mtrx = new double[n, m];
            Console.WriteLine("Введите матрицу, где кол-во строк: " + n + "; и кол-во элементов в строке: " + m);
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Введите кол-во строк матрицы: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов в строке матрицы: ");
            b = Convert.ToInt32(Console.ReadLine());
            mtrx1 = new double[a, b];
            Console.WriteLine("Введите матрицу, где кол-во строк: " + a + "; и кол-во элементов в строке: " + b);
            for (int i = 0; i < a; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < b; j++)
                {
                    mtrx1[i, j] = arr[j];
                }
            }
            DelColumnWithout0(mtrx, n, m);
            DelColumnWithout0(mtrx1, a, b);
            #endregion


            #region 26
            Console.WriteLine("Задание 26: ");
            Console.WriteLine("Введите кол-во строк матрицы: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов в строке матрицы: ");
            m = Convert.ToInt32(Console.ReadLine());
            mtrx = new double[n, m];
            Console.WriteLine("Введите первую матрицу, где кол-во строк: " + n + "; и кол-во элементов в строке: " + m);
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            mtrx1 = new double[n, m];
            Console.WriteLine("Введите вторую матрицу, где кол-во строк: " + n + "; и кол-во элементов в строке: " + m);
            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx1[i, j] = arr[j];
              
                }
            }
            Console.WriteLine();
            I = MinMtrxLine(mtrx, n, m);
            I1 = MinMtrxLine(mtrx1, n, m);
            Console.WriteLine(I + " " + I1);
            SwapLines(mtrx, mtrx1, n, m, I, I1);
            #endregion



        }
    }
}