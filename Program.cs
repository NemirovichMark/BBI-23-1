// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Channels;
#region 1.1
Console.WriteLine("1.1");
double[] a = new double[6] { 14, 2, 3, 4, 5, 6 };
double s = 0;


for(int i = 0; i < 6; i++)
{
    s = s + a[i];
   
    
}
for (int i = 0; i < a.Length; i++)
{
    a[i] /= s;
     
}
Console.WriteLine("[{0}]", string.Join("; ", a));
#endregion

#region 1.2
Console.WriteLine( "1.2");
s = 0;
double R=0;
double []e= new double[4] {100,-1,2,-2,};
int zz = 0;
for (int i = 0; i <e.Length; i++) {
    if (e[i] > 0)
    {
        R += e[i];
        zz++;
    }
        }
s=R/ zz;
for (int i = 0; i < e.Length; i++)
{
    if (e[i] > 0)
    {
        e[i] = s;
    }
}
Console.WriteLine("[{0}]", string.Join("; ", e));
#endregion

#region 1.3
Console.WriteLine(  "1.3");
int[]t =new int[4]{ 1,2,3,4};
int[] l = new int[4] { 2, 3, 2, 3 };
int[] w=new int[4];
for (int i = 0; i < 4; i++)
{
    w[i]= t[i] + l[i];
   
}
 Console.WriteLine("массив суммы равен");
Console.WriteLine("[{0}]", string.Join("; ", w));
for (int i = 0; i < 4; i++)
{
    w[i] = t[i] - l[i];
    
}
Console.WriteLine("массив разности равен");
Console.WriteLine("[{0}]", string.Join("; ", w));
#endregion

#region 1.4
Console.WriteLine("1.4");
double ff=0;
zz = 0;

double[] b = new double[5] { 1, 2, 3, 4, 5 };
for(int i = 0;i < 5; i++)
{
    ff=ff+b[i];
    zz++;
    
   
}
ff = ff / zz;
for (int i = 0; i < 5; i++) {
    b[i] = b[i] - ff;
   
}
Console.WriteLine("[{0}]", string.Join("; ", b));
#endregion


#region 1.5
Console.WriteLine("1.5");
s = 0;
b = new double[4] { 4, 4, 4, 4 };
e = new double[4] { 3, 3, 3, 3 };
for(int i = 0; i < 4; i++)
{
    s += b[i] * e[i];
}
Console.WriteLine(s);
#endregion


#region 1.6
Console.WriteLine(  "1.6");
double[] rrr = new double[5] { 1, 2, 3, 4, 5 };
double sum = 0;
for (int i = 0; i < 5; i++)
{
    sum += rrr[i] * rrr[i];
}
sum = Math.Sqrt(sum);
Console.WriteLine($"длинна вектора{sum}");
#endregion


#region 1.7
Console.WriteLine( "1.7");
s = 0;
double[] v = new double[4] { 1, 2, 3, 4 };
zz = 0;
for (int i = 0; i < 4; i++)
{
    s = s + v[i];

    zz++;

}
s = s/zz;
for (int i = 0; i < 4; i++)
    if (v[i] > s)
    {
        v[i] = 0;
        
    }

Console.WriteLine("[{0}]", string.Join("; ", v));
#endregion

#region 1.8

Console.WriteLine("1.8");
double[] n = new double[6] { -1, -2, -3, 4, 5, 6 };
 s = 0;
for (int i = 0; i < n.Length; i++)
{
    if (n[i] < 0)
    {
        s = s + 1;
    }
}
Console.WriteLine(s);
#endregion


#region 1.9
Console.WriteLine("1.9");
double[] nn = new double[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
double ss = 0, vv = 0;
for (int i = 0; i < nn.Length; i++)
{
    ss += nn[i];

}
ss = ss / 8;
for (int i = 0; i < nn.Length; i++)
{
    if (nn[i] > ss)
    {
        vv = vv + 1;
    }
}
Console.WriteLine(vv);
#endregion


#region 1.10
Console.WriteLine("1.10");
s = 0;
double P = 2, Q = 8;
double[] ee = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < 10; i++)
{
    if (P < ee[i] & ee[i] < Q)
    {
        s = s + 1;
    }
}
Console.WriteLine(s);
#endregion

