using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.1
            //int s = 0;
            //for (int i = 2; i <= 35; i = i + 3)
            //{
            //    s = s + i;
            //}
            //{
            //    Console.WriteLine("1.1:\n{0}", s);
            //}
            #endregion
            //
            #region 1.2 
            //s = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    s += 1 / i;
            //}
            //{
            //    Console.WriteLine("1.2:\n{0}", s);
            //}
            #endregion
            //
            #region 1.3
            //double s = 0;
            //for (double i = 2; i <= 112; i += 2)
            //{
            //    s = s + i / (i + 1);
            //}
                
            //Console.WriteLine("1.3:\n{0}", s);
            
            #endregion
            //
            #region 1.4 
            //double sum = 0;
            //double x = 0.2;
            //for (double i = 1; i <= 9; i = i + 1)
            //{
            //    sum = sum + Math.Cos(i + x) / Math.Pow(x, (i - 1));
            //}
            //Console.WriteLine("1.4:\n{0}", sum);
            #endregion
            //
            #region 1.5
            //sum = 0;
            //double p = 2;
            //double h = 1.5;
            //for (double i = 1; i <= 9; i++)
            //{
            //    sum = sum + Math.Pow((p + i * h), 2);
            //}
            //Console.WriteLine("1.5:\n{0}", sum);
            #endregion
            //
            #region 1.6
            //Console.WriteLine("1.6:");
            //Console.WriteLine("x             y");
            //double y = 0;
            //for (x = -4; x <= 4; x = x + 0.5)
            //{
            //    y = 0.5 * Math.Pow(x, 2) - 7 * x;
            //    Console.WriteLine($"{x}          {y}");
            //}
            //Console.WriteLine();
            #endregion
            //
            #region 1.7
            ////Вычислить значение факториала числа 6 (6! = 1*2*3*...*6)
            //int factorial = 1;

            //for (int i = 1; i <= 6; i++)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine("1.7: \n" + "Значение факториала 6 = " + factorial);
            #endregion
            //
            #region 1.8
            ////Вычислить s = 1! + 2! + ... + 6!

            //int sum_ = 0, fctrl = 1;

            //for (int i = 1; i <= 6; i++)
            //{
            //    fctrl *= i;
            //    sum_ += fctrl;
            //}

            //Console.WriteLine("1.8: \n" + "Сумма ряда значений факториалов до 6 = " + sum_);
            #endregion
            //
            #region 1.9
            //double sum1 = 0;
            //int factr = 1;
            //double mnozh = 0;

            //for (int i = 1; i <= 6; i++)
            //{
            //    factr *= i;
            //    mnozh = Math.Pow((-1), i) * Math.Pow(5, i) / factr;
            //    sum1 += mnozh;
            //}

            //Console.WriteLine("1.9 \n" + "Ответ: " + sum1);
            #endregion
            //
            #region 1.10
            ////  Возвести число 3 в 7-ю степень, не используя операцию возведения в степень
            //int zxc = 1;

            //for (int i = 1; i <= 7; i++)
            //{
            //    zxc *= 3;
            //}

            //Console.WriteLine("1.10: \n" + "Ответ: " + zxc);
            #endregion
            //
            #region 1.11
            ////Console.WriteLine(" 1.11: \n" + "a: 1 2 3 4 5 6 " + "\nb: 5 5 5 5 5 5");
            //Console.WriteLine("1.11:");
            //for (int i = 1; i <= 6; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();

            //for (int i = 1;i <= 6; i++)
            //{
            //    Console.Write("5 ");
            //}
            #endregion
            //
            #region 1.12
            //Console.WriteLine("Enter x value:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //double s = 1;
            //for(int i = 1; i <= 10; i++)
            //{
            //    s = s + 1 / Math.Pow(x, i);
            //}
            //Console.WriteLine("Answer: " + s);
            #endregion
            //
            #region 1.13

            //for (double otr = -1.5; otr <= 1.5; otr += 0.1)
            //{
            //    if (otr <= -1)
            //    {
            //        Console.WriteLine("1.13: " + 1);
            //    }
            //    if ((-1 < otr) & (otr <= 1))
            //    {
            //        Console.WriteLine("1.13: " + Math.Round(-otr, 2));
            //    }
            //    if (otr > 1)
            //    {
            //        Console.WriteLine("1.13: " + -1);
            //    }
            //}

            #endregion
            //
            #region 1.14

            //Console.WriteLine("1.14:");

            //int fibonacci = 1;
            //int fibonacciPrev;
            //int fibonacciPrevPrev = 0;

            //for(int i = 1; i <= 8; i++)
            //{
            //    Console.Write(fibonacci + " ");
            //    fibonacciPrev = fibonacciPrevPrev;
            //    fibonacciPrevPrev = fibonacci;
            //    fibonacci = fibonacciPrev + fibonacciPrevPrev;
            //}
            #endregion
            //
            #region 1.15

            //Console.WriteLine("\n1.15:");

            //int numerator = 1;
            //int numeratorPrev = 2;
            //int numeratorPPrev = 0;
            //int denominator = 1;
            //int denominatorPrev = 1;
            //int denominatorPPrev = 0;

            //for (int i = 1; i <=3; i++)
            //{
            //    numeratorPPrev = numerator + numeratorPrev;
            //    numerator = numeratorPrev;
            //    numeratorPrev = numeratorPPrev;
            //    denominatorPPrev = denominator + denominatorPrev;
            //    denominator = denominatorPrev;
            //    denominatorPrev = denominatorPPrev;
            //}
            //Console.WriteLine("The fifth sequence member is: " + numeratorPPrev + "/" + denominatorPPrev) ;
            #endregion
            //
            #region 2.1

            //Console.WriteLine("2.1:");

            //double sum = 0;
            //double kon = 0.0001;
            //double n = 1;
            //double step = 1;

            //while (Math.Abs(Math.Cos(step * n) / n * n) >= kon)
            //{
            //    sum += Math.Cos(step * n) / n * n;
            //    n += 1;
            //}

            //Console.WriteLine("Answer: " + sum);

            #endregion
            //
            #region 2.2

            Console.WriteLine("2.2:");

            //double p = 1;
            //double somn = 1;
            //int L = 30000;

            //while (p < L)
            //{
            //    somn += 3;
            //    p *= somn;
            //}

            //Console.WriteLine("Answer: " + somn);

            #endregion
            //
            #region 2.3

            //Console.WriteLine("2.3:");

            //Console.WriteLine("Enter p's value:");
            //int p = Convert.ToInt32(Console.ReadLine());

            //int n = 0;

            //double sum = 0;

            //Console.WriteLine("Enter a's value:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter h's value:");
            //int h = Convert.ToInt32(Console.ReadLine());

            //while (sum <= p)
            //{
            //    sum += (a + n * h);
            //    n += 1;
            //}

            //Console.WriteLine("Answer: " + (n - 1));

            #endregion
            //
            #region 2.4

            //Console.WriteLine("2.4:");

            //double eps = 0.0001;
            //int n = 0;
            //double x = 0.9;
            //double sumx = x;
            //double sum = 1;
            //do
            //{
            //    n += 1;
            //    x = 0.9;
            //    for (int pow = 1; pow < 2 * n; pow++)
            //    {
            //        x = x * sumx;
            //    }
            //    sum += x;

            //} while (x >= eps);
            //Console.WriteLine("Answer: " + sum);

            #endregion
            //
            #region 2.5

            //Console.WriteLine("2.5:");

            //Console.WriteLine("Enter M:");
            //int M = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter N:");
            //int N = Convert.ToInt32(Console.ReadLine());

            //double quotient = 0;
            //double remainder = 0;

            //while (N - M >= 0)
            //{
            //    quotient += 1;
            //    N = N - M;
            //}
            //remainder = N;

            //Console.WriteLine("Answer: " + "quotient: " + quotient + " remainder: " + remainder);

            #endregion
            //
            #region 2.7a

            //double km = 10;
            //double plusKDnevNorm = 10;
            //double S = 10;

            //for (int i = 2; i <= 7; i++)
            //{
            //    S = S + km * (1 + plusKDnevNorm / 100);
            //    km = km * (1 + plusKDnevNorm / 100);
            //}
            //Console.WriteLine("2.7a:\nAnswer: " + S);

            #endregion
            //
            #region 2.7b

            //double km = 10;
            //double plusKDnevNorm = 10;
            //double S = 10;
            //int nDays = 0;

            //while (S < 100)
            //{
            //    S = S + km * (1 + plusKDnevNorm / 100);
            //    km = km * (1 + plusKDnevNorm / 100);
            //    nDays += 1;
            //}
            //Console.WriteLine("2.7b:\nAnswer: " + nDays + " days");

            #endregion
            //
            #region 2.7c

            //double km = 10;
            //double plusKDnevNorm = 10;
            //double S = 10;

            //int nDays = 0;
            //while (km <= 20)
            //{
            //    km = km * (1 + plusKDnevNorm / 100);
            //    nDays += 1;
            //}
            //Console.WriteLine("2.7c:\nAnswer: " + nDays + " days");

            #endregion
            //
            #region 2.8

            //double vklad = 10000;
            //double proc = 0.08;
            //double dobav = 0;
            //double nMonth = 1;

            //while (vklad < 20000)
            //{
            //    dobav = vklad * proc;
            //    vklad += dobav;
            //    nMonth += 1;
            //}

            //Console.WriteLine("2.8:\nAnswer: " + nMonth);

            #endregion
            //
            #region 3.9

            //double a = 0.1;
            //double b = 0.5;
            //double h = 0.05;
            //for (double x = a; x <= b; x += h)
            //{
            //    int i = 0;
            //    double s = 0;
            //    double k = x;
            //    double t = 1;
            //    while (Math.Abs(k / (2 * i + 1)) >= 0.0001)
            //    {
            //        s += t * (k / (2 * i + 1));
            //        t *= -1;
            //        i++;
            //        k *= x * x;
            //    }
            //    double y = Math.Atan(x);
            //    Console.WriteLine(s + y);
            //}

            #endregion

            Console.ReadKey();
        }
    }
}
