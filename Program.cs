using ProtoBuf;
using serializer_library;
using System.Xml.Linq;
using System.Xml.Serialization;

//1 работа
[ProtoContract]
[ProtoInclude(6, typeof(HunderedRace))]
[ProtoInclude(7, typeof(FiveHunderedRace))]
public abstract class Paticapant
{
    [ProtoMember(1)]
    public string _surname { get; set; }
    [ProtoMember(2)]
    public string _group { get; set; }
    [ProtoMember(3)]
    public string _teacherSurname { get; set; }
    [ProtoMember(4)]
    public double _result { get; set; }
    [ProtoMember(5)]
    public bool _isNormative { get; set; }
    public Paticapant() { }
    public Paticapant(string surname, string group, string teacherSurname, double result)
    {
        _surname = surname;
        _group = group;
        _teacherSurname = teacherSurname;
        _result = result;
        _isNormative = CheckNormative();
    }

    protected abstract bool CheckNormative();


    public void Print()
    {
        Console.WriteLine($"{_surname,15} | {_group,10} | {_teacherSurname,15} | {_result,10:F2} | {(_isNormative ? "Да" : "Нет"),10}");
    }
}
[ProtoContract]
public class HunderedRace : Paticapant  // Норматив для бега на 500м 165 сек 
{
    public HunderedRace() { }
    private const double NormativeTime = 110.0;
    public HunderedRace(string Surname, string Group, string TeacherSurname, double Result) : base(Surname, Group, TeacherSurname, Result)
    {

    }

    protected override bool CheckNormative()
    {
        return _result <= NormativeTime;
    }
}
[ProtoContract]
public class FiveHunderedRace : Paticapant
{
    public FiveHunderedRace() { }
    private const double NormativeTime = 165.0;
    public FiveHunderedRace(string Surname, string Group, string TeacherSurname, double Result) : base(Surname, Group, TeacherSurname, Result)
    {

    }

    protected override bool CheckNormative()
    {
        return _result <= NormativeTime;
    }
}



class Program
{
    static void Main(string[] args)
    {
        HunderedRace[] hundered = new HunderedRace[]
        {
                new HunderedRace ("Jenn","1","Kenn",96),
                new HunderedRace("Zutdly", "2", "Jhnn", 109),
                new HunderedRace("Pory", "3", "Proxy", 101),
                new HunderedRace("Yorn", "4", "Bolly", 190),
                new HunderedRace("Ioen", "5", "Denzly", 140)
        };
        FiveHunderedRace[] fivehundered = new FiveHunderedRace[]
        {
                new FiveHunderedRace("Ionn", "6", "Leo",190),
                new FiveHunderedRace("Lina", "7", "Dennis",132),
                new FiveHunderedRace("Pudge", "8", "Player",154),
                new FiveHunderedRace("Sven", "9", "Admin",180),
                new FiveHunderedRace("Lion", "10", "Ceo",173),
        };


        InsertionSort(hundered);
        InsertionSort(fivehundered);


        Console.WriteLine("\n100 метров:");
        Console.WriteLine("{0,15} | {1,10} | {2,15} | {3,10} | {4,10}", "Фамилия", "Группа", "Фамилия преподавателя", "Результат", "Норматив");

        foreach (var pat in hundered)
        {
            pat.Print();
        }

        Console.WriteLine("\n500 метров");
        Console.WriteLine("{0,15} | {1,10} | {2,15} | {3,10} | {4,10}", "Фамилия", "Группа", "Фамилия преподавателя", "Результат", "Норматив");

        foreach (var pat in fivehundered)
        {
            pat.Print();
        }
        int hunderednormativecounter = hundered.Count(p => p._isNormative);
        int fivehunderedNormativeCounter = fivehundered.Count(p => p._isNormative);
        Console.WriteLine($"\nКоличество участниц, выполнивших норматив на 100м: {hunderednormativecounter}");
        Console.WriteLine($"\nКоличество участниц, выполнивших норматив на 500м: {fivehunderedNormativeCounter}");

        var json = new json_serializer();
        var xml = new xml_serializer();
        var binary = new binary_serializer();
        string path = @"C:\Users\artem\Desktop";
        string folderName = "Solution";
        path = Path.Combine(path, folderName);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        string name1 = "work-1.json";
        string name2 = "work-1.xml";
        string name3 = "work-1.bin";

        name1 = Path.Combine(path, name1);
        name2 = Path.Combine(path, name2);
        name3 = Path.Combine(path, name3);

        json.Serializetion<HunderedRace[]>(hundered, name1);
        xml.Serializetion<FiveHunderedRace[]>(fivehundered, name2);
        binary.Serializetion<FiveHunderedRace[]>(fivehundered, name3);

        Console.WriteLine("\n\nФайлы Json на 100 метров:");
        Console.WriteLine("{0,15} | {1,10} | {2,15} | {3,10} | {4,10}", "Фамилия", "Группа", "Фамилия преподавателя", "Результат", "Норматив");
        var deserealized_1 = json.Deserializetion<HunderedRace[]>(name1);
        Console.WriteLine();
        foreach (var pat in deserealized_1)
        {
            pat.Print();
        }

        Console.WriteLine("\n\nФайлы XML на 500 метров:");
        Console.WriteLine("{0,15} | {1,10} | {2,15} | {3,10} | {4,10}", "Фамилия", "Группа", "Фамилия преподавателя", "Результат", "Норматив");
        var deserealized_2 = xml.Deserializetion<FiveHunderedRace[]>(name2);
        Console.WriteLine();
        foreach (var pat in deserealized_2)
        {
            pat.Print();
        }

        Console.WriteLine("\n\nФайлы Binary на 500 метров:");
        Console.WriteLine("{0,15} | {1,10} | {2,15} | {3,10} | {4,10}", "Фамилия", "Группа", "Фамилия преподавателя", "Результат", "Норматив");
        var deserealized_3 = binary.Deserializetion<FiveHunderedRace[]>(name3);
        Console.WriteLine();
        foreach (var pat in deserealized_3)
        {
            pat.Print();
        }

    }

