using FantasticalWorldSim.Services;

namespace FantasticalWorldSim.Model
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
    }
}