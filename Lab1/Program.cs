using System;
namespace project
{
    class project
    {
        static void Main()
        {

            double o = 1;
            double a = 0.1;
            double h = 0.1;
            for (double x = a; x <= o; x += h)
            {
                double k = x * x * x;
                double s = 0;
                int i = 1;
                while (Math.Abs(((2 * (i % 2)) - 1) * (k / (4 * i * i - 1))) >= 0.0001)
                {
                    s += (2 * (i % 2) - 1) * (k / (4 * i * i - 1));
                    k *= x * x;
                    i += 1;
                }
                double y = (1 + x * x) * Math.Atan(x) / 2 - x / 2;
                Console.WriteLine($"{s} {y}");
            }
        }


    }
}
