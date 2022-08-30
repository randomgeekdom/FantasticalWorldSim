namespace FantasticalWorldSim.Services
{
    public interface IRandomizer
    {
        bool GetRandomBool();
        T GetRandomElement<T>(IEnumerable<T> args);
    }
}