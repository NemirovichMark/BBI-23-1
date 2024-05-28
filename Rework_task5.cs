using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_reworktask5
{
    abstract class Task
    {
        protected string Text = "";

        public Task(string text)
        {
            Text = text;
        }
    }
    // сделать свою структуру с полями "Буква" и "Количество слов", и метод для увеличеня счетчика слов Использовать вместо словаря и KeyVAluePair вашу структуру с соблюдением ООП
    class Task_5 : Task
    {
        public Task_5(string text) : base(text) { Text = text; }
        public override string ToString()
        {
            var formattedStrings = LetterCounter(Text);
            return string.Join(", ", formattedStrings.Select(lc => $"{lc.Letter}: {lc.WordCounter}"));
        }
        public struct LetterCount
        {
            public char Letter;
            public int WordCounter;

            public static void Counter(LetterCount count) { count.WordCounter++; }
        }
        public IEnumerable<LetterCount> LetterCounter(string text)
        {
            text = text.ToLower();
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            char[] firstLetter = new char[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                firstLetter[i] = words[i][0];
            }
            Dictionary<char, LetterCount> firstLettersCount = new Dictionary<char, LetterCount>();

            foreach (char letter in firstLetter)
            {
                if (firstLettersCount.ContainsKey(letter))
                {
                    LetterCount existingCount = firstLettersCount[letter];
                    LetterCount updatedCount = new LetterCount { Letter = letter, WordCounter = existingCount.WordCounter + 1 };
                    LetterCount.Counter(updatedCount);
                    firstLettersCount[letter] = updatedCount;
                }
                else
                {
                    firstLettersCount.Add(letter, new LetterCount { Letter = letter, WordCounter = 1 });
                }
            }

            List<LetterCount> sortedList = firstLettersCount.Values.ToList();
            sortedList = sortedList.OrderByDescending(lc => lc.WordCounter).ThenBy(lc => lc.Letter).ToList();

            return sortedList;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 задание :");
            Task_5 task5 = new Task_5("Утром в низинах расстилался туман. Но вот из-за горизонта появляются солнце, и его лучи съедают серую пелену тумана.     Солнце поднимается выше и разбрасывает свои лучи по необъятным полям желтой пшеницы верхушкам далекого леса.     На расстоянии километра от леса замечаешь блестящую на солнце поверхность озера. В неё впадает извилистая речонка. Мы направляемся к ней.");
            Console.WriteLine(task5);

            Console.ReadKey();
        }
    }
}
