using System;
namespace ConsoleApp4
{
    class program
    {
        static void Main(string[] args)
        {
            #region 3.9
            int[,] a = new int[6, 7] { { -20, 13, 10, -17, 7, -11, -8 }, { -6, -7, 5, 9, 4, 11, 32 }, { -2, 37, -4, -43, 9, -10, 3 }, { -4, -6, -9, -8, -3, -7, 0 }, { -4, 6, 7, 9, 5, 11, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
            int[] b = new int[7];
            int min, k, ind = 0;
            for (int i = 0; i < 7; i++)
            {
                k = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (a[j, i] < 0)
                        k++;
                }
                a[5, i] = k;
                b[i] = a[5, i];
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("{0:d}\t", a[i, j]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                min = b[i];
                ind = i;
                for (int j = i + 1; j < 7; j++)
                {
                    if (b[j] < min)
                    {
                        min = b[j];
                        ind = j;
                    }
                }
                k = b[i];
                b[i] = min;
                b[ind] = k;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (a[5, j] == b[i])
                    {
                        ind = j;
                    }
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    k = a[i2, i];
                    a[i2, i] = a[i2, ind];
                    a[i2, ind] = k;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("{0:d}\t", a[i, j]);
                }
            }
            #endregion
        }
    }
}

