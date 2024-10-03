using System;

namespace ConsoleApp.RequestDispatcher.Dispatchers;

public class StupidDispatcher : IDispatcher
{
    public void Dispatch(int digit)
    {
        if (digit == 0)
        {
            UseCase0Logic();
        }
        else if (digit == 1)
        {
            UseCase1Logic();
        }
        else if (digit == 2)
        {
            UseCase2Logic();
        }
        else if (digit == 3)
        {
            UseCase3Logic();
        }
        else if (digit == 4)
        {
            UseCase4Logic();
        }
        else if (digit == 5)
        {
            UseCase5Logic();
        }
        else if (digit == 6)
        {
            UseCase6Logic();
        }
        else if (digit == 7)
        {
            UseCase7Logic();
        }
        else if (digit == 8)
        {
            UseCase8Logic();
        }
        else if (digit == 9)
        {
            UseCase9Logic();
        }
    }

    private static void UseCase0Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 0");
    }

    private static void UseCase1Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 1");
    }

    private static void UseCase2Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 2");
    }

    private static void UseCase3Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 3");
    }

    private static void UseCase4Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 4");
    }

    private static void UseCase5Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 5");
    }

    private static void UseCase6Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 6");
    }

    private static void UseCase7Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 7");
    }

    private static void UseCase8Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 8");
    }

    private static void UseCase9Logic()
    {
        Console.WriteLine("Executing Use Case Logic. Use Case: 9");
    }
}