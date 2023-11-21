////1
//string x1, n1;
//double x, max = -9999999999999;
//int n, q = 0;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] b = new double[n];
//double[] a = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	for (int j = 0; j < n; j++)
//	{
//		if (a[j] > max)
//		{
//			max = a[j];
//		}
//	}
//	if (a[i] == max)
//	{
//		b[q] = i;
//		q++;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Массив с максимальными элементами: ");
//for (int i = 0; i < n; i++)
//{
//	if (b[i] == 0) break;
//	Console.Write($"{b[i]} ");
//}
//Console.WriteLine(" ");



////2
//string x1, n1;
//double x, max = -9999999999999;
//int n, q = 0;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] b = new double[n];
//double[] a = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	for (int j = 0; j < n; j++)
//	{
//		if (a[j] > max)
//		{
//			max = a[j];
//		}
//	}
//	b[i] = a[i];
//	//q++;
//	if (a[i] == max)
//	{
//		b[i] = a[i]+i;
//		q++;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{b[i]} ");
//}
//Console.WriteLine(" ");


////3
//string x1, n1;
//double x, max = -9999999999999;
//int n, imax = 0;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] b = new double[n];
//double[] a = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	if (a[i] > max)
//	{
//		max = a[i];
//		imax = i;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
////double p = 0;
//for (int i = 1; i < imax; i+=2)
//{
//	double p = 0;
//	p = a[i];
//	a[i] = a[i-1];
//	a[i-1] = p;
//	Console.WriteLine(p);
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



////4
//string x1, n1;
//double s=0,x, max = -9999999999999;
//int n, k = 0, ii=0;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] b = new double[n];
//double[] a = new double[n];
//double[] c = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	if (a[i] > max)
//		{
//			max = a[i];
//		}
//}
//for (int i = 0; i < n; i++)
//{
//	if (a[i] == max)
//	{
//		b[i] = i;
//		k++;
//	}
//}
//Console.WriteLine(" ");
//for (int i=0; i<n; i++)
//{
//	if (a[i] == max) a[i] = s;
//	s += a[i];
//}
//Console.WriteLine(" ");
//Console.WriteLine("Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



////5
//string x1, n1;
//double x;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//for (int i = 0; i < n; i += 2)
//{
//	if (a[i] > 0)
//	{
//		double amax = a[i];
//		int imax = i;
//		for (int j = i + 1; j < n; j++)
//		{
//			if (a[j] > amax)
//			{
//				amax = a[j];
//				imax = j;
//			}
//		}
//		a[imax] = a[i];
//		a[i] = amax;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine("Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



////6
//string x1, n1;
//double x;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//int k = 1;
//int km = -999999999;
//for (int i=0; i < n-1; i++)
//{
//	if (a[i] > a[i + 1])
//	{
//		k++;
//		if (k>km) km = k;
//	}
//	else k = 1;
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Максимальное количество элементов, расположенных по убыванию: {km}");



////7
//string x1, n1;
//double x;
//int n;
//int q=0;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//double[] b = new double[n];
//double[] c = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//int k = 0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	if (a[i] < 0)
//	{
//		b[q] = a[i]; //отрицательные элементы
//		k++; //количество отрицательных
//		q++;
//		a[i] = 0;
//	}
//}
//q = 0;
//Console.WriteLine(" ");
//for (int i = 0; i < n; i++)
//{
//	if (a[i] != 0)
//	{
//		c[q] = a[i];
//		q++;
//	}
//}
//q = 0;
//for (int i = n-k; i < n; i++)
//{
//	c[i] = b[q];
//	q++;
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine("Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{c[i]} ");
//}
//Console.WriteLine(" ");



