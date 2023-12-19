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
            double[,] matrix = new double[a, b];
            double[] arr;
            Console.WriteLine("Введите матрицу, где кол-во строк: " + a + "; и кол-во элементов в строке: " + b);
            for (int i = 0; i < a; i++)
            {
                str = Console.ReadLine();
                arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }
            return matrix;
        }
        public static void output(double[,] arr, int a, int b)
        {
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
        public static void outputMassInt(int[] arr, int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static void outputMassDouble(double[] arr, int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static int FindMaxIndexDiagonal(double[,] matrix, int a, int b)
        {
            int I = 0;
            double max = double.MinValue;
            for (int i = 0; i < a; i++)
            {
                if (matrix[i, i]>max)
                {
                    max = matrix[i, i];
                    I = i;
                }
            }
            return I;
        }
        public static void SwapLineToColumn(double[,] matrix, double[,] matrix1, int a, int b, int I, int J)
        {
            double[] mass = new double[b];
            double[] mass1 = new double[b];
            for (int j = 0; j < b; j++)
            {
                mass[j] = matrix[I, j];
            }
            for (int i = 0; i < a; i++)
            {
                mass1[i] = matrix1[i, J];
            }
            for (int i = 0; i < a; i++)
            {
                matrix1[i, J] = mass[i];
            }
            for (int j = 0; j < b; j++)
            {
                matrix[I, j] = mass1[j];
            }
        }
        public static int FindMaxIndexUnderDiagonal(double[,] matrix, int a, int b)
        {
            int J = 0;
            double max = double.MinValue;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i >= j)
                    {
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                            J = j;
                        }
                    }
                }
            }
            return J;
        }
        public static int FindMinIndexOverDiagonal(double[,] matrix, int a, int b)
        {
            int J = 0;
            double min = double.MaxValue;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i < j)
                    {
                        if (matrix[i, j] < min)
                        {
                            min = matrix[i, j];
                            J = j;
                        }
                    }
                }
            }
            return J;
        }
        public static double[,] DelColumn(double[,] matrix, int a, int b, int J)
        {
            double max = double.MinValue;
            double[,] matrix1 = new double[a, b - 1];
            for (int j = 0; j < J; j++)
            {
                for (int i = 0; i < a; i++)
                {
                    matrix1[i, j] = matrix[i, j];
                }
            }
            for (int j = J; j < b - 1; j++)
            {
                for (int i = 0; i < a; i++)
                {
                    matrix1[i, j] = matrix[i, j+1];
                }
            }
            return matrix1;
        }
        public static int[] AmountNegativeElementLines(double[,] matrix, int a, int b)
        {
            int c = 0;
            int[] mass = new int[a];
            for (int i = 0; i < a; i++)
            {
                c = 0;
                for (int j = 0; j < b; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        c += 1;
                    }
                }
                mass[i] = c;
            }
            return mass;
        }
        public static double[] MaxNegativeElementColumns(double[,] matrix, int a, int b)
        {
            double[] mass = new double[b];
            double max = double.MinValue;
            for (int j = 0; j < b; j++)
            {
                max = double.MinValue;
                for (int i = 0; i < a; i++)
                {
                    if ((matrix[i, j] < 0) & (matrix[i,j]>max))
                    {
                        mass[j] = matrix[i,j];
                        max = matrix[i,j];
                    }
                }
            }
            return mass;
        }



        static void Main()
        {
            int n = 0;
            int m = 0;
            double[,] matrix = new double[n, m];
            double[,] matrix1 = new double[n, m];
            double[,] matrix2 = new double[n, m];
            int[] arr1 = new int[4];
            double[] arr = new double[4];
            double q = 0;
            int Imax = 0;
            int Jmax = 0;
            int Jmin = 0;


            #region 4
            Console.WriteLine("Задание 4: ");
            n = 5;
            m = 5;
            matrix = input(n, m);
            matrix1 = input(n, m);
            Console.WriteLine("Исходная матрица: ");
            output(matrix, n, m);
            Console.WriteLine("Исходная матрица: ");
            output(matrix1, n, m);
            Imax = FindMaxIndexDiagonal(matrix, n, m);
            Jmax = FindMaxIndexDiagonal(matrix1, n, m);
            SwapLineToColumn(matrix, matrix1, n, m, Imax, Jmax);
            Console.WriteLine("Итоговая матрица: ");
            output(matrix, n, m);
            Console.WriteLine("Итоговая матрица: ");
            output(matrix1, n , m);
            #endregion


            #region 10
            Console.WriteLine("Задание 10: ");
            Console.WriteLine("Введите кол-во строк и столбцов матрицы (матрица квадратная): ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            if (n - 1 >= 0)
            {
                matrix1 = new double[n, m-1];
            }
            if (n - 2 >= 0)
            {
                matrix2 = new double[n, m-2];
            }
            matrix = input(n, m);
            Console.WriteLine("Исходная матрица: ");
            output(matrix, n, m);
            Jmax = FindMaxIndexUnderDiagonal(matrix, n, m);
            Jmin = FindMinIndexOverDiagonal(matrix, n, m);
            if (n > 0)
            {
                if (Jmax == Jmin)
                {
                    matrix1 = DelColumn(matrix, n, m, Jmax);
                    Console.WriteLine("Итоговая матрица: ");
                    output(matrix1, n, m-1);
                }
                if (Jmax < Jmin)
                {
                    Jmin -= 1;
                    matrix1 = DelColumn(matrix, n, m, Jmax);
                    matrix2 = DelColumn(matrix1, n, m-1, Jmin);
                    Console.WriteLine("Итоговая матрица: ");
                    output(matrix2, n, m-2);
                }
                if (Jmax > Jmin)
                {
                    matrix1 = DelColumn(matrix, n, m, Jmax);
                    matrix2 = DelColumn(matrix1, n, m-1, Jmin);
                    Console.WriteLine("Итоговая матрица: ");
                    output(matrix2, n, m-2);
                }
            }
            #endregion


            #region 22
            Console.WriteLine("Задание 22: ");
            Console.WriteLine("Введите кол-во строк матрицы: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов в строке матрицы: ");
            m = Convert.ToInt32(Console.ReadLine());
            matrix = input(n, m);
            Console.WriteLine("Исходная матрица: ");
            output(matrix, n, m);
            arr1 = new int[n];
            arr1 = AmountNegativeElementLines(matrix, n, m);
            arr = new double[m];
            arr = MaxNegativeElementColumns(matrix, n, m);
            Console.WriteLine("Итоговый массив с количеством отрицательных элементов строк: ");
            outputMassInt(arr1, n);
            Console.WriteLine("Итоговый массив с максимальными среди отрицательных элементов столбцов: ");
            outputMassDouble(arr, m);
            #endregion
        }
    }
}