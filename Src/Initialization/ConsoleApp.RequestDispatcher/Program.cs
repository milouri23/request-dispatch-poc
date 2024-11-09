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
        // RunStupidDispatcher();
        RunStupidDispatcherWithUseCasesInjection();
    }

    private static void RunStupidDispatcher()
    {
        ServiceProvider serviceProvider = new ServiceCollection()
                    .AddSingleton<IRandomDigitService, RandomDigitService>()
                    .AddDispatcher<StupidDispatcher>()
                    .AddConsoleLoop<DigitGreeterIteration>()
                    .BuildServiceProvider();

        var app = serviceProvider.GetRequiredService<ConsoleLoopApplication>();
        app.Run();
    }

    private static void RunStupidDispatcherWithUseCasesInjection()
    {
        var serviceProvider = new ServiceCollection()
                    .AddUseCases()
                    .AddDispatcher<StupidDispatcherUseCasesInjection>()
                    .AddSingleton<IRandomDigitService, RandomDigitService>()
                    .AddConsoleLoop<DigitGreeterIteration>()
                    .BuildServiceProvider();

        var app = serviceProvider.GetRequiredService<ConsoleLoopApplication>();
        app.Run();
    }
}