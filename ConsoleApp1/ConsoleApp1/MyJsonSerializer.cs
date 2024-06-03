using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class MyJsonSerializer : MySerializer
    {
        public override void Write<GameCatalog>(GameCatalog catalog, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<GameCatalog>(fs, catalog);
            }
        }
        public override GameCatalog Read<GameCatalog>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Console.WriteLine(path);
                return (GameCatalog)JsonSerializer.Deserialize<GameCatalog>(fs);
            }
        }
    }

}
