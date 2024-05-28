//1 уровень


// string x1;
// double x, s=0;
// double[] a = new double[6];
// for (int i = 0; i < 6; i++) //Ввод массива
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 6; i++) //Вывод массива
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//for (int i=0; i<6; i++) //действия с массивом
//{
//	s += a[i];
//}
//Console.WriteLine($"Сумма элементов: {s}");
//Console.WriteLine(" ");
//Console.WriteLine("Массив, делённый на сумму его элементов: ");
//for (int i = 0; i < 6; i++) //вывод окончательно
//{
//	//a[i] = a[i] / s;
//	Console.Write($"{a[i]/s} ");
//}
//Console.WriteLine(" ");



//2
//string x1;
//double x, s = 0,k=0;
//double[] a = new double[8];
//for (int i = 0; i < 8; i++) //ввод массива
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 8; i++) //вывод массива
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < 8; i++) //действия с массивом
//{
//	if (a[i] > 0)
//	{
//		s += a[i];
//		k += 1;
//	}
//}
//Console.WriteLine($"Среднее арифметическое среди положительных: {s/k}");
//Console.WriteLine(" ");
//Console.WriteLine("Массив окончатльный: ");
//for (int i = 0; i < 8; i++) //вывод окончательно
//{
//	if (a[i] > 0)
//	{
//		a[i] = s / k;
//	}
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//3
//string a2, b2;
//double a1, b1;
//double[] a = new double[4];
//double[] b = new double[4];
//double[] c = new double[4];
//double[] d = new double[4];
//for (int i = 0; i < 4; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число первого массива");
//	a2 = Console.ReadLine();
//	a1 = double.Parse(a2);
//	a[i] = a1;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш первый массив:");
//for (int i = 0; i < 4; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");

//for (int i = 0; i < 4; i++) //ввод массива b
//{
//	Console.WriteLine("Введите число второго массива");
//	b2 = Console.ReadLine();
//	b1 = double.Parse(b2);
//	b[i] = b1;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш второй массив:");
//for (int i = 0; i < 4; i++) //вывод массива b
//{
//	Console.Write($"{b[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < 4; i++) //действия с массивами
//{
//	c[i] = a[i] + b[i];
//	d[i] = a[i] - b[i];
//}
//Console.WriteLine("Массив с: ");
//for (int i = 0; i < 4; i++) //вывод массива с
//{
//	Console.Write($"{c[i]} ");
//}
//Console.WriteLine(" ");
//Console.WriteLine("Массив d: ");
//for (int i = 0; i < 4; i++) //вывод массива с
//{
//	Console.Write($"{d[i]} ");
//}
//Console.WriteLine(" ");



//4
//string x1;
//double x, sr=0,s=0, k=0;
//double[] a = new double[5];
//for (int i = 0; i < 5; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 5; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < 5; i++)
//{
//	s += a[i];
//	k++;
//}
//sr = s / k;
//for (int i = 0; i < 5; i++)
//{
//	a[i] = a[i] - sr;
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//5
//string x1,x2;
//double[] a = new double[4];
//for (int i = 0; i < 4; i++)
//{
//	Console.WriteLine($"Введите координату {i+1} первого вектора");
//	x1 = Console.ReadLine();
//	a[i] = double.Parse(x1);
//	Console.WriteLine(" ");
//}
//double[] b = new double[4];
//for (int i = 0; i < 4; i++)
//{
//	Console.WriteLine($"Введите координату {i + 1} второго вектора");
//	x2 = Console.ReadLine();
//	b[i] = double.Parse(x2);
//	Console.WriteLine(" ");
//}
//double s = 0;
//for (int i=0; i < 4;i++)
//{
//	s += a[i] * b[i];
//}
//Console.WriteLine($"Скалярное произведение равно: {s}");
//Console.WriteLine(" ");



//6
//string x1;
//double[] a = new double[5];
//for (int i = 0; i < 5; i++)
//{
//	Console.WriteLine($"Введите координату {i + 1} вектора L");
//	x1 = Console.ReadLine();
//	a[i] = double.Parse(x1);
//	Console.WriteLine(" ");
//}
//double s = 0;
//for (int i=0; i<5;i++)
//{
//	s += a[i]*a[i];
//}
//Console.WriteLine($"Длина вектора L: {Math.Pow(s, 0.5)}");
//Console.WriteLine(" ");



