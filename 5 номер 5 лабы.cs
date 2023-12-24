using System;
namespace project
{
    class Project
    {
        static int FindMax(int[,] inputArray) 
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
        static void Main(int[,] a, int strok, int stolb)
        {
            Console.WriteLine("Task 5: ");

            int[,] arrayA = new int[4, 6];
            Console.WriteLine("Enter array A with size 4x6: ");
            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                string inputLineA = Console.ReadLine();
                string[] linesA = inputLineA.Split(' ');
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    arrayA[i, j] = Convert.ToInt32(linesA[j]);
                }
            }

            int[,] arrayB = new int[6, 6]; 
            Console.WriteLine("Enter array B with size 6x6: ");
            for (int i = 0; i < arrayB.GetLength(0); i++)
            {
                string inputLineB = Console.ReadLine();
                string[] linesB = inputLineB.Split(' ');
                for (int j = 0; j < arrayB.GetLength(1); j++)
                {
                    arrayB[i, j] = Convert.ToInt32(linesB[j]);
                }
            }

            int maxElIndA = FindMax(arrayA); 

            int maxElIndB = FindMax(arrayB);

            for (int j = 0; j < 6; j++) 
            {

                int temp = arrayA[maxElIndA, j];
                arrayA[maxElIndA, j] = arrayB[maxElIndB, j];
                arrayB[maxElIndB, j] = temp;
            }

            Console.WriteLine("Eventual array A:");
            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    Console.Write(arrayA[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Eventual array B:"); 
            for (int i = 0; i < arrayB.GetLength(0); i++)
            {
                for (int j = 0; j < arrayB.GetLength(1); j++)
                {
                    Console.Write(arrayB[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}