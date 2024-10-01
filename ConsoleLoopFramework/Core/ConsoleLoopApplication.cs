using System;

namespace ConsoleLoopFramework.Core
{
    /// <summary>
    /// Represents the application that runs a console loop executing iterations.
    /// </summary>
    public class ConsoleLoopApplication
    {
        private readonly IIteration _iteration;

        public ConsoleLoopApplication(IIteration iteration)
        {
            _iteration = iteration;
        }

        public void Run()
        {
            ConsoleKey key;

            do
            {
                try
                {
                    _iteration.Execute();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                // Application Logic
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue, or any other key to exit.");
                key = Console.ReadKey(true).Key;
                Console.WriteLine();
            } while (ShouldContinue(key));

            OnExit();
        }

        protected virtual bool ShouldContinue(ConsoleKey key)
        {
            return key == ConsoleKey.Enter;
        }

        protected virtual void OnExit()
        {
            Console.WriteLine("Thank you for using the application!");
        }
    }
}