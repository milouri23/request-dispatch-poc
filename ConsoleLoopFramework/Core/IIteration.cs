namespace ConsoleLoopFramework.Core
{
    /// <summary>
    /// Defines the interface for an iteration to be executed in the console loop.
    /// </summary>
    public interface IIteration
    {
        /// <summary>
        /// Executes the iteration logic.
        /// </summary>
        void Execute();
    }
}