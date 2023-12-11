// See https://aka.ms/new-console-template for more information
Console.WriteLine("порядковый номер 9");





#region 1.2
Console.WriteLine("");
int[,] matrix = new int[5, 7]
        {
            { 1, -2, 3, -4, 5, -6, 7 },
            { -8, 9, -10, 11, -12, 13, -14 },
            { 15, -16, 17, -18, 19, -20, 21 },
            { -22, 23, -24, 25, -26, 27, -28 },
            { 29, -30, 31, -32, 33, -34, 35 }
        };
int n = 5, m = 7;
        int sum = 0;
        int count = 0;

        for (int i = 0; i <n ; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > 0)
                {
                    sum += matrix[i, j];
                    count++;
                }
            }
        }

       
        double average = (double)sum / count;

        
        Console.WriteLine("среднее среди положительных элементов матрицы: " + average);


#endregion
#region 1.6
Console.WriteLine("");
matrix = new int[4, 7] {
            {-3, 7, 2, 8, 5, 9, 1},
            {4, 6, 2, 9, 1, 5, 3},
            {9, 2, 6, 4, 8, 1, 7},
            {5, 3, 1, 7, 9, 2, 6}
        };

int[] minInd = new int[4];

for (int i = 0; i < 4; i++)
{
    int minI = 0;
    int minV = matrix[i, 0];

    for (int j = 1; j < 7; j++)
    {
        if (matrix[i, j] < minV)
        {
            minV = matrix[i, j];
            minI = j;
        }
    }

    minInd[i] = minI;
}

Console.WriteLine("Минимальные индексы в каждой строке:");
Console.WriteLine("[{0}]", string.Join(';', minInd));
#endregion

#region
Console.WriteLine("1.10");
 matrix = new int[5, 7] {
            {3, 7, 2, 8, 5, 9, 1},
            {4, 6, 2, 9, 1, 5, 3},
            {9, 2, 6, 4, 8, 1, 7},
            {5, 3, 1, 7, 9, 2, 6},
            {2, 4, 7, 1, 3, 5, 8}
        };

int maxI = matrix[0, 2];
int maxR = 0;
for (int i = 1; i < 5; i++)
{
    if (matrix[i, 2] > maxI)
    {
        maxI = matrix[i, 2];
        maxR = i;
    }
}


for (int j = 0; j < 7; j++)
{
    int temp = matrix[3, j];
    matrix[3, j] = matrix[maxR, j];
    matrix[maxR, j] = temp;
}

