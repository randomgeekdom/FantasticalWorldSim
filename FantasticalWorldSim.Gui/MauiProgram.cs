using FantasticalWorldSim.Gui.Services;
using FantasticalWorldSim.Services;

namespace FantasticalWorldSim.Gui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<IFileSaver, FileSaver>();

            builder.Services.AddTransient<IRandomizer, Randomizer>();
            builder.Services.AddTransient<INameGenerator, NameGenerator>();
            builder.Services.AddTransient<IPersonGenerator, PersonGenerator>();

            return builder.Build();
        }
    }
}