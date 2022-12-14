using FantasticalWorldSim.Services.Extensions;
using RandomNameGeneratorLibrary;

namespace FantasticalWorldSim.Services
{
    public class NameGenerator : INameGenerator
    {
        private readonly Mudless.NameGenerator.NameGenerator fantasyNameGenerator;
        private readonly PersonNameGenerator realNameGenerator;
        private readonly Random randomizer;

        public NameGenerator()
        {
            this.fantasyNameGenerator = new Mudless.NameGenerator.NameGenerator();
            this.realNameGenerator = new PersonNameGenerator();
            this.randomizer = new Random();

        }
        public string GenerateFirstName(Gender? gender = null, bool? useRealName = null)
        {
            var getRealPerson = useRealName ?? this.randomizer.NextBool();
            var nameGender = gender ?? (this.randomizer.NextBool() ? Gender.Male : Gender.Female);

            if (!getRealPerson)
            {
                return this.fantasyNameGenerator.Generate();
            }
            else if (nameGender == Gender.Male)
            {
                return this.realNameGenerator.GenerateRandomMaleFirstName();
            }
            else
            {
                return this.realNameGenerator.GenerateRandomFemaleFirstName();
            }
        }

        public string GenerateLastName(bool? useRealName)
        {
            var getRealPerson = useRealName ?? this.randomizer.NextBool();

            if (!getRealPerson)
            {
                return this.fantasyNameGenerator.Generate();
            }
            else
            {
                return this.realNameGenerator.GenerateRandomLastName();
            }
        }
    }
}