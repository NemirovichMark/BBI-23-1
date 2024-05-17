// 1.1 lab 7

using System;
using Lab9_1_1.Serializers;
using ProtoBuf;
using System.IO;
using System.Text.Json.Serialization;


[Serializable]
[ProtoContract]
public class JumpResult
{
    [JsonIgnore]
    [NonSerialized]
    private string _lastName;
    [JsonIgnore]
    [NonSerialized]
    private string _society;
    [JsonIgnore]
    [NonSerialized]
    private double _result1;
    [JsonIgnore]
    [NonSerialized]
    private double _result2;
    [JsonIgnore]
    [NonSerialized]
    private double _totalResult;
    [JsonIgnore]
    [NonSerialized]
    private bool _isDisqualified;
    [ProtoMember(1)]
    [JsonInclude]
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value ?? string.Empty; } // проверка на ввод для строки - проверка на то, что она не пустая
    }
    [ProtoMember(2)]
    [JsonInclude]
    public string Society
    {
        get { return _society; }
        set { _society = value ?? string.Empty; }
    }
    [ProtoMember(3)]
    [JsonInclude]
    public double Result1
    {
        get { return _result1; }
        set { if (value > 0) _result1 = value; } // проверка на ввод для числа - чтобы результат был положительный
    }
    [ProtoMember(4)]
    [JsonInclude]
    public double Result2
    {
        get { return _result2; }
        set { if (value > 0) _result2 = value; } 
    }
    [ProtoMember(5)]
    [JsonInclude]
    public double TotalResult
    {
        get { return _totalResult; }
        set { if (value > 0) _totalResult = value; }
    } 
    [ProtoMember(6)]
    [JsonInclude]
    public bool IsDisqualified
    { 
        get { return _isDisqualified; }
        set { _isDisqualified = value; } 
    }
    public JumpResult(string lastName, string society, double result1, double result2)
    {
        LastName = lastName;
        Society = society;
        Result1 = result1;
        Result2 = result2;
        TotalResult = result1 + result2;
        IsDisqualified = false;
    }
    
    public JumpResult(string lastName, string society, double result1, double result2, bool isDisqualified)
    {
        LastName = lastName;
        Society = society;
        Result1 = result1;
        Result2 = result2;
        TotalResult = result1 + result2;
        IsDisqualified = isDisqualified;
    }
    [JsonConstructor]//конструктор, который будет использоваться для десериализации в JSON, в качестве параметров в конструктор передаются все поля, помеченные [JsonInclude] 
    public JumpResult(string lastName, string society, double result1, double result2, double totalResult, bool isDisqualified) : this(lastName,society, result1, result2, isDisqualified) { }
    // Беспараметрический конструктор для сериализации в XML формате
    public JumpResult() { }
    //Объявление публичного метода Disqualify без параметров
    public void Disqualify()
    {
        //Присваивание логического значения true свойству IsDisqualified
        IsDisqualified = true;
    }
    //Переопределение метода ToString для класса JumpResult
    public override string ToString() //вывод по заданию 
    {
        return string.Format("{0,-15} {1,-15} {2,15} {3,15} {4,15}", LastName, Society, Result1, Result2, TotalResult);
    }
    public void Print() //вывод для десериализации (видны все поля, в том числе и поле "дисквалифицирован")
    {
        Console.WriteLine($"{_lastName,-15} {_society,-15} {_result1,15} {_result2,15} {_totalResult,15} {_isDisqualified,15}");
    }
}
class JumpCompetition
{
    static void Main()
    {
        JumpResult[] results = new JumpResult[]
        {
            new JumpResult("Чайкина", "МИСиС", 5.6, 6.2),
            new JumpResult("Чичинкова", "ВШЭ", 5.5, 6.0),
            new JumpResult("Лунин", "МГИМО", 5.8, 6.1),
            new JumpResult("Бычкова", "МГТУ", 5.7, 6.3),
            new JumpResult("Агапова", "МГУ", 5.9, 6.2)
        };

        results[2].Disqualify();

        Array.Sort(results, (x, y) =>
        {
            if (!x.IsDisqualified && !y.IsDisqualified)
            {
                return y.TotalResult.CompareTo(x.TotalResult); 
            }
            else if (x.IsDisqualified && !y.IsDisqualified)
            {
                return 1; 
            }
            else if (!x.IsDisqualified && y.IsDisqualified)
            {
                return -1; 
            }
            else
            {
                return 0; 
            }
        });

        Console.WriteLine("{0,-15} {1,-15} {2,15} {3,15} {4,15}", "Фамилия", "Общество", "1-ая попытка", "2-ая попытка", "Итого");
        Console.WriteLine(new string('-', 100));

        foreach (var result in results)
        {
            if (!result.IsDisqualified)
            {
                Console.WriteLine(result);
            }
        }
        MySerializer[] serializers = new MySerializer[3] { new JsonMySerializer(), new XmlMySerializer(), new BinMySerializer() };
        string[] files = new string[3] { "serialize.json", "serialize.xml", "serialize.bin" };
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // путь к рабочему столу
        string folder = "FilesForLab9_1";
        path = Path.Combine(path, folder);// путь к папке, располагающейся на рабочем столе, здесь будем создавать файлы и записывать в них информацию
        
        for (int i = 0; i < serializers.Length; i++)
        {
            serializers[i].Write(results, Path.Combine(path, files[i])); //записываем результаты сериализации в каждом формате в файл соответсвующего формата
        }
        
        Console.WriteLine("Десериализация:");
        Console.WriteLine("{0,-15} {1,-15} {2,15} {3,15} {4,15} {5,15}", "Фамилия", "Общество", "1-ая попытка", "2-ая попытка", "Итого", "Дисквалифицирован?");
        Console.WriteLine(new string('-', 100));
        for (int i = 0; i < serializers.Length; i++)
        {

            JumpResult[] results1 = serializers[i].Read<JumpResult[]>(Path.Combine(path, files[i]));
            Console.WriteLine($"(Из файла {files[i]})");
            foreach (var result1 in results1) //var = JumpResult
            {
                result1.Print();
            }
        }
        Console.ReadKey();
    }
}

