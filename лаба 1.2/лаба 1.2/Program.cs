using System;
class Program
{
    static void Main(string[] args)
    {
        #region 2_1
        double x1 = 1;
        const double eps1 = 0.0001;
        double s1 = 0, a1;
        int n1 = 1;
        do
        {
            a1 = Math.Cos(n1 * x1) / (Math.Pow(n1, n1));
            s1 = s1 + a1;
            n1 = n1 + 1;

        }
        while (Math.Abs(a1) > eps1);
        Console.WriteLine();
        Console.WriteLine("Здание 1:");
        Console.WriteLine(s1);
        Console.WriteLine();
        #endregion

        #region 2_2
        int p2 = 1;
        int x2 = 30000;
        int n2 = 1;
        while (p2<=x2)
        {
            p2 *= n2;
            n2 += 3;
        }
        Console.WriteLine();
        Console.WriteLine("Здание 2:");
        Console.WriteLine(n2-3);
        Console.WriteLine();
        #endregion

        #region 2_3
        int s3 = 0;
        int a3 = 1;
        int h3 = 1;
        int n3 = 0;
        int p3 = 200;
        do
        {
            s3 = s3 + a3 + (h3 * n3);
            ++n3;
        }
        while (s3 <= p3);
        Console.WriteLine();
        Console.WriteLine("Здание 3:");
        Console.WriteLine(n3);
        Console.WriteLine();
        #endregion

        #region 2_4
        double s4 = 0;
        double x4 = 0.5;
        const double eps4 = 0.0001;
        double n4 = 0;
        do
        {
            s4 = s4 + Math.Pow(x4, n4);
            n4++;
        }
        while (Math.Abs (s4) <= eps4);
        Console.WriteLine();
        Console.WriteLine("Здание 4:");
        Console.WriteLine(s4);
        Console.WriteLine();
        #endregion

        #region 2_5 
        int m5 = 3, chast = 0, ostat = 0;
        int n5 = 5;
        while (n5 - m5 >= 0)
        {
            chast += 1;
            n5 = n5 - m5;
        }
        ostat = n5;
        Console.WriteLine("Задание 5:\nЧастное:{0}, Остаток: {1}", chast, ostat);
        Console.WriteLine();
        #endregion

        #region 2_7 (a)
        double s7 = 0;
        double r7 = 10;
        int n7 = 0;
        do
        {
            n7 = n7 + 1;
            s7 = s7 + r7;
            r7 = r7 * 1.1;
        }
        while (n7 <= 6);
        Console.WriteLine();
        Console.WriteLine("Здание 7 (a):");
        Console.WriteLine(s7);
        Console.WriteLine();
        #endregion

        #region 2_7 (б)
        double s8 = 0;
        double r8 = 10;
        int n8 = 0;
        do
        {
            s8 = s8 + r8;
            r8 = r8 * 1.1;
            n8 = n8 + 1;
        }
        while (s8 <= 100);
        Console.WriteLine();
        Console.WriteLine("Здание 7 (б):");
        Console.WriteLine(n8);
        Console.WriteLine();
        #endregion

        #region 2_7(в)
        double s9 = 10;
        double r9 = 1.1;
        int n9 = 0;
        do
        {
            s9 = s9 * r9;
            n9 = n9 + 1;
        }
        while (s9 <= 20);
        Console.WriteLine();
        Console.WriteLine("Здание 7 (в):");
        Console.WriteLine(n9);
        Console.WriteLine();
        #endregion

        #region 2_8
        double s10 = 10000;
        double k10 = 1.08;
        double n10 = 0;
        do
        {
            s10 = s10 * k10;
            n10++;
        }
        while (s10 <= 20000);
        Console.WriteLine();
        Console.WriteLine("Здание 8:");
        Console.WriteLine(n10);
        Console.WriteLine();
        #endregion
    }
}
