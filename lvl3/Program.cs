using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl3
{
    public class Team
    {
        private string _name;
        private int _points;


        public Team(string name, int points)
        {
            _name = name;
            _points = points;
        }

        public string Name { get { return _name; } }

        public int Points { get { return _points; } }

    }

    public class Program
    {
        public static void Main()
        {
            Team[] groupA = new Team[]
            {
            new Team ( "Team A1", 10 ),
            new Team ( "Team A2", 9 ),
            new Team ( "Team A3", 3 ),
            new Team ( "Team A4", 10 ),
            new Team ( "Team A5", 11 ),
            new Team ( "Team A6", 12 ),
            new Team ( "Team A7", 9 ),
            new Team ( "Team A8", 8 ),
            new Team ( "Team A9", 5 ),
            new Team ( "Team A10", 3 ),
            new Team ( "Team A11", 4 ),
            new Team ( "Team A12" ,11 ),
            };


            Team[] groupB = new Team[]
            {
            new Team ( "Team B1", 12 ),
            new Team ( "Team B2", 6 ),
            new Team ( "Team B3", 3 ),
            new Team ( "Team B4", 3 ),
            new Team ( "Team B5", 12 ),
            new Team ( "Team B6", 10 ),
            new Team ( "Team B7", 9 ),
            new Team ( "Team B8", 11 ),
            new Team ( "Team B9",  5 ),
            new Team ( "Team B10", 3 ),
            new Team ( "Team B11", 1 ),
            new Team ( "Team B12", 8 ),
            };


            Sort(groupB);
            Sort(groupA);


            Team[] groupC = MergeArrays(groupA, groupB);

            foreach (var team in groupC)
            {
                Console.WriteLine(team.Name);
            }
            Console.ReadKey();
        }



        static Team[] MergeArrays(Team[] array1, Team[] array2)
        {
            int n1 = array1.Length;
            int n2 = array2.Length;
            Team[] mergedArray = new Team[n1 + n2];
            int i = 0, j = 0, k = 0;

            while (i < n1 && j < n2 && k < 12)
            {
                if (array1[i].Points >= array2[j].Points)
                {
                    mergedArray[k++] = array1[i++];
                }
                else
                {
                    mergedArray[k++] = array2[j++];
                }
            }

            while (i < n1 && k < 12)
            {
                mergedArray[k++] = array1[i++];
            }

            while (j < n2 && k < 12)
            {
                mergedArray[k++] = array2[j++];
            }

            return mergedArray;
        }



        static void Sort(Team[] teams)
        {
            for (int i = 0; i < teams.Length - 1; i++)
            {
                for (int j = 0; j < teams.Length - i - 1; j++)
                {
                    if (teams[j].Points < teams[j + 1].Points)
                    {
                        Team temp = teams[j];
                        teams[j] = teams[j + 1];
                        teams[j + 1] = temp;
                    }
                }
            }
        }
    }
}