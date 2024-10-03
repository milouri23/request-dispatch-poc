using System;

namespace ConsoleApp.RequestDispatcher.UseCases
{
    public class UseCase1 : IUseCase1
    {
        public void Execute()
        {
            Console.WriteLine("Executing Use Case Logic. Use Case: 1");
        }
    }
}