    static void InsertionSort(Paticapant[] parts)
    {
        for (int i = 1; i < parts.Length; i++)
        {
            Paticapant key = parts[i];
            int j = i - 1;

            while (j >= 0 && parts[j]._result > key._result)
            {
                parts[j + 1] = parts[j];
                j = j - 1;
            }
            parts[j + 1] = key;
        }
    }
}


//2 работа
//[ProtoContract]
//[ProtoInclude(4, typeof(Student))]
//public abstract class Person
//{
//    [ProtoMember(1)]
//    public string _name { get; set; }
//    public int _markMath { get; set; }
//    public int _markPhys { get; set; }
//    public int _markRus { get; set; }
//    [ProtoMember(2)]
//    public double _avgMark { get; set; }
//    public bool _isPastExm { get; set; }

//    public Person(string name, int markmat, int markphys, int markrus)
//    {
//        _name = name;
//        _markMath = markmat;
//        _markPhys = markphys;
//        _markRus = markrus;
//        _avgMark = (_markMath + _markPhys + _markRus) / 3.0;
//        _isPastExm = (_markMath >= 3 && _markPhys >= 3 && _markRus >= 3);

//    }
//    public Person()
//    {
//    }

//    public virtual void Print()
//    {
//        Console.WriteLine($"{_name,15} | {Math.Round(_avgMark),10} | ");
//    }

//}

//[ProtoContract]
//public class Student : Person
//{
//    [ProtoMember(3)]
//    public string _id { get; set; }
//    public Student(string name, int markmat, int markphys, int markrus, string id) : base(name, markmat, markphys, markrus)
//    {
//        _id = id;

//    }
//    public Student()
//    {

//    }
//    public string Id => _id;

//    public override void Print()
//    {
//        Console.WriteLine($"{_name,15} | {Math.Round(_avgMark),10} | ID: {_id}");
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        Student[] students = new Student[]
//        {
//                new Student("Иван", 3, 5, 5 , "000"),
//                new Student("Сергей", 3, 3, 3, "001"),
//                new Student("Колян", 3, 4, 2, "010"),
//                new Student("Сеня", 3, 4, 4, "011"),
//                new Student("ВВП", 5, 5, 5, "100"),
//                new Student("Ждан", 3, 4, 4, "101")

//        };

//        var passedStudent = students.Where(s => s._isPastExm).ToArray();


//        //InsertionSort(passedStudent);

