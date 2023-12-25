using System;
class Program
{
    public static void Main(string[] args)
    {
        #region 2-9
        Console.WriteLine("2-9:");
        int n = 6; int m = 7;
        double[,] arr = new double[n, m];
        double[,] C = new double[n, m];
        int[] D = new int[n];
        string str;
        Console.WriteLine("Введите матрицу: 6 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
            }
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                C[i, j] = arr[i, (m - 1) - j];
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion


        #region 3-4
        Console.WriteLine("3-4:");
        Console.WriteLine("Введите кол-во строк:");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        int n2 = int.Parse(Console.ReadLine());
        arr = new double[n1, n2];
        C = new double[n1, n2];
        int tempura = 0;
        tempura = n1 / 2;
        Console.WriteLine(tempura);
        Console.WriteLine("Введите матрицу: " + n1 + " строк по " + n2 + " эллементов,через пробел:");
        for (int i = 0; i < n1; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < n2; j++)
            {
                arr[i, j] = mass[j];
                if (i >= tempura && j <= i)
                {
                    C[i, j] = 1;
                }
                else
                {
                    C[i, j] = arr[i, j];
                }
            }
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        #endregion
        #region 3_8
        Console.WriteLine("3_8:");
        n = 7;
        m = 5;
        double[,] mtrx = new double[n, m];
        double s = 0;
        double q = 0;
        double K = 0;
        double []arr1 = new double[7];
        double min = Math.Pow(10, 20);
        Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] arrr = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                mtrx[i, j] = arrr[j];
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
            K = 0;
            for (int j = 0; j < m; j++)
            {
                if (mtrx[i, j] > 0)
                {
                    K += 1;
                    arr1[i] = K;
                }
            }
        }
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
    }
}