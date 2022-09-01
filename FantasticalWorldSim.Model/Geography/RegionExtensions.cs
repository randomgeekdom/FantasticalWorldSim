using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticalWorldSim.Model.Geography
{
    public static class RegionExtensions
    {
        public const string Polar = "Polar";
        public const string Continental = "Continental";
        public const string Temperate = "Temperate";
        public const string Dry = "Dry";
        public const string Tropical = "Tropical";

        public static string GetClimate(this Region region)
        {
            if (region.Climate < 100)
            {
                return Polar;
            }
            else if (region.Climate >= 100 && region.Climate < 200)
            {
                return Continental;
            }
            else if (region.Climate >= 200 && region.Climate < 300)
            {
                return Temperate;
            }
            else if (region.Climate >= 300 && region.Climate < 400)
            {
                return Dry;
            }
            else
            {
                return Tropical;
            }
        }
    }
}
