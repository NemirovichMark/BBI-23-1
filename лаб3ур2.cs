
//#region 2_1
//string x1_1, n1_1;
//double x1, min1 = 9999999999999999999;
//int n1;
//Console.WriteLine("Введите размер массива");
//n1_1 = Console.ReadLine();
//n1 = int.Parse(n1_1);
//Console.WriteLine(" ");
//double[] a1 = new double[n1];
//for (int i = 0; i < n1; i++) 
//{
//	Console.WriteLine("Введите число массива");
//	x1_1 = Console.ReadLine();
//	x1 = double.Parse(x1_1);
//	a1[i] = x1;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n1; i++) 
//{
//	Console.Write($"{a1[i]} ");
//	if (a1[i] < min1) min1 = a1[i];
//}
//Console.WriteLine(" ");
//Console.WriteLine("Массив с увеличенным вдвое минимальным элементом: ");
//for (int i = 0; i < n1; i++) 
//{
//	if (a1[i] == min1) a1[i] = min1 * 2;
//	Console.Write($"{a1[i]} ");
//}
//Console.WriteLine(" ");

//#endregion

//#region 2_2

//string x2_1, n2_1;
//double x2, s2 = 0, max2 = -999999999999999999;
//int n2;
//Console.WriteLine("Введите размер массива");
//n2_1 = Console.ReadLine();
//n2 = int.Parse(n2_1);
//Console.WriteLine(" ");
//double[] a2 = new double[n2];
//for (int i = 0; i < n2; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x2_1 = Console.ReadLine();
//	x2 = double.Parse(x2_1);
//	a2[i] = x2;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n2; i++)
//{
//	Console.Write($"{a2[i]} ");
//	if (a2[i] > max2) max2 = a2[i];
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n2; i++)
//{
//	if (a2[i] == max2) break;
//	s2 += a2[i];
//}
//Console.WriteLine($"Сумма элементов, расположенных до максимального: {s2}");

////#endregion

//#region 2_3

//string x3_1, n3_1;
//double x3, min3 = 999999999999999999;
//int n3;
//Console.WriteLine("Введите размер массива");
//n3_1 = Console.ReadLine();
//n3 = int.Parse(n3_1);
//Console.WriteLine(" ");
//double[] a3 = new double[n3];
//for (int i = 0; i < n3; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x3_1 = Console.ReadLine();
//	x3 = double.Parse(x3_1);
//	a3[i] = x3;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n3; i++)
//{
//	Console.Write($"{a3[i]} ");
//	if (a3[i] < min3) min3 = a3[i];
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n3; i++)
//{
//	if (a3[i] == min3) break;
//	a3[i] = a3[i] * 2;
//}
//Console.WriteLine("Массив с увеличенными вдвое элементами перед минимальным: ");
//for (int i = 0; i < n3; i++)
//{
//	Console.Write($"{a3[i]} ");
//}
//Console.WriteLine(" ");


//#endregion

//#region 2_4
//string x4_1, n4_1;
//double x4, s4 = 0, k4 = 0, max4 = -999999999999999999;
//int n4;
//Console.WriteLine("Введите размер массива");
//n4_1 = Console.ReadLine();
//n4 = int.Parse(n4_1);
//Console.WriteLine(" ");
//double[] a4 = new double[n4];
//for (int i = 0; i < n4; i++) //ввод массива a
//{
//	Console.WriteLine("Введите число массива");
//	x4_1 = Console.ReadLine();
//	x4 = double.Parse(x4_1);
//	a4[i] = x4;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n4; i++)
//{
//	Console.Write($"{a4[i]} ");
//	k4++;
//	s4 += a4[i];
//	if (a4[i] > max4) max4 = a4[i];
//}
//Console.WriteLine(" ");
//for (int i = n4 - 1; i >= 0; i--)
//{
//	if (a4[i] == max4) break;
//	a4[i] = s4 / k4;
//}
//Console.WriteLine(" ");
//Console.WriteLine("Изменённый массив: ");
//for (int i = 0; i < n4; i++)
//{
//	Console.Write($"{a4[i]} ");
//}
//Console.WriteLine(" ");

//#endregion