//7
//string x1;
//double x, sr = 0, s = 0, k = 0;
//double[] a = new double[7];
//for (int i = 0; i < 7; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 7; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < 7; i++)
//{
//	s += a[i];
//	k++;
//}
//sr = s / k;
//for (int i = 0; i < 7; i++)
//{
//	if (a[i]>sr) a[i] =0;
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//8
//string x1;
//double x, k = 0;
//double[] a = new double[6];
//for (int i = 0; i < 6; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//	if (x < 0) k++;
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 6; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Количество отрицательных элементов: {k}");
//Console.WriteLine(" ");



//9
//string x1;
//double x, sr = 0, s = 0, k = 0,k1=0;
//double[] a = new double[8];
//for (int i = 0; i < 8; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 8; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//	s += a[i];
//	k++;
//}
//Console.WriteLine(" ");
//sr = s / k;
//Console.WriteLine($"Среднее значение: {sr}");
//for (int i = 0; i < 8; i++)
//{
//	if (a[i] > sr) k1++;
//}
//Console.WriteLine($"Элементов, больших, чем среднее значение: {k1}");
//Console.WriteLine(" ");



//10
//string x1, P1,Q1;
//double x, P,Q,k=0;
//double[] a = new double[10];
//Console.WriteLine("Введите P");
//P1 = Console.ReadLine();
//P = double.Parse(P1);
//Console.WriteLine("Введите Q");
//Q1 = Console.ReadLine();
//Q = double.Parse(Q1);
//for (int i = 0; i < 10; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 10; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//	if (P <= a[i] && a[i] <= Q) k += 1;
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Количество элементов, заключённых между P и Q: {k}");
//Console.WriteLine(" ");



//11
//string x1;
//double x;
//int k=0;
//double[] a = new double[10];
//double[] b = new double[10];
//for (int i = 0; i < 10; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 10; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//	if (a[i] > 0)
//	{
//		b[k] = a[i];
//		k++;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine("Массив, состоящий из положительных элементов вашего массива:");
//for (int i = 0; i < 10; i++) //вывод массива b
//{
//	if (b[i] == 0) break;
//	Console.Write($"{b[i]} ");
//}



//12
//string x1;
//double x, ai = 0, ao=0;
//double[] a = new double[8];
//for (int i = 0; i < 8; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 8; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 7; i >= 0; i--)
//{
//	ai = i;
//	ao = a[i];
//	if (a[i] < 0) break;
//}
//Console.WriteLine($"Последний отрицательный элемент массива = {ao}, его номер: {ai}");
//Console.WriteLine(" ");



//13
//string x1;
//double x;
//int kn=0, kc=0;
//double[] a = new double[10];
//double[] ach = new double[5];
//double[] anch = new double[5];
//for (int i = 0; i < 10; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 10; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//	if (i % 2 == 0)
//	{
//		ach[kc] = a[i];
//		kc++;
//	}
//	else
//	{
//		anch[kn] = a[i];
//		kn += 1;
//	}
//}
//Console.WriteLine(" "); 
//Console.WriteLine(" ");
//Console.WriteLine("Массив с чётными индексами: ");
//for (int i = 0; i < 5; i++) //вывод массива ach
//{
//	Console.Write($"{ach[i]} ");
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine("Массив с нечётными индексами: ");
//for (int i = 0; i < 5; i++) //вывод массива anch
//{
//	Console.Write($"{anch[i]} ");
//}
//Console.WriteLine(" ");



//14
//string x1;
//double x, s=0;
//double[] a = new double[11];
//for (int i = 0; i < 11; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 10; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < 10; i++)
//{
//	if (a[i] < 0) break;
//	s += a[i] * a[i];
//}
//Console.WriteLine($"Сумма квадратов элементов, расположенных до первого отрицательного: {s}");
//Console.WriteLine(" ");



//15
//string x1;
//double x;
//double[] X = new double[10];
//double[] Y = new double[10];
//for (int i = 0; i < 10; i++) //ввод массива x
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	X[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("y = 0.5ln(x)");
//for (int i = 0; i < 10; i++) //вывод массива a
//{
//	Y[i] = 0.5*Math.Log(X[i]);
//	Console.WriteLine("x={0:f5}, y={1:f5}",X[i],Y[i]);
//}




//2 уровень



//1
//string x1,n1;
//double x,min=9999999999999999999;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//for (int i = 0; i < n; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++) //вывод массива a
//{
//	Console.Write($"{a[i]} ");
//	if (a[i] < min) min = a[i];
//}
//Console.WriteLine(" ");
//Console.WriteLine("Массив с увеличенным вдвое минимальным элементом: ");
//for (int i = 0; i < n; i++) //вывод массива a
//{
//	if (a[i] == min) a[i] = min * 2;
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//2
//string x1, n1;
//double x,s=0, max = -999999999999999999;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//for (int i = 0; i < n; i++) //ввод массива a
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
//	if (a[i] > max) max = a[i];
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n; i++) 
//{
//	if (a[i] == max) break;
//	s += a[i];
//}
//Console.WriteLine($"Сумма элементов, расположенных до максимального: {s}");



