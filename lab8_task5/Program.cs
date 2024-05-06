using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Утром в низинах расстилался туман. Но вот из-за горизонта появляются солнце, и его лучи съедают серую пелену тумана.     Солнце поднимается выше и разбрасывает свои лучи по необъятным полям желтой пшеницы верхушкам далекого леса.     На расстоянии километра от леса замечаешь блестящую на солнце поверхность озера. В неё впадает извилистая речонка. Мы направляемся к ней.";
            text = text.ToLower();
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            char[] firstletters = new char[words.Length];

            for ( int i = 0; i < words.Length; i++ )
            {
                firstletters[i] = words[i][0]; 
            }
            Dictionary<char, int> lettercounter = new Dictionary<char, int>();
            foreach (var letter in firstletters)
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

            var sortedLetters = lettercounter.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();

            foreach( var letter in sortedLetters) 
            {
                Console.WriteLine($"{letter} - {lettercounter[letter]}");
            }

            Console.ReadKey();
        }
    }
}