#region 1.11
Console.WriteLine( "1.11");
int kk = 0,gg=0;
 nn = new double[10] { -1, -2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < nn.Length; i++)
{
    if (nn[i] > 0)
    {
        
            kk++;
    }
}ee = new double[kk];
for (int i = 0; i < nn.Length; i++)
{
    if (nn[i] > 0)
    {
        ee[gg] = nn[i];
        gg++;
    }
}

Console.WriteLine("Новый массив:");
Console.WriteLine("[{0}]", string.Join("; ", ee));
Console.WriteLine();
#endregion


#region 1.12
Console.WriteLine("1.12:");
 double []mas = new double[8];
double num = 0, znachenye = 0;
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = double.Parse(Console.ReadLine());
    if (mas[i] < 0)
    {
        num = i + 1;
        znachenye = mas[i];
    }
}
Console.WriteLine("Значениe:");
Console.WriteLine(znachenye);
Console.WriteLine("Номер");
Console.WriteLine(num);
Console.WriteLine();
#endregion
#region 1.13
Console.WriteLine( "1.13");
mas= new double[10] {2,2,3,4,5,6,7,8,9,11};
ee = new double[5];
nn=new double[5];
int ss1 = 0;
int ss2 = 0;



for (int i = 0;i < 10; i++)
{

    
    if (i%2==0  )
    {

        ee[ss1] = mas[i];
        ss1++;
    }
    else
    {
        nn[ss2] = mas[i];
        ss2++;
    }
}
Console.WriteLine( "Массив с четными значениями:");
Console.WriteLine("[{0}]",string.Join(";",ee));
Console.WriteLine(  "Массив с нечетными значениями:");
Console.WriteLine(  "[{0}]",string.Join(";",nn));
Console.WriteLine();
#endregion
#region 1.14
Console.WriteLine(  "1.14");
ss = 0;
P = 0;
ee = new double[11] { 1, 2, 3, 4, 5, -6, 7, 8, 9, 10, 11 };
for(int i = 0; i < 11; i++)
{
    
    if (ee[i] < 0)
    {
        break;
    }

    P = P + ee[i] * ee[i];
}
Console.WriteLine(  P);
#endregion



#region 1.15
Console.WriteLine(  "1.15");

double[]x = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
double[] y = new double[10];
for(int i = 0; i < 10; i++)
{
    y[i] = Math.Log(x[i]);
}

Console.WriteLine("x\t|\ty");
Console.WriteLine("------------------");
for (int i = 0; i < x.Length; i++)
{
    Console.WriteLine(x[i] + "\t|\t" + y[i]);
}
#endregion
#region
Console.WriteLine("2.1");
 mas = new double[5] { 1, 2, 3, 4, 5 };
double min = mas[0];
int imin =0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] < min)
    {
        min = mas[i];
        imin = i;



    }


}
mas[imin] = min * 2;
Console.WriteLine("Массив с увелченным минимальным элементом:");

Console.WriteLine("[{0}]", string.Join(";", mas));


#endregion


#region 2.2
Console.WriteLine(  "2.2");

int[] mass = new int[4] { 1, 2, 3, 4 };
int max = mass[0];
int imax = 0;
int S = 0;
for (int i = 0; i < 4; i++)
{
    if (mass[i] > max)
    {
        max = mass[i];
        imax = i;
    }

}
for (int i = 0; i < 4; i++)
{
    if (mass[i] < mass[imax])
    {
        S = S + mass[i];
    }



}
Console.WriteLine(S);
#endregion


#region 2.3
Console.WriteLine(  "2.3");
 mass = new int[4] { 6, 2, 3, 4 };
 min = mass[0];
int iminn = 0;
for (int i = 0; i < 4; i++)
{
    if (mass[i] < min)
    {
        min = mass[i];
        iminn = i;
    }
}
for (int i = 0; i < 4; i++)
{
    if (i < iminn)
    {
        mass[i] = mass[i] * 2;
    }
    Console.WriteLine("{0:d}", mass[i]);
}

#endregion
#region 2.4
Console.WriteLine("2.4");
mas = new double[4] { 1, 2, 7, 5 };
 double maxx = mas[0];
 imax = 0;
 s = 0;
