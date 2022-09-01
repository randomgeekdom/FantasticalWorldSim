using FantasticalWorldSim.Model.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticalWorldSim.Services
{
    public class RegionGenerator : IRegionGenerator
    {
        private readonly IRandomizer randomizer;
        private readonly INameGenerator nameGenerator;

        public RegionGenerator(IRandomizer randomizer, INameGenerator nameGenerator)
        {
            this.randomizer = randomizer;
            this.nameGenerator = nameGenerator;
        }

        public Region GenerateRegion(int x = 0, int y = 0, IEnumerable<Region>? neighboringRegions = null)
        {
            var averageClimate = neighboringRegions == null
                ? 250
                : (int)neighboringRegions.Average(x => x.Climate);

            var region = new Region
            {
                X = x,
                Y = y,
                Climate = this.randomizer.GetRandomInteger(averageClimate - 10, averageClimate + 10)
            };

            region.Name = GetNameByClimate(region);

            return region;
        }

        private string GetNameByClimate(Region region)
        {
            var climateType = region.GetClimate();

            var baseName = this.randomizer.GetRandomBool()
                ? this.nameGenerator.GenerateLastName()
                : this.nameGenerator.GenerateFirstName();


            var baseList = new List<string>
            {
                "Flatlands",
                "Hills",
                "Lowlands",
                "Mountains",
                "Plateau"
            };

            switch (climateType)
            {
                case RegionExtensions.Polar:
                    baseList.Add("Frostlands");
                    baseList.Add("Snowfields");
                    baseList.Add("Tundra");
                    break;
                case RegionExtensions.Continental:
                    baseList.Add("Forest");
                    baseList.Add("Woods");
                    break;
                case RegionExtensions.Temperate:
                    baseList.Add("Forest");
                    baseList.Add("Plains");
                    baseList.Add("Woods");
                    break;
                case RegionExtensions.Dry:
                    baseList.Add("Desert");
                    baseList.Add("Savannah");
                    baseList.Add("Plains");
                    break;
                case RegionExtensions.Tropical:
                    baseList.Add("Bog");
                    baseList.Add("Jungle");
                    baseList.Add("Marshes");
                    baseList.Add("Rainforest");
                    baseList.Add("Swamplands");
                    break;
            }

            return $"{baseName} {this.randomizer.GetRandomElement(baseList)}";
        }
    }
}
