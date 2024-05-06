using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Вселенная, в которой мы живём, имеет возраст около 4 миллиардов лет. Солнце, наша звезда, имеет диаметр около 3 миллиона километров. Расстояние от Земли до Солнца составляет 7 миллионов километров.";
            int counter = 0;
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if ( int.TryParse(word, out int number) )
                {
                    counter = +number;
                }
            }
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