for (int i = 0; i < 4; i++)
{
    s += mas[i];
}
s = s / 4;
for (int i = 0; i < 4; i++)
{
    if (mas[i] > maxx)
    {
        maxx = mas[i];
        imax = i;
    }
}
for (int i = 0; i < 4; i++)
{
    if (i > imax)
    {

        mas[i] = s;
    }
}
Console.WriteLine("Новый массив:");
Console.WriteLine("[{0}]", string.Join(";", mas));
#endregion
#region 2.5
Console.WriteLine("2.5");
Console.WriteLine("исходный массив:");
 a = new double[5] { -4, 1, -2, -3, 5 };
Console.WriteLine("[{0}]", string.Join(";", a));
int k = 0;
double[] bb = new double[5];

 maxx = a[0];
 imax = 0;
 min = a[0];
 imin = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > max)
    {
        maxx = a[i];
        imax = i;
    }

    if (a[i] < min)
    {
        min = a[i];
        imin = i;
    }
}

for (int i = imin + 1; i < imax; i++)
{
    if (a[i] < 0)
    {
        k++;
    }
}
b = new double[k];
k = 0;


for (int i = imin + 1; i < imax; i++)
{
    if (a[i] < 0)
    {
        b[k] = a[i];
        k++;
    }
}
Console.WriteLine("полученный массив:");
Console.WriteLine("[{0}]", string.Join(";", b));
#endregion

#region 2.6
Console.WriteLine("2.6");
Console.WriteLine("Введите массив:");
string str = Console.ReadLine();
Console.WriteLine("Введите число P:");
 min = 1000000000;
 P = double.Parse(Console.ReadLine());
string[] masss = str.Split(' ');
double[] arr = new double[mass.Length];
double[] arr1 = new double[mass.Length + 1];
int temporary = 0;
double minim = 1000000000;
double su = 0;
for (int i = 0; i < mass.Length; i++)
{
    arr[i] = double.Parse(masss[i]);
    su += arr[i];
}
su = su / arr.Length;
Console.WriteLine(su);
for (int i = 0; i < mass.Length; i++)
{
    if (Math.Abs(su - arr[i]) <= minim)
    {
        minim = Math.Abs(su - arr[i]);
        temporary = i;
    }
}
arr1[temporary + 1] = P;
for (int i = 0; i < arr.Length + 1; i++)
{
    if (i < (temporary + 1))
    {
        arr1[i] = arr[i];
    }
    else if (i > (temporary + 1))
    {
        arr1[i] = arr[i - 1];
    }
}
Console.WriteLine("Полученный массив:");
Console.WriteLine("[{0}]", string.Join(';', arr1));
Console.WriteLine();
#endregion


#region 2.7
Console.WriteLine("2.7");
a = new double[5] { 1, 3, 5, 2, 4 };
 maxx = a[0];
 s = 0;
imax = 0;
for (int i = 0; i < 5; i++)
{
    if (a[i] > maxx)
    {
        maxx = a[i];
        imax = i;

    }
}

a[imax + 1] *= 2;

Console.WriteLine("Полученный массив:");
Console.WriteLine("[{0}]", string.Join(";", a));
#endregion



#region 2.8
Console.WriteLine("2.8");
 a = new double[6] { 1, 2, 3, 7, 5, 4 };
 maxx = a[0];
imax = 0;
 k = 0;
double hh = 0;
 

for (int i = 0; i < 6; i++)
{
    if (a[i] > maxx)
    {
        maxx = a[i];
        imax = i;
    }
}
Console.WriteLine(a[imax]);
 min = a[imax];
 imin = 0;

for (int i = imax + 1; i < 6; i++)
{
    if (a[i] < min)
    {
        min = a[i];
        imin = i;
    }


}
Console.WriteLine(a[imin]);
hh = a[imax]; a[imax] = a[imin]; a[imin] = hh;
for (int i = 0; i < 6; i++)
    Console.Write("{0:f1} ", a[i]);
#endregion




#region 2.9
Console.WriteLine( "2.9");
s = 0;
 mas = new double[6] { 1, 2, 3, 4, 5, 6 };

 maxx = mas[0];
 imax = 0;
  double minn = mas[0];
 imin = 0;
