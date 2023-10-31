using System;
using System.Runtime.InteropServices;

namespace project
{
    class Project
    {
        static void Main()
        {
            #region 1_1
            Console.WriteLine("1_1:");
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double r = 2;
            if (x * x + y * y == r * r)
            {
                Console.WriteLine("Ответ:");
                Console.WriteLine("Точка лежит на окружности");
            }
            else
            {
                Console.WriteLine("Ответ:");
                Console.WriteLine("Точка не лежит на окружности");
            }
            Console.WriteLine();
            #endregion

            #region 1_4
            Console.WriteLine("1_4:");
            Console.WriteLine("Введите a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c:");
            double c = Convert.ToDouble(Console.ReadLine());
            double z = Math.Max(Math.Min(a, b), c);
            Console.WriteLine("Ответ:");
            Console.WriteLine(z);
            Console.WriteLine();
            #endregion

            #region 1_7
            Console.WriteLine("1_7:");
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(x) > 1)
            {
                y = 1;
            }
            if (Math.Abs(x) <= 1)
            {
                y = Math.Abs(x);
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(y);
            Console.WriteLine();
            #endregion

            #region 2_1
            Console.WriteLine("2_1:");
            Console.WriteLine("Введите n:");
            double n = Convert.ToDouble(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите рост ученика:");
                r = Convert.ToDouble(Console.ReadLine());
                s += r;
            }
            s /= n;
            Console.WriteLine("Средний рост учеников:");
            Console.WriteLine(s);
            Console.WriteLine();
            #endregion

            #region 2_4
            Console.WriteLine("2_4:");
            s = 0;
            Console.WriteLine("Введите r1:");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите r2:");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите n:");
            n = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите x:");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                y = Convert.ToDouble(Console.ReadLine());
                if ((x * x + y * y < r1 * r1) & (x * x + y * y > r2 * r2))
                {
                    s++;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(s);
            Console.WriteLine();
            #endregion

            #region 2_7
            Console.WriteLine("2_7:");
            double s1 = 0;
            double s2 = 0;
            Console.WriteLine("Введите n:");
            n = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите x:");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 & y > 0)
                {
                    Console.WriteLine("Точка лежит в 1 четверти");
                    s1++;
                }
                if (x < 0 & y > 0)
                {

                    Console.WriteLine("Точка лежит в 2 четверти");
                }
                if (x < 0 & y < 0)
                {
                    Console.WriteLine("Точка лежит в 3 четверти");
                    s2++;
                }
                if (x > 0 & y < 0)
                {
                    Console.WriteLine("Точка лежит в 4 четверти");
                }
            }
            Console.WriteLine("2_7:\nКол-во точек в 1 четверти:{0}, Кол-во точек в 3 четверти: {1}", s1, s2);
            #endregion
        }
    }
}
