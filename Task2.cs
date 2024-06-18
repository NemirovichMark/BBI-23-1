using System;

namespace Variant_2
{
    public class Task2
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

            public Point(double[] coordinates)
            {
                X = coordinates.Length > 0 ? coordinates[0] : 0;
                Y = coordinates.Length > 1 ? coordinates[1] : 0;
            }

            public override string ToString()
            {
                return $"x = {X}, y = {Y}";
            }

            public double DistanceTo(Point other)
            {
                return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
            }
        }

        public abstract class Fourangle
        {
            public Point[] Points { get; }

            protected Fourangle(Point[] points)
            {
                Points = points.Length == 4 ? points : new Point[4];
            }

            public abstract double Length();
            public abstract double Area();

            public override string ToString()
            {
                return $"{GetType().Name} with P = {Length()}, S = {Area()}";
            }
        }

        public class Square : Fourangle
        {
            public Square(Point[] points) : base(points) { }

            public override double Length()
            {
                if (Points.Length != 4) return 0;
                return Points[0].DistanceTo(Points[1]) * 4;
            }

            public override double Area()
            {
                if (Points.Length != 4) return 0;
                double side = Points[0].DistanceTo(Points[1]);
                return side * side;
            }
        }

        public class Rectangle : Fourangle
        {
            public Rectangle(Point[] points) : base(points) { }

            public override double Length()
            {
                if (Points.Length != 4) return 0;
                double length = Points[0].DistanceTo(Points[1]);
                double width = Points[1].DistanceTo(Points[2]);
                return 2 * (length + width);
            }

            public override double Area()
            {
                if (Points.Length != 4) return 0;
                double length = Points[0].DistanceTo(Points[1]);
                double width = Points[1].DistanceTo(Points[2]);
                return length * width;
            }
        }

        private Fourangle[] fourangles;

        public Fourangle[] Fourangles => fourangles;

        public Task2(Fourangle[] fouranglesArray)
        {
            fourangles = fouranglesArray;
            Sorting();
        }

        public void Sorting()
        {
            
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < fourangles.Length - 1; i++)
                {
                    if (fourangles[i].Area() < fourangles[i + 1].Area())
                    {
                        Fourangle temp = fourangles[i];
                        fourangles[i] = fourangles[i + 1];
                        fourangles[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public override string ToString()
        {
            string result = "";
            foreach (var figure in fourangles)
            {
                result += figure.ToString() + Environment.NewLine;
            }
            return result.TrimEnd();
        }
    }
}




