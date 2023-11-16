#region 1.1
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

Console.WriteLine("1.1");
double[] a = new double[6];
double sum = 0;
for (int i = 0; i < 6; i++)
{
    Console.Write($"Введите эдемент массива {i + 1}: ");
    a[i] = Double.Parse(Console.ReadLine());
    sum += a[i];
}
Console.WriteLine("Изменённый массив: ");
for (int i = 0; i < 6; i++)
{
    a[i] /= sum;
    Console.Write(a[i] + " ");
}
Console.WriteLine();
#endregion

#region 1.2
a = new double[8];
sum = 0;
double n = 0;
for (int i = 0; i < 8; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > 0)
    {
        sum += a[i];
        n++;
    }
}
Console.WriteLine("Изменённый массив: ");
for (int i = 0; i < 8; i++)
{
    if (a[i] > 0)
    {
        a[i] /= (sum / n);

    }
    Console.Write(a[i] + " ");
}
Console.WriteLine();
#endregion

#region 1.3
Console.WriteLine("1.3");
a = new double[4];
double[] b = new double[4];
double[] c = new double[4];
Console.WriteLine("Разность");
for (int i = 0; i < 4; i++)
{
    Console.Write($"Введите элемент массива a {i + 1}");
    a[i] = double.Parse(Console.ReadLine());
    Console.Write($"Введите элемент массива b {i + 1}");
    b[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < 4; i++)
{
    c[i] = a[i] - b[i];
    Console.Write(c[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Сумма");
for (int i = 0; i < 4; i++)
{
    c[i] = a[i] + b[i];
    Console.Write(c[i] + " ");
}
Console.WriteLine();
#endregion

#region 1.4
Console.WriteLine("1.4");
a = new double[5];
double sr = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    sr += a[i];
}
sr /= 5;
Console.WriteLine("Изменённый массив: ");
for (int i = 0; i < 5; i++)
{
    a[i] -= sr;
    Console.Write(a[i] + " ");
}
Console.WriteLine();
#endregion

#region 1.5
Console.WriteLine("1.5:");
a = new double[4];
b = new double[4];
sum = 0;
Console.WriteLine("Введите попарно элементы первого и второго массива");
for (int i = 0; i < a.Length; i++)
{
    a[i] = double.Parse(Console.ReadLine());
    b[i] = double.Parse(Console.ReadLine());
    sum += a[i] * b[i];
}
Console.WriteLine($"Скалярное произведение: {sum}");
Console.WriteLine();
#endregion

#region 1.6
Console.WriteLine("1.6:");
a = new double[5];
sum = 0;
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"Введите значение вектора {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    sum += a[i] * a[i];
}
sum = Math.Sqrt(sum);
Console.WriteLine($"Длина вектора:{sum}");
Console.WriteLine();
#endregion

#region 1.7
Console.WriteLine("1.7");
a = new double[7];
sr = 0;
for (int i = 0; i < 7; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    sr += a[i];
}
sr /= a.Length;
Console.WriteLine("Массив, в котором элементы большие среднего значения элементов массива, заменены на 0: ");
for (int i = 0; i < 7; i++)
{
    if (a[i] > sr)
    {
        a[i] = 0;
    }
    Console.Write(a[i] + " ");
}
Console.WriteLine();
#endregion

#region 1.8
Console.WriteLine("1.8");
a = new double[6];
n = 0;
for (int i = 0; i < 6; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] < 0)
    {
        n++;
    }
}
Console.WriteLine();
#endregion

#region 1.9
Console.WriteLine("1.9");
a = new double[8];
sr = 0;
n = 0;
for (int i = 0; i < 8; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    sr += a[i];
}
sr /= a.Length;
for (int i = 0; i < 8; i++)
{
    if (a[i] > sr)
    {
        n++;
    }
}
Console.WriteLine($"Количество элементов, больших среднего значения элементов массива: {n}");
Console.WriteLine();
#endregion

#region 1.10
Console.WriteLine("1.10");
a = new double[10];
Console.WriteLine("Введите значение P: ");
double P = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение Q: ");
double Q = double.Parse(Console.ReadLine());
n = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (P > Q && a[i] > Q && a[i] < P)
    { n++; }
    if (P < Q && a[i] > P && a[i] < Q)
    { n++; }
}
Console.WriteLine($"Количество элементов, расположенных на числовой прямой между P и Q: {n}");
Console.WriteLine();
#endregion

