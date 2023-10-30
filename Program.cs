
using System;

class Program
{
    static void Main()

    {
        #region 1_1 
        //int s = 0;
        //for (int i = 2; i <+ 35; i += 3)
        //{
        //    s += i;
        //}
        //Console.WriteLine(s);
        //Console.ReadLine();
        #endregion

        #region 1_2 
        //double s = 0;
        //for (double i = 1; i < 11; i++)
        //{
        //    s += 1 / i;
        //}
        //Console.WriteLine(s);
        //Console.ReadLine();
        #endregion

        #region 1_3
        //double s = 0;
        //for (double i = 2; i < 113; i += 2)
        //{
        //    s += i / (i + 1);
        //}
        //Console.WriteLine(s);
        //Console.ReadLine();

        #endregion

        #region 1_4
        //double s = 0;
        //double x = 1;
        //double st = x;

        //for (double n = 1; n <= 9; n++)
        //{
        //    s += Math.Cos(n * x) / st;
        //    st *= x;
        //}

        //Console.WriteLine(s);
        //Console.ReadLine();
        #endregion
        #region 1_5
        //double p = 30;
        //double h = 32;
        //double s = 0;
        //for (double i = 0; i < 10; i++)
        //{
        //    s += Math.Pow((p + i * h), 2);
        //}
        //Console.WriteLine(s);
        //Console.ReadLine();

        #endregion
        #region 1_6
        //double y = 0;
        //double x;
        //for (x = -4; x <= 4; x += 0.5)
        //{
        //    y = 0.5 * Math.Pow(x, 2) - 7 * x;
        //    Console.WriteLine($"{x},{y}");
        //    Console.ReadLine();
        //}

        #endregion

        #region 1_7
        //int s = 1;
        //for (int i = 1; i <= 6; i++)
        //{
        //    s *= i;
        //}
        //s = s * 6;
        //Console.WriteLine(s);
        //Console.ReadLine();
        #endregion
        #region 1_8
        //int n = 6;
        //int s = 0;
        //int factorial = 1;

        //for (int i = 1; i <= n; i++)
        //{
        //    factorial *= i;
        //    s += factorial;
        //}

        //Console.WriteLine(s);
        //Console.ReadLine();
        #endregion

        #region 1_9
        //int n = 6;
        //double s = 0;

        //for (int i = 1; i <= n; i++)

        //{
        //    n = i * i;
        //    s += Math.Pow(-1, i) * Math.Pow(5, i) / fact(i);
        //}

        //static long fact(int n)
        //{
        //    long result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}
        //Console.WriteLine(s);
        //Console.ReadLine();
        #endregion

        #region 1_10
        //int a = 3;
        //int step = 7;
        //int res = 1;
        //for (int i = 0; i < step; i++)
        //{
        //    res *= a;
        //}
        //Console.WriteLine(res);
        #endregion

        #region 1_11
        //for(int i = 1; i <= 6; i++)
        //    {
        //    Console.WriteLine(i);
        //}

        //for (int i = 1; i <= 6; i++)
        //{
        //    Console.WriteLine(5);
        //    Console.ReadLine();
        //}

        #endregion

        #region 1_12
        //double s = 1;
        //double x = 7;
        //double k = x;

        //for (int i = 1; i <= 10; i++)
        //{
        //    s = s + 1 / k;
        //    k *= x;
        //}
        //Console.WriteLine(s);
        //Console.ReadLine();

        #endregion

        #region 1_13
        //double x, y;
        //double h = 0.1;
        //for (x = -1.5; x<= 1.5; x+=h)
        //{
        //    if (x <= -1) y = 1;
        //    if (x <= 1 & x>-1) y = -x;
        //    else y = -1;
        //    Console.WriteLine($"{x} {y}");
        //}
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion
        #region 1_14
        //int n = 8;
        //int a = 1;
        //int b = 1;

        //Console.Write(a + " " + b + " ");

        //for (int i = 3; i <= n; i++)
        //{
        //    int c = a + b;
        //    Console.Write(c + " ");
        //    a = b;
        //    b = c;
        //}

        //Console.WriteLine();
        //Console.ReadLine();

        #endregion

        #region 1_15
        //double a1 = 1;
        //double b1 = 1;
        //double a2 = 2;
        //double b2 = 1;
        //int n = 5;
        //for (int i = 3; i <= n; i++)
        //{
        //    double nexta = a1 + a2;
        //    double nextb = b1 + b2;
        //    a1 = a2;
        //    b1 = b2;
        //    a2 = nexta;
        //    b2 = nextb;

        //}
        //double res = a2 / b2;
        //Console.WriteLine(res);
        //Console.ReadLine();

        #endregion

        #region 2_1
        //double x = 1.0;
        //const double Eps = 0.0001;
        //double sum = 0.0, element;
        //int n = 1;
        //do
        //{
        //    element = Math.Cos(n * x) / Math.Pow(n, 2);
        //    sum += element;
        //    n += 1;
        //} while (Math.Abs(element) > Eps);
        //Console.WriteLine( sum);
        //Console.ReadLine();

        #endregion

        #region 2_2
        //int n = 1;
        //int p = 1;

        //for (int i = n; i = i + 3);
        //{
        //    if (p * i < 30000)
        //        p = p * i;
        //    else
        //    {
        //        n = i - 3;
        //        break;
        //    }
        //}
        //Console.WriteLine(n);
        //Console.ReadLine();
        #endregion
        #region 2_3
        //double sum = 0;
        //const double p = 15;
        //int n = 0;
        //double a = 2;
        //double h = 4;

        //while (sum + a <= p)
        //{
        //    n++;
        //    sum += a;
        //    a += h;
        //}

        //Console.WriteLine(n);
        //Console.ReadLine();
        #endregion
        #region 2_4
        //const double eps = 0.0001;
        //double x = 0.9;
        //double s = 1;
        //double n = 0;
        //double a = 1;

        //while (a >= eps)

        //{
        //    n++;
        //    a *= x * x;
        //    s += a;
        //}

        //Console.WriteLine(s);
        //Console.ReadLine();

        #endregion
        #region 2_5
        //int N, M;
        //int res = 5;
        //N = 5;
        //M = 3;
        //while (N >= M)
        //{
        //    N -= M;
        //    res++;
        //}
        //Console.WriteLine($"частное: {res}, остаток: {N}");
        //Console.ReadKey();
        //Console.ReadLine();
        #endregion

        #region 2_7(a)
        //double s = 10;
        //double u = 0;
        //double k = 0;
        //while (k < 7)
        //{
        //    u += s;
        //    s = s * 1.1;
        //    k += 1;
        //}
        //Console.WriteLine(u);
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion
        #region 2_7(б)
        //double s = 10;
        //double u = 0;
        //double k = 0;
        //while (u < 100)
        //{
        //    u += s;
        //    s *= 1.1;
        //    k++;
        //}
        //Console.WriteLine(k);
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion
        #region 2_7(в)
        //double s = 10;
        //double k = 1;
        //while (s < 20)
        //{
        //    s *= 1.1;
        //    k++;
        //}
        //Console.WriteLine(k);
        //Console.WriteLine();
        //Console.ReadLine();
        #endregion
        #region 2_8
        //int s = 10000;
        //int n = 0;
        //while (s < 20000)
        //{
        //    s += s * 8 / 100;
        //    n++;
        //}
        //Console.WriteLine(n);
        //Console.ReadLine();
        #endregion
        #region 3_2
        //double s = 0;
        //double eps = 0.0001;
        //double a = 0.1;
        //double b = 0.8;
        //double h = 0.1;
        //double x = a;
        //int i = 0;
        //double y;
        //while (true)
        //{
        //    double now = (Math.Pow(x, i) * Math.Sin((i * Math.PI) / 4));

        //    if (now < eps)
        //    {
        //        y = ((x * Math.Sin((Math.PI / 4))) / (1 - 2 * x * Math.Cos((Math.PI) / 4) + x * x));
        //        break;
        //    }
        //    else
        //    {
        //        s += now;
        //    }
        //    i++;
        //    x += h;
        //}
        //Console.WriteLine(y);
        //Console.WriteLine(s);
        //Console.ReadLine();
        #endregion

    }


}
