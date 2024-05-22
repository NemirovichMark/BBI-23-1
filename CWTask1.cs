using System;

public struct Point
{
    private static int count = 1;
    private int x;
    private int y;

    public Point(int[] xy)
    {
        this.x = xy[0];
        this.y = xy[1];
    }

    public void Printxy()
    {
        Console.WriteLine($"Точка {count++}: X = {x}, Y = {y}");
    }

    public static void dis(Point p1, Point p2)
    {
        double d = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        Console.WriteLine($"Расстояние между точками 1 и 2: {d}");
       
    }
    public static void diss(Point p1, Point p2)
    {
        double d = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        Console.WriteLine($"Расстояние между точками 3 и 2: {d}");
    }
    public static void disss(Point p1, Point p2)
    {
        double d = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        Console.WriteLine($"Расстояние между точками 1 и 3: {d}");
    }
}

class Program
{
    static void Main()
    {
        int[][] pointsxy = new int[][]
        {
            new int[] {1, 2},
            new int[] {3, 4},
            new int[] {5, 16}
        };

        Point[] pointsArray = new Point[3];

        for (int i = 0; i < pointsArray.Length; i++)
        {
            pointsArray[i] = new Point(pointsxy[i]);
        }

        for (int i = 0; i < pointsArray.Length; i++)
        {
            pointsArray[i].Printxy();
        }

        Console.WriteLine();

        Point.dis(pointsArray[0], pointsArray[1]);
        Point.diss(pointsArray[1], pointsArray[2]);
        Point.disss(pointsArray[0], pointsArray[2]);
    }
}
