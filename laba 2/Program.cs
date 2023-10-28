using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.3
            //Console.WriteLine("Enter b: ");
            //double b = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a: ");
            //double a = Double.Parse(Console.ReadLine());
            //double c = 0;
            //if(a > 0)
            //{
            //    c = Math.Max(a, b);
            //}
            //else
            //{
            //    c = Math.Min(a, b);
            //}
            //Console.WriteLine(c);
            #endregion

            #region 1.6(1)
            //Console.WriteLine("1.6(1): ");

            //double r = 3.2, s = 3.5;

            //double t = Math.Sqrt(r/Math.PI) * 2; // t - диаметр круга  
            //double z = Math.Sqrt(s); // z - сторона квадрата 

            //if (t > z )
            //{
            //    Console.WriteLine($"Круг с площадью {0} не помещается в квадрате c площадью {1} ", r, s);
            //}
            //else
            //{
            //    Console.WriteLine($"Круг с площадью {0} помещается в квадрате c площадью {1} ", r, s);
            //}
            #endregion

            #region 1.6(2)
            //Console.WriteLine("1.6(2): ");

            //double r = 3.2, s = 4;

            //double t = Math.Sqrt(r / Math.PI) * 2; // t - диаметр круга  
            //double z = Math.Sqrt(s); // z - сторона квадрата 

            //if (t > z)
            //{
            //    Console.WriteLine("Круг с площадью {0} не помещается в квадрате c площадью {1} ", r, s);
            //}
            //else
            //{
            //    Console.WriteLine("Круг с площадью {0} помещается в квадрате c площадью {1} ", r, s);

            //}
            #endregion

            #region 1.6(3)
            //Console.WriteLine("1.6(3): ");

            //double r = 6, s = 9;

            //double t = Math.Sqrt(r / Math.PI) * 2; // t - диаметр круга  
            //double z = Math.Sqrt(s); // z - сторона квадрата 

            //if (t > z)
            //{
            //    Console.WriteLine("Круг с площадью {0} не помещается в квадрате c площадью {1} ", r, s);
            //}
            //else
            //{
            //    Console.WriteLine("Круг с площадью {0} помещается в квадрате c площадью {1} ", r, s);
            //}
            #endregion

            #region 1.9
            //Console.WriteLine("1.9: ");

            //Console.WriteLine("Enter x: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y=0;
            //if (x<= -1)
            //{
            //    y = 0;
            //}
            //if (x > 0)
            //{
            //    y = 1;
            //}
            //if( x<=0 && x > -1)
            //{
            //    y = x + 1;
            //}

            //Console.WriteLine("y equals: " + y);
            #endregion

            #region 2.3
            //Console.WriteLine("2.3:");

            //Console.WriteLine("Enter the amount of children in the class:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int weight;
            //double milkInL = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter child's weight:");
            //    weight = Convert.ToInt32(Console.ReadLine());
            //    if(weight < 30)
            //    {
            //        milkInL += 0.2;
            //    }
            //}

            //Console.WriteLine("The amount of milk required for the class per day: " + milkInL + " litres");
            #endregion

            #region 2.6

            //Console.WriteLine("2.6:");

            //Console.WriteLine("Enter the amount of points on the graph: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int x, y;
            //int counterOfP = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter the x coordinate: ");
            //    Console.WriteLine("Enter the y coordinate: ");
            //    x = Convert.ToInt32(Console.ReadLine()); y = Convert.ToInt32(Console.ReadLine());

            //    if (y <= Math.Sin(x) && y >= 0)
            //    {
            //        if (x >= 0 && x < Math.PI)
            //        {
            //            counterOfP++;
            //        }
            //    }
            //}

            //Console.WriteLine("The amount of points in the area: " + counterOfP);
            #endregion

            #region 2.9
            //Console.WriteLine("2.3:");

            //Console.WriteLine("Enter the amount of sportsmen");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int maxRes, resInSec;
            //maxRes = 1000000000;

            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter the sportsman's result in seconds");
            //    resInSec = Convert.ToInt32(Console.ReadLine());
            //    if (resInSec < maxRes)
            //    {
            //        maxRes = resInSec;
            //    } 
            //}

            //Console.WriteLine("The best result: " + maxRes);
            #endregion
        }
    }
}
