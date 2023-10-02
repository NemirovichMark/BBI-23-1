// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System. Text;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        #region 1-1

        //int s = 0;
        //for (int i = 2; i < 36; i += 1)
        //{
        //    s += i
        //}
        //Console.WriteLine(s);


        #endregion

        #region 1-2
        //double s = 0;
        //for (double i = 1; i < 11; i++)
        //{
        //    s += 1 / i;
        //}
        //Console.WriteLine(s);
        #endregion

        #region 1-3
        //double s = 0:
        //for (double 1 = 2; 1 < 113; i += 2)
        //        {
        //            s + i / (1 + 1);
        //        }
        //Console.WriteLine(s);
        #endregion

        #region 1-4
        //double sum = 0.0;
        //double × = 5.0;
        //for (double i = 1; i < 10; i++)
        //{
        //    sum += Math.Cos(i * x) / Math.Pow(x, i - 1);
        //}
        //Console.WriteLine(sum);
        #endregion

        #region 1-5
        //double p = 20;
        //double h = 23;
        //double s = 0;
        //for (double i = 0; 1 < 10; 1++)
        //{
        //    s += Math.Pow((p + i * h), 2);
        //}
        //Console.WriteLine(s);
        #endregion

        #region 1 - 6
        //double y = 0;
        //double x;
        //for (x = -4; x <= 4; x += 0.5)
        //{
        //    y = 0.5 * Math.Pow(x, 2) - 7 * x;
        //    Console.WriteLine($"{ x},{ y}");

        //}

        #endregion

        #region 1 - 8
        //int n = 6; 
        //int s = 0; 
        //int factorial = 1;

        //for (int i = 1; i <= n; i++)
        //{
        //    factorial *= i; 
        //    s += factorial; 
        //}

        //Console.WriteLine(s);
        #endregion

        #region 1-7
        //int s = 1;
        //for (int i =  1; i <= 6; i++)
        //{
        //    s *= i;
        //}
        //s = s * 6;
        //Console.WriteLine(s);
        #endregion

        #region 1 -9
        //int n = 6;
        //double s = 0.0;

        //for (int i = 1; i <= n; i++)

        //{
        //    n = i * i
        //    s += Math.Pow(-1, i) * Math.Pow(5, i) / fact(i);
        //}


        //static long fact(int n) // функция для нахождения факториала 
        //{
        //    long result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}
        //Console.WriteLine(s);
        #endregion

        #region 1 - 10
        //int a = 3;
        //int step = 7;
        //int otv = 1;
        //for (int i = 0; i < step; i++)
        //{
        //    otv *= a;
        //}
        //Console.WriteLine(otv);
        #endregion

        #region 1 -11
        //for (int i = 1; i <= 6; i++)
        //{
        //    Console.Write(i + " ");
        //}

        //for (int i = 0; i < 6; i++)
        //{
        //    Console.Write("5 ");
        //}
        #endregion

        #region 1- 12
        //int x = 2;
        //double s = 0.0;
        //for (int i = 1; i <= 10; i++)
        //{
        //    s += 1.0 + Math.Pow(x, i);

        //}
        //Console.WriteLine(s);
        #endregion

        #region 1- 14
        //int a = 1; // первый член последовательности
        //int b = 1; // второй член последовательности
        //int next = 0;
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //for (int i = 2; i <= 7; i ++)
        //{
        //    next = (a + b);
        //    Console.WriteLine($"{next}");
        //    a = b;
        //    b = next; 
        //}
        #endregion

        #region 1 -15

        //double a1 = 1;
        //double b1 = 1;
        //double a2 = 2;
        //double b2 = 1;
        //int n = 5;

        //// Вычисление следующих членов
        //for (int i = 3; i <= n; i++)
        //{
        //    double nexta = a1 + a2;
        //    double nextb = b1 + b2;

        //    // Обновление значений для следующей итерации
        //    a1 = a2;
        //    b1 = b2;
        //    a2 = nexta;
        //    b2 = nextb;

        //}
        //double res = a2 / b2;
        //Console.WriteLine(res);
        #endregion 1- 15

        #region 2 - 1
        //double s = 0;
        //double x = 1.0; // любое знач.
        //double epsil = 0.0001;
        //int n = 0;
        //double с = 0;// в эту пременну положим все выражение для удобства 
        //while (Math.Abs(с) >= epsil)
        //{
        //    n++;
        //    с = Math.Cos(n * x) / (n * n);
        //    s += с;
        //}
        //Console.WriteLine(s);

        #endregion


        #region 2 - 2
        //int n = 1;
        //int s = 1;
        //while (s <= 30000)
        //{
        //    n += 3;
        //    s *= n;
        //}
        //Console.WriteLine(n);
        #endregion

        #region 2 - 3
        //int s = 0;
        //Console.WriteLine("Введите число а : ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //int n = 1;
        //Console.WriteLine("Введите число h : ");
        //int h = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите число р :");
        //int p = Convert.ToInt32(Console.ReadLine());
        //while (s <= p)
        //{
        //    s += (a + n * h);
        //    n++;
        //}
        //Console.WriteLine($"Ответ {n}");
        #endregion

        #region 2 - 4
        //double x = 0.5;
        //double chlenposl;
        //double sum = 1.0;
        //double epsilon = 0.0001;
        //int n = 2; // степень
        //do
        //{
        //    n += 2;
        //    chlenposl = Math.Pow(x, n);
        //    sum += chlenposl;
        //}
        //while (Math.Abs(chlenposl) <= epsilon);
        //Console.WriteLine(sum);
        #endregion

        #region 2 - 5
        //int n = 21;
        //int m = 2;
        //int del = 0;
        //while (n >= m)
        //{
        //    del++;
        //    n -= m;
        //}
        //Console.WriteLine(del);
        //Console.WriteLine(n);
        #endregion

        #region 2_7(а)
        //    s = 10;
        //u = 0;
        //k = 0;
        //while (k < 7)
        //{
        //    u += s;
        //    s = s * 1.1;
        //    k += 1;
        //}
        //Console.WriteLine("2_7(а):\n{0}", u);
        //Console.WriteLine();
        #endregion

        #region 2_7(б)
        //s = 10;
        //u = 0;
        //k = 0;
        //while (u < 100)
        //{
        //    u += s;
        //    s *= 1.1;
        //    k++;
        //}
        //Console.WriteLine("2_7(б):\n{0}", k);
        //Console.WriteLine();
        #endregion

        #region 2_7(в)
        //s = 10;
        //k = 1;
        //while (s < 20)
        //{
        //    s *= 1.1;
        //    k++;
        //}
        //Console.WriteLine("2_7(в):\n{0}", k);
        //Console.WriteLine();
        #endregion


        #region 2_8
        //s = 10000;
        //k = 0;
        //while (s <= 20000)
        //{
        //    s *= 1.08;
        //    k++;
        //}
        //Console.WriteLine("2_8:\n{0}", k);
        //Console.WriteLine();
        #endregion

        #region 3_6
        //double o = 1;
        //a = 0.1;
        //h = 0.1;
        //for (x = a; x <= o; x += h)
        //{
        //    s = 0;
        //    int i = 1;
        //    while ((Math.Abs(Math.Pow(-1, i + 1) * (Math.Pow(x, 2 * i + 1) / (4 * Math.Pow(i, 2) - 1)))) >= 0.0001)
        //    {
        //        s += Math.Pow(-1, i + 1) * (Math.Pow(x, 2 * i + 1) / (4 * Math.Pow(i, 2) - 1));
        //        i += 1;
        //    }
        //    y = ((1 + Math.Pow(x, 2)) * Math.Atan(x)) / 2;
        //    Console.WriteLine($"{s} {y}");
        //}
        #endregion



    }
}