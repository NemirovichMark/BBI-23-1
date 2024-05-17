//Лыжные гонки проводятся отдельно для двух групп участников. Результаты 
//соревнований заданы в виде фамилий участников и их результатов в каждой 
//группе. Расположить результаты соревнований в каждой группе в порядке 
//занятых мест. Объединить результаты обеих групп с сохранением 
//упорядоченности и вывести в виде таблицы с заголовком.

//Создать класс «Команда» с 2 классами-наследниками: «Женская команда» и «Мужская команда».
//Соревнования среди команд независимые.
//Провести среди них отдельные соревнования,
//вывести таблицы для каждой группы (жен-1, жен-2, муж-1, муж-2),
//общую для женщин и общую мужчин, и общую для всех участников.
//Использовать динамическую связку: преобразование классов.
//Должно быть 7 таблиц с выводом.

//region 3.4 lab 7

using ProtoBuf;
using System;
using System.Text.Json.Serialization;
using Lab9_3_4.Serializers;
using System.IO;
using System.Xml.Serialization;

[Serializable]
[ProtoContract]
[ProtoInclude(3, typeof(Skier))]
[ProtoInclude(4, typeof(Skieress))]
public class Sportsman
{
    [JsonIgnore]
    [NonSerialized]
    protected string _lastName;
    [JsonIgnore]
    [NonSerialized]
    protected int _finishTime;
    [ProtoMember(1)]
    [JsonInclude]
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value ?? string.Empty; }
    }
    
    [ProtoMember(2)]
    [JsonInclude]
    public int FinishTime
    {
        get { return _finishTime; }
        set
        {
            if (value >= 0) _finishTime = value;
        }
    }
    [JsonConstructor]
    public Sportsman(string lastName, int finishTime)
    {
        _lastName = lastName;
        _finishTime = finishTime;
    }
    public Sportsman() { }
    public virtual void Print()
    {
        Console.WriteLine( $"{LastName} - {FinishTime} очка");
    }
    
    //public static void SortResults(ref Sportsman[] results) //не работает для наследников(((( почему-то
    //{

    //    for (int i = 0; i < results.Length - 1; i++)
    //    {
    //        for (int j = i + 1; j < results.Length; j++)
    //        {
    //            if (results[j].FinishTime > results[i].FinishTime)
    //            {
    //                Sportsman a = results[i];
    //                results[i] = results[j];
    //                results[j] = a;
    //            }
    //        }
    //    }
    //}

}
[Serializable]
[ProtoContract]
public class Skier : Sportsman
{

    public Skier(): base() { }
    [JsonConstructor]
    public Skier(string lastName, int finishTime) : base(lastName, finishTime) { }
    public override void  Print()
    {
        Console.WriteLine($"Мужская команда - {_lastName} - {_finishTime} очка");
    }
    
}
[Serializable]
[ProtoContract]
public class Skieress : Sportsman
{
    public Skieress() : base() { }
    [JsonConstructor]
    public Skieress(string lastName, int finishTime) : base(lastName, finishTime) { }
    public override void Print()
    {
        Console.WriteLine($"Женская команда - {_lastName} - {_finishTime} очка");
    }
    
}

public class SkiRace
{

    private Skieress[] skieressGroup1Results;

    private Skieress[] skieressGroup2Results;

    private Skier[] skierGroup1Results;
 
    private Skier[] skierGroup2Results;
   
    public SkiRace()
    {
        skieressGroup1Results = new Skieress[]
        {
            new Skieress("Чиченкова", 60),
            new Skieress("Агапова", 55),
            new Skieress("Чайкина", 58),
            new Skieress("Абраменкова", 57),
            new Skieress("Бычкова", 62)
        };

        skieressGroup2Results = new Skieress[]
        {
            new Skieress("Куулар", 63),
            new Skieress("Лунина", 56),
            new Skieress("Щербакова", 59),
            new Skieress("Родина", 61),
            new Skieress("Лищенко", 58)
        };

        skierGroup1Results = new Skier[]
        {
            new Skier("Стоценко", 57),
            new Skier("Виноградов", 59),
            new Skier("Смирнов", 58),
            new Skier("Волков", 56),
            new Skier("Иванов", 61)
        };

        skierGroup2Results = new Skier[]
        {
            new Skier("Зайцев", 62),
            new Skier("Павлов", 63),
            new Skier("Козлов", 55),
            new Skier("Голубев", 58),
            new Skier("Горбунов", 60)
        };

        MergeAndPrintResults();
    }
    private static void SortResults(ref Skieress[] results) // метод SortResults нормально работает только вот с таким тройным повторением кода
                                                            //- для класса-родителя Sportsman  и его наследников
    {

        for (int i = 0; i < results.Length - 1; i++)
        {
            for (int j = i + 1; j < results.Length; j++)
            {
                if (results[j].FinishTime > results[i].FinishTime)
                {
                    Skieress a = results[i];
                    results[i] = results[j];
                    results[j] = a;
                }
            }
        }
    }
    private static void SortResults(ref Skier[] results)
    {

        for (int i = 0; i < results.Length - 1; i++)
        {
            for (int j = i + 1; j < results.Length; j++)
            {
                if (results[j].FinishTime > results[i].FinishTime)
                {
                    Skier a = results[i];
                    results[i] = results[j];
                    results[j] = a;
                }
            }
        }
    }
    private static void SortResults(ref Sportsman[] results) 
    {

        for (int i = 0; i < results.Length - 1; i++)
        {
            for (int j = i + 1; j < results.Length; j++)
            {
                if (results[j].FinishTime > results[i].FinishTime)
                {
                    Sportsman a = results[i];
                    results[i] = results[j];
                    results[j] = a;
                }
            }
        }
    }

