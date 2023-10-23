// 1
//int s = 0;
//for (int i = 2; i <= 35; i = i + 3)
//{
//    s = s + i;
//}
//Console.WriteLine("s=", s);
// 2
//double s = 0;
//for (double i = 1; i <= 10; i = i + 1)
//{
//    s = s + 1 / i;
//}
//Console.WriteLine("s=", s);

//3
//double s = 0;
//for (int i = 2; i <= 112; i = i + 2)
//{
//    s = s + i / (i + 1.0);
//}
//Console.WriteLine("s={0:f}", s);

//4
//double s = 0, x = 0.2;
//for (double i = 0; i <= 9; i++)
//{
//    s = s + Math.Cos(i * x) / Math.Pow(x, i - 1);
//}
//Console.WriteLine("s={0:f}", s);

//5
//h = 0;
//double gh = 1;
//double p = 1;
//for (double i = 0; i <= 9; i++)
//{
//    h += (p + h * i) * (p + h * i);
//}
//Console.WriteLine(h);
//Console.WriteLine();

//6
//for (double x = -4; x <= 4; x = x + 0.5)
//{
//    Console.WriteLine("x=" + x   "y=" + (0.5 * x * x - 7 * x));
//}
//Console.ReadKey(true);

//7
//const int n = 6;
//int s = 1;
//for (int i = 2; i <= n; i++)
//{
//    s = s * i;
//}
//Console.WriteLine(s);

//8
//int s = 0;
//int p = 1;
//for (int i = 1; i <= 6; i++)
//{
//    p = p * i;
//    s = s + p;
//}
//Console.WriteLine(s);

//9
//h = 0; fir = -1;
//double l = 5;
//for (int i = 1; i <= 6; i++)
//{
//    h += fir * l / Fact(i);
//    fir *= -1;
//    l *= 5;
//}
//Console.WriteLine(h);
//Console.WriteLine();

//10
//int a = 3;
//for (int i = 2; i <= 7; i++)
//{
//    a = a * 3;
//}
//Console.WriteLine("{0:d}", a);

//11.1
//for (int i = 1; i <= 6; i++)
//{
//    Console.Write("{0:d} ", i);
//}
//Console.ReadKey();

//11.2
//for (int i = 1; i <= 6; i++)
//{
//    Console.Write("{0:d} ", 5);
//}
//Console.ReadKey();

//12
// h = 0; fir = -1;
//l = 5;
//for (int i = 1; i <= 6; i++)
//{
//    h += fir * l / Fact(i);
//    fir *= -1;
//    l *= 5;
//}
//Console.WriteLine(h);
//Console.WriteLine();

//13
//const double a = -1.5, b = 1.5, h = 0.1;
//double x, y;
//int i;
//x = a;
//for (i = 1; x <= -1; i++)
//{
//    y = 1;
//    Console.WriteLine("x = {0:f2}\ty = {1:f2}", x, y);
//    x = x + h;
//}
//for (i = 1; x <= 1; i++)
//{
//    y = -x;
//    Console.WriteLine("x = {0:f2}\ty = {1:f2}", x, y);
//    x = x + h;
//}
//for (i = 1; x < 1.6; i++)
//{
//    y = -1;
//    Console.WriteLine("x = {0:f2}\ty = {1:f2}", x, y);
//    x = x + h;
//}

//14
//int fib = 0, fib1 = 0, fib2 = 1;

//for (int i = 0; i < 8; i++)
//{
//    fib = fib1 + fib2;
//    fib2 = fib1;
//    fib1 = fib;
//    Console.Write("{0:d} ", fib);
//}
//Console.ReadKey();

//15 
//int fib = 0, fib1 = 0, fib2 = 1;
//double a = 0, n = 0;
//for (int i = 0; i < 5; i++)
//{
//    fib = fib1 + fib2;
//    fib2 = fib1;
//    fib1 = fib;
//    a = fib1 + fib2;
//    n = a / fib;

//}
//Console.WriteLine("{0:f2}", n);

//2 уровень
//1
//double xp = 1;
//double e = 0.0001;
//double sum = 0;
//double t = 1; // текущий член суммы
//double np = 1; // текущий номер члена суммы
//while (Math.Abs(t) >= e)
//{
//    t = Math.Cos(np * xp) / Math.Pow(np, 2);
//    sum += t;
//    n++;
//}
//Console.WriteLine(sum);
//2
//int p = 1, n = 1;
//const int L = 30000;
//do
//{
//    n += 3;
//    p = p * n;
//} while (p <= L);
//Console.WriteLine("{0:f}", n);

//3
//int s = 0, n = 0, m;
//const int a = 5, h = 4, p = 65;
//do
//{
//    m = a + n * h;
//    s += m;
//    n += 1;
//} while (s <= p);
//Console.WriteLine("{0:d}", s);

//4
//double e = 0.0001;
//x = 0.9;
//s = 1;
//ks = 1;
//n = 0;
//while (ks >= e)
//{
//    n++;
//    ks *= x * x;
//    s += ks;
//}
//Console.WriteLine("2_4:\n{0}", s);
//Console.WriteLine();

//5
//int n = 9;
//int m = 4;
//int ch = 0;
//while (n >= m)
//{
//    n -= m;
//    ch++;
//}
//Console.Write("частное " + ch + ", остаток " + n);
//6
//int kl = 10;
//double kl_end = Math.Pow(10, 5);
//int h = 0;
//while (kl < kl_end)
//{
//    kl *= 2;
//    h += 3;
//}
//Console.WriteLine(h);
//7.1
//double s = 0.0, p = 10.0;
//int n = 0;
//do
//{
//    p = 1.1 * p;
//    s = s + p;
//    n += 1;
//} while (n < 7);
//Console.WriteLine("{o:f}", s);
//7.2
//double s = 0.0, p = 10.0;
//int n = 0;
//do
//{
//    p = 1.1 * p;
//    s = s + p;
//    n += 1;
//} while (s < 100);
//Console.WriteLine("{o:d}", n);
//7.3
//double s = 0.0, p = 10.0;
//int n = 0;
//do
//{
//    p = 1.1 * p;
//    s = s + p;
//    n += 1;
//} while (p < 20);
//Console.WriteLine("{0:f}", n);

//8
//double s = 10000.0;
//int n = 1;
//do
//{
//    s = s * 1.08;
//    n += 1;
//} while (s < 20000);
//Console.WriteLine("{0:d}", n);
