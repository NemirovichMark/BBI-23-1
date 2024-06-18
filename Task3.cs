using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Variant_1
{
    public class Task3
    {
        public class Searcher
        {
            //fields
            private string input;
            private string[] output;

            //public properties to read fields
            public string Input
            {
                get { return input; }
            }
            public string[] Output
            {
                get { return output; }
            }

            //constructor
            public Searcher(string text)
            {
                input = text;
                output = ProcessText(text);
            }

            //method to turn a text into array of strings
            public string[] ProcessText(string text)
            {
                var words = text.Split(new[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                var repeatedWords = new List<string>();
                var checkedWords = new List<string>(); //we need hashset so that every posession(word in our case) is unique

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

                        if (count > 1) //if we meet a word in a text more than once we add it to an output with repeated words
                        {
                            repeatedWords.Add(words[i]);
                        }

                        checkedWords.Add(words[i]); //not to check again
                    }
                }

                return repeatedWords.ToArray();
            }

            //output
            public override string ToString()
            {
                return string.Join(" ", output);
            }
        }
    }
}
