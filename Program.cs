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

            for (double x = 0.1; x <= 1; x += 0.1)
            {
                double s = 1;
                int i = 1;
                double f = 1;
                while (Math.Abs(Math.Cos(i * x) / f) >= 0.0001)
                {
                    s += Math.Cos(i * x) / f;
                    i++;
                    f = f * i;
                }
                double y = Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x));
                Console.WriteLine($"{s} {y}");
            }
        }
    }
}


