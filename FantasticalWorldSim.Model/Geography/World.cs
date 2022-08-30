using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticalWorldSim.Model.Geography
{
    public class World
    {
        public string Name { get; set; } = "My World";
        public List<Person> People { get; set; } = new List<Person>();
    }
}
