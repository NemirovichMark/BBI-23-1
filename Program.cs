using System;
class Program
{
    static void Main(string[] args)
    {
        #region 1_4
        double s4 = 0;
        double x4 = 3;
            for (int i4 = 0; i4 <= 8; i4 ++)
            {
            s4 += Math.Cos(x4 * (i4 + 1)) / x4 * i4;
            }
        Console.WriteLine(s4);
        #endregion

        #region 1_5
        double S5 = 0;
        double p5 = 2;
        double h5 = 0;
        for (double i5 = 0; i5 <= 9; i5++)
        {
            S5 += (p5 + h5) * (p5 + h5);
            h5 += 10;
        }
        Console.WriteLine(S5);
        #endregion

        #region 1_9
        double s9 = 0;
        double a9 = 1;
        int x1 = 5;
        int x2 = -1;
        for (int i9 = 1; i9 <= 6; i9++)
        {
            a9 = a9 * i9;
            s9 += x2 * x1 / a9;
            x2 *= x2;
            x1 *= x1;
        }
        Console.WriteLine(s9);
        #endregion

        #region 1_12
        double x12 = 3;
        double s12 = 0;
        double c12 = 1;
        for (int i12 = 0; i12 <= 10; i12++)
        {
            s12 += c12;
            c12 /= x12;
        }
        Console.WriteLine(s12);
        #endregion

        #region 2_1
        double x21 = 3;
        double e1 = 0.0001;

        double s1 = 0;
        double c1;
        double d1;
        int n1 = 1;
        do
        {
            c1 = Math.Cos(n1 * x21);
            d1 = n1 * n1;
            s1 += c1 / d1;
            n1++;
        } 
        while (Math.Abs(c1/ d1) > e1);
        Console.WriteLine(s1);
        #endregion

        #region 2_4
        double x24 = 3;
        double e24 = 0.0001;

        double s24 = 0;
        double c24 = 1;
        int n24 = 0;

        do
        {
            s24 += c24;
            c24 *= x24 * x24;
            n24 += 2;
        } while (Math.Abs(c24) >= e24);

        Console.WriteLine(s24);
        #endregion

        #region 3_4
        double x34 = 1;
        double sum34 = 0;
        {
            double i34 = 1;
            double f34 = 1;
            double s34 = x34;
            while (((2 * i34 + 1) * s34 / f34) > 0.0001)
            {
                sum34 += ((2 * i34 + 1) * s34 / f34);
                i34++;
                f34 *= i34;
                s34 = s34 * s34;
            }

            Console.WriteLine((1 + 2 * x34 * x34) * Math.Pow(Math.E, x34 * x34), x34);

        }
        Console.WriteLine(sum34);
        #endregion
    }
}