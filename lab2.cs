using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_2");
        Task2();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_5");
        Task5();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("1_8");
        Task8();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_2");
        Task2_2();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_5");
        Task2_5();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("2_8");
        Task2_8();
    }
    private static void Task2()
    {
        int x = 1;
        int y = 1;
        if ((y + Math.Abs(x) <= 1) & (y >= 0))
        {
            Console.WriteLine("является");
        }
        else
        {
            Console.WriteLine("не является");
        }
    }
    private static void Task5()
    {
        Console.WriteLine("Введите r:");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите S:");
        double S = Convert.ToDouble(Console.ReadLine());
        double D = 2 * Math.Sqrt(r / Math.PI);
        double dg = Math.Sqrt(2 * S);
        if (dg <= D)
        {
            Console.WriteLine("Квадрат поместиться в круге");
        }
        else
        {
            Console.WriteLine("Квадрат не поместиться в круге");
        }
        Console.WriteLine();
    }
    private static void Task8()
    {
        double y = 0;
        Console.WriteLine("Введите x:");
        double x = Convert.ToDouble(Console.ReadLine());
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
    }
    private static void Task2_2()
    {
        Console.WriteLine("Введите n:");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите r:");
        double r = Convert.ToDouble(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());
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
    }
    private static void Task2_5()
    {
    int n = 30;
    int H = 0;
    int Q = 0;
    int F = 0;
    Console.WriteLine("Введите норматив:");
    double w = Convert.ToDouble(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine("Введите результат участника:");
        string x = Console.ReadLine();
        if (x != "-")
        {
            double k = Convert.ToDouble(x);
            if (k >= w)
            {
                H++;
            }
            if (k < w)
            {
                Q++;
            }
        }
        else
        {
            F++;
        }
    }
    Console.WriteLine("Прошли");
    Console.WriteLine(H);
    Console.WriteLine("Не прошли");
    Console.WriteLine(Q);
    Console.WriteLine("Сошли");
    Console.WriteLine(F);
}
    private static void Task2_8()
    {
        double S = 0;
        double min = 0;
        double k = 0;
        Console.WriteLine("Введите n:");
        double n = Convert.ToDouble(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double r = x * x + y * y;
            if (r < S)
            {
                min = r;
                k = i;
            }
            S = r;
        }
        Console.WriteLine("Номер точки:");
        Console.WriteLine(k);
        Console.WriteLine("Расстояние до начала координат:");
        Console.WriteLine(min);
    }
}
