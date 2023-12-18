using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace laba_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.5
            //Определить значение и номер первого отрицательного элемента заданного столбца матрицы А размера 5 × 4.

            //Console.WriteLine("1.5:");

            //int[,] array = new int[5, 4];

            //Console.WriteLine("Enter array with size 5x4: "); //array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //Console.WriteLine("\nInitial array:"); //initial array output
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {

            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int firstNegativeElement = 0;
            //int countEl = 0;

            //for (int i = 0; i < array.GetLength(0); i++) //parsing to find first negative element
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        countEl++;
            //        if (array[i, j] < 0)
            //        {
            //            firstNegativeElement = array[i, j];
            //        }
            //        break;
            //    }
            //}

            //if (firstNegativeElement == 0)
            //{
            //    Console.WriteLine("\nThere're no negative elements in the array!");//the inputted array has no negative elements
            //}
            //else
            //{
            //    Console.WriteLine($"\nThe first negative element is: {firstNegativeElement}. It's number: {countEl}"); //task's output 
            //}
            #endregion


            #region 1.9
            ////Поменять местами максимальный и 1-й элементы строк матрицы А размера 5 × 7

            //Console.WriteLine("1.9:");

            //int[,] array = new int[5, 7];

            //Console.WriteLine("Enter array with size 5x7: "); //array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //for (int i = 0; i < array.GetLength(0); i++) //parsing 
            //{
            //    int maxEl = 0;
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] > array[i,maxEl]) // biggest element in the line 
            //        {
            //            maxEl = j;
            //        }
            //    }
            //    int temp = array[i, 0]; //swapping
            //    array[i, 0] = array[i,maxEl];
            //    array[i, maxEl] = temp;
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {

            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 1.13
            ////В матрице А размера 5 × 5 поменять местами 4-й столбец со столбцом, содержащим максимальный элемент на диагонали.

            //Console.WriteLine("1.13:");

            //int[,] array = new int[5, 5];

            //Console.WriteLine("Enter array with size 5x5: "); //array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //int indexMaxEl = 0;

            //for (int i = 0; i < array.GetLength(0); i++) //parsing for biggest element on the main diagonal
            //{
            //    if (array[i, i] > array[indexMaxEl, indexMaxEl])
            //    {
            //        indexMaxEl = i;
            //    }
            //}

            //int temp = 0;

            //for (int j = 0; j < array.GetLength(1); j++) //swapping
            //{
            //    temp = array[j, indexMaxEl];
            //    array[j, indexMaxEl] = array[j, 3];
            //    array[j, 3] = temp;
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {

            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 1.17
            ////В каждой строке матрицы В размера n × m минимальный элемент поместить в начало строки, сохранив порядок остальных элементов.

            //Console.WriteLine("1.17:");

            //Console.Write("Enter the amount of lines: "); //initialization of i and j for the array
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the amount of columnes: ");
            //int m = Convert.ToInt32(Console.ReadLine());

            //int[,] array = new int[n, m];

            //Console.WriteLine($"Enter array with size {n}x{m}: "); //array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    int minInLine = 0;

            //    for (int j = 0; j < array.GetLength(1); j++)//parsing index of min el
            //    {
            //        if (array[i, j] < array[i, minInLine])
            //        {
            //            minInLine = j;
            //        }
            //    }
            //    int minValue = array[i, minInLine]; //remembering value of min el

            //    for (int k = minInLine; k > 0; k--) //moving el before min el one place forward
            //    {
            //        int temp = array[i, k - 1];
            //        array[i, k - 1] = array[i, k];
            //        array[i, k] = temp;
            //    }

            //    array[i, 0] = minValue; // moving min el to the first place in line  
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {

            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 1.21
            //В матрице Н размера 5 × 7 заполнены первые 6 столбцов. Поместить в качестве
            //предпоследнего столбца столбец, состоящий из максимальных элементов строк.

            //Console.WriteLine("1.21:");

            //int[,] array = new int[5, 6];

            //Console.WriteLine("Enter array with size 5x6: "); //array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //int[,] tempArray = new int[5, 7]; //enlargement of the array

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        tempArray[i, j] = array[i, j];
            //    }
            //}

            //array = tempArray; //array now 5x7

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    array[i, 6] = array[i, 5]; //moving column one place forward to place column of max els

            //    int maxInLine = 0;

            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] > array[i, maxInLine]) //finding max el in each line
            //        {
            //            maxInLine = j;
            //        }
            //    }
            //    array[i,5] = array[i,maxInLine]; //making additional column of max els
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {

            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 1.25
            //В матрице X размера 6 × 5 поменять местами строки, содержащие минимальное и
            //максимальное число отрицательных элементов.

            //Console.WriteLine("1.25:");

            //int[,] array = new int[6, 5];

            //Console.WriteLine("Enter array with size 6x5: "); //array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //int maxAmountOfNegativeEl = 0;
            //int minAmountOfNegativeEl = int.MaxValue;

            //int lineWithMaxNeg = 0;
            //int lineWithMinNeg = 0;


            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    int AmountOfNegativeEl = 0;
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] < 0)
            //        {
            //            AmountOfNegativeEl++;
            //        }
            //    }
            //    if (AmountOfNegativeEl > maxAmountOfNegativeEl) //finding max amount of neg el in line
            //    {
            //        maxAmountOfNegativeEl = AmountOfNegativeEl;
            //        lineWithMaxNeg = i;
            //    }
            //    if (AmountOfNegativeEl < minAmountOfNegativeEl) //finding min amount of neg el in line
            //    {
            //        minAmountOfNegativeEl = AmountOfNegativeEl;
            //        lineWithMinNeg = i;
            //    }
            //}

            //int temp = 0;

            //for (int j = 0; j < array.GetLength(1); j++) //swapping lines
            //{
            //    temp = array[lineWithMaxNeg, j];
            //    array[lineWithMaxNeg, j] = array[lineWithMinNeg, j];
            //    array[lineWithMinNeg, j] = temp;

            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {

            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 1.29
            //В матрице F размера 5 × 7 удалить столбец, расположенный после столбца, содержащего минимальный по модулю элемент во 2 - й строке.

            //Console.WriteLine("1.29:");

            //int[,] array = new int[5, 7];

            //Console.WriteLine("Enter array with size 5x7: "); //array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //int minInSecondLine = int.MaxValue;
            //int minElIndex = 0;

            //for (int i = 0; i < array.GetLength(0); i++) //finding min element in 2 line and remembering it's index
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (Math.Sqrt(Math.Pow(array[1, j], 2)) < minInSecondLine)
            //        {
            //            minInSecondLine = array[1, j];
            //            minElIndex = j;
            //        }
            //    }
            //}

            //for (int i = 0; i < array.GetLength(0); i++) //turning column after min el in line 2 to 0
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, minElIndex + 1] = 0;
            //    }
            //}

            //for (int i = 0; i < array.GetLength(0); i++) //moving els after min el in line 2 one place backwards
            //{
            //    int k = minElIndex;
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (j == (k + 1) + 1 && k != 7)
            //        {
            //            array[i, j - 1] = array[i, j];
            //            k++;
            //        }
            //    }
            //}

            //int[,] arrayminus = new int[5, 6];

            //for (int i = 0; i < arrayminus.GetLength(0); i++) //making array have no column after min el in line 2
            //{
            //    for (int j = 0; j < arrayminus.GetLength(1); j++)
            //    {
            //        arrayminus[i, j] = array[i, j];
            //    }
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < arrayminus.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayminus.GetLength(1); j++)
            //    {

            //        Console.Write(arrayminus[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 1.33
            //Сформировать одномерный массив из отрицательных элементов матрицы А размера 5 × 7

            //Console.WriteLine("1.33:");

            //int[,] array = new int[5, 7];

            //Console.WriteLine("Enter array with size 5x7: "); //array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //int counterOfNegEls = 0;

            //for (int i = 0; i < array.GetLength(0); i++) //counting the amount of negative elements to form an array with this length
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] < 0)
            //        {
            //            counterOfNegEls++;
            //        }
            //    }
            //}

            //int[] lineOfNegEls = new int[counterOfNegEls];

            //int n = 0;

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] < 0)
            //        {
            //            lineOfNegEls[n] = array[i, j];
            //            n++;
            //        }
            //    }
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < lineOfNegEls.GetLength(0); i++)
            //{
            //        Console.Write(lineOfNegEls[i] + " ");
            //}
            #endregion


            #region 2.4
            //Дана матрица A размера 7 × 5 и массив B размера 5.Заменить максимальный элемент
            //столбца соответствующим элементом массива B, если этот элемент больше
            //найденного максимального элемента столбца. В противном случае замены не
            //производить.

            //Console.WriteLine("2.4: ");

            //int[,] arrayA = new int[7, 5];

            //Console.WriteLine("Enter array with size 7x5: "); //array A input
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //Console.WriteLine("Enter array B with 5 elements: "); //array B input
            //string inputLineB = Console.ReadLine();
            //string[] linesB = inputLineB.Split(' ');
            //int[] arrayB = new int[linesB.Length];
            //for (int i = 0; i < linesB.Length; i++)
            //{
            //    arrayB[i] = int.Parse(linesB[i]);
            //}


            //int indJ = 0;

            //for (int column = 0; column < 5; column++) // cycle of checks for every column
            //{
            //    int maxElInColumn = int.MinValue;
            //    int indexOfMaxElInCol = 0;
            //    int indexI = 0;
            //    int n = 0;

            //    for (int i = 0; i < arrayA.GetLength(0); i++) //finding the biggest el in column
            //    {
            //        for (int j = 0; j < arrayA.GetLength(1); j++)
            //        {
            //            if (arrayA[i, indJ] > maxElInColumn)
            //            {
            //                maxElInColumn = arrayA[i, indJ];
            //                indexOfMaxElInCol = indexI;
            //            }
            //        }
            //        indexI++;
            //    }

            //    for (int i = 0; i < arrayA.GetLength(0); i++) //swapping biggest el in col
            //    {
            //        for (int j = 0; j < arrayA.GetLength(1); j++)
            //        {
            //            if (arrayB[n] > arrayA[indexOfMaxElInCol, indJ])
            //            {
            //                arrayA[indexOfMaxElInCol, indJ] = arrayB[n];
            //            }
            //        }
            //    }
            //    indJ++; //next column
            //    n++; //next el in array B
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        Console.Write(arrayA[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 2.8
            //В матрице В размера 6 × 6 поменять местами максимальные элементы 1-й и 2-й строк, 3 - й и 4 - й, 5 - й и 6 - й.

            //Console.WriteLine("2.8: ");

            //int[,] arrayA = new int[6, 6];

            //Console.WriteLine("Enter array with size 6x6: "); //array  input
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //int temp = 0;
            //int line = 0;

            //for (int linesPairs = 0; linesPairs < arrayA.GetLength(0) / 2; linesPairs++) //find biggest el in pair of lines and swap them with each other
            //{
            //    int indexMaxInLine1 = 0;
            //    int indexMaxInLine2 = 0;

            //    int maxElInLine1 = int.MinValue;
            //    int maxElInLine2 = int.MinValue;

            //    for (int i = 0; i < arrayA.GetLength(0); i++) // finding biggest el in lines pair
            //    {

            //        for (int j = 0; j < arrayA.GetLength(1); j++)
            //        {
            //            if (arrayA[line, j] > maxElInLine1) //max el in line 1
            //            {
            //                maxElInLine1 = arrayA[line, j];
            //                indexMaxInLine1 = j;
            //            }
            //            if (arrayA[line + 1, j] > maxElInLine2) //max el in line 2
            //            {
            //                maxElInLine2 = arrayA[line + 1, j];
            //                indexMaxInLine2 = j;
            //            }
            //        }
            //    }

            //    for (int i = 0; i < arrayA.GetLength(0); i++) //swapping
            //    {
            //        for (int j = 0; j < arrayA.GetLength(1); j++)
            //        {
            //            arrayA[line + 1, indexMaxInLine2] = maxElInLine1;
            //            arrayA[line, indexMaxInLine1] = maxElInLine2;
            //        }
            //    }

            //    line += 2;
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        Console.Write(arrayA[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 3.8
            //В матрице размера 7 × 5 переставить строки таким образом, чтобы количества
            //положительных элементов в строках следовали в порядке убывания.

            //Console.WriteLine("3.8:");

            //int[,] array = new int[7, 5];

            //Console.WriteLine("Enter array with size 7x5: "); //initial array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //for (int i = 0; i < array.GetLength(0) - 1; i++) //parsing lines one by one 
            //{
            //    int indexOfLineMaxAmount = 0;
            //    int counterWithMaxAmount = 0;

            //    for (int j = i; j < array.GetLength(0); j++) // j = i - not to parse lines that are sorted 
            //    {
            //        int tempCounterWithmaxAmount = 0;

            //        for (int k = 0; k < array.GetLength(1); k++)
            //        {
            //            if (array[j, k] > 0) // counting positive elements 
            //            {
            //                tempCounterWithmaxAmount++;
            //            }
            //        }

            //        if (counterWithMaxAmount < tempCounterWithmaxAmount) //find the most amount of posi els in line tween lines that are left
            //        {
            //            counterWithMaxAmount = tempCounterWithmaxAmount;
            //            indexOfLineMaxAmount = j;
            //        }
            //    }

            //    int[] line = new int[array.GetLength(1)];
            //    for (int j = 0; j < array.GetLength(1); j++) //sorting by descend  
            //    {
            //        line[j] = array[i, j];
            //        array[i, j] = array[indexOfLineMaxAmount, j];
            //        array[indexOfLineMaxAmount, j] = line[j];
            //    }
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 3.3
            //Для квадратной матрицы размера n  n просуммировать элементы, расположенные
            //на диагоналях, параллельных главной, включая главную диагональ. Результат получить в виде вектора размера 2n – 1.

            //Console.WriteLine("3.9:");


            //Console.WriteLine("Enter n (size of the squared matrix)");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[,] array = new int[n, n];

            //Console.WriteLine($"Enter array with size {n}x{n}: "); //initial array input
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //int[] answerSumm = new int[2 * array.GetLength(0) - 1]; 

            //for (int i = 0; i < n; i++) //calculating summs of diagonals 
            //{
            //    int sum = 0;
            //    int sumSimmetr = 0;

            //    for (int j = 0; j <= i; j++)
            //    {
            //        sum += array[n - 1 - i + j, j];
            //        sumSimmetr += array[j, n - 1 - j];
            //    }

            //    answerSumm[i] = sum;
            //    answerSumm[answerSumm.Length - i - 1] = sumSimmetr;
            //}

            //Console.WriteLine("Matrix diagonals summary: {0}", string.Join("; ", answerSumm)); //vector output
            #endregion


            #region 3.1
            //В матрице размера 7 × 5 переставить строки таким образом, чтобы минимальные 
            //элементы строк следовали в порядке убывания.

            //Console.WriteLine("3.1:");

            //int[,] arrayA = new int[7, 5];

            //Console.WriteLine("Enter array with size 7x5: "); //array A input
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    string inputLine = Console.ReadLine();
            //    string[] lines = inputLine.Split(' ');
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(lines[j]);
            //    }
            //}

            //int[] minEls = new int[arrayA.GetLength(0)];
            //int[] minIndexes = new int[arrayA.GetLength(0)];

            //for (int i = 0; i < arrayA.GetLength(0); i++) //finding min els in every line 
            //{
            //    int minEl = arrayA[i, 0];
            //    int minIndex = 0;

            //    for (int j = 1; j < arrayA.GetLength(1); j++) //finding min el
            //    {
            //        if (arrayA[i, j] < minEl)
            //        {
            //            minEl = arrayA[i, j];
            //            minIndex = j;
            //        }
            //    }

            //    minEls[i] = minEl;
            //    minIndexes[i] = minIndex;
            //}

            //for (int i = 0; i < arrayA.GetLength(0) - 1; i++) //swapping array's lines
            //{
            //    for (int j = i + 1; j < arrayA.GetLength(0); j++)
            //    {
            //        if (minEls[j] < minEls[i])
            //        {
            //            int tempEl = minEls[i]; //swapping tween els
            //            minEls[i] = minEls[j];
            //            minEls[j] = tempEl;

            //            for (int k = 0; k < arrayA.GetLength(1); k++) //swapping tween lines
            //            {
            //                int temp = arrayA[i, k];
            //                arrayA[i, k] = arrayA[j, k];
            //                arrayA[j, k] = temp;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Eventual array:"); //eventual array output
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        Console.Write(arrayA[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            Console.ReadKey();
        }
    }
}