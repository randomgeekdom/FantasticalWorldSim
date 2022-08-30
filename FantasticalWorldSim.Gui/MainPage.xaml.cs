using FantasticalWorldSim.Gui.Services;
using FantasticalWorldSim.Model.Geography;

namespace FantasticalWorldSim.Gui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public World World { get; }

        public MainPage(IFileSaver fileSaver)
        {
            this.World = fileSaver.ReadWorld();
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            FileSaver fileSaver = new FileSaver();
            fileSaver.WriteWorld(this.World);
            var result = fileSaver.ReadWorld();
        }
    }
}