using System;
using System.Data;

namespace project
{
    class Project
    {
        static void Main()
        {
            #region 1_1
            //double r = 2;
            //Console.WriteLine("Введите X:");
            //double x = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Введитк Y:");
            //double y = Convert.ToInt16(Console.ReadLine());
            //if (x * x + y * y == r * r)
            //{
            //    Console.WriteLine("Лежит");
            //}
            //else
            //{
            //    Console.WriteLine("Не лежит");
            //}
            #endregion

            #region 1_3
            //Console.WriteLine("Введите значение а: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите значение b: ");
            //double b = Convert.ToDouble(Console.ReadLine());

            //if (a > 0)
            //{
            //    double c = Math.Max(a, b);
            //    Console.WriteLine(c);
            //}
            //if (a <= 0)
            //{
            //    double c = Math.Min(a, b);
            //    Console.WriteLine(c);
            //}
            #endregion

            #region 1_6
            //Console.WriteLine("Радиус круга r: ");
            //double r = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Площадь квадрата s: ");
            //double s_kvadrat = Convert.ToDouble(Console.ReadLine());
            //double s_kruga = 3.14 * r * r;
            //if (s_kruga > s_kvadrat)
            //{
            //    Console.WriteLine("Помещаеться");
            //}
            //else
            //{
            //    Console.WriteLine("НЕ помещаеться");
            //}
            #endregion

            #region 1_9
            //Console.WriteLine("Введите х: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //if (x <= -1)
            //{
            //    double y = 0;
            //    Console.WriteLine("у =");
            //    Console.WriteLine(y);
            //}
            //if (-1 < x && x <= 0)
            //{
            //    double y = 1 + x;
            //    Console.WriteLine("у =");
            //    Console.WriteLine(y);
            //}
            //if (x > 0)
            //{
            //    double y = 1;
            //    Console.WriteLine("у =");
            //    Console.WriteLine(y
            #endregion

            #region 2_3
            //Console.WriteLine("Введите колличество учеников в калссе : ");
            //int n = Convert.ToInt16(Console.ReadLine());
            //double sum_moloka = 0;
            //double sr_snach = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Введите ваш весс:");
            //    int ves = Convert.ToInt16(Console.ReadLine());
            //    if (ves < 30)
            //    {
            //        sum_moloka += 200;
            //        Console.WriteLine("Количесво доп молока на класс равно = ");
            //        Console.WriteLine(sum_moloka);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Доп молоко не нужно");
            //    }
            #endregion

            #region 2_6
            //Console.WriteLine("Введите количество точек:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;

            //Console.WriteLine("Введите значение P:");
            //double P = Convert.ToDouble(Console.ReadLine());// ЧИСЛО П

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Введите координаты точки {i + 1} (x y):");
            //    string[] input = Console.ReadLine().Split(' ');// ПРОСТО РАЗДЕЛЯЕМ ЧЕРЕЗ ПРОБЕЛ 
            //    double x = Convert.ToDouble(input[0]);
            //    double y = Convert.ToDouble(input[1]);

            //    if (x >= 0 && x <= P && y >= 0 && y <= Math.Sin(x))
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine($"Количество точек, принадлежащих фигуре: {count}");

            #endregion

            #region 2_9
            //Console.WriteLine("Введите количество спортсменов:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n <= 0)
            //{
            //    Console.WriteLine("Некорректное количество спортсменов.");
            //    return;
            //}

            //Console.WriteLine("Введите результаты спортсменов (через пробел):");
            //string[] results = Console.ReadLine().Split(' ');

            //if (results.Length != n)
            //{
            //    Console.WriteLine("Количество введенных результатов не соответствует количеству спортсменов.");
            //    return;
            //}

            //double bestResult = double.MaxValue;

            //foreach (string result in results)
            //{
            //    double time = Convert.ToDouble(result);
            //    if (time < bestResult)
            //    {
            //        bestResult = time;
            //    }
            //}

            //Console.WriteLine($"Лучший результат: {bestResult} секунд");


            #endregion

        }
    }
}