#region 1.11
Console.WriteLine("1.11");
a = new double[10];
int k = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > 0)
    {
        k++;
    }
}
b = new double[k];
Console.WriteLine("Новый массив b, созданный из положительных элементов массива а: ");
for (int i = 0; i < 10; i++)
{
    if (a[i] > 0)
    {
        b[i] = a[i];
        Console.Write(b[i] + " ");
    }
}
Console.WriteLine();
#endregion

#region 1.12
Console.WriteLine("1.12");
a = new double[8];
double o = 0;
n = 0;
for (int i = 0; i < 8; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] < 0)
    {
        o = a[i];
        n = i + 1;
    }
}
Console.WriteLine($"Номер последнего отрицательного элемента: {n}. Значение последнего отрицательного элемента массива: {o}");
Console.WriteLine();
#endregion

#region 1.13
Console.WriteLine("1.13");
a = new double[10];
b = new double[5];
c = new double[5];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        b[i] = a[i];
    }
    else
    {
        c[i] = a[i];
    }

}
Console.WriteLine("Массив b:");
for (int i = 0; i < 5; i++)
{
    Console.Write(b[i] + " ");
}
Console.WriteLine("Массив с:");
for (int i = 0; i < 5; i++)
{
    Console.Write(c[i] + " ");
}
Console.WriteLine();
#endregion

#region 1.14
Console.WriteLine("1.14");
a = new double[11];
sum = 0;
for (int i = 0; i < 11; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    if (a[i] >= 0)
    {
        sum += a[i] * a[i];
    }
    else
    { break; }
}
Console.WriteLine($"Сумма квадратов:{sum}");
Console.WriteLine();

#endregion

#region 1.15
Console.WriteLine("1.15");
double[] x = new double[10];
for (int i = 0; i <= 10; i++)
{
    Console.Write("Введите значение x");
    x[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("x   y");
for (int i = 0; i < 10; i++)
{
    double y = 0.5 * Math.Log(x[i]);
    Console.WriteLine("{0}   {1}", x[i], y);
}
Console.WriteLine();
#endregion

#region 2.1
Console.WriteLine("2.1");
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());
a = new double[size];
int imin = 0;
double r = 100000000000000000;
for (int i = 0; i < size; i++)
{
    Console.Write("Введите значение элемента массива:");
    a[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < size; i++)
{
    if (a[i] < r)
    {
        imin = i;
        r = a[i];
    }
}
a[imin] = a[imin] * 2;
Console.WriteLine($"Минимальный элемент массива, увеличенный в 2 раза: {a[imin]}");
Console.WriteLine();
#endregion

#region 2.2
Console.WriteLine("Введите длину массива:");
size = int.Parse(Console.ReadLine());
a = new double[size];
sum = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < size; i++)
{
    if (a[i] > 0)
    {
        sum += a[i];
    }
    else
    {
        break;
    }
}
Console.WriteLine($"Сумма элементов, расположенных после максимального элемента массива: {sum}");
Console.WriteLine();
#endregion

#region 2.3
Console.WriteLine("2.3");
Console.WriteLine("Введите длину массива:");
size = int.Parse(Console.ReadLine());
a = new double[size];
imin = 0;
double amin = a[0];
for (int i = 0; i < size; i++)
{
    Console.Write("Введите элемент массива");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] < amin)
    {
        amin = a[i];
        imin = i;
    }

}
for (int i = 0; i < imin; i++)
{
    a[i] *= 2;
}
Console.WriteLine("Изменённый массив, в которов элементы, расположеные перед минимальным элементом, увеличены в 2 раза");
for (int i = 0; i < size; i++)
{
    Console.Write(a[i] + " ");
}
Console.WriteLine();

#endregion

#region 2.4
Console.WriteLine("Введите длину массива:");
size = int.Parse(Console.ReadLine());
a = new double[size];
int imax = 0;
double amax = -1000000000000000;
sum = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    sum += a[i];
}
for (int i = 0; i < size; i++)
{
    if (a[i] > amax) { amax = a[i]; imax = i; }
}
sum /= size;
for (int i = imax + 1; i < size; i++)
{
    a[i] = sum;
}
Console.WriteLine();
#endregion

#region 2.5
Console.WriteLine("2.5");
Console.WriteLine("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
amax = a[0];
amin = a[0];
int w = 0;
r = 0; // индекс масимального элемента
double p = 0; //индекс минимального элемента
int max, min;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > amax)
    {
        amax = a[i];
        r = i;
    }
    if (a[i] < amin)
    {
        amin = a[i];
        p = i;
    }
}
if (r > p)
{
    max = (int)r; min = (int)p;
}
else
{
    max = (int)p; min = (int)r;
}
for (int i = min + 1; i < max; i++)
{
    if (a[i] < 0) { w++; }
}
b = new double[w];
w = 0;
for (int i = min + 1; i < max; i++)
{
    if (a[i] < 0)
    {
        b[w] = a[i];
        w++;
    }
}
Console.WriteLine();
#endregion

