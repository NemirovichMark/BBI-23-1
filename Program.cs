
#region 1.1
int s = 0;
for (int i = 2; i <= 35; i += 3)
{ s += i; }
Console.WriteLine(s);
#endregion
#region 1.2
double q = 0;

for (double i = 1; i <= 10; i += 1)

{ q += 1 / i; }

Console.WriteLine(q);
#endregion
#region 1.3
double w = 0;

for (double i = 2; i <= 112; i += 1)

{ w += i / (i + 1); }

Console.WriteLine(w);
#endregion
#region 1.4
double x = 0.5;
double e = 0;
for (double o = 1; o <= 9; o++)
{ e += Math.Cos(o * x) / Math.Pow(x, o - 1); }
Console.WriteLine(e);
#endregion
#region 1.5
double r = 0;
double p = 3;
double h = 2;
for (double no = 0; no <= 9; no++)
{ r += Math.Pow(p + no * h, 2);}
Console.WriteLine(r);
#endregion
#region 2.1
double eps = 0.0001;
double t = 0;
double a = 0;
double y = 0.5;
int n = 1;
do
{a = Math.Cos(n * y) / Math.Pow(n, 2);
t += a;
n++;
}

while (Math.Abs(a) > eps);
Console.WriteLine(t);
#endregion
#region 2.2
p = 1;
for (n = 1; n * p <= 30000; n += 3)
{p *= n;}

Console.WriteLine(p);
#endregion
#region 2.3
a = 2;
int b = 3;
p = 100;
n = 0;
double l = 0;
do
{
    l += a + n * b;
    n++;
}
while (l <= p);
n -= 1;
Console.WriteLine(n);
#endregion
#region 2.4
x = 0.5;
l = 0;
eps = 0.0001;
n = 0;
a = 0;
do
{
    a = Math.Pow(x, 2 * n);
    l += a;
    n++;
}
while (a > eps);
Console.WriteLine(l);
#endregion
#region 2.5
a = 50;
b = 3;
x = 0;
do
{
    x++;
    a -= b;
}
while (a > b);
Console.WriteLine(a);
Console.WriteLine(x);
#endregion