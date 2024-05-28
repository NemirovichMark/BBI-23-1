using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

class Task4 : Task
{
    public Task4(string text) : base(text) { }

    public int HardText(string text4)
    {
        int hardText = 0;
        string[] words = text4.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            foreach (char c in word)
            {
                if (char.IsPunctuation(c))
                {
                    hardText++;
                }
            }
        }

        int punctuationCount = 0;
        foreach (char c in text4)
        {
            if (char.IsPunctuation(c))
            {
                punctuationCount++;
            }
        }
        int wordCount = words.Length;

        return wordCount + punctuationCount;
    }

    public override (string Text, Dictionary<string, string> tableCodes) ParseText()
    {
        int complexity = HardText(Text);
        return ($"Сложность текста: {complexity}", null);
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

internal class Task_9 : Task
{
    private Dictionary<string, string> symbols;
    public string newtext;

    public Task_9(string text) : base(text)
    {
        symbols = new Dictionary<string, string>();
    }

    public override string ToString()
    {
        return newtext;
    }

    public override (string Text, Dictionary<string, string> tableCodes) ParseText()
    {
        var pairs = new Dictionary<string, int>();
        for (int i = 0; i < Text.Length - 1; i++)
        {
            if (char.IsLetter(Text[i]) && char.IsLetter(Text[i + 1]))
            {
                var sequence = Text.Substring(i, 2);
                if (!pairs.ContainsKey(sequence))
                {
                    pairs[sequence] = 0;
                }
                pairs[sequence]++;
            }
        }

        var topSequences = new List<KeyValuePair<string, int>>();
        foreach (var pair in pairs)
        {
            if (topSequences.Count < 5)
            {
                topSequences.Add(pair);
            }
            else
            {
                for (int i = 0; i < topSequences.Count; i++)
                {
                    if (pair.Value > topSequences[i].Value)
                    {
                        topSequences[i] = pair;
                        break;
                    }
                }
            }
        }

        topSequences.Sort((x, y) => y.Value.CompareTo(x.Value));
        char code = '[';
        foreach (var sequence in topSequences)
        {
            symbols[sequence.Key] = code.ToString();
            Text = Text.Replace(sequence.Key, code.ToString());
            code++;
        }
        newtext = Text;
        return (newtext, symbols);
    }

    public void DisplayCodesTable()
    {
        Console.WriteLine("Таблица кодов:");
        foreach (var codePair in symbols)
        {
            Console.WriteLine($"Пара букв: {codePair.Key} - Знак шифра: {codePair.Value}");
        }
    }
}

internal class Task_10 : Task
{
    private Dictionary<string, string> symbols;
    private string firsttext;

    public Task_10(string text) : base(text)
    {
        symbols = new Dictionary<string, string>();
        firsttext = text;
    }

    public override string ToString()
    {
        return firsttext;
    }

    public override (string Text, Dictionary<string, string> tableCodes) ParseText()
    {
        return (null, null);
    }

    public void ParseText(Dictionary<string, string> tableCodes)
    {
        foreach (var codePair in tableCodes)
        {
            firsttext = firsttext.Replace(codePair.Value, codePair.Key);
        }
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

        Task4 task4 = new Task4(text);
        Console.WriteLine("Задание 4");
        Console.WriteLine("\n \tСложность текста");
        Console.WriteLine(task4.HardText(text));

        Task6 task6 = new Task6(text);
        Console.WriteLine("Задание 6");
        Console.WriteLine("\n\tАнализ слогов:");
        task6.AnalyzeSyllables();

        Task8 task8 = new Task8(text);
        Console.WriteLine("Задание 8");
        Console.WriteLine("\n\tТекст разбит по строкам:");
        foreach (var line in task8.lines)
        {
            Console.WriteLine(line);
        }

        Task_9 task9 = new Task_9(text);
        task9.ParseText();
        Console.WriteLine("Задание 9");
        Console.WriteLine("\n\tЗашифрованное сообщение:");
        Console.WriteLine(task9.ToString());
        Console.WriteLine();
        task9.DisplayCodesTable();

        Task_10 task10 = new Task_10(text);
        task10.ParseText(task9.ParseText().tableCodes);
        Console.WriteLine("\n\nЗадание 10");
        Console.WriteLine("\n\tДекодированное сообщение:");
        Console.WriteLine(task10.ToString());

        Console.ReadKey();
    }
}
