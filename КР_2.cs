using System;
using System.IO;
using System.Text.Json;

struct Task
{
    public string LongestWord;

    public void PrintTask1()
    {
        Console.WriteLine("Длинейшее слово: " + this.LongestWord);
    }

    // Метод для задания 1
    public static Task ExecuteTask1(string text)
    {
        Task task = new Task();
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);

        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length || (word.Length == longestWord.Length && string.Compare(word, longestWord) < 0))
            {
                longestWord = word;
            }
        }
        task.LongestWord = longestWord;

        return task;
    }
}

struct Task2
{
    public string[] LastWords;

    public void PrintTask2()
    {
        foreach (var word in this.LastWords)
        {
            Console.WriteLine(word);
        }
    }

    // Метод для задания 2
    public static Task2 ExecuteTask2(string text)
    {
        Task2 task2 = new Task2();
        string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        task2.LastWords = new string[sentences.Length];

        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            task2.LastWords[i] = words[words.Length - 1];
        }

        return task2;
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
        string text = "Как же сложно понимать это программирование, но ничего, надеюсь получится закрыть!";
        Task[] tasks = {
            new Task1(text),
            new Task2(text)
        };

        foreach (var task in tasks)
        {
            task.Resh();
        }

        string path = @"C:\Users\m2313933";
        string folderName = "Fourth Task";
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