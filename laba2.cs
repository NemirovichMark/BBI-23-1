using System;

internal class Program
{
    private static void Main(string[] args)
    {
        #region 1_2
        Console.Write("Введите координты x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координты y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        if (x < 0)
            if ((1 - x >= 0) & (y + Math.Abs(x) <= 1))
            {
                Console.WriteLine("Является");
            }
            else
            {
                Console.WriteLine("Не является");
            }
        #endregion

        #region 1_5
        Console.Write("Введите площадь круга: ");
        double r = double.Parse(Console.ReadLine());
        Console.Write("Введите площадь квадрата: ");
        double s = double.Parse(Console.ReadLine());
        double storona = Math.Sqrt(s);
        double radius = Math.Sqrt(r / Math.PI);
        if (radius >= storona * Math.Sqrt(2))
            Console.WriteLine("поместиться");
        else Console.WriteLine("не поместиться");
        #endregion

        #region 1_8
        Console.Write("Введите значение x: ");
        double _ = double.Parse(Console.ReadLine());
        if (x > 1 || x < -1)
        {
            Console.WriteLine("y = 0");
        }
        else
            Console.WriteLine("y = {0}", x * x - 1);
        #endregion

        #region 2_2
        int n = 3;
        double j = 0;
        double b = 0;
        r = 5;
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            if (Math.Sqrt(Math.Pow(x - j, 2) + Math.Pow(Y - b, 2)) <= r)
            {
                k += 1;
            }
        }
        Console.WriteLine("2_2: " + k);
        Console.WriteLine();
        #endregion

        #region 2_5
        Console.Write("Введите норматив: ");
        double result = double.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите результат спортсмена №{0}: ", i + 1);
            x = double.Parse(Console.ReadLine());
            int count = 0;
            if (x >= result)
                count += 1;
        }
        Console.WriteLine("Спортсменов выполнивших норматив: {0}");
        #endregion

        #region 2_8
        n = 3;
        r = Math.Pow(9, 100);
        int t = 0;
        int k1 = 0;
        for (int d = 0; d < n; d++)
        {
            Console.WriteLine("Введите x: ");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            d += 1;
            if (Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)) <= r)
            {
                r = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
                k1 = d;
            }
        }
        Console.WriteLine("2_8: " + k1 + " " + r);
        Console.WriteLine();
        #endregion
    }
}


