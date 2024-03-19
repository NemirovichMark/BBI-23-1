using System;

namespace ConsoleApp1
{
    public struct Point
    {
        private int _x;
        private int _y;
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        public static int Rasstoyanie(int X,  int Y)
        {
            
            return(Math.Abs(X - Y));
        }

        public void Print()
        {
            Console.WriteLine($"x: {_x}\t y:{_y}\t расстояние: {Rasstoyanie(X,Y)}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] array = new Point[3];
            array[0] = new Point(1, 4);//3
            array[1] = new Point(3, 3);//0
            array[2] = new Point(5, 1);//3

            for(int i=0;i<array.Length;i++)
            {
                array[i].Print();
            }
        }
    }
}
