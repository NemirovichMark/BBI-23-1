// See https://aka.ms/new-console-template for more information
//задание 2 вар 4
using System;

abstract class Embrasur
{
    protected string name;
    protected int length;
    protected int t;

    protected Embrasur(string name, int length, int th)
    {
        this.name = name;
        this.length = length;
        this.t = th;
    }

    protected abstract int CCost();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Тип: {name}");
        Console.WriteLine($"Длина: {length} м");
        Console.WriteLine($"Толщинаа: {t} cm");
        Console.WriteLine($"Стоимость: {CCost()} RUB");
    }
}