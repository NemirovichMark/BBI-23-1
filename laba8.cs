using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

abstract class Task
{
    public string Text { get; set; }
    public Task(string text)
    {
        Text = text;
    }

    public abstract (string Text, Dictionary<string, string> tableCodes) ParseText();
}

class Task2 : Task
{
    public Task2(string text) : base(text) { }

    public string Encrypt(string text)
    {
        char[] punctuation = { '.', ',', '!', '?', ';', ':', '(', ')' };
        StringBuilder reversed = new StringBuilder();
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            int punctuationIndex = -1;

            foreach (char p in punctuation)
            {
                if (word.Contains(p))
                {
                    punctuationIndex = word.IndexOf(p);
                    break;
                }
            }

            if (punctuationIndex != -1)
            {
                string reversedWord = new string(word.Substring(0, punctuationIndex).ToCharArray().Reverse().ToArray());
                reversed.Append(reversedWord + word[punctuationIndex]);
            }
            else
            {
                string reversedWord = new string(word.ToCharArray().Reverse().ToArray());
                reversed.Append(reversedWord);
            }

            if (i < words.Length - 1)
            {
                reversed.Append(" ");
            }
        }

        return reversed.ToString();
    }

    public string Descrypt(string text2)
    {
        return Encrypt(text2);
    }

    public override (string Text, Dictionary<string, string> tableCodes) ParseText()
    {
        return (Text, null);
    }
}

class Task6 : Task
{
    public Task6(string inputText) : base(inputText) { }

    public void SetText(string inputText)
    {
        Text = inputText;
    }

    public string GetText()
    {
        return Text;
    }

    public void AnalyzeSyllables()
    {
        string[] words = Text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int[] syllableCount = new int[11];

        foreach (string word in words)
        {
            int count = Regex.Matches(word, "[аеёиоуыэюя]+", RegexOptions.IgnoreCase).Count;
            if (count <= 10)
            {
                syllableCount[count]++;
            }
            else
            {
                syllableCount[10]++;
            }
        }

        for (int i = 1; i < syllableCount.Length; i++)
        {
            Console.WriteLine($"Слов с {i} слогом: {syllableCount[i]}");
        }
    }

    public override (string Text, Dictionary<string, string> tableCodes) ParseText()
    {
        return (Text, null);
    }
}

class Task8 : Task
{
    public List<string> lines = new List<string>();

    public Task8(string text) : base(text)
    {
        ParseText();
    }

    public override (string Text, Dictionary<string, string> tableCodes) ParseText()
    {
        string[] words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string line = "";
        int lineLength = 0;

        foreach (string word in words)
        {
            if (lineLength + word.Length > 50)
            {
                string[] spacedWords = line.Trim().Split(' ');
                int vseProbeli = 50 - line.Replace(" ", "").Length;
                int ProbeliSlov = vseProbeli / (spacedWords.Length - 1);
                int dopProbeli = vseProbeli % (spacedWords.Length - 1);
                line = "";
                for (int i = 0; i < spacedWords.Length - 1; i++)
                {
                    line += spacedWords[i] + new string(' ', ProbeliSlov + (i < dopProbeli ? 1 : 0));
                }
                line += spacedWords[spacedWords.Length - 1];
                lines.Add(line);
                line = "";
                lineLength = 0;
            }
            line += word + " ";
            lineLength += word.Length + 1;
        }
        if (!string.IsNullOrEmpty(line))
        {
            lines.Add(line.Trim());
        }
        return (null, null);
    }
}

class Task9 : Task
{
    public Task9(string text) : base(text) { }

    public override (string Text, Dictionary<string, string> tableCodes) ParseText()
    {
        string _text = Text.Replace(" ", "");

        Dictionary<string, string> tableCodes = new Dictionary<string, string>();
        int countOfPar = 5;
        int counter = 0;
        HashSet<string> letters = new HashSet<string>
        {
            "`", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=",
            "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "[", "]",
            "A", "S", "D", "F", "G", "H", "J", "K", "L", ";", "'",
            "Z", "X", "C", "V", "B", "N", "M", ",", ".", "/",
            "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+",
            "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "{", "}",
            "a", "s", "d", "f", "g", "h", "j", "k", "l", ":", "\"",
            "z", "x", "c", "v", "b", "n", "m", "<", ">", "?",
            "ё", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=",
            "й", "ц", "у", "к", "е", "н", "г", "ш", "щ", "з", "х", "ъ",
            "ф", "ы", "в", "а", "п", "р", "о", "л", "д", "ж", "э",
            "я", "ч", "с", "м", "и", "т", "ь", "б", "ю", ".",
            "!", "\"", "№", ";", "%", ":", "?", "*", "(", ")", "_", "+",
            "Ё", "!", "\"", "№", ";", "%", ":", "?", "*", "(", ")", "_", "+",
            "Й", "Ц", "У", "К", "Е", "Н", "Г", "Ш", "Щ", "З", "Х", "Ъ",
            "Ф", "Ы", "В", "А", "П", "Р", "О", "Л", "Д", "Ж", "Э",
            "Я", "Ч", "С", "М", "И", "Т", "Ь", "Б", "Ю", ","
        };

        HashSet<string> _tmp = new HashSet<string>(letters);
        foreach (string s in _tmp)
        {
            if (_text.IndexOf(s) != -1)
                letters.Remove(s);
        }

        Dictionary<string, int> meetings = new Dictionary<string, int>();
        for (int i = 0; i < _text.Length - 1; i++)
        {
            string key = _text.Substring(i, 2);
            if (!meetings.ContainsKey(key))
                meetings[key] = 0;
            meetings[key] = meetings[key] + 1;
        }

        var sortedMeetings = meetings.OrderBy(pair => pair.Value).Reverse();
        foreach (var pair in sortedMeetings)
        {
            if (counter >= countOfPar)
                break;
            Text = Text.Replace(pair.Key, letters.ElementAtOrDefault(counter));
            tableCodes[pair.Key] = letters.ElementAtOrDefault(counter);
            counter++;
        }

        foreach (var pair in tableCodes)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
        return (Text, tableCodes);
    }
}

class Program
{
    static void Main()
    {
        string text = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории. Высокопревосходительство (для 6)";
        int maxLength = 50;

        Task2 task2 = new Task2(text);
        Console.WriteLine("Задание 2");
        Console.WriteLine("\tТекст: ");
        Console.WriteLine(text);

        Console.WriteLine("\n\tТекст зашифрован:");
        Console.WriteLine(task2.Encrypt(text));

        Console.WriteLine("\n\tТекст расшифрован:");
        Console.WriteLine(task2.Descrypt(task2.Encrypt(text)));

        Task6 task6 = new Task6(text);
        Console.WriteLine("Задание 6");
        Console.WriteLine("\n\t Анализ слогов:");
        task6.AnalyzeSyllables();

        Task8 task8 = new Task8(text);
        Console.WriteLine("Задание 8");
        Console.WriteLine("\n\t Текст разбит по строкам:");
        foreach (var line in task8.lines)
        {
            Console.WriteLine(line);
        }

        Task9 task9 = new Task9(text);
        Console.WriteLine("Задание 9");
        Console.WriteLine("\n\t Таблица кодов:");
        var result = task9.ParseText();
        Console.WriteLine("\n\t Зашифрованный текст:");
        Console.WriteLine(result.Text);
     
        
    }
}

