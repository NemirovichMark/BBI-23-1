#region 2_15
Console.WriteLine("2_15:");
int k = 4;
int n = 10;
int m = 5;
int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] B = new int[] { 111, 4, 5, 6, 111 };
for (int i = 0; i < n; i++)
{
    Console.Write("{0:d} ", A[i]);
    if (i == (k - 1))
    {
        for (int j = 0; j < m; j++) Console.Write("{0:d} ", B[j]);
    }
}
Console.WriteLine();
#endregion
