using System;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            #region 1_3
            double a, b, c;
            Console.WriteLine("Введите a и b для задания 1_3");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = a;
            if (a > 0)
            {
                if (a < b) c = b;
            }
            else
            {
                if (a > b) c = b;
            }
            Console.WriteLine(c);
            #endregion
            #region 1_6
            double r, s;
            Console.WriteLine("Введите r и s для задания 1_6");
            r = double.Parse(Console.ReadLine());
            s = double.Parse(Console.ReadLine());
            bool otv;
            if (2 * Math.Sqrt(r / Math.PI) < Math.Sqrt(s)) otv = true;
            else otv = false;
            Console.WriteLine(otv);
            #endregion
            #region 1_9
            double x, y;
            Console.WriteLine("Введите значение x для задания 1_9");
            x = double.Parse(Console.ReadLine());
            if (x <= -1) y = 0;
            else if (x <= 0) y = 1 + x;
            else y = 1;
            Console.WriteLine("x={0}, y={1}", x, y);
            #endregion
            #region 2_3
            int n;
            Console.WriteLine("Введите количество учеников для задания 2_3");
            n = int.Parse(Console.ReadLine());
            double m = 0;
            for (int i = 1; i <= n; i++)
            {
                double ves = double.Parse(Console.ReadLine());
                if (ves < 30) m += 0.2;
            }
            Console.WriteLine(m);
            #endregion
            #region 2_6
            Console.WriteLine("Введите количество точек для задания 2_6");
            n = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                if ((y1 >= 0) && (y1 <= Math.Sin(x1)) && (x1 >= 0) && (x1 <= Math.PI)) k += 1;
            }
            Console.WriteLine(k);
            #endregion
            #region 2_9
            Console.WriteLine("Введите количество участников для задания 2_9");
            n = int.Parse(Console.ReadLine());
            double best = 0;
            for (int i = 1; i <= n; i++)
            {
                double res;
                res = double.Parse(Console.ReadLine());
                if (i == 1) best = res;
                else
                {
                    if (res <= best) best = res;
                }
            }
            Console.WriteLine(best);
            #endregion
        }
    }
}