//3
//string x1, n1;
//double x, s = 0, min = 999999999999999999;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//for (int i = 0; i < n; i++) //ввод массива a
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
//	if (a[i] < min) min = a[i];
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n; i++)
//{
//	if (a[i] == min) break;
//	a[i] = a[i] * 2;
//}
//Console.WriteLine("Массив с увеличенными вдвое элементами перед минимальным: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//4
//string x1, n1;
//double x, s = 0,k=0, max = -999999999999999999;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//for (int i = 0; i < n; i++) //ввод массива a
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
//	k++;
//	s += a[i];
//	if (a[i] > max) max = a[i];
//}
//Console.WriteLine(" ");
//for (int i = n-1; i>=0; i--)
//{
//	if (a[i] == max) break;
//	a[i] = s/k;
//}
//Console.WriteLine(" ");
//Console.WriteLine("Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//5
//string x1, n1;
//double x, max = -999999999999999999, min =99999999999999999;
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
//	if (a[i] > max) max = a[i];
//	if (a[i] < min) min = a[i];
//}
//Console.WriteLine(" ");
//int k = 0;
//double[] b = new double[n];
//for (int i = 0; i < n; i++)
//{
//	if (a[i] < 0)
//	{
//		if (min <= a[i] && a[i] <= max)
//		{
//			b[k] = a[i];
//			k++;
//		}
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Массив, созхданный из отрицательных элементов между минимальным ({min}) и максимальным ({max}): ");
//for (int i = 0; i < n; i++)
//{
//	if (b[i] == 0) break;
//	Console.Write($"{b[i]} ");
//}
//Console.WriteLine(" ");



//6
//string x1, n1,p1;
//double p,x, s = 0,k=0,sr,minr=999999999999999;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите P");
//p1 = Console.ReadLine();
//p = double.Parse(p1);
//Console.WriteLine(" ");
//double[] a = new double[n+1];
//for (int i = 0; i < n; i++) 
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//	a[n] = 0;
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	k++;
//	s += a[i];
//}
//sr = s / k;
//Console.WriteLine(" ");
//int ii = 0; //индекс после которого нужен p
//for (int i = 0; i < n; i++)
//{
//	if (Math.Abs(a[i] - sr) < minr)
//	{
//		minr = Math.Abs(a[i] - sr);
//		ii = i;
//	}
//}
//for (int i = n - 1; i >= ii; i--)
//{ 
//	a[i + 1] = a[i];
//}
//a[ii+1] = p;
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n+1; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//7
//string x1, n1;
//double x,max = -999999999999999;
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
//int ii = 0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	if (a[i]>max)
//	{
//		max = a[i];
//		ii = i;
//	}
//}
//a[ii + 1] = 2 * a[ii + 1];
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//8
//string x1, n1;
//double p,p1,x, max = -999999999999999,min=99999999999999;
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
//int imin = 0, imax=0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	if (a[i] > max)
//	{
//		max = a[i];
//		imin = i;
//	}
//}
//Console.WriteLine(" ");
//p = a[imin]; //макимальное значение элемента в массиве, равен max
//for(int i = imin; i < n; i++)
//{
//	if (a[i] < min)
//	{
//		min = a[i];
//		imax = i;
//	}
//}
//p1 = a[imax];
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	a[imin] = p1;
//	a[imax] = p;
//	Console.Write($"{a[i]} ");
//}



//9
//string x1, n1;
//double x, max = -999999999999999999, min = 99999999999999999;
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
//	if (a[i] > max) max = a[i];
//	if (a[i] < min) min = a[i];
//}
//Console.WriteLine(" ");
//int k = 0;
//double s=0;
//for (int i = 0; i < n; i++)
//{
//	if (min<=a[i] && a[i]<=max)
//	{
//		k++;
//		s += a[i];
//	}
//}
//double sr;
//sr = s / k;
//Console.WriteLine(" ");
//Console.WriteLine($"Среднее арифметическое между минимальным ({min}) и максимальным ({max}) элементами: {sr}");



