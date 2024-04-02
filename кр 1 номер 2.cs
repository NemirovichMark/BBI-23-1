using System;
//2 
public abstract class Vehicle
{
    protected string _marka;
    protected string _model;
    protected static int _vim = 0;
    protected int _years;
    protected int _probeg;
    public int Years { get { return _years; } }

    public Vehicle(string marka, string model, int years, int probeg)
    {
        _marka = marka;
        _model = model;
        _years = years;
        _probeg = probeg;
        _vim += 1;
    }
    public virtual void Print()
    {

        Console.WriteLine($" {_marka}, {_model}, {_years}, {_probeg}");
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
}
    class Car : Vehicle
    {
        private string _klass;
        public Car(string marka, string model, int years, int probeg, string klass) : base(marka, model, years, probeg)
        {
            _klass = klass;
        }
        public override void Print()
        {
            Console.WriteLine($"{_marka}, {_model}, {_years}, {_probeg}, {_klass}, {harakter()}");
        }
    }
    class Truck : Vehicle
    {
        private int _kkoles;
        public Truck(string marka, string model, int years, int probeg, int kkoles) : base(marka, model, years, probeg)
        {
            _kkoles = kkoles;
        }
        public override void Print()
        {
            Console.WriteLine($"{_marka}, {_model}, {_years}, {_probeg}, {_kkoles}");
        }
    }

    class Motorcycle : Vehicle
    {
        public Motorcycle(string marka, string model, int years, int probeg) : base(marka, model, years, probeg)
        {

        }
    }

class Program
{
    static void Main()
    {
        Car[] cars = new Car[5]
            {
                    new Car("Toyota", "Camry", 2018, 30000, "A"),
                    new Car("Honda", "Civic", 2019, 1500, "B"),
                    new Car("Ford", "Focus", 2016, 800, "S"),
                    new Car("Chevrolet", "Malibu", 2020, 100, "C"),
                    new Car("Nissan", "Altima", 2017,  60000, "A") ,
            };

        Truck[] trucks = new Truck[5]
            {
                    new Truck("Toyota", "Camry", 2021, 30000, 12),
                    new Truck("Honda", "Civic", 2009, 1500, 6),
                    new Truck("Ford", "Focus", 2006, 800, 4),
                    new Truck("Chevrolet", "Malibu", 2022, 100, 10),
                    new Truck("Nissan", "Altima", 2020,  60000, 8) ,
            };
        Motorcycle [] motocycles = new Motorcycle[5]
            {
                    new Motorcycle("Toyota", "Camry", 2010, 30000),
                    new Motorcycle("Honda", "Civic", 2015, 1500),
                    new Motorcycle("Ford", "Focus", 2020, 800),
                    new Motorcycle("Chevrolet", "Malibu", 2023, 100),
                    new Motorcycle("Nissan", "Altima", 2007, 60000) ,
            };

        foreach (var car in cars)
        {
            car.Print();
        }
        Console.WriteLine();
        foreach (var truck in trucks)
        {
            truck.Print();
        }
        Console.WriteLine();
        foreach (var motocycle in motocycles)
        {
            motocycle.Print();
        }
        Console.WriteLine();    

        Sort(cars);
        Console.WriteLine("Sorted: ");
        foreach (var car in cars)
        {
            car.Print();
        }
        Console.WriteLine();

        Sort(trucks);
        Console.WriteLine("Sorted: ");
        foreach (var truck in trucks)
        {
            truck.Print();
        }
        Console.WriteLine();

        Sort(motocycles);
        Console.WriteLine("Sorted: ");
        foreach (var motocycle in motocycles)
        {
            motocycle.Print();
        }

        Console.ReadKey();
    }
    static void Sort(Vehicle[] cars)
    {
        for (int i = 0; i < cars.Length - 1; i++)
        {
            for (int j = i + 1; j < cars.Length; j++)
            {
                if (cars[i].Years > cars[j].Years)
                {
                    Vehicle t = cars[i];
                    cars[i] = cars[j];
                    cars[j] = t;
                }
            }
        }
    }
}