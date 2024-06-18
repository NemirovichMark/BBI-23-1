using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Variant_2
{
    public class Task1
    {
        public struct Point
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"x = {X}, y = {Y}";
            }

            public double Length(Point other)
            {
                return Math.Round(Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2)), 3);
            }

            public static string GetDistanceInfo(Point p1, Point p2)
            {
                return $"Точка 1: {p1}nТочка 2: {p2}nРасстояние: {p1.Length(p2)}";
            }
        }

        private Point[] points;

        public Point[] Points
        {
            get { return points; }
        }

        public Task1(Point[] pointsArray)
        {
            points = pointsArray;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Point point in points)
            {
                result += $"{point}n";
            }
            return result.TrimEnd('n');
        }

        public void Sorting()
        {
            GnomeSort();
        }

        private void GnomeSort()
        {
            int index = 0;
            while (index < points.Length)
            {
                if (index == 0 || DistanceFromOrigin(points[index - 1]) <= DistanceFromOrigin(points[index]))
                {
                    index++;
                }
                else
                {
                    (points[index], points[index - 1]) = (points[index - 1], points[index]);
                    index--;
                }
            }
        }

        private double DistanceFromOrigin(Point point)
        {
            return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }
    }
}