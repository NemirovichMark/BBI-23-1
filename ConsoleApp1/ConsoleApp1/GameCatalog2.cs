using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class GameCatalog : IAnalizer
    {
        public double AverageMinAmount(BoardGame[] boardGames)
        {
            double sum = 0;
            foreach (BoardGame game in boardGames)
            {
                sum += game.MinimumPlayers;
            }
            return sum / boardGames.Length;
        }

        public double AverageMaxAmount(BoardGame[] boardGames)
        {
            double sum = 0;
            foreach (BoardGame game in boardGames)
            {
                sum += game.MaximumPlayers;
            }
            return sum / boardGames.Length;
        }

        public double MeanAmount(BoardGame[] boardGames)
        {
            double sum = 0;
            foreach (BoardGame game in boardGames)
            {
                sum += (game.MinimumPlayers + game.MaximumPlayers) / 2.0;
            }
            return sum / boardGames.Length;
        }

        public double MeanAgeRestriction(BoardGame[] boardGames)
        {
            double sum = 0;
            foreach (BoardGame game in boardGames)
            {
                sum += game.AgeRestriction;
            }
            return sum / boardGames.Length;
        }
    }

}