#region 2.6
Console.WriteLine("2.6");
Console.WriteLine("Введите число P:");
double L = double.Parse(Console.ReadLine());
min = 1000000000;
Console.WriteLine("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
b = new double[size + 1];
int l = 0;
double minn = 1000000000;
sum = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите эелмент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    sum += a[i];
}
sum /= a.Length;
Console.WriteLine(sum);
for (int i = 0; i < size; i++)
{
    if (Math.Abs(sum - a[i]) <= minn)
    {
        minn = Math.Abs(sum - a[i]);
        l = i;
    }
}
b[l + 1] = L;
for (int i = 0; i < size + 1; i++)
{
    if (i < (p + 1))
    {
        b[i] = a[i];
    }
    else if (i > (p + 1))
    {
        b[i] = a[i - 1];
    }
}
Console.WriteLine("Полученный массив:");
for (int i = 0; i < size; i++)
{
    Console.Write(b[i] + " ");
}
Console.WriteLine();
#endregion

#region 2.7
Console.WriteLine("2.7");
Console.WriteLine("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
imax = 0;
amax = a[0];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите элемент массива {i + 1}");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > amax)
    {
        amax = a[i];
        imax = i;
    }
}
a[imax + 1] *= 2;
Console.WriteLine("Изменённый массив: ");
for (int i = 0; i < size; i++)
{
    Console.Write(a[i] + " ");
}
Console.WriteLine();
#endregion

#region 2.8
Console.WriteLine("2.8");
Console.WriteLine("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
imax = 0;
imin = 0;
amax = a[0];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > amax)
    {
        amax = a[i];
        imax = i;
    }
}
amin = a[imax + 1];
for (int i = imax + 1; i < size; i++)
{
    if (a[i] < amin)
    {
        amin = a[i];
        imin = i;
    }
}
double t = a[imax];
a[imax] = a[imin];
a[imin] = t;
Console.WriteLine("Изменённый массив: ");
for (int i = 0; i < size; i++) { Console.Write(a[i] + " "); }
Console.WriteLine();
#endregion

#region 2.9
Console.WriteLine("2.9");
Console.WriteLine("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
amin = a[0];
amax = a[0];
imin = 0;
amax = 0;
t = 0; p = 0;
sum = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите эдемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] < amin) { amin = a[i]; imin = i; }
    if (a[i] > amax) { amax = a[i]; imax = i; }
}
if (imin > imax)
{
    p = imin;
    t = imax;
}
else
{
    p = imax; t = imin;
}
for (int i = (int)p + 1; i < t; i++)
{
    sum += a[i];
}
sum /= t - p - 1;
Console.WriteLine($"Среднее арифметическое элементов массива, расположенных между максимальным и минимальным элементами: {sum}");
Console.WriteLine();
#endregion

#region 2.10
Console.WriteLine("2.10");
Console.Write("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
int k = 0;//счетчик положительных элементов массива
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = int.Parse(Console.ReadLine());
}
double amin = a[0];
for (int i = 0; i < size; i++)
{
    if (a[i] > 0)
    {
        k++;
        if (a[i] < amin)
        {
            amin = a[i];
        }
    }
}
for (int i = 0; i < size; i++)
{
    if (a[i] == amin)
    {
        for (int j = i; j < size - 1; j++)
        {
            a[j] = a[j + 1];
        }
        size--;
        break;
    }
}
if (k > 0)
{
    Console.WriteLine("Массив после удаления минимального положительного элемента:");
    for (int i = 0; i < size; i++)
    {
        Console.Write(a[i] + " ");
    }
}
if (k == 0)
{
    Console.WriteLine("В массиве нет положительных элементов.");
}
Console.WriteLine();
#endregion

#region 2.11
Console.WriteLine("2.1");
Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());
double[] a = new double[size];
int k = 0; //Счетчик положительных элементов
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > 0)
    {
        k++;
    }
}
if (k > 0)
{
    int r = 0;//Индекс последнего положительного элемента
    Console.Write("Введите значение Р: ");
    double P = double.Parse(Console.ReadLine());
    for (int i = size - 1; i >= 0; i--)
    {
        if (a[i] > 0) { r = i; break; }
    }

    for (int i = size - 2; i > r; i--) { a[i + 1] = a[i]; }
    a[r + 1] = P;
    Console.WriteLine("Изменённый массив, после добавления Р:");
    foreach (double x in a) { Console.Write(x + " "); }
    Console.WriteLine();
}
if (k == 0)
{
    Console.WriteLine("В массиве отсутствуют положительные элементы.");
}
Console.WriteLine();
#endregion


