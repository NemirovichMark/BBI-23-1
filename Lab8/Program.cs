using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab8
{
    //abstract class to complete lab8
    abstract class Task
    {
        public abstract string ToString();
    }
    //tasks:
    class Task2 : Task
    {
        //Ученики зашифровывают свои записки, записывая все слова наоборот. Составить 
        //программу, зашифровывающую и расшифровывающую сообщение.

        private string Text { get; set; }
        public Task2(string text)
        {
            Text = text;
        }

        //method to encrypt text
        private string EncryptText(string text)
        {
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseWordKeepingPunctuation(words[i]);
            }

            return string.Join(" ", words);
        }

        // Method to reverse a word while keeping punctuation in place
        private string ReverseWordKeepingPunctuation(string word) //using left/right - if symbol is not a letter or a number it stays in place
        {
            char[] chars = word.ToCharArray();
            char[] reversedChars = new char[chars.Length];
            int left = 0, right = chars.Length - 1;

            while (left <= right)
            {
                if (!char.IsLetterOrDigit(chars[left]))
                {
                    reversedChars[left] = chars[left];
                    left++;
                }
                else if (!char.IsLetterOrDigit(chars[right]))
                {
                    reversedChars[right] = chars[right];
                    right--;
                }
                else
                {
                    reversedChars[left] = chars[right];
                    reversedChars[right] = chars[left];
                    left++;
                    right--;
                }
            }

            return new string(reversedChars);
        }

        //method to decrypt text
        private string DecryptText(string text)
        {
            return EncryptText(text);
        }

        //outputting the result
        public override string ToString()
        {
            string encryptedText = EncryptText(Text);
            string decryptedText = DecryptText(encryptedText);

            return "\nEncrypted text: " + encryptedText +
                   "\nDecrypted text: " + decryptedText;
        }
    }

    class Task4 : Task
    {
        //Назовем сложностью предложения сумму количества слов и знаков препинания.
        //Определить сложность заданного предложения.

        private string Text { get; set; }

        public Task4(string text)
        {
            Text = text;
        }

        //method to calculate complexity(words + punctuation marks)
        private string CalculateComplexity(string text)
        {
            int words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length; //divides words using spaces

            char[] punctuationMarks = { '.', ',', '!', '?', ':', ';', '-', '—', '(', ')', '[', ']', '{', '}', '"', '\'' }; //counts every 
                                                                                                                           //punctuation mark
            int punctuations = text.Count(c => punctuationMarks.Contains(c));

            int complexityyy = Convert.ToInt32(words + punctuations);

            return "Complexity: " + complexityyy;
        }

        //outputting the result
        public override string ToString()
        {
            string complexity = CalculateComplexity(Text);
            return complexity;
        }
    }

    class Task6 : Task
    {
        //Определить, сколько слов в тексте содержит один слог, два слога, три слога и т.д.

        private string Text { get; set; }

        public Task6(string text)
        {
            Text = text;
        }

        //method  to count syllables and words
        private string CountSyllables(string text)
        {
            string[] words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries); //divides words using spaces

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y', 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' }; //counts vowels to make 1 syllable when we find 1 vowel in a word

            Dictionary<int, int> syllableCounts = new Dictionary<int, int>();// create dictionary to count the amount of word with different number of syllables

            foreach (var word in words) //counting syllables
            {
                int syllableCount = word.Count(c => vowels.Contains(c));

                if (syllableCounts.ContainsKey(syllableCount))
                {
                    syllableCounts[syllableCount]++;
                }
                else
                {
                    syllableCounts[syllableCount] = 1;
                }
            }

            foreach (var keyValuePair in syllableCounts.OrderBy(keyValuePair => keyValuePair.Key)) //key in this dictionary - number of syllables
                                                                                                   //value - words with particular amount of syllables
            {
                Console.WriteLine($"{keyValuePair.Key} слогов: {keyValuePair.Value} слов");
            }
            return string.Empty;
        }

        //outputting the result
        public override string ToString()
        {
            string output = CountSyllables(Text);
            return output;
        }
    }

    class Task8 : Task
    {
        // Разделить заданный текст (не более 1000 символов) на строки, содержащие не
        // более 50 символов. (Перенос осуществлять на месте пробела). Добавить
        // равномерно пробелы, чтобы каждая строка содержала ровно 50 символов.

        private string Text { get; set; }
        private int MaxLength { get; set; } = 50;

        public Task8(string text)
        {
            Text = text;
        }

        // Method to split inputted text into words 
        static List<string> SplitTextIntoLines(string text, int maxLength) //method makes a new line only when current
                                                                           //line has exactly 50 sumbols
        {
            List<string> lines = new List<string>();
            string[] words = text.Split(' ');
            string currentLine = "";

            foreach (string word in words)
            {
                if (currentLine.Length + word.Length + 1 <= maxLength)
                {
                    if (currentLine.Length > 0)
                        currentLine += " ";
                    currentLine += word;
                }
                else
                {
                    lines.Add(MakeLineExactly50Symbols(currentLine, maxLength));
                    currentLine = word;
                }
            }

            if (currentLine.Length > 0)
                lines.Add(MakeLineExactly50Symbols(currentLine, maxLength));

            return lines;
        }

        // Method to add spaces so that every line is exactly 50 symbols long
        static string MakeLineExactly50Symbols(string line, int length) //added a check in case the string consists of a single word
                                                                        //in this case, spaces are added to the end of the line
        {
            if (line.Length >= length) return line;

            string[] words = line.Split(' ');
            int totalSpaces = length - line.Length;
            int gaps = words.Length - 1;

            if (gaps > 0)
            {
                int spacesPerGap = totalSpaces / gaps;
                int extraSpaces = totalSpaces % gaps;

                for (int i = 0; i < gaps; i++)
                {
                    words[i] += new string(' ', spacesPerGap + (i < extraSpaces ? 1 : 0));
                }
            }
            else
            {
                // If there are no gaps (line is a single word), just add spaces at the end
                return words[0] + new string(' ', totalSpaces);
            }

            return string.Join(" ", words);
        }

        // Outputting the result
        public override string ToString()
        {
            List<string> lines = SplitTextIntoLines(Text, MaxLength);
            return string.Join(Environment.NewLine, lines);
        }
    }

    class Task9 : Task
    {
        //Для хранения текста в сжатом виде найти часто повторяющиеся
        //последовательности из двух букв и заменить их кодом.В качестве кода
        //использовать символы, не встречающиеся в тексте.Составить также таблицу
        //кодов.

        //properties
        private string originalText;
        private string compressedText;
        private Dictionary<string, string> cipherTable;

        //constructor for the class
        public Task9(string text)
        {
            originalText = text;
            CompressText();
        }

        //method to compress letter-couples to one-symbol code
        private void CompressText()
        {
            //finding letter-couples
            Dictionary<string, int> letterCouple = new Dictionary<string, int>();
            for (int i = 0; i < originalText.Length - 1; i++)
            {
                string pair = originalText.Substring(i, 2);
                if (letterCouple.ContainsKey(pair))
                {
                    letterCouple[pair]++;
                }
                else
                {
                    letterCouple[pair] = 1;
                }
            }

            // finding letter-couples
            var sortedPairs = letterCouple.OrderByDescending(p => p.Value).ToList();
            cipherTable = new Dictionary<string, string>();
            HashSet<char> usedChars = new HashSet<char>(originalText);

            char replacementChar = '\u0001'; // unicode symbol 0001 - start of heading
            foreach (var pair in sortedPairs)
            {
                while (usedChars.Contains(replacementChar) || char.IsControl(replacementChar))
                {
                    replacementChar++;
                }

                if (cipherTable.Count >= 256) break;

                cipherTable[pair.Key] = replacementChar.ToString();
                usedChars.Add(replacementChar);
                replacementChar++;
            }

            // swapping letter-couples to the code symbols
            compressedText = originalText;
            foreach (var entry in cipherTable)
            {
                compressedText = compressedText.Replace(entry.Key, entry.Value.ToString());
            }
        }

        //method to copy table of code
        public Dictionary<string, string> GetTableOfCodes()
        {
            return cipherTable;
        }

        //outputting the result
        public override string ToString()
        {
            var result = new System.Text.StringBuilder();
            result.AppendLine("Code table:");

            foreach (var entry in cipherTable)
            {
                result.AppendLine($"{entry.Key} => {entry.Value}");
            }

            result.AppendLine("\nCiphered text:");
            result.AppendLine(compressedText);

            return result.ToString();
        }
    }

    class Task10 : Task
    {
        //class properties
        private string compressedText;
        private Dictionary<string, string> codeTable;

        //class constructor
        public Task10(string compressedText, Dictionary<string, string> codeTable)
        {
            this.compressedText = compressedText;
            this.codeTable = codeTable;
        }

        //method to deсipher text
        private string DecipherText()
        {
            string decipheredText = "";
            int i = 0;

            while (i < compressedText.Length)
            {
                bool found = false;
                foreach (var code in codeTable)
                {
                    if (i + code.Value.Length <= compressedText.Length && compressedText.Substring(i, code.Value.Length) == code.Value)
                    {
                        decipheredText += code.Key;
                        i += code.Value.Length;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    decipheredText += compressedText[i];
                    i++;
                }
            }

            return decipheredText;
        }

        //outputting result
        public override string ToString()
        {
            string decodedText = DecipherText();
            return "Deciphered text:\n" + decodedText;
        }
    }

    class Task14 : Task
    {
        //Текст содержит слова и целые числа от 1 до 10. Найти сумму включенных в текст чисел.

        private string Text { get; set; }

        public Task14(string text)
        {
            Text = text;
        }

        //method to find the sum of numbers from 1 to 10 included in the text
        public int SumOfNumbersInText()
        {
            int sum = 0;
            string[] words = Text.Split(' ');

            foreach (string word in words)
            {
                if (int.TryParse(word, out int number) && number >= 1 && number <= 10)
                {
                    sum += number;
                }
            }

            return sum;
        }


        //outputting the result
        public override string ToString()
        {
            int sum = SumOfNumbersInText();
            return $"Sum of numbers in the text: {sum}";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //original text
            string textToDoSum = "1 2 3 Hello what's up, how are you, what are you doing";

            //task 2 output
            Console.WriteLine("Task2 answer:");
            var task2 = new Task2(textToDoSum);
            string task2Answer = task2.ToString();
            Console.WriteLine(task2Answer);

            //task 4 output
            Console.WriteLine("\nTask 4 answer:\n");
            var task4 = new Task4(textToDoSum);
            string task4Answer = task4.ToString();
            Console.WriteLine(task4Answer);

            //task 6 output
            Console.WriteLine("\nTask 6 answer:\n");
            var task6 = new Task6(textToDoSum);
            string task6Answer = task6.ToString();
            Console.WriteLine(task6Answer);

            //task 8 output
            Console.WriteLine("Task 8 answer:");
            var task8 = new Task8(textToDoSum);
            string task8Answer = task8.ToString();
            Console.WriteLine(task8Answer);

            //task 9 output
            Console.WriteLine("\nTask 9 answer:\n");
            var task9 = new Task9(textToDoSum);
            string task9Answer = task9.ToString();
            Console.WriteLine(task9Answer);

            //task 10 output
            Console.WriteLine("Task 10 answer:\n");
            var codeTable = task9.GetTableOfCodes();
            var task10 = new Task10(textToDoSum, codeTable);
            string task10Answer = task10.ToString();
            Console.WriteLine(task10Answer);

            //task 14 output
            Console.WriteLine("\nTask 14 answer:\n");
            var task14 = new Task14(textToDoSum);
            string task14Answer = task14.ToString();
            Console.WriteLine(task14Answer);

            //for console correct displaying
            Console.ReadKey();
        }
    }
}
