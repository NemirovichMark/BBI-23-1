using System;
namespace ConrolWork2;
//11 вариант
//1
/*
class Program
{
    static void Main ()
    {
        int[] array = { 1, -3, 5, 7, -9, 10, 6, 13 }; // Исходный массив

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int index = FindFirstNegativeIndex(array); // Находим индекс первого отрицательного элемента
        if (index != -1) // Если отрицательный элемент найден
        {
            RemoveElement(array, index); // Удаляем элемент из массива
            Console.WriteLine("Массив после удаления первого отрицательного элемента:");
            PrintArray(array);
        }
        else
        {
            Console.WriteLine("В массиве нет отрицательных элементов.");
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int FindFirstNegativeIndex(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                return i;
            }
        }
        return -1; // Если отрицательный элемент не найден
    }

    static void RemoveElement(int[] array, int index)
    {
        for (int i = index; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        Array.Resize(ref array, array.Length - 1);

    }
}
*/
//2
using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 2, 33, 3, 9 }; // Исходный массив

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minIndex = FindMinIndex(array); // Находим индекс минимального элемента
        int maxIndex = FindMaxIndex(array); // Находим индекс максимального элемента

        if (maxIndex != -1) // Если максимальный элемент найден
        {
            ReplaceElements(array, minIndex, maxIndex); // Заменяем элементы
            Console.WriteLine("Массив после замены элементов:");
            PrintArray(array);
        }
        else
        {
            Console.WriteLine("В массиве нет элементов.");
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int FindMinIndex(int[] array)
    {
        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }

    static int FindMaxIndex(int[] array)
    {
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    static void ReplaceElements(int[] array, int minIndex, int maxIndex)
    {
        int minElement = array[minIndex];
        for (int i = 0; i < maxIndex; i++)
        {
            array[i] = minElement;
        }
    }
}
