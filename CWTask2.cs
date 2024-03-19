using System;

abstract class Embrasure : IComparable<Embrasure>
{
    public string name;
    public double width;
    public double height;
    public double thickness;

    protected Embrasure(string name, double width, double height, double thickness)
    {
        this.name = name;
        this.width = width;
        this.height = height;
        this.thickness = thickness;
    }

    public abstract double Cost();

    public int CompareTo(Embrasure other)
    {
        return Cost().CompareTo(other.Cost());
    }
}

class Window : Embrasure
{
    private int layers;

    public Window(string name, double width, double height, double thickness, int layers) : base(name, width, height, thickness)
    {
        this.layers = layers;
    }

    public override double Cost()
    {
        width * height * thickness * layers * 7; 
    }
}

class Door : Embrasure
{
    private bool pattern;
    private bool glass;

    public Door(string name, double width, double height, double thickness, bool pattern, bool glass) : base(name, width, height, thickness)
    {
        this.pattern = pattern;
        this.glass = glass;
    }
    public override double Cost()
    {
        double baseCost = width * height * thickness * 13;
    }
}

class Program
{
    static void Main() { 
       class Program
    {
        static void Main()
        {
            Embrasure[] embrasures = new Embrasure[10];
            embrasures[0] = new Window("Window 1", 100, 120, 5, 2);
            embrasures[1] = new Window("Window 2", 80, 100, 5, 3);
            embrasures[2] = new Window("Window 3", 120, 150, 5, 4);
            embrasures[3] = new Window("Window 4", 90, 110, 5, 2);
            embrasures[4] = new Window("Window 5", 110, 130, 5, 3);
            embrasures[5] = new Door("Door 1", 90, 210, 7, true, false);
            embrasures[6] = new Door("Door 2", 80, 200, 7, false, false);
            embrasures[7] = new Door("Door 3", 100, 220, 7, true, true);
            embrasures[8] = new Door("Door 4", 85, 215, 7, false, true);
            embrasures[9] = new Door("Door 5", 95, 205, 7, true, false);

        }
    }
 }
}

