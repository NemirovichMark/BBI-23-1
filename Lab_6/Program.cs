using System.Drawing;

public struct Car
{
    private string _model;
    private int _length;
    private int _width;
    private double _weight;
    private static int _counter = 10; // общая для всех переменных (для счетчиков)
    public int Size { get { return _width * _length; } }
    public Car(string model, int length, int width, double weight) // Abstraction & Encapsulation
    {
        _model = model;
        _length = length;
        _width = width;
        _weight = weight;
    }
    public Car(string model, int length, int width) // Abstraction & Encapsulation
    {
        _model = "no name";
        _length = length;
        _width = width;
        _weight = 100 * length * width / 2.5;
    }
    public void Print()
    {
        _counter++;
        Console.WriteLine($"Model: {_model}, length: {_length}, {_width}, {_weight}");
    }
    public static void PrintCounter() => Console.WriteLine(_counter);
}

class Program
{
    public struct Engeneer
    {
        Car _brokenCar;
    }
    static void Main()
    {
        // тип имя (значение)
        int age = 10;
        double weight;
        float height = 175.3f;

        int[] array = new int[10];
        Car car0;
        Car car1 = new Car(); // конструктор по умолчанию
        Car car2 = new Car("Tesla", 236, 78, 1389.54); // наш конструктор
        Car car3 = new Car("Tesla", 236, 78); // наш конструктор 2й
        //car1.Print();
        //car2.Print();
        //Car.PrintCounter();
        Car[] cars = new Car[4]
            {
                new Car("Tesla", 236, 78, 1389.54),
                new Car("Ford", 278, 80, 1469.5),
                new Car("Masda", 204, new Random().Next(50, 80), 1999.54),
                new Car("Toyota", 255, 98, 1440.00),
            };

        Car.PrintCounter();
        foreach (var car in cars) // var = Car
        {
            car.Print();
        }

        Sort(cars);
        Console.WriteLine("Sorted: ");

        car0 = MaxElement(cars);
        car0.Print();
        Car.PrintCounter();
        MaxElement(cars);
        MaxElement(cars, ref car1);

        Car.PrintCounter();
        foreach (var car in cars) // var = Car
        {
            car.Print();
        }
        Console.ReadKey(); // для ожидания нажатия кнопки для закрытия консоли
    }
    static void Sort(Car[] cars)
    {
        for (int i = 0; i < cars.Length - 1; i++) // from 1 to n-1
        {
            for (int j = i + 1; j < cars.Length; j++) // from next to n
            {
                if (cars[i].Size > cars[j].Size)
                {
                    Car temp = cars[i];
                    cars[i] = cars[j];
                    cars[j] = temp;
                }
            }
        }
    }
    static Car MaxElement(Car[] cars)
    {
        Car max = cars[0];
        for (int i = 0; i < cars.Length; i++) // from 1 to n
        {
            if (cars[i].Size > max.Size)
            {
                max = cars[i];
            }
        }
        return max;
    }
    static void MaxElement(Car[] cars, ref Car maxCar)
    {
        for (int i = 0; i < cars.Length; i++) // from 1 to n
        {
            if (cars[i].Size > maxCar.Size)
            {
                maxCar = cars[i];
            }
        }
    }


}