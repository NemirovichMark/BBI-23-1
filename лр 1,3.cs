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
        double z = 1;
        for (double x = a; x <= b; x += h)
        {
            s = 0;
            i = 0;
            z = 1;
            double k = z * MyPow(x, 2 * i) / Fact(2 * i);
            while (Math.Abs(k) >= 0.0001)
            {
                k = z * MyPow(x, 2 * i) / Fact(2 * i);
                s += k;
                i += 1;
                z = -z;
            }
            double y = Math.Cos(x);
            Console.WriteLine($"{s} {y}");
        }

    }
}

double MyPow(double x, int v)
{
    throw new NotImplementedException();
}