using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

class Program
{
    public static int Fact(int n)
    {
        if (n == 0) return 1;
        if (n == 1) return 1;
        else return Fact(n - 1) * n;
    }
    public static double Step(double n, double step)
    {
        double s = 1;
        for (int i = 0; i < step; i++)
        {
            s = s * n;
        }
        return s;
      
    }
    public static void Main(string[] args)
    {
        #region 1-1
        double s = 0;
        for (double i = 2; i < 36; i += 3)
        {
            s += i;
        }
        Console.WriteLine("1-1:\n{0}", s);
        Console.WriteLine();
        #endregion
        #region 1-2
        s = 0;
        for (double i = 1; i < 11; i++)
        {
            s += 1 / i;
        }
        Console.WriteLine("1-2:\n{0}", s);
        Console.WriteLine();
        #endregion
        #region 1-3
        s = 0;
        for (double i = 2; i < 113; i += 2)
        {
            s += i / (i + 1);
        }
        Console.WriteLine("1-3:\n{0}", s);
        Console.WriteLine();
        #endregion

        #region 1-4
        s = 0.0;
        double x = 60.0;
        for (double i = 1; i < 10; i++)
        {
            s += Math.Cos(i * x) / Step(x, i - 1);
        }
        Console.WriteLine("1-4:\n{0}", s);
        Console.WriteLine();
        #endregion

        #region 1-5
        double p = 10;
        double h = 7;
        s = 0;
        for (double i = 0; i < 10; i++)
        {
            s += Step((p + i * h), 2);
        }
        Console.WriteLine("1-5:\n{0}", s);
        Console.WriteLine();
        #endregion
        #region 1-6
        Console.WriteLine("1-6:");
        double y = 0;
        for (double i = -4; i <= 4; i += 0.5)
        {
            y = 0.5 * Step(i, 2) - 7 * i;
            Console.WriteLine($"{i} {y}");
        }
        Console.WriteLine();
        #endregion
        #region 1-7 
        int n = 6;
        int F = 6;
        F = Fact(n);
        Console.WriteLine("1-7:\n{0}", F);
        Console.WriteLine();
        #endregion
        #region 1-8 
        s = 0;
        for (int i = 1; i <= 6; i++)
        {
            s += Fact(i);
        }
        Console.WriteLine("1-8:\n{0}", s);
        Console.WriteLine();
        #endregion 
        #region 1-9 
        s = 0;
        double k = -1;
        double l = 5;
        for (int i = 1; i <= 6; i++)
        {
            F = Fact(i);
            s += k * l / F;
            k *= -1;
            l *= 5;
        }
        Console.WriteLine("1-9:\n{0}", s);
        Console.WriteLine();
        #endregion
        #region 1-10 
        s = 1;
        for (int i = 1; i <= 7; i++)
        {
            s *= 3;
        }
        Console.WriteLine("1-10:\n{0}", s);
        Console.WriteLine();
        #endregion
        #region 1-11(а) 
        Console.WriteLine("1-11(а):");
        s = 0;
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        #endregion
        #region 1-11(б) 
        Console.WriteLine("1-11(б):");
        s = 0;
        int t = 5;
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(t + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        #endregion
        #region 1-12 
        s = 0;
        k = -1;
        l = 5;
        for (int i = 1; i <= 6; i++)
        {
            F = Fact(i);
            s += k * l / F;
            k *= -1;
            l *= 5;
        }
        Console.WriteLine("1-12:\n{0}", s);
        Console.WriteLine();
        #endregion
        #region 1-13 
        Console.WriteLine("1-13:\n{0}", "x   y");
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
        #region 1_14 
        Console.WriteLine("1-14:");
        n = 8;
        double g = 1;
        double b = 1;
        double m = 0;
        Console.Write($"{g} {b} ");
        for (int i = 2; i < n; i++)
        {
            m = g + b;
            Console.Write($"{m} ");
            g = b;
            b = m;
        }
        Console.WriteLine();
        Console.WriteLine();
        #endregion
        #region 1-15 
        k = 1;
        b = 1;
        for (int i = 0; i < 5; i++)
        {
            m = k;
            k = k + b;
            b = m;
        }
        Console.WriteLine("1-15:\n{0}", $"{k}/{b}");
        Console.WriteLine();
        #endregion

        #region 2-1
        double temp = 0;
        x = 60.0;
        s = Math.Cos(x);
        n = 2;
        do
        {
            temp = Math.Cos(n * x) / Step(n, 2);
            s += temp;
            n++;
        }
        while (Math.Abs(temp) >=0.0001);
        Console.WriteLine("2-1:\n{0}", s);
        Console.WriteLine();
        #endregion
        #region 2-2
        s = 1;
        n = 1;
        do
        {
            s *= n;
            n += 3;
        }
        while (s <= 30000);
        Console.WriteLine("2-1:\n{0}", n);
        Console.WriteLine();
        #endregion
        #region 2-3
        s = 0;
        double a = 1;
        n = 0;
        h = 3;
        p = 10000;
        do
        {
            s += (a + n * h);
            n++;
        }
        while (s <= p);
        Console.WriteLine("2-1:\n{0}", n);
        Console.WriteLine();
        #endregion
        #region 2-4
        s = 1;
        n = 2;
        x = 0.5;
        do
        {
            temp = Step(x, 2 * n);
            s += temp;
            n++;
        }
        while (temp > 0.0001);
        Console.WriteLine("2-1:\n{0}", s);
        Console.WriteLine();
        #endregion
        #region 2-5
        m = 3;
        x = 0;
        y = 0;
        double z = 5;
        while (z - m >= 0)
        {
            x += 1;
            z = z - m;
        }
        y = z;
        Console.WriteLine("2-5:\nЧаст:{0}, Ост: {1}", x, y);
        Console.WriteLine();
        #endregion
        #region 2-7(a,б,в)
        s = 10;
        z = 0;
        m = 0;
        while (m < 7)
        {
            z += s;
            s = s * 1.1;
            m += 1;
        }
        Console.WriteLine("2-7(а):\n{0}", z);
        Console.WriteLine();
        s = 10;
        z = 0;
        m = 0;
        while (z < 100)
        {
            z += s;
            s *= 1.1;
            m++;
        }
        Console.WriteLine("2-7(б):\n{0}", m);
        Console.WriteLine();
        s = 10;
        m = 1;
        while (s < 20)
        {
            s *= 1.1;
            m++;
        }
        Console.WriteLine("2-7(в):\n{0}", m);
        Console.WriteLine();
        #endregion
        #region 2-8
        s = 10000;
        n = 0;
        do
        {
            s *= 1.08;
            n++;
        }
        while (s < 20000);
        Console.WriteLine("2-8:\n{0}", n);
        Console.WriteLine();
        #endregion
        #region 3-5
        Console.WriteLine("3-5:");
        Console.WriteLine($"x y");
        double pi = Math.PI;
        double a1 = pi / 5;
        double b1 = pi;
        double h1 = pi / 25;
        for (double x0 = a1; x <= b1; x += h1)
        {
            double i = 1;
            double y1 = 0;
            double s1 = 0;
            do
            {
                temp = Step(-1, i) * Math.Cos(i * x) / Step(i, 2);
                s1 += temp;
                i++;
            }
            while (temp >= 0.0001);
            y1 = (x * x - (pi * pi / 3)) / 4;
            Console.WriteLine($"{s1} {y1}");
        }
        #endregion
    }
}


