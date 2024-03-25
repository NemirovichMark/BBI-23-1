using System;
using System.Collections.Generic;
using System.Xml.Linq;

struct Radio
{
    private string _answer;
    private int _count;
    public string Answer => _answer;
    public int Count => _count;
    public Radio(string answer, int count) 
    {
        _answer = answer;
        _count = count;
    }
}

class Program
{
    static void Main()
    {
        Radio[] responses = new Radio[5];

        responses[0] = new Radio("Егор Крид", 120);
        responses[1] = new Radio("Филипп Киркоров", 70);
        responses[2] = new Radio("Тимати", 90);
        responses[3] = new Radio("Владимир Путин", 150);
        responses[4] = new Radio("Кайли Дженнер", 60);

        int totalVotes = 0;

        foreach (var response in responses)
        {
            totalVotes += response.Count;
        }

        Array.Sort(responses, (x, y) => y.Count.CompareTo(x.Count));

        Console.WriteLine("Топ-5 человек года по результатам опроса:  ");

        foreach (var response in responses)
        {
            double percentage = (double)response.Count / totalVotes * 100;
            Console.WriteLine($" {response.Answer} - {percentage:f2}% от общего количества ответов");
        }
    }
}

