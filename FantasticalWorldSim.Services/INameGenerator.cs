namespace FantasticalWorldSim.Services
{
    public interface INameGenerator
    {
        string GenerateFirstName(Gender? gender = null, bool? useRealName = null);
        string GenerateLastName(bool? useRealName);
    }
}