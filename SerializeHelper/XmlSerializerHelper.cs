
using System.IO;
using System.Xml.Serialization;

namespace Lab7_1.SerializeHelper
{
    public class XmlSerializerHelper : SerializerHelper
    {
        public override void SerializeTo<T>(T obj, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                new XmlSerializer(typeof(T)).Serialize(fs, obj);
            }
        }

        public override T DeserializeFrom<T>(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return (T)new XmlSerializer(typeof(T)).Deserialize(fs);
            }
        }
    }
}



