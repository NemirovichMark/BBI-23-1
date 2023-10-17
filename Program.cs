using System;
namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Task3.5
            Console.WriteLine($"x                  y");
            double a = Math.PI / 5;
            double b = Math.PI;
            double h = Math.PI / 25;
            for (double x = a; x <= b; x += h)
            {
                int i = 1;
                double s = 0;
                double t = -1;
                while (Math.Abs(Math.Cos(i * x) / (i * i)) >= 0.0001)
                {
                    s += t * (Math.Cos(i * x)) / (i * i);
                    t = t * (-1);
                    i++;
                }
                double y = (x * x - (Math.PI * Math.PI / 3)) / 4;
                Console.WriteLine($"{s} {y}");
                #endregion
            }
        }
    }
}
