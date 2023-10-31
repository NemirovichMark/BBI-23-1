using System;
namespace project
{
    class Project
    {
        static void Main()
        {
            #region 1_1
            Console.WriteLine("Введите х - координату точки");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите у - координату точки");
            double y = Convert.ToDouble(Console.ReadLine());

            if (y >= 0 && (y + Math.Abs(x)) <= 1)
            {
                Console.WriteLine("Указанная точка принадлежит фигуре");
            }

            else
            {
                Console.WriteLine("Указанная точка не принадлежит фигуре");
            }
            #endregion

            #region 1_5
            Console.WriteLine("Введите площадь круга");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите площадь квадрата");
            double s = Convert.ToDouble(Console.ReadLine());


            double diameter = 2 * Math.Sqrt(r / Math.PI); // диаметр круга

            double diagonal = Math.Sqrt(s * 2); // диагональ квадрата

            if (diameter >= diagonal)
            {
                Console.WriteLine("Квадрат поместится в круге");
            }
            else
            {
                Console.WriteLine("Квадрат не поместится в круге");
            }
            #endregion

            #region 1_8
            Console.WriteLine("1_8:");
             y = 0;
            Console.WriteLine("Введите x:");
             x = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(x) >= 1)
            {
                y = 0;
            }
            if (Math.Abs(x) < 1)
            {
                y = x * x - 1;
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(y);
            Console.WriteLine();
            #endregion

            #region 2_2
            Console.WriteLine("2_2:");
            Console.WriteLine("Введите n:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите r:");
            r = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите x:");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                y = Convert.ToDouble(Console.ReadLine());
                if (x * x + y * y <= r * r)
                {
                    Console.WriteLine("Точка лежит в круге");
                }
                else
                {
                    Console.WriteLine("Точка не лежит в круге");
                }
            }
            Console.WriteLine();
            #endregion

            #region 2_5
            Console.WriteLine("2_5:");
            n = 30;
            int k = 0;
            Console.WriteLine("Введите норматив:");
            s = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите результат участника:");
                x = Convert.ToDouble(Console.ReadLine());
                if (x >= s)
                {
                    k++;
                }
            }
            Console.WriteLine("Ответ:");
            Console.WriteLine(k);
            #endregion

            #region 2_8
            n = 3;
            r = Math.Pow(9, 100);
            k = 0;
            int cou = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите x: ");
                n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                double Y = Convert.ToDouble(Console.ReadLine());
                k += 1;
                if (Math.Sqrt(Math.Pow(n, 2) + Math.Pow(Y, 2)) <= r)
                {
                    r = Math.Sqrt(Math.Pow(n, 2) + Math.Pow(Y, 2));
                    cou = k;
                }
            }
            Console.WriteLine("2_8: " + k + " " + r);
            #endregion
        }
    }
}
