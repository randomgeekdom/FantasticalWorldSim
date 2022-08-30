using FantasticalWorldSim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticalWorldSim.Services
{
    public class PersonGenerator : IPersonGenerator
    {
        private readonly INameGenerator nameGenerator;
        private readonly IRandomizer randomizer;

        public PersonGenerator(INameGenerator nameGenerator, IRandomizer randomizer)
        {
            this.nameGenerator = nameGenerator;
            this.randomizer = randomizer;
        }

        public Person BirthPerson()
        {
            var gender = this.randomizer.GetRandomGender();
            return new Person
            {
                FirstName = nameGenerator.GenerateFirstName(gender),
                LastName = nameGenerator.GenerateLastName(),
                Gender = gender,
            };
        }
    }
}
