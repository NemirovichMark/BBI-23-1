using System;
namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            /* #region Task1.1
                int S = 0;
                 for (int i = 2; i<=35; i= i+3)
                  {
                   S=S+i;
                  }
                 Console.WriteLine(S);
               #endregion */

            /* #region Task1.2
                 double S = 1;
                  for (double i = 1; i <= 10; i++)
                   {
                     S = S + 1 / i;
                   }
                   Console.WriteLine("s = {0}", S);
                   #endregion */

            /* #region Task1.3
               double S = 0;
               for (int i = 2; i <= 112; i = i + 2)
               {
                 S = S + i / (i + 1.0);
               }
               Console.WriteLine("s = {0}", S);
               #endregion */

            /* #region Task1.4
              double s = 0;
              double x = 1;
              double k = x;
              for (double n = 1; n<= 9; n++) 
              {
                  s+= Math.Cos(n * x)/k;
                  k =k* x;
              }
              Console.WriteLine(s);
              #endregion */

            /* #region Task1.5
            double s = 0;
            double h = 1;
            double p = 1;
            for (double i = 0; i <= 9; i++)
            {
                s = s + (p + h * i)*(p + h * i);
            }
            Console.WriteLine("\n{0}", s);
            Console.WriteLine();
            #endregion */

            /* #region Task1.6
            const double xh = -4, xk = 4, h = 0.5;
            double x, y;
            int i, n;
            n = (int) ((xk - xh) / h + 1);// определение количества значений аргумента при его изменении в пределах с шагом h
            x = xh;
            for (i = 1; i <= n; i = i + 1)
            {
                y = 0.5 * x * x - 7 * x;
                Console.WriteLine("x={0:f2}\ty = {1:f2}", x, y);
                x = x + h;
            }
            #endregion */

            /* #region Task1.7
            const int n = 6;
            int p = 1;
             for (int i = 2; i <= n; i++)
            {
                p = p * i;
            }
            Console.WriteLine("p={0:d}", p);
            #endregion */

            /* #region Task1.8
            double s = 1, fac=1;
            for (int i = 2; i <= 6; i++) 
            {
                fac = fac * i;
                s = s + fac;
            }
            Console.WriteLine(s);
            #endregion */

            /* #region Task1.9 
            double s = 0, fac = 1;
            double a=-1; double m=5;
            for (int i = 1; i <= 6; i++) 
            {
                fac = fac * i;
                s += a * m / fac;
                a *= -1;
                m *= 5;
            }
            Console.WriteLine(s);
            #endregion */

            /* #region Task1.10
            double s = 1;
            for (int i = 1; i <= 7; i++) 
            {
                s = s * 3;
            }
            Console.WriteLine(s);
            #endregion */

            /* #region Task1.11.a
            for (int i = 1; i <= 6; i++) 
            {
                Console.Write(i + " ");
            }
            #endregion */

            /*  #region Task1.11.b
              int a = 5;
              for (int i = 0; i <= a; i++)
              {
                  Console.Write(a + " ");
              }
              #endregion */

            /* #region Task1.12
           double s = 1;
           double x = 7;
           double k=x;
           for (int i = 1; i <= 10; i++)
           {
               s = s + 1 / k;
               k*=x;
           }
           Console.WriteLine(s);
           #endregion */

            /* #region Task1.13
            double x, y;
            double h = 0.1;
            for (x = -1.5; x <= 1.5; x += h) 
            {
                if (x <= -1) y = 1;
                if (x > 1 & x <= 1) y = -x;
                else y = -1;
                Console.WriteLine($"{x} {y}");
            }
            Console.WriteLine();
            #endregion */

            /* #region Task1.14
             double n = 8;
             double a = 1;
             double b = 1;
             double c = 0;
             Console.Write($"{a} {b}");
             for (int i=2; i<n; i++)
             {
                 c = a + b;
                 Console.Write($"{c}");
                 a = b;
                 b = c;
             }
             Console.WriteLine();
             #endregion */

            /* #region Task1.15
            double k = 1;
            double b = 1;
            double c = 0;
            for (int i = 0; i < 5; i++) ;
            {
                c = k;
                k = k + b;
                b= c;
            }
            Console.WriteLine($"{k}/{b}");
            #endregion */

            /* #region Task2.1
             double x = 1;
             const double eps = 0.0001;
             double s = 0, a;
             int n = 1;
             do
             {
                 a = Math.Cos(n * x) / (n*n);
                 s = s + a;
                 n = n + 1;
             } while (Math.Abs(a) > eps);
             Console.WriteLine("Сумма равна {0:f4}", s);
             #endregion */

            /* #region Task2.2
            int n = 1;
            int p = 1;
            for (int i = n; ; i = i + 3)
            {
                if (p * i < 30000)
                    p = p * i;
                else
                {
                    n = i - 3;
                    break;
                }
            }
            Console.WriteLine(n);
            #endregion */

            /* #region Task2.3
             int s = 0, n = 0, m;
             const int a = 2, h = 3, p = 41;
             while (s < p)
             {
                 m = a + n * h;
                 s = s + m;
                 n = n + 1;
             }
             n = n - 1;
             Console.WriteLine("{0:d}", n);
             #endregion */

            /* #region Task2.4
             const double eps = 0.0001;
             double x = 0.9;
             double s = 1;
             double n = 0;
             double a = 1;
             while (a >= eps)
             {
                 n++;
                 a *= x * x;
                 s += a;
             }
             Console.WriteLine(s);
             #endregion */

            /* #region Task2.5
            int N, M;
            int result = 0;
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            while (N >= M)
            {
                N -= M;
                result++;
            }
            Console.WriteLine($"Частное: {result}, остаток: {N}");
            #endregion */

            /* #region Task2.7.a
             double s = 10;
             double p = 0;
             double d = 0;
             while (d < 7)
             {
                 p = p + s;
                 s = s * 1.1;
                 d = d + 1;
             }
             Console.WriteLine(p);
             #endregion */

            /* #region Task2.7.b
            double s = 10;
            double p = 0;
            double d = 0;
            while (p < 100)
            {
                p = p + s;
                s = s * 1.1;
                d = d + 1;
            }
            Console.WriteLine(d);
            #endregion */

            /* #region Task2.7.c
            double s = 10;
            double d = 1;
            while (s < 20)
            {
                s = s * 1.1;
                d = d + 1;
            }
            Console.WriteLine(d);
            #endregion */

           /* #region Task2.8
            int s = 10000;
            int n = 0;
            while (s < 20000)
            {
                s += s * 8 / 100;
                n++;
            }
            Console.WriteLine($"{n}");
            #endregion */
        }
    }
}