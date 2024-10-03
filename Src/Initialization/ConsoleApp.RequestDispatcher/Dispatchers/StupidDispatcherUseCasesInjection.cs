using ConsoleApp.RequestDispatcher.UseCases;

namespace ConsoleApp.RequestDispatcher.Dispatchers
{
    public class StupidDispatcherUseCasesInjection : IDispatcher
    {
        private readonly IUseCase0 _useCase0;
        private readonly IUseCase1 _useCase1;
        private readonly IUseCase2 _useCase2;
        private readonly IUseCase3 _useCase3;
        private readonly IUseCase4 _useCase4;
        private readonly IUseCase5 _useCase5;
        private readonly IUseCase6 _useCase6;
        private readonly IUseCase7 _useCase7;
        private readonly IUseCase8 _useCase8;
        private readonly IUseCase9 _useCase9;

        public StupidDispatcherUseCasesInjection(
            IUseCase0 useCase0,
            IUseCase1 useCase1,
            IUseCase2 useCase2,
            IUseCase3 useCase3,
            IUseCase4 useCase4,
            IUseCase5 useCase5,
            IUseCase6 useCase6,
            IUseCase7 useCase7,
            IUseCase8 useCase8,
            IUseCase9 useCase9
            )
        {
            _useCase0 = useCase0;
            _useCase1 = useCase1;
            _useCase2 = useCase2;
            _useCase3 = useCase3;
            _useCase4 = useCase4;
            _useCase5 = useCase5;
            _useCase6 = useCase6;
            _useCase7 = useCase7;
            _useCase8 = useCase8;
            _useCase9 = useCase9;
        }

        public void Dispatch(int digit)
        {
            if (digit == 0)
            {
                _useCase0.Execute();
            }
            else if (digit == 1)
            {
                _useCase1.Execute();
            }
            else if (digit == 2)
            {
                _useCase2.Execute();
            }
            else if (digit == 3)
            {
                _useCase3.Execute();
            }
            else if (digit == 4)
            {
                _useCase4.Execute();
            }
            else if (digit == 5)
            {
                _useCase5.Execute();
            }
            else if (digit == 6)
            {
                _useCase6.Execute();
            }
            else if (digit == 7)
            {
                _useCase7.Execute();
            }
            else if (digit == 8)
            {
                _useCase8.Execute();
            }
            else if (digit == 9)
            {
                _useCase9.Execute();
            }
        }
    }
}