﻿using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main(string[] args)
    { /*
// в списке номер 1
#region 1-1
double r = 2;
double x = 0;
double y = 0;
for (int i = 1; i <= 4; i++)
{
Console.WriteLine("Введите x:");

        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y:");

        y = Convert.ToDouble(Console.ReadLine());
        if ((x * x + y * y - r * r) <= 0.001)
        {
            Console.WriteLine("лежит");
        }
        else Console.WriteLine("не лежит");

    }
    #endregion
    #region 1-4
    {
        Console.WriteLine("1-4");
        double a, b, c, z;
        Console.WriteLine("a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("c:");
        c = double.Parse(Console.ReadLine());

        {
            z = Math.Max(Math.Min(a, b), c);
        }
        Console.WriteLine("Ответ");
        Console.WriteLine(z);
    }
    #endregion

    #region 1-7
    {
        Console.WriteLine("1-7");
        double f, g;
        Console.WriteLine("x:");
        f = double.Parse(Console.ReadLine());
        if (Math.Abs(f) > 1)
        {
            g = 1;
        }
        else
        {
            g = (Math.Abs(f));
        }

        Console.WriteLine("Ответ");
        Console.WriteLine(g);
    }


    #endregion

    #region 2-1

    Console.WriteLine("2-1");
    Console.WriteLine("Введите кол-во девочек:");
    double l = Convert.ToDouble(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= l; i++)
    {
        Console.WriteLine("Введите рост девочки:");
        r = Convert.ToDouble(Console.ReadLine());
        s += r;
    }
    s /= l;
    Console.WriteLine("Введите кол-во мальчиков:");
    double e = Convert.ToDouble(Console.ReadLine());
    double q = 0;
    for (int w = 1; w <= e; w++)
    {
        Console.WriteLine("Введите рост мальчика:");
        r = Convert.ToDouble(Console.ReadLine());
        q += r;
    }
    q /= e;
    Console.WriteLine("Средний рост девочек:");
    Console.WriteLine(s);
    Console.WriteLine("Средний рост мальчиков:");
    Console.WriteLine(q);
    Console.WriteLine();
    #endregion

    #region 2-4
    {
        Console.WriteLine("2-4");
        double r1, r2;
        Console.WriteLine("r1:");
        r1 = double.Parse(Console.ReadLine());
        Console.WriteLine("r2:");
        r2 = double.Parse(Console.ReadLine());
        if (r1 > r2)
        {
            Console.WriteLine("Нет решения");
        }
        else
        {
            double a = 0;
            double b = 0;
            double c = 0;
            Console.WriteLine("Введите n:");
            c = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= c ; i++)
            {   
                Console.WriteLine("Введите x:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                b = Convert.ToDouble(Console.ReadLine());
                if ((a * a + b * b) < r2 * r2)
                {
                    if ((a * a + b * b) > r1 * r1)
                    {

                        Console.WriteLine("лежит");

                    }
                    else
                    {
                        Console.WriteLine("не лежит");
                    }
                }
                else
                {
                    Console.WriteLine("не лежит");
                }
            }
        }
    }
    #endregion
    */
        #region 2-7
        {
            Console.WriteLine("2-7");

            double a = 0;
            double k = 0;
            double z = 0;
            double b = 0;
            double c = 0;
            Console.WriteLine("Введите n:");
            c = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= c; i++)
            {

                Console.WriteLine("Введите x:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                b = Convert.ToDouble(Console.ReadLine());
                if (b >= 0)
                {
                    if (a >= 0)
                    {

                        Console.WriteLine("1");
                        z = z + 1;
                    }
                    else
                    {
                        Console.WriteLine("2");

                    }
                }
                else
                {
                    if (a >= 0)
                    {

                        Console.WriteLine("4");

                    }
                    else
                    {
                        Console.WriteLine("3");
                        k = k + 1;
                    }
                }

            }
            Console.WriteLine("Кол-во 1:");
            Console.WriteLine(z);
            Console.WriteLine("Кол-во 3:");
            Console.WriteLine(k);
        }
        #endregion
    }
}