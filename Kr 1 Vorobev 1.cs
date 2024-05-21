// Контрольная работа номер 1 вариант 4 
// задание 1 
//using System;


/*public struct Triangle
{
    private double a;
    private double b;
    private double c;

    public double A { get => a; set => a = value; }
    public double B { get => b; set => b = value; }
    public double C { get => c; set => c = value; }

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public string GetTriangleT()
    {
        if (a == b && b == c)
            return "Равносторонний";
        else if (a == b || b == c || a == c)
            return "Равнобедренный";
        else
            return "Разносторонний";
    }

    public double GetArea()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Стороны: {a}, {b}, {c}");
        Console.WriteLine($"Тип: {GetTriangleT()}");
        Console.WriteLine($"Площадь: {GetArea():0.##}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Triangle[] triangles = new Triangle[5];
        triangles[0] = new Triangle(1, 2, 3);// Могут задаваться любые значения для треугольника 
        triangles[1] = new Triangle(5, 5, 5);
        triangles[2] = new Triangle(2, 2, 7);
        triangles[3] = new Triangle(7, 3, 9);
        triangles[4] = new Triangle(6, 10, 6);

        Array.Sort(triangles, (t1, t2) => t2.GetArea().CompareTo(t1.GetArea()));

        Console.WriteLine("Треугольники по убыванию площади:");
        Console.WriteLine("№\tСтороны\t\tПлощадь\t\tТип");
        for (int i = 0; i < triangles.Length; i++)
        {
            Console.Write($"{i + 1}\t{triangles[i].A}, {triangles[i].B}, {triangles[i].C}\t");
            Console.WriteLine($"{triangles[i].GetArea():0.##}\t\t{triangles[i].GetTriangleT()}");
        }
    }
}*/