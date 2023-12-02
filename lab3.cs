using System;
namespace project
{
    class Project
    {
        static void Main()
        {
            #region 1-1
            double[] mas = new double[6];
            double sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву 
                sum += a;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] /= sum;
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            #endregion
            #region 1-2
            mas = new double[8];
            sum = 0;
            int k = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву 
                if (mas[i] > 0)
                {
                    sum += mas[i];
                    k++;
                }
            }
            double sr = sum / k; //среднее значение 
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)// проверяем на положительность 
                {
                    mas[i] = sr;// меняем на ср арифм положительные значения 
                }
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            #endregion
            #region 1-3
            mas = new double[4];
            sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву 
            }
            double[] mas1 = new double[4];
            for (int i = 0; i < mas1.Length; i++)
            {
                double c = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas1[i] = c; //присваиваем значение массиву 
            }
            double[] mas2 = new double[4];
            for (int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = mas[i] + mas1[i];
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas2));
            for (int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = mas[i] - mas1[i];
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas2));
            #endregion
            #region 1-4
            mas = new double[5];
            sum = 0;
            k = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву 
                sum += a;
                k++;
            }
            sr = sum / k;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] -= sr;
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            #endregion
            #region 1-6
            mas = new double[5];
            sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву
                sum += a * a;
            }
            Console.WriteLine(Math.Sqrt(sum));
            #endregion
            #region 1-7
            mas = new double[7];
            sum = 0;
            k = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву
                sum += a;
                k++;
            }
            sr = sum / k;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < sr)
                {
                    mas[i] = 0;
                }
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            #endregion
            #region 1-8
            mas = new double[6];
            k = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву
                if (mas[i] < 0)
                {
                    k++;
                }
            }
            Console.WriteLine(k);
            #endregion
            #region 1-9
            mas = new double[8];
            k = 0;
            double v = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву
                sum += a;
                k++;
            }
            sr = sum / k;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > sr)
                {
                    v++;
                }
            }
            Console.WriteLine(v);
            #endregion
            #region 1-10
            mas = new double[10];
            double p = Convert.ToDouble(Console.ReadLine());
            double q = Convert.ToDouble(Console.ReadLine());
            k = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву
                if (p < mas[i] & mas[i] < q)
                {
                    k++;
                }
            }
            Console.WriteLine(k);
            #endregion
            #region 1-11
            mas = new double[10];
            k = 0;
            int h = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву
                if (mas[i] > 0)
                {
                    k++;
                }
            }
            mas1 = new double[k];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)
                {
                    mas1[h] = mas[i];
                    h++;
                }
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas1));
            #endregion
            #region 1-12
            mas = new double[8];
            h = 0;
            double r = 0;
            for(int i = 0;i < mas.Length;i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву
                if (mas[i] < 0)
                {
                    h = i + 1;
                    r = mas[i];
                }
            }
            Console.WriteLine("r" + "h");
            #endregion
            #region 1-13
            mas = new double[10];
            k = 0;
            h= 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву
            }
            mas1 = new double[5];
            for (int i = 0; i < mas.Length; i+=2)
            {
                mas1[i] = mas[i]; //присваиваем значение массиву
                k++;
            }
            mas2 = new double[5];
            for (int i = 0; i < mas.Length; i+=2)
            {
                mas2[i] = mas[i];
                h++;
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas1));
            Console.WriteLine("[{0}]", string.Join("; ", mas2));
            #endregion
            #region 1-14
            mas = new double[10];
            sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine()); //вводим значения массива
                mas[i] = a; //присваиваем значение массиву
                if (mas[i]<0)
                {
                    sum += a * a;
                }
                if (mas[i] < 0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
            #endregion
            #region 1 - 15
            double[] x = new double[10];
            double[] y = new double[10];
            for (int i = 0; i < x.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                x[i] = a;
                y[i] = 0.5 * Math.Log10(x[i]);
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{x[i]} {y[i]}");
            }
            Console.WriteLine();
            #endregion
            #region 2-1
            int b = Convert.ToInt16(Console.ReadLine());
            mas = new double[b];
            double min = 100000000000;
            h = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;

                if (min > mas[i])
                {
                    min = mas[i];
                    h = i;
                }
            }
            mas[h] = min * 2;
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            #endregion

            #region 2_2
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            double o = -Math.Pow(10, 20);
            sum = 0;
            h = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > o)
                {
                    h = i;
                    o = mas[i];
                }
            }
            for (int i = 0; i < h; i++)
            {
                sum += mas[i];
            }
            Console.WriteLine(sum);
            #endregion
            Console.WriteLine();


            #region 2_3
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            o = Math.Pow(10, 20);
            h = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] < o)
                {
                    h = i;
                    o = mas[i];
                }
            }
            for (int i = 0; i < h; i++)
            {
                mas[i] = 2 * mas[i];
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            Console.WriteLine();
            #endregion

            #region 2_4
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            o = -Math.Pow(10, 20);
            h = 0;
            sum = 0;
            sr = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > o)
                {
                    h = i;
                    o = mas[i];
                }
                sum += mas[i];
            }
            sr = sum / b;
            for (int i = (h + 1); i < b; i++)
            {
                mas[i] = sr;
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            Console.WriteLine();
            #endregion


            #region 2_5
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            o = -Math.Pow(10, 20);
            p = Math.Pow(10, 20);
            h = 0;
            k = 0;
            int index1 = -1;
            int index2 = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > o)
                {
                    h = i;
                    o = mas[i];
                }
                if (mas[i] < p)
                {
                    k = i;
                    p = mas[i];
                }
            }
            if (k >= h)
            {
                for (int i = (h + 1); i < k; i++)
                {
                    if (mas[i] < 0)
                    {
                        index2++;
                    }
                }
                mas1 = new double[index2];
                for (int i = (h + 1); i < k; i++)
                {
                    if (mas[i] < 0)
                    {
                        index1 += 1;
                        mas1[index1] = mas[i];
                    }
                }
            }
            if (k < h)
            {
                for (int i = (k + 1); i < h; i++)
                {
                    if (mas[i] < 0)
                    {
                        index2++;
                    }
                }
                mas1 = new double[index2];
                for (int i = (k + 1); i < h; i++)
                {
                    if (mas[i] < 0)
                    {
                        index1 += 1;
                        mas1[index1] = mas[i];
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas1));
            Console.WriteLine();
            #endregion



            #region 2_6
            p = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            mas1 = new double[b + 1];
            o = Math.Pow(10, 20);
            h = 0;
            k = 0;
            index1 = -1;
            index2 = 0;
            sum = 0;
            sr = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                sum += mas[i];
            }
            sr = sum / b;
            for (int i = 0; i < mas.Length; i++)
            {
                if (Math.Abs(mas[i] - sr) < o)
                {
                    h = i;
                    o = Math.Abs(mas[i] - sr);
                }
            }
            for (int i = 0; i < mas.Length + 1; i++)
            {
                if (i <= h)
                {
                    mas1[i] = mas[i];
                }
                if (i == (h + 1))
                {
                    mas1[i] = p;
                }
                if (i > (h + 1))
                {
                    mas1[i] = mas[i - 1];
                }
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas1));
            Console.WriteLine();
            #endregion

            #region 2_7
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            o = -Math.Pow(10, 20);
            h = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > o)
                {
                    h = i;
                    o = mas[i];
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (i == (h + 1))
                {
                    mas[i] = 2 * mas[i];
                }
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            Console.WriteLine();
            #endregion


            #region 2_8
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            mas1 = new double[b + 1];
            o = -Math.Pow(10, 20);
            p = Math.Pow(10, 20);
            h = 0;
            k = 0;
            index1 = -1;
            index2 = 0;
            sum = 0;
            sr = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > o)
                {
                    h = i;
                    o = mas[i];
                }
            }
            for (int i = h + 1; i < mas.Length; i++)
            {
                if (mas[i] < p)
                {
                    k = i;
                    p = mas[i];
                }
            }
            mas[h] = p;
            mas[k] = o;
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            Console.WriteLine();
            #endregion


            #region 2_9
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            o = -Math.Pow(10, 20);
            p = Math.Pow(10, 20);
            h = 0;
            k = 0;
            sum = 0;
            sr = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > o)
                {
                    h = i;
                    o = mas[i];
                }
                if (mas[i] < p)
                {
                    k = i;
                    p = mas[i];
                }
            }
            if (k >= h)
            {
                for (int i = h + 1; i < k; i++)
                {
                    sum += mas[i];
                }
            }
            if (k < h)
            {
                for (int i = k + 1; i < h; i++)
                {
                    sum += mas[i];
                }
            }
            sr = sum / (Math.Abs(k - h) - 1);
            Console.WriteLine(sr);
            Console.WriteLine();
            #endregion

            #region 2_10
            b = Convert.ToInt32(Console.ReadLine());
            mas  = new double[b];
            p = Math.Pow(10, 20);
            h = 0;
            bool flag = false;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] < p & mas[i] > 0)
                {
                    h = i;
                    p = mas[i];
                }
            }
            foreach (double elem in mas)
            {
                if (elem > 0)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                for (int i = h + 1; i < mas.Length; i++)
                {
                    mas[i - 1] = mas[i];
                }
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    Console.Write("{0:f1}", mas[i] + " ");
                }
            }
            else
            {
                foreach (double elem in mas)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();

            #region 2_11
            p = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            mas1 = new double[b + 1];
            h = 0;
            flag = false;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > 0)
                {
                    h = i;
                }
            }
            foreach (double elem in mas)
            {
                if (elem > 0)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                for (int i = 0; i < mas.Length + 1; i++)
                {
                    if (i <= h)
                    {
                        mas1[i] = mas[i];
                    }
                    if (i == (h + 1))
                    {
                        mas1[i] = p;
                    }
                    if (i > (h + 1))
                    {
                        mas1[i] = mas[i - 1];
                    }
                }
                Console.WriteLine("[{0}]", string.Join("; ", mas1));
            }
            else
            {
                foreach (double elem in mas)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            #endregion

            #region 2_12
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            h = 0;
            k = 0;
            o = -Math.Pow(10, 20);
            double s = 0;
            flag = false;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > o)
                {
                    h = i;
                    o = mas[i];
                }
            }
            foreach (double elem in mas)
            {
                if (elem < 0)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                for (int i = h + 1; i < mas.Length; i++)
                {
                    s += mas[i];
                }
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] < 0)
                    {
                        k = i;
                        break;
                    }
                }
                mas[k] = s;
                Console.WriteLine("[{0}]", string.Join("; ", mas));
            }
            else
            {
                foreach (double elem in mas)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region 2_13
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            h = 0;
            o = -Math.Pow(10, 20);
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > o & i % 2 == 0)
                {
                    h = i;
                    o = mas[i];
                }
            }
            mas[h] = h;
            Console.WriteLine("[{0}]", string.Join("; ", mas));
            Console.WriteLine();
            #endregion

            #region 2_14
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            h = 0;
            k = 0;
            o = -Math.Pow(10, 20);
            flag = false;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > o)
                {
                    h = i;
                    o = mas[i];
                }
            }
            foreach (double elem in mas)
            {
                if (elem < 0)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] < 0)
                    {
                        k = i;
                        break;
                    }
                }
                mas[h] = mas[k];
                mas[k] = o;
                Console.WriteLine("[{0}]", string.Join("; ", mas));
            }
            else
            {
                foreach (double elem in mas)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region 2_15
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
            }
            int n = int.Parse(Console.ReadLine());
            mas1 = new double[n];
            for (int i = 0; i < mas1.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas1[i] = a;
            }
            k = int.Parse(Console.ReadLine());
            mas2 = new double[mas.Length + mas1.Length];
            h -= 1;
            if (((h + 1) > mas.Length) || ((h == 1) & (mas.Length == 1)))
            {
            }
            else
            {
                for (int i = 0; i < mas.Length + mas1.Length; i++)
                {
                    if (i <= h)
                    {
                        mas2[i] = mas[i];
                    }
                    if (i > h & i <= h + mas1.Length)
                    {
                        mas2[i] = mas1[i - h - 1];
                    }
                    if (i > (h + mas1.Length))
                    {
                        mas2[i] = mas[i - mas1.Length];
                    }
                }
            }
            Console.WriteLine( "[{0}]", string.Join("; ", mas2));
            Console.WriteLine();
            #endregion

            #region 2_16
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            h = 0;
            sum = 0;
            sr = 0;
            int K = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                sum += mas[i];
            }
            sr = sum / b;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < sr)
                {
                    K++;
                }
            }
            mas1 = new double[K];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < sr)
                {
                    mas1[h] = i;
                    h++;
                }
            }
            Console.WriteLine("[{0}]", string.Join("; ", mas1));
            Console.WriteLine();
            #endregion

            #region 2_17
            b = int.Parse(Console.ReadLine());
            mas = new double[b];
            int I = 0;
            int I1 = 0;
            s = 0;
            sr = 0;
            q = 0;
            double l = Math.Pow(10, 20);
            p = -Math.Pow(10, 20);
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] < l)
                {
                    I = i;
                    l = mas[i];
                }
                if (mas[i] > p)
                {
                    I1 = i;
                    p = mas[i];
                }
            }
            if (I1 < I)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] > 0)
                    {
                        s += mas[i];
                        q += 1;
                    }
                }
                sr = s / q;
            }
            if (I1 > I)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] < 0)
                    {
                        s += mas[i];
                        q += 1;
                    }
                }
                if (q == 0)
                {
                    Console.WriteLine("Ответ: 0");
                }
                else
                {
                    sr = s / q;
                }
            }
            Console.WriteLine(sr);
            Console.WriteLine();
            #endregion

            #region 2_18
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            h = 0;
            k = 0;
            sum = 0;
            sr = 0;
            q = 0;
            o = Math.Pow(10, 20);
            p = -Math.Pow(10, 20);
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] < o)
                {
                    h = i;
                    o = mas[i];
                }
                if (mas[i] > p)
                {
                    k = i;
                    p = mas[i];
                }
            }
            if (k < h)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] > 0)
                    {
                        sum += mas[i];
                        q += 1;
                    }
                }
                sr = sum / q;
            }
            if (k > h)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] < 0)
                    {
                        sum += mas[i];
                        q += 1;
                    }
                }
                sr = sum / q;
            }
            Console.WriteLine(sr);
            Console.WriteLine();
            #endregion

            #region 2_19
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            h = 0;
            sum = 0;
            p = -Math.Pow(10, 20);
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > p)
                {
                    h = i;
                    p = mas[i];
                }
                sum += mas[i];
            }
            if (p > sum)
            {
                mas[h] = 0;
            }
            if (p <= sum)
            {
                mas[h] = 2 * mas[h];
            }
            Console.WriteLine("[{0}]", string.Join(';', mas));
            Console.WriteLine();
            #endregion


            #region 2_20 
            b = Convert.ToInt32(Console.ReadLine());
            mas = new double[b];
            h = 0;
            sum = 0;
            k = 0;
            q = 0;
            o = Math.Pow(10, 20);
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] < o)
                {
                    h = i;
                    o = mas[i];
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                {
                    k = i;
                    break;
                }
            }
            if (k < h)
            {
                for (int i = 0; i < mas.Length; i += 2)
                {
                    sum += mas[i];
                }
            }
            if (k >= h)
            {
                for (int i = 1; i < mas.Length; i += 2)
                {
                    sum += mas[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine();
            #endregion


            #region 3_2
            b = int.Parse(Console.ReadLine());
            mas = new double[b];
            p = -Math.Pow(10, 20);
            K = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > p)
                {
                    p = mas[i];
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == p)
                {
                    mas[i] = mas[i] + K;
                    K++;
                }
            }
            Console.Write("[{0}]", string.Join("; ", mas));
            Console.WriteLine();
            #endregion

            #region 3_3
            b = int.Parse(Console.ReadLine());
            mas = new double[b];
            p = -Math.Pow(10, 20);
            I = 0;
            double kr = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                mas[i] = a;
                if (mas[i] > p)
                {
                    p = mas[i];
                }
            }
            if (I % 2 != 0)
            {
                I -= 1;
            }
            for (int i = 0; i < I; i += 2)
            {
                kr = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = kr;
            }
            Console.Write("[{0}]", string.Join("; ", mas));
            Console.WriteLine();
#endregion
        }
    }
}
