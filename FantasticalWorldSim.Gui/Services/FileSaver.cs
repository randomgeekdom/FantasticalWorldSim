using FantasticalWorldSim.Model.Geography;
using Newtonsoft.Json;
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

        public World ReadWorld()
        {
            if (File.Exists(file))
            {
                return JsonConvert.DeserializeObject<World>(File.ReadAllText(file));
            }
            else
            {
                var world = new World();
                this.WriteWorld(world);
                return world;
            }
        }

        public void WriteWorld(World world)
        {
            File.WriteAllText(file, JsonConvert.SerializeObject(world));
        }
    }
}
