using FantasticalWorldSim.Model;

namespace FantasticalWorldSim.Gui.Services
{
    public interface IFileSaver
    {
        World ReadWorld();
        void WriteWorld(World world);
    }
}