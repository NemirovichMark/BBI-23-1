using System;
class Program
{
    static void Main(string[] args)
    {
        #region 1_1
        int S1 = 0;
        for (int i = 2; i <= 35; i += 3)
        {
            S1 = S1 + i;
        }
        Console.WriteLine("Здание 1:\n");
        Console.WriteLine(S1);
        Console.WriteLine();
        #endregion

        #region 1_2
        double S2 = 0;
        for (double i = 1; i <= 10; i++)
        {
            S2 = S2 + 1 / i;
        }
        Console.WriteLine("Здание 2:");
        Console.WriteLine(S2);
        Console.WriteLine();
        #endregion

        #region 1_3
        double S3 = 0;
        for (double i = 3; i <= 113; i++)
        {
            S3 = S3 + (i - 1) / i;
        }
        Console.WriteLine("Здание 3:");
        Console.WriteLine(S3);
        Console.WriteLine();
        #endregion

        #region 1_4
        double S4 = 0;
        double x4 = 1;
        for (double i = 1; i <= 9; i++)
        {
            S4 = S4 + Math.Cos(i * x4) / Math.Pow(x4, i - 1);
        }
        Console.WriteLine("Здание 4:");
        Console.WriteLine(S4);
        Console.WriteLine();
        #endregion

        #region 1_5
        double S5 = 0;
        double p = 2;
        double h = 5;
        for (double i = 0; i <= 9; i++)
        {
            S5 = S5 + Math.Pow(p + i * h, 2);
        }
        Console.WriteLine("Здание 5:");
        Console.WriteLine(S5);
        Console.WriteLine();
        #endregion

        #region 1_6
        double y6 = 0;
        double x6;
        for (x6 = -4; x6 <= 4; x6 += 0.5)
        {
            y6 = 0.5 * Math.Pow(x6, 2) - 7 * x6;
        }
        Console.WriteLine("Здание 6:");
        Console.WriteLine($"{x6},{y6}");
        Console.WriteLine();
        #endregion

        #region 1_7
        int s7 = 1;
        for (int i = 1; i <= 6; i++)
        {
            s7 = s7 * i;
        }
        Console.WriteLine("Здание 7:");
        Console.WriteLine(s7);
        Console.WriteLine();
        #endregion

        #region 1_8
        int s8 = 0;
        int p8 = 1;
        for (int i = 1; i <= 6; i++)
        {
            p8 = p8 * i;
            s8 = s8 + p8;
        }
        Console.WriteLine("Здание 8:");
        Console.WriteLine(s8);
        Console.WriteLine();
        #endregion

        #region 1_9
        double S9 = 0;
        double p1 = 1;
        for (double i = 1; i <= 6; i++)
        {
            p1 = p1 * i;
            S9 += Math.Pow(-1, i) * Math.Pow(5, i) / p1;
        }
        Console.WriteLine("Здание 9:");
        Console.WriteLine(S9);
        Console.WriteLine();
        #endregion

        #region 1_10
        int a = 3;
        int b = 7;
        int c = 1;
        for (int i = 0; i < b; i++)
        {
            c *= a;
        }
        Console.WriteLine("Здание 10:");
        Console.WriteLine(c);
        Console.WriteLine();
        #endregion

        #region 1_11(а)
        Console.WriteLine("Здание 11(a):");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        #endregion

        #region 1_11(б)
        int t = 5;
        Console.WriteLine();
        Console.WriteLine("Здание 11(б):");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(t + " ");
        }
        Console.WriteLine();
        #endregion

        #region 1_12
        double S12 = 0;
        double x12 = 1;
        for (double i = 0; i <= 10; i++)
        {
            S12 = S12 + (x12 / Math.Pow(x12, i));
        }
        Console.WriteLine();
        Console.WriteLine("Здание 12:");
        Console.WriteLine(S12);
        Console.WriteLine();
        #endregion

        #region 1_13

        Console.WriteLine();
        Console.WriteLine("Здание 13:");

        double h13 = 0.1;
        double xMin = -1.5;
        double xMax = 1.6;
        Console.WriteLine("x\ty");
        for (double x13 = xMin; x13 <= xMax; x13 += h13)
        {
            double y13;
            if (x13 <= -1)
            {
                y13 = 1;
            }
            else if (x13 > -1 && x13 <= 1)
            {
                y13 = -x13;
            }
            else
            {
                y13 = -1;
            }

            Console.WriteLine($"{x13:0.0}\t{y13:0.0}");
            Console.WriteLine();
        }
        #endregion

        #region 1_14
        int n = 8;
        int a14 = 1;
        int b14 = 1;
        Console.WriteLine("Здание 14:");
        Console.WriteLine(a14);
        Console.WriteLine(b14);
        for (int i = 3; i <= n; i++)
        {
            int c14 = a14 + b14;
            Console.WriteLine(c14);
            a14 = b14;
            b14 = c14;
        }
        #endregion

        #region 1_15
        double q1 = 1, q2 = 2;
        double d1 = 1;
        double d2 = 1;
        double n15 = 5;
        for (double i = 3; i <= n15; i++)
        {
            double q = q1 + q2;
            double d = d1 + d2;

            q1 = q2;
            q2 = q;
            d1 = d2;
            d2 = d;
        }
        Console.WriteLine();
        Console.WriteLine("Здание 15:");
        Console.WriteLine("{0}/{1}", q2, d2);
        #endregion
    }
}