//#region 2_5
//string x5_1, n5_1;
//double x5, max5 = -999999999999999999, min5 = 99999999999999999;
//int n5;
//Console.WriteLine("Введите размер массива");
//n5_1 = Console.ReadLine();
//n5 = int.Parse(n5_1);
//Console.WriteLine(" ");
//double[] a5 = new double[n5];
//for (int i = 0; i < n5; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x5_1 = Console.ReadLine();
//	x5 = double.Parse(x5_1);
//	a5[i] = x5;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n5; i++)
//{
//	Console.Write($"{a5[i]} ");
//	if (a5[i] > max5) max5 = a5[i];
//	if (a5[i] < min5) min5 = a5[i];
//}
//Console.WriteLine(" ");
//int k5 = 0;
//double[] b5 = new double[n5];
//for (int i = 0; i < n5; i++)
//{
//	if (a5[i] < 0)
//	{
//		if (min5 <= a5[i] && a5[i] <= max5)
//		{
//			b5[k5] = a5[i];
//			k5++;
//		}
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Массив, созхданный из отрицательных элементов между минимальным ({min5}) и максимальным ({max5}): ");
//for (int i = 0; i < n5; i++)
//{
//	if (b5[i] == 0) break;
//	Console.Write($"{b5[i]} ");
//}
//Console.WriteLine(" "); //!!!!!!!!!!!!!!!!!!!!!!!!



//#endregion

//#region 2_6
//string x6_1, n6_1, p6_1;
//double p6, x6, s6 = 0, k6 = 0, sr6, minr6 = 999999999999999;
//int n6;
//Console.WriteLine("Введите размер массива");
//n6_1 = Console.ReadLine();
//n6 = int.Parse(n6_1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите P6");
//p6_1 = Console.ReadLine();
//p6 = double.Parse(p6_1);
//Console.WriteLine(" ");
//double[] a6 = new double[n6 + 1];
//for (int i = 0; i < n6; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x6_1 = Console.ReadLine();
//	x6 = double.Parse(x6_1);
//	a6[i] = x6;
//	Console.WriteLine(" ");
//	a6[n6] = 0;
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n6; i++)
//{
//	Console.Write($"{a6[i]} ");
//	k6++;
//	s6 += a6[i];
//}
//sr6 = s6 / k6;
//Console.WriteLine(" ");
//int ii6 = 0; //индекс после которого нужен p
//for (int i = 0; i < n6; i++)
//{
//	if (Math.Abs(a6[i] - sr6) < minr6)
//	{
//		minr6 = Math.Abs(a6[i] - sr6);
//		ii6 = i;
//	}
//}
//for (int i = n6 - 1; i >= ii6; i--)
//{
//	a6[i + 1] = a6[i];
//}
//a6[ii6 + 1] = p6;
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n6 + 1; i++)
//{
//	Console.Write($"{a6[i]} ");
//}
//Console.WriteLine(" ");


//#endregion

//#region 2_7
//string x7_1, n7_1;
//double x7, max7 = -999999999999999;
//int n7;
//Console.WriteLine("Введите размер массива");
//n7_1 = Console.ReadLine();
//n7 = int.Parse(n7_1);
//Console.WriteLine(" ");
//double[] a7 = new double[n7];
//for (int i = 0; i < n7; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x7_1 = Console.ReadLine();
//	x7 = double.Parse(x7_1);
//	a7[i] = x7;
//	Console.WriteLine(" ");
//}
//int ii7 = 0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n7; i++)
//{
//	Console.Write($"{a7[i]} ");
//	if (a7[i] > max7)
//	{
//		max7 = a7[i];
//		ii7 = i;
//	}
//}
//a7[ii7 + 1] = 2 * a7[ii7 + 1];
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n7; i++)
//{
//	Console.Write($"{a7[i]} ");
//}
//Console.WriteLine(" ");



//#endregion

