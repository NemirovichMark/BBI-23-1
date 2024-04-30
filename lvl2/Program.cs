using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lvl2
{
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
            private string _name;
            private int _markMath;
            private int _markPhys;
            private int _markRus;
            private double _avgMark;
            private bool _isPastExm;

            public Graduate(string name, int markmat, int markphys, int markrus)
            {
                _name = name;
                _markMath = markmat;
                _markPhys = markphys;
                _markRus = markrus;
                _avgMark = (_markMath + _markPhys + _markRus) / 3.0;
                _isPastExm = (_markMath >= 3 && _markPhys >= 3 && _markRus >= 3);

            }

            public string Name => _name;
            public int MarkMath => _markMath;
            public int MarkPhys => _markPhys;
            public int MarkRus => _markRus;
            public double AvgMark => _avgMark;
            public bool IsPastExm => _isPastExm;

            public void Print()
            {
                Console.WriteLine($"{Name}, {MarkMath}, {MarkPhys}, {MarkRus}");
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

                var sortedGraduates = InsertionSort(passedGraduates)

                foreach (var graduate in sortedGraduates)
                {
                    graduate.Print();
                }
                Console.ReadKey()


                static void Swap(ref int e1, ref int e2)
                {
                    var temp = e1;
                    e1 = e2;
                    e2 = temp;
                }

                static int[] InsertionSort(int[] array)
                {
                    for ( int i = 1; i < array.Length; i++ )
                    {
                        var k = array[i];
                        var j = k; 
                        while ((j > 1) && (array[j - 1] > k))
                        {
                            Swap(ref array[j - 1], ref array[j]);
                            j--
                        }
                        array[j] = k
                    }
                    return array;
                }
            }
        }
    }
}
