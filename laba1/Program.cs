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
                hypotenuse = Math.Sqrt(x2 * x2 + y2 * y2);
                if(hypotenuse<=mindist){
                    mindistnum = i; 
                    mindist = hypotenuse;
                 }
            }
             Console.WriteLine("Номер ближайщей точки: " mindistnum);
             Console.WriteLine("Расстояние ближайщей точки до начала координат: " mindist);
            #endregion
        }
    }
}