#region 2.12
Console.WriteLine("2.12");
Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()); ;
double[] a = new double[size];
int k = 0;//счетчик отрицательных элементов
double amax = a[0];
int imax = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] < 0) { k++; }
    if (a[i] > amax) { amax = a[i]; imax = i; }
}
if (k > 0 && imax == size - 1)
{
     Console.WriteLine("Невозможно посчитать сумму чисел после максимального элемента, т.к. он в конце массива.");
}
if (k > 0 && imax != size - 1)
{
    int iot = 0;//индекс первого отрицательного элемента
    double sum = 0;
    for (int i = 0;i < size;i++)
    {
        if (a[i] < 0) { iot = i; break; }
    }
    for (int i = imax + 1;i < size;i++)
    {
        sum += a[i];
    }
    a[iot] = sum;
    Console.WriteLine("Изменённый массив: ");
    foreach (double x in a)
    {
        Console.Write(x + " ");
    }
}
if (k == 0)
{
    Console.WriteLine("Отрицательные элементы отсутствуют");
}
Console.WriteLine();
#endregion

#region 2.13
Console.WriteLine("2.13");
Console.Write("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
imax = 0;//идекс максимального элемента среди чётных индексов
amax = a[0];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите значение элемента {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > amax && i % 2 == 0) { amax = a[i]; imax = i; }
}
Console.WriteLine($"Значение максимального элемента с четным индеком {0} и его индекс {1}", a[imax], imax);
a[imax] = (double)imax;
Console.WriteLine("Изменённый массив: ");
for (int i = 0; i < size; i++)
{
    Console.Write(a[i] + " ");
}
Console.WriteLine();
#endregion

#region 2.14
Console.WriteLine("2.14");
Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());
double[] a = new double[size];
int k = 0; // счетчик отрицательных элементов
double amax = a[0];
int imax = 0;
for (int i = 0; i < size; i ++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > amax ) { amax = a[i]; imax = i; }
    if (a[i] < 0) { k++; }
}
if (k == 0)
{
    Console.WriteLine("Отсутствуют отрицательные элементы.");
}
if (k > 0)
{
    int iot = 0; //индекс первого отрицательного элемента
    for (int i = 0; i < size; i++)
    {
        if (a[i] < 0) { iot = i; break; }
    }
    double h = a[imax];
    a[imax] = a[iot];
    a[iot] = h;
    Console.WriteLine("Изменённый массив: ");
    foreach (double x in  a) { Console.Write(x + " "); }
}
Console.WriteLine();
#endregion

#region 2.15
Console.WriteLine("2.15");
Console.Write("Введите длину массива А: ");
int n = int.Parse(Console.ReadLine());
double[] a = new double[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите элемент массива А {i + 1} :");
    a[i] = double.Parse(Console.ReadLine());
}
Console.Write("Введите длину массива B: ");
int m = int.Parse(Console.ReadLine());
double[] b = new double[m];
for (int i = 0;i < m; i++)
{
    Console.Write($"Введите элемент массива В {i + 1}: ");
    b[i] = double.Parse(Console.ReadLine());
}
double[] c = new double[m + n];
Console.Write("Введите К: ");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Полученный массив: ");
for (int i = 0;i < m + n; i++)
{
    if (i <= k)
    {
        c[i] = a[i];
    }
    if (i > k && i <= (k + m)) 
    {
        c[i] = b[i - k - 1];
    }
    if (i > k && i > (k + m))
    {
        c[i] = a[i - m - k + 1];
    }
    Console.Write(c[i] + " ");
}
#endregion

