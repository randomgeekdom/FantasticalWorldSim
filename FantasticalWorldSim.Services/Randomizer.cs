using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticalWorldSim.Services
{
    public class Randomizer : IRandomizer
    {
        private readonly Random random = new();
        public bool GetRandomBool()
        {
            return random.Next() % 2 == 0;
        }

        public Gender GetRandomGender()
        {
            return this.GetRandomBool() ? Gender.Male : Gender.Female;
        }
    }
}
