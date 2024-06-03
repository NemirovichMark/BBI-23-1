using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyXmlSerializer : MySerializer
    {
        public override void Write<GameCatalog>(GameCatalog catalog, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var temp = new XmlSerializer(typeof(GameCatalog));
                temp.Serialize(fs, catalog);
            }
        }
        public override GameCatalog Read<GameCatalog>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var temp = new XmlSerializer(typeof(GameCatalog));
                return (GameCatalog)temp.Deserialize(fs);
            }
        }
    }

}
