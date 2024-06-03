using System.Text.Json.Serialization;
using System.Xml.Serialization;


[XmlInclude(typeof(StrategyGame))]
[Serializable]
public class BoardGame
{
    [XmlAttribute]
    protected string title;
    [XmlAttribute]
    protected int minimumplayers;
    [XmlAttribute]
    protected int maximumplayers;
    [XmlAttribute]
    protected int agerestriction;
    [XmlAttribute]
    protected string description;
    [XmlAttribute]

    public string Title
    {
        get => title;
        set => title = value;
    }

    public int MinimumPlayers
    {
        get => minimumplayers;
        set => minimumplayers = value;
    }

    public int MaximumPlayers
    {
        get => maximumplayers;
        set => maximumplayers = value;
    }
    public int AgeRestriction
    {
        get => agerestriction;
        set => agerestriction = value;
    }
    public string Description
    {
        get => description;
        set => description = value;
    }

    

    [JsonConstructor]
    public BoardGame(string title, int minimumplayers, int maximumplayers, int agerestriction, string description)
    {
        this.title = title;
        this.minimumplayers = minimumplayers;
        this.maximumplayers = maximumplayers;
        this.agerestriction = agerestriction;
        this.description = description;
    }
    public BoardGame() { }
    
    public virtual string ToString()
    {
        return $"Название - {title}" + "\n" + $"Мин.игроков - {minimumplayers}" + "\n" + $"Макс.игроков - {maximumplayers}" + "\n" + $"Возрастное ограничение - {agerestriction}" + "\n" + $"Описание - {description}" + "\n";
    }
}

[Serializable]
public class CardGame : BoardGame
{
    [XmlAttribute]
    private int number_of_player_cards;
    [XmlAttribute]
    private int total_number_of_cards;

    public int Number_of_player_cards
    {
        get => number_of_player_cards;
        set => number_of_player_cards = value;
    }

    public int Total_number_of_cards
    {
        get => total_number_of_cards;
        set => total_number_of_cards = value;
    }


    [JsonConstructor]
    public CardGame(string title, int minimumplayers, int maximumplayers, int agerestriction, string description, int number_of_player_cards, int total_number_of_cards) : base(title, minimumplayers, maximumplayers, agerestriction, description)
    {
        this.number_of_player_cards = number_of_player_cards;
        this.total_number_of_cards = total_number_of_cards;
    }


    public CardGame() { }

    public override string ToString()
    {
        return "Карточная игра:" + "\n" + $"Название - {title}" + "\n" + $"Мин.игроков - {minimumplayers}" + "\n" + $"Макс.игроков - {maximumplayers}" + "\n" + $"Возрастное ограничение - {agerestriction}" + "\n" + $"Описание - {description}" + "\n" + $"Кол-во карт всего - {total_number_of_cards}" + "\n" + $"Кол-во карт игрока  - {number_of_player_cards}" + "\n";
    }
}

[Serializable]
public class StrategyGame : BoardGame
{
    [XmlAttribute]
    private int average_game_time;
    [XmlAttribute]
    private bool magnetic_board;

    public int Average_game_time
    {
        get => average_game_time;
        set => average_game_time = value;
    }

    public bool Magnetic_board
    {
        get => magnetic_board;
        set => magnetic_board = value;
    }


    [JsonConstructor]
    public StrategyGame(string title, int minimumplayers, int maximumplayers, int agerestriction, string description, int average_game_time, bool magnetic_board) : base(title, minimumplayers, maximumplayers, agerestriction, description)
    {
        this.average_game_time = average_game_time;
        this.magnetic_board = magnetic_board;
    }
    public StrategyGame() { }

    public override string ToString()
    {
        return "Игра стратегия:" + "\n" + $"Название - {title}" + "\n" + $"Мин.игроков - {minimumplayers}" + "\n" + $"Макс.игроков - {maximumplayers}" + "\n" + $"Возрастное ограничение - {agerestriction}" + "\n" + $"Описание - {description}" + "\n" + $"Ср.время игры - {average_game_time}" + "\n" + $"Магнитная доска  - {magnetic_board}" + "\n";
    }
}

[Serializable]
public class PartyGame : BoardGame
{
    [XmlAttribute]
    private string difficulty_level;
    [XmlAttribute]
    private bool team_or_individual;

    public string Difficulty_level
    {
        get => difficulty_level;
        set => difficulty_level = value;
    }

    public bool Team_or_individual
    {
        get => team_or_individual;
        set => team_or_individual = value;
    }


    [JsonConstructor]
    public PartyGame(string title, int minimumplayers, int maximumplayers, int agerestriction, string description, string difficulty_level, bool team_or_individual) : base(title, minimumplayers, maximumplayers, agerestriction, description)
    {
        this.difficulty_level = difficulty_level;
        this.team_or_individual = team_or_individual;
    }

    public PartyGame() { }

    public override string ToString()
    {
        return "Игра для вечеринки:" + "\n" + $"Название - {title}" + "\n" + $"Мин.игроков - {minimumplayers}" + "\n" + $"Макс.игроков - {maximumplayers}" + "\n" + $"Возрастное ограничение - {agerestriction}" + "\n" + $"Описание - {description}" + "\n" + $"Уровень сложности - {difficulty_level}" + "\n" + $"Командная ли игра  - {team_or_individual}" + "\n";
    }
}

public interface IGameCatalog
{
    void AddGame(BoardGame game);
    void RemoveGame();
    void AddGames(BoardGame[] games);
    void RemoveGame(int index);
    void DisplayCatalog();
}
