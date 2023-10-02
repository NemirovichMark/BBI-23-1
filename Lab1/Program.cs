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
            #region 1_4
            double s = 0;
            double x = 1;
            double k = x;
            for(double i = 1; i <=9; i++)
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
                s += (p+h*i)*(p+h*i);
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

            #region 2_4
            double e = 0.0001;
            x = 0.9;
            s = 1;
            k = 1;
            int n = 0;
            while (k >= e)
            {
                n++;
                k *= x * x;
                s += k;
            }
            Console.WriteLine("2_4:\n{0}", s);
            Console.WriteLine();
            #endregion
        }
    }
}
