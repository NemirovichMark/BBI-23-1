
using System.IO;
using ProtoBuf;

namespace Lab7_1.SerializeHelper
{
    internal class BinSerializerHelper: SerializerHelper
    {
        public override void SerializeTo<T>(T obj, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Serializer.Serialize(fs, obj);
            }
        }
        public override T DeserializeFrom<T>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                return Serializer.Deserialize<T>(fs);
            }
        }
    }
}
