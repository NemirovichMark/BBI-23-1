using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Прекрасная пора и майский день дождливый. Сижу у окна и чувствую аромат.\r\n      Я вспоминаю с радостью сегодняшнюю встречу, и сердце бьётся в упоении. Слышу голос, смотрю на букет. Я в эйфории! Снова вдыхаю запах сирени. Вчитываюсь в письмо.\r\n       После замираю. Ошибка в имени. Одна буква. Письмо сестре!\r\n       Мгновенно выступившие слёзы.";
            int complexity = CalculateSentenceComplexity(sentence);
            Console.WriteLine($"Сложность предложения: {complexity}") ;
            Console.ReadKey();
        }

        static int CalculateSentenceComplexity(string sentence)
        {
            string pattern = @"\w+|[^\w\s]";
            MatchCollection matches = Regex.Matches(sentence, pattern);

            int complexity = matches.Count;
            return complexity;
        }
    }
}
