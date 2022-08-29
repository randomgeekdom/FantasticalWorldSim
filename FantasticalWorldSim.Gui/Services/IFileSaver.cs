namespace FantasticalWorldSim.Gui.Services
{
    public interface IFileSaver
    {
        string ReadTextFile();
        void WriteTextFile(string text);
    }
}