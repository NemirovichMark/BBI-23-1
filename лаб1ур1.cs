using System;
class Program
{
    static void Main(string[] args)
    {
        #region 1_1
        float S1 = 0;
        for (float i = 2; i <= 35; i += 3)
        {
            S1 = S1 + i;
        }
        Console.WriteLine(S1);
        #endregion

        #region 1_2
        float S2 = 0;
        for (float i = 1; i <= 10; i++)
        {
            S2 = S2 + 1 / i;
        }
        Console.WriteLine(S2);
        #endregion

        #region 1_3
        float S3 = 0;
        for (float i = 1; i <= 113; i++)
        {
            S3 = S3 + (i - 1) / i;
        }
        Console.WriteLine(S3);
        #endregion

        #region 1_4
        double S4 = 0;
        double x4 = 1;
        for (double i = 1; i <= 9; i++)
        {
            S4 = S4 + (Math.Cos(x4)) / (Math.Pow(x4, i - 1));
        }
        Console.WriteLine(S4);
        #endregion

        #region 1_5

        double S5 = 0;
        double p5 = 1;
        double h5 = 1;
        for (double i = 0; i <= 9; i++)
        {
            S5 = S5 + Math.Pow(p5 + i * h5, 2);
        }
        Console.WriteLine(S5);
        #endregion

        #region 1_6
        double y6 = 0;
        for (double x6 = -4; x6 <= 4; x6 += 0.5)
        {
            y6 = y6 + 0.5 * Math.Pow(x6, 2) - 7 * x6;
            Console.WriteLine(y6);
        }
        Console.WriteLine(y6);
        #endregion

        #region 1_7
        int P7 = 1;
        for (int i = 1; i <= 6; i++)
        {
            P7 = P7 * i;
        }
        Console.WriteLine(P7);
        #endregion

        #region 1_8
        int S8 = 0;
        int P8 = 1;
        for (int i = 1; i <= 6; i++)
        {
            P8 = P8 * i;
            S8 += P8;

        }
        Console.WriteLine(S8);
        #endregion

        #region 1_9
        {

            double S9 = 0;

            double P9 = 1;

            for (double i = 1; i <= 6; i++)

            {

                P9 = P9 * i;

                S9 = S9 + (Math.Pow(-1, i) * Math.Pow(5, i)) / P9;



            }

            Console.WriteLine(S9);

        }
        #endregion

        #region 1_10
        {

            double S10 = 1;

            for (double i = 1; i <= 7; i++)

            {

                S10 = S10 * 3;



            }

            Console.WriteLine(S10);

        }
        #endregion

        #region 1_11а

        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        #endregion

        #region 1_11b

        int t11b = 5;
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(t11b + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        #endregion

        #region 1_12
        {

            double S12 = 0;

            double x12 = 2;

            for (double i = 0; i <= 10; i++)

            {

                S12 = S12 + 1 / (Math.Pow(x12, i));



            }

            Console.WriteLine(S12);

        }
        #endregion

        #region 1_13


        double y13 = 0;

        for (double x13 = -1.5; x13 <= 1.5; x13 += 0.1)

        {

            if (x13 <= 1)

                y13 = 1;

            else if (x13 > -1 && x13 <= 1)

                y13 = x13 * (-1);

            else

                y13 = -1;

            Console.WriteLine(y13);







        }
        #endregion

        #region 1_14
        {

            double f1 = 1;

            double f2 = 1;


            for (double i = 1; i <= 6; i++)

            {

                double f3 = f1 + f2;

                f1 = f2;

                f2 = f3;

                Console.WriteLine(f3);
            }

        }

        #endregion

        #region 1_15
        {

            double f1 = 1;

            double f2 = 1;

            double d1 = 2;

            double d2 = 1;


            for (double i = 1; i <= 3; i++)

            {

                double s1 = f1 + d1;

                double s2 = f2 + d2;

                f1 = d1;

                f2 = d2;

                d1 = s1;

                d2 = s2;

                Console.WriteLine(s1 / s2);

            }

        }
        #endregion


    }
}


