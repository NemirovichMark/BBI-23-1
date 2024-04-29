using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

abstract class Task
{
    private string _text;
    public Task(string text) { _text = text; }
    public virtual string ToString()
    {
        return _text;
    }
}


class Task_2 : Task
{
    private string _text;
    public Task_2(string t) : base(t) { _text = t; }
    public override string ToString()
    {
       
    }

    private string Encrypt()
    {
        string[] words = _text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();
            Array.Reverse(chars);
            words[i] = new string(chars);
        }

        return string.Join(" ", words);
    }

    private string Decrypt()
    {
        string[] words = _text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();
            Array.Reverse(chars);
            words[i] = new string(chars);
        }

        return string.Join(" ", words);
    }
}


class Task_4 : Task
{
    private string _text;
    public Task_4(string t) : base(t) { _text = t; }
    public override string ToString()
    {
        int complexity = CalculateComplexity(_text);
        return $"Сложность предложения: {complexity}";
    }
    private int CalculateComplexity(string text)
    {
        int wordCount = CountWords(text);
        int punctuationCount = CountPunctuation(text);
        return wordCount + punctuationCount;
    }

    private int CountWords(string text)
    {
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    private int CountPunctuation(string text)
    {
        int count = 0;
        foreach (char c in text)
        {
            if (char.IsPunctuation(c))
            {
                count++;
            }
        }
        return count;
    }
}


class Task_6 : Task
{
    private string _text;
    public Task_6(string t) : base(t) { _text = t; }
    public override string ToString()
    {
        Dictionary<int, int> syllableCount = CountSyllables(_text);

        StringBuilder result = new StringBuilder();
        foreach (var pair in syllableCount)
        {
            result.Append($"Слов с {pair.Key} слогами: {pair.Value}\n");
        }

        return result.ToString();
    }

    private Dictionary<int, int> CountSyllables(string text)
    {
        Dictionary<int, int> syllableCount = new Dictionary<int, int>();

        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            int syllables = CountSyllablesInWord(word);
            if (syllableCount.ContainsKey(syllables))
            {
                syllableCount[syllables]++;
            }
            else
            {
                syllableCount.Add(syllables, 1);
            }
        }

        return syllableCount;
    }

    private int CountSyllablesInWord(string word)
    {
        int vowels = Regex.Matches(word, "[aeiouyAEIOUY]+").Count;

        if (word.EndsWith("e", StringComparison.OrdinalIgnoreCase))
        {
            vowels--;
        }

        return vowels;
    }

}



class Task_8 : Task
{
    private string _text;
    public Task_8(string t) : base(t) { _text = t; }
    public override string ToString()
    {
        _text = ParseText(_text);
        return _text;
    }
    private string ParseText(string text)
    {
        int j = 0;
        while (j < text.Length - 50)
        {
            int i = j + 50;
            while (i > j && text[i] != ' ')
            {
                i--;
            }

            if (i == j)
            {
                i = j + 50;
            }
            text = text.Remove(i, 1);
            text = text.Insert(i, "\n");
            int d = 0;
            string text1 = text.Substring(j, i - j);
            while (text1.Length < 50)
            {
                for (int l = j; l < i; l++)
                {
                    if (text[l] == ' ')
                    {
                        text = text.Insert(l, " ");
                        l++;
                        d++;
                        text1 = text.Substring(j, i + d - j);
                        if (text1.Length >= 50) break;
                    }
                }
            }
            j = i + 1 + d;
        }

        return text;
    }
}


