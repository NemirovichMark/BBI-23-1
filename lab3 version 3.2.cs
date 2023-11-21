#region 2.11
Console.WriteLine("Введите, пожалуйста, число p ");
p = double.Parse(Console.ReadLine());
Console.WriteLine("Введите, пожалуйста, размер массива ");
k = int.Parse(Console.ReadLine());
a = new double[k + 1];
ok = true;
Console.WriteLine("Введите, пожалуйста, элементы массива, записывая каждый элемент в очередную строку");
for (int i = 0; i < k; i++)
{

    string s1 = Console.ReadLine();
    a[i] = double.Parse(s1);
}
Console.Write("Исходный массив: ");
for (int i = 0; i < k; i++)
{
    Console.Write("{0} ", a[i]);
}
int ip = k - 1;
Console.WriteLine();
while ((ip >= 0) && (a[ip] <= 0)) ip -= 1;
if (ip == -1) ok = false;
if (ok == false) Console.WriteLine("нет положительных элементов");
else
{
    Console.Write("Встав п после послед + эл: ");
    for (int i = k - 1; i >= ip + 1; i--)
    {
        a[i + 1] = a[i];
    }
    a[ip + 1] = p;
    for (int i = 0; i < k + 1; i++)
    {
        Console.Write("{0} ", a[i]);
    }
}
#endregion
Console.WriteLine();

#region 2.14
Console.WriteLine("Введите, пожалуйста, размер массива ");
k = int.Parse(Console.ReadLine());
io = 0;
imax = 0;
ok = true;
a = new double[k];
Console.WriteLine("Введите, пожалуйста, элементы массива, записывая каждый элемент в очередную строку");
for (int i = 0; i < k; i++)
{
    string s1 = Console.ReadLine();
    a[i] = double.Parse(s1);
    if (a[i] > a[imax]) imax = i;
}
Console.Write("Исходный массив: ");
for (int i = 0; i < k; i++)
{
    Console.Write("{0} ", a[i]);
}
Console.WriteLine();
while ((io < k) && (a[io] >= 0)) io += 1;
if (io == k) ok = false;
if (ok == false) Console.WriteLine("нет отрицательных элементов");
else
{
    c = a[imax]; a[imax] = a[io]; a[io] = c;
    Console.Write("Помен мест макс и 1й отриц эл: ");
    for (int i = 0; i < k; i++)
    {
        Console.Write("{0} ", a[i]);
    }
}
#endregion
Console.WriteLine();

#region 2.17 
Console.WriteLine("Введите размер массива");
n1 = int.Parse(Console.ReadLine());
a1 = new double[n1];
imax = 0;
imin = 0;
double sp = 0;
double so = 0;
ko = 0; kp = 0;
for (int i = 0; i < n1; i++)
{
    a1[i] = double.Parse(Console.ReadLine());
}
Console.Write("Исходный массив: ");
for (int i = 0; i < n1; i++)
{
    Console.Write("{0} ", a1[i]);
    if (a1[i] < a1[imin]) imin = i;
    if (a1[i] > a1[imax]) imax = i;
    if (a1[i] > 0)
    {
        sp += a1[i];
        kp++;
    }
    if (a1[i] < 0)
    {
        so += a1[i];
        ko++;
    }
}
Console.WriteLine();
if (imin < imax)
{
    if (ko != 0)
    {
        double otv = so / ko;
        Console.WriteLine("Ср арифм отрицательных чисел: {0}", otv);
    }
    else Console.WriteLine("Нет отрицательных чисел");
}
else
{
    if (kp != 0)
    {
        double otv = sp / kp;
        Console.WriteLine("Ср арифм положительных чисел: {0}", otv);
    }
    else Console.WriteLine("Нет положительных чисел");
}
Console.WriteLine();
#endregion
