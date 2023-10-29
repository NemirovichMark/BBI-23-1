#region 1.1
double r = 2;
double[,] tochki = { { 0, 2 }, { 1.5, 0.7 }, { 1, 1 }, { 3, 0 } };
for (int i = 0; i < tochki.GetLength(0); i++)
{
     x = tochki[i, 0];
     y = tochki[i, 1];

    if (Math.Abs(x * x + y * y - r * r) < 0.001)
    {
        Console.WriteLine($"Точка ({x}, {y}) лежит на окружности.");
    }
    else
    {
        Console.WriteLine($"Точка ({x}, {y}) не лежит на окружности.");
    }
}
#endregion

#region 1.4
Console.WriteLine("1.4");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
int ab = Math.Min(a, b);
int z = Math.Max(ab, c);
Console.WriteLine($"Значение z: {z}");
Console.WriteLine();
#endregion

#region 1.7
Console.WriteLine("1.7");
x = double.Parse(Console.ReadLine());
y = 0;
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
Console.WriteLine("2.1");
double srM, srD; //Средний рост мальчиков и девочек
int nM = 0, nD = 0; // Количество мальчиков и девочек
Console.WriteLine("Введико количество учеников:");
n = double.Parse(Console.ReadLine()); //количество учеников в целом
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
Console.WriteLine();
#endregion

#region 2.4
Console.WriteLine("2.4");
r1 = double.Parse(Console.ReadLine());
r2 = double.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < n; i++)
{
    string[] coordinates = Console.ReadLine().Split(' ');
     x = double.Parse(coordinates[0]);
     y = double.Parse(coordinates[1]);
    double distance = Math.Sqrt(x * x + y * y);
    if (distance >= r1 && distance <= r2)
    {
        count++;
    }
}
Console.WriteLine($"Количество точек, попавших в кольцо: {count}");
Console.WriteLine();
#endregion

#region 2.7
Console.Write("2.7");
n = int.Parse(Console.ReadLine());
int count1 = 0;
int count3 = 0; 
for (int i = 1; i <= n; i++)
{
    x = double.Parse(Console.ReadLine());
    y = double.Parse(Console.ReadLine());
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка находится в 1-м квадранте");
        count1++;
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка находится в 3-м квадранте");
        count3++;
    }
}

Console.WriteLine($"Количество точек в 1-м квадранте: {count1}");
Console.WriteLine($"Количество точек в 3-м квадранте: {count3}");
Console.WriteLine();
#endregion