class Task_9 : Task
{
    private string _text;
    public Task_9(string t) : base(t) { _text = t; }
    public override string ToString()
    {
        Dictionary<string, int> letter = Create_Dictionary(_text);

        string[] keys = Sorting_Keys((Dictionary<string, int>)letter);

        char[] kode = Create_Code_Table(_text);

        Print_Code_Table(keys, kode);
        _text = ToReplace(_text, keys, kode);

        return _text;
    }
    private Dictionary<string, int> Create_Dictionary(string text)
    {
        Dictionary<string, int> letter = new Dictionary<string, int>();
        
        for (int i = 65; i < 91; i++)
        {
            for (int j = 65; j < 91; j++)
            {
                char first = char.ToLower((char)i);
                char second = char.ToLower((char)j);
                string key = first.ToString() + second.ToString();
                letter.Add(key, 0);
            }
        }
        
        for (int i = 1072; i < 1106; i++)
        {
            for (int j = 1072; j < 1106; j++)
            {
                char first = char.ToLower((char)i);
                char second = char.ToLower((char)j);
                string key = first.ToString() + second.ToString();
                letter.Add(key, 0);
            }
        }
        for (int i = 0; i < text.Length - 1; i++)
        {
            string two = text[i].ToString() + text[i + 1].ToString();
            if (letter.ContainsKey(two))
            {
                letter[two]++;
            }
        }
        return letter;
    }
    private string[] Sorting_Keys(Dictionary<string, int> letter)
    {
        string[] keys = new string[10];
        int max = 0;
        for (int j = 0; j < 10; j++)
        {
            max = 0;
            foreach (var i in letter)
            {
                bool est = true;
                if ((i.Value > max))
                {
                    for (int z = 0; z < j; z++)
                    {
                        if (i.Key == keys[z])
                        {
                            est = false;
                            break;
                        }
                    }
                    if (est)
                    {
                        max = i.Value;
                        keys[j] = i.Key;
                    }
                }
            }
        }
        return keys;
    }
    private char[] Create_Code_Table(string text)
    {
        char[] kode = new char[10];
        int k = 0;

        for (int i = 33; i < 125; i++)
        {
            bool pod = true;
            for (int j = 0; j < text.Length; j++)
            {
                if ((char)i == (char)text[j])
                {
                    pod = false;
                    break;
                }
            }
            if (pod)
            {
                kode[k] = (char)i;
                k++;
            }
            if (k == 10) break;
        }
        return kode;
    }
    private void Print_Code_Table(string[] keys, char[] kode)
    {

        Console.WriteLine("\n\nТаблица символов/кодов:");
        for (int j = 0; j < keys.Length; j++)
        {
            Console.Write("\t {0}", keys[j]);
        }
        Console.WriteLine();
        for (int j = 0; j < 10; j++)
        {
            Console.Write("\t {0}", kode[j]);
        }
    }
    private string ToReplace(string text, string[] keys, char[] kode)
    {
        int l = keys.Length;
        if (l > text.Length) l = text.Length;
        for (int j = 0; j < l; j++)
        {
            if (keys[j] != null)
            {
                text = text.Replace(char.ToUpper(keys[j][0]).ToString() + (keys[j][1]).ToString(), kode[j].ToString());
                text = text.Replace((keys[j][0]).ToString() + char.ToUpper(keys[j][1]).ToString(), kode[j].ToString());
                text = text.Replace(char.ToUpper(keys[j][0]).ToString() + char.ToUpper(keys[j][1]).ToString(), kode[j].ToString());
                text = text.Replace(keys[j], kode[j].ToString());
            }
        }
        return text;
    }

}


class Task_10 : Task
{
    private string _text;
    private string[] _code;
    public Task_10(string t, string[] code) : base(t)
    {
        _text = t;
        _code = code;
    }
    public override string ToString()
    {
        _text = ParseText(_text, _code);
        return _text;
    }
    private string ParseText(string text, string[] code)
    {
        for (int j = 0; j < code.Length; j = j + 2)
        {
            text = text.Replace(code[j], code[j + 1]);
        }
        return text;
    }
}



    public static void Main(string[] args)
    {

        //2 
        Console.WriteLine("Задание 2. Введите текст для шифрования:");
      string text = Console.ReadLine();

        var task2 = new Task_2(text);
      string encryptedText = task2.Encrypt();
        Console.WriteLine($"\nЗашифрованный текст: {encryptedText}");

      string decryptedText = task2.Decrypt();
        Console.WriteLine($"\nРасшифрованный текст: {decryptedText}");

        //8
       string[] code = new string[10];
        Console.WriteLine("Задание 8.Введите текст:");
        string text = Console.ReadLine();
        var task8 = new Task_8(text);
        text = task8.ToString();
        Console.Write("\n\n{0}", text);

        //9
        Console.WriteLine("\n\nЗадание 9.Введите текст:");
        text = Console.ReadLine();
        var task9 = new Task_9(text);
        text = task9.ToString();
        Console.Write("\nРезультат: \n{0}", text);

        //10
        Console.WriteLine("\n\nЗадание 10\nВведите закодированный текст");
        text = Console.ReadLine();
        var task10 = new Task_10(text, code);
        var inputt = new Program();
        code = inputt.Input_Code(code);
        text = task10.ToString();
        Console.Write("\nРезультат:\n{0}", text);

    }
}