//        var sortedStudent = passedStudent.OrderByDescending(s => s._avgMark).ToArray();

//        Console.WriteLine($"{"Имя",15}  {"Средняя оценка",10}  {"ID",5}");

//        foreach (var student in sortedStudent)
//        {
//            student.Print();
//        }

//        var json = new json_serializer();
//        var xml = new xml_serializer();
//        var binary = new binary_serializer();

//        string path = @"C:\Users\artem\Desktop";
//        string folderName = "Solution";
//        path = Path.Combine(path, folderName);
//        if (!Directory.Exists(path))
//        {
//            Directory.CreateDirectory(path);
//        }
//        string name1 = "work-2.json";
//        string name2 = "work-2.xml";
//        string name3 = "work-2.bin";

//        name1 = Path.Combine(path, name1);
//        name2 = Path.Combine(path, name2);
//        name3 = Path.Combine(path, name3);

//        json.Serializetion<Student[]>(sortedStudent, name1);
//        xml.Serializetion<Student[]>(sortedStudent, name2);
//        binary.Serializetion<Student[]>(sortedStudent, name3);

//        Console.Write("\n\nФайл Json:\n");
//        Console.WriteLine($"{"Имя",15}  {"Средняя оценка",10}  {"ID",5}");
//        var deserealized_1 = json.Deserializetion<Student[]>(name1);
//        foreach (var student in deserealized_1)
//        {
//            student.Print();
//        }

//        Console.Write("\n\nФайл XML:\n");
//        Console.WriteLine($"{"Имя",15}  {"Средняя оценка",10}  {"ID",5}");
//        var deserealized_2 = xml.Deserializetion<Student[]>(name2);
//        foreach (var student in deserealized_2)
//        {
//            student.Print();
//        }

//        Console.Write("\n\nФайл Binary:\n");
//        Console.WriteLine($"{"Имя",15}  {"Средняя оценка",10}  {"ID",5}");
//        var deserealized_3 = binary.Deserializetion<Student[]>(name3);
//        foreach (var student in deserealized_3)
//        {
//            student.Print();
//        }
//    }
//}

//3 работа
//[ProtoContract]
//[ProtoInclude(4, typeof(WomenFootballTeam))]
//[ProtoInclude(5, typeof(MenFootballTeam))]
//public class FootballTeam
//{
//    [ProtoMember(1)]
//    public string _name {  get; set; }
//    [ProtoMember(2)]
//    public int _points { get; set; }
//    [ProtoMember(3)]
//    public string _gender { get; set; } = "";

//    public FootballTeam() 
//    {

//    }
//    public FootballTeam(string name, int points)
//    {
//        _name = name;
//        _points = points;
//    }
//}
//[ProtoContract]
//public class WomenFootballTeam : FootballTeam
//{
//    public WomenFootballTeam() 
//    {

//    }
//    public WomenFootballTeam(string Name, int Points) : base(Name, Points)
//    {
//        _gender = "Women";
//    }
//}
//[ProtoContract]
//public class MenFootballTeam : FootballTeam
//{
//    public MenFootballTeam()
//    {

//    }
//    public MenFootballTeam(string Name, int Points) : base(Name, Points)
//    {
//        _gender = "Men";
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        WomenFootballTeam[] womenteam = new WomenFootballTeam[]
//        {
//            new WomenFootballTeam ( "Women Team A1", 10 ),
//            new WomenFootballTeam( "Women Team A2", 9 ),
//            new WomenFootballTeam("Women Team A3", 3 ),
//            new WomenFootballTeam( "Women Team A4", 10 ),
//            new WomenFootballTeam( "Women Team A5", 11 ),
//            new WomenFootballTeam( "Women Team A6", 12 ),
//            new WomenFootballTeam( "Women Team A7", 9 ),
//            new WomenFootballTeam( "Women Team A8", 8 ),
//            new WomenFootballTeam( "Women Team A9", 5 ),
//            new WomenFootballTeam( "Women Team A10", 3 ),
//            new WomenFootballTeam( "Women Team A11", 4 ),
//            new WomenFootballTeam( "Women Team A12" ,11 ),
//        };


