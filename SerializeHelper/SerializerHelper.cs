

namespace Lab7_1.SerializeHelper
{
    public abstract class SerializerHelper
    {
        // вместо T будет подставляться нужный тип, который мы передаем из main
        public abstract void SerializeTo<T>(T obj, string filePath);
        // вместо T будет подставляться нужный тип, который мы хотим получить в main
        public abstract T DeserializeFrom<T>(string filePath);
    }
}
