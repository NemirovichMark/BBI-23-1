using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Preparation_Task3
{
    public class Task3
    {
        public class Searcher
        {
            //fields
            private string Input;
            private string[] Output;

            //public properties to read fields
            public string input
            {
                get { return Input; }
            }
            public string[] output
            {
                get { return Output; }
            }

            //constructor
            public Searcher(string text)
            {
                Input = text;
                Output = ProcessText(text);
            }

            private string[] ProcessText(string text)
            {
                var words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var repeatedWords = new List<string>();
                var checkedWords = new HashSet<string>();

                //check words repetitions
                for (int i = 0; i < words.Length; i++)
                {
                    if (!checkedWords.Contains(words[i]))
                    {
                        int count = 0;
                        for (int j = 0; j < words.Length; j++)
                        {
                            if (words[i] == words[j])
                            {
                                count++;
                            }
                        }

                        if (count > 1)
                        {
                            repeatedWords.Add(words[i]);
                        }

                        checkedWords.Add(words[i]); //not to check again
                    }
                }

                return repeatedWords.ToArray();
            }

            public override string ToString()
            {
                return string.Join(" ", Output);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                //text for input
                string text = "This is is text. Hello! Hello!!! How are you? AAafadsba ggcsa";

                //object of class Searcher to work with text
                Searcher wordsearch = new Searcher(text);

                //output the initial text
                Console.WriteLine("Input text:");
                Console.WriteLine(wordsearch.input);

                //output repeating words
                Console.WriteLine("\nRepeated words:");
                foreach (var word in wordsearch.output)
                {
                    Console.WriteLine(word);
                }

                //output
                Console.WriteLine("\nOutput:");
                Console.WriteLine(wordsearch.ToString());

                Console.ReadKey();
            }
        }
    }
}