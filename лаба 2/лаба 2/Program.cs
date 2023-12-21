using System;
class Program
{
    static void Main()
    {
        #region 1_3
        double a;
        double b;
        double c;
        Console.WriteLine("Введите a и b:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = a;
        if (a > 0)
            if (a < b) c = b;
            else
            {
                if (a > b) c = b;
            }
        Console.WriteLine(c);
        #endregion

        #region 1_6
        double r;
        double s;
        Console.WriteLine("Введите r и s:");
        r = double.Parse(Console.ReadLine());
        s = double.Parse(Console.ReadLine());
        bool otv;
        if (2 * Math.Sqrt(r / Math.PI) < Math.Sqrt(s)) otv = true;
        else otv = false;
        Console.WriteLine(otv);
        #endregion

        #region 1_9
        double x, y;
        Console.WriteLine("Введите значение x:");
        x = double.Parse(Console.ReadLine());
        if (x <= -1) y = 0;
        else if (x <= 0) y = 1 + x;
        else y = 1;
        Console.WriteLine("x={0}, y={1}", x, y);
        #endregion

        #region 2_3
        int n;
        Console.WriteLine("Введите количество учеников:");
        n = int.Parse(Console.ReadLine());
        double M = 0;
        double V = double.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (V < 30) M += 0.2;
        }
        Console.WriteLine(M);
        #endregion

        #region 2_6
        Console.WriteLine("Введите количество точек^");
        n = int.Parse(Console.ReadLine());
        int t = 0;
        for (int i = 1; i <= n; i++)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            if ((y1 >= 0) && (y1 <= Math.Sin(x1)) && (x1 >= 0) && (x1 <= Math.PI)) t += 1;
        }
        Console.WriteLine(t);
        #endregion

        #region 2_9
        Console.WriteLine("Введите количество участников:");
        n = int.Parse(Console.ReadLine());
        double B = 0;
        for (int i = 1; i <= n; i++)
        {
            double R;
            R = double.Parse(Console.ReadLine());
            if (i == 1) B = R;
            else
            {
                if (R <= B) B = R;
            }
        }
        Console.WriteLine(B);
        #endregion
    }
}
