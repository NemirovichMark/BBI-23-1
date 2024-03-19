using System;

struct Rectangle
{

    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double Area()
    {
        return length * width;
    }

    public double Perimeter()
    {
        return 2 * (length + width);
    }

    public string Compare(Rectangle other)
    {
        string result = $"Прямоугольник 1 vs Прямоугольник 2:\n";
        if (length > other.length)
            result += "Прямоугольник 1 длинее.\n";
        else if (length < other.length)
            result += "Прямоугольник 2 длинее.\n";
        else
            result += "Прямоугольники равны.\n";

        if (width > other.width)
            result += "Прямоугольник 1 шире.\n";
        else if (width < other.width)
            result += "Прямоугольник 2 шире.\n";
        else
            result += "Прямоугольники равны.\n";

        double area1 = Area();
        double area2 = other.Area();
        if (area1 > area2)
            result += "Прямоугольник 1 больше по площади.\n";
        else if (area1 < area2)
            result += "Прямоугольник 2 больше по площади.\n";
        else
            result += "Прямоугольники равны.\n";

        return result;
    }

    public void PrintInfo(int index)
    {
        Console.WriteLine($"\nПрямоугольник {index}:");
        Console.WriteLine($"Длина: {length}, Ширина: {width}, Площадь: {Area()}, Периметр: {Perimeter()}");
    }

    class Program
    {
        static void Main()
        {
            Rectangle[] rectangles = new Rectangle[3];
            rectangles[0] = new Rectangle(5, 10);
            rectangles[1] = new Rectangle(8, 6);
            rectangles[2] = new Rectangle(7, 9);

            Console.WriteLine("Значения:\n");

            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i].PrintInfo(i + 1);
            }

            Console.WriteLine();

            Console.WriteLine(rectangles[0].Compare(rectangles[1]));
            Console.WriteLine(rectangles[1].Compare(rectangles[2]));
            Console.WriteLine(rectangles[0].Compare(rectangles[2]));
        }
    }

}
