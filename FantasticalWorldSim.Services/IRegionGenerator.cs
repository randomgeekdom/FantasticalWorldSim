using FantasticalWorldSim.Model.Geography;

namespace FantasticalWorldSim.Services
{
    public interface IRegionGenerator
    {
        Region GenerateRegion(int x = 0, int y = 0, IEnumerable<Region>? neighboringRegions = null);
    }
}