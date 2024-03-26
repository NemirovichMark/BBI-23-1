using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lvl2
{
    struct Graduate
    {
        public string Name;
        private int MarkMath;
        private int MarkPhys;
        private int MarkRus;
        public double AvgMark;
        public bool IsPastExm;

        public Graduate(string name, int markmat, int markphys, int markrus)
        {
            Name = name;
            MarkMath = markmat;
            MarkPhys = markphys;
            MarkRus = markrus;
            AvgMark = (MarkMath + MarkPhys + MarkRus) / 3.0;
            IsPastExm = (MarkMath + MarkPhys + MarkRus)/3 >= 3;

        }
    }


    class Program
    {
        static void Main()
        {
            Graduate[] graduates = new Graduate[]
            {
            new Graduate("Иван", 3, 5, 5),
            new Graduate("Сергей", 3, 3, 3),
            new Graduate("Колян", 3, 4, 2),
            new Graduate("Сеня", 3, 4, 4),
            new Graduate("ВВП", 5, 5, 5),
            new Graduate("Ждан", 3, 4, 4)

            };

            var passedGraduates = graduates.Where(g => g.IsPastExm).ToArray();

            var sortedGraduates = passedGraduates.OrderByDescending(g => g.AvgMark).ToArray();

            foreach (var graduate in sortedGraduates)
            {
                Console.WriteLine($"{graduate.Name}: {graduate.AvgMark}");


            }
            Console.ReadLine();
        }
    }
}
