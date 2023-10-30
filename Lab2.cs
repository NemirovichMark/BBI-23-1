#region 1.2
int x = 1;
int y = 1;
if ((y + Math.Abs(x) <= 1) & (y >= 0))

{
    Console.WriteLine("1.2: Принадлижит");
}
else
{
    Console.WriteLine("1.2: Не принадлижит");
}
#endregion


#region 1.5(1)
double r = 70;
double s = 36.74;

if (2 * Math.Sqrt(r / Math.PI) >= Math.Sqrt(2) * Math.Sqrt(s))

{
    Console.WriteLine("1.5(1): Квадрат поместится в круге");
}
else
{
    Console.WriteLine("1.5(1): Квадрат не поместится в круге");
}
#endregion

#region 1.5(2)
double r = 0.86;
double s = 0.74;

if (2 * Math.Sqrt(r / Math.PI) >= Math.Sqrt(2) * Math.Sqrt(s))
{
    Console.WriteLine("1.5(2): Квадрат поместится в круге");
}
else
{
    Console.WriteLine("1.5(2): Квадрат не поместится в круге");
}
#endregion


#region 1.8
double x = -0.98;
if (Math.Abs(x) > 1)

{
    Console.WriteLine("1.8: " + 1);
}
else
{
    Console.WriteLine("1.8: " + Math.Abs(x));
}
#endregion

#region 2.2
int n = 3;
double a = 0;
double b = 0;
double r = 5;
int k = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Пожалуйста, введите x: ");
    double X = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Пожалуйста, введите y: ");
    double Y = Convert.ToDouble(Console.ReadLine());
    if (Math.Sqrt(Math.Pow(X - a, 2) + Math.Pow(Y - b, 2)) <= r)
    {
        k += 1;
    }
}
Console.WriteLine("2.2: " + k);
#endregion

#region 2.5
int n = 30;
int r = 5;
int k = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Пожалуйста, введите результат участника: ");
    double X = Convert.ToDouble(Console.ReadLine());
    if (X <= r)
    {
        k += 1;
    }
}
Console.WriteLine("2.5: " + k);
#endregion

#region 2.8
int n = 2;
double r = Math.Pow(10, 5);
double k = 0;
double knew = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Пожалуйста, введите x: ");
    double X = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Пожалуйста, введите y: ");
    double Y = Convert.ToDouble(Console.ReadLine());
    k += 1;
    if (Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)) <= r)
    {
        r = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        knew = k;
    }
}
Console.WriteLine("2.8: " + knew + " " + r);
#endregion