    private void PrintResults(Sportsman[] results, string groupName)
    {
        Console.WriteLine($"\nРезультаты для группы {groupName}:");
        Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Фамилия", "Время", "Группа");

        int place = 1;
        foreach (var result in results)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", result.LastName, result.FinishTime, result.GetType().Name + $" (место {place++})"); 
        }
    }

    private void MergeAndPrintResults()
    {
        SortResults(ref skieressGroup1Results);
        SortResults(ref skieressGroup2Results);
        SortResults(ref skierGroup1Results);
        SortResults(ref skierGroup2Results);

        PrintResults(skieressGroup1Results, "Лыжницы-1");
        PrintResults(skieressGroup2Results, "Лыжницы-2");
        PrintResults(skierGroup1Results, "Лыжники-1");
        PrintResults(skierGroup2Results, "Лыжники-2");

        Skieress[] WomenResults = new Skieress[skieressGroup1Results.Length + skieressGroup2Results.Length];
        Array.Copy(skieressGroup1Results, WomenResults, skieressGroup1Results.Length);
        Array.Copy(skieressGroup2Results, 0, WomenResults, skieressGroup1Results.Length, skieressGroup2Results.Length);
        SortResults(ref WomenResults);
        PrintResults(WomenResults, "Все женские команды");
        Skier[] MenResults = new Skier[skierGroup1Results.Length + skierGroup2Results.Length];
        Array.Copy(skierGroup1Results, MenResults, skierGroup1Results.Length);
        Array.Copy(skierGroup2Results, 0, MenResults, skierGroup1Results.Length, skierGroup2Results.Length);
        SortResults(ref MenResults);
        PrintResults(MenResults, "Все мужские команды");
        //Сериализация:
        MySerializer[] serializers = new MySerializer[3] { new JsonMySerializer(), new XmlMySerializer(), new BinMySerializer() };
        string[] files = new string[6] { "women.json", "women.xml", "women.bin","men.json","men.xml", "men.bin"};

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // путь к рабочему столу
        string folder = "FilesForLab9_3";
        path = Path.Combine(path, folder);// путь к папке, располагающейся на рабочем столе, здесь будем создавать файлы и записывать в них информацию

        for (int i = 0; i < serializers.Length; i++)
        {
            serializers[i].Write(WomenResults, Path.Combine(path, files[i]));
            serializers[i].Write(MenResults, Path.Combine(path, files[i+3])); //записываем результаты сериализации в каждом формате в файл соответсвующего формата
        }
        //Десериализация:
        Console.WriteLine("Десериализация:");
        for (int i = 0; i < serializers.Length; i++)
        {
            Skieress[] newWomenResults = serializers[i].Read<Skieress[]>(Path.Combine(path, files[i]));
            Skier[] newMenResults = serializers[i].Read<Skier[]>(Path.Combine(path, files[i + 3]));
            Console.WriteLine($">>>>>From {files[i]}<<<<<<<");
            foreach (var sportsman in newWomenResults)
            {
                sportsman.Print();
            }
            //PrintResults(newWomenResults, "полученная при десериализации новая женская группа");
            Console.WriteLine($">>>>>From {files[i + 3]}<<<<<<");
            foreach (var sportsman in newMenResults)
            {
                sportsman.Print();
            }
            //PrintResults(newMenResults, "полученная при десериализации новая мужская группа");
        }
        
        Sportsman[] allResults = new Sportsman[WomenResults.Length + MenResults.Length];
        Array.Copy(WomenResults, allResults, WomenResults.Length);
        Array.Copy(MenResults, 0, allResults, WomenResults.Length, MenResults.Length);
        SortResults(ref allResults);
        PrintResults(allResults, "Все участники");
        Console.ReadKey();
    }
}

class Program
{
    static void Main()
    {
        SkiRace skiRace = new SkiRace();
    }
}
