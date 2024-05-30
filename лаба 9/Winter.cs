﻿using ProtoBuf;
using System.Diagnostics.Metrics;
using System.Xml.Serialization;

[XmlInclude(typeof(FigureSkating))]
[XmlInclude(typeof(SpeedSkating))]
[ProtoInclude(69, typeof(FigureSkating))]
[ProtoInclude(96, typeof(SpeedSkating))]
[Serializable]
[ProtoContract]
public abstract class WinterSports
{
    protected string _sportsmenname;
    protected string _namediscipline;
    protected double[] _scores;
    protected int _totalplace;

    [XmlElement(ElementName = "SportsMenName")]
    [ProtoMember(1)]
    public string SportsMenName { get { return _sportsmenname; } set { _sportsmenname = value; } }
    [XmlElement(ElementName = "NameDiscipline")]
    [ProtoMember(2)]
    public string NameDiscipline { get { return _namediscipline; } set { _namediscipline = value; } }
    [XmlElement(ElementName = "Scores")]
    [ProtoMember(3)]
    public double[] Scores { get { return _scores; } set { _scores = value; } }
    [XmlElement(ElementName = "TotalPlace")]
    [ProtoMember(4)]
    public int TotalPlace { get { return _totalplace; } set { _totalplace = value; } }
    public WinterSports() { }
    public WinterSports(string namediscipline, string sportsmenname, double[] scores)
    {
        _namediscipline = namediscipline;
        _sportsmenname = sportsmenname;
        _scores = scores;
        _totalplace = 0;
    }
    public virtual void Print()
    {
        Console.WriteLine($" {_namediscipline}, {_sportsmenname}, {_totalplace}");
    }

    public static void AssignTotalPlaces(WinterSports[] figures)
    {
        for (int i = 0; i < figures.Length; i++)
        {
            int totalPlace = 0;
            for (int j = 0; j < figures.Length; j++)
            {
                if (i != j && CalculateTotalScore(figures[i]._scores) < CalculateTotalScore(figures[j]._scores))
                {
                    totalPlace++;
                }
            }
            figures[i]._totalplace = totalPlace + 1;
        }
    }

    public static double CalculateTotalScore(double[] scores)
    {
        double total = 0;
        foreach (double score in scores)
        {
            total += score;
        }
        return total;
    }

}

[Serializable]
[ProtoContract]
public class FigureSkating : WinterSports
{
    public FigureSkating() { }
    public FigureSkating(string sportsmenname, double[] scores) : base("Фигурное катание", sportsmenname, scores)
    {

    }
}

[Serializable]
[ProtoContract]
public class SpeedSkating : WinterSports
{
    public SpeedSkating() { }
    public SpeedSkating(string sportsmenname, double[] scores) : base("Конькобежный спорт", sportsmenname, scores)
    {

    }
}

class Program
{
    static void Main()
    {
        FigureSkating[] figures = new FigureSkating[]
            {
                        new FigureSkating("Маша", new double[] {5.6, 5.3, 5.0, 5.8, 5.7, 5.5, 5.9}),
                        new FigureSkating("Саша", new double[] {5.8, 5.7, 5.9, 5.5, 5.6, 5.6, 5.5}),
                        new FigureSkating("Паша", new double[] {5.0, 5.1, 5.7, 5.6, 5.9, 5.4, 5.6})
            };

        SpeedSkating[] speeds = new SpeedSkating[]
            {
                        new SpeedSkating("Леша", new double[] {5.6, 5.3, 5.0, 5.8, 5.7, 5.5, 5.9}),
                        new SpeedSkating("Ваня", new double[] {5.8, 5.7, 5.9, 5.5, 5.6, 5.6, 5.5}),
                        new SpeedSkating("Оскар", new double[] {5.0, 5.1, 5.7, 5.6, 5.9, 5.4, 5.6})
            };

        WinterSports.AssignTotalPlaces(figures);
        WinterSports.AssignTotalPlaces(speeds);

        Sort(figures);
        Sort(speeds);

        Console.WriteLine("Результаты:");
        foreach (var figure in figures)
        {
            figure.Print();
        }
        Console.WriteLine("Результаты:");
        foreach (var speed in speeds)
        {
            speed.Print();
        }
        Console.WriteLine();

        List<WinterSports> winterSportsList = new();
        winterSportsList.AddRange(figures);
        winterSportsList.AddRange(speeds);


        Stream file = File.Create(@"data\winterSports.json");
        Stream data = JSONProcessing<WinterSports>.Write(winterSportsList);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\winterSports.xml");
        data = XMLProcessing<WinterSports>.Write(winterSportsList);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\winterSports.bin");
        data = BinProcessing<WinterSports>.Write(winterSportsList);
        data.CopyTo(file);
        file.Dispose();

        winterSportsList = JSONProcessing<WinterSports>.Read(new FileStream(@"data\winterSports.json", FileMode.Open));
        Console.WriteLine("JSON файл:");
        for (int i = 0; i < winterSportsList.Count; i++)
        {
            winterSportsList[i].Print();
        }

        winterSportsList = XMLProcessing<WinterSports>.Read(new FileStream(@"data\winterSports.xml", FileMode.Open));
        Console.WriteLine("XML файл:");
        for (int i = 0; i < winterSportsList.Count; i++)
        {
            winterSportsList[i].Print();
        }

        winterSportsList = BinProcessing<WinterSports>.Read(new FileStream(@"data\winterSports.bin", FileMode.Open));
        Console.WriteLine("Bin файл:");
        for (int i = 0; i < winterSportsList.Count; i++)
        {
            winterSportsList[i].Print();
        }
    }

    static void Sort(WinterSports[] figures)
    {
        for (int i = 0; i < figures.Length - 1; i++)
        {
            for (int j = i + 1; j < figures.Length; j++)
            {
                if (figures[i].TotalPlace > figures[j].TotalPlace)
                {
                    WinterSports t = figures[i];
                    figures[i] = figures[j];
                    figures[j] = t;
                }
            }
        }
    }
}