//#region 2_8
//string x8_1, n8_1;
//double p8, p8_1, x8, max8 = -999999999999999, min8 = 99999999999999;
//int n8;
//Console.WriteLine("Введите размер массива");
//n8_1 = Console.ReadLine();
//n8 = int.Parse(n8_1);
//Console.WriteLine(" ");
//double[] a8 = new double[n8];
//for (int i = 0; i < n8; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x8_1 = Console.ReadLine();
//	x8 = double.Parse(x8_1);
//	a8[i] = x8;
//	Console.WriteLine(" ");
//}
//int imin8 = 0, imax8 = 0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n8; i++)
//{
//	Console.Write($"{a8[i]} ");
//	if (a8[i] > max8)
//	{
//		max8 = a8[i];
//		imin8 = i;
//	}
//}
//Console.WriteLine(" ");
//p8 = a8[imin8]; //макимальное значение элемента в массиве, равен max
//for (int i = imin8; i < n8; i++)
//{
//	if (a8[i] < min8)
//	{
//		min8 = a8[i];
//		imax8 = i;
//	}
//}
//p8_1 = a8[imax8];
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n8; i++)
//{
//	a8[imin8] = p8_1;
//	a8[imax8] = p8;
//	Console.Write($"{a8[i]} ");
//}
//#endregion

//#region 2_9
//string x9_1, n9_1;
//double x9, max9 = -999999999999999999, min9 = 99999999999999999;
//int n9;
//Console.WriteLine("Введите размер массива");
//n9_1 = Console.ReadLine();
//n9 = int.Parse(n9_1);
//Console.WriteLine(" ");
//double[] a9 = new double[n9];
//for (int i = 0; i < n9; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x9_1 = Console.ReadLine();
//	x9 = double.Parse(x9_1);
//	a9[i] = x9;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n9; i++)
//{
//	Console.Write($"{a9[i]} ");
//	if (a9[i] > max9) max9 = a9[i];
//	if (a9[i] < min9) min9 = a9[i];
//}
//Console.WriteLine(" ");
//int k9 = 0;
//double s9 = 0;
//for (int i = 0; i < n9; i++)
//{
//	if (min9 <= a9[i] && a9[i] <= max9)
//	{
//		k9++;
//		s9 += a9[i];
//	}
//}
//double sr9;
//sr9 = s9 / k9;
//Console.WriteLine(" ");
//Console.WriteLine($"Среднее арифметическое между минимальным ({min9}) и максимальным ({max9}) элементами: {sr9}");


//#endregion

//#region 2_10
//string x10_1, n10_1;
//double x10, min10 = 99999999999999999;
//int n10;
//Console.WriteLine("Введите размер массива");
//n10_1 = Console.ReadLine();
//n10 = int.Parse(n10_1);
//Console.WriteLine(" ");
//double[] a10 = new double[n10];
//for (int i = 0; i < n10; i++)
//{
//	Console.WriteLine("Введите число массива");
//    x10_1 = Console.ReadLine();
//    x10 = double.Parse(x10_1);
//	a10[i] = x10;
//	Console.WriteLine(" ");
//}
//int ii10 = 0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n10; i++)
//{
//	Console.Write($"{a10[i]} ");
//	if (a10[i] < min10 && a10[i] > 0)
//	{
//		min10 = a10[i];
//		ii10 = i;
//	}
//}
//Console.WriteLine(" ");
//for (int i = ii10 + 1; i < n10; i++)
//{
//	a10[i - 1] = a10[i];
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n10 - 1; i++)
//{
//	Console.Write($"{a10[i]} ");
//}


//#endregion

//#region 2_11
//string x11_1, n11_1, p11_1;
//double p11, x11;
//int n11;
//Console.WriteLine("Введите размер массива");
//n11_1 = Console.ReadLine();
//n11 = int.Parse(n11_1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите P");
//p11_1 = Console.ReadLine();
//p11 = double.Parse(p11_1);
//Console.WriteLine(" ");
//double[] a11 = new double[n11 + 1];
//for (int i = 0; i < n11; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x11_1 = Console.ReadLine();
//	x11 = double.Parse(x11_1);
//	a11[i] = x11;
//	Console.WriteLine(" ");
//	a11[n11] = 0;
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n11; i++)
//{
//	Console.Write($"{a11[i]} ");
//}
//Console.WriteLine(" ");
//int ii11 = 0; //индекс после которого нужен p
//for (int i = n11 - 1; i >= 0; i--)
//{
//	ii11 = i;
//	if (a11[i] > 0) break;
//}
//for (int i = n11 - 1; i >= ii11 + 1; i--)
//{
//	a11[i + 1] = a11[i];
//}
//a11[ii11 + 1] = p11;
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n11 + 1; i++)
//{
//	Console.Write($"{a11[i]} ");
//}
//Console.WriteLine(" ");

