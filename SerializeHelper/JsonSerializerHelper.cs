
using System.Text.Json;
using System.IO;

namespace Lab7_1.SerializeHelper
{
    public class JsonSerializerHelper : SerializerHelper
    {
        public override void SerializeTo<T>(T obj, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, obj);
            }
        }
        public override T DeserializeFrom<T>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<T>(fs);
            }
        }
    }
}
