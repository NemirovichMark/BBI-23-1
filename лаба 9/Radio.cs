using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProtoBuf;

[XmlInclude(typeof(Man))]
[XmlInclude(typeof(Opening))]
[ProtoInclude(69, typeof(Man))]
[ProtoInclude(96, typeof(Opening))]
[Serializable]
[ProtoContract]
public abstract class RadioPoll
{
    private static int _totalVotes = 0;
    private string _answer;
    private int _count;
    [XmlElement(ElementName = "Answer")]
    [ProtoMember(1)]
    public string Answer { get { return _answer; } set { _answer = value; } }
    [XmlElement(ElementName = "Count")]
    [ProtoMember(2)]
    public int Count { get { return _count; } set { _count = value; } }
    [XmlElement(ElementName = "TotalVotes")]
    [ProtoMember(3)]
    public static int TotalVotes { get { return _totalVotes; } set { _totalVotes = value; } }

    public RadioPoll() { }
    public RadioPoll(string answer, int count)
    {
        _answer = answer;
        _count = count;
        _totalVotes += count;
    }

    public virtual void Print()
    {
        double percentage = (double)Count / TotalVotes * 100;
        Console.WriteLine($"Ответ: {Answer} - {percentage:f2}% от общего количества ответов");
    }

    public static void MergeSort(RadioPoll[] polls)
    {
        if (polls.Length < 2)
            return;

        int mid = polls.Length / 2;
        RadioPoll[] leftPolls = new RadioPoll[mid];
        RadioPoll[] rightPolls = new RadioPoll[polls.Length - mid];

        Array.Copy(polls, 0, leftPolls, 0, mid);
        Array.Copy(polls, mid, rightPolls, 0, polls.Length - mid);

        MergeSort(leftPolls);
        MergeSort(rightPolls);

        Merge(polls, leftPolls, rightPolls);
    }

    private static void Merge(RadioPoll[] polls, RadioPoll[] leftP, RadioPoll[] rightP)
    {
        int leftI = 0;
        int rightI = 0;
        int pollsI = 0;

        while (leftI < leftP.Length && rightI < rightP.Length)
        {
            if (leftP[leftI].Count >= rightP[rightI].Count)
            {
                polls[pollsI++] = leftP[leftI++];
            }
            else
            {
                polls[pollsI++] = rightP[rightI++];
            }
        }

        while (leftI < leftP.Length)
        {
            polls[pollsI++] = leftP[leftI++];
        }

        while (rightI < rightP.Length)
        {
            polls[pollsI++] = rightP[rightI++];
        }
    }
}

[Serializable]
[ProtoContract]
public class Man : RadioPoll
{
    public Man() { }
    public Man(string answer, int count) : base(answer, count)
    {

    }
}

[Serializable]
[ProtoContract]
public class Opening : RadioPoll
{
    public Opening() { }
    public Opening(string answer, int count) : base(answer, count)
    {

    }
}

class Program
{
    static void Main()
    {
        Man[] mans = new Man[]
        {
            new Man("Эльон Маск", 10),
            new Man("Грета Тунберг", 90),
            new Man("Владимир Путин", 110),
            new Man("Джо Байден", 70),
            new Man("Анджелина Джоли", 60),
        };

        Opening[] openings = new Opening[]
        {
            new Opening("The sunken ship Endurance", 70),
            new Opening("Artificial intelligence", 90),
            new Opening("Brain Decoder", 110),
            new Opening("The Ancient Whale", 50),
            new Opening("Living robot", 10),
        };

        RadioPoll.MergeSort(mans);
        RadioPoll.MergeSort(openings);

        Console.WriteLine("Топ-5 человек года по результатам опроса:");
        foreach (var man in mans)
        {
            man.Print();
        }

        Console.WriteLine();

        Console.WriteLine("Топ-5 открытий года по результатам опроса:");
        foreach (var opening in openings)
        {
            opening.Print();
        }

        List<RadioPoll> radioPollList = new();
        radioPollList.AddRange(mans);
        radioPollList.AddRange(openings);


        Stream file = File.Create(@"data\radioPoll.json");
        Stream data = JSONProcessing<RadioPoll>.Write(radioPollList);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\radioPoll.xml");
        data = XMLProcessing<RadioPoll>.Write(radioPollList);
        data.CopyTo(file);
        file.Dispose();

        file = File.Create(@"data\radioPoll.bin");
        data = BinProcessing<RadioPoll>.Write(radioPollList);
        data.CopyTo(file);
        file.Dispose();

        radioPollList = JSONProcessing<RadioPoll>.Read(new FileStream(@"data\radioPoll.json", FileMode.Open));
        Console.WriteLine("JSON файл:");
        for (int i = 0; i < radioPollList.Count; i++)
        {
            radioPollList[i].Print();
        }

        radioPollList = XMLProcessing<RadioPoll>.Read(new FileStream(@"data\radioPoll.xml", FileMode.Open));
        Console.WriteLine("XML файл:");
        for (int i = 0; i < radioPollList.Count; i++)
        {
            radioPollList[i].Print();
        }

        radioPollList = BinProcessing<RadioPoll>.Read(new FileStream(@"data\radioPoll.bin", FileMode.Open));
        Console.WriteLine("Bin файл:");
        for (int i = 0; i < radioPollList.Count; i++)
        {
            radioPollList[i].Print();
        }
    }
}