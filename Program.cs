using System;

class Program
{
    static void Main(string[] args)
    {
        #region 2.10
        //Console.WriteLine("Введите размер массива ");
        //int n = int.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int imin = 0;
        //bool ok = true;
        //for (int i = 0; i < n; i++)
        //{
        //    string s1 = Console.ReadLine();
        //    a[i] = double.Parse(s1);
        //}
        //while ((imin < n) && (a[imin] <= 0))
        //{
        //    imin += 1;
        //}
        //if (imin == n) ok = false;
        //Console.WriteLine();
        //if (ok == false) Console.WriteLine("Положительных элементов нет");
        //else
        //{
        //    for (int i = imin + 1; i < n; i++)
        //    {
        //        if ((a[i] < a[imin]) && (a[i] > 0)) imin = i;
        //    }
        //    if (ok == true)
        //    {
        //        for (int i = imin; i < n - 1; i++) a[i] = a[i + 1];
        //    }
        //    Console.Write("Удалить мин элемент среди положительных: ");
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        Console.Write("{0} ", a[i]);
        //    }
        //}

        //Console.ReadLine();
        #endregion
        #region 2_12
        Console.WriteLine("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());
        int z = 0;
        int amax = 0;
        double s = 0;
        bool ok = true;
        double[] a = new double[n];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (a[i] > a[amax])
                amax = i;
        }
        while ((z < n) && (a[z] >= 0))
            z += 1;
        if (z == n) ok = false;
        if (ok == false) Console.WriteLine("Отрицательных элементов нет");
        else
        {
            for (int i = amax + 1; i < n; i++)
                s += a[i];
            a[z] = s;
            Console.Write("Полученный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
        Console.ReadLine();
        #endregion
    }
}


