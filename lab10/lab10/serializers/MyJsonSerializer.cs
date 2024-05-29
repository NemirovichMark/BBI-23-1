using System.Text.Json;
using lab10.library;

namespace lab10.serializers;

public class MyJsonSerializer : MySerializer
{
    public override void Write(Library[] libraries, string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, libraries);
        }
    }

    public override Library[] Read(string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<Library[]>(fs);
        }
    }
}