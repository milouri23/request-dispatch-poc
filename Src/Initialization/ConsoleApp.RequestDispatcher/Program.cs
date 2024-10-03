using ConsoleApp.RequestDispatcher.Dispatchers;
using ConsoleApp.RequestDispatcher.Extensions;
using ConsoleApp.RequestDispatcher.Iterations;
using ConsoleApp.RequestDispatcher.Services;
using ConsoleLoopFramework.Core;
using ConsoleLoopFramework.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp.RequestDispatcher;

public static class Program
{
    public static void Main()
    {
        using var serviceProvider = new ServiceCollection()
            .AddSingleton<IRandomDigitService, RandomDigitService>()
            .AddDispatcher<StupidDispatcher>()
            .AddConsoleLoop<DigitGreeterIteration>()
            .BuildServiceProvider();

        var app = serviceProvider.GetRequiredService<ConsoleLoopApplication>();
        app.Run();
    }
}