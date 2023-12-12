public class Program
{
    public static void Main(string[] args)
    {
        #region 1_3
        Console.WriteLine("1_3:");
        string str = "";
        int n = 4;
        int m = 4;
        double[,] mtrx = new double[n, m];
        double sum = 0;
        Console.WriteLine("Введите матрицу - 4 строки по 4 эллемента:");
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
            sum += mtrx[i, i] + mtrx[i, (n - 1) - i];
        }
        Console.WriteLine("След:");
        Console.WriteLine(sum);
        #endregion
        Console.WriteLine();

        #region 1_7
        Console.WriteLine("1_7:");
        n = 3;
        m = 5;
        double max = Math.Pow(-10, 20);
        int index = 0;
        double[] mas = new double[m];
        mtrx = new double[n, m];
        Console.WriteLine("Введите матрицу - 3 строки по 5 эллементов:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] arr = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                mtrx[i, j] = arr[j];
            }
        }
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (mtrx[i, j] > max)
                {
                    max = mtrx[i, j];
                    index = i;
                }
            }
            mas[j] = index;
            max = Math.Pow(-10, 20);
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
        Console.WriteLine();
        Console.WriteLine("Полученный массив индексов :");
        Console.WriteLine("[{0}]", string.Join(';', mas));
        #endregion
        Console.WriteLine();

        #region 1_11
        Console.WriteLine("1_11:");
        n = 5;
        m = 7;
        double min = Math.Pow(10, 20);
        mtrx = new double[n, m];
        double[,] array = new double[n - 1, m];
        index = 0;
        max = Math.Pow(-10, 20);
        Console.WriteLine("Введите матрицу - 5 строк по 7 эллементов: ");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] arr = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                mtrx[i, j] = arr[j];
                if (arr[j] < min && j == 0)
                {
                    min = arr[j];
                    index = i;
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
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i < index)
                {
                    array[i, j] = mtrx[i, j];
                }
                if (i > index)
                {
                    array[i - 1, j] = mtrx[i, j];
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
        #endregion
        Console.WriteLine();

        #region 1_15
        Console.WriteLine("1_15:");
        n = 5;
        m = 7;
        mtrx = new double[n, m];
        array = new double[n, m];
        Console.WriteLine("Введите матрицу - 5 строк по 7 эллементов: ");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] arr = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                mtrx[i, j] = arr[j];
                array[i, j] = mtrx[i, j] * (i + 1);
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
        Console.WriteLine();
        Console.WriteLine("Конечная матрица:");
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        #endregion
        Console.WriteLine();

        #region 1_19
        Console.WriteLine("1_19:");
        Console.WriteLine("Введите кол-во строк:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        m = int.Parse(Console.ReadLine());
        double[,] A = new double[n, m];
        int[] B = new int[n];
        max = Math.Pow(-10, 20);
        index = 0;
        Console.WriteLine("Введите матрицу - " + n + " строк по " + m + " эллементов,через пробел:");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] arr = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                A[i, j] = arr[j];
                if (arr[j] > max)
                {
                    max = arr[j];
                    index = j;
                }
            }
            B[i] = index;
            max = Math.Pow(-10, 20);
            index = 0;
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < 0 && j < B[i])
                {
                    A[i, j] = A[i, j] / A[i, B[i]];
                }
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        #endregion
        Console.WriteLine();

        #region 1_23
        Console.WriteLine("1_23:");
        n = 5;
        m = 7;
        mtrx = new double[n, m];
        array = new double[n, m];
        int[] D = new int[n];
        max = int.MaxValue;
        index = 0;
        Console.WriteLine("Введите матрицу - 5 строк по 6 эллементов: ");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] mass = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m - 1; j++)
            {
                mtrx[i, j] = mass[j];
                if (mtrx[i, j] > max)
                {
                    max = mass[j];
                    index = j;
                }
            }
            D[i] = index;
            index = 0;
            max = int.MaxValue;
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
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (j <= D[i])
                {
                    array[i, j] = mtrx[i, j];
                }
                if ((j - 1) == D[i])
                {
                    array[i, j] = mtrx[i, j - 1];
                }
                if ((j - 1) > D[i])
                {
                    array[i, j] = mtrx[i, j - 1];
                }
            }
        }
        Console.WriteLine("Конечная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        #endregion
        Console.WriteLine();

        #region 1_27
        Console.WriteLine("1_27:");
        n = 5;
        m = 7;
        mtrx = new double[n, m];
        D = new int[n];
        max = int.MinValue;
        index = 0;
        Console.WriteLine("Введите матрицу - 5 строк по 7 эллементов: ");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] arr = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                mtrx[i, j] = arr[j];
                if (mtrx[i, j] > max)
                {
                    max = arr[j];
                    index = j;
                }
            }
            D[i] = index;
            index = 0;
            max = int.MinValue;
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
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            mtrx[i, 3] = mtrx[i, D[i]];
        }
        Console.WriteLine("Конечная матрица");
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

        #region 2_1
        Console.WriteLine("2_1:");
        n = 5;
        m = 7;
        mtrx = new double[n, m];
        D = new int[n];
        max = int.MinValue;
        index = 0;
        Console.WriteLine("Введите матрицу - 5 строк по 7 эллементов: ");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] arr = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                mtrx[i, j] = arr[j];
                if (mtrx[i, j] > max)
                {
                    max = arr[j];
                    index = j;
                }
            }
            D[i] = index;
            index = 0;
            max = int.MinValue;
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
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            if (D[i] == 0)
            {
                mtrx[i, 1] = mtrx[i, 1] * 2;
            }
            else if (D[i] == (m - 1))
            {
                mtrx[i, (m - 2)] = mtrx[i, (m - 2)] * 2;
            }
            else
            {
                if (mtrx[i, D[i] - 1] < mtrx[i, D[i] + 1])
                {
                    mtrx[i, D[i] - 1] = mtrx[i, D[i] - 1] * 2;
                }
                else
                {
                    mtrx[i, D[i] + 1] = mtrx[i, D[i] + 1] * 2;
                }
            }
        }
        Console.WriteLine("Конечная матрица");
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

        #region 2_2
        Console.WriteLine("2_5:");
        n = 7;
        m = 5;
        mtrx = new double[n, m];
        D = new int[n];
        max = int.MinValue;
        index = 0;
        sum = 0;
        Console.WriteLine("Введите матрицу - 7 строк по 5 эллементов: ");
        for (int i = 0; i < n; i++)
        {
            str = Console.ReadLine();
            double[] arr = str.Split(' ').Select(double.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                mtrx[i, j] = arr[j];
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mtrx[j, i] > max)
                {
                    max = mtrx[i, j];
                    index = j;
                }
            }
            D[i] = index;
            index = 0;
            max = int.MinValue;
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
        Console.WriteLine();
        for (int i = 0; i < m; i++)
        {
            sum = (mtrx[0, i] + mtrx[(n - 1), i]) / 2;
            if (mtrx[D[i], i] < sum)
            {
                mtrx[D[i], i] = sum;
            }
            else
            {
                mtrx[D[i], i] = D[i];
            }
        }
        Console.WriteLine("Конечная матрица");
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

        #region 2_3
        Console.WriteLine("2_9:");
        n = 6;
        m = 7;
        mtrx = new double[n, m];
        double[,] C = new double[n, m];
        D = new int[n];
        Console.WriteLine("Введите матрицу - 6 строк по 7 эллементов: ");
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
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                C[i, j] = mtrx[i, (m - 1) - j];
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
        #endregion
        Console.WriteLine();

        #region 3_9
        Console.WriteLine("3_9:");


        Console.WriteLine("Введите n (размер матрицы):");
        int.TryParse(Console.ReadLine(), out int n);
        int[,] array = new int[n, n];

        Console.WriteLine($"Введите матрицу размером {n}x{n}: "); //initial array input
        for (int i = 0; i < array.GetLength(0); i++)
        {
            string str = Console.ReadLine();
            string[] lines = str.Split(' ');
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToInt(lines[j]);
            }
        }
        int[] fSum = new int[2 * array.GetLength(0) - 1];

        for (int i = 0; i < n; i++) 
        {
            int sum = 0;
            int sumS = 0;
            for (int j = 0; j <= i; j++)
            {
                sum += array[n - 1 - i + j, j];
                sumS += array[j, n - 1 - j];
            }

            fSum[i] = sum;
            fSum[fSum.Length - i - 1] = sumS;
        }

        Console.WriteLine("Сумма диагоналей матрицы: {0}", string.Join("; ", fSum)); 
        #endregion
        Console.WriteLine();

        #region 3_8
        Console.WriteLine("3_8:");
        int[,] array = new int[7, 5];
        Console.WriteLine("Введите матрицу 7x5: "); 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            string str = Console.ReadLine();
            string[] lines = str.Split(' ');
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToInt(lines[j]);
            }
        }

        for (int i = 0; i < array.GetLength(0) - 1; i++) 
        {
            int index = 0;
            int countM = 0;
            for (int j = i; j < array.GetLength(0); j++) 
            {
                int t = 0;

                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[j, k] > 0) 
                    {
                        t++;
                    }
                }

                if (countM < t) 
                {
                    countM = t;
                    index = j;
                }
            }
            int[] line = new int[array.GetLength(1)];
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                line[j] = array[i, j];
                array[i, j] = array[index, j];
                array[index, j] = line[j];
            }
        }

        Console.WriteLine("Итоговая матрица:"); 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
