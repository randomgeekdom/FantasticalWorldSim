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

        public T GetRandomElement<T>(IEnumerable<T> args)
        {
            return args.ElementAt(random.Next(0, args.Count()));
        }
    }
}