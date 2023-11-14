internal class Program
{
    private static void Main(string[] args)
{
        #region 1_1
        int h = 6;
        double[] a = new double[] { 1, 2, 3, 4, 5, 6 };
        double s = 0;
        for (int i = 0; i < h; i++)
        {
            s += a[i];
        }
        Console.Write("1_1:");
        for (int i = 0; i < h; i++)
        {
            a[i] = a[i] / s;
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        #endregion
        
        #region 1_2
        h = 8;
        s = 0;
        a = new double[] { 1, 2, 3, 4, -1, -2, -3, -4 };
        int kp = 0;
        for (int i = 0; i < h; i++)
        {
            if (a[i] > 0)
            {
                s += a[i];
                kp += 1;
            }
        }
        double sr = s / kp;
        Console.Write("1_2: ");
        for (int i = 0; i < h; i++)
        {
            if (a[i] > 0) a[i] = sr;
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        #endregion
        
        #region 1_3
        h = 4;
        double[] a1 = new double[] { 1, 2, 3, 4 };
        double[] a2 = new double[] { 1, 2, 3, 4 };
        double[] asum = new double[4];
        double[] arazn = new double[4];
        Console.WriteLine("1_3:");
        Console.Write("массив суммы: ");
        for (int i = 0; i < h; i++)
        {
            asum[i] = a1[i] + a2[i];
            Console.Write("{0} ", asum[i]);

        }
        Console.WriteLine();
        Console.Write("массив разности: ");
        for (int i = 0; i < h; i++)
        {
            arazn[i] = a2[i] - a2[i];
            Console.Write("{0} ", arazn[i]);
        }
        Console.WriteLine();
        #endregion
       
        #region 1_4
        h = 5;
        s = 0;
        a = new double[] { 1, 2, 3, 4, 5 };
       Console.Write("1_4:");
        for (int i = 0; i < h; i++)
        {
            s += a[i];
        }
        sr = s / h;
        for (int i = 0; i < h; i++)
        {
            a[i] -= sr;
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        #endregion
        
        #region 1_5
        h = 4;
        a1 = new double[] { 0, 0, 1, 0 };
        a2 = new double[] { 1, 2, 3, 5 };
        s = 0;
        for (int i = 0; i < h; i++)
        {
            s += a1[i] * a2[i];
        }
        Console.Write("1_5: {0}", s);
        Console.WriteLine();
        #endregion
        
        #region 1_6
        h = 5;
        s = 0;
        a = new double[] { 1, 2, 2, 0, 0 };
        for (int i = 0; i < h; i++)
        {
            s += a[i] * a[i];
        }
        Console.Write("1_6: {0}", Math.Sqrt(s));
         Console.WriteLine();
        #endregion
       
        #region 1_7
        h = 7;
        s = 0;
        a = new double[] { 0, 0, 0, 0, 3, 3, 3 };
        Console.Write("1_7: ");
        for (int i = 0; i < h; i++)
        {
            s += a[i];
        }
        sr = s / h;
        for (int i = 0; i < h; i++)
        {
            if (a[i] > sr)
            {
                a[i] = 0;
            }
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        #endregion
        
        #region 1_8
        h = 6;
        a = new double[] { 0, 0, 0, 0, 3, 3 };
        double ks = 0;
        for (int i = 0; i < h; i++)
        {
            if (a[i] < 0)
            {
                ks += 1;
            }
        }
        Console.WriteLine("1_8: {0} ", ks);
        #endregion

        #region 1_9
        h = 8;
        s = 0;
        a = new double[] { 0, 0, 0, 0, 3, 3, 3, 3 };
        double n = 0;
        for (int i = 0; i < h; i++)
        {
            s += a[i];
        }
        sr = s / h;

        for (int i = 0; i < h; i++)
        {
            if (a[i] > sr) n += 1;
        }
        Console.WriteLine("1_9: {0}", n);
        #endregion

        #region 1_10
        n = 0;
        h = 10;
        a = new double[] { 0, 0, 0, 0, 3, 3, 3, 3, 5, 5 };
        double P = -4, Q = 4;
        for (int i = 0; i < h; i++)
        {
            if ((a[i] > P) && (a[i] < Q)) n += 1;
        }
        Console.WriteLine("1_10: {0}", n);
        #endregion

        #region 1_11
        h = 10;
        int ko = 0;
        a1 = new double[] { 0, 0, 0, 0, 3, 3, 3, 3, -5, -5 };
        for (int i = 0; i < h; i++)
        {
            if (a1[i] > 0) ko += 1;
        }
        a2 = new double[ko];
        int j = 0;
        Console.Write("1_10: ");
        for (int i = 0; i < h; i++)
        {
            if (a1[i] > 0)
            {
                a2[j] = a1[i];
                Console.Write("{0} ", a2[j]);
                j += 1;
            }
        }
        Console.WriteLine();
        #endregion
        
        #region 1_12
        h = 8;
        a = new double[] { 0, -4, 0, 0, 3, 3, -5, 3 };
        for (int i = h - 1; i >= 0; i -= 1)
        {
            if (a[i] < 0)
            {
                Console.WriteLine("1_12: элемент {0} с номером {1}", a[i], i);
                break;
            }
        }
        #endregion

        #region 1_13
        Console.WriteLine("1_13: ");
        h = 10;
        a = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        a1 = new double[5];
        a2 = new double[5];
        int j1 = 0, j2 = 0;
        for (int i = 0; i < h; i++)
        {
            if (i % 2 == 0)
            {
                a1[j1] = a[i];
                j1 += 1;
            }
            else
            {
                a2[j2] = a[i];
                j2 += 1;
            }
        }
        Console.Write("с четными индексами: ");
        for (int i = 0; i < 5; i++) Console.Write("{0} ", a1[i]);
        Console.WriteLine();
        Console.Write("с нечетными индексами: ");
        for (int i = 0; i < 5; i++) Console.Write("{0} ", a2[i]);
        Console.WriteLine();
        #endregion

        #region 1_14
        a = new double[] { 1, 2, -3, 4, 5, 6, 7, 8, 9, 10, 11 };
        s = 0;
        j = 0;
        while (a[j] >= 0)
        {
            s += a[j] * a[j];
            j += 1;
        }
        Console.WriteLine("1_14: {0}", s);
        #endregion

        #region 1_15
        h = 10;
        a1 = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        a2 = new double[h];
        Console.WriteLine("1_15:");
        Console.WriteLine("    x        y   ");
        for (int i = 0; i < h; i++)
        {
            a2[i] = 0.5 * Math.Log(a1[i]);
            Console.WriteLine("{0:f5}  {1:f5}", a1[i], a2[i]);
        }
        #endregion

        #region 2_1
        Console.WriteLine("2_1:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        int m = 0;
        a = new double[h];
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (i != 0)
            {
                if (a[i] < a[m]) m = i;
            }
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        a[m] = 2 * a[m];
        Console.WriteLine();
        Console.Write("Мин эл увелич в 2 раза: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        #endregion

        #region 2_2
        Console.WriteLine("2_2:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        m = 0;
        a = new double[h];
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (i != 0)
            {
                if (a[i] > a[m]) m = i;
            }
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        double ss = 0;
        for (int i = 0; i < m; i++)
        {
            ss += a[i];
        }
        Console.WriteLine("Сумма элементов массива до максимального элемента: {0} ", ss);
        #endregion

        #region 2_3
        Console.WriteLine("2_3:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        m = 0;
        a = new double[h    ];
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (i != 0)
            {
                if (a[i] < a[m]) m = i;
            }
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        Console.Write("Все эл перед мин увелич в 2 раза: ");
        for (int i = 0; i < h; i++)
        {
            if (i < m)
            {
                a[i] = 2 * a[i];
            }
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        #endregion
       

        #region 2_4
        Console.WriteLine("2_4:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        ss = 0;
        m = 0;
        a = new double[h];
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (i != 0)
            {
                if (a[i] > a[m]) m = i;
            }
            ss += a[i];
        }
        sr = ss / h;
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        Console.Write("Все элэменты после максимального заменить средним значением элэмента массива: ");
        for (int i = 0; i < h; i++)
        {
            if (i > m)
            {
                a[i] = sr;
            }
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        #endregion
        

        #region 2_5
        int imin = 0;
        int imax = 0;
        Console.WriteLine("2_5:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        j = 0;
        a = new double[h];
        double[] b = new double[h];
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (i != 0)
            {
                if (a[i] > a[imax]) imax = i;
                if (a[i] < a[imin]) imin = i;
            }
        }
        if (imin > imax)
        {
            (imin, imax) = (imax, imin);
        }
        for (int i = imin + 1; i < imax; i++)
        {
            if (a[i] < 0)
            {
                b[j] = a[i];
                j++;
            }
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        Console.Write("Новый массив из - элементоа между макс и мин: ");
        for (int i = 0; i < j; i++)
        {
            Console.Write("{0} ", b[i]);
        }
        Console.WriteLine();
        #endregion
        
        #region 2_6
        Console.WriteLine("2_6:");
        Console.WriteLine("Введите число p ");
        P = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        ss = 0;
        m = 0;
        a = new double[h + 1];
        Console.WriteLine("Введите элементы массива ");
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            ss += a[i];
        }
        sr = ss / h;
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        for (int i = 0; i < h; i++)
        {
            if (Math.Abs(a[i] - sr) < Math.Abs(a[m] - sr))
            {
                m = i;
            }
        }
        Console.WriteLine();
        Console.Write("Добавл п после самого близкого к ср знач эл: ");
        for (int i = h - 1; i >= m + 1; i--)
        {
            a[i + 1] = a[i];
        }
        a[m + 1] = P;
        for (int i = 0; i < h + 1; i++)
        {
            Console.Write("{0} ", a[i]);
        }
         Console.WriteLine();
        #endregion
       
        #region 2_7
        Console.WriteLine("2_7:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        m = 0;
        a = new double[h];
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (i != 0)
            {
                if (a[i] > a[m]) m = i;
            }
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        a[m + 1] = a[m + 1] * 2;
        Console.WriteLine();
        Console.Write("Увелич в 2 раза эл после макс эл: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        #endregion
        
        #region 2_8
        Console.WriteLine("2_8:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        m = 0;
        a = new double[h];
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (i != 0)
            {
                if (a[i] > a[m]) m = i;
            }
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        double c;
        int m1 = m + 1;
        if (m < (h - 1))
        {
            for (int i = m + 2; i < h; i++)
            {
                if (a[i] < a[m1]) m1 = i;
            }
            c = a[m]; a[m] = a[m1]; a[m1] = c;
            Console.Write("Макс эл и мин из следующ за ним эл массива помен мест: ");
            for (int i = 0; i < h; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
        else Console.Write("Максимальный элемент стоит в конце массива");
        Console.WriteLine();
        #endregion
        
        #region 2_9
        Console.WriteLine("2_9:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        imax = 0;
        imin = 0;
        a = new double[h];
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (i != 0)
            {
                if (a[i] > a[imax]) imax = i;
                if (a[i] < a[imin]) imin = i;
            }
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        ss = 0;
        if (imin > imax) (imin, imax) = (imax, imin);
        for (int i = imin + 1; i <= imax - 1; i++)
        {
            ss += a[i];
        }
        sr = ss / (imax - imin - 1);
        Console.WriteLine("{0} - среднее значение элементов, расположенных между минимальным и максимальным элементами массива", sr);
        #endregion

        #region 2_10
        Console.WriteLine("2_10:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        a = new double[h];
        bool ok = true;
        for (int i = 0; i < h; i++)
        {

            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        imin = 0;
        while ((imin < h) && (a[imin] <= 0))
        {
            imin += 1;
        }
        if (imin == h) ok = false;
        Console.WriteLine();
        if (ok == false) Console.WriteLine("нет положительных элементов");
        else
        {
            for (int i = imin + 1; i < h; i++)
            {
                if ((a[i] < a[imin]) && (a[i] > 0)) imin = i;
            }
            if (ok == true)
            {
                for (int i = imin; i < h - 1; i++) a[i] = a[i + 1];
            }
            Console.Write("Удал мин среди положит эл: ");
            for (int i = 0; i < h - 1; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
        Console.WriteLine();
        #endregion
        
        #region 2_11
        Console.WriteLine("2_11:");
        Console.WriteLine("Введите число p ");
        P = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        a = new double[h + 1];
        ok = true;
        Console.WriteLine("Введите элементы массива, записывая каждый элемент в очередную строку");
        for (int i = 0; i < h; i++)
        {

            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        int ip = h - 1;
        Console.WriteLine();
        while ((ip >= 0) && (a[ip] <= 0)) ip -= 1;
        if (ip == -1) ok = false;
        if (ok == false) Console.WriteLine("нет положительных элементов");
        else
        {
            Console.Write("Встав п после послед + эл: ");
            for (int i = h - 1; i >= ip + 1; i--)
            {
                a[i + 1] = a[i];
            }
            a[ip + 1] = P;
            for (int i = 0; i < h + 1; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
        Console.WriteLine();
        #endregion
        
        #region 2_12
        Console.WriteLine("2_12:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        int io = 0;
        imax = 0;
        ok = true;
        a = new double[h];
        Console.WriteLine("Введите элементы массива, записывая каждый элемент в очередную строку");
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (a[i] > a[imax]) imax = i;
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        while ((io < h) && (a[io] >= 0)) io += 1;
        if (io == h) ok = false;
        if (ok == false) Console.WriteLine("нет отрицательных элементов");
        else
        {
            ss = 0;
            for (int i = imax + 1; i < h; i++) ss += a[i];
            a[io] = ss;
            Console.Write("1й - эл замен суммой эл расп после макс: ");
            for (int i = 0; i < h; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
         Console.WriteLine();
        #endregion
       
        #region 2_13
        Console.WriteLine("2_13:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        imax = 0;
        a = new double[h];
        Console.WriteLine("Введите элементы массива, записывая каждый элемент в очередную строку");
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if ((i % 2 == 0) && (a[i] > a[imax])) imax = i;
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        a[imax] = imax;
        Console.Write("Макс из эл с чет индексами заменить его индексом: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
         Console.WriteLine();
        #endregion
       
        #region 2_14
        Console.WriteLine("2_14:");
        Console.WriteLine("Введите размер массива ");
        h = int.Parse(Console.ReadLine());
        io = 0;
        imax = 0;
        ok = true;
        a = new double[h];
        Console.WriteLine("Введите элементы массива, записывая каждый элемент в очередную строку");
        for (int i = 0; i < h; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = double.Parse(s1);
            if (a[i] > a[imax]) imax = i;
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a[i]);
        }
        Console.WriteLine();
        while ((io < h) && (a[io] >= 0)) io += 1;
        if (io == h) ok = false;
        if (ok == false) Console.WriteLine("нет отрицательных элементов");
        else
        {
            c = a[imax]; a[imax] = a[io]; a[io] = c;
            Console.Write("Помен мест макс и 1й отриц эл: ");
            for (int i = 0; i < h; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
        Console.WriteLine();
        #endregion
        
        #region 2_15
        Console.WriteLine("2_15:");
        Console.WriteLine("Введите размер массива А ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер массива В ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите номер элемента массива А, после которого нужно вставить массив В");
        h = int.Parse(Console.ReadLine());
        a1 = new double[n1 + m];
        a2 = new double[m];
        Console.WriteLine("Введите массив А");
        for (int i = 0; i < n1; i++)
        {
            a1[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Введите массив В");
        for (int i = 0; i < m; i++)
        {
            a2[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Массив А: ");
        for (int i = 0; i < n1; i++) Console.Write("{0} ", a1[i]);
        Console.WriteLine();
        Console.Write("Массив В: ");
        for (int i = 0; i < m; i++) Console.Write("{0} ", a2[i]);
        j = 0;
        for (int i = n1 + m - 1; i >= h + m; i--) a1[i] = a1[i - m];
        for (int i = h; i < h + m; i++)
        {
            a1[i] = a2[j];
            j++;
        }
        Console.WriteLine();
        Console.Write("Преобразованный массив А(вставл массив б после к-го эл массив а): ");
        for (int i = 0; i < n1 + m; i++) Console.Write("{0} ", a1[i]);
        #endregion

        #region 2_16
        Console.WriteLine("2_16:");
        Console.WriteLine("Введите размер массива (обязательно нечетное значение)");
        n1 = int.Parse(Console.ReadLine());
        a1 = new double[n1];
        a2 = new double[n1];
        for (int i = 0; i < n1; i++)
        {
            a1[i] = double.Parse(Console.ReadLine());
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < n1; i++) Console.Write("{0} ", a1[i]);
        sr = a1[(n1 - 1) / 2];
        j = 0;
        for (int i = 0; i < n1; i++)
        {
            if (a1[i] < sr)
            {
                a2[j] = i;
                j++;
            }
        }
        Console.Write("Новый массив из индексов элементов, меньших среднего: ");
        for (int i = 0; i < j; i++)
        {
            Console.Write("{0} ", a2[i]);
        }
        Console.WriteLine();
        #endregion
        
        #region 2_17
        Console.WriteLine("2_17:");
        Console.WriteLine("Введите размер массива");
        n1 = int.Parse(Console.ReadLine());
        a1 = new double[n1];
        imax = 0;
        imin = 0;
        double sp = 0;
        double so = 0;
        ks = 0; kp = 0;
        for (int i = 0; i < n1; i++)
        {
            a1[i] = double.Parse(Console.ReadLine());
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < n1; i++)
        {
            Console.Write("{0} ", a1[i]);
            if (a1[i] < a1[imin]) imin = i;
            if (a1[i] > a1[imax]) imax = i;
            if (a1[i] > 0)
            {
                sp += a1[i];
                kp++;
            }
            if (a1[i] < 0)
            {
                so += a1[i];
                ks++;
            }
        }
        Console.WriteLine();
        if (imin < imax)
        {
            if (ks != 0)
            {
                double otv = so / ks;
                Console.WriteLine("Ср арифм отрицательных чисел: {0}", otv);
            }
            else Console.WriteLine("Нет отрицательных чисел");
        }
        else
        {
            if (kp != 0)
            {
                double otv = sp / kp;
                Console.WriteLine("Ср арифм положительных чисел: {0}", otv);
            }
            else Console.WriteLine("Нет положительных чисел");
        }
        Console.WriteLine();
        #endregion

        #region 2_18
        Console.WriteLine("2_18:");
        Console.WriteLine("Введите размер массива");
        n1 = int.Parse(Console.ReadLine());
        a1 = new double[n1];
        for (int i = 0; i < n1; i++)  
        {
            a1[i] = double.Parse(Console.ReadLine());
        }
        double max1 = a1[1];
        double max2 = a1[0];
        Console.Write("Исходный массив: ");
        for (int i = 0; i < n1; i++)
        {
            Console.Write("{0} ", a1[i]);
            if ((i % 2 == 0) && (a1[i] > max2)) max2 = a1[i];
            if ((a1[i] > max1) && (i % 2 == 1)) max1 = a1[i];
        }
        Console.WriteLine();
        if (max2 > max1)
        {
            for (int i = 0; i < n1 / 2; i++) a1[i] = 0;
        }
        else
        {
            for (int i = n1 / 2; i < n1; i++) a1[i] = 0;
        }
        Console.Write("Конечный массив: ");
        for (int i = 0; i < n1; i++)
        {
            Console.Write("{0} ", a1[i]);
        }
        Console.WriteLine();
        #endregion
       
        #region 2_19
        Console.WriteLine("2_19:");
        Console.WriteLine("Введите размер массива");
        n1 = int.Parse(Console.ReadLine());
        a1 = new double[n1];
        for (int i = 0; i < n1; i++)
        {
            a1[i] = double.Parse(Console.ReadLine());
        }
        imax = 0;
        s = 0;
        Console.Write("Исходный массив: ");
        for (int i = 0; i < n1; i++)
        {
            Console.Write("{0} ", a1[i]);
            if (a1[i] > a1[imax]) imax = i;
            s += a1[i];

        }
        Console.WriteLine();
        if (a1[imax] > s) a1[imax] = 0;
        else a1[imax] = 2 * a1[imax];
        Console.Write("Конечный массив: ");
        for (int i = 0; i < n1; i++)
        {
            Console.Write("{0} ", a1[i]);
        }
        Console.WriteLine();
        #endregion
        
        #region 2_20
        Console.WriteLine("2_20:");
        Console.WriteLine("Введите размер массива");
        n1 = int.Parse(Console.ReadLine());
        a1 = new double[n1];
        for (int i = 0; i < n1; i++)
        {
            a1[i] = double.Parse(Console.ReadLine());
        }
        imin = 0;
        double ss1 = 0;
        double s2 = 0;
        Console.Write("Исходный массив: ");
        for (int i = 0; i < n1; i++)
        {
            Console.Write("{0} ", a1[i]);
            if (a1[i] < a1[imin]) imin = i;
            if (i % 2 == 0) s2 += a1[i];
            else ss1 += a1[i];
        }
        io = 0;
        while (a1[io] >= 0) io += 1;
        Console.WriteLine();
        if (io < imin) Console.WriteLine("сумма элементов с чёт индексами: {0}", s2);
        else Console.WriteLine("сумма элементов с нечёт индексами: {0}", ss1);
        #endregion

        #region 3_1
        h = 10;
        a1 = new double[] { 1, 2, 5, 3, 4, 5, 2, 1, 5, -5 };
        a2 = new double[h];
        j = 0;
        for (int i = 0; i < h; i++)
        {
            if (a1[i] == a1[imax])
            {
                a2[j] = i;
                j++;
            }
            else if (a1[i] > a1[imax])
            {
                a2[0] = i;
                imax = i;
                j = 1;
            }
        }
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++) Console.Write("{0} ", a1[i]);
        Console.WriteLine();
        for (int i = 0; i < j; i++)
        {
            Console.Write("{0} ", a2[i]);
        }
        #endregion

        #region 3_2
        h = 10;
        a1 = new double[] { 1, 2, 5, 3, 4, 5, 2, 1, 5, -5 };
        int[] a3 = new int[h];
        j = 0;
        imax = 0;
        for (int i = 0; i < h; i++)
        {
            if (a1[i] == a1[imax])
            {
                a3[j] = i;
                j++;
            }
            else if (a1[i] > a1[imax])
            {
                a3[0] = i;
                imax = i;
                j = 1;
            }
        }
        Console.WriteLine();
        Console.Write("Исходный массив: ");
        for (int i = 0; i < h; i++) Console.Write("{0} ", a1[i]);
        for (int i = 0; i < j; i++)
        {
            a1[a3[i]] = a1[a3[i]] * (i + 1);
        }
        Console.WriteLine();
        Console.Write("Конечный массив: ");
        for (int i = 0; i < h; i++)
        {
            Console.Write("{0} ", a1[i]);
        }
        #endregion

        #region 3_3
        _ = new double[] { 9, 2, 3, 1, 54, 7, 6, 54 };
        double max = -1000000000;
        double l = 0;
        double f = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (max < a[i])
            {
                max = a[i];
                m = i;
            }
        }
        if (l % 2 != 0)
        {
            l -= 1;
        }
        for (int i = 0; i < l; i += 2)
        {
            f = a[i];
            a[i] = a[i + 1];
            a[i + 1] = f;

        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("{0:f} ", a[i]);
        }
        Console.WriteLine(); 
        #endregion
    }
}