Console.WriteLine("Матрица после замены строк:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


#endregion

#region
Console.WriteLine("1.14");
matrix = new int[4, 3] {
            {3, -7, 2},
            {-4, 6, -2},
            {9, 2, -6},
            {-5, 3, 1}
        };

int[] neG = new int[3];
for (int j = 0; j < 3; j++)
{
     count = 0;
    for (int i = 0; i < 4; i++)
    {
        if (matrix[i, j] < 0)
        {
            count++;
        }
    }
    neG[j] = count;
}

Console.WriteLine("Массив количеств отрицательных элементов столбцов:");
for (int j = 0; j < 3; j++)
{
    Console.Write(neG[j] + " ");
}
#endregion

#region 1.18
Console.WriteLine("1.18");
 matrix = new int[4, 3] {
            {3, 7,- 2},
            {-4, 6, 2},
            {9, -2, 6},
            {5, 3, -1}
        };

for (int i = 0; i < 4; i++)
{
    int maxIndex = -1;
    int l = -1;
    for (int j = 0; j < 3; j++)
    {
        if (matrix[i, j] < 0)
        {
            l = j;
            break;
        }
        if (maxIndex == -1 || matrix[i, j] > matrix[i, maxIndex])
        {
            maxIndex = j;
        }
    }
    if (l != -1 && maxIndex != -1)
    {
        int temp = matrix[i, maxIndex];
        matrix[i, maxIndex] = matrix[i, l];
        matrix[i, l] = temp;
    }
}

Console.WriteLine("Измененная матрица:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion

#region 1.22
Console.WriteLine("1.22");
int[,] Z = new int[6, 8]
       {
            {1, -2, 3, 4, -5, 6, -7, 8},
            {9, -10, 11, -12, 13, 14, -15, 16},
            {17, -18, 19, 20, -21, 22, 23, -24},
            {25, -26, 27, 28, -29, 30, -31, 32},
            {33, -34, 35, -36, 37, 38, -39, 40},
            {41, -42, 43, 44, -45, 46, 47, -48}
       };
Console.WriteLine("исходная матрица");
for (int i = 0; i < Z.GetLength(0); i++)
{
    for (int j = 0; j < Z.GetLength(1); j++)
    {
        Console.Write(Z[i, j] + " ");
    }
    Console.WriteLine();
}
int max = Z[0, 0];
 sum = 0;
int c = 0;


for (int i = 0; i < Z.GetLength(0); i++)
{
    for (int j = 0; j < Z.GetLength(1); j++)
    {
        if (Z[i, j] > max)
        {
            max = Z[i, j];
        }
        if (Z[i, j] > 0)
        {
            sum += Z[i, j];
            c++;
        }
    }
}


if (c > 0)
{
    int av = sum / c;
    for (int i = 0; i < Z.GetLength(0); i++)
    {
        for (int j = 0; j < Z.GetLength(1); j++)
        {
            if (Z[i, j] == max)
            {
                Z[i, j] = av;
            }
        }
    }
}

Console.WriteLine("полученная матрица");
for (int i = 0; i < Z.GetLength(0); i++)
{
    for (int j = 0; j < Z.GetLength(1); j++)
    {
        Console.Write(Z[i, j] + " ");
    }
    Console.WriteLine();
}

#endregion


#region 1.26
Console.WriteLine("1.26");
int[,] A = new int[5, 7]
      {
            {1, 2, 3, 4, 5, 6, 7},
            {8, 9, 10, 11, 12, 13, 14},
            {15, 16, 17, 18, 19, 20, 21},
            {22, 23, 24, 25, 26, 27, 28},
            {29, 30, 31, 32, 33, 34, 35}
      };

int[] B = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

int maxe = A[0, 6];
int imax = 0;

for (int i = 1; i < A.GetLength(0); i++)
{
    if (A[i, 6] > maxe)
    {
        maxe = A[i, 6];
        imax = i;
    }
}

for (int j = 0; j < A.GetLength(1); j++)
{
    A[imax, j] = B[j];
}


for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}


#endregion

#region 1.30
Console.WriteLine("1.30");
matrix = new int[5, 5]
        {
            {1, 2, 3, 4, 5},
            {6, 7, 8, 9, 10},
            {11, 12, -13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
        };

int maxd = matrix[0, 0];
 imax = 0;
for (int i = 1; i < 5; i++)
{
    if (matrix[i, i] > maxd)
    {
        maxd = matrix[i, i];
        imax = i;
    }
}
int neg = -1;
for (int i = 0; i < 5; i++)
{
    if (matrix[i, 2] < 0)
    {
        neg = i;
        break;
    }
}

if (neg != -1)
{
    for (int j = 0; j < 5; j++)
    {
        int temp = matrix[neg, j];
        matrix[neg, j] = matrix[imax, j];
        matrix[imax, j] = temp;
    }
}


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


#endregion

#region 2.1
Console.WriteLine("2.1");
int[,] a = {
            {-1, -2, -3, -4, 0, -6, -7},
            {8, 9, 10, 11, 12, 13, 14},
            {15, 16, 17, 18, 19, 20, 21},
            {22, 23, 90, -25, 26, 27, 28},
            {100, 30, 31, 32, 33, 34, 35}
        };

 Console.WriteLine("исходная матрица:");
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(a[i, j] + " ");
    }
   
    Console.WriteLine();
}

for (int i = 0; i < a.GetLength(0); i++)
{
    int maxIndex = 0;
     max = a[i, maxIndex];

    for (int j = 1; j < a.GetLength(1); j++)
    {
        if (a[i, j] > max)
        {
            max = a[i, j];
            maxIndex = j;
        }
    }

    if (maxIndex > 0 && maxIndex < a.GetLength(1) - 1)
    {
        if (a[i, maxIndex - 1] < a[i, maxIndex + 1])
        {
            a[i, maxIndex - 1] *= 2;
        }
        else
        {
            a[i, maxIndex + 1] *= 2;
        }
    }
    else if (maxIndex == 0)
    {
        a[i, maxIndex + 1] *= 2;
    }
    else
    {
        a[i, maxIndex - 1] *= 2;
    }
}

