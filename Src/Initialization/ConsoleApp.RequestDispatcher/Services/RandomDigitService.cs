using System;

namespace ConsoleApp.RequestDispatcher.Services;

public class RandomDigitService : IRandomDigitService
{
    private readonly Random _rnd = new();

    public int Generate() => _rnd.Next(0, 10);
}