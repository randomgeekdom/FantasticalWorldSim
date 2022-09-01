using FantasticalWorldSim.Model.Geography;

namespace FantasticalWorldSim.Gui.Services
{
    public interface IFileSaver
    {
        World ReadWorld();
        void WriteWorld(World world);
    }
}