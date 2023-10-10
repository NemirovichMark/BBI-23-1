using System;
namespace project
{
    class Project
    {
        static void Main()
        {
            //я по списку 19 => 19%3+1=1+1=2
            #region 1_2
            int x = 1; 
            int y = 1;
            if ((y + Math.Abs(x) <= 1) & (y >= 0))
            {
                Console.WriteLine("1_2: Является");
            }
            else
            {
                Console.WriteLine("1_2: Не является");
            }
            #endregion  
            Console.WriteLine();

            #region 1_5_1
            double r = 70; 
            double s = 36.74;
            if (2 * Math.Sqrt(r/Math.PI) >= Math.Sqrt(2)*Math.Sqrt(s))
            {
                Console.WriteLine("1_5_1: Поместится");
            }
            else
            {
                Console.WriteLine("1_5_1: Не поместится");
            }
            #endregion

            #region 1_5_2
            r = 0.86;
            s = 0.74;
            if (2 * Math.Sqrt(r / Math.PI) >= Math.Sqrt(2) * Math.Sqrt(s))
            {
                Console.WriteLine("1_5_2: Поместится");
            }
            else
            {
                Console.WriteLine("1_5_2: Не поместится");
            }
            #endregion  
            Console.WriteLine();

            #region 1_8
            double X = -0.5;
            if (Math.Abs(X)>1)
            {
                Console.WriteLine("1_8: " + 1);
            }
            else
            {
                Console.WriteLine("1_8: " + Math.Abs(X));
            }
            #endregion  
            Console.WriteLine();

            #region 2_2
            int n = 3;
            double a = 0;
            double b = 0;
            r = 5;
            int k = 0;
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Введите x: ");
                X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                double Y = Convert.ToDouble(Console.ReadLine());
                if (Math.Sqrt( Math.Pow(X-a, 2) + Math.Pow(Y-b, 2) ) <= r)
                {
                    k += 1;
                }
            }
            Console.WriteLine("2_2: " + k);
            #endregion  
            Console.WriteLine();

            #region 2_5
            n = 30;
            r = 5;
            k = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите результат участника: ");
                X = Convert.ToDouble(Console.ReadLine());
                if (X <= r)
                {
                    k += 1;
                }
            }
            Console.WriteLine("2_5: " + k);
            #endregion  
            Console.WriteLine();

            #region 2_8
            n = 3;
            r = Math.Pow(9, 100);
            k = 0;
            int k1 = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите x: ");
                X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                double Y = Convert.ToDouble(Console.ReadLine());
                k += 1;
                if (Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)) <= r)
                {
                    r = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
                    k1 = k;
                }
            }
            Console.WriteLine("2_8: " + k + " " + r);
            #endregion  
            Console.WriteLine();

        }
    }
}
