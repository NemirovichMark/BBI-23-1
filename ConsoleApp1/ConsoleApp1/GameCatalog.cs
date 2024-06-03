using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class GameCatalog : IGameCatalog
    {
        private List<BoardGame> games = new List<BoardGame>();

        public void AddGame(BoardGame game)
        {
            games.Insert(games.Count,game);
        }

        public void RemoveGame()
        {
            games.RemoveAt(games.Count - 1);
        }

        public void AddGames(BoardGame[] gamesToAdd)
        {
            foreach (BoardGame game in gamesToAdd)
            {
                games.Insert(games.Count, game);
            }
        }
        public List<BoardGame> Games
        {
            get => games;
            set => games = value ?? default(List<BoardGame>);
        }

        public void RemoveGame(int index)
        {
            games.RemoveAt(index);
        }

        public void DisplayCatalog()
        {
            foreach (BoardGame game in games)
            {
                Console.WriteLine(game.ToString());
            }
        }
        public BoardGame[] GetGames()
        {
            BoardGame[] gamesl = new BoardGame[games.Count];
            for (int i = 0; i < games.Count; i++)
            {
                gamesl[i] = games[i];
            }
            return gamesl;
        }

    }
    public interface IAnalizer
    {
        double AverageMinAmount(BoardGame[] boardGames);
        double AverageMaxAmount(BoardGame[] boardGames);
        double MeanAmount(BoardGame[] boardGames);
        double MeanAgeRestriction(BoardGame[] boardGames);
    }

}
