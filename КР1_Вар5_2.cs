namespace ConsoleApp2;

public abstract class Embrasure
{
    public string Name { get; private set; }
    public double Width { get; private set; }
    public double Length { get; private set; }
    public double Thickness { get; private set; }

    protected Embrasure(string name, double width, double length, double thickness)
    {
        Name = name;
        Width = width;
        Length = length;
        Thickness = thickness;
    }

    public abstract double Cost();

    public override string ToString()
    {
        return $"Имя: {Name}, Ширина: {Width}, Длина: {Length}, Толщина: {Thickness}";
    }
}

public class Window : Embrasure
{
    public int NumberLayers { get; private set; }

    public Window(string name, double width, double length, double thickness, int numberLayers) : base(name, width, length, thickness)
    {
        NumberLayers = numberLayers;
    }

    public override double Cost()
    {
        return NumberLayers * 1000 + Width * Length * Thickness / 10;
    }

    public override string ToString()
    {
        return base.ToString() + $", Количество уровней: {NumberLayers}";
    }
}

public class Door : Embrasure
{
    public bool Glass { get; private set; }
    public bool Design { get; private set; }

    public Door(string name, double width, double length, double thickness, bool glass, bool design) : base(name, width, length, thickness)
    {
        Glass = glass;
        Design = design;
    }

    public override double Cost()
    {
        return (Glass ? 1 : 0) * 1000 + (Design ? 1 : 0) * 1500 + Width * Length * Thickness / 10;
    }

    public override string ToString()
    {
        return base.ToString() + $", {(Glass ? "Стекло есть" : "Стекла нет")}, {(Design ? "Дизайн есть" : "Дизайна нет")}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Door[] doors =
        {
            new Door("1", 10, 10, 10, true, true),
            new Door("2", 1, 1, 10, false, true),
            new Door("3", 10, 90, 10, true, false),
            new Door("4", 100, 9, 10, false, true),
            new Door("5", 7, 7, 7, false, false)
        };

        Window[] windows =
        {
            new Window("6", 10, 10, 10, 4),
            new Window("7", 1, 1, 10, 7),
            new Window("8", 10, 90, 10, 9),
            new Window("9", 100, 9, 10, 10),
            new Window("10", 7, 7, 7, 7)
        };

        for (int i = 0; i < windows.Length; i++)
        {
            for (int j = i + 1; j < windows.Length; j++)
            {
                if (windows[i].Cost() > windows[j].Cost())
                {
                    Window window = windows[i];
                    windows[i] = windows[j];
                    windows[j] = window;
                }
            }
        }

        for (int i = 0; i < doors.Length; i++)
        {
            for (int j = i + 1; j < doors.Length; j++)
            {
                if (doors[i].Cost() > doors[j].Cost())
                {
                    Door door = doors[i];
                    doors[i] = doors[j];
                    doors[j] = door;
                }
            }
        }

        Console.WriteLine("Doors");
        foreach (Door door in doors)
        {
            Console.WriteLine(door + ", Цена: " + door.Cost());
        }

        Console.WriteLine("Windows");
        foreach (Window window in windows)
        {
            Console.WriteLine(window + ", Цена: " + window.Cost());
        }

        Embrasure[] embrasures = new Embrasure[10];
        int k = 0;
        foreach (Window window in windows)
        {
            embrasures[k++] = window;
        }
        foreach (Door door in doors)
        {
            embrasures[k++] = door;
        }

        for (int i = 0; i < embrasures.Length; i++)
        {
            for (int j = i + 1; j < embrasures.Length; j++)
            {
                if (embrasures[i].Cost() > embrasures[j].Cost())
                {
                    Embrasure embrasure = embrasures[i];
                    embrasures[i] = embrasures[j];
                    embrasures[j] = embrasure;
                }
            }
        }

        Console.WriteLine("Общий список");
        foreach (Embrasure embrasure in embrasures)
        {
            Console.WriteLine(embrasure + ", Цена: " + embrasure.Cost());
        }
    }
}
