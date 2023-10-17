#region 1.4
/*
double sum = 0.0;
double x = 5.0;    

   for (double i = 1; i < 10; i++)
        {
    sum += Math.Cos(i * x) / Math.Pow(x, i - 1);
        }

Console.WriteLine(sum);
*/

#endregion


#region 2.3
/*
int s = 0;
Console.WriteLine("Введите число a : ");
int a = Convert.ToInt32(Console.ReadLine());
int n = 0;
Console.WriteLine("Введите число h : ");
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число p : ");
int p = Convert.ToInt32(Console.ReadLine());
while (s <= p)
{
    s += (a + n * h);
    n++;
}
Console.WriteLine($"Ответ: {n}");

*/
#endregion


#region 3.7
/*
using System;


class Program
{
    public static int Factoria(int fact)
    {
        if (fact == 0 || fact == 1) return 1;
        return fact * Factoria(fact - 1);
    }
    public static void Main(string[] args)
    {
        double s = 0;
        int i = 0;
        double y = 0;

        for (double x = 0.1; x <= 1; x = x + 0.05)
        {
            i = 0;
            double tr = 0;
            do
            {
                tr = (Math.Pow(x, (2 * i)) / Factoria(2 * i));
                if (Math.Abs(tr) < 0.0001) break;
                s = s + tr;
                i++;
            }
            while (Math.Abs(tr) >= 0.0001);
            Console.WriteLine(s);
            y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
            Console.WriteLine("Y равен" + y);
        }
    }
}

*/
#endregion