//10
//string x1, n1;
//double x, min = 99999999999999999;
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
//int ii = 0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	if (a[i] < min && a[i] > 0)
//	{
//		min = a[i];
//		ii = i;
//	}
//}
//Console.WriteLine(" ");
//for (int i=ii+1; i<n; i++)
//{
//	a[i - 1] = a[i];
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n-1; i++)
//{
//	Console.Write($"{a[i]} ");
//}



//11
//string x1, n1, p1;
//double p, x;
//int n;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите P");
//p1 = Console.ReadLine();
//p = double.Parse(p1);
//Console.WriteLine(" ");
//double[] a = new double[n + 1];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//	a[n] = 0;
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//int ii = 0; //индекс после которого нужен p
//for (int i = n-1; i>=0; i--)
//{
//	ii = i;
//	if (a[i] > 0) break;
//}
//for (int i = n - 1; i >= ii+1; i--)
//{
//	a[i + 1] = a[i];
//}
//a[ii + 1] = p;
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n + 1; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//12
//string x1, n1;
//double s=0,x, max = -9999999999999999;
//int n,imax=0,imin=0;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//for (int i=0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//	if (a[i] > max)
//	{
//		max = a[i];
//		imax = i;
//	}
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n; i++)
//{
//	imin = i;
//	if (a[i] < 0) break;
//}
//for (int i = imax+1; i < n; i++)
//{
//	s += a[i];	
//}
//a[imin] = s;
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//13
//string x1, n1;
//double s = 0, x, max = -9999999999999999;
//int n, imax = 0;
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
//	if (a[i] > max && i%2==0)
//	{
//		max = a[i];
//		imax = i; //индекс
//	}
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n; i++)
//{
//	if (a[i]==max) a[i] = i;
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//14
//string x1, n1;
//double s = 0, x, max = -9999999999999999;
//int n, imax = 0, imin = 0;
//double o, m;
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
//	if (a[i] > max)
//	{
//		max = a[i];
//		imax = i; 
//	}
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n; i++)
//{
//	imin = i; //первый отрицательный
//	if (a[i] < 0) break;
//}
//o = a[imax]; //первый отрицательный
//m = a[imin]; //максимальный
//a[imin] = o;
//a[imax] = m;
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//15
//string x11, n1, x22,m1,k1;
//double s = 0, x1,x2;
//int n, m,k;
//Console.WriteLine("Введите размер массива A");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите k");
//k1 = Console.ReadLine();
//k = int.Parse(k1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите размер массива B");
//m1 = Console.ReadLine();
//m = int.Parse(m1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//double[] b = new double[m];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива A");
//	x11 = Console.ReadLine();
//	x1 = double.Parse(x11);
//	a[i] = x1;
//	Console.WriteLine(" ");
//}
//for (int i = 0; i < m; i++)
//{
//	Console.WriteLine("Введите число массива B");
//	x22 = Console.ReadLine();
//	x2= double.Parse(x22);
//	b[i] = x2;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив A: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");
//Console.WriteLine("Ваш массив B: ");
//for (int i = 0; i < m; i++)
//{
//	Console.Write($"{b[i]} ");
//}
//Console.WriteLine(" ");
//int q = 0;
//double[] c = new double[n + m];
//for (int i=0; i<k+1;i++)
//{
//	c[i] = a[i];
//}
//for (int i=k+1; i<k+1+m;i++)
//{ 
//	c[i] = b[q];
//	q++;
//}
//if (q <= n)
//{
//	for (int i = k + m + 1; i < m + n; i++)
//	{
//		c[i] = a[q];
//		q++;
//	}
//}
//else
//{
//	q = n-1;
//	for (int i = n+m-1; i >= m+k+1; i--)
//	{
//		c[i] = a[q];
//		q--;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Массив А с добавлением массива В после элемента с индексом {k}: ");
//for (int i = 0; i < n+m; i++)
//{
//	Console.Write($"{c[i]} ");
//}
//Console.WriteLine(" ");



//16
//string x1, n1;
//double x, s = 0, k = 0, sr;
//int n,ii=0;
//Console.WriteLine("Введите размер массива");
//n1 = Console.ReadLine();
//n = int.Parse(n1);
//Console.WriteLine(" ");
//double[] a = new double[n];
//double[] b = new double[n];
//for (int i = 0; i < n; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x1 = Console.ReadLine();
//	x = double.Parse(x1);
//	a[i] = x;
//	Console.WriteLine(" ");
//	k++;
//	s += a[i];
//}
//sr = s / k;
//int q = 0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//	if (a[i] < sr)
//	{
//		b[q] = i;
//		q++;
//		ii++;
//	}
//}
//Console.WriteLine(" "); 
//Console.WriteLine(" ");
//Console.WriteLine($"Индексы элементов, меньших чем среднее арифметическое ({sr}):");
//for (int i = 0; i < ii; i++)
//{
//	Console.Write($"{b[i]} ");
//}
//Console.WriteLine(" ");



