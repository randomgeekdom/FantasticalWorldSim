namespace FantasticalWorldSim.Services
{
    public interface IRandomizer
    {
        bool GetRandomBool(); 
        Gender GetRandomGender();
        T GetRandomElement<T>(IEnumerable<T> set);
        int GetRandomInteger(int min, int max);
    }
}