using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Коля и Лёня ехали в лифте. Внезапно свет погас и лифт остановился. Кабина застыла на месте. Дети оказались в полной темноте, одни в маленькой тесной кабине. Коля и Лёня испугались. Они стали звать соседей. Тут свет вспыхнул, и кабина поехала. Но несколько минут в тёмном лифте показались детям удивительно длинными.";
            string sequence = "дет";
            text = text.ToLower();
            string[] words = text.Split(new char[] {' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if ( word.Contains(sequence))
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadKey();
        }   
    }
}
