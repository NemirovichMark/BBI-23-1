using System.Runtime.Serialization.Formatters;

internal class Program
{


    private static void Task1()
    {
        int s = 0;
        for (int i = 2; i <= 35; i += 3)
        {
            s += i;
        }
        Console.WriteLine(s);
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("1_1");
        Task1();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_2");
        Task2();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_3");
        Task3();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_4");
        Task4();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_5");
        Task5();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_6");
        Task6();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_7");
        Task7();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_8");
        Task8();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_9");
        Task9();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_10");
        Task10();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_11");
        Task11();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_12");
        Task12();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_13");
        Task13();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_14");
        Task14();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_15");
        Task15();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_1");
        Task2_1();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_2");
        Task2_2();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_3");
        Task2_3();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_4");
        Task2_4();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_5");
        Task2_5();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_7_1");
        Task2_7_1();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_7_2");
        Task2_7_2();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_7_3");
        Task2_7_3();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("3_1");
        Task3_1();
    }


    private static void Task2()
    {
        double s = 0;
        for (int i = 1; i < 11; i++)
        {
            s += (1.0) / (i);
        }
        Console.WriteLine(s);
    }

    private static void Task3()
    {
        double s = 0;
        for (int i = 0; i <= 55; i++)
        {
            double num = 2.0 + (2.0 * i);
            double denum = 3.0 + (2.0 * i);

            s += num / denum;
        }
        Console.WriteLine(s);

    }
 private static void Task4()
 {
     double s = 0;
     double x = 1;
     double k = x;
     for (double i = 1; i <= 9; i++)
     {
         s += Math.Cos(i * x) / k;
         k *= x;
     }
     Console.WriteLine("\n{0}", s);
     Console.WriteLine();
 }

    private static double myPow(double x, int y)
    {
        double result = 1;
        for (int i = 0; i < y; i++)
            result *= x;
        return result;
    }
    private static void Task5()
    {
        double s = 0;
        double p = 3.5;
        double h = 69.0;
        for (int i = 0; i <= 9; i++)
        {
            double q = p + i * h;
            s += q * q;
        }
        Console.WriteLine(s);
    }
    private static void Task6()
    {
        for (double x = -4; x <= 4; x += 0.5)
        {
            double y = 0.5 * x * x - 7 * x;
            Console.WriteLine($"{x} {y}");
        }
    }
    private static void Task7()
    {
        Console.WriteLine(fac(6));
    }

    private static int fac(int x)
    {
        int result = 1;

        for (int i = 1; i <= x; i++)
        {
            result *= i;
        }

        return result;
    }

    private static void Task8()
    {
        int s = 0;

        for (int i = 1; i <= 6; i++)
        {
            s += fac(i);
        }

        Console.WriteLine(s);
    }

    private static void Task9()
    {
        double s = 0;

        for (int i = 1; i <= 6; i++)
        {
            s += myPow(-1, i) * myPow(5, i) / fac(i);
        }


        Console.WriteLine(s);
    }

    private static void Task10()
    {
        Console.WriteLine(myPow(3, 7));
    }

    private static void Task11()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            Console.Write(5 + " ");
        }

        Console.WriteLine();
    }

    private static void Task12()
    {
        double s = 0;
        double x = 69;

        for (int i = 0; i <= 10; i++)
        {
            s += 1.0 / myPow(x, i);
        }

        Console.WriteLine(s);
    }

    private static void Task13()
    {
        double y = 0;
        double h = 0.1;
        Console.WriteLine("\n{0}", "x   y");
        for (double x = -1.5; x <= 1.5; x += h)
        {
            if (x <= -1) y = 1;
            if (x > -1 & x <= 1) y = -x;
            else y = -1;
            Console.WriteLine($"{x} {y}");
        }
        Console.WriteLine();
    }

    private static void Task14()
    {
        int fib1 = 1;
        int fib2 = 1;

        Console.Write(fib1 + " ");
        Console.Write(fib2 + " ");

        for (int i = 3; i <= 8; i++)
        {
            if (i % 2 == 1)
            {
                fib1 += fib2;
                Console.Write(fib1 + " ");
            }
            else
            {
                fib2 += fib1;
                Console.Write(fib2 + " ");
            }
        }
        Console.WriteLine();
    }
    private static void Task15()
    {
        int fib1 = 1;
        int fib2 = 1;

        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 0)
            {
                if (i == 4) Console.Write($"{fib2}/{fib1} ");
                fib1 += fib2;
            }
            else
            {
                fib2 += fib1;
            }
        }
    }
    private static void Task2_1()
    {
        double s = 0, x = 0.25, a;
        const double eps = 0.0001;
        int n = 1;
        do
        {
            a = Math.Cos(n * x) / myPow(n, 2);
            s = s + a;
            n = n + 1;
        } while (Math.Abs(a) > eps);
        Console.WriteLine("сумма равна {0:f}", s);
    }
    private static void Task2_2()
 {
     double p = 1;
     int L = 30000;
     int i = 1;
     while (p <= L)
     {
         i += 3;
         p *= i;
     }
     Console.WriteLine(i-3);
 }
    private static void Task2_3()
    {
        double sum = 0;
        int a = 2;
        int h = 8;
        int n = 0;
        int p = 218000;
        while (sum <= p)
        {
            sum += a + n * h;
            n += 1;
        }
        Console.WriteLine(n);
    }
 private static void Task2_4()
 {
     double sum = 0;
     double x = 0.5;
     int n = 0;
     const double eps = 0.0001;
     double k = myPow(x, n);
     while ((x * k) >= eps)
     {
         k=myPow(x,n);
         sum += k;
         n += 2;
     }

     Console.WriteLine(sum);
 }
    private static void Task2_5()
    {
        int m = 2, chast = 0, ostat = 0;
        int n = 7;
        while (n - m >= 0)
        {
            chast += 1;
            n = n - m;
        }
        ostat = n;
        Console.WriteLine("\nЧастное:{0}, Остаток: {1}", chast, ostat);
        Console.WriteLine();
    }
    private static void Task2_7_1()
    {
        double s = 10.0;
        double x = 0;
        int y = 0;
        while (y < 7)
        {
            x += s;
            s = s * 1.1;
            y += 1;
        }
        Console.WriteLine(x);
        Console.WriteLine();
    }
    private static void Task2_7_2()
    {
        double s = 10;
        double x = 0;
        int y = 0;
        while (x < 100)
        {
            x += s;
            s *= 1.1;
            y++;
        }
        Console.WriteLine(y);
        Console.WriteLine();
    }
    private static void Task2_7_3()
    {
        double s = 10;
        int y = 1;
        while (s < 20)
        {
            s *= 1.1;
            y++;
        }
        Console.WriteLine(y);
        Console.WriteLine();
    }
    private static void Task3_1()

 {
     static long Fact(long n)
     {
         if (n == 0)
             return 1;
         else
             return n * Fact(n - 1);
     }
     {
         double s = 0;
         double a = 0.1;
         double b = 1;
         double h = 0.1;
         int i = 0;
         double q = 1;
         for (double x = a; x <= b; x += h)
         {
             s = 0;
             i = 0;
             q = 1;
             double k = q * myPow(x, 2 * i) / Fact(2 * i);
             while (Math.Abs(k) >= 0.0001)
             {
                 k = q * myPow(x, 2 * i) / Fact(2 * i);
                 s += k;
                 i += 1;
                 q = -q;
             }
             double y = Math.Cos(x);
             Console.WriteLine($"{s} {y}");
         }

     }
 }
}
