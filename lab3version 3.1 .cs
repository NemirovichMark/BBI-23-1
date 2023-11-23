#region 2.11
/*
Console.Write("Введите, пожалуйста, P: ");

double p = Double.Parse(Console.ReadLine());
double[] a = new double[] { -1, -2, 3, 4, -5, -6 };
double index = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0) index = i;
}

Console.WriteLine("Итоговый массив: ");

for (int i = 0;i < a.Length; i++)
{
    Console.Write("{0:f} ", a[i]);
    if (i == index) Console.Write("{0:f} ", p);
}
*/
#endregion

#region 2.12
/*
double[] a = new double[] { 1, -2, -3, 8, 6, 5 };
int indexMin = a.Length, indexMax = 0;
double Max = a[0], sum = 0;

for (int i = 0; i < a.Length; i++)
{
    if ((a[i] < 0) && (indexMin > i))
    {
        indexMin = i;
    }
    if (a[i] > Max)
    {
        Max = a[i];
        indexMax = i;
    }
}

for (int i = indexMax+1; i < a.Length; i++)
{
    sum+= a[i];
}

for (int i = 0; i < a.Length; i++)
{
    if (i == indexMin)
    {
        Console.Write("{0:f} ", sum);
    }
    else Console.Write("{0:f} ", a[i]);
}
*/
#endregion

#region 2.14
/*
int[] a = new int[] { 1, -2, -3, 8, 6, 45545, 799 };
int max = a[0], otr = 0, indexMax = 0, k=0 ;

for (int i = 0; i < a.Length; i++)
{
    if ((a[i] < 0)&&(k==0))
    {
        otr = i;
        k += 1;
    }
    if (a[i] > max) 
    {
        indexMax = i;
        max = a[i];
    }
}

k = a[otr];
a[otr] = a[indexMax];
a[indexMax]= k;

Console.WriteLine("Итоговый массив: ");
for (int i = 0;i < a.Length;i++) Console.Write("{0:f} ",a[i]);
*/
#endregion

#region 2.15
/*
int k = 3;
int n = 10;
int m = 5;
int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int[] B = new int[] { 999, 2, 3, 4,999 };

for (int i = 0;i<n; i++)
{
    Console.Write("{0:d} ", A[i]);
    if (i == (k - 1))
    {
        for (int j = 0; j < m; j++) Console.Write("{0:d} ",B[j]);
    }
}
*/
#endregion

#region 2.17
/*
int[] a = new int[] { 1, -3, 8, 6, -9, 43 };
double sum1 = 0, k1 = 0, sum2=0, k2=0;
double max = a[0], min = a[0],indexMax=0,indexMin=0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0)
    {
        sum1 += a[i];
        k1++;
    }
    if (a[i] < 0)
    {
        sum2 += a[i];
        k2++;
    }
    if (a[i] > max)
    {
        max = a[i];
        indexMax = i;
    }
    if (a[i] < min)
    {
        min = a[i];
        indexMin = i;
    }
}

Console.WriteLine(max);
Console.WriteLine(min);

if (indexMax < indexMin) Console.WriteLine(sum1/k1);
else Console.WriteLine(sum2/k2);
*/
#endregion
