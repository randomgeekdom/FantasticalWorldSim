namespace FantasticalWorldSim.Services
{
    public class RandomInteractionService : IInteractionService
    {
        private readonly IRandomizer randomizer;

        public RandomInteractionService(IRandomizer randomizer)
        {
            this.randomizer = randomizer;
        }

        public T GetOption<T>(string prompt, params T[] args)
        {
            return this.randomizer.GetRandomElement<T>(args);
        }

        public string? GetText(string prompt)
        {
            return null;
        }
    }
}
