using ConsoleApp1;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        MyJsonSerializer jsonSerializer = new();
        MyXmlSerializer xmlSerializer = new();

        BoardGame[] games = new BoardGame[30];

        for (int i = 0; i < games.Length; i++)
        {
            if (i % 3 == 0)
                games[i] = new StrategyGame("Игра " + i.ToString(), 2, 4, 12, "Описание " + i.ToString(), 60, true);
            else if (i % 3 == 1)
                games[i] = new CardGame("Игра " + i, 2, 4, 8, "Описание " + i, 52, 10);
            else
                games[i] = new PartyGame("Игра " + i, 4, 10, 16, "Описание " + i, "Средний", true);
        }

        string json_raw = "C:\\Users\\seregafarm\\Desktop\\raw_data.json"; //путь до файликов
        string xml_raw = "C:\\Users\\seregafarm\\Desktop\\raw_data.xml";
        string json = "C:\\Users\\seregafarm\\Desktop\\data.json";
        string xml = "C:\\Users\\seregafarm\\Desktopdata.xml";


        GameCatalog catalog = new GameCatalog();
        for (int i = 0; i < 10; i++)
        {
            catalog.AddGame(games[i]);
        }


        for (int i = 10; i < 20; i++)
        {
            catalog.AddGame(games[i]);
        }
        catalog.AddGame(games[29]);

        catalog.RemoveGame(5);
        catalog.RemoveGame(7);


        catalog.DisplayCatalog();


        Console.WriteLine("Среднее минимальное количество игроков: " + catalog.AverageMinAmount(catalog.GetGames()));
        Console.WriteLine("Среднее максимальное количество игроков: " + catalog.AverageMaxAmount(catalog.GetGames()));
        Console.WriteLine("Средний диапазон мест: " + catalog.MeanAmount(catalog.GetGames()));
        Console.WriteLine("Среднее возрастное ограничение: " + catalog.MeanAgeRestriction(catalog.GetGames()));
        Console.WriteLine();


        if (!File.Exists(json_raw))
        {
            jsonSerializer.Write<GameCatalog>(catalog, json_raw);
            jsonSerializer.Write<GameCatalog>(catalog, xml_raw);
        }
        else
        {
            var t1 = jsonSerializer.Read<GameCatalog>(json_raw);
            t1.DisplayCatalog();
            var t2 = jsonSerializer.Read<GameCatalog>(xml_raw);
            t2.DisplayCatalog();
           
            catalog.DisplayCatalog();
        }

    }
}





