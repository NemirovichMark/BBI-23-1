using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Collections.Generic;

abstract class Task
{
    protected string text;
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

    public override string ToString()
    {
        return $"{text}\n Удаленные буквы: {RemoveCommonLetters(text, "banana")}";
    }
    private static string RemoveCommonLetters(string word1, string word2)
    {
        var uniqueLetters = new HashSet<char>(word2);
        string result = new string(word1.Where(c => !uniqueLetters.Contains(c)).ToArray());
        return result;
    }
}

class Task2 : Task
{
    [JsonConstructor]
    public Task2(string text) : base(text) { }

    public override string ToString()
    {
        return $"{text}\n Найденные числа : {string.Join(", ", ExtractNumbersFromString(text))}";
    }
    private static List<double> ExtractNumbersFromString(string input)
    {
        string pattern = @"[-+]?\d+([.,]\d+)?";
        MatchCollection matches = Regex.Matches(input, pattern);

        List<double> numbers = new List<double>();

        foreach (Match match in matches)
        {
            double num;
            if (double.TryParse(match.Value.Replace(".", ","), out num))
            {
                numbers.Add(num);
            }
        }

        return numbers;
    }
}

class JsonHelper
{
    public static void Write<T>(T obj, string filePath)
    {
        string jsonString = JsonSerializer.Serialize(obj);
        File.WriteAllText(filePath, jsonString);
    }

    public static T Read<T>(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(jsonString);
    }
}

class Program
{
    static void Main()
    {
        string inputWord1 = "apple";
        string inputWord2 = "banana";
        string output = Task1.RemoveCommonLetters(inputWord1, inputWord2);
        Console.WriteLine($"Удаленные буквы: {output}");

        string inputText = "Пример текста с числами 123 и 45.6 и 7,89";

        List<double> extractedNumbers = Task2.ExtractNumbersFromString(inputText);

        foreach (double number in extractedNumbers)
        {
            Console.WriteLine(number);
        }

        string text = "A a B baa cscddsd";
        Task[] tasks = { new Task1(text), new Task2(text) };

        Console.WriteLine("\tВ самом приложении:");
        Console.WriteLine(tasks[0]);
        Console.WriteLine(tasks[1]);

        string path = @"C:\Users\m2306633\Downloads\Test";
        string name1 = "task_1.json";
        string name2 = "task_2.json";
        string filePath1 = Path.Combine(path, name1);
        string filePath2 = Path.Combine(path, name2);

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        if (!File.Exists(filePath1))
        {
            JsonHelper.Write((Task1)tasks[0], filePath1);
            JsonHelper.Write((Task2)tasks[1], filePath2);
        }
        else
        {
            var t1 = JsonHelper.Read<Task1>(filePath1);
            var t2 = JsonHelper.Read<Task2>(filePath2);
            Console.WriteLine("\n\tДесериализованные файлы:");
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}

