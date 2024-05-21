
using System;
struct Point
{
    private double x;
    private double y;

    public Point(double[] coordinates)
    {
        x = coordinates[0];
        y = coordinates[1];
    }

    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public static double Distance(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
    }

    public static void PrintInfo(Point p1, Point p2)
    {
        double distance = Distance(p1, p2);
        Console.WriteLine($"Точка 1: ({p1.X}, {p1.Y})");
        Console.WriteLine($"Точка 2: ({p2.X}, {p2.Y})");

        Console.WriteLine($"Расстояние между точками: {distance:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point[] points = new Point[]
        {
            new Point(new double[] { 1.0, 2.0 }),
            new Point(new double[] { 3.0, 4.0 }),
            new Point(new double[] { -1.0, 5.0 })
        };

        Console.WriteLine("Информация о точках:");

        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                Console.WriteLine($"Пара точек {i + 1} и {j + 1}:");
                Point.PrintInfo(points[i], points[j]);
                Console.WriteLine();
            }
        }
    }
}
