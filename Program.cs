using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Lab8_alekseev
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
            return ($"Зашифрованное : {Message(Text)}, Расшифрованное : {ReverseString(Message(Text))}") ;
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
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseString(words[i]);
            }
            return string.Join(" ", words);
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
        public Task_4(string text) : base (text) { Text = text; }

        public override string ToString()
        {
            return $"Сложность {Complexity()}" ;
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
            return base.ToString(); 
        }


    }













    internal class Program
    {
        static void Main() 
        {
            Console.WriteLine("1");
            Task_2 task2 = new Task_2("Играющий в игры Антон хотел все время кушать и пить");
            Console.WriteLine(task2);

            Console.WriteLine("2");
            Task_4 task4 = new Task_4("Прекрасная пора и майский день дождливый. Сижу у окна и чувствую аромат.\r\n      Я вспоминаю с радостью сегодняшнюю встречу, и сердце бьётся в упоении. Слышу голос, смотрю на букет. Я в эйфории! Снова вдыхаю запах сирени. Вчитываюсь в письмо.\r\n       После замираю. Ошибка в имени. Одна буква. Письмо сестре!\r\n       Мгновенно выступившие слёзы.");
            Console.WriteLine(task4);




            Console.ReadKey();
        }
    }
}
