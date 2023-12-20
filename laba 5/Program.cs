using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 5
            //Поменять местами строки матриц А размера 4 × 6 и В размера 6 × 6, содержащие
            //максимальные элементы в 1 - м столбце. Поиск максимального элемента в заданном
            //столбце матрицы осуществить в методе.

            //Console.WriteLine("Task 5: ");

            //int[,] arrayA = new int[4, 6]; //array A input
            //Console.WriteLine("Enter array A with size 4x6: ");
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    string inputLineA = Console.ReadLine();
            //    string[] linesA = inputLineA.Split(' ');
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(linesA[j]);
            //    }
            //}

            //int[,] arrayB = new int[6, 6]; //array B input
            //Console.WriteLine("Enter array B with size 6x6: ");
            //for (int i = 0; i < arrayB.GetLength(0); i++)
            //{
            //    string inputLineB = Console.ReadLine();
            //    string[] linesB = inputLineB.Split(' ');
            //    for (int j = 0; j < arrayB.GetLength(1); j++)
            //    {
            //        arrayB[i, j] = Convert.ToInt32(linesB[j]);
            //    }
            //}

            //int maxElIndA = FindMax(arrayA); //finding max el in 1 column for array A

            //int maxElIndB = FindMax(arrayB); //finding max el in 1 column for array B

            //for (int j = 0; j < 6; j++) //swapping lines of arrays A and B
            //{

            //    int temp = arrayA[maxElIndA, j];
            //    arrayA[maxElIndA, j] = arrayB[maxElIndB, j];
            //    arrayB[maxElIndB, j] = temp;
            //}

            //Console.WriteLine("Eventual array A:"); //eventual array A output
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        Console.Write(arrayA[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Eventual array B:"); //eventual array B output
            //for (int i = 0; i < arrayB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayB.GetLength(1); j++)
            //    {
            //        Console.Write(arrayB[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region task 11
            //В двух заданных матрицах найти максимальные элементы и поменять их местами.
            //Поиск максимального элемента матрицы оформить в виде метода.

            //Console.WriteLine("Task 11: ");

            //Console.WriteLine("Enter amount of lines for array A(n): "); //array A input
            //int nA = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter amount of columns for array A(m): ");
            //int mA = Convert.ToInt32(Console.ReadLine());

            //int[,] arrayA = new int[nA, mA];
            //Console.WriteLine($"Enter array A with size {nA} x {mA}: ");
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    string inputLineA = Console.ReadLine();
            //    string[] linesA = inputLineA.Split(' ');
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(linesA[j]);
            //    }
            //}

            //Console.WriteLine("Enter amount of lines for array B(n): "); //array B input
            //int nB = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter amount of columns for array B(m): ");
            //int mB = Convert.ToInt32(Console.ReadLine());

            //int[,] arrayB = new int[nB, mB];

            //Console.WriteLine($"Enter array B with size {nB} x {mB}: ");
            //for (int i = 0; i < arrayB.GetLength(0); i++)
            //{
            //    string inputLineB = Console.ReadLine();
            //    string[] linesB = inputLineB.Split(' ');
            //    for (int j = 0; j < arrayB.GetLength(1); j++)
            //    {
            //        arrayB[i, j] = Convert.ToInt32(linesB[j]);
            //    }
            //}

            //int arrayAMax = 0; int arrayAI = 0; int arrayAJ = 0; //finding biggest el and it's indecies in array A
            //FindMaxEl(arrayA, ref arrayAI, ref arrayAJ, ref arrayAMax);

            //int arrayBMax = 0; int arrayBI = 0; int arrayBJ = 0; //finding biggest el and it's indecies in array B
            //FindMaxEl(arrayB, ref arrayBI, ref arrayBJ, ref arrayBMax);

            //arrayA[arrayAI, arrayAJ] = arrayBMax; //swapping
            //arrayB[arrayBI, arrayBJ] = arrayAMax;

            //Console.WriteLine("Eventual array A:"); //eventual array A output
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        Console.Write(arrayA[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Eventual array B:"); //eventual array B output
            //for (int i = 0; i < arrayB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayB.GetLength(1); j++)
            //    {
            //        Console.Write(arrayB[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region task 17
            //В двух заданных матрицах расположить строки в порядке убывания их
            //максимальных элементов. Упорядочение строк матрицы оформить в виде метода.

            //Console.WriteLine("Task 17: ");

            //Console.WriteLine("Enter amount of lines for array A(n): "); //array A input
            //int nA = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter amount of columns for array A(m): ");
            //int mA = Convert.ToInt32(Console.ReadLine());

            //int[,] arrayA = new int[nA, mA];
            //Console.WriteLine($"Enter array A with size {nA} x {mA}: ");
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    string inputLineA = Console.ReadLine();
            //    string[] linesA = inputLineA.Split(' ');
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(linesA[j]);
            //    }
            //}

            //Console.WriteLine("Enter amount of lines for array B(n): "); //array B input
            //int nB = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter amount of columns for array B(m): ");
            //int mB = Convert.ToInt32(Console.ReadLine());

            //int[,] arrayB = new int[nB, mB];

            //Console.WriteLine($"Enter array B with size {nB} x {mB}: ");
            //for (int i = 0; i < arrayB.GetLength(0); i++)
            //{
            //    string inputLineB = Console.ReadLine();
            //    string[] linesB = inputLineB.Split(' ');
            //    for (int j = 0; j < arrayB.GetLength(1); j++)
            //    {
            //        arrayB[i, j] = Convert.ToInt32(linesB[j]);
            //    }
            //}

            //SortArray(arrayA);
            //SortArray(arrayB);  

            //Console.WriteLine("Eventual array A:"); //eventual array A output
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        Console.Write(arrayA[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Eventual array B:"); //eventual array B output
            //for (int i = 0; i < arrayB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayB.GetLength(1); j++)
            //    {
            //        Console.Write(arrayB[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region task 23
            //В двух заданных матрицах по пять наибольших элементов увеличить вдвое,
            //остальные вдвое уменьшить.Преобразование матрицы оформить в виде метода.

            //Console.WriteLine("Task 23: ");

            //Console.WriteLine("Enter amount of lines for array A(n): "); //array A input
            //int nA = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter amount of columns for array A(m): ");
            //int mA = Convert.ToInt32(Console.ReadLine());

            //int[,] arrayA = new int[nA, mA];
            //Console.WriteLine($"Enter array A with size {nA} x {mA}: ");
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    string inputLineA = Console.ReadLine();
            //    string[] linesA = inputLineA.Split(' ');
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(linesA[j]);
            //    }
            //}

            //Console.WriteLine("Enter amount of lines for array B(n): "); //array B input
            //int nB = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter amount of columns for array B(m): ");
            //int mB = Convert.ToInt32(Console.ReadLine());

            //int[,] arrayB = new int[nB, mB];

            //Console.WriteLine($"Enter array B with size {nB} x {mB}: ");
            //for (int i = 0; i < arrayB.GetLength(0); i++)
            //{
            //    string inputLineB = Console.ReadLine();
            //    string[] linesB = inputLineB.Split(' ');
            //    for (int j = 0; j < arrayB.GetLength(1); j++)
            //    {
            //        arrayB[i, j] = Convert.ToInt32(linesB[j]);
            //    }
            //}

            //ArrayTransform(arrayA); //transforming array A

            //ArrayTransform(arrayB); //transforming array B

            //Console.WriteLine("Eventual array A:"); //eventual array A output
            //for (int i = 0; i < arrayA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayA.GetLength(1); j++)
            //    {
            //        Console.Write(arrayA[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Eventual array B:"); //eventual array B output
            //for (int i = 0; i < arrayB.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrayB.GetLength(1); j++)
            //    {
            //        Console.Write(arrayB[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            Console.ReadKey();
        }
        static int FindMax(int[,] inputArray) //Method to find max el in 1 column of both arrays(task 5)
        {
            int maxEl = int.MinValue;
            int maxElIndex = 0;
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                if (inputArray[i, 0] > maxEl)
                {
                    maxEl = inputArray[i, 0];
                    maxElIndex = i;
                }
            }
            return maxElIndex;
        }
        static void FindMaxEl(int[,] inputArray, ref int maxeli, ref int maxelj, ref int maxElem) //method for finding max el in whole array(task 11)
        {
            maxElem = int.MinValue;
            maxeli = 0;
            maxelj = 0;

            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    if (inputArray[i, j] > maxElem)
                    {
                        maxElem = inputArray[i, j];
                        maxeli = i;
                        maxelj = j;
                    }
                }
            }
        }
        static int NewFindMax(int[,] matrix, int iInd) //method to find max el in line (task 17)
        {
            int maxMax = int.MinValue;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[iInd, j] > maxMax)
                {
                    maxMax = matrix[iInd, j];
                }
            }

            return maxMax;
        }
        static void SortArray(int[,] matrix) //method for sorting lines in arrays (task 17)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int ii = 0; ii < matrix.GetLength(0); ii++)
                {
                    int lineWithMaxEl = NewFindMax(matrix, i);
                    int lineWithMaxEl2 = NewFindMax(matrix, ii);

                    if (lineWithMaxEl < lineWithMaxEl2)
                    {
                        for (int k = 0; k < matrix.GetLength(1); k++)
                        {
                            int temp = matrix[lineWithMaxEl, k];
                            matrix[lineWithMaxEl, k] = matrix[lineWithMaxEl2, k];
                            matrix[lineWithMaxEl2, k] = temp;
                        }
                    }
                }
            }
        }
        static void ArrayTransform(int[,] matrix) //method to transform matrix (task 23)
        {
            int[] tempArray = new int[5]; // 

            for (int i = 0; i < 5; i++) //finding and keeping 5 biggest elements
            {
                int maxElll = int.MinValue;
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] > maxElll)
                    {
                        maxElll = matrix[i, j];
                    }
                }
                tempArray[i] = maxElll;
            }

            for (int i = 0; i < 5; i++) //transforming matrix 
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Array.Exists(tempArray, element => element == matrix[i, j])) //(googled this System c# method).
                                                                                     //if present element is located
                                                                                     //in array that contains 5 biggest elements in matrix, then:
                    {
                        matrix[i, j] *= 2; //present element is multiplied by two
                    }
                    else
                    {
                        matrix[i, j] /= 2; //present element is not in the array with biggest elements and it's divided by 2
                    }
                }
            }
        }
    }
}