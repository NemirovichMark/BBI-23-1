using System;
class Program
{
    static void Main(string[] args)
    {
        double s = 0;
        double y = 0;
        double b = 1;
        double a = 0.1;
        double h = 0.05;
        for (double x = a; x <= b; x += h)
        {
            s = 0;
            int i = 1;
            i = i * i;
            while ((Math.Pow(2 * x, i) / i >= 0.0001))
            {
                s += (Math.Pow(2 * x, i) / i);
                i += 1;
            }
            y = Math.Pow(Math.E, 2 * x);
            Console.WriteLine();
            Console.WriteLine($"{s}\t{y}");
        }
    }
}