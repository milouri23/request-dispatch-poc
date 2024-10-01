using ConsoleApp.RequestDispatcher.Services;
using ConsoleLoopFramework.Core;
using System;

namespace ConsoleApp.RequestDispatcher.Iterations;

public class DigitGreeterIteration : IIteration
{
    private readonly IRandomDigitService _randomDigitService;

    public DigitGreeterIteration(IRandomDigitService randomDigitService)
    {
        _randomDigitService = randomDigitService;
    }

    public void Execute()
    {
        int randomDigit = _randomDigitService.Generate();
        Console.WriteLine($"Hello Digit: {randomDigit}");
    }
}