using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Variant_2
{
    public class Task3
    {
        public class Grep
        {
            private string input;
            private string output;

            public string Input => input;
            public string Output => output;

            public Grep(string text)
            {
                input = text;
                ProcessInput();
            }

            private void ProcessInput()
            {
                
                Dictionary<char, int> charFrequency = new Dictionary<char, int>();
                foreach (char c in input.Replace(" ", "")) 
                {
                    if (charFrequency.ContainsKey(c))
                    {
                        charFrequency[c]++;
                    }
                    else
                    {
                        charFrequency[c] = 1;
                    }
                }

                
                char mostCommonChar = '0';
                int maxCount = 0;
                foreach (var pair in charFrequency)
                {
                    if (pair.Value > maxCount)
                    {
                        mostCommonChar = pair.Key;
                        maxCount = pair.Value;
                    }
                }

                
                StringBuilder sb = new StringBuilder();
                string[] words = input.Split(' ');
                foreach (string word in words)
                {
                    if (!word.Contains(mostCommonChar))
                    {
                        sb.Append(word + " ");
                    }
                }

                
                if (sb.Length > 0)
                {
                    sb.Length--;
                }
                output = sb.ToString();
            }

            public override string ToString()
            {
                return output;
        }
            }
    }
}
