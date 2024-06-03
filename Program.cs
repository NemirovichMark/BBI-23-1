using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

abstract class Task
{
    public string Text { get; set; }

    public Task(string text)
    {
        Text = text;
    }

    public abstract void Execute();
    public abstract override string ToString();
}

class Task1 : Task
{
    private double[] letterFrequencies;
    private char[] letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();

    public Task1(string text) : base(text) { }

    public override void Execute()
    {
        letterFrequencies = new double[letters.Length];
        string filteredText = new string(Text.ToLower().Where(c => letters.Contains(c)).ToArray());
        int totalLetters = filteredText.Length;

        foreach (char c in filteredText)
        {
            int index = Array.IndexOf(letters, c);
            if (index != -1)
            {
                letterFrequencies[index]++;
            }
        }

        for (int i = 0; i < letterFrequencies.Length; i++)
        {
            letterFrequencies[i] /= totalLetters;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < letters.Length; i++)
        {
            if (letterFrequencies[i] > 0)
            {
                sb.AppendLine($"{letters[i]}: {letterFrequencies[i]:F4}");
            }
        }
        return sb.ToString();
    }
}

class Task3 : Task
{
    private List<string> lines;
    private const int maxLength = 50;

    public Task3(string text) : base(text) { }

    public override void Execute()
    {
        lines = new List<string>();
        string[] words = Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder currentLine = new StringBuilder();

        foreach (string word in words)
        {
            if (currentLine.Length + word.Length + 1 > maxLength)
            {
                lines.Add(currentLine.ToString());
                currentLine.Clear();
            }
            if (currentLine.Length > 0)
            {
                currentLine.Append(' ');
            }
            currentLine.Append(word);
        }

        if (currentLine.Length > 0)
        {
            lines.Add(currentLine.ToString());
        }
    }

    public override string ToString()
    {
        return string.Join("\n", lines);
    }
}

class Task5 : Task
{
    private List<(char, int)> letterCounts;

    public Task5(string text) : base(text) { }

    public override void Execute()
    {
        letterCounts = new List<(char, int)>();
        string[] words = Text.Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '-', '—' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            char firstLetter = char.ToLower(word[0]);
            if (char.IsLetter(firstLetter))
            {
                if (!letterCounts.Any(l => l.Item1 == firstLetter))
                {
                    letterCounts.Add((firstLetter, 0));
                }
                int index = letterCounts.FindIndex(l => l.Item1 == firstLetter);
                letterCounts[index] = (firstLetter, letterCounts[index].Item2 + 1);
            }
        }

        letterCounts.Sort((x, y) => y.Item2.CompareTo(x.Item2));
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var (letter, count) in letterCounts)
        {
            sb.AppendLine($"{letter}: {count}");
        }
        return sb.ToString();
    }
}

class Task7 : Task
{
    private string sequence;
    private List<string> matchingWords;

    public Task7(string text, string sequence) : base(text)
    {
        this.sequence = sequence;
    }

    public override void Execute()
    {
        matchingWords = new List<string>();
        string[] words = Text.Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '-', '—' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (word.Contains(sequence))
            {
                matchingWords.Add(word);
            }
        }
    }

    public override string ToString()
    {
        return string.Join(", ", matchingWords);
    }
}

class Task11 : Task
{
    private string[] names;
    private string[] sortedNames;

    public Task11(string text) : base(text)
    {
        names = text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToArray();
    }

    public override void Execute()
    {
        sortedNames = names.OrderBy(n => n).ToArray();
    }

    public override string ToString()
    {
        return string.Join(", ", sortedNames);
    }
}

class Task14 : Task
{
    private int sum;

    public Task14(string text) : base(text) { }

    public override void Execute()
    {
        sum = 0;
        string[] words = Text.Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '-', '—' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (int.TryParse(word, out int number) && number >= 1 && number <= 10)
            {
                sum += number;
            }
        }
    }

    public override string ToString()
    {
        return $"Сумма чисел: {sum}";
    }
}

class Program
{
    static void Main()
    {
        Task[] tasks = new Task[]
        {
            new Task1("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов."),
            new Task3("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений."),
            new Task5("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна."),
            new Task7("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.", "двиг"),
            new Task11("Иванов, Петров, Смирнов, Соколов, Кузнецов, Попов, Лебедев, Волков, Козлов, Новиков, Иванова, Петрова, Смирнова, Ivanov, Petrov, Smirnov, Sokolov, Kuznetsov, Popov, Lebedev, Volkov, Kozlov, Novikov, Ivanova, Petrova, Smirnova"),
            new Task14("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны ")
        };

        foreach (var task in tasks)
        {
            task.Execute();
            Console.WriteLine(task.ToString());
        }

        Console.ReadKey();
    }
}
