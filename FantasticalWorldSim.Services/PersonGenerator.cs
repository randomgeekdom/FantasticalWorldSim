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
        private readonly IInteractionService interactionService;

        public PersonGenerator(INameGenerator nameGenerator, IRandomizer randomizer, IInteractionService interactionService)
        {
            this.nameGenerator = nameGenerator;
            this.randomizer = randomizer;
            this.interactionService = interactionService;
        }

        public Person BirthPerson()
        {
            var gender = this.interactionService.GetOption("Gender", Gender.Male, Gender.Female) ;
            return new Person
            {
                FirstName = this.interactionService.GetText("First Name") ?? nameGenerator.GenerateFirstName(gender),
                LastName = this.interactionService.GetText("Last Name") ?? nameGenerator.GenerateLastName(),
                Gender = gender,
            };
        }
    }
}
