using System;

class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}

abstract class Fourangle
{
    protected Point[] points;

    public Fourangle(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 };
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();
}

class Square : Fourangle
{
    public Square(Point p1, Point p2, Point p3, Point p4) : base(p1, p2, p3, p4) { }

    public override double GetArea()
    {
        double a = GetSide(points[0], points[1]);
        return a * a;
    }

    public override double GetPerimeter()
    {
        double a = GetSide(points[0], points[1]);
        return 4 * a;
    }

    private double GetSide(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}

class Rectangle : Fourangle
{
    public Rectangle(Point p1, Point p2, Point p3, Point p4) : base(p1, p2, p3, p4) { }

    public override double GetArea()
    {
        double a = GetSide(points[0], points[1]);
        double b = GetSide(points[0], points[3]);
        return a * b;
    }

    public override double GetPerimeter()
    {
        double a = GetSide(points[0], points[1]);
        double b = GetSide(points[0], points[3]);
        return 2 * (a + b);
    }

    private double GetSide(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}

class Trapezium : Fourangle
{
    public Trapezium(Point p1, Point p2, Point p3, Point p4) : base(p1, p2, p3, p4) { }

    public override double GetArea()
    {
        double a = GetSide(points[0], points[1]);
        double b = GetSide(points[2], points[3]);
        double h = GetHeight(points[0], points[1], points[2], points[3]);
        return 0.5 * (a + b) * h;
    }

    public override double GetPerimeter()
    {
        double a = GetSide(points[0], points[1]);
        double b = GetSide(points[1], points[2]);
        double c = GetSide(points[2], points[3]);
        double d = GetSide(points[3], points[0]);
        return a + b + c + d;
    }

    private double GetSide(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }

    private double GetHeight(Point p1, Point p2, Point p3, Point p4)
    {
        double a = GetSide(p1, p2);
        double b = GetSide(p3, p4);
        double c = GetSide(p1, p4);
        double d = GetSide(p2, p3);
        return 2 * Math.Sqrt(c * d - 0.25 * Math.Pow(a - b, 2)) / (a + b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Square[] squares = new Square[]
        {
            new Square(new Point(0, 0), new Point(0, 5), new Point(5, 5), new Point(5, 0)),
            new Square(new Point(2, 2), new Point(2, 7), new Point(7, 7), new Point(7, 2)),
            new Square(new Point(1, 1), new Point(1, 6), new Point(6, 6), new Point(6, 1))
        };

        Rectangle[] rectangles = new Rectangle[]
        {
            new Rectangle(new Point(0, 0), new Point(0, 5), new Point(10, 5), new Point(10, 0)),
            new Rectangle(new Point(2, 2), new Point(2, 7), new Point(12, 7), new Point(12, 2)),
            new Rectangle(new Point(1, 1), new Point(1, 8), new Point(11, 8), new Point(11, 1))
        };

        Trapezium[] trapeziums = new Trapezium[]
        {
            new Trapezium(new Point(0, 0), new Point(0, 5), new Point(10, 10), new Point(10, 0)),
            new Trapezium(new Point(2, 2), new Point(2, 7), new Point(12, 12), new Point(12, 2)),
            new Trapezium(new Point(1, 1), new Point(1, 8), new Point(11, 16), new Point(11, 1))
        };

        PrintTable(" Квадраты", squares);
        PrintTable(" Прямоугольники", rectangles);
        PrintTable(" Трапеции", trapeziums);

        Fourangle[] figures = new Fourangle[squares.Length + rectangles.Length + trapeziums.Length];
        int index = 0;
        foreach (var square in squares)
            figures[index++] = square;
        foreach (var rectangle in rectangles)
            figures[index++] = rectangle;
        foreach (var trapezium in trapeziums)
            figures[index++] = trapezium;

        Array.Sort(figures, (f1, f2) => f2.GetArea().CompareTo(f1.GetArea()));

        Console.WriteLine("\n Вычисления:");
        Console.WriteLine("  Фигура  | Периметр | Площадь ");
        Console.WriteLine(" ------------------------------");
        foreach (var figure in figures)
        {
            string type = figure.GetType().Name;
            double perimeter = figure.GetPerimeter();
            double area = figure.GetArea();
            Console.WriteLine($"{type,-9} | {perimeter,8:F2} | {area,7:F2}");
        }
    }

    static void PrintTable(string title, Fourangle[] figures)
    {
        Console.WriteLine($"\n{title}:");
        Console.WriteLine("  Фигура  | Периметр | Площадь  ");
        Console.WriteLine(" ------------------------------");
        Array.Sort(figures, (f1, f2) => f2.GetArea().CompareTo(f1.GetArea()));
        foreach (var figure in figures)
        {
            string type = figure.GetType().Name;
            double perimeter = figure.GetPerimeter();
            double area = figure.GetArea();
            Console.WriteLine($"{type,-9} | {perimeter,8:F2} | {area,7:F2}");
        }
    }
}
