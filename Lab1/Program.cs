////2.1
//double x = 1;
//const double eps = 0.0001;
//double s = 0, a;
//int n = 1;
//do
//{
//    a = Math.Cos(n * x) / (n * n);
//    s = s + a;
//    n = n + 1;
//} while (Math.Abs(a) > eps);
//Console.WriteLine( s);

////2.2
//int n = 1; 
//int p = 1; 
//for (int i = n; ; i = i + 3) 
//{ 
//    if (p * i < 30000) 
//        p = p * i; 
//    else 
//    { 
//        n = i - 3; 
//        break; 
//    } 
//} 
//Console.WriteLine(n); 
////1.4
//double s = 0;
//double x = 1;
//double k = x;
//for (double i = 1; i <= 9; i++)
//{
//    s += Math.Cos(i * x) / k;
//    k *= x;
//}
//Console.WriteLine("1_4:\n{0}", s);
//Console.WriteLine();
