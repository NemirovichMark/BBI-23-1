using System;
namespace project
{
    class Project
    {
        public static int Fact(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            else return Fact(n - 1) * n;
        }
        static void Main()
        {
            #region 1_1
            double S = 0;
            for (int i = 2; i <= 35; i += 3)
            {
                S = S + i;
            }
            Console.WriteLine("1_1:\n{0}", S);
            Console.WriteLine();
            #endregion

            #region 1_2
            S = 0;
            for (double i = 1; i <= 10; i++)
            {
                S = S + 1 / i;
            }
            Console.WriteLine("1_2:\n{0}", S);
            Console.WriteLine();
            #endregion

            #region 1_3
            double s = 0;
            for (double i = 2; i <= 113; i += 2)
            {
                s = s + i / (i + 1);
            }
            Console.WriteLine("1_3:\n{0}", s);
            Console.WriteLine();
            #endregion

            #region 1_4
            s = 0;
            double x = 1;
            for (double i = 1; i <= 9; i++)
            {
                s = s + Math.Cos(i * x) / Math.Pow(x, (i - 1));
            }
            Console.WriteLine("1_4:\n{0}", s);
            Console.WriteLine();
            #endregion

            #region 1_5
            s = 0;
            double h = 1;
            double p = 1;
            for (double i = 0; i <= 9; i++)
            {
                s = s + Math.Pow(p + h * i, 2);
            }
            Console.WriteLine("1_5:\n{0}", s);
            Console.WriteLine();
            #endregion

            #region 1_6
            Console.WriteLine("1_6:\n{0}", "x   y");
            double y = 0;
            for (x = -4; x <= 4; x += 0.5)
            {
                y = 0.5 * Math.Pow(x, 2) - 7 * x;
                Console.WriteLine($"{x} {y}");
            }
            Console.WriteLine();
            #endregion

            #region 1_7
            int n = 6;
            int f = 6;
            f = Fact(n);
            Console.WriteLine("1_7:\n{0}", f);
            Console.WriteLine();
            #endregion

            #region 1_8
            s = 0;
            for (int i = 1; i <= 6; i++)
            {
                s += Fact(i);
            }
            Console.WriteLine("1_8:\n{0}", s);
            Console.WriteLine();
            #endregion

            #region 1_9
            s = 0;
            for (int i = 1; i <= 6; i++)
            {
                s += Math.Pow(-1, i) * Math.Pow(5, i) / Fact(i);
            }
            Console.WriteLine("1_9:\n{0}", s);
            Console.WriteLine();
            #endregion

            #region 1_10
            s = 1;
            for (int i = 1; i <= 7; i++)
            {
                s *= 3;
            }
            Console.WriteLine("1_10:\n{0}", s);
            Console.WriteLine();
            #endregion

            Console.WriteLine("1_11(а):");

            #region 1_11(а)
            s = 0;
            for (int i = 1; i <= 6; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("1_11(б):");

            #region 1_11(б)
            s = 0;
            int t = 5;
            for (int i = 1; i <= 6; i++)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 1_12
            s = 0;
            x = 4;
            for (int i = 0; i <= 10; i++)
            {
                s += 1 / Math.Pow(x, i);
            }
            Console.WriteLine("1_12:\n{0}", s);
            Console.WriteLine();
            #endregion

            #region 1_13
            Console.WriteLine("1_13:\n{0}", "x   y");
            y = 0;
            h = 0.1;
            for (x = -1.5; x <= 1.5; x += h)
            {
                if (x <= -1) y = 1;
                if (x > -1 & x <= 1) y = -x;
                else y = -1;
                Console.WriteLine($"{x} {y}");
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine("1_14:");

            #region 1_14
            n = 8;
            double u = 1;
            double b = 1;
            double c = 0;
            Console.Write($"{u} {b} ");

            for (int i = 2; i < n; i++)
            {
                c = u + b;
                Console.Write($"{c} ");
                u = b;
                b = c;
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 1_15
            double k = 1;
            b = 1;
            for (int i = 0; i < 5; i++)
            {
                c = k;
                k = k + b;
                b = c;
            }
            Console.WriteLine("1_15:\n{0}", $"{k}/{b}");
            Console.WriteLine();
            #endregion

            #region 2_1
            x = 1;
            double sum = Math.Cos(x);
            for (int i = 1; i < 10000; i++)
            {
                if ((Math.Abs(Math.Cos(i * x) / Math.Pow(i, 2))) < 0.0001)
                {
                    break;
                }
                else
                {
                    sum = sum + Math.Cos(i * x) / Math.Pow(i, 2);
                }

            }
            Console.WriteLine("2_1:\n{0}", sum);
            Console.WriteLine();
            #endregion

            #region 2_2
            p = 1;
            c = 0;
            for (int g = 1; g < 30000; g += 3)
            {
                if (p > 30000)
                {
                    break;
                }
                else
                {
                    p *= g;
                    c = g - 3;
                }
            }
            Console.WriteLine("2_2:\n{0}", c);
            Console.WriteLine();
            #endregion

            #region 2_3
            p = 100;
            n = 0;
            s = 0;
            double a = 1;
            h = 2;
            while (s <= p)
            {
                s += (a + n * h);
                n += 1;
            }
            Console.WriteLine("2_3:\n{0}", n - 1);
            Console.WriteLine();
            #endregion

            #region 2_4
            double e = 0.0001;
            n = 0;
            x = 0.9;
            s = 0;
            while (Math.Pow(x, 2 * n) >= e)
            {
                s += Math.Pow(x, 2 * n);
                n += 1;
            }
            Console.WriteLine("2_4:\n{0}", s);
            Console.WriteLine();
            #endregion

            #region 2_5
            int m = 3, chast = 0, ostat = 0;
            n = 5;
            while (n - m >= 0)
            {
                chast += 1;
                n = n - m;
            }
            ostat = n;
            Console.WriteLine("2_5:\nЧастное:{0}, Остаток: {1}", chast, ostat);
            Console.WriteLine();
            #endregion

            #region 2_7(а)
            s = 10;
            u = 0;
            k = 0;
            while (k < 7)
            {
                u += s;
                s = s * 1.1;
                k += 1;
            }
            Console.WriteLine("2_7(а):\n{0}", u);
            Console.WriteLine();
            #endregion

            #region 2_7(б)
            s = 10;
            u = 0;
            k = 0;
            while (u < 100)
            {
                u += s;
                s *= 1.1;
                k++;
            }
            Console.WriteLine("2_7(б):\n{0}", k);
            Console.WriteLine();
            #endregion

            #region 2_7(в)
            s = 10;
            k = 1;
            while(s < 20)
            {
                s *= 1.1;
                k++;
            }
            Console.WriteLine("2_7(в):\n{0}", k);
            Console.WriteLine();
            #endregion

            #region 2_8
            s = 10000;
            k = 0;
            while (s <= 20000)
            {
                s *= 1.08;
                k++;
            }
            Console.WriteLine("2_8:\n{0}", k);
            Console.WriteLine();
            #endregion

            Console.WriteLine("3_6:");

            #region 3_6
            double o = 1;
            a = 0.1;
            h = 0.1;
            for (x = a; x <= o; x += h)
            {
                s = 0;
                int i = 1;
                while ((Math.Abs(Math.Pow(-1, i + 1) * (Math.Pow(x, 2 * i + 1) / (4 * Math.Pow(i, 2) - 1)))) >= 0.0001)
                {
                    s += Math.Pow(-1, i + 1) * (Math.Pow(x, 2 * i + 1) / (4 * Math.Pow(i, 2) - 1));
                    i += 1;
                }
                y = ((1 + Math.Pow(x, 2)) * Math.Atan(x)) / 2;
                Console.WriteLine($"{s} {y}");
            }
            #endregion
        }
    }
}
