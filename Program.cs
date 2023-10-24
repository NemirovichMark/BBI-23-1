#region 1.1 
using System;

double S = 0;
for (int i = 2; i <= 35; i += 3)
{
    S += i;
}
Console.WriteLine("1.1:\n{0}", S);
Console.WriteLine();
#endregion

#region 1.2 
S = 0;
for (double i = 1; i <= 10; i++)
{
    S += 1 / i;
}
Console.WriteLine("1.2:\n{0}", S);
Console.WriteLine();
#endregion

#region 1.3 
double s = 0;
for (double i = 2; i <= 112; i += 2)
{
    s += i / (i + 1);
}
Console.WriteLine("1.3:\n{0}", s);
Console.WriteLine();
#endregion

#region 1_4 
s = 0;
double x = 1;
double K = x;
for (double i = 1; i <= 9; i++)
{
    s += Math.Cos(i * x) / K;
    K *= x;
}
Console.WriteLine("1_4:\n{0}", s);
Console.WriteLine();
#endregion

#region 1.5 
s = 0;
double h = 4;
double p = 5;
for (double i = 0; i <= 9; i++)
{
    s += Math.Pow(p + h * i, 2);
}
Console.WriteLine("1.5:\n{0}", s);
Console.WriteLine();
#endregion

#region 1.6 
Console.WriteLine("1.6:\n{0}", " x y");
double y = 0;
for (x = -4; x <= 4.00001; x += 0.5)
{
    y = 0.5 * x * x - 7 * x;
    Console.WriteLine($"{x} {y}");
}
Console.WriteLine();
#endregion

#region 1.7
s = 1;
for (double i = 1; i < 7; i++)
{
    s *= i;
}
Console.WriteLine("1.7:\n{0}", s);
Console.WriteLine();
#endregion

#region 1.8 
s = 0;
int a = 1;
for (int i = 1; i <= 6; i++)
{
    a *= i;
    s += a;
}
Console.WriteLine("1.8:\n{0}", s);
Console.WriteLine();
#endregion

#region 1.9 
s = 0;
double k = -1;
double l = 5;
for (int i = 1; i <= 6; i++)
{
    s += k * l / i;
    k *= -1;
    l *= 5;
}
Console.WriteLine("1.9:\n{0}", s);
Console.WriteLine();
#endregion

#region 1.10 
s = 1;
for (int i = 1; i <= 7; i++)
{
    s *= 3;
}
Console.WriteLine("1.10:\n{0}", s);
Console.WriteLine();
#endregion

#region 1.11(а) 
Console.WriteLine("1.11(а):");
s = 0;
for (int i = 1; i <= 6; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();
#endregion

#region 1.11(б) 
Console.WriteLine("1.11(б):");
s = 0;
int t = 5;
for (int i = 1; i <= 6; i++)
{
    Console.Write(t + " ");
}
Console.WriteLine();
Console.WriteLine();
#endregion

#region 1.12 
s = 0;
x = 2;
double I = 1;
int N = 0;
do
{
    s += 1 / I;
    I *= x;
    N++;
}
while (N < 11);
Console.WriteLine("1.12:\n{0}", s);
Console.WriteLine();
#endregion

#region 1.13 
Console.WriteLine("1.13:\n{0}", "x     y");
y = 0;
h = 0.1;
for (x = -1.5; x <= 1.500001; x += h)
{
    if (x <= -1) y = 1;
    if (x > -1 & x <= 1) y = -x;
    else y = -1;
    Console.WriteLine($"{x} {y}");
}
Console.WriteLine();
#endregion

#region 1.14
Console.WriteLine("1.14:");
double u = 1;
double b = 1;
Console.Write($"{u} {b} ");

for (int i = 2; i < 8; i++)
{
    Console.Write($"{u + b} ");
    b = b + u;
    u = b - u;
}
Console.WriteLine();
Console.WriteLine();
#endregion

#region 1.15 
k = 1;
b = 1;
for (int i = 0; i < 5; i++)
{
    c = k;
    k = k + b;
    b = c;
}
Console.WriteLine("1.15:\n{0}", $"{k}/{b}");
Console.WriteLine();
#endregion

#region 2.1 
s = 0;
double r = 0;
y = 0.5;
n = 1;
do
{
    r = Math.Cos(n * y) / n*n;
    s += r;
    n++;
}
while (Math.Abs(r) > 0.0001);
Console.WriteLine(" 2.1:\n{0}", s);
Console.WriteLine();
#endregion

#region 2.2
p = 1;
n = 1;
do
{
    p *= n;
    n += 3;
}
while (p * n < 30000);
n -= 3;
Console.WriteLine("2.2:\n{0}", n);
Console.WriteLine();
#endregion

#region 2.3
a = 2;
b = 3;
p = 100;
n = 0;
l = 0;
do
{
    l += a + n * b;
    n++;
}
while (l <= p);
n -= 1;
Console.WriteLine("2.3\n{0}", n);
Console.WriteLine();
#endregion

#region 2_4 
double e = 0.0001;
x = 0.9;
s = 1;
k = 1;
n = 0;
while (k >= e)
{
    n++;
    k *= x * x;
    s += k;
}
Console.WriteLine("2_4:\n{0}", s);
Console.WriteLine();
#endregion


#region 2.5 
int m = 3,
chast = 0,
ostat = 0;
int o = 5;
while (o - m >= 0)
{
    chast += 1;
    o -= m;
}
ostat = o;
Console.WriteLine("2.5:\nЧастное:{0}, Остаток: {1}", chast, ostat);
Console.WriteLine();
#endregion

#region 2.7(а) 
s = 10;
u = 0;
k = 0;
while (k < 7)
{
    u += s;
    s = s * 1.1;
    k ++;
}
Console.WriteLine("2.7(а):\n{0}", u);
Console.WriteLine();
#endregion

#region 2.7(б) 
s = 10;
u = 0;
k = 0;
while (u < 100)
{
    u += s;
    s *= 1.1;
    k++;
}
Console.WriteLine("2.7(б):\n{0}", k);
Console.WriteLine();
#endregion

#region 2.7(в) 
s = 10;
k = 1;
while (s < 20)
{
    s *= 1.1;
    k++;
}
Console.WriteLine("2.7(в):\n{0}", k);
Console.WriteLine();
#endregion

#region 2.8 
s = 10000;
k = 0;
while (s <= 20000)
{
    s *= 1.08;
    k++;
}
Console.WriteLine("2.8:\n{0}", k);
Console.WriteLine();
#endregion

#region 3.6
Console.WriteLine("3.6:");
for (x = 0.1; x <= 1; x += 0.1)
{
    s = 0;
    int i = 1;
    double z = 0;
    k = x * x;
    while (z >= 0.0001)
    {
        z = k*x / (4 * i * i - 1);
        s += z;
        i += 1;
        k *= (-x) * x;
    }
    y = (((1 + x*x) * Math.Atan(x))/ 2) - x/2;
    Console.WriteLine("\nСумма:{0}, Функция: {1}", s, y);
}

#endregion
