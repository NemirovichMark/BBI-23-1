using System;
using System.IO;

abstract class Task
{
    protected string text = "апро апрол внро ычпрнгош арп"; 
    public string Text
    {
        get => text;
        protected set => text = value;
    }
    public Task(string text)
    {
        this.text = text;
    }
}
class Task1 : Task
{
    [JsonConstructor]
    public Task1(string text) : base(text) { }
    static int CountShortWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string word in words)
        {
            if (word.Length == 1 && (word == "и" || word == "а" || word == "но" || word == "в" || word == "с" || word == "к" || word == "у" || word == "о" || word == "или" || word == "а" || word == "но"))
            {
                count++;
            }
        }

        return count;
    }
    public override string ToString()
    {
        return text;
    }
}
class Task2 : Task
{
    private int amount = 1;
    public int Amount
    {
        get => amount;
        private set => amount = value;
    }
    [JsonConstructor]
    public Task2(string text, int amount = 0) : base(text)
    {
        this.amount = amount;
    }
    static bool CheckBrackets(string input)
    {
        int countRound = 0;
        int countSquare = 0;
        int countCurly = 0;

        foreach (char c in input)
        {
            if (c == '(')
                countRound++;
            else if (c == ')')
                countRound--;
            else if (c == '[')
                countSquare++;
            else if (c == ']')
                countSquare--;
            else if (c == '{')
                countCurly++;
            else if (c == '}')
                countCurly--;

            if (countRound < 0 || countSquare < 0 || countCurly < 0)
                return false;
        }

        return countRound == 0 && countSquare == 0 && countCurly == 0;
    }
    public override string ToString()
    {
        return amount.ToString();
    }
}
class JsonIO
{
    public static void Write<T>(T obj, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, obj);
        }
    }
    public static T Read<T>(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<T>(fs);
        }
        return default(T);
    }

    public static void Write1(Task1 obj, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, obj);
        }
    }
    public static Task1 Read1(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<Task1>(fs);
        }
        return null;
    }
    public static void Write2(Task2 obj, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, obj);
        }
    }
    public static Task2 Read2(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<Task2>(fs);
        }
        return null;
    }
}
class Program
{
    static void Main()
    {
        Task[] tasks = {
            new Task1("dsehs ygthygjy"),      
            new Task2("rtfhjuk yhj")    
        };
        Console.WriteLine(tasks[0]);
        Console.WriteLine(tasks[1]);

        string path = @"C:\Users\m2302499\Downloads";
        string NameOfFolder = "Test";
        path = Path.Combine(path, NameOfFolder);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        string fileName1 = "cw1_json.json";
        string fileName2 = "cw_2json.json";

        fileName1 = Path.Combine(path, fileName1);
        fileName2 = Path.Combine(path, fileName2);
    }
}