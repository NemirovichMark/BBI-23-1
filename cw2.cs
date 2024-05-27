using System;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

#region 1

abstract class Task
{
    protected string text = "Hello students ;)";

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
        return text;
    }
}

class program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();
        string[] words = inputText.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = words.OrderByDescending(w => w.Length).First();

        Console.WriteLine($"Самое длинное слово в тексте: {longestWord}");
    }
}
#endregion

#region 2
class Program
{
    static void Main()
    {
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string controlWorkPath = Path.Combine(documentsPath, "Control work");

        if (!Directory.Exists(controlWorkPath))
        {
            Directory.CreateDirectory(controlWorkPath);

            string cw2_1FilePath = Path.Combine(controlWorkPath, "cw2_1.json");
            string cw2_2FilePath = Path.Combine(controlWorkPath, "cw2_2.json");

            if (!File.Exists(cw2_1FilePath))
            {
                File.Create(cw2_1FilePath).Close();
            }

            if (!File.Exists(cw2_2FilePath))
            {
                File.Create(cw2_2FilePath).Close();
            }

            Console.WriteLine("Папка и файлы успешно созданы.");
        }
        else
        {
            Console.WriteLine("Папка 'Control work' уже существует.");
        }
    }
}
#endregion
