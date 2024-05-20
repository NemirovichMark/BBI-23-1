
namespace Lab9_3_4.Serializers
{
    public abstract class MySerializer
    {
        public abstract void Write<T>(T obj, string filePath);
        public abstract T Read<T>(string filePath);
    }
}

