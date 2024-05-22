

//Вариант 4 
using System;
using System.Linq;

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public abstract string GetName();
}

public class Round : Shape
{
    private double radius;

    public Round(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override string GetName()
    {
        return "Круг";
    }
}

public class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double GetArea()
    {
        return Math.Pow(side, 2);
    }

    public override double GetPerimeter()
    {
        return 4 * side;
    }

    public override string GetName()
    {
        return "Квадрат";
    }
}

public class Triangle : Shape
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public override double GetArea()
    {
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    public override double GetPerimeter()
    {
        return sideA + sideB + sideC;
    }

    public override string GetName()
    {
        return "Треугольник";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Shape[] rounds = new Shape[5]
        {
            new Round(3),
            new Round(5),
            new Round(2),
            new Round(7),
            new Round(4)
        };

        Shape[] squares = new Shape[5]
        {
            new Square(3),
            new Square(5),
            new Square(2),
            new Square(7),
            new Square(4)
        };

        Shape[] triangles = new Shape[5]
        {
            new Triangle(3, 4, 5),
            new Triangle(5, 5, 5),
            new Triangle(2, 2, 3),
            new Triangle(7, 8, 9),
            new Triangle(6, 6, 6)
        };

        Console.WriteLine("Круги:");
        PrintShapesTable(rounds);

        Console.WriteLine("\nКвадраты:");
        PrintShapesTable(squares);

        Console.WriteLine("\nТреугольники:");
        PrintShapesTable(triangles);

        Shape[] allShapes = rounds.Concat(squares).Concat(triangles).ToArray();
        Array.Sort(allShapes, (s1, s2) => s2.GetArea().CompareTo(s1.GetArea()));

        Console.WriteLine("\nВсе фигуры (отсортированы по убыванию площади):");
        PrintShapesTable(allShapes);
    }

    private static void PrintShapesTable(Shape[] shapes)
    {
        Array.Sort(shapes, (s1, s2) => s2.GetArea().CompareTo(s1.GetArea()));
        Console.WriteLine("Название\tПериметр\tПлощадь");
        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetName()}\t{shape.GetPerimeter():0.##}\t\t{shape.GetArea():0.##}");
        }
    }
}
