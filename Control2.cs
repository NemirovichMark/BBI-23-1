using System.Text.Json;
using System.Text.Json.Serialization;
abstract class Task
{
    protected string text = "No text";
    public string Text
    {
        get => text;
        protected set => text = value;
    }
    [JsonConstructor]
    public Task()
    {

    }
}
class Task1 : Task
{
    [JsonConstructor]
    public Task1(string text) { this.text = text; }
    public override string ToString()
    {
        string[] s = text.Split(' ');
        char[] g = { 'у', 'е', 'ё', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю' };
        int sum = 0;
        foreach (string c in s)
        {
            bool f = true;
            foreach (char e in c)
            {
                if (char.IsLetter(e))
                {
                    for (int i = 0; i < g.Length; i++)
                    {
                        if (g[i] == e) { f = false; break; }
                    }
                }
                else { f = false; break; }
                if (!f) { break; }
            }
            if (f) { sum++; }
        }
        return sum.ToString();
    }
}
class Task2 : Task
{
    [JsonConstructor]
    public Task2(string text) { this.text = text; }
    public override string ToString()
    {
        List<char> k = new List<char>();
        List<char> g = new List<char>();
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                bool f = true;
                foreach(char e in k)
                {
                    if (e == c) { f = false; break; }
                }
                if (f) { k.Add(c); }
            }
            else if (c != ' ')
            {
                bool f = true;
                foreach (char e in g)
                {
                    if (e == c) { f = false; break; }
                }
                if (f) { g.Add(c); }
            }
        }
        return ((float)k.Count / (float)g.Count).ToString();
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
}

    class Control2
    {
        static void Main()
        {
            string text = "абв 123 в";
            Task[] tasks = { new Task1(text), new Task2(text)};
            Console.WriteLine(tasks[0]);
            Console.WriteLine(tasks[1]);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = "Test";
            path = Path.Combine(path, folderName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName1 = "cw2_1.json";
            string fileName2 = "cw2_2.json";

            fileName1 = Path.Combine(path, fileName1);
            fileName2 = Path.Combine(path, fileName2);

            if (!File.Exists(fileName1))
            {
                JsonIO.Write<Task1>(tasks[0] as Task1, fileName1);
                JsonIO.Write<Task2>(tasks[1] as Task2, fileName2);
            }
            else
            {
                var t1 = JsonIO.Read<Task1>(fileName1);
                var t2 = JsonIO.Read<Task2>(fileName2);
                Console.WriteLine(t1);
                Console.WriteLine(t2);
            }
        }
    }