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
using System;

class Program
{
    static void Main()
    {
        double x = 1.0; // Значение x
        int n = 9;     // Количество членов ряда
        double sum = 0.0;

        for (int i = 1; i <= n; i++)
        {
            double term = Math.Cos(i * x) / Math.Pow(x, i - 1);
            sum += term;
        }

        Console.WriteLine("Сумма ряда равна: " + sum);
    }
}
*/

#endregion

#region 1.5
/*
using System;

class Program
{
    static void Main()
    {
        double p = 2.0;  // Первый член последовательности
        double h = 1.5; // Шаг арифметической прогрессии
        int n = 10;     // Количество членов ряда
        double sum = 0.0;

        for (int i = 0; i < n; i++)
        {
            double term = Math.Pow(p + i * h, 2);
            sum += term;
        }

        Console.WriteLine("Сумма квадратов 10 членов арифметической прогрессии равна: " + sum);
    }
}
*/
#endregion

#region 1.6
/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("x\t  y(x)");
        Console.WriteLine("---------------------");

        double startX = -4.0;
        double endX = 4.0;
        double step = 0.5;

        for (double x = startX; x <= endX; x += step)
        {
            double y = 0.5 * x * x - 7 * x;
            Console.WriteLine($"{x}\t{y}");
        }
    }
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
int n = 6;
double s = 0.0;

for (int i = 1; i <= n; i++)

{
    n = i * i
    s += Math.Pow(-1, i) * Math.Pow(5, i) / fact(i);
}


static long fact(int n) // функция для нахождения факториала 
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }

    return result;
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
int x = 2;
double s = 0.0;
for (int i = 1; i <= 10; i++)
{
   s += 1.0 + Math.Pow(x, i);

}
Console.WriteLine(s);
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
