using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticalWorldSim.Gui.Services
{
    public class FileSaver : IFileSaver
    {
        private readonly string file = Path.Combine(FileSystem.Current.AppDataDirectory, "world.world");

        public string ReadTextFile()
        {
            return File.ReadAllText(file);
        }

        public void WriteTextFile(string text)
        {
            File.WriteAllText(file, text);
        }
    }
}