//        MenFootballTeam[] menteam = new MenFootballTeam[]
//        {
//            new MenFootballTeam( "Men Team B1", 12 ),
//            new MenFootballTeam ( "Men Team B2", 6 ),
//            new MenFootballTeam ( "Men Team B3", 3 ),
//            new MenFootballTeam ( "Men Team B4", 3 ),
//            new MenFootballTeam ( "Men Team B5", 12 ),
//            new MenFootballTeam ( "Men Team B6", 10 ),
//            new MenFootballTeam ( "Men Team B7", 9 ),
//            new MenFootballTeam ( "Men Team B8", 11 ),
//            new MenFootballTeam ( "Men Team B9",  5 ),
//            new MenFootballTeam ( "Men Team B10", 3 ),
//            new MenFootballTeam ( "Men Team B11", 1 ),
//            new MenFootballTeam ( "Men Team B12", 8 ),
//        };


//        Sort(womenteam);
//        Sort(menteam);


//        FootballTeam[] commantable = MergeArrays(womenteam, menteam);


//        foreach (var team in commantable)
//        {
//            try
//            {
//                Console.WriteLine($"{team._gender}, {team._name}, {team._points} баллов");
//            }
//            catch { }
//        }

//        var json = new json_serializer();
//        var xml = new xml_serializer();
//        var binary = new binary_serializer();

//        string path = @"C:\Users\artem\Desktop";
//        string folderName = "Solution";
//        path = Path.Combine(path, folderName);
//        if (!Directory.Exists(path))
//        {
//            Directory.CreateDirectory(path);
//        }
//        string name1 = "work-3.json";
//        string name2 = "work-3.xml";
//        string name3 = "work-3.bin";

//        name1 = Path.Combine(path, name1);
//        name2 = Path.Combine(path, name2);
//        name3 = Path.Combine(path, name3);

//        json.Serializetion<FootballTeam[]>(commantable, name1);
//        xml.Serializetion<WomenFootballTeam[]>(womenteam, name2);
//        binary.Serializetion<MenFootballTeam[]>(menteam, name3);

//        Console.Write("\n\nФайл Json - общий:\n");
//        var deserealized_1 = json.Deserializetion<FootballTeam[]>(name1);
//        foreach (var team in deserealized_1)
//        {
//            try
//            {
//                Console.WriteLine($"{team._gender}, {team._name}, {team._points} баллов");
//            }
//            catch { }
//        }

//        Console.Write("\n\nФайл XML - женские команды:\n");
//        var deserealized_2 = xml.Deserializetion<WomenFootballTeam[]>(name2);
//        foreach (var team in deserealized_2)
//        {
//            try
//            {
//                Console.WriteLine($"{team._gender}, {team._name}, {team._points} баллов");
//            }
//            catch { }
//        }

//        Console.Write("\n\nФайл Binary - мужские команды:\n");
//        var deserealized_3 = binary.Deserializetion<MenFootballTeam[]>(name3);
//        foreach (var team in deserealized_3)
//        {
//            try
//            {
//                Console.WriteLine($"{team._gender}, {team._name}, {team._points} баллов");
//            }
//            catch { }
//        }
//    }



//    static FootballTeam[] MergeArrays(FootballTeam[] array1, FootballTeam[] array2)
//    {
//        int n1 = array1.Length;
//        int n2 = array2.Length;
//        FootballTeam[] mergedArray = new FootballTeam[n1 + n2];
//        int i = 0, j = 0, k = 0;

//        while (i < n1 && j < n2 && k < 12)
//        {
//            if (array1[i]._points >= array2[j]._points)
//            {
//                mergedArray[k++] = array1[i++];
//            }
//            else
//            {
//                mergedArray[k++] = array2[j++];
//            }
//        }

//        while (i < n1 && k < 12)
//        {
//            mergedArray[k++] = array1[i++];
//        }

//        while (j < n2 && k < 12)
//        {
//            mergedArray[k++] = array2[j++];
//        }

//        return mergedArray;
//    }



//    static void Sort(FootballTeam[] teams)
//    {
//        for (int i = 0; i < teams.Length - 1; i++)
//        {
//            for (int j = 0; j < teams.Length - i - 1; j++)
//            {
//                if (teams[j]._points < teams[j + 1]._points)
//                {
//                    FootballTeam temp = teams[j];
//                    teams[j] = teams[j + 1];
//                    teams[j + 1] = temp;
//                }
//            }
//        }
//    }
//}