for (int i = 0; i < 6; i++)
{

    if (mas[i] > max)
    {
        maxx = mas[i];
        imax = i;
    }
    if (mas[i] < min)
    {
        minn = mas[i];
        imin = i;
    }
}
for (int i = 0; i < 6; i++)
{
    if (imin < i & i < imax)
    {

        s += mas[i] / 4;
    }
}
Console.WriteLine("Среднее арифмитическое значение:");
Console.WriteLine(s);

#endregion

#region 2.10
Console.WriteLine("2.10");

 a = new double[4] { -1, -2, -3, -4 };
int cR = 0, pR = 0;
 min = 100000000;
 imin = 0;
for (int i = 0; i < 4; i++)
{
    if (a[i] >= 0)
    {
        pR = i;
        cR++;
    }

}
for (int i = 0; i <= pR; i++)
{
    if (a[i] < min & a[i] > 0)
    {



        min = a[i];
        imin = i;


    }

}

if (cR == 0)
{
    Console.WriteLine("отсутствуют положительные элементы массива");
}
else
{

    int kkk = imin;
    double nnn = 4;
    for (int i = kkk + 1; i < nnn; i++)
        a[i - 1] = a[i];
    for (int i = 0; i < nnn - 1; i++)
        Console.WriteLine("{0:f1}", a[i]);
    Console.WriteLine();
}
#endregion




#region 2.11
Console.WriteLine("2.11");
int m = 0;
const int N = 6;
int[] aA = new int[N];
string sS;
int ch = 0;
Console.WriteLine("Введите элементы массива");

for (int i = 0; i < N - 1; i++)
{
    sS = Console.ReadLine();
    aA[i] = int.Parse(sS);
}
for (int i = 0; i < N - 1; i++)
{
    if (aA[i] > 0)
    {
        ch++;
    }
}



if (ch == 0)
{
    Console.WriteLine("отсутствуют положительные элементы массива");
}
else
{
    int PP = 52;
    m = 0;
    int mm = 0;
    Console.WriteLine("число Р={0}", PP);
    for (int i = N - 2; i >= 0; i--)
    {
        if (aA[i] > 0)
        {
            m = aA[i];
            mm = i;
            break;
        }

    }
    for (int i = N - 2; i >= mm + 1; i--)
    {
        aA[i + 1] = aA[i];
    }
    aA[mm + 1] = PP;
    Console.WriteLine("Полученный массив");
    for (int i = 0; i < N; i++)
        Console.Write("{0:d} ", aA[i]);
    Console.WriteLine();
}

#endregion





#region 2.12
Console.WriteLine("2.12");
mas = new double[5] { 1, -1, 7, 4, 5 };
 maxx = mas[0];
 imax = 0;
 s = 0;
for (int i = 0; i < 5; i++)
{
    if (mas[i] > maxx)
    {
        maxx = mas[i];
        imax = i;
    }

}
for (int i = 0; i < 5; i++)
{
    if (i > imax)
    {

        s = s + mas[i];
    }

}
for (int i = 0; i < 5; i++)
{
    if (mas[i] < 0)
    {
        mas[i] = s;
    }
}
Console.WriteLine("[{0}]", string.Join(";", mas));
#endregion
#region 2.13
Console.WriteLine("2.13");
int kc = 0;

 int [] aa = new int[5] { 4, 2, 11, 10, 9 };
Console.WriteLine("исходный массив:");
Console.WriteLine("[{0}]", string.Join(";", aa));

 maxx = a[0];
imax = 0;
for (int i = 0; i < 5; i++)
{
    if (i % 2 == 0)
    {

        kc = i;





        if (aa[kc] > maxx)
        {
            maxx = aa[kc];
            imax = kc;
        }
    }
}
aa[imax] = imax;
Console.WriteLine("полученный массив:");
Console.WriteLine("[{0}]", string.Join(";", aa));

#endregion






#region 2.14
Console.WriteLine("2.14");
 a = new double[5] { 1.0, 3.0, 4.0, 5.0, 7.0 };

double p;
Console.WriteLine("Исходный массив:");
int c = 0;
 k = 0;
int sss = 0;
 imax = 0;
 maxx = a[0];