//#endregion

//#region 2_12
//string x12_1, n12_1;
//double s12 = 0, x12, max12 = -9999999999999999;
//int n12, imax12 = 0, imin12 = 0;
//Console.WriteLine("Введите размер массива");
//n12_1 = Console.ReadLine();
//n12 = int.Parse(n12_1);
//Console.WriteLine(" ");
//double[] a12 = new double[n12];
//for (int i = 0; i < n12; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x12_1 = Console.ReadLine();
//	x12 = double.Parse(x12_1);
//	a12[i] = x12;
//	Console.WriteLine(" ");
//	if (a12[i] > max12)
//	{
//		max12 = a12[i];
//		imax12 = i;
//	}
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n12; i++)
//{
//	Console.Write($"{a12[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n12; i++)
//{
//	imin12 = i;
//	if (a12[i] < 0) break;
//}
//for (int i = imax12 + 1; i < n12; i++)
//{
//	s12 += a12[i];
//}
//a12[imin12] = s12;
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n12; i++)
//{
//	Console.Write($"{a12[i]} ");
//}
//Console.WriteLine(" ");
//#endregion

//#region 2_13
//string x13_1, n13_1;
//double s13 = 0, x13, max13 = -9999999999999999;
//int n13, imax13 = 0;
//Console.WriteLine("Введите размер массива");
//n13_1 = Console.ReadLine();
//n13 = int.Parse(n13_1);
//Console.WriteLine(" ");
//double[] a13 = new double[n13];
//for (int i = 0; i < n13; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x13_1 = Console.ReadLine();
//	x13 = double.Parse(x13_1);
//	a13[i] = x13;
//	Console.WriteLine(" ");
//	if (a13[i] > max13 && i % 2 == 0)
//	{
//		max13 = a13[i];
//		imax13 = i; //индекс
//	}
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n13; i++)
//{
//	Console.Write($"{a13[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n13; i++)
//{
//	if (a13[i] == max13) a13[i] = i;
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n13; i++)
//{
//	Console.Write($"{a13[i]} ");
//}
//Console.WriteLine(" ");
//#endregion

//#region 2_14
//string x14_1, n14_1;
//double s14 = 0, x14, max14 = -9999999999999999;
//int n14, imax14 = 0, imin14 = 0;
//double o14, m14;
//Console.WriteLine("Введите размер массива");
//n14_1 = Console.ReadLine();
//n14 = int.Parse(n14_1);
//Console.WriteLine(" ");
//double[] a14 = new double[n14];
//for (int i = 0; i < n14; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x14_1 = Console.ReadLine();
//	x14 = double.Parse(x14_1);
//	a14[i] = x14;
//	Console.WriteLine(" ");
//	if (a14[i] > max14)
//	{
//		max14 = a14[i];
//		imax14 = i;
//	}
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n14; i++)
//{
//	Console.Write($"{a14[i]} ");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n14; i++)
//{
//	imin14 = i; //первый отрицательный
//	if (a14[i] < 0) break;
//}
//o14 = a14[imax14]; //первый отрицательный
//m14 = a14[imin14]; //максимальный
//a14[imin14] = o14;
//a14[imax14] = m14;
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n14; i++)
//{
//	Console.Write($"{a14[i]} ");
//}
//Console.WriteLine(" ");


//#endregion

