using System;
using System.Linq;
class Program
{ 
    private struct Dot 
    { 
        private int X { get; } 
        private int Y { get; } 
        private int Z { get; } 
        public Dot(int[] coordinates) 
        { 
            if (coordinates.Length != 3) 
            { 
                throw new ArgumentException("Array должен состоять ровно из трёх элементов.");
            } 
            X = coordinates[0]; 
            Y = coordinates[1]; 
            Z = coordinates[2];
        } 
        public double DistanceTo(Dot other) => Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2) + Math.Pow(Z - other.Z, 2)); 
        public override string ToString() => $"({X}, {Y}, {Z})";
    }
    private struct Vector 
    { 
        private Dot Start { get; }
        private Dot End { get; } 
        public Vector(int[,] matrix) 
        { 
            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 3)
            { 
                throw new ArgumentException("Матрица должна быть 2x3."); 
            } 
            Start = new Dot(new int[] { matrix[0, 0], matrix[0, 1], matrix[0, 2] }); 
            End = new Dot(new int[] { matrix[1, 0], matrix[1, 1], matrix[1, 2] }); 
        } 
        public double Length => Start.DistanceTo(End); 
        public override string ToString() => $"Вектор: Начальная точка = {Start}, Конечная точка = {End}, Длина вектора = {Length:F2}"; 
    } 
    static void Main(string[] args) 
    { 
        int[][,] vectorData = new int[][,] 
        { 
            new int[,] { { 0, 0, 0 }, { 3, 4, 0 } }, 
            new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }, 
            new int[,] { { -1, -2, -3 }, { -4, -5, -6 } }, 
            new int[,] { { 7, 8, 9 }, { 10, 11, 12 } }, 
            new int[,] { { 5, 5, 5 }, { 10, 10, 10 } } 
        }; 
        Vector[] vectors = vectorData.Select(matrix => new Vector(matrix)).ToArray(); 
        Array.Sort(vectors, (v1, v2) => v2.Length.CompareTo(v1.Length)); 
        foreach (var vector in vectors) { Console.WriteLine(vector); } } }