for (int i = 0; i < 5; i++)

    Console.Write("{0:f1} ", a[i]);
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    if (a[i] < 0)
    {
        c++;
    }
}
Console.WriteLine(c);
if (c == 0)
{
    Console.WriteLine("отсутствуют отрицательные элементы массива");
}
else
{
    for (int i = 0; i < 5; i++)
    {
        if (a[i] > maxx)
        {
            maxx = a[i];
            imax = i;
        }
    }

    for (int i = 0; i < 5; i++)
        if (a[i] < 0)
        {
            k = i;
            break;
        }
    p = a[k]; a[k] = a[imax]; a[imax] = p;
    Console.WriteLine("Полученный массив:");
    for (int i = 0; i < 5; i++)
        Console.Write("{0:f1} ", a[i]);
    Console.WriteLine();
}
#endregion




#region 2.15
Console.WriteLine("2-15:");
Console.WriteLine("Введите размер массивa A:");
int nu = (int)Double.Parse(Console.ReadLine());
Console.WriteLine("Введите размер массивa B:");
 m = (int)Double.Parse(Console.ReadLine());
double[] A = new double[nu];
double[] B = new double[m];
double[] C = new double[nu + m];
Console.WriteLine("Введите k:");
k = (int)Double.Parse(Console.ReadLine());