#region 2.16
Console.WriteLine("2.16");
Console.Write("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
k = 0; //счетчик для измерения нового массива
sum = 0;
for (int i = 0;i < size;i++)
{
    Console.Write($"Введите значение элемента {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    sum += a[i];
}
sum /= size;
for (int i = 0; i < size; i++)
{
    if (a[i] < sum)
    { k++; }
}
b = new double[k];
int h = 0;
for (int i = 0; i < size; i++)
{
    if (a[i] < sum) {b[h] = i; h++; }
}
Console.WriteLine("Индексы элементов массива, меньших среднего: ");
for (int i = 0; i < k; i++)
{
    Console.Write(b[i] + " ");
}
Console.WriteLine();
#endregion

#region 2.17
Console.WriteLine("2.17");
Console.Write("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
imin = 0;
imax = 0;
amax = a[0];
amin = a[0];
double sum1 = 0;
double sum2 = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите значение элемента {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > amax) { amax = a[i]; imax = i; }
    if (a[i] < amin) { amin = a[i]; imin = i; }
}
if (imin < imax)
{
    for(int i = 0;i < size; i++)
    {
        if (a[i] < 0)
        { sum1 += a[i]; }
    }
    Console.WriteLine($"Минимальный элемент расположен до максимального. Сумма отрицательный элементов равна {sum1}");
}
if (imax < imin)
{
    for (int i = 0;i < size; i++)
    {
        if (a[i] > 0) { sum2 += a[i]; }
    }
    Console.WriteLine($"Максимальный элемент расположен до минимального. Сумма положительных элементов равна {sum2}");
}
Console.WriteLine();
#endregion

#region 2.18
Console.WriteLine("2.18");
Console.Write("Введите чётную длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
double maxch = a[0];
double maxn = a[1];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (i % 2 == 0 && a[i] > maxch)
    {
        maxch = a[i];
    }
    else if (i % 2 == 1 && a[i] > maxn)
    {
        maxn = a[i];
    }
}
if (maxch > maxn)
{
    for (int i = 0; i < size/2; i++)
    {
        a[i] = 0;
    }
}
else
{
    for(int i = size/2; i< size; i++)
    {
        a[i] = 0;
    }
}
Console.WriteLine("Получившийся массив:");
for (int i = 0;i < size;i++)
{
    Console.Write(a[i] + " ");
}
Console.WriteLine();
#endregion

#region 2.19
Console.WriteLine("2.19");
Console.Write("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
amax = a[0];
imax = 0;
sum = 0;
for (int i = 0;i < size;i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    sum += a[i];
    if (a[i] > amax)
    {
        amax = a[i];
        imax = i;
    }
}
sum -= amax;
Console.WriteLine($"Максимальный элемент массива {amax} и его индекс {imax}.");
if (sum > amax)
{
    amax *= 2;
}
else;
{
    amax = 0;
}
a[imax] = amax;
Console.WriteLine("Изменённый массив: ");
for (int i = 0; i < size;i++)
{
    Console.Write(a[i] + " ");
}
Console.WriteLine();
#endregion

#region 2.20
Console.WriteLine("2.20");
Console.Write("Введите длину массива: ");
size = int.Parse(Console.ReadLine());
a = new double[size];
imin = 0;
amin = 0;
k = 0; //индекс первого отрицательного элемента
for (int i = 0; i < size;i++)
{
    Console.Write($"Введите элемент массива {i + 1}");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] < amin)
    {
        amin = a[i];
        imin = i;
    }
}
for (int i = 0; i < size; i++)
{
    if (a[i] < 0) { k = i; break; }
}
sum1 = 0;
sum2 = 0;
if (imin > k)
{
    for (int i = 0; i < size; i+=2)
    {
        sum1 += a[i];
    }
    Console.WriteLine($"Первый отрицательный элемент расположен до минимального элемента. Сумма элементов с чётными индексами равна {sum1}.");
}
else
{
    for (int i = 1; i < size; i+=2)
    {
        sum2 += a[i];
    }
    Console.WriteLine($"Первый отрицательный элемент расположен после минимального элемента. Сумма элементов с нечётными индексами равна {sum2}.");
}
Console.WriteLine();
#endregion

#region 3.2
Console.WriteLine("3.2");
Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());
double [] a = new double[size];
double amax = -100000000000000000;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
    if (a[i] > amax)
    {
        amax = a[i];
    }
}
Console.WriteLine("Изменённый массив: ");
for (int i = 0; i < size; i++)
{
    if (a[i] == amax) { a[i] += i + 1; }
    Console.Write(a[i] + " ");
}
Console.WriteLine();
#endregion

#region 3.6
Console.WriteLine("3.6");
Console.Write("Введите длинну массива: ");
int size = int.Parse(Console.ReadLine());
double[] a = new double[size];
int k = 1;
int maxx = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    a[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < size - 1; i++)
{
    if (a[i] == a[i] && a[i] > a[i + 1]) { k++; maxx = Math.Max(maxx, k); }
    else { k = 1; }
}
Console.WriteLine($"Максимальное количество элементов, упорядоченных по убыванию: {maxx}");
Console.WriteLine();
#endregion
