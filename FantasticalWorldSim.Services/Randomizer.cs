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

        public T GetRandomElement<T>(IEnumerable<T> set)
        {
            return set.OrderBy(x => Guid.NewGuid()).First();
        }

        public Gender GetRandomGender()
        {
            return this.GetRandomBool() ? Gender.Male : Gender.Female;
        }

        public int GetRandomInteger(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