Console.WriteLine("Введите масив A:");
for (int i = 0; i < nu; i++)
{
    A[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("Введите массив B:");
for (int j = 0; j < m; j++)
{
    B[j] = double.Parse(Console.ReadLine());
}
if (k > nu)
{
    Console.WriteLine("k не входит в размер массива А");
}
else
{


    for (int i = 0; i < C.Length; i++)
    {
        if (i <= k)
        {
            C[i] = A[i];
        }
        if (i > k && i <= (k + m))
        {
            C[i] = B[i - k - 1];
        }
        if (i > (k + m))
        {
            C[i] = A[i - k - m + 2];
        }
    }
    Console.WriteLine("Полученный массив:");
    Console.WriteLine("[{0}]", string.Join(';', C));
    Console.WriteLine();
}



#endregion
#region 2.16
Console.WriteLine("2.16");
a = new double[4] { 5, 2, 3, 4 };
 s = 0;
 k = 0;
int tt = 0;
double snn = 0;
for (int i = 0; i < 4; i++)
{

    s = s + a[i];
    snn++;
}

s = s / snn;
for (int i = 0; i < 4; i++)
{
    if (a[i] < s)
    {

        tt++;

    }

}
double[] bm = new double[tt];
for (int i = 0; i < a.Length; i++)
{
    if (a[i] < s)
    {
        bm[k] = i;
        k++;
    }
}
Console.WriteLine("Полученный массив:");
Console.WriteLine("[{0}]", string.Join(';', bm));


#endregion

#region 2.17
Console.WriteLine("2.17");
Console.WriteLine("введите элементы массива через пробел");
 str = Console.ReadLine();
string[] aray = str.Split(' ');
 int []at = new int[aray.Length];
 min = 9000000;
 maxx = 9000000;
 imax = 0;
 imin = 0;
int count = 0;
double sr = 0;
for (int i = 0; i < aray.Length; i++)
{
    at[i] = int.Parse(aray[i]);
    if (maxx < at[i])
    {
        maxx = at[i];
        imax = i;
    }
    if (min > at[i])
    {
        min = at[i];
        imin = i;
    }
}
if (imax < imin)
{
    for (int i = 0; i < aray.Length; i++)
    {
        if (at[i] > 0)
        {
            sr += at[i];
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("отсутсвуют положительные элементы");
    }
    else
    {
        sr /= count;
        Console.WriteLine("Ср.Арифм: " + sr);
    }

}
else
{
    for (int i = 0; i < aray.Length; i++)
    {
        if (at[i] < 0)
        {
            sr += at[i];
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("отсутствуют отрицательные элементы");
    }
    else
    {
        sr /= count;
        Console.WriteLine("Ср.Арифм.: " + sr);
    }

}
Console.WriteLine();
Console.ReadKey();


#endregion


#region 2.18
Console.WriteLine("2.18");
a = new double[5] { 1, 2, 3, 6, 5 };
 arr = new double[5];
int chet = 0, nech = 0;
 maxx = a[0];
 imax = 0;
double max1 = a[0];
double imax1 = 0;
for (int i = 0; i < a.Length; i++)
{
    arr[i] = (a[i]);
}

for (int i = 0; i < 5; i++)
{
    if (i % 2 == 0)
    {
        chet = i;
    }
    else
    {
        nech = i;
    }
}
for (int i = 0; i < 5; i++)
{
    if (a[chet] > max)
    {
        maxx = a[chet];
        imax = chet;
    }
}
Console.WriteLine("максимальный среди четных");
Console.WriteLine(maxx);
for (int i = 0; i < 5; i++)
{
    if (a[nech] > max1)
    {
        max1 = a[nech];
        imax1 = nech;
    }
}
Console.WriteLine("максимальный среди нечетных");
Console.WriteLine(max1);
if (max > max1)
{
    for (int i = 0; i < a.Length / 2; i++)
    {
        arr[i] = 0;
    }
}
else
{
    for (int i = a.Length / 2; i < a.Length; i++)
    {
        arr[i] = 0;
    }
}
Console.WriteLine("Полученный массив:");
Console.WriteLine("[{0}]", string.Join(';', arr));
Console.WriteLine();

#endregion
# region 2.19
Console.WriteLine("2.19");
Console.WriteLine("исходный массив:");
a = new double[5] { 1, 2, 3, 4, 5 };
Console.WriteLine("[{0}]", string.Join(";", a));
 maxx = a[0];
 imax = 0;
 s = 0;
for (int i = 0; i < 5; i++)
{
    if (a[i] > maxx)
    {
        maxx = a[i];
        imax = i;
    }
}

for (int i = 0; i < 5; i++)
{
    s += a[i];
}

if (s < a[imax])
{
    a[imax] = 0;
}
if (s > a[imax])
{
    a[imax] *= 2;
}
Console.WriteLine("полученный массив:");
Console.WriteLine("[{0}]", string.Join(";", a));

#endregion





#region 2.20
Console.WriteLine("2.20");
 a = new double[5] { 1, -2, 3, 4, 5 };
Console.WriteLine("исходный массив:");
Console.WriteLine("[{0}]", string.Join(";", a));
min = a[0];
chet = 0;
int nechet = 0;
m = 0;
 imin = 0;
s = 0;
    double sn = 0;
for (int i = 0; i < 5; i++)
{
    if (a[i] < min)
    {
        min = a[i];
        imin = i;
    }
}
for (int i = 0; i < 5; i++)
{
    if (i % 2 == 0)
    {
        chet = i;
        s = s + a[chet];

    }
    else
    {
        nechet = i;
        sn = sn + a[nechet];
    }
}
for (int i = 0; i < 5; i++)
{
    if (a[i] < 0)
    {
        m = i;
        break;
    }
}
Console.WriteLine("сумма элементов равна:");
if (m < imin)
{
    Console.WriteLine(s);
}
else
{
    Console.WriteLine(sn);
}


#endregion
#region 3.2
Console.WriteLine("3.2:");
Console.WriteLine("Введите массив,элементы вводите через пробел:");
string strok = Console.ReadLine();
string[] massiv = strok.Split(' ');
double[] array = new double[massiv.Length];
double maximum = -4000000000;
double mmm = 1;
for (int i = 0; i < massiv.Length; i++)
{
    array[i] = double.Parse(massiv[i]);
    if (maximum < array[i])
    {
        maximum = array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == maximum)
    {
        array[i] += mmm;
        mmm++;
    }
}
Console.WriteLine("Полученный массив:");
Console.WriteLine("[{0}]", string.Join(';', array));
Console.WriteLine();
#endregion

#region 3.3
Console.WriteLine("3.3:");
Console.WriteLine("Введите массив,элементы вводите через пробел:");
strok = Console.ReadLine();
massiv = strok.Split(' ');
array = new double[massiv.Length];
maximum = -9000000000;
mmm = 0;
double kv = 0;
for (int i = 0; i < massiv.Length; i++)
{
    array[i] = double.Parse(massiv[i]);
    if (maximum < array[i])
    {
        maximum = array[i];
        mmm = i;
    }
}
if (mmm % 2 != 0)
{
    mmm -= 1;
}
for (int i = 0; i < mmm; i += 2)
{
    kv = array[i];
    array[i] = array[i + 1];
    array[i + 1] = kv;

}
Console.WriteLine("Полученный массив:");
Console.WriteLine("[{0}]", string.Join(';', array));
Console.WriteLine();
       

   

 #endregion