using System.Text.Json.Serialization;

namespace app.main.songs;

[Serializable]
public class ChartSong : Song
{
    private int numberOfListeners;
    private string genreSong;

    public ChartSong()
    {
        
    }

    [JsonConstructor]
    public ChartSong(string title, string artist, int year, int numberOfListeners, string genreSong) : base(title, artist, year)
    {
        this.numberOfListeners = numberOfListeners;
        this.genreSong = genreSong;
    }


    public string GenreSong
    {
        get => genreSong;
        set => genreSong = value;
    }

    public int NumberOfListeners
    {
        get => numberOfListeners;
        set => numberOfListeners = value;
    }

    public override string ToString()
    {
        return base.ToString() + $" {numberOfListeners}, {genreSong}";
    }
}