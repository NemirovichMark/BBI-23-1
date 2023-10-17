using System;


class Program
{
    public static int Factoria(int fact)
    {
        if (fact == 0 || fact == 1) return 1;
        return fact * Factoria(fact - 1);
    }
    public static void Main(string[] args)
    {
        
        int i = 0;
        double y = 0;

        for (double x = 0.1; x <= 1; x = x + 0.05)
        {
            i = 0;
            double s = 0;
            double tr = 0;
            do
            {
                tr = (Math.Pow(x, (2 * i)) / Factoria(2 * i));
                if (Math.Abs(tr) < 0.0001) break;
                s = s + tr;
                i++;
            }
            while (Math.Abs(tr) >= 0.0001);
            Console.WriteLine(s);
            y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
            Console.WriteLine("Y равен" + y);
        }
    }
}
