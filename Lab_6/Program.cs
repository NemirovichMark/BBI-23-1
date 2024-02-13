using System.Drawing;

public struct Car
{
    private string _model;
    private int _length;
    private int _width;
    private double _weight;
    private static int _counter; // общая для всех переменных (для счетчиков)
    static Car() // если нужно задать другое значение статической переменной
    {
        _counter = 10;
    }
    public Car(string model, int length, int width, double weight)
    {
        _model = model;
        _length = length;
        _width = width;
        _weight = weight;
    }
    public void Print()
    {
        _counter++;
        Console.WriteLine($"{_model}, {_length}, {_width}, {_weight}");
    }
    public static void PrintCounter() => Console.WriteLine(_counter);
}

class Program
{
    static void Main(string[] args, int argc)
    {
        // тип имя (значение)
        int age = 10;
        double weight;
        float height = 175.3f;

        int[] array = new int[10];
        Car car0;
        Car car1 = new Car(); // конструктор по умолчанию
        Car car2 = new Car("Tesla", 236, 78, 1389.54); // наш конструктор
        car1.Print();
        car2.Print();
        Car.PrintCounter();
        Console.ReadKey(); // для ожидания нажатия кнопки для закрытия консоли
    }