////8
//string x1, n1;
//double x;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//double[] b= new double[n];									
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//int k = 0, q=0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	if (a[i] < 0)
//	{
//		b[q] = a[i];
//		a[i] = 0;
//		k++;
//		q++;
//	}
//}
//int imax = 0;
//double bmax;
//double p;
//for (int i = 0; i < k - 1; i++)
//{
//	bmax = Math.Abs(b[i]);
//	for (int j = i + 1; j < k; j++)
//	{
//		if (Math.Abs(b[j]) > bmax)
//		{
//			imax = j;
//			bmax = Math.Abs(b[j]);
//		}
//		p = Math.Abs(b[i]);
//		b[i] = Math.Abs(b[imax]); 
//		b[imax] = p;
//	}

//}
//q = 0;
//for (int i=n-1; i>=0; i--)
//{
//	if (a[i] == 0)
//	{
//		a[i] = -b[q];
//		q++;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine("Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



////9
//string x1, n1;
//double x;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//int k = 1;
//int kmub = -999999999, kmv=-999999999;
//string kmub1 = "убыванию", kmv1 = "возрастанию";
//for (int i = 0; i < n - 1; i++)
//{
//	if ((a[i] > a[i + 1]))
//	{
//		k++;
//		if (k > kmub) kmub = k;
//	}
//	else k = 1;
//}
//k = 1;
//for (int i = 0; i < n - 1; i++)
//{
//	if ((a[i] < a[i + 1]))
//	{
//		k++;
//		if (k > kmv) kmv = k;
//	}
//	else k = 1;
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//if (kmub > kmv) Console.WriteLine($"Максимальное количество элементов, " +
//	$"расположенных по {kmub1}: {kmub}");
//else if (kmub==kmv) Console.WriteLine($"Максимальное количество элементов, расположенных по {kmub1}, " +
//	$"равно максимальному количеству элементов, расположенных по {kmv1}, " +
//	$"равно: {kmv}");
//else Console.WriteLine($"Максимальное количество элементов, " +
//	$"расположенных по {kmv1}: {kmv}");
//Console.WriteLine(" ");



////10
//string x1, n1;
//double x;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n*2];
//double[] b = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//	b[i] = x;
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//int k = 0;
//int q = 0;
//double p = 0;
//for (int j = 0; j < n; j++)
//{
//	for (int i = n - 1; i >= k+1; i--)
//	{
//		a[i + 1] = a[i];
//	}
//	a[k + 1] = b[q];
//	k += 2;
//	q++;
//}
//for (int i = 0; i < 2*n-1; i++)
//{
//	if (a[i]==0)
//	{
//		a[i] = a[i+1];
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine("Изменённый массив: ");
//for (int i = 0; i < 2 * n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");

//10.1
//string x1, n1;
//double x;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n * 2];
//double[] b = new double[n];
//for (int i = 0; i < 2*n; i+=2)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n*2; i++)
//{
//	if (a[i] == 0)
//	{
//		a[i] = a[i - 1];
//	}
//	Console.Write($"{a[i]} ");
//}



////11
//string x1, n1, a1, b1;
//double x, h, a, b;
//int n, q = 0;
//Console.WriteLine("Введите количество точек");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите a");
//a1 = Console.ReadLine();
//a = double.Parse(a1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите b");
//b1 = Console.ReadLine();
//b = double.Parse(b1);
//Console.WriteLine(" ");
//double[] X = new double[n];
//double[] Y = new double[n];
//x = a;
//h = (double)((b - a) / (n - 1)); //шаги 
//double maxy = -a - 1, miny=b+1;
//double imax=0, imin=0;
//for (int i=0; i<n; i++)
//{
//	X[q] = x;
//	Y[q] = Math.Cos(x) + x * Math.Sin(x);
//	if (Y[q] > maxy)
//	{
//		maxy = Y[q];
//		imax = x;
//	}
//	q++;
//	x += h;
//}
//q = 0;
//x = a;
//for (int i=0; i<n;i++)
//{
//	if (Y[q] < miny)
//	{
//		miny = Y[q];
//		imin = x;
//	}
//	q++;
//	x += h;
//}
//Console.WriteLine($"y max={maxy}, при x={imax};   y min={miny}, при x={imin}");
//Console.WriteLine(" ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"x={X[i]}\t y={Y[i]}");
//	Console.WriteLine(" ");
//}











