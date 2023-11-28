#region 1_1

string m1;
double x1, s1 = 0;
double[] a1 = new double[6];
for (int i = 0; i < 6; i++) //ввод массива
{
	Console.WriteLine("Введите число массива");
	m1 = Console.ReadLine();
	x1 = double.Parse(m1);
	a1[i] = x1;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 6; i++) //вывод массива
{
	Console.Write($"{a1[i]} ");
}
Console.WriteLine(" ");
for (int i = 0; i < 6; i++) //действия с массивом
{
	s1 += a1[i];
}
Console.WriteLine($"Сумма элементов: {s1}");
Console.WriteLine(" ");
Console.WriteLine("Массив, делённый на сумму его элементов: ");
for (int i = 0; i < 6; i++) //вывод окончательно
{
	a1[i] = a1[i] / s1;
	Console.Write($"{a1[i] / s1} ");
}
Console.WriteLine(" ");

#endregion

#region 1_2
string m2;
double x2, s2 = 0, k2 = 0;
double[] a2 = new double[8];
for (int i = 0; i < 8; i++) //ввод массива
{
	Console.WriteLine("Введите число массива");
	m2 = Console.ReadLine();
	x2 = double.Parse(m2);
	a2[i] = x2;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 8; i++) //вывод массива
{
	Console.Write($"{a2[i]} ");
}
Console.WriteLine(" ");
for (int i = 0; i < 8; i++) //действия с массивом
{
	if (a2[i] > 0)
	{
		s2 += a2[i];
		k2 += 1;
	}
}
Console.WriteLine($"Среднее арифметическое среди положительных: {s2 / k2}");
Console.WriteLine(" ");
Console.WriteLine("Массив окончатльный: ");
for (int i = 0; i < 8; i++) //вывод окончательно
{
	if (a2[i] > 0)
	{
		a2[i] = s2 / k2;
	}
	Console.Write($"{a2[i]} ");
}
Console.WriteLine(" ");


#endregion

