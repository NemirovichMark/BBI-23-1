using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        //номер в списке 14
        #region 1-3
        Console.WriteLine("1-3");
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
        Console.WriteLine("Ответ:");
        Console.WriteLine(c);
        Console.WriteLine();
        #endregion

        #region 1-6
        Console.WriteLine("1-6");
        double pi = Math.PI;
        double r, s;
        //1
        r = 3.2;
        s = 3.5;
        Console.WriteLine("Ответы:");
        Console.WriteLine("3.1");
        if (Math.Sqrt(s) / 2 >= Math.Sqrt(r / pi))
        {
            Console.WriteLine("Можно");
        }
        else
        {
            Console.WriteLine("Нелья");
        }
        r = 3.2;
        s = 4;
        Console.WriteLine("3.2");
        if (Math.Sqrt(s) / 2 >= Math.Sqrt(r / pi))
        {
            Console.WriteLine("Можно");
        }
        else
        {
            Console.WriteLine("Нелья");
        }
        r = 6;
        s = 9;
        Console.WriteLine("3.3");
        if (Math.Sqrt(s) / 2 >= Math.Sqrt(r / pi))
        {
            Console.WriteLine("Можно");
        }
        else
        {
            Console.WriteLine("Нелья");
        }
        Console.WriteLine();
        #endregion

        #region 1-9
        Console.WriteLine("1-9");
        double y = 0;
        Console.WriteLine("Введите x,чтобы посчитать y:");
        double x = double.Parse(Console.ReadLine());
        if (x <= -1)
        {
            y = 0;
        }
        if (x > -1 && x <= 0)
        {
            y = x + 1;
        }
        if (x > 0)
        {
            y = 1;
        }
        Console.WriteLine("Значение функции:");
        Console.WriteLine(y);
        Console.WriteLine();
        #endregion

        #region 2-3
        Console.WriteLine("2-3");
        Console.WriteLine("Введите число учеников:");
        double n = double.Parse(Console.ReadLine());
        double w;
        double temp = 0;
        Console.WriteLine("Введите веc учеников:");
        for (double i = 0; i < n; i++)
        {
            w = double.Parse(Console.ReadLine());
            if (w < 30)
            {
                temp += 1;
            }
        }
        temp *= 0.2;
        temp = Math.Round(temp, 1);
        Console.WriteLine("Кол-во литров:");
        Console.WriteLine(temp);
        Console.WriteLine();
        #endregion

        #region 2-6
        Console.WriteLine("2-6");
        double X, Y = 0;
        temp = 0;
        Console.WriteLine("Введите кол-во координат");
        n = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты x и y");
        for (double i = 0; i < n; i++)
        {
            X = double.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());
            if (X >= 0 && X <= pi && Y <= Math.Sin(X))
            {
                temp += 1;
            }
        }
        Console.WriteLine("Кол-во координат,которые входят:");
        Console.WriteLine(temp);
        Console.WriteLine();
        #endregion

        #region 2-9
        {
            Console.WriteLine("2-9");
            Console.WriteLine("Введите кол-во участников:");
            n = double.Parse(Console.ReadLine());
            double max = -1000000;
            temp = 0;
            Console.WriteLine("Введите результаты участников:");
            for (double i = 0; i < n; i++)
            {
                temp = double.Parse(Console.ReadLine());
                max = Math.Max(max, temp); 
            }
            Console.WriteLine("Лучший результат:");
            Console.WriteLine(max);
            #endregion

        }
    }
}

