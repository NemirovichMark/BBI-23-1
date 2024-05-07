using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_alekseev_lvl3
{
    public class FootballTeam
    {
        private string _name;
        private int _points;
        private string _gender;


        public FootballTeam(string name, int points, string gender)
        {
            _name = name;
            _points = points;
            _gender = gender;
        }

        public string Name { get { return _name; } }
        public int Points { get { return _points; } }
        public string Gender { get { return _gender; } }

    }

    class WomenFootballTeam : FootballTeam
    {

        public WomenFootballTeam(string Name , int Points) : base(Name , Points, "Women" )
        {
        }
    }

    class MenFootballTeam : FootballTeam
    { 
        public MenFootballTeam(string Name ,int Points) : base (Name, Points, "Men")
        {

        }
    }

    public class Program
    {
        public static void Main()
        {
            FootballTeam[] womenteam = new FootballTeam[]
            {
            new WomenFootballTeam ( "Women Team A1", 10 ),
            new WomenFootballTeam( "Women Team A2", 9 ),
            new WomenFootballTeam("Women Team A3", 3 ),
            new WomenFootballTeam( "Women Team A4", 10 ),
            new WomenFootballTeam( "Women Team A5", 11 ),
            new WomenFootballTeam( "Women Team A6", 12 ),
            new WomenFootballTeam( "Women Team A7", 9 ),
            new WomenFootballTeam( "Women Team A8", 8 ),
            new WomenFootballTeam( "Women Team A9", 5 ),
            new WomenFootballTeam( "Women Team A10", 3 ),
            new WomenFootballTeam( "Women Team A11", 4 ),
            new WomenFootballTeam( "Women Team A12" ,11 ),
            };


            FootballTeam[] menteam = new FootballTeam[]
            {
            new MenFootballTeam( "Men Team B1", 12 ),
            new MenFootballTeam ( "Men Team B2", 6 ),
            new MenFootballTeam ( "Men Team B3", 3 ),
            new MenFootballTeam ( "Men Team B4", 3 ),
            new MenFootballTeam ( "Men Team B5", 12 ),
            new MenFootballTeam ( "Men Team B6", 10 ),
            new MenFootballTeam ( "Men Team B7", 9 ),
            new MenFootballTeam ( "Men Team B8", 11 ),
            new MenFootballTeam ( "Men Team B9",  5 ),
            new MenFootballTeam ( "Men Team B10", 3 ),
            new MenFootballTeam ( "Men Team B11", 1 ),
            new MenFootballTeam ( "Men Team B12", 8 ),
            };


            Sort(womenteam);
            Sort(menteam);


            FootballTeam[] commantable = MergeArrays(womenteam, menteam);


            foreach (var team in commantable)
            {
                Console.WriteLine($"{team.Gender}, {team.Name}, {team.Points} баллов") ;
            }
            Console.ReadKey();
        }



        static FootballTeam[] MergeArrays(FootballTeam[] array1, FootballTeam[] array2)
        {
            int n1 = array1.Length;
            int n2 = array2.Length;
            FootballTeam[] mergedArray = new FootballTeam[n1 + n2];
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



        static void Sort(FootballTeam[] teams)
        {
            for (int i = 0; i < teams.Length - 1; i++)
            {
                for (int j = 0; j < teams.Length - i - 1; j++)
                {
                    if (teams[j].Points < teams[j + 1].Points)
                    {
                        FootballTeam temp = teams[j];
                        teams[j] = teams[j + 1];
                        teams[j + 1] = temp;
                    }
                }
            }
        }
    }
}