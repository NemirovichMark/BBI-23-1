using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace lab8_rework_alekseev
{
    abstract class Task
    {
        protected string Text = "";

        public Task(string text)
        {
            Text = text;
        }
    }

    class Task_2 : Task
    {
        public Task_2(string text) : base(text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return ($"Зашифрованное : {Message(Text)}, Расшифрованное : {DecryptMessage(Message(Text))}");
        }

        public string Message(string text)
        {
            string encryptedText = EncryptMessage(text);
            return encryptedText;
        }

        protected string EncryptMessage(string text)
        {
            string[] messageParts = text.Split(' ');
            for (int i = 0; i < messageParts.Length; i++)
            {
                messageParts[i] = ReverseString(messageParts[i]);
            }
            return string.Join(" ", messageParts);
        }

        protected string DecryptMessage(string encryptedText)
        {
            string[] words = encryptedText.Split(' ');
            
            StringBuilder decryptText = new StringBuilder(); // для хранения разобранного текста 
            foreach(string word in words)
            {
                string decryptWords = ReverseString(word);
                decryptText.Append(decryptWords).Append(" ");

            }
            return decryptText.ToString().TrimEnd();// Удалил последний пробел и вернул текст
        }

        protected string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
    class Task_4 : Task
    {
        public Task_4(string text) : base(text) { Text = text; }

        public override string ToString()
        {
            return $"Сложность {Complexity()}";
        }
        public int Complexity()
        {
            return CalculateSentenceComplexity(Text);
        }


        protected int CalculateSentenceComplexity(string text)
        {
            string pattern = @"\w+|[^\w\s]";
            MatchCollection matches = Regex.Matches(text, pattern);

            int complexity = matches.Count;
            return complexity;
        }
    }

    class Task_5 : Task
    {
        public Task_5(string text) : base(text) { Text = text; }
        public override string ToString()
        {
            return string.Join(", ", LetterCounter(Text));
        }
        public IEnumerable<KeyValuePair<char, int>> LetterCounter (string text) 
        {
            text = text.ToLower();
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            char[] firstLetter = new char[words.Length];

            for(int i =0; i < words.Length; i++)
            {
                firstLetter[i] = words[i][0];
            }
            Dictionary<char, int> lettercounter = new Dictionary<char, int>();
            foreach(var letter in firstLetter)
            {
                if (lettercounter.ContainsKey(letter))
                {
                    lettercounter[letter]++;
                }
                else
                {
                    lettercounter[letter] = 1;
                }
            }

            var sortedLetters = lettercounter.OrderByDescending(x =>x.Value).Select(x => new KeyValuePair<char, int>(x.Key, x.Value)).ToList();

            return sortedLetters;
            
        }

    }

    class Task_7 : Task
    {
        public Task_7(string text) : base (text ) { Text = text.ToLower(); }

        public override string ToString()
        {
            return Sequence(Text).ToString();
        }
        public string Sequence (string text)
        {
            text = text.ToLower();
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
             Console.WriteLine("Задайте последовательность букв, которую нужно найти :");
             string sequence = Console.ReadLine().ToLower();
            //string sequence = "дет";
            string[] matchingWords = new string[words.Length]; 
            int count = 0;

            foreach (string word in words)
            {
                if (word.Contains(sequence))
                {
                    matchingWords[count] = word;
                    count++;
                }
            }
            if (count > 0)
            {
                return string.Join(", ", matchingWords.Take(count).ToArray());  
            }
            else
            {
                return "Ничего не смогли найти, попробуйте другое";
            }
            
        }
    }

    class Task_11 : Task
    {
        public Task_11(string text) : base (text ) { Text = text; }
        public override string ToString()
        {
            return SortedSurname(Text).ToString();
        }
        public string SortedSurname(string text)
        {
            string[] strings = text.Split(',');
            string[] sortedStrings = strings.OrderBy(s => s).ToArray();

            string sortedSurnamelist = string.Join(",", sortedStrings);
            return sortedSurnamelist;
        }
    }

    class Task_14 : Task
    {
        public Task_14(string text) : base (text ) {Text = text ;}

        public override string ToString()
        {
            return CounterNumbers(Text).ToString();
        }
        public int CounterNumbers(string text)
        {
            int counter = 0;
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if(int.TryParse(word, out int number))
                {
                    counter+=number;
                }
            }
            return counter;
        }
    }







    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1 задание :");
            Task_2 task2 = new Task_2("Играющий в игры Антон хотел все время кушать и пить");
            Console.WriteLine(task2);

            Console.WriteLine("2 задание :");
            Task_4 task4 = new Task_4("Прекрасная пора и майский день дождливый. Сижу у окна и чувствую аромат.\r\n      Я вспоминаю с радостью сегодняшнюю встречу, и сердце бьётся в упоении. Слышу голос, смотрю на букет. Я в эйфории! Снова вдыхаю запах сирени. Вчитываюсь в письмо.\r\n       После замираю. Ошибка в имени. Одна буква. Письмо сестре!\r\n       Мгновенно выступившие слёзы.");
            Console.WriteLine(task4);

            Console.WriteLine("3 задание :");
            Task_5 task5 = new Task_5("Утром в низинах расстилался туман. Но вот из-за горизонта появляются солнце, и его лучи съедают серую пелену тумана.     Солнце поднимается выше и разбрасывает свои лучи по необъятным полям желтой пшеницы верхушкам далекого леса.     На расстоянии километра от леса замечаешь блестящую на солнце поверхность озера. В неё впадает извилистая речонка. Мы направляемся к ней.");
            Console.WriteLine(task5);

            Console.WriteLine("4 задание :");
            Task_7 task7 = new Task_7("Коля и Лёня ехали в лифте. Внезапно свет погас и лифт остановился. Кабина застыла на месте. Дети оказались в полной темноте, одни в маленькой тесной кабине. Коля и Лёня испугались. Они стали звать соседей. Тут свет вспыхнул, и кабина поехала. Но несколько минут в тёмном лифте показались детям удивительно длинными.");
            Console.WriteLine(task7);

            Console.WriteLine("5 задание :");
            Task_11 task11 = new Task_11("Иванов,Алексеев,Кузьмин,Совельев,Кайдорин");
            Console.WriteLine(task11);

            Console.WriteLine("6 задание :");
            Task_14 task14 = new Task_14("Вселенная, в которой мы живём, имеет возраст около 4 миллиардов лет. Солнце, наша звезда, имеет диаметр около 3 миллиона километров. Расстояние от Земли до Солнца составляет 7 миллионов километров.");
            Console.WriteLine(task14);


            Console.ReadKey();
        }
    }
}
