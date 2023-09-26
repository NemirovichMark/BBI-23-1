static void Main()
{ 
 #region 1_1
int S = 0;
for (int i = 2; i <= 35; i += 3)
{
    S += i;
}
Console.WriteLine(S);
#endregion

#region 1_2
double S = 0;
for (double i = 1; i <= 10; i++)
{
    S += 1 / i;
}
Console.WriteLine(S);
#endregion

#region 1_3
double S = 0;
for (double i = 3; i <= 113; i++)
{
    S += (i - 1) / i;
}
Console.WriteLine(S);
#endregion

#region 1_10
int pow = 1;
for (int i = 0; i < 7; i++)
{
    pow *= 3;
}
Console.WriteLine(pow);
#endregion

#region 1_11
for (int i = 1; i <= 6; i++) 
{
    Console.Write(i + " ");
}
Console.WriteLine();
for (int i = 0; i < 6; i++)
{
    Console.Write("5 ");
}
#endregion

#region 2_1
double eps = 0.0001;
double s = 0;
double a = 0;
double x = 0.5;
int n = 1;
do
{
    a = Math.Cos(n * x) / Math.Pow(n, 2);
    s += a;
    n++;
}
while (Math.Abs(a) > eps);
Console.WriteLine(s);
#endregion

#region 2_2
int p = 1;
for (int n = 1; n * p <= 30000; n += 3)
{
    p *= n;
}
Console.WriteLine(p);
#endregion

#region 2_3
int a = 4;
int b = 5;
int p = 100;
int n = 0;
int s = 0;
do
{
    s += a + n * b;
    n++;
}
while (s <= p);
n -= 1;
Console.WriteLine(n);
#endregion

#region 2_4
double x = 0.5;
double s = 0;
double eps = 0.0001;
int n = 0;
double a = 0;
do
{
    a = Math.Pow(x, 2 * n);
    s += a;
    n++;
}
while (a > eps);
Console.WriteLine(s);
#endregion

#region 2_5
int a = 29;
int b = 2;
int x = 0;
do
{
    x++;
    a -= b;
}
while (a > b);
Console.WriteLine(a);
Console.WriteLine(x);
#endregion

#region 3_1
using System;
using System.Diagnostics.CodeAnalysis;

class project
{
    public static int Factorial(int fact)
    {
        if (fact == 0 || fact == 1) return 1;
        return fact * Factorial(fact - 1);
    }

    public static void Main(string[] args)
    {

        double s = 0;
        int i = 0;
        double y = 0;


        for (double x = 0.1; x <= 1; x = x + 0.05)
        {
            double tr = 0;
            do
            {
                tr = (Math.Pow(x, (2 * i)) / Factorial(2 * i));
                s = s + tr;
                i++;
            }
            while (Math.Abs(tr) >= 0.0001);
            Console.WriteLine(s);
            y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
            Console.WriteLine("Y равен" + y);

        }
    }
    #endregion
}