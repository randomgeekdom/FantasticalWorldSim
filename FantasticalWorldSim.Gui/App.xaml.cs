using FantasticalWorldSim.Gui.Services;

namespace FantasticalWorldSim.Gui
{
    public partial class App : Application
    {
        public App(AppShell appShell)
        {
            InitializeComponent();

            MainPage = appShell;
        }
    }
}