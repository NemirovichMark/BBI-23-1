public class Program
{
    public static void Main(string[] args)
    {
        #region 1_1 
        Console.WriteLine("1_1:");
        double s = 0;
        double a = 0;
        double[] mass = new double[6];
        Console.WriteLine("Введите 6 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            s += a;
        }
        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = mass[i] / s;
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 1_2 
        Console.WriteLine("1_2:");
        s = 0;
        double arm = 0;
        mass = new double[8];
        double k = 0;
        Console.WriteLine("Введите 8 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (a > 0)
            {
                s += a;
                k++;
            }
        }
        arm = s / k;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] > 0)
            {
                mass[i] = arm;
            }
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 1_3
        Console.WriteLine("1_3:");
        double[] mass1 = new double[4];
        double[] mass2 = new double[4];
        double[] mass3 = new double[4];
        Console.WriteLine("Введите 4 элемента 1-го массива: ");
        for (int i = 0; i < mass1.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass1[i] = a;
        }
        Console.WriteLine("Введите 4 элемента 2-го массива: ");
        for (int i = 0; i < mass2.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass2[i] = a;
        }
        for (int i = 0; i < mass3.Length; i++)
        {
            mass3[i] = mass1[i] + mass2[i];
        }
        Console.WriteLine("Ответ(Сумма): " + "[{0}]", string.Join("; ", mass3));
        for (int i = 0; i < mass3.Length; i++)
        {
            mass3[i] = mass1[i] - mass2[i];
        }
        Console.WriteLine("Ответ(Разность): " + "[{0}]", string.Join("; ", mass3));
        #endregion
        Console.WriteLine();


        #region 1_4
        Console.WriteLine("1_4:");
        s = 0;
        arm = 0;
        mass = new double[5];
        k = 0;
        Console.WriteLine("Введите 5 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            s += a;
        }
        arm = s / 5;
        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = mass[i] - arm;
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();

        #region 1_5
        Console.WriteLine("1_5:");
        mass1 = new double[4];
        mass2 = new double[4];
        s = 0;
        Console.WriteLine("Введите 4 элементов 1-го массива: ");
        for (int i = 0; i < mass1.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass1[i] = a;
        }
        Console.WriteLine("Введите 4 элементов 2-го массива: ");
        for (int i = 0; i < mass2.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass2[i] = a;
        }
        for (int i = 0; i < mass1.Length; i++)
        {
            s += mass1[i] * mass2[i];
        }
        Console.WriteLine($"Ответ: {s}");
        #endregion
        Console.WriteLine();


        #region 1_6
        Console.WriteLine("1_6:");
        s = 0;
        arm = 0;
        mass = new double[5];
        k = 0;
        Console.WriteLine("Введите 5 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            s += mass[i] * mass[i];
        }
        s = Math.Sqrt(s);
        Console.WriteLine($"Ответ: {s}");
        #endregion
        Console.WriteLine();


        #region 1_7
        Console.WriteLine("1_7:");
        s = 0;
        arm = 0;
        mass = new double[7];
        Console.WriteLine("Введите 7 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            s += mass[i];
        }
        arm = s / mass.Length;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] > arm)
            {
                mass[i] = 0;
            }
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 1_8
        Console.WriteLine("1_8:");
        s = 0;
        mass = new double[6];
        k = 0;
        Console.WriteLine("Введите 6 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] < 0)
            {
                k += 1;
            }
        }
        Console.WriteLine($"Ответ: {k}");
        #endregion
        Console.WriteLine();


        #region 1_9
        Console.WriteLine("1_9:");
        s = 0;
        mass = new double[8];
        k = 0;
        arm = 0;
        Console.WriteLine("Введите 8 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            s += mass[i];
        }
        arm = s / mass.Length;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] > arm)
            {
                k += 1;
            }
        }
        Console.WriteLine($"Ответ: {k}");
        #endregion
        Console.WriteLine();


        #region 1_10
        Console.WriteLine("1_10:");
        mass = new double[10];
        k = 0;
        Console.WriteLine("Введите нижнюю границу: ");
        double.TryParse(Console.ReadLine(), out double p);
        Console.WriteLine("Введите верхнюю границу: ");
        double.TryParse(Console.ReadLine(), out double q);
        Console.WriteLine("Введите 10 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            a = Convert.ToDouble(Console.ReadLine());
            mass[i] = a;
            if (mass[i] > p & mass[i] < q)
            {
                k += 1;
            }
        }
        Console.WriteLine($"Ответ: {k}");
        #endregion
        Console.WriteLine();

        #region 1_11
        Console.WriteLine("1_11:");
        int I = 0;
        mass = new double[10];
        arm = 0;
        Console.WriteLine("Введите 10 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > 0)
            {
                I += 1;
            }
        }
        mass1 = new double[I];
        I = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] > 0)
            {
                mass1[I] = mass[i];
                I += 1;
            }
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass1));
        #endregion
        Console.WriteLine();


        #region 1_12
        Console.Write("1_12:");
        I = 0;
        mass = new double[8];
        k = 0;
        Console.WriteLine("Введите 8 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] < 0)
            {
                k = mass[i];
                I = i;
            }
        }
        Console.WriteLine("Ответ: " + k + " " + (I + 1));
        #endregion
        Console.WriteLine();


        #region 1_13
        Console.Write("1_13:");
        I = 0;
        mass = new double[10];
        mass1 = new double[5];
        mass2 = new double[5];
        k = 0;
        int index1 = 0;
        int index2 = 0;
        Console.WriteLine("Введите 10 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (i % 2 == 0)
            {
                mass1[index1] = mass[i];
                index1++;
            }
            else
            {
                mass2[index2] = mass[i];
                index2++;
            }
        }
        Console.WriteLine("Ответ(Четный): " + "[{0}]", string.Join("; ", mass1));
        Console.WriteLine("Ответ(Нечетный): " + "[{0}]", string.Join("; ", mass2));
        #endregion
        Console.WriteLine();


        #region 1_14
        Console.WriteLine("1_14:");
        I = 0;
        mass = new double[11];
        s = 0;
        Console.WriteLine("Введите 11 элементов массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
        }
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] >= 0)
            {
                s += mass[i] * mass[i];
            }
            else
            {
                break;
            }

        }
        Console.WriteLine($"1_13: {s}");
        #endregion
        Console.WriteLine();


        #region 1_15
        Console.WriteLine("1_15:");
        mass = new double[10];
        mass1 = new double[10];
        Console.WriteLine("Введите 10 значений x: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
        }
        for (int i = 0; i < mass1.Length; i++)
        {
            mass1[i] = 0.5 * Math.Log(mass[i], Math.E);
        }
        Console.WriteLine("Ответ: ");
        Console.WriteLine("x " + "y");
        for (int i = 0; i < mass.Length; i++)
        {
            Console.WriteLine("Ответ" + mass[i] + " " + mass1[i]);
        }
        #endregion
        Console.WriteLine();

        #region 2_1
        Console.WriteLine("2_1:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out int n);
        mass = new double[n];
        k = Math.Pow(10, 20);
        Console.WriteLine("Введите " + n + " значений массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] < k)
            {
                k = mass[i];
            }
        }
        Console.WriteLine($"Ответ(Наименьший элемент массива умноженный на 2): {2 * k}");
        #endregion
        Console.WriteLine();


        #region 2_2
        Console.WriteLine("2_2:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        k = -Math.Pow(10, 20);
        s = 0;
        I = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > k)
            {
                I = i;
                k = mass[i];
            }
        }
        for (int i = 0; i < I; i++)
        {
            s += mass[i];
        }
        Console.WriteLine($"Ответ(Cумма элементов до максимального элемента массива): {s}");
        #endregion
        Console.WriteLine();


        #region 2_3
        Console.WriteLine("2_3:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        k = Math.Pow(10, 20);
        I = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] < k)
            {
                I = i;
                k = mass[i];
            }
        }
        for (int i = 0; i < I; i++)
        {
            mass[i] = 2 * mass[i];
        }

        Console.WriteLine("Ответ(Итоговый массив, где элементы расположенные до минимального увеличены в 2 раза): " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 2_4
        Console.WriteLine("2_4:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        k = -Math.Pow(10, 20);
        I = 0;
        s = 0;
        arm = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > k)
            {
                I = i;
                k = mass[i];
            }
            s += mass[i];
        }
        arm = s / n;
        for (int i = (I + 1); i < n; i++)
        {
            mass[i] = arm;
        }

        Console.WriteLine("Ответ(Итоговый массив, где элементы расположенные после max заменены на ср.ариф.): " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 2_5
        Console.WriteLine("2_5:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        k = -Math.Pow(10, 20);
        p = Math.Pow(10, 20);
        I = 0;
        int I1 = 0;
        index1 = -1;
        index2 = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > k)
            {
                I = i;
                k = mass[i];
            }
            if (mass[i] < p)
            {
                I1 = i;
                p = mass[i];
            }
        }
        if (I1 >= I)
        {
            for (int i = (I + 1); i < I1; i++)
            {
                if (mass[i] < 0)
                {
                    index2++;
                }
            }
            mass1 = new double[index2];
            for (int i = (I + 1); i < I1; i++)
            {
                if (mass[i] < 0)
                {
                    index1 += 1;
                    mass1[index1] = mass[i];
                }
            }
        }
        if (I1 < I)
        {
            for (int i = (I1 + 1); i < I; i++)
            {
                if (mass[i] < 0)
                {
                    index2++;
                }
            }
            mass1 = new double[index2];
            for (int i = (I1 + 1); i < I; i++)
            {
                if (mass[i] < 0)
                {
                    index1 += 1;
                    mass1[index1] = mass[i];
                }
            }
        }
        Console.WriteLine("Ответ(Итоговый массив, где находятся отрицательные элементы расположенные между макс. и мин.): " + "[{0}]", string.Join("; ", mass1));
        #endregion
        Console.WriteLine();


        #region 2_6
        Console.WriteLine("2_6:");
        Console.WriteLine("Введите значение p: ");
        double.TryParse(Console.ReadLine(), out p);
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        mass1 = new double[n + 1];
        k = Math.Pow(10, 20);
        I = 0;
        I1 = 0;
        index1 = -1;
        index2 = 0;
        s = 0;
        arm = 0;
        Console.WriteLine($"Введите {n} значен. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            s += mass[i];
        }
        arm = s / n;
        for (int i = 0; i < mass.Length; i++)
        {
            if (Math.Abs(mass[i] - arm) < k)
            {
                I = i;
                k = Math.Abs(mass[i] - arm);
            }
        }
        for (int i = 0; i < mass.Length + 1; i++)
        {
            if (i <= I)
            {
                mass1[i] = mass[i];
            }
            if (i == (I + 1))
            {
                mass1[i] = p;
            }
            if (i > (I + 1))
            {
                mass1[i] = mass[i - 1];
            }
        }
        Console.WriteLine("Ответ(Итоговый массив, где после элемента ближайшего к ср.ариф. стоит число p): " + "[{0}]", string.Join("; ", mass1));
        #endregion
        Console.WriteLine();


        #region 2_7
        Console.WriteLine("2_7:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        k = -Math.Pow(10, 20);
        I = 0;
        Console.WriteLine($"Введите {n} знач/ массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > k)
            {
                I = i;
                k = mass[i];
            }
        }
        for (int i = 0; i < mass.Length; i++)
        {
            if (i == (I + 1))
            {
                mass[i] = 2 * mass[i];
            }
        }
        Console.WriteLine("Ответ(Итоговый массив, где элемент, идущий после макс., увеличен в 2 раза): " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 2_8
        Console.WriteLine("2_8:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        mass1 = new double[n + 1];
        k = -Math.Pow(10, 20);
        p = Math.Pow(10, 20);
        I = 0;
        I1 = 0;
        index1 = -1;
        index2 = 0;
        s = 0;
        arm = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > k)
            {
                I = i;
                k = mass[i];
            }
        }
        for (int i = I + 1; i < mass.Length; i++)
        {
            if (mass[i] < p)
            {
                I1 = i;
                p = mass[i];
            }
        }
        mass[I] = p;
        mass[I1] = k;
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 2_9
        Console.WriteLine("2_9:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        k = -Math.Pow(10, 20);
        p = Math.Pow(10, 20);
        I = 0;
        I1 = 0;
        s = 0;
        arm = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > k)
            {
                I = i;
                k = mass[i];
            }
            if (mass[i] < p)
            {
                I1 = i;
                p = mass[i];
            }
        }
        if (I1 >= I)
        {
            for (int i = I + 1; i < I1; i++)
            {
                s += mass[i];
            }
        }
        if (I1 < I)
        {
            for (int i = I1 + 1; i < I; i++)
            {
                s += mass[i];
            }
        }
        arm = s / (Math.Abs(I1 - I) - 1);
        Console.WriteLine("Ответ: " + arm);
        #endregion
        Console.WriteLine();


        #region 2_10
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        p = Math.Pow(10, 20);
        I = -1;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if ((mass[i] < p) & (mass[i] > 0))
            {
                I = i;
                p = mass[i];
            }
        }
        if (I > 0)
        {
            for (int i = I + 1; i < mass.Length; i++)
            {
                mass[i - 1] = mass[i];
            }
        }
        for (int i = 0; i < mass.Length - 1; i++)
        {
            Console.Write("{0:f1}", mass[i] + " ");
        }
        #endregion
        Console.WriteLine();


        #region 2_11
        Console.WriteLine("2_11:");
        Console.WriteLine("Введите значение p: ");
        double.TryParse(Console.ReadLine(), out p);
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        mass1 = new double[n + 1];
        I = -1;
        k = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > 0)
            {
                I = i;
                k = mass[i];
            }
        }
        if (I < 0)
        {
            Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass));
        }
        else
        {

            for (int i = 0; i < mass1.Length; i++)
            {
                if (i <= I)
                {
                    mass1[i] = mass[i];
                }
                if (i == (I + 1))
                {
                    mass1[i] = p;
                }
                if (i > (I + 1))
                {
                    mass1[i] = mass[i - 1];
                }
            }
            Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass1));
        }
        #endregion
        Console.WriteLine();


        #region 2_12
        Console.WriteLine("2_12:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        mass1 = new double[n + 1];
        I = -1;
        I1 = -1;
        k = -Math.Pow(10, 20);
        s = 0;
        p = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > k)
            {
                I = i;
                k = mass[i];
            }
        }
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] < 0)
            {
                I1 = i;
                break;
            }
        }
        if ((I1 > 0) || (I > 0))
        {
            for (int i = I + 1; i < mass.Length; i++)
            {
                s += mass[i];
            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    I1 = i;
                    break;
                }
            }
            mass[I1] = s;
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 2_13
        Console.WriteLine("2_13:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        I = 0;
        k = -Math.Pow(10, 20);
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > k & i % 2 == 0)
            {
                I = i;
                k = mass[i];
            }
        }
        mass[I] = I;
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 2_14
        Console.WriteLine("2_14:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        I = -1;
        I1 = -1;
        k = -Math.Pow(10, 20);
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > k)
            {
                I = i;
                k = mass[i];
            }
        }
        if ((I > 0) || (I1 > 0))
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    I1 = i;
                    break;
                }
            }
            mass[I] = mass[I1];
            mass[I1] = k;
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass));
        #endregion
        Console.WriteLine();


        #region 2_15
        Console.WriteLine("2_15:");
        Console.WriteLine("Введите длину массива A: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        Console.WriteLine($"Введите {n} знач. массива A: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
        }
        Console.WriteLine("Введите длину массива B: ");
        int.TryParse(Console.ReadLine(), out n);
        mass1 = new double[n];
        Console.WriteLine($"Введите {n} знач. массива B: ");
        for (int i = 0; i < mass1.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass1[i] = a;
        }
        Console.WriteLine("Введите значение k: ");
        int.TryParse(Console.ReadLine(), out int intK);
        mass2 = new double[mass.Length + mass1.Length];
        I = 0;
        I1 = 0;
        s = 0;
        p = 0;
        intK -= 1;
        if (((intK + 1) > mass.Length) || ((intK == 1) & (mass.Length == 1)))
        {
            Console.WriteLine("Неверный ввод");
        }
        else
        {
            for (int i = 0; i < mass.Length + mass1.Length; i++)
            {
                if (i <= intK)
                {
                    mass2[i] = mass[i];
                }
                if (i > intK & i <= intK + mass1.Length)
                {
                    mass2[i] = mass1[i - intK - 1];
                }
                if (i > (intK + mass1.Length))
                {
                    mass2[i] = mass[i - mass1.Length];
                }
            }
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass2));
        #endregion

        #region 2_16
        Console.WriteLine("2_16:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        I = 0;
        s = 0;
        arm = 0;
        intK = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            s += mass[i];
        }
        arm = s / n;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] < arm)
            {
                intK++;
            }
        }
        mass1 = new double[intK];
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] < arm)
            {
                mass1[I] = i;
                I++;
            }
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join("; ", mass1));
        #endregion
        Console.WriteLine();


        #region 2_17
        Console.WriteLine("2_17:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        I = 0;
        I1 = 0;
        s = 0;
        arm = 0;
        q = 0;
        k = Math.Pow(10, 20);
        p = -Math.Pow(10, 20);
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] < k)
            {
                I = i;
                k = mass[i];
            }
            if (mass[i] > p)
            {
                I1 = i;
                p = mass[i];
            }
        }
        if (I1 < I)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    s += mass[i];
                    q += 1;
                }
            }
            arm = s / q;
        }
        if (I1 > I)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    s += mass[i];
                    q += 1;
                }
            }
            if (q == 0)
            {
                Console.WriteLine("Ответ: 0");
            }
            else
            {
                arm = s / q;
            }
        }
        Console.WriteLine($"Ответ: {arm}");
        #endregion
        Console.WriteLine();


        #region 2_18
        Console.WriteLine("2_18:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        I = 0;
        I1 = 0;
        s = 0;
        arm = 0;
        q = 0;
        k = Math.Pow(10, 20);
        p = -Math.Pow(10, 20);
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] < k)
            {
                I = i;
                k = mass[i];
            }
            if (mass[i] > p)
            {
                I1 = i;
                p = mass[i];
            }
        }
        if (I1 < I)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    s += mass[i];
                    q += 1;
                }
            }
            arm = s / q;
        }
        if (I1 > I)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    s += mass[i];
                    q += 1;
                }
            }
            arm = s / q;
        }
        Console.WriteLine("Ответ: {arm}");
        #endregion
        Console.WriteLine();


        #region 2_19 
        Console.WriteLine("2_19:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        I = 0;
        s = 0;
        p = -Math.Pow(10, 20);
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > p)
            {
                I = i;
                p = mass[i];
            }
            s += mass[i];
        }
        if (p > s)
        {
            mass[I] = 0;
        }
        if (p <= s)
        {
            mass[I] = 2 * mass[I];
        }
        Console.WriteLine("Ответ: " + "[{0}]", string.Join(';', mass));
        #endregion
        Console.WriteLine();


        #region 2_20 
        Console.WriteLine("2_20:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        I = 0;
        s = 0;
        I1 = 0;
        q = 0;
        k = Math.Pow(10, 20);
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] < k)
            {
                I = i;
                k = mass[i];
            }
        }
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] < 0)
            {
                I1 = i;
                break;
            }
        }
        if (I1 < I)
        {
            for (int i = 0; i < mass.Length; i += 2)
            {
                s += mass[i];
            }
        }
        if (I1 >= I)
        {
            for (int i = 1; i < mass.Length; i += 2)
            {
                s += mass[i];
            }
        }
        Console.WriteLine($"Ответ: {s}");
        #endregion
        Console.WriteLine();

        #region 3_1
        Console.WriteLine("3_2:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        p = -Math.Pow(10, 20);
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > p)
            {
                p = mass[i];
            }
        }
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] == p)
            {
                mass[i] = mass[i] + (i + 1);
            }
        }
        Console.Write("Ответ: " + "[{0}]", string.Join(';', mass));
        #endregion

        #region 3_2
        Console.WriteLine("3_3:");
        Console.WriteLine("Введите длину массива: ");
        int.TryParse(Console.ReadLine(), out n);
        mass = new double[n];
        p = -Math.Pow(10, 20);
        I = 0;
        double kr = 0;
        Console.WriteLine($"Введите {n} знач. массива: ");
        for (int i = 0; i < mass.Length; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            mass[i] = a;
            if (mass[i] > p)
            {
                p = mass[i];
            }
        }
        if (I % 2 != 0)
        {
            I -= 1;
        }
        for (int i = 0; i < I; i += 2)
        {
            kr = mass[i];
            mass[i] = mass[i + 1];
            mass[i + 1] = kr;
        }
        Console.Write("Ответ: " + "[{0}]", string.Join(';', mass));
        #endregion
    }
}
