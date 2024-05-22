using System;
class Programm
{
    public struct JumpResult
    {
        private string lastName;
        private string society;
        private double Result1;
        private double Result2;
        private double totalResult;
        public JumpResult(string lastName, string society, double Result1, double Result2)
        {
            this.lastName = lastName;
            this.society = society;
            this.Result1 = Result1;
            this.Result2 = Result2;
            this.totalResult = Result1 + Result2;
        }
        public string LastName { get { return lastName; } }
        public string Society { get { return society; } }
        public double TotalResult { get { return totalResult; } }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,11} {2,17} {3,14} {4,15}", lastName, society, Result1, Result2, totalResult);
        }
        static void GnomeSort(JumpResult[] array)
        {
            int index = 0;
            int nextIndex = index + 1;
            while (index < array.Length)
            {
                if (index == 0)
                    index=nextIndex;
                    nextIndex++;
                if (array[index].TotalResult <= array[index - 1].TotalResult)
                    index++;
                else
                {
                    Swap(array, index, index - 1);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }
        }

        static void Swap(JumpResult[] array, int a, int b)
        {
            JumpResult temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
    class JumpCompetition
    {
        static void Main()
        {
            JumpResult[] results = new JumpResult[]
            {
            new JumpResult("Хрищанович", "МИСиС", 2, 1.9),
            new JumpResult("Щерба", "БГЭУ", 2, 1.8),
            new JumpResult("Джурабоев", "МЭИ", 2.1, 1.7),
            new JumpResult("Мисюк", "БГУ", 2.1, 1.9),
            new JumpResult("Васечкин", "МИРЭА", 2.0, 1.85)
            };
            Console.WriteLine("{0,-15} {1,-15} {2,5} {3,15} {4,11}", "Фамилия", "Общество", "1-ая попытка", "2-ая попытка", "Итого");
            Console.WriteLine(new string('-', 60));
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}