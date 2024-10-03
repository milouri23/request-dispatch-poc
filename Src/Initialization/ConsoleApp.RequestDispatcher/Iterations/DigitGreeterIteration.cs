using ConsoleApp.RequestDispatcher.Dispatchers;
using ConsoleApp.RequestDispatcher.Services;
using ConsoleLoopFramework.Core;
using System;

namespace ConsoleApp.RequestDispatcher.Iterations;

public class DigitGreeterIteration : IIteration
{
    private readonly IRandomDigitService _randomDigitService;
    private readonly IDispatcher _dispatcher;

    public DigitGreeterIteration(IRandomDigitService randomDigitService, IDispatcher dispatcher)
    {
        _randomDigitService = randomDigitService;
        _dispatcher = dispatcher;
    }

    public void Execute()
    {
        int randomDigit = _randomDigitService.Generate();
        Console.WriteLine($"Hello Digit: {randomDigit}");

        _dispatcher.Dispatch(randomDigit);
    }
}