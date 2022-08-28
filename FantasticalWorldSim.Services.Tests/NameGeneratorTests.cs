namespace FantasticalWorldSim.Services.Tests
{
    public class NameGeneratorTests
    {
        private readonly NameGenerator sut = new NameGenerator();
        
        [Theory]
        [InlineData(null, null)]
        [InlineData(Gender.Male, null)]
        [InlineData(Gender.Female, null)]
        [InlineData(null, true)]
        [InlineData(Gender.Male, true)]
        [InlineData(Gender.Female, true)]
        [InlineData(null, false)]
        [InlineData(Gender.Male, false)]
        [InlineData(Gender.Female, false)]
        public void GenerateFirstNameGeneratesFirstName(Gender? gender, bool? useRealName)
        {
            var name = sut.GenerateFirstName(gender, useRealName);
            Assert.NotNull(name);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(true)]
        [InlineData(false)]
        public void GenerateLastNameGeneratesLastName(bool? useRealName)
        {
            var name = sut.GenerateLastName(useRealName);
            Assert.NotNull(name);
        }
    }
}