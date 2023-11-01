using System;

class Program
{
    static void Main()

    {
        for (double x = 0.1; x <= 0.8; x += 0.1)
{
    double s = 0;
    int i = 1;
    double x2 = x; /*степень*/
            while (x2 * Math.Sin((i * Math.PI) / 4) >= 0.0001)
    {
        s += x2 * Math.Sin((i * Math.PI) / 4);
        i += 1;
        x2 *= x; /*степень*/
    }
            double y = ((x * Math.Sin((Math.PI / 4))) /*числитель*/ / (1 - 2 * x * Math.Cos((Math.PI) / 4) + x * x)); /*знаменитель*/
    Console.WriteLine($"{s} {y}");

}
Console.ReadLine();
    }
    
}

