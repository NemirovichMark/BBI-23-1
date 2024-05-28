//Вариант 17
//Задание 1
#region 1
using System;
using System.IO;
using System.Text.Json;

namespace LongestWordTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Карл у Клары украл кораллы, а Клара у Карла украла кларнет";
            string[] words = input.Split(' ');
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
                else if (word.Length == longestWord.Length && word.CompareTo(longestWord) < 0)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine("Самое длинное слово: " + longestWord);

            string jsonOutput = JsonSerializer.Serialize(longestWord);

        }
    }
}
#endregion

//Задание 2
#region 2
using System;
using System.IO;
using System.Text.Json;
namespace LastWordsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "На вход подаётся строка. На выход - массив строк. Выписать последние слова всех предложений построчно.";
            string[] sentences = input.Split('.');
            string[] lastWords = new string[sentences.Length];
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Trim().Split(' ');
                lastWords[i] = words[words.Length - 1];
            }

            Console.WriteLine("Последние слова в предложениях:");
            foreach (string word in lastWords)
            {
                Console.WriteLine(word);
            }

            string jsonOutput = JsonSerializer.Serialize(lastWords);
        }
    }
}

#endregion

//Задание 3
#region 3


class Program
{
    static void Main()
    {
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string FourthTaskPath = Path.Combine(documentsPath, "Fourth Task");

        if (!Directory.Exists(FourthTaskPath))
        {
            Directory.CreateDirectory(FourthTaskPath);

            string string_1FilePath = Path.Combine(FourthTaskPath, "string_1.json");
            string string_2FilePath = Path.Combine(FourthTaskPath, "string_2.json");

            if (!File.Exists(string_1FilePath))
            {
                File.Create(string_1FilePath).Close();
            }

            if (!File.Exists(string_2FilePath))
            {
                File.Create(string_2FilePath).Close();
            }

            Console.WriteLine("Папка и файлы успешно созданы.");
        }
        else
        {
            Console.WriteLine("Папка 'Fourth Task' уже существует.");
        }
    }
}
#endregion
