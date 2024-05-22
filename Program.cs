using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

abstract class Task
{
    protected string text = "Здесь пока нет текста";

    public string Text
    {
        get => text;
        protected set => text = value;
    }

    public Task(string text)
    {
        this.text = text;
    }

    public abstract void Solve();

    public override string ToString()
    {
        return text;
    }
}

class Task1 : Task
{
    [JsonConstructor]
    public Task1(string text) : base(text) { }

    public override void Solve()
    {
        char[] charArray = text.ToCharArray();
        string result = new string(charArray.Where(c => charArray.Count(x => x == c) == 1).ToArray());

        Console.WriteLine(result);
    }
}

class Task2 : Task
{
    [JsonConstructor]
    public Task2(string text) : base(text) { }

    public override void Solve()
    {
        string[] sentences = text.Split('.', '!', '?');
        string reversedText = "";

        foreach (string sentence in sentences)
        {
            string[] words = sentence.Trim().Split(' ');
            Array.Reverse(words);
            reversedText += string.Join(" ", words) + ". ";
        }

        Console.WriteLine(reversedText.Trim());
    }
}

class Program
{
    static void Main()
    {
        string path = @"C:\Users\m2304881\Desktop\Зарузки";
        string folderName = "Answer";
        path = Path.Combine(path, folderName);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        string fileName1Input = "task1_input.json";
        string fileName1Output = "task1_output.json";
        string fileName2Input = "task2_input.json";
        string fileName2Output = "task2_output.json";

        fileName1Input = Path.Combine(path, fileName1Input);
        fileName1Output = Path.Combine(path, fileName1Output);
        fileName2Input = Path.Combine(path, fileName2Input);
        fileName2Output = Path.Combine(path, fileName2Output);

      
        Task task1 = new Task1("Привет мирррр");
        task1.Solve();

        var jsonTask1Input = JsonSerializer.Serialize(task1);
        File.WriteAllText(fileName1Input, jsonTask1Input);

        
        Task task2 = new Task2("Это предложение переверни его");
        task2.Solve();

        var jsonTask2Input = JsonSerializer.Serialize(task2);
        File.WriteAllText(fileName2Input, jsonTask2Input);

        
        var savedTask1 = JsonSerializer.Deserialize<Task1>(File.ReadAllText(fileName1Input));
        var savedTask2 = JsonSerializer.Deserialize<Task2>(File.ReadAllText(fileName2Input));

        Console.WriteLine(savedTask1);
        Console.WriteLine(savedTask2);
    }
}