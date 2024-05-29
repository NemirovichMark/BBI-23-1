using lab10.library;

namespace lab10.serializers;

public abstract class MySerializer
{
    public abstract Library[] Read(string filename);

    public abstract void Write(Library[] libraries, string filename);
}