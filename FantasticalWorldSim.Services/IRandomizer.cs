namespace FantasticalWorldSim.Services
{
    public interface IRandomizer
    {
        bool GetRandomBool(); 
        Gender GetRandomGender();
    }
}