Console.WriteLine("полученная матрица:");
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(a[i, j] + " ");
    }
    
    Console.WriteLine();
}


#endregion

#region 2.5
Console.WriteLine("2.5");
 a = new int[7, 5]
       {
            {1, 2, 3, 4, 30},
            {6, 7, 8, 9, 10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25},
            {26, 27, 28, 29, 30},
            {31, 32, 33, 34, 35}
       };
Console.WriteLine("исходная матрица");
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}

for (int j = 0; j < a.GetLength(1); j++)
{
     max = a[0, j];
     maxR = 0;

    for (int i = 1; i < a.GetLength(0); i++)
    {
        if (a[i, j] > max)
        {
            max = a[i, j];
            maxR = i;
        }
    }

    int pols = (a[0, j] + a[a.GetLength(0) - 1, j]) / 2;

    if (max < pols)
    {
        a[maxR, j] = pols;
    }
    else
    {
        a[maxR, j] = j;
    }
}
Console.WriteLine("полученная матрица");
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion

#region 2.9
Console.WriteLine("2.9");
 matrix = new int[6, 7]
       {
            {1, 2, 3, 4, 5, 6, 7},
            {8, 9, 10, 11, 12, 13, 14},
            {15, 16, 17, 18, 19, 20, 21},
            {22, 23, 24, 25, 26, 27, 28},
            {29, 30, 31, 32, 33, 34, 35},
            {36, 37, 38, -39, 40, 41, 42}
       };


int ro = matrix.GetLength(0);
int co = matrix.GetLength(1);

for (int j = 0; j < co / 2; j++)
{
    for (int i = 0; i < ro; i++)
    {
        int temp = matrix[i, j];
        matrix[i, j] = matrix[i, co - 1 - j];
        matrix[i, co - 1 - j] = temp;
    }
}


for (int i = 0; i < ro; i++)
{
    for (int j = 0; j < co; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion


#region

Console.WriteLine("3.1");
 matrix = new int[7, 5]
        {
            {3, 7, 1, 4, 9},
            {6, 2, 8, 9, 5},
            {11, 1, 13, 14, 15},
            {16, 17, 2, 19, 20},
            {21, 22, 23, 4, 25},
            {26, 27, 3, 29, 30},
            {31, 32, 33, 34, 1}
        };


int[] minVv = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int min = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
        }
    }
    minVv[i] = min;
}


for (int i = 0; i < minVv.Length - 1; i++)
{
    for (int j = 0; j < minVv.Length - i - 1; j++)
    {
        if (minVv[j] > minVv[j + 1])
        {

            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                int temp = matrix[j, k];
                matrix[j, k] = matrix[j + 1, k];
                matrix[j + 1, k] = temp;
            }


            int t = minVv[j];
            minVv[j] = minVv[j + 1];
            minVv[j + 1] = t;
        }
    }
}
Console.WriteLine("полученная матрица");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

#endregion

#region 3.8



Console.WriteLine("3.8");


matrix = new int[7, 5]
        {
            {1, -2, 3, 4, -5},
            {6, 7, -8, 9, 10},
            {-11, 12, 13, -14, 15},
            {-16, -17, 18, 19, 20},
            {21, -22, 23, 24, -25},
            {-26, 27, 28, -29, 30},
            {31, 32, -33, 34, 35}
        };


int[] p = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] > 0)
        {
            p[i]++;
        }
    }
}


for (int i = 0; i < p.Length - 1; i++)
{
    for (int j = 0; j < p.Length - i - 1; j++)
    {
        if (p[j] < p[j + 1])
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                int temp = matrix[j, k];
                matrix[j, k] = matrix[j + 1, k];
                matrix[j + 1, k] = temp;
            }


            int tempC = p[j];
            p[j] = p[j + 1];
            p[j + 1] = tempC;
        }
    }
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


#endregion