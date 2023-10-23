public class Program
{
    public static void Main(string[] args)
    {
        //номер в списке: 6
        #region 1_1
        double x = 0;
        double y = 2;
        double r = 2;
        Console.WriteLine("1_1:");
        Console.WriteLine("Координаты (0, 2)");
        if (x * x + y * y == r * r)
        {
            Console.WriteLine("Лежит");
        }
        else
        {
            Console.WriteLine("Не лежит");
        }
        Console.WriteLine();
        #endregion

        #region 1_1(2)
        x = 1.5;
        y = 0.7;
        r = 2;
        Console.WriteLine("1_1(2):");
        Console.WriteLine("Координаты (1.5, 0.7)");
        if (x * x + y * y == r * r)
        {
            Console.WriteLine("Лежит");
        }
        else
        {
            Console.WriteLine("Не лежит");
        }
        Console.WriteLine();
        #endregion

        #region 1_1(3)
        x = 1;
        y = 1;
        r = 2;
        Console.WriteLine("1_1(3):");
        Console.WriteLine("Координаты (1, 1)");
        if (x * x + y * y == r * r)
        {
            Console.WriteLine("Лежит");
        }
        else
        {
            Console.WriteLine("Не лежит");
        }
        Console.WriteLine();
        #endregion

        #region 1_1(4)
        x = 3;
        y = 0;
        r = 2;
        Console.WriteLine("1_1(4):");
        Console.WriteLine("Координаты (3, 0)");
        if (x * x + y * y == r * r)
        {
            Console.WriteLine("Лежит");
        }
        else
        {
            Console.WriteLine("Не лежит");
        }
        Console.WriteLine();
        #endregion

        #region 4_1
        Console.WriteLine("1_4:");
        Console.WriteLine("Введите значение для переменной - a");
        double.TryParse(Console.ReadLine(), out double a);
        Console.WriteLine("Введите значение для переменной - b");
        double.TryParse(Console.ReadLine(), out double b);
        Console.WriteLine("Введите значение для переменной - c");
        double.TryParse(Console.ReadLine(), out double c);
        double z = Math.Max(Math.Min(a, b), c);
        Console.WriteLine($"Ответ: {z}");
        Console.WriteLine();
        #endregion

        #region 1_7
        Console.WriteLine("1_7:");
        Console.WriteLine("Введите значение для переменной - x");
        double.TryParse(Console.ReadLine(), out x);
        if(Math.Abs(x) > 1)
        {
            y = 1;
        }
        else
        {
            y = Math.Abs(x);
        }
        Console.WriteLine($"Ответ: {y}");
        Console.WriteLine();
        #endregion

        #region 2_1
        double s = 0;
        Console.WriteLine("Введите количество учеников: ");
        double.TryParse(Console.ReadLine(), out double n);
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите рост ученика: ");
            double.TryParse(Console.ReadLine(), out double h);
            s += h;
        }
        s /= n;
        Console.WriteLine($"Ответ: {s}");
        Console.WriteLine();
        #endregion

        #region 2_4
        Console.WriteLine("2_4:");
        Console.WriteLine("Введите - n:");
        double.TryParse(Console.ReadLine(), out n);
        Console.WriteLine("Введите - r1:");
        double.TryParse(Console.ReadLine(), out double r1);
        Console.WriteLine("Введите - r2:");
        double.TryParse(Console.ReadLine(), out double r2);
        s = 0;
        for(int i = 0; i <= n; i++)
        {
            Console.WriteLine("Введите координаты - x:");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите координаты - y:");
            double.TryParse(Console.ReadLine(), out y);
            if((x*x + y*y < r1*r1) & (x*x + y*y > r2*r2))
            {
                s += 1;
            }
        }
        Console.WriteLine($"Ответ: {s}");
        Console.WriteLine();
        #endregion

        #region 2_7
        Console.WriteLine("2_7:");
        Console.WriteLine("Введите значение - n:");
        double.TryParse(Console.ReadLine(), out n);
        double q1 = 0;
        double q3 = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите значение - x:");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите значение - y:");
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 & y > 0)
            {
                Console.WriteLine("Точка лежит в 1 четверти");
                q1++;
            }
            if (x < 0 & y > 0)
            {
                Console.WriteLine("Точка лежит в 2 четверти");
            }
            if (x < 0 & y < 0)
            {
                Console.WriteLine("Точка лежит в 3 четверти");
                q3++;
            }
            if (x > 0 & y < 0)
            {
                Console.WriteLine("Точка лежит в 4 четверти");
            }
        }
        Console.WriteLine($"Количество точек, которые лежат в 1 четверти:{0}", q1);
        Console.WriteLine($"Количество точек, которые лежат в 3 четверти: {1}", q3);
        #endregion

    }
}
