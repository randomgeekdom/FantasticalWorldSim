using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticalWorldSim.Services.Tests
{
    public class PersonGeneratorTests
    {
        private PersonGenerator sut;
        private Mock<INameGenerator> nameGenerator;
        private Mock<IRandomizer> randomizer;
        private Mock<IInteractionService> interactionService;

        public PersonGeneratorTests()
        {
            nameGenerator = new Mock<INameGenerator>();
            randomizer = new Mock<IRandomizer>();
            interactionService = new Mock<IInteractionService>();

            sut = new PersonGenerator(nameGenerator.Object, randomizer.Object, interactionService.Object);
        }

        [Fact]
        public void GeneratePersonGeneratesNamesAndGender()
        {
            var firstName = "First";
            var lastName = "Last";
            var gender = Gender.Female;

            this.nameGenerator.Setup(x => x.GenerateFirstName(It.IsAny<Gender?>(), It.IsAny<bool?>())).Returns(firstName);
            this.nameGenerator.Setup(x => x.GenerateLastName(It.IsAny<bool?>())).Returns(lastName);
            this.interactionService.Setup(x => x.GetOption<Gender>(It.IsAny<string>(), It.IsAny<Gender[]>())).Returns(gender);

            var person = this.sut.BirthPerson();

            Assert.Equal(firstName, person.FirstName);
            Assert.Equal(lastName, person.LastName);
            Assert.Equal(gender, person.Gender);
        }
    }
}
