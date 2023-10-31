#region 1.1
using System;

double r = 2;
double[,] tochki = { { 0, 2 }, { 1.5, 0.7 }, { 1, 1 }, { 3, 0 } };
for (int i = 0; i < tochki.GetLength(0); i++)
{
     double X = tochki[i, 0];
     double Y = tochki[i, 1];

    if (Math.Abs(X * X + Y * Y - r * r) < 0.001)
    {
        Console.WriteLine($"Точка ({X}, {Y}) лежит на окружности.");
    }
    else
    {
        Console.WriteLine($"Точка ({X}, {Y}) не лежит на окружности.");
    }
}
#endregion

#region 1.4
Console.WriteLine("1.4");
double a = int.Parse(Console.ReadLine());
double b = int.Parse(Console.ReadLine());
double c = int.Parse(Console.ReadLine());
double ab = Math.Min(a, b);
double z = Math.Max(ab, c);
Console.WriteLine($"Значение z: {z}");
Console.WriteLine();
#endregion

#region 1.7
Console.WriteLine("1.7");
double x = double.Parse(Console.ReadLine());
double y = 0;
if (Math.Abs(x) < 1)
{
    y = 1;
}
else
{
    y = Math.Abs(x);
}
Console.WriteLine($"Значение фунции: {y}");
Console.WriteLine();
#endregion

#region 2.1
double srM, srD; //Средний рост мальчиков и девочек
int nM = 0, nD = 0; // Количество мальчиков и девочек
Console.WriteLine("Введико количество учеников:");
double n = double.Parse(Console.ReadLine()); //количество учеников в целом
double m = 0, d = 0; // суммарный рост для мальчиков и девочек
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите рост ученика:");
    double s = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите пол ученика (д - девочка, м - мальчик):");
    string gender = Console.ReadLine();
    if (gender == "д")
    {
        d += s;
        nD++;
    }
    else
    {
        m += s;
        nM++;
    }

}
srM = m / nM;
srD = d / nD;
Console.WriteLine($"Средний рост девочек: {srD}");
Console.WriteLine($"Средний рост мальчиков: {srM}");
#endregion

#region 2.4
Console.WriteLine("2.4");
Console.WriteLine("Введите r1:");
double r1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите r2:");
double r2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите количество точек:");
n = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите x:");
    x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y:");
    y = double.Parse(Console.ReadLine());
    if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2)
    { count++; }
}
Console.WriteLine($"Количество точек, попавших в кольцо: {count}");
Console.WriteLine();
#endregion

#region 2.7
Console.Write("2.7");
int n = 0;
double count1 = 0;
double count3 = 0;
double p1 = 0, p3 = 0;
while(true)
{
    Console.WriteLine("Введите x");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y");
    double y = double.Parse(Console.ReadLine());
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка находится в 1-м квадранте");
        count1++;
        n++;
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка находится в 3-м квадранте");
        count3++;
        n++;
    }
    else if ((x > 0 && y < 0) || (x < 0 && y > 0))
    {
        n++;
    }
    Console.WriteLine("Введите stop для завершения");
    string stop = Console.ReadLine();
    if (stop == "stop")
    {
        break;
    }
}
p1 = count1 / n * 100;
p3 = count3 / n * 100;
Console.WriteLine($"Процент точек в 1-м квадранте: {p1} %");
Console.WriteLine($"Процент точек в 3-м квадранте: {p3} %");
Console.WriteLine();
#endregion
