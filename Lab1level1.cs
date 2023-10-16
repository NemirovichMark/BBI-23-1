#region 1.1
/*
using System;

class Program
{
    static void Main()
    {
        int start = 2;
        int end = 35;
        int step = 3;
        int sum = 0;

        for (int i = start; i <= end; i += step)
        {
            sum += i;
        }

        Console.WriteLine("Сумма ряда чисел от 2 до 35 с шагом 3 равна: " + sum);
    }
}
*/
#endregion

#region 1.2
/* 
using System;

class Program
{
	static void Main()
	{
		int n = 10; // Количество членов ряда
		double sum = 0.0;

		for (int i = 1; i <= n; i++)
		{
			sum += 1.0 / i;
		}

		Console.WriteLine("Сумма ряда 1 + 1/2 + 1/3 + ... + 1/10 равна: " + sum);
	}
}
*/
#endregion

#region 1.3
/*
using System;

class Program
{
    static void Main()
    {
        int n = 112; // Последний знаменатель
        double sum = 0.0;

        for (int i = 2; i <= n; i += 2)
        {
            sum += (double)i / (i + 1);
        }

        Console.WriteLine("Сумма ряда 2/3 + 4/5 + 6/7 + ... + 112/113 равна: " + sum);
    }
}
*/
#endregion

#region 1.4
/*
double s = 0;
double x = 1;    
double k = x;

        for (double n = 1; n <= 9; n++)
        {
    s+= Math.Cos(n*x)/k;
    k = k*x;
        }

Console.WriteLine(s);
*/

#endregion

#region 1.5
/*
double s = 0;  
double h = 1; 
double p = 1;    

        for (double i = 0; i <= 9; i++)
        {
            s = s + (p + h * i) * (p + h * i);
        }

Console.WriteLine("\n{0}", s);
Console.WriteLine(); 
*/
#endregion

#region 1.6
/*
const double xh = -4, xk = 4, h = 0.5;
double x, y;
int i, n;
n = (int) ((xk - xh) / h + 1); // определение кол-ва значений аргкмента при его изменении в пределах с шагом h
x = xh; 

for (i = 1; i <= n; i = i + 1)
    {
    y = 0.5 * x * x - 7 * x;
    Console.WriteLine("x={0:f2}\ty = {1:f2}", x, y);
    x = x + h;
    }
*/
#endregion

#region 1.7
/*
using System;

class Program
{
    static void Main()
    {
        int n = 6;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Факториал числа {n} равен {factorial}");
    }
}
*/
#endregion

#region 1.8
/*
using System;

class Program
{
    static void Main()
    {
        int n = 6;
        int sum = 0;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial;
        }

        Console.WriteLine("Сумма факториалов от 1! до 6! равна: " + sum);
    }
}
*/
#endregion

#region 1.9
/*
double s = 0, fac = 1;
double a = -1;
double m = 5;

for (int i = 1; i <= 6; i++)
    { 
    fac = fac * i;
    s += a * m / fac; 
    a *= -1;
    m *= 5;
    }
Console.WriteLine(s);
*/
#endregion

#region 1.10
/*
int a = 3;
int step = 7;
int otv = 1;
for (int i = 0; i < step; i++)
{
    otv *= a;
}
Console.WriteLine(otv);
*/
#endregion

#region 1.11
/*
for (int i = 1; i <= 6; i++)
{
    Console.Write(i + " ");
}

for (int i = 0; i < 6; i++)
{
    Console.Write("5 ");
}
*/
#endregion

#region 1.12
/*
double s = 1;
double x = 7; 
double k = x; 

for (int i = 1; i <= 10; i++)
    {
    s = s + 1 / k;
    k *=x;
    }
Console.WriteLine(s);
*/
#endregion

#region 1.13 
/*
Console.WriteLine("1_13:\n{0}", "x   y");
double x, y;
double h = 0.1;
for (x = -1.5; x <= 1.5; x += h)
{
    if (x <= -1) y = 1;
    if (x > -1 & x <= 1) y = -x;
    else y = -1;
    Console.WriteLine($"{x} {y}");
}
Console.WriteLine();
*/
#endregion

#region 1.14
/*
int a = 1; // первый член последовательности
int b = 1; // второй член последовательности
int next = 0;
Console.WriteLine(a);
Console.WriteLine(b);
for (int i = 2; i <= 7; i ++)
{
    next = (a + b);
    Console.WriteLine($"{next}");
    a = b;
    b = next; 
}
*/
#endregion

#region 1.15
/*
double a1 = 1;
double b1 = 1;
double a2 = 2;
double b2 = 1;
int n = 5;

//Вычисление следующих членов
for (int i = 3; i <= n; i++)
{
    double nexta = a1 + a2;
    double nextb = b1 + b2;

// Обновление значений для следующей итерации
    a1 = a2;
    b1 = b2;
    a2 = nexta;
    b2 = nextb;
}
double res = a2 / b2;
Console.WriteLine(res);
*/
#endregion
