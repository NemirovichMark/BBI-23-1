using System;
using System.Runtime.Serialization.Formatters;

internal class Programm
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_3:");
        Task1_3();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_7:");
        Task1_7();
        /*Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_11:");
        Task1_11();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_15:");
        Task1_15();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_19:");
        Task1_19();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_23:");
        Task1_23();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_27:");
        Task1_27();*/
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_3:");
        Task2_3();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_7:");
        Task2_7();
    }
    private static void Task1_3()
    {
        int n = 4, m = 4;
        double[,] arr = new double[n, m];
        double su = 0;
        Console.WriteLine("Введите матрицу: 4 строки по 4 эллемента,через пробел:");
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
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
        for (int i = 0; i < n; i++)
        {
            su = su + arr[i, i] + arr[i, (n - 1) - i];
        }
        Console.WriteLine("След:");
        Console.WriteLine(su);
        Console.WriteLine();
    }
    private static void Task1_7()
    {
        int n = 3;
        int m = 5;
        double max = -Math.Pow(10, 20);
        int ind = 0;
        double[] mas = new double[m];
        double[,] arr = new double[n, m];
        Console.WriteLine("Введите матрицу: 3 строки по 5 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
            }
        }
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
            mas[j] = max;
            max = -10000000000;
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
        Console.WriteLine("Полученный массив индексов :");
        Console.WriteLine("[{0}]", string.Join(';', mas));
        Console.WriteLine();
    }
    private static void Task1_11()
    {
        int n = 5; 
        int m = 7;
        double min = Math.Pow(10, 20);
        double [,] arr = new double[n, m];
        double[,] array = new double[n - 1, m];
        int ind = 0; 
        double maxim = -Math.Pow(10, 20);
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (mass[j] < min && j == 0)
                {
                    min = mass[j];
                    ind = i;
                }
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
                if (i < ind)
                {
                    array[i, j] = arr[i, j];
                }
                if (i > ind)
                {
                    array[i - 1, j] = arr[i, j];
                }
            }
        }
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void Task1_15()
    {
        int n = 5; 
        int m = 7;
        double [,] arr = new double[n, m];
        double [,] arr1 = new double[n, m];
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                arr1[i, j] = arr[i, j] * (i + 1);
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
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void Task1_19()
    {
        Console.WriteLine("Введите кол-во строк:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        int m = int.Parse(Console.ReadLine());
        double [,] arr = new double[n, m];
        int[] x = new int[n];
        double max = -Math.Pow(10, 20);
        int ind = 0;
        Console.WriteLine("Введите матрицу: " + n + " строк по " + m + " эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (mass[j] > max)
                {
                    max = mass[j];
                    ind = j;
                }
            }
            x[i] = ind;
            max = -Math.Pow(10, 20);
            ind = 0;
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
                if (arr[i, j] < 0 && j < x[i])
                {
                    arr[i, j] = arr[i, j] / arr[i, x[i]];
                }
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void Task1_23()
    {
        int n = 5; 
        int m = 7;
        double [,] arr = new double[n, m];
        double [,] arr1 = new double[n, m];
        int [] x = new int[n];
        double max = -Math.Pow(10, 20);
        int ind = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 6 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m - 1; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i, j] > max)
                {
                    max = mass[j];
                    ind = j;
                }
            }
            x[i] = ind;
            ind = 0;
            max = -Math.Pow(10, 20);
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
                if (j <= x[i])
                {
                    arr1[i, j] = arr[i, j];
                }
                if ((j - 1) == x[i])
                {
                    arr1[i, j] = arr[i, j - 1];
                }
                if ((j - 1) > x[i])
                {
                    arr1[i, j] = arr[i, j - 1];
                }
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void Task1_27()
    {
        int n = 5; 
        int m = 7;
        double [,] arr = new double[n, m];
        int [] x = new int[n];
        double max = -Math.Pow(10, 20);
        int ind = 0;
        Console.WriteLine("Введите матрицу: 5 строк по 7 эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = mass[j];
                if (arr[i, j] > max)
                {
                    max = mass[j];
                    ind = j;
                }
            }
            x[i] = ind;
            ind = 0;
            max = -Math.Pow(10, 20);
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
            arr[i, 3] = arr[i, x[i]];
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void Task2_3()
    {
        int n = 10;
        int m = 5;
        int ind = 0;
        double su = 0;
        double[,] arr = new double[n, m];
        double max = -Math.Pow(10, 20);
        Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
        for (int i = 0; i < n; i++)
        {
            string str1 = Console.ReadLine();
            double[] mass = str1.Split(' ').Select(double.Parse).ToArray();
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
        for (int j = 0; j < m; j++)
        {
            max = -Math.Pow(10, 20);
            ind = 0;
            su = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    ind = i;
                }
            }
            if (ind <= 4)
            {
                for (int i = ind + 1; i < n; i++)
                {
                    su += arr[i, j];
                }
                arr[0, j] = su;
            }
        }
        Console.WriteLine("Итоговая матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void Task2_7()
    {
        int n = 6;
        int m = 6;
        int ind = 0;
        double su = 0;
        double[,] arr = new double[n, m];
        double max = -Math.Pow(10, 20);
        Console.WriteLine("Введите матрицу(Кол-во строк: " + n + "; Кол-во элементов в строке: " + m + ")");
        for (int i = 0; i < n; i++)
        {
            string str1 = Console.ReadLine();
            double[] mass = str1.Split(' ').Select(double.Parse).ToArray();
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
        for (int i = 0; i < n; i++)
        {
            if (arr[i, i] > max)
            {
                max = arr[i, i];
                ind = i;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if ((i < ind) & (j > i))
                {
                    arr[i, j] = 0;
                }
            }
        }
        Console.WriteLine("Итоговая матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void Task3_2()
    {
        Console.WriteLine("Введите кол-во строк:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        int y = int.Parse(Console.ReadLine());
        double [,] arr = new double[x, y];
        double[,] arr1 = new double[x, y];
        Console.WriteLine("Введите матрицу: " + x + " строк по " + y + " эллементов,через пробел:");
        for (int i = 0; i < x; i++)
        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < y; j++)
            {
                arr[i, j] = mass[j];
                if (i == 0 || j == 0 || i == (x - 1) || j == (y - 1))
                {
                    arr1[i, j] = 0;
                }
                else
                {
                    arr1[i, j] = arr[i, j];
                }
            }
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void Task3_4()
    {
        Console.WriteLine("Введите кол-во строк:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        int y = int.Parse(Console.ReadLine());
        double [,] arr = new double[x, y];
        double [,] arr1 = new double[x, y];
        int k = 0;
        k = x / 2;
        Console.WriteLine(k);
        Console.WriteLine("Введите матрицу: " + x + " строк по " + y + " эллементов,через пробел:");
        for (int i = 0; i < x; i++)
        {
            string str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < y; j++)
            {
                arr[i, j] = mass[j];
                if (i >= k && j <= i)
                {
                    arr1[i, j] = 1;
                }
                else
                {
                    arr1[i, j] = arr[i, j];
                }
            }
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}