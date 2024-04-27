using System;
using System.Text.RegularExpressions;
using System.Text;

abstract class Task
{
    public abstract string Process(string input);
}

class EncryptionTask : Task
{
    public override string Process(string input)
    {
        string[] words = input.Split(' ');
        System.Text.StringBuilder encryptedMessage = new System.Text.StringBuilder();

        foreach (string word in words)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            encryptedMessage.Append(chars);
            encryptedMessage.Append(" ");
        }

        return encryptedMessage.ToString().Trim();
    }
}

class ComplexityTask : Task
{
    public override string Process(string input)
    {
        int wordCount = CountWords(input);
        int punctuationCount = CountPunctuation(input);
        int complexity = wordCount + punctuationCount;
        return $"Сложность предложения: {complexity}";
    }

    private int CountWords(string sentence)
    {
        System.Text.RegularExpressions.MatchCollection matches =
            System.Text.RegularExpressions.Regex.Matches(sentence, @"\b\w+\b");
        return matches.Count;
    }

    private int CountPunctuation(string sentence)
    {
        System.Text.RegularExpressions.MatchCollection matches =
            System.Text.RegularExpressions.Regex.Matches(sentence, @"[.,\/#!$%\^&\*;:{}=\-_`~()""']");
        return matches.Count;
    }
}

class SyllableCountTask : Task
{
    public override string Process(string input)
    {
        string pattern = @"[\p{L}-[\p{M}]]+";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        MatchCollection matches = regex.Matches(input);

        int[] syllableCounts = new int[10];

        foreach (Match match in matches)
        {
            string word = match.Value;
            int syllableCount = CountSyllables(word);
            if (syllableCount > 0 && syllableCount <= 9)
            {
                syllableCounts[syllableCount - 1]++;
            }
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < syllableCounts.Length; i++)
        {
            if (syllableCounts[i] > 0)
            {
                result.AppendLine($"Слов с {i + 1} слогом: {syllableCounts[i]}");
            }
        }

        return result.ToString();
    }

    private int CountSyllables(string word)
    {
        word = word.ToLower();
        int count = 0;
        bool isPrevVowel = false;

        foreach (char c in word)
        {
            if ("aeiouyаеёиоуыэюя".IndexOf(c) >= 0)
            {
                if (!isPrevVowel)
                {
                    count++;
                }
                isPrevVowel = true;
            }
            else
            {
                isPrevVowel = false;
            }
        }

        if (word.EndsWith("e") && count > 1)
        {
            count--;
        }

        return count;
    }
}

class FormatTextTask : Task
{
    public override string Process(string input)
    {
        int maxLineLength = 50;

        string[] words = input.Split(' ');
        StringBuilder outputText = new StringBuilder();

        int currentLineLength = 0;
        foreach (string word in words)
        {
            if (currentLineLength + word.Length + 1 > maxLineLength)
            {
                outputText.AppendLine();
                currentLineLength = 0;
            }

            outputText.Append(word);
            outputText.Append(' ');
            currentLineLength += word.Length + 1;
        }

        return outputText.ToString();
    }
}

class TextCompressionDecompressionTask : Task
{
    public override string Process(string input)
    {
        string text = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";

        Dictionary<string, char> codeTable = new Dictionary<string, char>();
        StringBuilder compressedText = new StringBuilder();
        StringBuilder decompressedText = new StringBuilder();

        char code = 'a';

        // Сжатие текста
        for (int i = 0; i < text.Length - 1; i++)
        {
            string sequence = text.Substring(i, 2);
            if (!codeTable.ContainsKey(sequence))
            {
                codeTable.Add(sequence, code);
                compressedText.Append(code);
                code++;
            }
            else
            {
                compressedText.Append(codeTable[sequence]);
            }
        }
        Console.WriteLine("Текст после сжатия: " + compressedText.ToString());

        Console.WriteLine("Таблица кодов:");
        foreach (var pair in codeTable)
        {
            Console.WriteLine(pair.Key + " -> " + pair.Value);
        }

        Console.WriteLine("\nВведите сжатый текст:");
        string inputCompressedText = compressedText.ToString(); // используем сжатый текст из первой программы
        Console.WriteLine(inputCompressedText);

        // Декодирование сжатого текста
        Dictionary<char, string> decodeTable = new Dictionary<char, string>();
        foreach (var pair in codeTable)
        {
            decodeTable.Add(pair.Value, pair.Key);
        }

        for (int i = 0; i < inputCompressedText.Length; i++)
        {
            char inputCode = inputCompressedText[i];
            if (decodeTable.ContainsKey(inputCode))
            {
                decompressedText.Append(decodeTable[inputCode]);
            }
            else
            {
                return $"Ошибка: код '{inputCode}' отсутствует в таблице кодов.";
            }
        }

        return "Текст после декодирования: " + decompressedText.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите задание: 1 - Шифрование сообщения(№2), 2 - Подсчёт сложности предложения(№4), 3 - Подсчет количества слогов(№6), 4 - Разделение текста на строки(№8), 5 - Кодирование текста(№9, №10)");
        int choice = int.Parse(Console.ReadLine());

        Task task;
        if (choice == 1)
        {
            task = new EncryptionTask();
            Console.WriteLine("Введите сообщение для шифрования:");
        }
        else if (choice == 2)
        {
            task = new ComplexityTask();
            Console.WriteLine("Введите предложение:");
        }
        else if (choice == 3)
        {
            task = new SyllableCountTask();
            Console.WriteLine("Введите предложение:");
        }
        else if (choice == 4)
        {
            task = new FormatTextTask();
            Console.WriteLine("Введите текст:");
        }
        else if (choice == 5)
        {
            task = new TextCompressionDecompressionTask();
        }
        else
        {
            Console.WriteLine("Выбрано недопустимое задание.");
            return;
        }

        string input = "";
        if (choice == 5)
        {
            input = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
        }

        else
        {
            input = Console.ReadLine();
        }
        string result = task.Process(input);
        Console.WriteLine($"Результат:");
        Console.WriteLine(result);
    }
}
