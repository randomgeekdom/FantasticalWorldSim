// See https://aka.ms/new-console-template for more information

using FantasticalWorldSim.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services
            .AddTransient<INameGenerator, NameGenerator>()
            .AddTransient<IRandomizer, Randomizer>()
            .AddTransient<IPersonGenerator, PersonGenerator>())
    .Build();



// Use this for stuff -> host.Services.GetService<INameGenerator>()

Console.WriteLine("Hello, World!");
