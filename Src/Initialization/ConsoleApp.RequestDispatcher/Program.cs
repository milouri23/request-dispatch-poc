using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp.RequestDispatcher;

public class Program
{
    private readonly IBusinessLogic _businessLogic;

    public Program(IBusinessLogic businessLogic)
    {
        _businessLogic = businessLogic;
    }

    public void Run()
    {
        ConsoleKey key;
        do
        {
            // Business Logic
            _businessLogic.Execute();

            // Application Logic
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue, or any other key to exit.");
            key = Console.ReadKey(true).Key;
            Console.WriteLine();
        } while (key == ConsoleKey.Enter);
    }

    public static void Main()
    {
        // Setup Dependency Injection
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IRandomDigitService, RandomDigitService>()
            .AddSingleton<IBusinessLogic, BusinessLogic>()
            .AddSingleton<Program>()
            .BuildServiceProvider();

        // Resolve and Run Program
        serviceProvider.GetRequiredService<Program>().Run();
    }
}

public interface IBusinessLogic
{
    void Execute();
}

public class BusinessLogic : IBusinessLogic
{
    private readonly IRandomDigitService _randomDigitService;

    public BusinessLogic(IRandomDigitService randomDigitService)
    {
        _randomDigitService = randomDigitService;
    }

    public void Execute()
    {
        int randomDigit = _randomDigitService.Generate();
        Console.WriteLine($"Hello Digit: {randomDigit}");
    }
}

public interface IRandomDigitService
{
    int Generate();
}

public class RandomDigitService : IRandomDigitService
{
    private readonly Random _rnd = new();

    public int Generate() => _rnd.Next(0, 10);
}