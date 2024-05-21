// На вход подается строка. На выход целое число. Входной текст представлен одним словом. Определить сколько различных букв в нем.
//На вход подается строка. На выход - массив строк. Вывести все слова, которые состоят из разных букв (длина слов должна быть более 1 символа) построчно.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

abstract class Task
{
    protected string text = "";
    public string Text
    {
        get => text;
        protected set => text = value;
    }

    public virtual void ParseText() { }
    public Task(string text)
    {
        this.text = text;
    }
}

class Task1 : Task
{
    public Task1(string text) : base(text)
    {
    }

    public override void ParseText()
    {
        HashSet<char> uniqueLetters = new HashSet<char>();

        foreach (char c in Text)
        {
            if (char.IsLetter(c))
            {
                uniqueLetters.Add(char.ToLower(c));
            }
        }

        Console.WriteLine($"Количество различных букв в слове: {uniqueLetters.Count}");
    }
    public override string ToString()
    {
        ParseText();
        return text.ToString();
    }
}

class Task2 : Task
{
    public Task2(string text) : base(text)
    {
    }
    public override void ParseText()
    {
        string[] words = Text.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (word.Length > 1 && word.Distinct().Count() == word.Length)
            {
                Console.WriteLine($"Слова, которые состоят из разных букв: {word}");
            }
        }
    }
    public override string ToString()
    {
        ParseText();
        return text.ToString();
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
    }
}
class Program
{
    static void Main()
    {
        Task[] tasks = {
            new Task1("Организованность"),            new Task2("Названо по имени Р. Броуна, который открыл явление в 1827 году.")
        }; Console.WriteLine(tasks[0]);
        Console.WriteLine(tasks[1]);

        string path = @"C:\Users\m2302394\Desktop";
        string folderName = "Solution";
        path = Path.Combine(path, folderName);

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        string fileName1 = "task_1.json";
        string fileName2 = "task_2.json";

        fileName1 = Path.Combine(path, fileName1);
        fileName2 = Path.Combine(path, fileName2);

        if (!File.Exists(fileName1))
        {
            JsonIO.Write<Task1>(tasks[0] as Task1, fileName1);
        }
        else
        {
            var t1 = JsonIO.Read<Task1>(fileName1);
            Console.WriteLine($"Количество различных букв: {t1}");
        }

        if (!File.Exists(fileName2))
        {
            JsonIO.Write<Task2>(tasks[1] as Task2, fileName2);
        }
        else
        {
            var t2 = JsonIO.Read<Task2>(fileName2);
            Console.WriteLine($"{t2}");
        }
    }
}

