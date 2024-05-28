using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading;
using System.ComponentModel;

public abstract class Task
{

    protected string _text = "No text here yet";
    public string Text
    {
        get => _text;
        protected set => _text = value;
    }
    [JsonConstructor]
    public Task(string text)
    {
        _text = text;
    }
}

public class Task1 : Task
{

    private int[] _data;
    public int[] Data
    {
        get => _data;
        private set => _data = value;
    }
    [JsonConstructor]
    public Task1(string text) : base(text)
    {
        _data = Count();
    }
    public int[] Count()
    {
        int[] data = new int[] { 0, 0, 0,0 };
        for (int i = 0; i < _text.Length; i++)
        {
            if (char.IsLetter(_text[i])) data[0]++;
            else if (char.IsDigit(_text[i])) data[1]++;
            else if (char.IsPunctuation(_text[i])) data[2]++;
            else if (char.IsWhiteSpace(_text[i])) data[3]++;
        }
        return data;
    }
    public override string ToString()
    {
        return $"{_data[0]}, {_data[1]}, {_data[2]}, {_data[3]}";
    }
}

public class Task2 : Task
{
    
    [JsonConstructor]
    public Task2(string text) : base(text)
    {
        
    }

    public override string ToString()
    {
        return Edit();
    }

    private string Edit()
    {
        string newText = "";
        for (int i = 0; i < _text.Length; i++)
        {
            if (_text[i] >= 'а' && _text[i] <= 'я')
            {
                if (_text[i] < 'о')
                {
                    int t = _text[i] - 'а';
                    newText += (char)('я' - 14 + t);
                }
                else newText += (char)(_text[i] - 15);
            }
            else if (_text[i] >= 'А' && _text[i] <= 'Я')
            {
                if (_text[i] < 'О')
                {
                    int t = _text[i] - 'А';
                    newText += (char)('Я' - 14 + t);
                }
                else newText += (char)(_text[i] - 15);
            }
            else newText += _text[i];
        }
        return newText;
    }
}
public class JsonIO
{
    public static void Write<T>(T obj, string FilePath)
    {
        using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, obj);
        }
    }
    public static T Read<T>(string FilePath)
    {
        using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<T>(fs);
        }
        return default(T);
    }
}
public class Program
{
    static void Main()
    {
        string text = "опрс , ? ! 124 - +=";
        Task[] tasks = new Task[] { new Task1(text), new Task2(text) };
        Console.WriteLine(tasks[0]);
        Console.WriteLine(tasks[1]);
        string file1 = "cw2_1.json";
        string file2 = "cw2_2.json";
        string path = "C:\\Users\\m2308909\\Downloads";
        string folder = "Test";
        path = Path.Combine(path, folder);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        file1 = Path.Combine(path, file1);
        file2 = Path.Combine(path, file2);
        if (!File.Exists(file1))
        {
            JsonIO.Write<Task1>((Task1)tasks[0], file1);
            JsonIO.Write<Task2>((Task2)tasks[1], file2);
            Console.WriteLine("Файлы успешно записаны");
        }
        else
        {
            Console.WriteLine("Десериализованные файлы:");
            var t1 = JsonIO.Read<Task1>(file1);
            var t2 = JsonIO.Read<Task2>(file2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
        Console.ReadKey();
    }
}
