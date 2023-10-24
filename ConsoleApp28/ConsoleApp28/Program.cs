

// See https://aka.ms/new-console-template for more information

using System;


//порядковый номер:9
#region 1-1
Console.WriteLine("1-1");

string inside="точка внутри круга";
string outside = "точка вне круга";

double x = 0;

 double y = 2;

int r = 2;

if (Math.Abs(x*x + y * y - r * r) <= Math.Pow(10, -3))
Console.WriteLine(inside);
 else
 Console.WriteLine(outside);
x = 1.5;
 y = 0.7;

if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
 Console.WriteLine(inside);
else
 Console.WriteLine(outside);
x = 1;
y = 1;
if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
 Console.WriteLine(inside);
else
 Console.WriteLine(outside);
x = 3;
y = 0;
if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
  Console.WriteLine(inside);
else
Console.WriteLine(outside);
#endregion

#region 1-4
Console.WriteLine("1-4");
Console.WriteLine("Введите значение a:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение b:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение c:");
int c = int.Parse(Console.ReadLine());
int z;
z = a;
if (b < z)
    z = b;
     
if(c > z)
    Console.WriteLine(c);
else
    Console.WriteLine(z);

#endregion




#region 1-7
Console.WriteLine("1-7");

x = 7;
    if (Math.Abs(x) > 0)
{
 y = 1;
 Console.WriteLine(y);
}
 else if (Math.Abs(x) <= 1)
{

 y = Math.Abs(x);
  Console.WriteLine(y);

}
#endregion

#region 2-1
Console.WriteLine("2-1");
double rr,j, s = 0,m=0,g=0, sr,mr,gr;
for (int i = 1; i <= 4; i++)
{
Console.WriteLine("Введите рост мальчиков ");
 rr = double.Parse(Console.ReadLine());
 Console.WriteLine("Введите рост девочек ");
j= double.Parse(Console.ReadLine());
s = s + rr+j;
 m = m+rr;
 g = g+j;
}
sr = s / 8;
mr = m / 4;
gr = g / 4;

Console.WriteLine($"общий средний рост :{sr} см" );
Console.WriteLine($"средний рост мальчиков {mr} см");
Console.WriteLine($"средний рост девочек  {gr} см");
Console.ReadKey();

#endregion

#region 2-4
Console.WriteLine("2-4");
double r1=1,r2=5;
int n=0;
x = 0;
y = 2;
double d=Math.Sqrt(x*x+y*y);
if (d >= r1 && d <= r2)
{
    n++;
}
x = 5;
y = 4;
 d = Math.Sqrt(x * x + y * y);
if (d >= r1 && d <= r2)
{ 
 n++;
}
x = 1;
y = 1.5;
d = Math.Sqrt(x * x + y * y);
if (d >= r1 && d <= r2)
{ 
    n ++;
}
Console.WriteLine($"количество точек попадающих в кольцо: {n}");


#endregion
#region 2-7
Console.WriteLine("2-7");
x = 2;
y = 3;
int mm=0, t=0;
if (x > 0 && y > 0)
{
    mm++;

    Console.WriteLine("точка находится в первом квадранте");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("точка находится во вторром квадранте");
}
if (x < 0 && y < 0)
{
    t++;
    Console.WriteLine("точка находится в третьем квадранте");
}


if (x > 0 && y < 0)
{
    Console.WriteLine("точка находится в четвертом квадранте");
}
x = -2;
y = -3;
if (x > 0 && y > 0)
{
    mm++;
    Console.WriteLine("точка находится в первом квадранте");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("точка находится во втором квадранте");
}
if (x < 0 && y < 0)
{
    t++;
    Console.WriteLine("точка находится в третьем квадранте");

}

if (x > 0 && y < 0)
{
    Console.WriteLine("точка находится в четвертом квадранте");
}
x = -4;
y = 5;
if (x > 0 && y > 0)
{
    mm++;
    Console.WriteLine("точка находится в первом квадранте");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("точка находится во втором квадранте");
}
if (x < 0 && y < 0)
{
    t++;
    Console.WriteLine("точка находится в третьем квадранте");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("точка находится в четвертом квадранте");
}
Console.WriteLine($"точек в первом квадранте: {mm}") ;
Console.WriteLine($"точек в третьем квадранте: {  t}");
        #endregion
