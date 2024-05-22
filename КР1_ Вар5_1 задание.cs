public struct Rectangle
{
    public double A { get; private set; }
    public double B { get; private set; }

    public Rectangle(double a, double b)
    {
        A = a;
        B = b;
    }

    public double Area()
    {
        return A * B;
    }

    public double Perimeter()
    {
        return 2 * (A + B);
    }

    public static string Compare(Rectangle r1, Rectangle r2)
    {
        string ans = "";
        if (r1.A > r2.B)
        {
            ans += "Прямоугольник 1 длиннее прямоугольника 2; ";
        }
        else if (r1.A == r2.B)
        {
            ans += "Прямоугольники имеют одинаковую длину; ";
        }
        else
        {
            ans += "Прямоугольник 2 длиннее прямоугольника 1; ";
        }

        if (r1.A > r2.B)
        {
            ans += "Прямоугольник 1 шире прямоугольника 2; ";
        }
        else if (r1.A == r2.B)
        {
            ans += "Прямоугольники имеют одинаковую ширину; ";
        }
        else
        {
            ans += "Прямоугольник 2 шире прямоугольника 1; ";
        }

        if (r1.Area() > r2.Area())
        {
            ans += "ПРямоугольник 1 больше площади треугольника 2";
        }
        else if (r1.Area() == r2.Area())
        {
            ans += "Прямоугольники имеют одинаковую площадь";
        }
        else
        {
            ans += "Прямоугольник 2 больше по площади прямоугольника 1";
        }

        return ans;
    }


    public override string ToString()
    {
        return $"Прямоугольник со сторонами a={A} и b={B}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Rectangle[] rectangles =
        {
            new Rectangle(10, 10),
            new Rectangle(10, 10),
            new Rectangle(9, 90)
        };

        for (int i = 0; i < rectangles.Length; i++)
        {
            for (int j = i + 1; j < rectangles.Length; j++)
            {
                Console.WriteLine(rectangles[i] + " " + rectangles[j] + " " + Rectangle.Compare(rectangles[i], rectangles[j]));
            }
        }
    }
}

