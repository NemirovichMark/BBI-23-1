using System;
using System.Runtime.Intrinsics.X86;

namespace project
{
    class Project
    {
        public static long Fact(long n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
        static void Main()
        {
            #region 1_1
            int s = 0;
            for (int i = 2; i <= 35; i += 3)
            {
                s = s + i;
            }
            Console.WriteLine("1_1: " + s);
            #endregion

            #region 1_2
            double S = 0;
            for (double i = 1; i <= 10; i++)
            {
                S = S + 1 / i;
            }
            Console.WriteLine("1_2: " + S);
            #endregion

            #region 1_3
            S = 0;
            for (double i = 2; i <= 112; i += 2)
            {
                S = S + i / (i + 1);
            }
            Console.WriteLine("1_3: " + S);
            #endregion

            #region 1_4
            S = 0;
            double sx = 1;
            double x = 1;
            for (double i = 1; i <= 9; i++)
            {
                for (double pow=1; pow<i; pow++)
                {
                    sx = x * sx;
                }
                S = S + Math.Cos(i * x) / sx;
            }
            Console.WriteLine("1_4: " + S);
            #endregion

            #region 1_5
            S = 0;
            double P = 2;
            double H = 3;
            for (double i = 0; i <= 9; i++)
            {
                S = S + (P + i * H) * (P + i * H);
            }
            Console.WriteLine("1_5: " + S);
            #endregion

            #region 1_6
            for (x = -4; x <= 4; x += 0.5)
            {
                double y = 0.5 * x*x - 7 * x;
                Console.WriteLine("1_6: " + $"{x} {y}");
            }
            #endregion

            #region 1_7
            int fact = 1;
            for (int i = 1; i <= 6; i++)
            {
                fact *= i;
            }
            Console.WriteLine("1_7: " + fact);
            #endregion

            #region 1_8
            fact = 1;
            s = 0;
            for (int j = 1; j <= 6; j++)
            {
                fact = 1;
                for (int i = 1; i <= j; i++)
                {
                    fact *= i;

                }
                s += fact;
            }
            Console.WriteLine("1_8: " + s);
            #endregion

            #region 1_9
            S = 0;
            double mo= -1;
            double f= 5;
            double mo2 = -1;
            double f2 = 5;
            for (int i = 1; i <= 6; i++)
            {
                mo = -1;
                f = 5;
                for (int pow=1; pow<i; pow++)
                {
                    mo = mo * mo2;
                    f = f * f2;
                }
                S += mo * f / Fact(i);
            }
            Console.WriteLine("1_9: " + S);
            #endregion

            #region 1_10
            s = 3;
            for (int i = 1; i <= 6; i++)
            {
                s *= 3;
            }
            Console.WriteLine("1_10: " + s);
            #endregion

            #region 1_11_a
            Console.Write("1_11_a: ");
            for (int i = 1; i <= 6; i++)
            {
                Console.Write(i + " ");
            }
            #endregion

            #region 1_11_b
            Console.WriteLine();
            Console.Write("1_11_b: ");
            for (int i = 1; i <= 6; i++)
            {
                Console.Write(5 + " ");
            }
            #endregion

            #region 1_12
            Console.WriteLine();
            x = 10;
            S = 1;
            sx = x;
            for (int i = 1; i <= 10; i++)
            {
                x = 10;
                for (int pow = 1; pow < i; pow++)
                {
                    x = x * sx;
                }
                S += 1 / x;
            }
            Console.WriteLine("1_12: " + S);
            #endregion

            #region 1_13
            for (double t = -1.5; t <= 1.5; t += 0.1)
            {
                if (t <= -1)
                {
                    Console.WriteLine("1_13: " + 1);
                }
                if ((-1 < t) & (t <= 1))
                {
                    Console.WriteLine("1_13: " + Math.Round(-t, 2));
                }
                if (t > 1)
                {
                    Console.WriteLine("1_13: " + -1);
                }
            }
            #endregion

            #region 1_14
            Console.Write("1_14: " + 1 + " " + 1 + " ");
            int b1 = 1;
            int b2 = 1;
            int b3 = 0;
            for (int i = 1; i <= 6; i++)
            {
                b3 = b1 + b2;
                b1 = b2;
                b2 = b3;
                Console.Write(b3 + " ");
            }
            #endregion

            #region 1_15
            Console.WriteLine();
            int ch1 = 1;
            int ch2 = 2;
            int ch3 = 0;
            int z1 = 1;
            int z2 = 1;
            int z3 = 0;
            for (int i = 1; i <= 3; i++)
            {
                ch3 = ch1 + ch2;
                ch1 = ch2;
                ch2 = ch3;
                z3 = z1 + z2;
                z1 = z2;
                z2 = z3;
            }
            Console.WriteLine("1_15: " + (double)ch3 / z3);
            #endregion

            #region 2_1
            S = 0;
            double e = 0.0001;
            double N = 1;
            double r = 1;
            while (Math.Abs(Math.Cos(r * N) / N*N) >= e)
            {
                S += Math.Cos(r * N) / N*N;
                N += 1;
            }
            Console.WriteLine("2_1: " + S);
            #endregion

            #region 2_2
            long p = 1;
            long k = 1;
            while (p <= 30000)
            {
                p *= k;
                k += 3;
            }
            Console.WriteLine("2_2: " + k);
            #endregion

            #region 2_3
            p = 100;
            int n = 0;
            s = 0;
            int a = 1;
            int h = 2;
            while (s <= p)
            {
                s += (a + n * h);
                n += 1;
            }
            Console.WriteLine("2_3: " + (n - 1));
            #endregion

            #region 2_4
            e = 0.0001;
            n = 0;
            double X = 0.9;
            sx = X;
            S = 1;
            do
            {
                n += 1;
                X = 0.9;
                for (int pow=1; pow<2*n; pow++)
                {
                    X = X * sx;
                }
                S += X;
                
            } while (X >= e);
            Console.WriteLine("2_4: " + S);
            #endregion

            #region 2_5
            int m = 3;
            n = 11;
            long ch = 0;
            long ost = 0;
            while (n - m >= 0)
            {
                ch += 1;
                n = n - m;
            }
            ost = n;
            Console.WriteLine("2_5: " + $"{ch} {ost}");
            #endregion

            #region 2_7_a
            double A = 10;
            double K = 10;
            S = 10;
            for (int i = 2; i <= 7; i++)
            {
                S = S + A * (1 + K / 100);
                A = A * (1 + K / 100);
            }
            Console.WriteLine("2_7_a: " + S);
            #endregion

            #region 2_7_b
            A = 10;
            K = 10;
            S = 10;
            n = 0;
            while (S < 100)
            {
                S = S + A * (1 + K / 100);
                A = A * (1 + K / 100);
                n += 1;
            }
            Console.WriteLine("2_7_b: " + n);
            #endregion

            #region 2_7_c
            A = 10;
            K = 10;
            n = 0;
            while (A <= 20)
            {
                A = A * (1 + K / 100);
                n += 1;
            }
            Console.WriteLine("2_7_c: " + n);
            #endregion

            #region 2_8
            S = 10000;
            K = 8;
            while (S < 20000)
            {
                S = S + S * (1 + k / 100);
                n += 1;
            }
            Console.WriteLine("2_8: " + n);
            #endregion

            #region 3_1
            S = 0;
            A = 0.1;
            double b = 1;
            double step = 0.1;
            long J = 0;
            long XJ = 2 * J;
            long MO1 = 1;
            long F = 1;
            for (x = A; x <= b; x += step)
            {
                S = 0;
                J = 0;
                F = 1;
                MO1 = 1;
                double x1 = 1;
                while (Math.Abs(MO1 * x1 / F) >= 0.0001)
                {
                    S += MO1 * x1 / F;
                    x1 = x;
                    J += 1;
                    XJ = J * 2;
                    MO1 = -MO1;
                    F = F * XJ * (XJ - 1);
                    for (int pow = 1; pow < XJ; pow++)
                    {
                        x1 = x1 * x;
                    }
                }
                double y = Math.Cos(x);
                Console.WriteLine("3_1: " + $"{S} {y}");
            }
            #endregion
        }
    }
}