//#region 2_15
//string x15_11, n15_1, x15_22, m15_1, k15_1;
//double s15 = 0, x15_1, x15_2;
//int n15, m15, k15;
//Console.WriteLine("Введите размер массива A15");
//n15_1 = Console.ReadLine();
//n15 = int.Parse(n15_1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите k15");
//k15_1 = Console.ReadLine();
//k15 = int.Parse(k15_1);
//Console.WriteLine(" ");
//Console.WriteLine("Введите размер массива B15");
//m15_1 = Console.ReadLine();
//m15 = int.Parse(m15_1);
//Console.WriteLine(" ");
//double[] a15 = new double[n15];
//double[] b15 = new double[m15];
//for (int i = 0; i < n15; i++)
//{
//	Console.WriteLine("Введите число массива A15");
//	x15_11 = Console.ReadLine();
//	x15_1 = double.Parse(x15_11);
//	a15[i] = x15_1;
//	Console.WriteLine(" ");
//}
//for (int i = 0; i < m15; i++)
//{
//	Console.WriteLine("Введите число массива B15");
//	x15_22 = Console.ReadLine();
//	x15_2 = double.Parse(x15_22);
//	b15[i] = x15_2;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив A15: ");
//for (int i = 0; i < n15; i++)
//{
//	Console.Write($"{a15[i]} ");
//}
//Console.WriteLine(" ");
//Console.WriteLine("Ваш массив B15: ");
//for (int i = 0; i < m15; i++)
//{
//	Console.Write($"{b15[i]} ");
//}
//Console.WriteLine(" ");
//int q15 = 0;
//double[] c15 = new double[n15 + m15];
//for (int i = 0; i < k15 + 1; i++)
//{
//	c15[i] = a15[i];
//}
//for (int i = k15 + 1; i < k15 + 1 + m15; i++)
//{
//	c15[i] = b15[q15];
//	q15++;
//}
//if (q15 <= n15)
//{
//	for (int i = k15 + m15 + 1; i < m15 + n15; i++)
//	{
//		c15[i] = a15[q15];
//		q15++;
//	}
//}
//else
//{
//	q15 = n15 - 1;
//	for (int i = n15 + m15 - 1; i >= m15 + k15 + 1; i--)
//	{
//		c15[i] = a15[q15];
//		q15--;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Массив А15 с добавлением массива В15 после элемента с индексом {k15}: ");
//for (int i = 0; i < n15 + m15; i++)
//{
//	Console.Write($"{c15[i]} ");
//}
//Console.WriteLine(" ");



//#endregion

//#region 2_16
//string x16_1, n16_1;
//double x16, s16 = 0, k16 = 0, sr16;
//int n16, ii16 = 0;
//Console.WriteLine("Введите размер массива");
//n16_1 = Console.ReadLine();
//n16 = int.Parse(n16_1);
//Console.WriteLine(" ");
//double[] a16 = new double[n16];
//double[] b16 = new double[n16];
//for (int i = 0; i < n16; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x16_1 = Console.ReadLine();
//	x16 = double.Parse(x16_1);
//	a16[i] = x16;
//	Console.WriteLine(" ");
//	k16++;
//	s16 += a16[i];
//}
//sr16 = s16 / k16;
//int q16 = 0;
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n16; i++)
//{
//	Console.Write($"{a16[i]} ");
//	if (a16[i] < sr16)
//	{
//		b16[q16] = i;
//		q16++;
//		ii16++;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Индексы элементов, меньших чем среднее арифметическое ({sr16}):");
//for (int i = 0; i < ii16; i++)
//{
//	Console.Write($"{b16[i]} ");
//}
//Console.WriteLine(" ");


//#endregion

//#region 2_17
//string x17_1, n17_1;
//double x17, max17 = -999999999999999999, min17 = 99999999999999999;
//int n17, imax17 = 0, imin17 = 0;
//double srp17 = 0, srm17 = 0, kp17 = 0, km17 = 0, sp17 = 0, sm17 = 0;
//Console.WriteLine("Введите размер массива");
//n17_1 = Console.ReadLine();
//n17 = int.Parse(n17_1);
//Console.WriteLine(" ");
//double[] a17 = new double[n17];
//for (int i = 0; i < n17; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x17_1 = Console.ReadLine();
//	x17 = double.Parse(x17_1);
//	a17[i] = x17;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n17; i++)
//{
//	Console.Write($"{a17[i]} ");
//	if (a17[i] > max17)
//	{
//		max17 = a17[i];
//		imax17 = i; //индес max
//	}
//	if (a17[i] < min17)
//	{
//		min17 = a17[i];
//		imin17 = i; //индекс min
//	}
//	if (a17[i] > 0)
//	{
//		kp17++;
//		sp17 += a17[i];
//	}
//	if (a17[i] < 0)
//	{
//		km17++;
//		sm17 += a17[i];
//	}
//}
//Console.WriteLine(" ");
//srp17 = sp17 / kp17;
//srm17 = sm17 / km17;
//Console.WriteLine(" ");
//if (imax17 < imin17)
//{
//	Console.WriteLine($"Среднее арифметическое положительных элементов: {srp17}");
//}
//else
//{
//	Console.WriteLine($"Среднее арифметическое отрицательных элементов: {srm17}");
//}
//Console.WriteLine(" ");


