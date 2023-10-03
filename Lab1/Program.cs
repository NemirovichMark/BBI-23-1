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
            double k = x;
            for (double i = 1; i <= 9; i++)
            {
                s += Math.Cos(i * x) / k;
                k *= x;
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
                s += (p + h * i) * (p + h * i);
            }
            Console.WriteLine("1_5:\n{0}", s);
            Console.WriteLine();
            #endregion

            #region 1_6
            Console.WriteLine("1_6:\n{0}", "x   y");
            double y = 0;
            for (x = -4; x <= 4; x += 0.5)
            {
                y = 0.5 * x * x - 7 * x;
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
            s = 0; k = -1;
            double l = 5;
            for (int i = 1; i <= 6; i++)
            {
                s += k * l / Fact(i);
                k *= -1;
                l *= 5;
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
            s = 1;
            x = 4;
            k = x;
            for (int i = 1; i <= 10; i++)
            {
                s += 1 / k;
                k *= x;
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
            double a = 1;
            double b = 1;
            Console.Write($"{a} {b} ");

            for (int i = 2; i < 8; i++)
            {
                b = a + b;
                Console.Write($"{b} ");
                a = b - a;
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 1_15
            k = 1;
            b = 1;
            double c = 0;
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
                if (Math.Abs(Math.Cos(i * x) / (i * i)) < 0.0001)
                {
                    break;
                }
                else
                {
                    sum += Math.Cos(i * x) / (i * i);
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
            a = 1;
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
            x = 0.9;
            s = 1;
            k = 1;
            n = 0;
            while (k >= e)
            {
                n++;
                k *= x * x;
                s += k;
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
            double u = 0;
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
            while (s < 20)
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
                    k = x * x * x;
                    s = 0;
                    int i = 1;
                    while (Math.Abs(((2 * (i % 2)) - 1) * (k / (4 * i * i - 1))) >= 0.0001)
                    {
                        s += (2 * (i % 2) - 1) * (k / (4 * i * i - 1));
                        k *= x * x;
                        i += 1;
                    }
                    y = (1 + x * x) * Math.Atan(x) / 2;
                    Console.WriteLine($"{s} {y}");
                }
            #endregion
        }
    }
}
