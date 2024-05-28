using System;
using System.Collections.Generic;
using System.Text;

abstract class Task
{
    public string Text { get; set; }

    public Task(string text)
    {
        Text = text;
    }

    public abstract List<string> ParseText();
}

class Task8 : Task
{
    public List<string> lines = new List<string>();

    public Task8(string text) : base(text)
    {
        ParseText();
    }

    public override List<string> ParseText()
    {
        string[] words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            lines.Add(word.PadLeft(50));
        }
        return lines;
    }
}

class Program
{
    static void Main()
    {
        string text = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории. Высокопревосходительство";

        Task8 task8 = new Task8(text);
        Console.WriteLine("Задание 8");
        Console.WriteLine("\n\tКаждое слово с новой строки :D :");
        foreach (var line in task8.lines)
        {
            Console.WriteLine(line);
        }
    }
}
