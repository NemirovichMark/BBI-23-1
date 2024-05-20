//2.7 lab 7
// После окончания соревнования по шахматам турнирная таблица содержит фамилии 
//участников и результаты сыгранных партий (выигрыш – 1 очко, ничья – 1/2 очка,
//проигрыш – 0 очков). Составить итоговую таблицу в порядке убывания 
//полученных участниками очков. 
//Сделать класс «Человек». Класс «Спортсмен» должен наследоваться от него,
//и иметь дополнительное поле «ид». При выводе в таблице должны быть ФИО,
//ид и балл. Ид должен создаваться программно.
//Не из main. И не заводиться с консоли. И он должен быть уникальным.

using System;
using Lab9_2_7.Serializers;
using ProtoBuf;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        Sportsman[] players = new Sportsman[5];

        players[0] = new Sportsman("Чиченкова", 1);
        players[1] = new Sportsman("Бычкова", 0.5);
        players[2] = new Sportsman("Куулар", 0);
        players[3] = new Sportsman("Агапова", 1);
        players[4] = new Sportsman("Чайкина", 0.5);

        Array.Sort(players, (x, y) => y.Score.CompareTo(x.Score));

        Console.WriteLine("Турнирная таблица:");
        foreach (var player in players)
        {
            Console.WriteLine($"{player.FullName} ({player.Id}) - {player.Score} очка");
        }
        //Сериализация:
        MySerializer[] serializers = new MySerializer[3] { new JsonMySerializer(), new XmlMySerializer(), new BinMySerializer() };
        string[] files = new string[3] { "serialize.json", "serialize.xml", "serialize.bin" };
        
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // путь к рабочему столу
        string folder = "FilesForLab9_2";
        path = Path.Combine(path, folder);// путь к папке, располагающейся на рабочем столе, здесь будем создавать файлы и записывать в них информацию

        for (int i = 0; i < serializers.Length; i++)
        {
            serializers[i].Write(players, Path.Combine(path, files[i])); //записываем результаты сериализации в каждом формате в файл соответсвующего формата
        }
        //Десериализация:
        Console.WriteLine("Десериализация:");
        for (int i = 0; i < serializers.Length; i++)
        {

            Sportsman[] newplayers = serializers[i].Read<Sportsman[]>(Path.Combine(path, files[i]));
            Console.WriteLine($"(Из файла {files[i]})");
            foreach (var newplayer in newplayers) //var = Sportsman
            {
                Console.WriteLine($"{newplayer.FullName} - {newplayer.Score} очка");
            }
        }
        Console.ReadKey();
    }
}
[Serializable]
[ProtoContract]
[ProtoInclude(1, typeof(Sportsman))]
public class Human
{
    [JsonIgnore]
    [NonSerialized]
    protected string _fullName;
    [ProtoMember(2)]
    [JsonInclude]
    public string FullName
    {
        get { return _fullName; }
        set { _fullName = value ?? string.Empty; }
    }
    [JsonConstructor]
    public Human(string fullName)
    {
        _fullName = fullName;
    }
    public Human() { } //конструктор для XML сериализации
}
[Serializable]
[ProtoContract]
public class Sportsman : Human
{
    [JsonIgnore]
    [NonSerialized]
    private double _score;
    [JsonIgnore]
    [NonSerialized]
    private static int nextId = 1;
    [JsonIgnore]
    [NonSerialized]
    private string _id;
    [ProtoMember(3)]
    [JsonInclude]
    public double Score { get { return _score; } set { if (value > 0) _score = value; } }
    public string Id
    {
        get { return _id; }
        set { _id = value ?? string.Empty; }
    }
    public Sportsman(string fullName, double score) : base(fullName)
    {
        _score = score;
        _id = "ID" + nextId;
        nextId++;
    }
    [JsonConstructor]
    public Sportsman(string fullName, double score, string id) : base(fullName)
    {
        _score = score;
        _id = id;
        nextId++;
    }
    public Sportsman() : base() { } //для XML сериализации
}
