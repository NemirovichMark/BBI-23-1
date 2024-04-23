using System;
using System.Collections.Generic;

namespace Analiztext
{
    abstract class Analyz
    {
        protected string[] SplitText(string text)
        {
            return text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        }

        protected bool Hhhjhhh(string word)
        {
            HashSet<char> letters = new HashSet<char>();

            foreach (char letter in word)
            {
                if (!letters.Contains(letter))
                {
                    letters.Add(letter);
                }
            }

            return letters.Count == word.Length;
        }

        public abstract List<string> Analyze(string text);
    }

    class Prep : Analyz
    {
        private readonly string[] vowels = { "а", "е", "ё", "и", "о", "у", "ы", "э", "ю", "я" };

        private bool I(string word)
        {
            return word == "и" || word == "или" || word == "но" || word == "а" || word == "ибо"
                || word == "чтобы" || word == "потому" || word == "что" || word == "если" || word == "когда"
                || word == "где" || word == "который" || word == "от" || word == "до" || word == "для" || word == "в"
                || word == "на" || word == "у" || word == "с" || word == "о" || word == "за" || word == "перед"
                || word == "под" || word == "над" || word == "около" || word == "по" || word == "без" || word == "про"
                || word == "со" || word == "из" || word == "за" || word == "при";
        }

        private bool CVowel(string word)
        {
            foreach (string v in vowels)
            {
                if (word.Contains(v))
                {
                    return true;
                }
            }
            return false;
        }

        public override List<string> Analyze(string text)
        {
            List<string> result = new List<string>();
            string[] words = SplitText(text);

            foreach (string word in words)
            {
                string low = word.ToLower();

                if (I(low) && !CVowel(low))
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }

    class WordAnalyzer : Analyz
    {
        public override List<string> Analyze(string text)
        {
            List<string> result = new List<string>();
            string[] words = SplitText(text);

            foreach (string word in words)
            {
                if (Hhhjhhh(word.ToLower()))
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Привет как дела что делаешь чем живешь";

            Analyz prep = new Prep();
            List<string> asd = prep.Analyze(text);

            Console.WriteLine("Предлоги и союзы без гласных букв в тексте:");
            foreach (string word in asd)
            {
                Console.WriteLine(word);
            }

            Analyz wordAnalyzer = new WordAnalyzer();
            List<string> Diflet = wordAnalyzer.Analyze(text);

            Console.WriteLine("Слова с разными буквами в тексте:");
            foreach (string word in Diflet)
            {
                Console.WriteLine(word);
            }
        }
    }
}