using System;
//variant 6
abstract class Animal
{
    protected string name;
    public string foodType;

    public abstract void MakeSound();
    public void DisplayInfo()
    {
        Console.WriteLine($"Животное: {name}\t Звук, который издает  {name}: ");
        MakeSound();
    }
}
class Giraffe : Animal
{
  public Giraffe()
    {
        name = "Жираф";
        foodType = "Травоядное";
    }
    public override void MakeSound()
    {
        Console.WriteLine("Ффффф");
    }
}
class Pig : Animal
{
    public Pig()
    {
        name = "Свинья";
        foodType = "Всеядное";
    }
    public override void MakeSound()
    {
        Console.WriteLine("Хрю хрю");
    }
}
class Elephant : Animal
{
    public Elephant()
    {
        name = "Слон";
        foodType = "Травоядное";
    }
    public override void MakeSound()
    {
        Console.WriteLine("Ттрр вврр");
    }
}
class Lion : Animal
{
    public Lion()
    {
        name = "Лев";
        foodType = "Хищник";
    }
    public override void MakeSound()
    {
        Console.WriteLine("Ааааррр");
    }
}
class Tiger : Animal
{
    public Tiger()
    {
        name = "Тигр";
        foodType = "Хищник";
    }
    public override void MakeSound()
    {
        Console.WriteLine("Рррррр");
    }
}
class Monkey : Animal
{
    public Monkey()
    {
        name = "Обезьяна";
        foodType = "Всеядное";
    }
    public override void MakeSound()
    {
        Console.WriteLine("Угу угу");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[]
        {
            new Giraffe(), 
            new Pig(),
            new Elephant(),
            new Lion(), 
            new Tiger(),
            new Monkey(), 
        };

        DisplayAnimals(animals, "Травоядные:");
        DisplayAnimals(animals, "Хищники:");
        DisplayAnimals(animals, "Всеядные:");
    }
    static void DisplayAnimals(Animal[] animals, string title)
    {
        Console.WriteLine($"\n{title}");
        Console.WriteLine("  ");
        foreach (var animal in animals)
        {
            if ((title == "Травоядные:" && animal.foodType == "Травоядное") ||
                (title == "Хищники:" && animal.foodType == "Хищник") ||
                (title == "Всеядные:" && animal.foodType == "Всеядное"))
            {
                animal.DisplayInfo();
            }
        }
    }
}