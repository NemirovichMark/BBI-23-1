using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        string[] words = text.Split(new char[] { ' ', '\n', '\t', '\r', ',', '.', '!', '?' });

        string word1 = words[0].ToLower();
        string word2 = words[1].ToLower();

        int k = 0;
        char[] index = new char[words[0].Length];
        for (int i = 0; i < word1.Length; i++)
        {
            bool found = true;
            for (int j = 0; j < word2.Length; j++)
            {
                if (word1[i] == word2[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                index[k] = words[0][i];
                k++;
            }
        }

        string result = "";

        for (int i = 0; i < index.Length; i++)
        {
                result += index[i];
        }

        result += " " + words[1];

        return result;
    }
}
    class Task2 : Task
{
    [JsonConstructor]
    public Task2(string text) : base(text) { }
    public override string ToString()
    {
        string[] words = text.Split(new char[] { ' ', '\n', '\t', '\r', ',', '.', '!', '?' });
        for (int i = 0; i < words.Length; i++)
        {
            char[] wordChars = new char[words[i].Length];
            int index = 0;
            for (int j = words[i].Length-1; j >= 0; j--)
            {
                if (!char.IsLetter(words[i][j]))
                {
                    wordChars[j] = words[i][j]; 
                }
                else
                {
                    while (index < words[i].Length && !char.IsLetter(words[i][index]))
                    {
                        index++; 
                    }
                    wordChars[index] = words[i][j]; 
                    index++;
                }
            }
            words[i] = new string(wordChars);
        }
        return string.Join(" ", words);
    }
}
class Json
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
}
class Program
{
    static void Main()
    {
        string text = "GaMEe4 gAli 4";
        Task[] tasks = { new Task1(text), new Task2(text) };
        Console.WriteLine(tasks[0]);
        Console.WriteLine(tasks[1]);
        string path = @"C:\Users\m2306908\Documents";
        string folderName = "Answer";
        path = Path.Combine(path, folderName);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        string First = "cw2_1.json";
        string Second = "cw2_2.json";
        Console.Write("\n\tJson:\n");
        First = Path.Combine(path, First);
        Second = Path.Combine(path, Second);

        if (!File.Exists(First))
        {
            Json.Write<Task1>((Task1)tasks[0], First);
           Json.Write<Task2>((Task2)tasks[1], Second);
        }
        else
        {
            var first = Json.Read<Task1>(First);
            var second = Json.Read<Task2>(Second);
            Console.WriteLine(first);
           Console.WriteLine(second);
        }
    }
}