//Вариант 4 


using System;

public struct Triangle
{
    private double sideA;
    private double sideB;
    private double sideC;

    public double SideA { get => sideA; set => sideA = value; }
    public double SideB { get => sideB; set => sideB = value; }
    public double SideC { get => sideC; set => sideC = value; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public string GetTriangleType()
    {
        if (sideA == sideB && sideB == sideC)
            return "Равносторонний";
        else if (sideA == sideB || sideB == sideC || sideA == sideC)
            return "Равнобедренный";
        else
            return "Разносторонний";
    }

    public double GetArea()
    {
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Стороны: {sideA}, {sideB}, {sideC}");
        Console.WriteLine($"Тип: {GetTriangleType()}");
        Console.WriteLine($"Площадь: {GetArea()}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Triangle[] triangles = new Triangle[5];
        triangles[0] = new Triangle(3, 4, 5);
        triangles[1] = new Triangle(5, 5, 5);
        triangles[2] = new Triangle(2, 2, 3);
        triangles[3] = new Triangle(7, 8, 9);
        triangles[4] = new Triangle(6, 6, 6);

        Array.Sort(triangles, (t1, t2) => t2.GetArea().CompareTo(t1.GetArea()));

        Console.WriteLine("Треугольники (отсортированные по убыванию площади):");
        Console.WriteLine("№\tСтороны\t\tПлощадь\t\tТип");
        for (int i = 0; i < triangles.Length; i++)
        {
            Console.Write($"{i + 1}\t{triangles[i].SideA}, {triangles[i].SideB}, {triangles[i].SideC}\t");
            Console.WriteLine($"{triangles[i].GetArea():0.##}\t\t{triangles[i].GetTriangleType()}");
        }
    }
}



