using System;
namespace ConsoleApp5
{
    class program
    {
        static void Main()
        {
            #region Task 5
            Console.WriteLine("Задание 5:");
            double[,] m1 = new double[4, 6] { { 8, 1, 2, 5, 3, 1 }, { 0, 2, 4, 11, 1, 3 }, { 3, 25, 4, 1, 5, 8 }, { 2, 4, 5, 7, 6, -8 } };
            double[,] m2 = new double[6, 6] { { 1, 5, 2, 7, 3, 0 }, { 6, 4, 1, 3, 9, 6 }, { 7, 3, 11, 5, 2, 1 }, { 0, 32, 0, 0, 0, 0 }, { 1, 15, -3, 2, 6, 0 }, { 9, 1, 2, 13, 6, 5 } };
            int n;
            Console.WriteLine("Матрица А:");
            print(m1);
            Console.WriteLine("Матрица В:");
            print(m2);
            Console.Write("Индекс столбца, в котором ищем максимальный элемент:");
            n = int.Parse(Console.ReadLine());
            int i1, i2;
            i1 = pm(m1, n);
            i2 = pm(m2, n);
            for (int i = 0; i < m1.GetLength(1); i++)
            {
                double x = m1[i1, i];
                m1[i1, i] = m2[i2, i];
                m2[i2, i] = x;
            }
            Console.WriteLine("Матрица А:");
            print(m1);
            Console.WriteLine("Матрица В:");
            print(m2);
            #endregion 


            #region Task 11
            Console.WriteLine("Задание 11:");
            int n1, n2, n3, n4;
            int i3, i4;
            define(out n1, out n2, out n3, out n4, out m1, out m2);
            find_imax(m1, out i1, out i2);
            find_imax(m2, out i3, out i4);
            double p = m1[i1, i2];
            m1[i1, i2] = m2[i3, i4];
            m2[i3, i4] = p;
            Console.WriteLine("Матрица А:");
            print(m1);
            Console.WriteLine("Матрица В:");
            print(m2);
            #endregion 


            #region Task 17
            Console.WriteLine("Задание 17:");
            define(out n1, out n2, out n3, out n4, out m1, out m2);
            replacelines(ref m1);
            replacelines(ref m2);
            Console.WriteLine("Матрица А:");
            print(m1);
            Console.WriteLine("Матрица В:");
            print(m2);
            #endregion


            #region Task 23
            Console.WriteLine("Задание 23:");
            define(out n1, out n2, out n3, out n4, out m1, out m2);
            if (((n1 * n2) >= 5) & ((n3 * n4) >= 5))
            {
                change(ref m1);
                change(ref m2);
                Console.WriteLine("Матрица А:");
                print(m1);
                Console.WriteLine("Матрица В:");
                print(m2);
            }
            else Console.WriteLine("Ошибка: в одной из матриц меньше 5 элементов");
            #endregion 
        }
        static int pm(double[,] a, int b)
        {
            int imax = 0;
            for (int i = 1; i < a.GetLength(0); i++)
            {
                if (a[i, b] > a[imax, b]) imax = i;
            }
            return imax;
        }
        static void print(double[,] q)
        {
            for (int i = 0; i < q.GetLength(0); i++)
            {
                for (int j = 0; j < q.GetLength(1); j++)
                {
                    Console.Write("{0} ", q[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void define(out int n1, out int n2, out int n3, out int n4, out double[,] m1, out double[,] m2)
        {
            Console.Write("Введите размерность матрицы А: ");
            string[] s1 = Console.ReadLine().Split();
            n1 = int.Parse(s1[0]); n2 = int.Parse(s1[1]);
            Console.Write("Введите размерность матрицы B: ");
            string[] s2 = Console.ReadLine().Split();
            n3 = int.Parse(s2[0]); n4 = int.Parse(s2[1]);
            m1 = new double[n1, n2]; m2 = new double[n3, n4];
            Console.WriteLine("Введите элементы матрицы А: ");
            for (int i = 0; i < n1; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n2; j++)
                {
                    m1[i, j] = double.Parse(s[j]);
                }
            }
            Console.WriteLine("Введите элементы матрицы В:");
            for (int i = 0; i < n3; i++)
            {
                string[] s = Console.ReadLine().Split();
                for (int j = 0; j < n4; j++)
                {
                    m2[i, j] = double.Parse(s[j]);
                }
            }
        }
        static void find_imax(double[,] m, out int i1, out int i2)
        {
            i1 = 0; i2 = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] > m[i1, i2])
                    {
                        i1 = i;
                        i2 = j;
                    }
                }
            }
        }
        static double find_amax(double[,] m, int i1)
        {
            int i2 = 0;
            for (int i = 0; i < m.GetLength(1); i++)
            {
                if (m[i1, i] > m[i1, i2]) i2 = i;
            }
            return m[i1, i2];
        }
        static void replacelines(ref double[,] m)
        {
            double[] m3 = new double[m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                m3[i] = find_amax(m, i);
            }
            for (int i = 0; i < m.GetLength(0) - 1; i++)
            {
                int im = i + 1;
                for (int j = i + 1; j < m.GetLength(0); j++)
                {
                    if (m3[j] > m3[im]) im = j;
                }
                if (m3[i] < m3[im])
                {
                    double x = m3[i];
                    m3[i] = m3[im];
                    m3[im] = x;
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        double h = m[i, j];
                        m[i, j] = m[im, j];
                        m[im, j] = h;
                    }
                }
            }
        }
        static void change(ref double[,] m)
        {
            double[,] l = new double[m.GetLength(0) * m.GetLength(1), 3];
            int il = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    l[il, 0] = m[i, j];
                    l[il, 1] = i;
                    l[il, 2] = j;
                    il++;
                }
            }
            for (int i = 0; i < (l.GetLength(0) - 1); i++)
            {
                int k = i + 1;
                for (int j = i + 1; j < l.GetLength(0); j++)
                {
                    if (l[j, 0] > l[k, 0]) k = j;
                }
                if (l[i, 0] < l[k, 0])
                {
                    for (int j = 0; j < 3; j++)
                    {
                        double y = l[i, j];
                        l[i, j] = l[k, j];
                        l[k, j] = y;
                    }

                }
            }
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    bool ok = false;
                    for (int z = 0; z < 5; z++)
                    {
                        if ((m[i, j] == l[z, 0]) & (i == l[z, 1]) & (j == l[z, 2]))
                        {
                            m[i, j] = m[i, j] * 2;
                            ok = true;
                        }
                    }
                    if (ok == false) m[i, j] = m[i, j] / 2;
                }
            }
        }
    }
}



