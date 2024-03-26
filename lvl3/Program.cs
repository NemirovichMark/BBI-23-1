using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl3
{
    public class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            Team[] groupA = new Team[]
            {
            new Team { Name = "Team A1", Points = 10 },
            new Team { Name = "Team A2", Points = 9 },
            new Team { Name = "Team A3", Points = 3},
            new Team { Name = "Team A4", Points = 10},
            new Team { Name = "Team A5", Points = 11},
            new Team { Name = "Team A6", Points = 12 },
            new Team { Name = "Team A7", Points = 9 },
            new Team { Name = "Team A8", Points = 8 },
            new Team { Name = "Team A9", Points = 5 },
            new Team { Name = "Team A10", Points = 3 },
            new Team { Name = "Team A11", Points = 4},
            new Team { Name = "Team A12", Points = 11},


            };


            Team[] groupB = new Team[]
            {
            new Team { Name = "Team B1", Points = 12 },
            new Team { Name = "Team B2", Points = 6 },
            new Team { Name = "Team B3", Points = 3 },
            new Team { Name = "Team B4", Points = 3 },
            new Team { Name = "Team B5", Points = 12 },
            new Team { Name = "Team B6", Points = 10},
            new Team { Name = "Team B7", Points = 9},
            new Team { Name = "Team B8", Points = 11 },
            new Team { Name = "Team B9", Points = 5 },
            new Team { Name = "Team B10", Points = 3 },
            new Team { Name = "Team B11", Points = 1 },
            new Team { Name = "Team B12", Points = 8 },

            };


            Team[] topTeamsGroupA = SelectTopTeams(groupA);
            Team[] topTeamsGroupB = SelectTopTeams(groupB);

            Team[] secondStageTeams = topTeamsGroupA.Concat(topTeamsGroupB).ToArray();

            Console.WriteLine("Команды участники во второй стадии:");
            foreach (var team in secondStageTeams)
            {
                Console.WriteLine(team.Name);
            }
            Console.ReadKey();
        }

        public static Team[] SelectTopTeams(Team[] teams)
        {
            return teams.OrderByDescending(t => t.Points).Take(6).ToArray();
        }
    }
}
