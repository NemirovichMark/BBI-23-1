#region 1.2
int x2 = 1;
int y2 = 1;
if ((y2 + Math.Abs(x2) <= 1) & (y2 >= 0))

{
    Console.WriteLine("Принадлижит");
}
else
{
    Console.WriteLine("Не принадлижит");
}
#endregion


#region 1.5(1)
double r5 = 70;
double s5 = 36.74;

if (2 * Math.Sqrt(r5 / Math.PI) >= Math.Sqrt(2) * Math.Sqrt(s5))

{
    Console.WriteLine("Поместится");
}
else
{
    Console.WriteLine("Не поместится");
}
#endregion

#region 1.5(2)
double r6 = 0.86;
double s6 = 0.74;

if (2 * Math.Sqrt(r6 / Math.PI) >= Math.Sqrt(2) * Math.Sqrt(s6))
{
    Console.WriteLine("Поместится");
}
else
{
    Console.WriteLine("Не поместится");
}
#endregion


#region 1.8
double x8 = -0.98;
if (Math.Abs(x8) > 1)

{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(Math.Abs(x8));
}
#endregion

