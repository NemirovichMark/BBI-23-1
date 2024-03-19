/*Вариант 9*/
using System;
namespace project;
class Program
{
    public struct Car
    {
        private string mark;
        private string model;
        private double vim;
        private double year;
        private double probeg;
        private string har;

        public string Mark => mark;
        public string Model => model;
        public double Vim => vim;
        public double Year => year;
        public double Probeg => probeg;
        public string Har => har;

        public Car(string mark, string model, double vim, double year, double probeg, string har)
        {
            this.mark = mark;
            this.model = model;
            this.vim = vim;
            this.year = year;
            this.probeg = probeg;
            this.har = har;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Марка: {Mark} Модель: {Model} VIM номер: {Vim} Год выпуска: {Year} Пробег: {Probeg} Характеристика: {Har}");
        }
    }
    public static void ShellSort(Car[] arr)
    {
        int step = arr.Length / 2;
        while (step >= 1)
        {
            for (int i = step; i < arr.Length; i++)
            {
                Car temp = arr[i];
                int j = i;
                while ((j >= step) && (arr[j - step].Probeg > temp.Probeg))
                {
                    arr[j] = arr[j - step];
                    j -= step;
                }
                arr[j] = temp;
            }
            step /= 2;
        }
    }
    static void Main()
    {
        Car[] Vehicle = new Car[5];
        Vehicle[0] = new Car("BMW", "M3", 123, 2023, 600, "рабочая");
        Vehicle[1] = new Car("BMW", "M5", 124, 2022, 200, "праздичная");
        Vehicle[2] = new Car("BMW", "M8", 321, 2024, 99, "простаивающая");
        Vehicle[3] = new Car("Mercedes", "E63", 322, 2020, 900, "рабочая");
        Vehicle[4] = new Car("BMW", "M3", 153, 2023, 250, "праздичная");
        ShellSort(Vehicle);
        for (int i = 0; i < Vehicle.Length; i++)
        {
            Vehicle[i].PrintInfo();
        }
    }
}
