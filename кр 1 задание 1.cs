using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

//1
public struct Car
{
    private string _marka;
    private string _model;
    private static int _vim = 0;
    private int _years;
    private int _probeg;
    public int Probeg { get { return _probeg; } }

    public Car(string marka, string model, int years, int probeg)
    {
        _marka = marka;
        _model = model;
        _years = years;
        _probeg = probeg;
        _vim += 1;
    }
    public string harakter()
    {
        if (_probeg / (2024 - _years) > 500)
        {
            return "Рабочая";
        }
        else if (_probeg / (2024 - _years) >= 100 && _probeg / (2024 - _years) <= 500)
        {
            return "Праздничная";
        }
        else
        {
            return "Простаивающая";
        }
    }
    public void Print()
    {
        Console.WriteLine($"{_marka}, {_model}, {_vim}, {_years}, {_probeg}, {harakter()}");
    }
}

class Program
{
    static void Main()
    {
        Car[] cars = new Car[5]
        {
                new Car("Toyota", "Camry", 2018, 30000),
                new Car("Honda", "Civic", 2019, 1500 ),
                new Car("Ford", "Focus", 2016, 800),
                new Car("Chevrolet", "Malibu", 2020, 100),
                new Car("Nissan", "Altima", 2017,  60000) ,
        };

        foreach (var car in cars)
        {
            car.Print();
        }
        Sort(cars);
        Console.WriteLine("Sorted: ");

        foreach (var car in cars)
        {
            car.Print();
        }
        Console.ReadKey();
    }
    static void Sort(Car[] cars)
    {
        for (int i = 0; i < cars.Length - 1; i++)
        {
            for (int j = i + 1; j < cars.Length; j++)
            {
                if (cars[i].Probeg > cars[j].Probeg)
                {
                    Car t = cars[i];
                    cars[i] = cars[j];
                    cars[j] = t;
                }
            }
        }
    }
}