#region 1_3
string a32, b32;
double a31, b31;
double[] a3 = new double[4];
double[] b3 = new double[4];
double[] c3 = new double[4];
double[] d3 = new double[4];
for (int i = 0; i < 4; i++) //ввод массива a3
{
	Console.WriteLine("Введите число первого массива");
	a32 = Console.ReadLine();
	a31 = double.Parse(a32);
	a3[i] = a31;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш первый массив:");
for (int i = 0; i < 4; i++) //вывод массива a3
{
	Console.Write($"{a3[i]} ");
}
Console.WriteLine(" ");

for (int i = 0; i < 4; i++) //ввод массива b3
{
	Console.WriteLine("Введите число второго массива");
	b32 = Console.ReadLine();
	b31 = double.Parse(b32);
	b3[i] = b31;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш второй массив:");
for (int i = 0; i < 4; i++) //вывод массива b3
{
	Console.Write($"{b3[i]} ");
}
Console.WriteLine(" ");
for (int i = 0; i < 4; i++) //действия с массивами
{
	c3[i] = a3[i] + b3[i];
	d3[i] = a3[i] - b3[i];
}
Console.WriteLine("Массив с: ");
for (int i = 0; i < 4; i++) //вывод массива с3
{
	Console.Write($"{c3[i]} ");
}
Console.WriteLine(" ");
Console.WriteLine("Массив d: ");
for (int i = 0; i < 4; i++) //вывод массива с3
{
	Console.Write($"{d3[i]} ");
}
Console.WriteLine(" ");
#endregion

#region 1_4
string m4;
double x4, sr4 = 0, s4 = 0, k4 = 0;
double[] a4 = new double[5];
for (int i = 0; i < 5; i++) //ввод массива a
{
	Console.WriteLine("Введите число массива");
	m4 = Console.ReadLine();
	x4 = double.Parse(m4);
	a4[i] = x4;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 5; i++) //вывод массива a
{
	Console.Write($"{a4[i]} ");
}
Console.WriteLine(" ");
for (int i = 0; i < 5; i++)
{
	s4 += a4[i];
	k4++;
}
sr4 = s4 / k4;
for (int i = 0; i < 5; i++)
{
	a4[i] = a4[i] - sr4;
	Console.Write($"{a4[i]} ");
}
Console.WriteLine(" ");
#endregion

#region 1_5
string x51, x52;
double[] a5 = new double[4];
for (int i = 0; i < 4; i++)
{
	Console.WriteLine($"Введите координату {i + 1} первого вектора");
	x51 = Console.ReadLine();
	a5[i] = double.Parse(x51);
	Console.WriteLine(" ");
}
double[] b5 = new double[4];
for (int i = 0; i < 4; i++)
{
	Console.WriteLine($"Введите координату {i + 1} второго вектора");
	x52 = Console.ReadLine();
	b5[i] = double.Parse(x52);
	Console.WriteLine(" ");
}
double s5 = 0;
for (int i = 0; i < 4; i++)
{
	s5 += a5[i] * b5[i];
}
Console.WriteLine($"Скалярное произведение равно: {s5}");
Console.WriteLine(" ");

#endregion

#region 1_6
string x61;
double[] a6 = new double[5];
for (int i = 0; i < 5; i++)
{
	Console.WriteLine($"Введите координату {i + 1} вектора L");
	x61 = Console.ReadLine();
	a6[i] = double.Parse(x61);
	Console.WriteLine(" ");
}
double s6 = 0;
for (int i = 0; i < 5; i++)
{
	s6 += a6[i] * a6[i];
}
Console.WriteLine($"Длина вектора L: {Math.Pow(s6, 0.5)}");
Console.WriteLine(" ");

#endregion

#region 1_7
string x71;
double x7, sr7 = 0, s7 = 0, k7 = 0;
double[] a7 = new double[7];
for (int i = 0; i < 7; i++) //ввод массива a
{
	Console.WriteLine("Введите число массива");
	x71 = Console.ReadLine();
	x7 = double.Parse(x71);
	a7[i] = x7;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 7; i++) //вывод массива a
{
	Console.Write($"{a7[i]} ");
}
Console.WriteLine(" ");
for (int i = 0; i < 7; i++)
{
	s7 += a7[i];
	k7++;
}
sr7 = s7 / k7;
for (int i = 0; i < 7; i++)
{
	if (a7[i] > sr7) a7[i] = 0;
	Console.Write($"{a7[i]} ");
}
Console.WriteLine(" ");

#endregion

#region 1_8
string x81;
double x8, k8 = 0;
double[] a8 = new double[6];
for (int i = 0; i < 6; i++) //ввод массива a
{
	Console.WriteLine("Введите число массива");
	x81 = Console.ReadLine();
	x8 = double.Parse(x81);
	a8[i] = x8;
	Console.WriteLine(" ");
	if (x8 < 0) k8++;
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 6; i++) //вывод массива a
{
	Console.Write($"{a8[i]} ");
}
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine($"Количество отрицательных элементов: {k8}");
Console.WriteLine(" ");


#endregion

#region 1_9
string m9;
double x9, sr9 = 0, s9 = 0, k9 = 0, k91 = 0;
double[] a9 = new double[8];
for (int i = 0; i < 8; i++) //ввод массива a
{
	Console.WriteLine("Введите число массива");
	m9 = Console.ReadLine();
	x9 = double.Parse(m9);
	a9[i] = x9;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 8; i++) //вывод массива a
{
	Console.Write($"{a9[i]} ");
	s9 += a9[i];
	k9++;
}
Console.WriteLine(" ");
sr9 = s9 / k9;
Console.WriteLine($"Среднее значение: {sr9}");
for (int i = 0; i < 8; i++)
{
	if (a9[i] > sr9) k91++;
}
Console.WriteLine($"Элементов, больших, чем среднее значение: {k91}");
Console.WriteLine(" ");


#endregion

#region 1_10 !!!!!!!!!!!!!!!!!!!!!!!
//string x101, P101, Q101;
//double x10, P10, Q10, k10 = 0;
//double[] a10 = new double[10];
//Console.WriteLine("Введите P");
//P101 = Console.ReadLine();
//P10 = double.Parse(P101);
//Console.WriteLine("Введите Q10");
//Q101 = Console.ReadLine();
//P10 = double.Parse(P101);
//for (int i = 0; i < 10; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x101 = Console.ReadLine();
//	P10 = double.Parse(P101);
//	a10[i] = x10;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив:");
//for (int i = 0; i < 10; i++) //вывод массива a
//{
//	Console.Write($"{a10[i]} ");
//	if (P10 <= a10[i] && a10[i] <= Q10) k10 += 1;
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Количество элементов, заключённых между P и Q: {k10}");
//Console.WriteLine(" ");

#endregion

#region 1_11
string m11;
double x11;
int k11 = 0;
double[] a11 = new double[10];
double[] b11 = new double[10];
for (int i = 0; i < 10; i++) //ввод массива a
{
	Console.WriteLine("Введите число массива");
	m11 = Console.ReadLine();
	x11 = double.Parse(m11);
	a11[i] = x11;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 10; i++) //вывод массива a
{
	Console.Write($"{a11[i]} ");
	if (a11[i] > 0)
	{
		b11[k11] = a11[i];
		k11++;
	}
}
Console.WriteLine(" ");
Console.WriteLine("Массив, состоящий из положительных элементов вашего массива:");
for (int i = 0; i < 10; i++) //вывод массива b
{
	if (b11[i] == 0) break;
	Console.Write($"{b11[i]} ");
}

#endregion

#region 1_12
string m12;
double x12, ai12 = 0, ao12 = 0;
double[] a12 = new double[8];
for (int i = 0; i < 8; i++) //ввод массива a
{
	Console.WriteLine("Введите число массива");
	m12 = Console.ReadLine();
	x12 = double.Parse(m12);
	a12[i] = x12;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 8; i++) //вывод массива a
{
	Console.Write($"{a12[i]} ");
}
Console.WriteLine(" ");
for (int i = 7; i >= 0; i--)
{
	ai12 = i;
	ao12 = a12[i];
	if (a12[i] < 0) break;
}
Console.WriteLine($"Последний отрицательный элемент массива = {ao12}, его номер: {ai12}");
Console.WriteLine(" ");
#endregion

#region 1_13
string m13;
double x13;
int kn13 = 0, kc13 = 0;
double[] a13 = new double[10];
double[] ach13 = new double[5];
double[] anch13 = new double[5];
for (int i = 0; i < 10; i++) //ввод массива a
{
	Console.WriteLine("Введите число массива");
	m13 = Console.ReadLine();
	x13 = double.Parse(m13);
	a13[i] = x13;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 10; i++) //вывод массива a
{
	Console.Write($"{a13[i]} ");
	if (i % 2 == 0)
	{
		ach13[kc13] = a13[i];
		kc13++;
	}
	else
	{
		anch13[kn13] = a13[i];
		kn13 += 1;
	}
}
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Массив с чётными индексами: ");
for (int i = 0; i < 5; i++) //вывод массива ach
{
	Console.Write($"{ach13[i]} ");
}
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Массив с нечётными индексами: ");
for (int i = 0; i < 5; i++) //вывод массива anch
{
	Console.Write($"{anch13[i]} ");
}
Console.WriteLine(" ");

#endregion

#region 1_14
string m14;
double x14, s14 = 0;
double[] a14 = new double[11];
for (int i = 0; i < 11; i++) //ввод массива a
{
	Console.WriteLine("Введите число массива");
	m14 = Console.ReadLine();
	x14 = double.Parse(m14);
	a14[i] = x14;
	Console.WriteLine(" ");
}
Console.WriteLine("Ваш массив:");
for (int i = 0; i < 10; i++) //вывод массива a
{
	Console.Write($"{a14[i]} ");
}
Console.WriteLine(" ");
for (int i = 0; i < 10; i++)
{
	if (a14[i] < 0) break;
	s14 += a14[i] * a14[i];
}
Console.WriteLine($"Сумма квадратов элементов, расположенных до первого отрицательного: {s14}");
Console.WriteLine(" ");

#endregion

#region 1_15

string m15;
double x15;
double[] X15 = new double[10];
double[] Y15 = new double[10];
for (int i = 0; i < 10; i++) 
{
	Console.WriteLine("Введите число массива");
	m15 = Console.ReadLine();
	x15 = double.Parse(m15);
	X15[i] = x15;
	Console.WriteLine(" ");
}
Console.WriteLine("y15 = 0.5ln(x15)");
for (int i = 0; i < 10; i++) 
{
	Y15[i] = 0.5 * Math.Log(X15[i]);
	Console.WriteLine("x15={0:f5}, y15={1:f5}", X15[i], Y15[i]);
}
#endregion

