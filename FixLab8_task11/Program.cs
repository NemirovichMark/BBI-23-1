using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixLab8_task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Surnamelist = "Иванов,Алексеев,Кузьмин,Совельев,Кайдорин";
            //Array.Sort(SurnamesList);
            //foreach(string surnames in  SurnamesList)
            //{
            //    Console.WriteLine(surnames);
            //}

            string sortedSurnamelist = SortSurnameList(Surnamelist);
            Console.WriteLine(sortedSurnamelist);
            Console.ReadKey();
        }
        static string SortSurnameList(string SurnameList)
        {
            //string [] strings = SurnameList.Split(',');
            //for (int i = 0; i < strings.Length - 1; i++)
            //{
            //    for (int j = 0; j < strings.Length - i - 1; j++)
            //    {
            //        if ((strings[j] > strings[j + 1]) > 0)
            //        {
            //            string temp = strings[j];
            //            strings[j] = strings[i];
            //            strings[i] = temp;
            //        }
            //    }
            //}
            string[] strings = SurnameList.Split(',');
            string[] sortedStrings = strings.OrderBy(s => s).ToArray();



            string sortedSurnamelist = string.Join(",", sortedStrings);
            return sortedSurnamelist;
        }
    }
}