//#endregion

//#region 2_18
//string x18_1, n18_1;
//double x18, maxch18 = -999999999999999999, maxnch18 = -99999999999999999;
//int n18, ich18 = 0, inch18 = 0;
//Console.WriteLine("Введите размер массива");
//n18_1 = Console.ReadLine();
//n18 = int.Parse(n18_1);
//Console.WriteLine(" ");
//double[] a18 = new double[n18];
//for (int i = 0; i < n18; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x18_1 = Console.ReadLine();
//	x18 = double.Parse(x18_1);
//	a18[i] = x18;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n18; i++)
//{
//	Console.Write($"{a18[i]} ");
//	if (i % 2 == 0)
//	{
//		if (a18[i] > maxch18)
//		{
//			maxch18 = a18[i];
//			ich18 = i; //индес max
//		}
//	}
//	else
//	{
//		if (a18[i] > maxnch18)
//		{
//			maxnch18 = a18[i];
//			inch18 = i; //индекс min
//		}
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//if (maxch18 > maxnch18)
//{
//	for (int i = 0; i < n18 / 2; i++)
//	{
//		a18[i] = 0;
//	}
//}
//else
//{
//	for (int i = n18 / 2; i < n18; i++)
//	{
//		a18[i] = 0;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n18; i++)
//{
//	Console.Write($"{a18[i]} ");
//}
//Console.WriteLine(" ");

//#endregion

//#region 2_19
//string x19_1, n19_1;
//double s19 = 0, x19, max19 = -999999999999999999;
//int n19, ii19 = 0;
//Console.WriteLine("Введите размер массива");
//n19_1 = Console.ReadLine();
//n19 = int.Parse(n19_1);
//Console.WriteLine(" ");
//double[] a19 = new double[n19];
//for (int i = 0; i < n19; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x19_1 = Console.ReadLine();
//	x19 = double.Parse(x19_1);
//	a19[i] = x19;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n19; i++)
//{
//	Console.Write($"{a19[i]} ");
//	if (a19[i] > max19)
//	{
//		max19 = a19[i];
//		ii19 = i;
//	}
//	s19 += a19[i];
//}
//if (max19 > s19 - a19[ii19]) a19[ii19] = 0;
//else a19[ii19] = a19[ii19] * 2;
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Изменённый массив: ");
//for (int i = 0; i < n19; i++)
//{
//	Console.Write($"{a19[i]} ");
//}
//Console.WriteLine(" ");

//#endregion

//#region 2_20
//string x20_1, n20_1;
//double x20, min20 = 9999999999999, sch20 = 0, snch20 = 0;
//int n20, imin20 = 0, io20 = 0;
//Console.WriteLine("Введите размер массива");
//n20_1 = Console.ReadLine();
//n20 = int.Parse(n20_1);
//Console.WriteLine(" ");
//double[] a20 = new double[n20];
//for (int i = 0; i < n20; i++)
//{
//	Console.WriteLine("Введите число массива");
//	x20_1 = Console.ReadLine();
//	x20 = double.Parse(x20_1);
//	a20[i] = x20;
//	Console.WriteLine(" ");
//}
//Console.WriteLine("Ваш массив: ");
//for (int i = 0; i < n20; i++)
//{
//	Console.Write($"{a20[i]} ");
//	if (a20[i] < min20)
//	{
//		min20 = a20[i];
//		imin20 = i;
//	}
//	if (i % 2 == 0) sch20 += a20[i];
//	else snch20 += a20[i];
//}
//for (int i = 0; i < n20; i++)
//{
//	if (a20[i] < 0)
//	{
//		io20 = i;
//		break;
//	}
//}
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//if (io20 < imin20) Console.WriteLine($"Сумма элементов с чётными индексами: {sch20}");
//else Console.WriteLine($"Сумма элементов с нечётными индексами: {snch20}");




//#endregion