//17
//string x1, n1;
//double x, max = -999999999999999999, min = 99999999999999999;
//int n,imax=0,imin=0;
//double srp = 0, srm = 0, kp = 0, km = 0, sp = 0, sm = 0;
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
//	if (a[i] > max)
//	{
//		max = a[i];
//		imax = i; //индес max
//	}
//	if (a[i] < min)
//	{
//		min = a[i];
//		imin = i; //индекс min
//	}
//	if (a[i]>0)
//	{
//		kp++;
//		sp += a[i];
//	}
//	if (a[i]<0)
//	{
//		km++;
//		sm += a[i];
//	}
//}
//Console.WriteLine(" ");
//srp = sp / kp;
//srm = sm / km;
//Console.WriteLine(" ");
//if (imax < imin)
//{
//	Console.WriteLine($"Среднее арифметическое положительных элементов: {srp}");
//}
//else
//{
//	Console.WriteLine($"Среднее арифметическое отрицательных элементов: {srm}");
//}
//Console.WriteLine(" ");



//18
//string x1, n1;
//double x, maxch = -999999999999999999, maxnch = -99999999999999999;
//int n, ich = 0, inch = 0;
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
//	if (i % 2 == 0)
//	{
//		if (a[i] > maxch)
//		{
//			maxch = a[i];
//			ich = i; //индес max
//		}
//	}
//	else
//	{
//		if (a[i] > maxnch)
//		{
//			maxnch = a[i];
//			inch = i; //индекс min
//		}
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//if (maxch > maxnch)
//{
//	for (int i=0; i<n/2; i++)
//	{
//		a[i] = 0;
//	}
//}
//else
//{
//	for (int i = n/2; i < n; i++)
//	{
//		a[i] = 0;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//19
//string x1, n1;
//double s=0,x, max = -999999999999999999;
//int n,ii=0;
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
//	if (a[i] > max)
//	{
//		max = a[i];
//		ii = i;
//	}
//	s += a[i];
//}
//if (max > s - a[ii]) a[ii] = 0;
//else a[ii] = a[ii] * 2;
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n; i++)
//{
//	Console.Write($"{a[i]} ");
//}
//Console.WriteLine(" ");



//20
//string x1, n1;
//double x, min=9999999999999, sch=0, snch=0;
//int n, imin=0, io=0;
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
//	if (a[i] < min)
//	{
//		min = a[i];
//		imin = i;
//	}
//	if (i % 2 == 0) sch += a[i];
//	else snch += a[i];
//}
//for (int i = 0; i < n; i++)
//{ 
//	if (a[i] < 0) 
//	{ 
//		io = i;
//		break;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//if (io < imin) Console.WriteLine($"Сумма элементов с чётными индексами: {sch}");
//else Console.WriteLine($"Сумма элементов с нечётными индексами: {snch}");

//3 уровень (задача 3)
//using System;

//class Program
{
    //static void Main()
    //{
        //int[] array = { 1, 2, 3, 4, 5, 10, 6, 7, 8, 9 };

        //int maxElement = array[0];
        //int maxIndex = 0;
        //for (int i = 1; i < array.Length; i++)
        //{
            //if (array[i] > maxElement)                                   // Находим максимальный элемент и его индекс
            //{
                //maxElement = array[i];
                //maxIndex = i;
            //}
        //}

        //for (int i = 0; i < maxIndex - 1; i += 2)
        //{
            //int temp = array[i];
            //array[i] = array[i + 1];                                     // Меняем соседние элементы
            //array[i + 1] = temp;
        //}

        //int start = maxIndex + 1;
        //int end = array.Length - 1;
        //while (start < end)
        //{
            //int temp = array[start];                                    // Задаем значение переменной temp, равное элементу массива после максимального
            //array[start] = array[end];                                  // Меняем элемент массива после максимального на последний элемент массива
            //array[end] = temp;                                          // Меняем последний элемент массива на элемент массива после максимального

            //start++;
            //end--;
        //}

        //Console.WriteLine("Результат:");
        //foreach (int element in array)
        //{
            //Console.Write(element + " ");
        //}
        //Console.WriteLine();
    //}
//}
