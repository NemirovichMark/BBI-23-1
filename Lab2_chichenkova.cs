using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* #region Task1.3
             double a, b, c;
             Console.WriteLine("Введите a:");
             a = double.Parse(Console.ReadLine());
             Console.WriteLine("Введите b:");
             b = double.Parse(Console.ReadLine());
             if (a > 0)
             {
                 c = Math.Max(a, b);
             }
             else
             {
                 c = Math.Min(a, b);
             }
             Console.WriteLine(c);
             #endregion */

            /* #region Task1.6.a
             double r, s;
             r = 3.2;
             s = 3.5;
             if (2 * Math.Sqrt(r / Math.PI) < Math.Sqrt(s))
             {
                 Console.WriteLine("Поместится");
             }
             else
             {
                 Console.WriteLine("Не поместится");
             }
             #endregion */

            /*  #region Task1.6.b
              double r, s;
              r = 3.2;
              s = 4;
              if (2 * Math.Sqrt(r / Math.PI) < Math.Sqrt(s))
              {
                  Console.WriteLine("Поместится");
              }
              else
              {
                  Console.WriteLine("Не поместится");
              }
              #endregion */

            /* #region Task.1.6.c
             double r, s;
             r = 6;
             s = 9;
             if (2 * Math.Sqrt(r / Math.PI) < Math.Sqrt(s))
             {
                 Console.WriteLine("Поместится");
             }
             else
             {
                 Console.WriteLine("Не поместится");
             }
             #endregion */

            /* #region Task1.9
             double y = 0;
             Console.WriteLine("Введите x,чтобы посчитать y:");
             double x = double.Parse(Console.ReadLine());
             if (x <= -1)
             {
                 y = 0;
             }
             else if (x > -1 & x <= 0)
             {
                 y = 1 + x;
             }
             else if (x > 0)
             {
                 y = 1;
             }
             Console.WriteLine("Значение функции:");
             Console.WriteLine(y);
             #endregion */

            /* #region Task2.3
              Console.WriteLine("Введите число учеников:");
              int n = int.Parse(Console.ReadLine());
              double m = 0;
              double v;
              Console.WriteLine("Введите веc учеников:");
              for (int i = 0; i < n; i++)
              {
                v = double.Parse(Console.ReadLine());
                if (v < 30)
                {
                    m = m + 0.2;
                }
              }
              Console.WriteLine("Кол-во литров:");
              Console.WriteLine(m);
           #endregion */

            /*  #region Task2.6
              double x, y;
              int k = 0;
              Console.WriteLine("Введите количество координат");
              int n = int.Parse(Console.ReadLine());
              Console.WriteLine("Введите координаты x и y");
              for (int i = 1; i <= n; i++)
              {
                  x = double.Parse(Console.ReadLine());
                  y = double.Parse(Console.ReadLine());
                  if ((y >= 0) && (y <= Math.Sin(x)) && (x >= 0) && (x <= Math.PI))
                  {
                      k = k + 1;
                  }    
              }
              Console.WriteLine(k);
              #endregion */

          /*  #region Task2.9 
            Console.WriteLine("Введите кол-во участников:");
            int n;
            n = int.Parse(Console.ReadLine());
            double best = 0;
            for (double i = 0; i < n; i++)
            {
                double r;
                r = double.Parse(Console.ReadLine());
                if (i == 1) best = r;
                else
                {
                    if (r <= best) best = r;
                }
            }
            Console.WriteLine("Лучший результат:");
            Console.WriteLine(best);
            #endregion */
        }
    }
}