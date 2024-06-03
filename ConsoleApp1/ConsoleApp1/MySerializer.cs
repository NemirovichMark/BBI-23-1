using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class MySerializer
    {
        public abstract void Write<GameCatalog>(GameCatalog catalog, string fileName);
        public abstract GameCatalog Read<GameCatalog>(string path);

    }
}
