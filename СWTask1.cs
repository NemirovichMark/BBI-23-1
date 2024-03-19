// See https://aka.ms/new-console-template for more information
//вар4 задание 1
using System;

struct Rectangle
{
    private int length;
    private int width;

    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    private int CalculateArea()
    {
        return length * width;
    }

    private int CalculatePerimeter()
    {
        return 2 * (length + width);
    }

    public void Compare(Rectangle other)
    {
        Console.WriteLine($"Rectangle 1: Length = {length}, Width = {width}");
        Console.WriteLine($"Rectangle 2: Length = {other.length}, Width = {other.width}");

        if (length > other.length)
            Console.WriteLine("Rectangle 1 длиннее чем Rectangle 2");
        else if (length < other.length)
            Console.WriteLine("Rectangle 2 длиннее чем Rectangle 1");
        else
            Console.WriteLine("У них одинаковая длина");

        if (width > other.width)
            Console.WriteLine("Rectangle 1 шире чем Rectangle 2");
        else if (width < other.width)
            Console.WriteLine("Rectangle 2 шире чем Rectangle 1");
        else
            Console.WriteLine("У них одинаковая ширина");

        int area1 = CalculateArea();
        int area2 = other.CalculateArea();

        if (area1 > area2)
            Console.WriteLine("Rectangle 1 имеет большую площадь чем Rectangle 2");
        else if (area1 < area2)
            Console.WriteLine("Rectangle 2 имеет большую площадь чем Rectangle 1.");
        else
            Console.WriteLine("Rectangles имеют одинаковую площади");

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Rectangle r1 = new Rectangle(5, 10);
        Rectangle r2 = new Rectangle(8, 6);
        Rectangle r3 = new Rectangle(0, 7);

        Console.WriteLine("Результаты:");
        Console.WriteLine("------------------------------");
        r1.Compare(r2);
        r1.Compare(r3);
        r2.Compare(r3);
    }
}