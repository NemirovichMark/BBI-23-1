using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        #region 1-1
        //double s = 0;
        //double[] mas = new double[6];
        //Console.WriteLine("Введите элементы массива(6):");
        //for (int i = 0; i < mas.Length; i++)
        //{
        //    mas[i] = double.Parse(Console.ReadLine());
        //    s += mas[i];
        //}
        //Console.WriteLine("Полученный массив:");
        //for (int i = 0; i < mas.Length; i++)
        //{
        //    mas[i] = mas[i] / s;
        //}
        //Console.WriteLine("[{0}]", string.Join("; ", mas));
        //Console.WriteLine();
        #endregion

        #region 1 - 2
        //// Создаю массив размером 8
        //double[] arr = { 1, -2, 3, -4, 5, 6, 7, -8 };

        //// Считаю среднее арифметического среди положительных элементов
        //double sum = 0;
        //int count = 0;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] > 0)
        //    {
        //        sum += arr[i];
        //        count++;
        //    }
        //}

        //if (count > 0)
        //{
        //    double average = sum / count;

        //    // Заменяю положительные элементы на среднее арифметическое
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > 0)
        //        {
        //            arr[i] = average;
        //        }
        //    }
        //}

        //// Вывожу результат
        //Console.WriteLine("Массив после замены:");
        //foreach (var element in arr)
        //{
        //    Console.WriteLine(element);
        //}
        #endregion

        #region 1 - 3
        //// Прописываю два одномерных массива размера 4
        //int[] array1 = { 1, 2, 3, 4 };
        //int[] array2 = { 5, 6, 7, 8 };

        //// Создаю массивы для суммы и разности
        //int[] plusResult = new int[4];
        //int[] minusResult = new int[4];

        //// Вычисляю сумму и разность массивов
        //for (int i = 0; i < 4; i++)
        //{
        //    plusResult[i] = array1[i] + array2[i];
        //    minusResult[i] = array1[i] - array2[i];
        //}

        //Console.WriteLine("Сумма массивов:");
        //foreach (var item in plusResult)
        //{
        //    Console.Write(item + " ");
        //}

        //Console.WriteLine("\nРазность массивов:");
        //foreach (var item in minusResult)
        //{
        //    Console.Write(item + " ");
        //}
        #endregion

        #region 1 - 4
        //// Исходный массив размером 5
        //int[] array = { 1, 2, 3, 4, 5 };

        //// Найду среднее значение элементов массива
        //int sum = 0;
        //foreach (int num in array)
        //{
        //    sum += num;
        //}
        //int average = sum / array.Length;

        //// Преобразую исходный массив, вычитая из каждого элемента среднее значение
        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] -= average;
        //}

        //// Вывожу преобразованный массив
        //Console.WriteLine("Преобразованный массив:");
        //foreach (int num in array)
        //{
        //    Console.Write(num + " ");
        //}

        Console.ReadLine();
        #endregion

        #region 1 - 5
        //    int[] vector1 = { 1, 2, 3, 4 };
        //    int[] vector2 = { 5, 6, 7, 8 };

        //    if (vector1.Length != vector2.Length)
        //    {
        //        // Векторы должны иметь одинаковую длину для вычисления скалярного произведения.
        //        Console.WriteLine("Ошибка: векторы должны иметь одинаковую длину.");
        //    }
        //    else
        //    {
        //        int scalar = CalculateScalar(vector1, vector2);
        //        Console.WriteLine("Скалярное произведение векторов: " + scalar);
        //    }
        //}

        //static int CalculateScalar(int[] vector1, int[] vector2)
        //{
        //    int result = 0;
        //    for (int i = 0; i < vector1.Length; i++)
        //    {
        //        result += vector1[i] * vector2[i];
        //    }
        //    return result;
        #endregion

        #region 1 - 6
        //double[] vector = { 1.0, 2.0, 3.0, 4.0, 5.0 };

        //// Переменную sum использую для накопления суммы квадратов элементов вектора
        //double sum = 0.0;

        //for (int i = 0; i < vector.Length; i++)
        //{
        //    sum += vector[i] * vector[i];
        //}

        //double length = Math.Sqrt(sum);

        //Console.WriteLine("Длина вектора: " + length);
        #endregion

        #region 1 - 7
        //// Одномерный массив
        //double[] array = { 1.5, 2.7, 3.1, 4.8, 5.3, 6.2, 7.4 };

        //// Вычисляю среднее значение элементов массива
        //double sum = 0.0;
        //foreach (double value in array)
        //{
        //    sum += value;
        //}
        //double average = sum / array.Length;

        //// Прохожу по массиву и заменяем элементы, которые больше среднего значения, на 0
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > average)
        //    {
        //        array[i] = 0.0;
        //    }
        //}

        //// Вывожу измененный массив
        //Console.WriteLine("Измененный массив:");
        //foreach (double value in array)
        //{
        //    Console.WriteLine(value);
        //}
        #endregion

        #region 1 - 8
        //int[] arr = new int[6]; // Создаю массив размера 6 и заполняю его элементами
        //int count = 0; // Счетчик отрицательных элементов

        //// Человек заполняет массив arr какими-либо значениями, например, просто случайными числами для примера:
        //Random random = new Random();
        //for (int i = 0; i < 6; i++)
        //{
        //    arr[i] = random.Next(-10, 11); // заполняю массив случайными числами от -10 до 10
        //}

        //// Подсчитываю отрицательные элементы
        //for (int i = 0; i < 6; i++)
        //{
        //    if (arr[i] < 0)
        //    {
        //        count++;
        //    }
        //}

        //Console.WriteLine("Массив:");
        //for (int i = 0; i < 6; i++)
        //{
        //    Console.Write(arr[i] + " ");
        //}

        //Console.WriteLine("\nКоличество отрицательных элементов: " + count);
        #endregion

        #region 1 - 9
        //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 }; // Одномерный массив размера 8

        //// Вычисляю среднее значение
        //int sum = 0;
        //foreach (int item in array)
        //{
        //    sum += item;
        //}
        //double average = (double)sum / array.Length;

        //// Количество элементов, превышающих среднее значение
        //int count = 0;
        //foreach (int item in array)
        //{
        //    if (item > average)
        //    {
        //        count++;
        //    }
        //}

        //// Вывожу результат
        //Console.WriteLine($"Среднее значение: {average}");
        //Console.WriteLine($"Количество элементов больше среднего значения: {count}");
        #endregion

        #region 1 - 11
        //int[] originalArray = new int[] { -2, 5, 10, -3, 8, -1, 0, 7, -4, 2 };
        //int[] positiveArray = new int[10];
        //int positiveCount = 0;

        //for (int i = 0; i < originalArray.Length; i++)
        //{
        //    if (originalArray[i] > 0)
        //    {
        //        positiveArray[positiveCount] = originalArray[i];
        //        positiveCount++;
        //    }

        //    if (positiveCount == 10) // Если найдено 10 положительных чисел, завершаем цикл
        //        break;
        //}

        //// Вывожу массив положительных чисел
        //Console.WriteLine("Массив положительных чисел:");
        //for (int i = 0; i < positiveCount; i++)
        //{
        //    Console.Write(positiveArray[i] + " ");
        //}
        #endregion

        #region 1 - 12
        //int[] array = { 2, -3, 5, 7, -1, 0, -4, 8 };

        //int lastNegativeValue = 0;
        //int lastNegativeIndex = -1;

        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        lastNegativeValue = array[i];
        //        lastNegativeIndex = i;
        //    }
        //}

        //if (lastNegativeIndex != -1)
        //{
        //    Console.WriteLine($"Последний отрицательный элемент: {lastNegativeValue}");
        //    Console.WriteLine($"Номер последнего отрицательного элемента: {lastNegativeIndex}");
        //}
        //else
        //{
        //    Console.WriteLine("В массиве нет отрицательных элементов.");
        //}
        #endregion

        #region 1 - 13
        //static void Main()
        //{
        //    int[] originalArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    int[] evenArray = new int[5];
        //    int[] oddArray = new int[5];

        //    int evenIndex = 0;
        //    int oddIndex = 0;

        //    for (int i = 0; i < originalArray.Length; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            evenArray[evenIndex] = originalArray[i];
        //            evenIndex++;
        //        }
        //        else
        //        {
        //            oddArray[oddIndex] = originalArray[i];
        //            oddIndex++;
        //        }
        //    }

        //    Console.WriteLine("Массив с четными индексами:");
        //    PrintArray(evenArray);

        //    Console.WriteLine("Массив с нечетными индексами:");
        //    PrintArray(oddArray);
        //}

        //static void PrintArray(int[] array)
        //{
        //    foreach (var element in array)
        //    {
        //        Console.Write(element + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion
        #region 1 - 14
        //static void Main()
        //{
        //    int[] arr = { 2, 4, 5, -3, 6, 1, 8, -4, 9, 7, 10 };
        //    int sum = SumOfSquaresBeforeNegative(arr);
        //    Console.WriteLine("Сумма квадратов элементов до первого отрицательного: " + sum);
        //}

        //static int SumOfSquaresBeforeNegative(int[] array)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < 0)
        //        {
        //            break;
        //        }
        //        sum += array[i] * array[i];
        //    }

        //    return sum;
        //}

        #endregion

        #region 1 - 15
        //double[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //double[] y = new double[10];

        //for (int i = 0; i < 10; i++)
        //{
        //    y[i] = 0.5 * Math.Log(x[i]);
        //}

        //Console.WriteLine("x    |    y");
        //Console.WriteLine("------------");

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(x[i] + "    |    " + y[i]);
        //}
        #endregion

        #region 2 - 1
        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double minim = 1000000000;
        //int temporary = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        temporary = i;
        //    }
        //}

        //arr[temporary] = minim * 2;
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 2
        //double su = 0;

        //Console.WriteLine("Введите, пожалуйста, массив,элементы вводите через пробел:");

        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double maxim = -100000000000;
        //int temporary = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        temporary = i;
        //    }
        //}

        //for (int i = 0; i < temporary; i++)
        //{
        //    su += arr[i];
        //}

        //Console.WriteLine("Сумма до максимального элемента:");
        //Console.WriteLine(su);
        //Console.WriteLine();
        #endregion

        #region 2 - 3
        //Console.WriteLine("Введите, пожалуйста, массив,элементы вводите через пробел:");
        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double minim = 1000000000;
        //int temporary = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        temporary = i;
        //    }
        //}
        //for (int i = 0; i < temporary; i++)
        //{
        //    arr[i] = arr[i] * 2;
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 4
        //Console.WriteLine("Введите, пожалуйста, массив:");

        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double maxim = -100000000000;
        //double su = 0;
        //int temporary = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    su += arr[i];
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        temporary = i;
        //    }
        //}
        //su = su / arr.Length;
        //for (int i = temporary + 1; i < arr.Length; i++)
        //{
        //    arr[i] = su;
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 5
        //Console.WriteLine("Введите, пожалуйста, массив:");

        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double maxim = -100000000000;
        //double minim = 1000000000000;
        //double su = 0;
        //int temporary = 0;
        //double g = 0, t = 0;
        //int max2, min3;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    su += arr[i];
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        g = i;
        //    }
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        t = i;
        //    }
        //}

        //if (g > t)
        //{
        //    max2 = (int)g;
        //    min3 = (int)t;
        //}

        //else
        //{
        //    max2 = (int)t;
        //    min3 = (int)g;
        //}

        //for (int i = min3 + 1; i < max2; i++)
        //{
        //    if (arr[i] < 0)
        //    {
        //        temporary++;
        //    }
        //}
        //double[] arr1 = new double[temporary];
        //temporary = 0;

        //for (int i = min3 + 1; i < max2; i++)
        //{
        //    if (arr[i] < 0)
        //    {
        //        arr1[temporary] = arr[i];
        //        temporary++;
        //    }
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr1));
        //Console.WriteLine();
        #endregion

        #region 2 - 6
        //Console.WriteLine("Введите, пожалуйста, массив:");
        //string str = Console.ReadLine();
        //Console.WriteLine("Введите, пожалуйста, число P:");


        //double P = double.Parse(Console.ReadLine());
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double[] arr1 = new double[mass.Length + 1];
        //int temporary = 0;
        //double minim = 1000000000;
        //double su = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    su += arr[i];
        //}
        //su = su / arr.Length;
        //Console.WriteLine(su);

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    if (Math.Abs(su - arr[i]) <= minim)
        //    {
        //        minim = Math.Abs(su - arr[i]);
        //        temporary = i;
        //    }
        //}
        //arr1[temporary + 1] = P;

        //for (int i = 0; i < arr.Length + 1; i++)
        //{
        //    if (i < (temporary + 1))
        //    {
        //        arr1[i] = arr[i];
        //    }
        //    else if (i > (temporary + 1))
        //    {
        //        arr1[i] = arr[i - 1];
        //    }
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr1));
        //Console.WriteLine();
        #endregion

        #region 2 - 7
        //Console.WriteLine("Введите, пожалуйста, массив:");
        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double maxim = -10000000000;
        //double[] arr = new double[mass.Length];
        //int temporary = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        temporary = i;
        //    }
        //}
        //arr[temporary + 1] *= 2;

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 8
        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double maxim = -10000000000;
        //double minim = 10000000000;
        //double[] arr = new double[mass.Length];
        //int min2 = 0;
        //int max2 = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        max2 = i;
        //    }
        //}
        //for (int i = max2 + 1; i < mass.Length; i++)
        //{
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        min2 = i;
        //    }
        //}

        //arr[max2] = minim;
        //arr[min2] = maxim;

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 9
        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double maxim = -10000000000;
        //double minim = 10000000000;
        //double[] arr = new double[mass.Length];
        //int minnn = 0;
        //int maxxx = 0;
        //int v = 0;
        //int g = 0;
        //double su = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        maxxx = i;
        //    }
        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        minnn = i;
        //    }
        //}

        //if (minnn < maxxx)
        //{
        //    v = minnn;
        //    g = maxxx;
        //}

        //else
        //{
        //    v = maxxx;
        //    g = minnn;
        //}

        //for (int i = v + 1; i < g; i++)
        //{
        //    su += arr[i];
        //}
        //su = su / (g - v - 1);

        //Console.WriteLine("Среднее арифметическое значение между минимальным и максимальным элементами:");
        //Console.WriteLine(su);
        //Console.WriteLine();
        #endregion

        #region 2 - 10
        //double[] a = new double[] { -1, -2, -3, -4, -5, -6 };
        //double min = 1000000;
        //for (int i = 0; i < a.Length; i++)
        //{
        //    if (a[i] < min)
        //    {
        //        min = a[i];
        //    }
        //}
        //Console.WriteLine("Мин знач: ");
        //Console.WriteLine(min);
        //Console.WriteLine("Изначальный массив: ");
        //for (int q = 0; q < a.Length; q++)
        //{
        //    Console.Write("{0:f} ", a[q]);
        //}
        //Console.WriteLine("");
        //Console.WriteLine("Итоговый массив: ");
        //for (int i = 0; i < a.Length; i++)
        //{
        //    if (a[i] != min) Console.Write("{0:f} ", a[i]);
        //}
        //Console.WriteLine();
        #endregion

        #region 2 - 11
        //Console.Write("Введите P: ");
        //double p = Double.Parse(Console.ReadLine());
        //double[] a = new double[] { -1, -2, -3, -4, -5, -6 };
        //double index = a[0];
        //for (int i = 0; i < a.Length; i++)
        //{
        //    if (a[i] > 0)
        //    {
        //        index = i;
        //    }
        //}
        //Console.WriteLine("Итоговый массив: ");
        //for (int i = 0; i < a.Length; i++)
        //{
        //    Console.Write("{0:f0} ", a[i]);
        //    if (i == index) Console.Write("{0:f0} ", p);
        //}
        #endregion

        #region 2 - 12
        //Console.WriteLine("2-12:");
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //str = Console.ReadLine();
        //mass = str.Split(' ');
        //arr = new double[mass.Length];
        //minim = 1000000000;
        //maxim = -100000000000;
        //maxxx = 0;
        //temporary = -1;
        //su = 0;
        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (arr[i] > maxim)
        //    {
        //        maxim = arr[i];
        //        maxxx = i;
        //    }
        //    if (temporary == -1 && arr[i] < 0)
        //    {
        //        temporary = i;
        //    }
        //}
        //for (int i = maxxx + 1; i < mass.Length; i++)
        //{
        //    su += arr[i];
        //}
        //arr[temporary] = su;
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 13
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //str = Console.ReadLine();
        //mass = str.Split(' ');
        //arr = new double[mass.Length];
        //minim = 1000000000;
        //maxim = -10000000000;
        //temporary = 0;
        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (i % 2 == 0 && arr[i] > maxim)
        //    {
        //        maxim = arr[i];
        //        temporary = i;
        //    }
        //}
        //arr[temporary] = temporary;
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 14
        //Console.WriteLine("Введите массив,элементы вводите через пробел:");
        //str = Console.ReadLine();
        //mass = str.Split(' ');
        //arr = new double[mass.Length];
        //minim = 1000000000;
        //maxim = -10000000000;
        //temporary = -1;
        //su = 0;
        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (arr[i] > maxim)
        //    {
        //        maxim = arr[i];
        //        maxxx = i;
        //    }
        //    if (temporary == -1 && arr[i] < 0)
        //    {
        //        temporary = i;
        //        su = arr[i];
        //    }
        //}
        //arr[temporary] = maxim;
        //arr[maxxx] = su;
        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 15
        //int n = (int)Double.Parse(Console.ReadLine());

        //Console.WriteLine("Введите, пожалуйста, размер массивa B:");

        //int m = (int)Double.Parse(Console.ReadLine());
        //double[] A = new double[n];
        //double[] B = new double[m];
        //double[] C = new double[n + m];

        //Console.WriteLine("Введите, пожалуйста, k:");
        //int k = (int)Double.Parse(Console.ReadLine());
        //Console.WriteLine("Введите, пожалуйста, масив A:");

        //for (int i = 0; i < n; i++)
        //{
        //    A[i] = double.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Введите, пожалуйста, массив B:");

        //for (int j = 0; j < m; j++)
        //{
        //    B[j] = double.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < C.Length; i++)
        //{
        //    if (i <= k)
        //    {
        //        C[i] = A[i];
        //    }
        //    if (i > k && i <= (k + m))
        //    {
        //        C[i] = B[i - k - 1];
        //    }
        //    if (i > (k + m))
        //    {
        //        C[i] = A[i - k - m + 2];
        //    }
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', C));
        //Console.WriteLine();
        #endregion

        #region 2 - 16
        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double su = 0;
        //int temporary = 0;
        //int al = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    su += arr[i];
        //}
        //su = su / arr.Length;

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] < su)
        //    {
        //        temporary++;
        //    }
        //}
        //double[] massivnew = new double[temporary];

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] < su)
        //    {
        //        massivnew[al] = i;
        //        al++;
        //    }
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', massivnew));
        Console.WriteLine();
        #endregion

        #region 2 - 17
        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double minim = 1000000000;
        //double maxim = -1000000000;
        //int max2 = 0;
        //int min2 = 0;
        //int temporary = 0;
        //double su = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);

        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        max2 = i;
        //    }

        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        min2 = i;
        //    }
        //}

        //if (max2 < min2)
        //{

        //    for (int i = 0; i < mass.Length; i++)
        //    {

        //        if (arr[i] > 0)
        //        {
        //            su += arr[i];
        //            temporary++;
        //        }
        //    }
        //}

        //else
        //{
        //    for (int i = 0; i < mass.Length; i++)
        //    {
        //        if (arr[i] < 0)
        //        {
        //            su += arr[i];
        //            temporary++;
        //        }
        //    }
        //}
        //su = su / temporary;

        //Console.WriteLine("Среднее арифметичсекое:");
        //Console.WriteLine(su);
        //Console.WriteLine();
        #endregion

        #region 2 - 18
        //str = Console.ReadLine();
        //mass = str.Split(' ');
        //arr = new double[mass.Length];
        //double maxim1 = -1000000000;
        //double maxim2 = -1000000000;
        //int chet = 0;
        //int nechet = 0;
        //temporary = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (maxim1 < arr[i] && (i % 2 == 0))
        //    {
        //        maxim1 = arr[i];
        //        chet = i;
        //    }
        //    if (maxim2 < arr[i] && (i % 2 != 0))
        //    {
        //        maxim2 = arr[i];
        //        nechet = i;
        //    }
        //}

        //if (maxim1 > maxim2)
        //{
        //    for (int i = 0; i < mass.Length / 2; i++)
        //    {
        //        arr[i] = 0;
        //    }
        //}

        //else
        //{
        //    for (int i = mass.Length / 2; i < mass.Length; i++)
        //    {
        //        arr[i] = 0;
        //    }
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 19
        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double maxim = -1000000000;
        //int temporary = 0;
        //double su = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);
        //    if (maxim < arr[i])
        //    {
        //        maxim = arr[i];
        //        temporary = i;
        //    }
        //}

        //if (maxim > su)
        //{
        //    arr[temporary] = 0;
        //}
        //else
        //{
        //    arr[temporary] *= 2;
        //}

        //Console.WriteLine("Полученный массив:");
        //Console.WriteLine("[{0}]", string.Join(';', arr));
        //Console.WriteLine();
        #endregion

        #region 2 - 20
        //string str = Console.ReadLine();
        //string[] mass = str.Split(' ');
        //double[] arr = new double[mass.Length];
        //double minim = 1000000000;
        //int temporary = -1;
        //double min2 = 0;
        //double su = 0;

        //for (int i = 0; i < mass.Length; i++)
        //{
        //    arr[i] = double.Parse(mass[i]);

        //    if (minim > arr[i])
        //    {
        //        minim = arr[i];
        //        min2 = i;
        //    }
        //    if (temporary == -1 && arr[i] < 0)
        //    {
        //        temporary = i;
        //    }
        //}

        //if (temporary < min2)
        //{

        //    for (int i = 0; i < mass.Length; i += 2)
        //    {
        //        su += arr[i];
        //    }
        //}

        //else
        //{

        //    for (int i = 1; i < mass.Length; i += 2)
        //    {
        //        su += arr[i];
        //    }
        //}

        //Console.WriteLine("Сумма:");
        //Console.WriteLine(su);
        //Console.WriteLine();
        #endregion

        #region 3  - 1
        //// Мой пример массива
        //int[] array = { -2, 6, 23, 8, 7, 9, -8, -10 };

        //// Поиск максимальных элементов и их индексов
        //int maxElement = int.MinValue;
        //int[] maxIndices = new int[array.Length];
        //int count = 0;

        //for (int i = 0; i < array.Length; i++)
        //{
        //    int currentElement = array[i];

        //    if (currentElement > maxElement)
        //    {
        //        // Типо найден новый максимальный элемент, обновляем информацию
        //        maxElement = currentElement;
        //        count = 1;
        //        maxIndices[0] = i;
        //    }
        //    else if (currentElement == maxElement)
        //    {
        //        // Типо найден элемент равный текущему максимальному
        //        // Добавляем его индекс к массиву
        //        maxIndices[count] = i;
        //        count++;
        //    }
        //}

        //// Формирую массив из индексов максимальных элементов
        //int[] resultIndices = new int[count];
        //Array.Copy(maxIndices, resultIndices, count);

        //// Вывожу результаты
        //Console.WriteLine("Максимальный элемент: " + maxElement);
        //Console.WriteLine("Индексы максимальных элементов: " + string.Join(", ", resultIndices));
        #endregion

        #region 3 - 2
        // Мой пример массива
    //    int[] array = { 3, 7, 1, 9, 5, 2 };

    //    // Нахожу максимальный элемент и его индекс
    //    int maxElement = array[0];
    //    int maxIndex = 0;

    //    for (int i = 1; i < array.Length; i++)
    //    {
    //        if (array[i] > maxElement)
    //        {
    //            maxElement = array[i];
    //            maxIndex = i;
    //        }
    //    }

    //    // Увеличиваю максимальные элементы на их порядковые номера
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        if (i == maxIndex)
    //        {
    //            array[i] += maxIndex + 1;
    //        }
    //    }

    //    // Вывожу результат
    //    Console.WriteLine("Исходный массив:");
    //    PrintArray(array);

    //    Console.ReadLine();
    //}

    //// Создала метод, который будет выводить массив на экран
    //static void PrintArray(int[] arr)
    //{
    //    foreach (var item in arr)
    //    {
    //        Console.Write(item + " ");
    //    }
    //    Console.WriteLine();
        #endregion
    }
}