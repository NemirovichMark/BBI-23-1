// Version 2

#region 2.10
/*
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Введите, пожалуйста, элементы массива через пробел: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        // Преобразовываю строковые значения в целые числа
        int[] array = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            array[i] = int.Parse(inputArray[i]);
        }


        Deletemin(ref array);

        
        Console.WriteLine("Измененный массив: " + string.Join(" ", array));
    }

    static void Deletemin(ref int[] arr)
    {
        int indexmin = -1;
        int minpos = int.MaxValue;

        // Нахожу индекс и значение минимального положительного элемента
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0 && arr[i] < minpos)
            {
                minpos = arr[i];
                indexmin = i;
            }
        }

        // Если будет найден положительный элемент, удаляю его из массива
        if (indexmin != -1)
        {
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i != indexmin)
                {
                    newArr[j++] = arr[i];
                }
            }
            arr = newArr;
        }
    }
}
*/
#endregion



#region 2.11
/*
Console.WriteLine("Введите, пожалуйста, значение p:");

p = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите, пожалуйста, размер массива:");

b = Convert.ToInt32(Console.ReadLine());
arr = new double[b];
arr1 = new double[b + 1];
h = 0;
o = 0;

Console.WriteLine("Введите, пожалуйста элементы массива:");

for (int i = 0; i < arr.Length; i++)
{
    double a = Convert.ToDouble(Console.ReadLine());
    arr[i] = a;
    if (arr[i] > 0)
    {
        h = i;
        o = arr[i];
    }
}

for (int i = 0; i < arr.Length + 1; i++)
{
    if (i <= h)
    {
        arr1[i] = arr[i];
    }
    if (i == (h + 1))
    {
        arr1[i] = p;
    }
    if (i > (h + 1))
    {
        arr1[i] = arr[i - 1];
    }
}

Console.WriteLine("Результат:");
Console.WriteLine("[{0}]", string.Join("; ", arr1));
Console.WriteLine();
*/
#endregion



#region 2.12
/*
Console.WriteLine("Введите, пожалуйста, размер массива:");

b = Convert.ToInt32(Console.ReadLine());
arr = new double[b];
arr1 = new double[b + 1];
h = 0;
k = 0;
o = -Math.Pow(10, 20);
s = 0;
p = 0;

Console.WriteLine("Введите, пожалуйста, элементы массива:");

for (int i = 0; i < arr.Length; i++)
{
    double a = Convert.ToDouble(Console.ReadLine());
    arr[i] = a;
    if (arr[i] > o)
    {
        h = i;
        o = arr[i];
    }
}
for (int i = h + 1; i < arr.Length; i++)
{
    s += arr[i];
}
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        k = i;
        break;
    }
}
arr[k] = s;

Console.WriteLine("Результат:");
Console.WriteLine("[{0}]", string.Join("; ", arr));
Console.WriteLine();
*/
#endregion

#region 2.14
/*
Console.WriteLine("Введите, пожалуйста, размер массива:");

b = Convert.ToInt32(Console.ReadLine());
arr = new double[b];
h = 0;
k = 0;
o = -Math.Pow(10, 20);

Console.WriteLine("Введите, пожалуйста, элементы массива:");

for (int i = 0; i < arr.Length; i++)
{
    double a = Convert.ToDouble(Console.ReadLine());
    arr[i] = a;
    if (arr[i] > o)
    {
        h = i;
        o = arr[i];
    }
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        k = i;
        break;
    }
}
arr[h] = arr[k];
arr[k] = o;

Console.WriteLine("Результат:");
Console.WriteLine("[{0}]", string.Join("; ", arr));
Console.WriteLine();
*/
#endregion

#region 2.15
/*
Console.WriteLine("Введите, пожалуйста, размер массива A:");

b = Convert.ToInt32(Console.ReadLine());
arr = new double[b];

Console.WriteLine("Введите, пожалуйста, элементы массива A:");

for (int i = 0; i < arr.Length; i++)
{
    double a = Convert.ToDouble(Console.ReadLine());
    arr[i] = a;
}

Console.WriteLine("Введите, пожалуйста, размер массива B:");

b = Convert.ToInt32(Console.ReadLine());
arr1 = new double[b];
Console.WriteLine("Введите, пожалуйста, элементы массива B:");

for (int i = 0; i < arr1.Length; i++)
{
    double a = Convert.ToDouble(Console.ReadLine());
    arr1[i] = a;
}

Console.WriteLine("Введите, пожалуйста, значение k:");
int K = Convert.ToInt32(Console.ReadLine());
arr2 = new double[arr.Length + arr1.Length];
h = 0;
k = 0;
s = 0;
p = 0;

for (int i = 0; i < arr.Length + arr1.Length; i++)
{
    if (i <= K)
    {
        arr2[i] = arr[i];
    }
    if (i > K & i <= K + arr1.Length)
    {
        arr2[i] = arr1[i - K - 1];
    }
    if (i > K + arr1.Length)
    {
        arr2[i] = arr[i - arr1.Length - 1];
    }
}

Console.WriteLine("Результат:");
Console.WriteLine("[{0}]", string.Join("; ", arr2));
Console.WriteLine();
*/
#endregion

#region 2.17
/*
Console.WriteLine("Введите, пожалуйста, размер массива:");

b = Convert.ToInt32(Console.ReadLine());
arr = new double[b];
h = 0;
k = 0;
s = 0;
sr = 0;
q = 0;
o = Math.Pow(10, 20);
p = -Math.Pow(10, 20);

Console.WriteLine("Введите, пожалуйста, элементы массива:");

for (int i = 0; i < arr.Length; i++)
{
    double a = Convert.ToDouble(Console.ReadLine());
    arr[i] = a;
    if (arr[i] < o)
    {
        h = i;
        o = arr[i];
    }
    if (arr[i] > p)
    {
        k = i;
        p = arr[i];
    }
}
if (k < h)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            s += arr[i];
            q += 1;
        }
    }
    sr = s / q;
}
if (k > h)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            s += arr[i];
            q += 1;
        }
    }
    sr = s / q;
}

Console.WriteLine("Результат:");
Console.WriteLine(sr);
Console.WriteLine();
*/
#endregion

#region 3.2
/*
Console.WriteLine("Введите, пожалуйста, массив,элементы вводите через пробел:");

string line = Console.ReadLine();
string[] massiv = line.Split(' ');
double[] array = new double[massiv.Length];
double maximum = -1000000000;
double num = 1;

for (int i = 0; i < massiv.Length; i++)
{
    array[i] = double.Parse(massiv[i]);
    if (maximum < array[i])
    {
        maximum = array[i];
    }
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == maximum)
    {
        array[i] += num;
        num++;
    }
}

Console.WriteLine("Полученный массив:");
Console.WriteLine("[{0}]", string.Join(';', array));
Console.WriteLine();
*/
#endregion