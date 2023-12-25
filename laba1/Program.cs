using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            # region "2LABA1"
            double x;
            double y;
            double r =2;
                for(int i = 1; i <= 4; i++){
                Console.WriteLine("Ведите x");
                    x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ведите y");
                    y = Convert.ToDouble(Console.ReadLine());
                if (Math.Abs(x * x + y * y - r * r) <= 0.001)
                {
                    Console.WriteLine("Принадлежит");
                }
                else Console.WriteLine("Не принадлежит");
                 }
             #endregion
            # region "2LABA4"
                int а;
                int b;
                int c;
                int z;
            Console.WriteLine("Ведите a");
                 а = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите b");
                    b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите c");
                    c = Convert.ToInt32(Console.ReadLine());
            if (а > b)
            {
                if(b>c) z = b;
                else z = c;
            }
            else{
                if(а>c) z =  а;
                else z = c;
            } 
            Console.WriteLine(z);
              #endregion
            # region "2LABA8"
            double y1,x1;
             Console.WriteLine("Ведите x");
                    x1 = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(x1)>=1) y1 =0;
            else y1=x1*x1 - 1;
            Console.WriteLine(y1);
             #endregion
            # region "2lvl1"
            double boys = 0;
            double boystotal = 0;
            double girls = 0;
            double girlstotal = 0;
            int n;
            Console.WriteLine("Введите число учеников: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int pol;
                Console.WriteLine("Введите пол 0-девочка,1-мальчик");
                pol = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите рост");
                if (pol == 0)
                {
                    girls += 1;
                    girlstotal += Convert.ToDouble(Console.ReadLine());
                }
                if (pol == 1)
                {
                    boys += 1;
                    boystotal += Convert.ToDouble(Console.ReadLine());
                }
                if (pol != 0 && pol != 1)
                {
                    Console.WriteLine("Проверьте правильность ввода данных");
                    i--;
                }
            }
            Console.WriteLine("Средний рост мальчиков: " + boystotal/boys);
            Console.WriteLine("Средний рост девочек: " + girlstotal/girls);
             #endregion
            # region "2lvl4"
            double r1 = 0; //короче по теореме пифагора ищем гипотенузу и сраниваем с радиусами если не строго меньше внешнего и не строго больше внутреннего тогда принадлежит в противном случае нет
            double r2 = 0;
            int n1 = 0;
            int innerpoints = 0;
            Console.WriteLine("Ведите r1");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите r2");
            r2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите n");
            n1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                double hypotenuse = 0;

                Console.WriteLine("Ведите x точки");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ведите y точки");
                double y2 = Convert.ToDouble(Console.ReadLine());
                hypotenuse = Math.Sqrt(x2 * x2 + y2 * y2);
                if (hypotenuse >= r1 && hypotenuse <= r2){
                    Console.WriteLine("Точка лежит в кольце");
                    innerpoints+=1;
                }
                else Console.WriteLine("Точка не лежит в кольце");
            }
            Console.WriteLine(innerpoints);
            #endregion
            # region "2lvl8"
            int n2 = 0; //по сути принцип решения такой же как в 4 но тут отслеживаем не принадлежность к кольцу а мин расстояние и номер точки 
            double mindist = double.MaxValue;
            int mindistnum = 0;
            Console.WriteLine("Ведите n");
            n2 = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= n1; i++)
            {
                double hypotenuse = 0;

                Console.WriteLine("Ведите x точки");
                double x3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ведите y точки");
                double y3 = Convert.ToDouble(Console.ReadLine());
                hypotenuse = Math.Sqrt(x3 * x3 + y3 * y3);
                if(hypotenuse<=mindist){
                    mindistnum = i; 
                    mindist = hypotenuse;
                 }
            }
             Console.WriteLine("Номер ближайщей точки: " + mindistnum);
             Console.WriteLine("Расстояние ближайщей точки до начала координат: " + mindist);
            #endregion
            # region "3laba1"
            double[] arr = new double[6]{1,4,8,9,5,6};
            double tot =0;
            double avg = 0;
            for(int i = 0; i < 6; i++)
            {
                tot += arr[i];
            }
            avg = tot/6;
            for(int i = 0; i < 6; i++)
            {
                arr[i]=arr[i]/avg;
            }
            #endregion
            # region "3laba4"
            double[] array = new double[5] {2,4,7,3,12};
            double average = 0;
            double total = 0;
            for(int i = 0; i < 5; i++)
            {
                total += array[i];
            }
            average = total/5;
            for(int i = 0; i < 5; i++)
            {
                array[i]=array[i] - average;
            }
            #endregion
            #region "3laba7"
            int[] mass = new int[7] {3,5,1,6,8,6,2};
            double avrg = 0;
            int ttl =0;
            for(int i = 0; i < 7; i++)
            {
                ttl += mass[i]; 
            }
            avrg = ttl/7;
             for(int i = 0; i < 7; i++)
            {
                if(mass[i]>avrg) mass[i] = 0;
            }
            #endregion
            # region "3laba10"
            int p = 0;
            int q = 0;
            int suitablenumbers = 0;
            Console.WriteLine("Введите p: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите q: ");
            q = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[10] { 2, 6, 10, 6, 5, 2, 1, 9, 12, 6};
            for (int i = 0; i < 10; i++)
            {
                if (ar[i] < q && ar[i] > p) suitablenumbers += 1;
            }
            Console.WriteLine(suitablenumbers);
            #endregion
            #region "3laba13"
            int[] initialarray = new int[10] { 2, 4, 5, 3, 8, 2, 1, 6, 8, 10 };
            int[] odd = new int[5];           
            int[] even = new int[5];
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) odd[i/2] = initialarray[i];
                else even[i/2] = initialarray[i];
            }
            #endregion
            # region "3.2lvl1"
            int indxmin = 0;
            int min = int.MaxValue;
            int[] arrr = new int[5] { 7, 4, 3, 4, 8 };
            for (int i = 0; i < 5; i++)
            {
                if (arrr[i] < min) { 
                    indxmin = i;
                    min = arrr[i];
                }
            }
            arrr[indxmin] = arrr[indxmin] * 2;
            #endregion
            # region "3.2lvl4"
            double[] arrray = new double[7] { 3, 5, 1, -6, 8, 6, 2 };
            double sred = 0;
            double tottal = 0;
            int maxindex = 0;
            double maxvaluev = double.MinValue;
            for (int i = 0; i < 7; i++)
            {
                tottal += arrray[i];
                if (arrray[i] > maxvaluev)
                {
                    maxindex = i;
                    maxvaluev = arrray[i];
                }
            }
            sred = tottal / 7;
            for (int i = 0; i < 7; i++)
            {
                if (i > maxindex) arrray[i] = sred;
            }     
            #endregion
            # region "3.2lvl7"
            int[] massiv = new int[] { 2, 8, 3, 5, 4 };
            int indexmax = 0;
            bool prevmax = false;
            int maxznach = int.MinValue;
            for (int i = 0; i < 5; i++)
            {
                if (massiv[i] > maxznach)
                {
                    indexmax = i;
                    maxznach = massiv[i];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (prevmax)
                {
                    prevmax = false;
                    massiv[i] = massiv[i] * 2;
                }
                if (i == indexmax) prevmax = true;

            }
            #endregion
            # region "3.2lvl10"
            int[] oldarray = new int[]{ -1,4,-2,6,8};
            int[] newarray = new int[oldarray.Length - 1];
            int mnidx = 0;
            int minposvalue = int.MaxValue;
            for (int i = 0; i < oldarray.Length; i++)
            {
                if (oldarray[i] > 0)
                {
                    if (oldarray[i] < minposvalue)
                    {
                        minposvalue = oldarray[i];
                        mnidx = i;
                    }
                }

            }
            for (int i = 0; i < mnidx; i++) newarray[i] = oldarray[i];
            for (int i = mnidx + 1; i < oldarray.Length; i++) newarray[i - 1] = oldarray[i];
            #endregion
            # region "3.2lvl13"
            int[] intarray = new int[] { 2, 10, 4, 5, 7, -1, 8 };
            int indxmax = 0;
            int valuemax = int.MinValue;
            for (int i = 0; i < intarray.Length; i += 2)
            {
                if (intarray[i] > valuemax)
                {
                    valuemax = intarray[i];
                    indxmax = i;
                }
            }
            intarray[indxmax] = indxmax;
            #endregion
            # region "3.2lvl16"
            double[] doublearr = new double[] { 2, -3, 8, 10, 14, -4, 6 };
            int schetchik = 0;
            double sredn = 0;
            double obsh = 0;

            for (int i = 0; i < doublearr.Length; i++)
            {
                obsh += doublearr[i];
            }
            sredn = obsh / doublearr.Length;
            for (int i = 0; i < doublearr.Length; i++)
            {
                if (doublearr[i] < sredn) schetchik++;
            }               
            double[] resarray = new double[schetchik];
            schetchik = 0;
            for (int i = 0; i < doublearr.Length; i++)
            {
                if (doublearr[i] < sredn)
                {
                    resarray[schetchik] = doublearr[i];
                    schetchik++;
                }
            }
          #endregion
            # region "3.2lvl19"
            int[] masssivint = new int[] { 3, 6, 10, 90, 5, -2 };
            int mxvlue = int.MinValue;
            int indexmaximum = 0;
            int cym = 0;
            for (int i = 0; i < masssivint.Length; i++)
            {
                cym += masssivint[i];
                if (masssivint[i] > mxvlue)
                {
                    indexmaximum = i;
                    mxvlue = masssivint[i];
                }
            }
            if (mxvlue > cym) masssivint[indexmaximum] = 0;
            else masssivint[indexmaximum] = masssivint[indexmaximum] * 2;
            #endregion
            # region "3.3lvl2"
           int[] maxsarray = new int[]{ 2, 12, 4, 12, 4, 6, 12 }; // принцип решения приблизительно такой за один цикл находим любой максимальный элемент а за второй сравнивая с ним прибавляем спец счетчиком к максимальным их порядковый номер
            int maxcnt = 1;
            int anymax = int.MinValue;
            for (int i = 0; i < maxsarray.Length; i++)
            {
                if (maxsarray[i] > anymax)
                {
                    anymax = maxsarray[i];
                }
            }
            for (int i = 0; i < maxsarray.Length; i++)
            {
                if (maxsarray[i] == anymax)
                {
                    maxsarray[i]+= maxcnt;
                    maxcnt++;
                }
            }
            #endregion
            # region "3.3lvl5"
            int[] vs = new int[] {8,4,2,-3,6,4}; //пузырьком сортируем четные элементы ( цикл в цикле)
            for(int i = 0; i < vs.Length; i += 2)
            {
                for(int j = i; j < vs.Length-2; j += 2)
                {
                    if (vs[j] > vs[j + 2])
                    {
                        int temp = vs[j];
                        vs[j]=vs[j+2];
                        vs[j+2]=temp;
                    }
                }
            }
            #endregion
        }
    }
}
